Public Class frmMain
    Dim BarsWFPath As String = ""
    Dim CurrentDirectory As String = System.IO.Directory.GetCurrentDirectory()
    Dim BarsWFSave As Boolean = False
    Dim BarsWFSavePath As String = BarsWFPath.Substring(0, BarsWFPath.LastIndexOf("\") + 1) & "barswf.save"
    Dim ProcessID As Integer = 0

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Static BarsWFSSE264, BarsWFSSE232, BarsWFCUDA64, BarsWFCUDA32, BarsWFBrook64, BarsWFBrook32 As String
        BarsWFSSE264 = "BarsWF_SSE2_x64.exe"
        BarsWFSSE232 = "BarsWF_SSE2_x32.exe"
        BarsWFCUDA64 = "barswf_cuda_x64.exe"
        BarsWFCUDA32 = "barswf_cuda_x32.exe"
        BarsWFBrook64 = "BarsWF_Brook_x64.exe"
        BarsWFBrook32 = "BarsWF_Brook_x32.exe"

        If PathOK(BarsWFSSE264) Then
            BarsWFPath = CurrentDirectory & "\" & BarsWFSSE264
        End If
        If PathOK(BarsWFSSE232) Then
            BarsWFPath = CurrentDirectory & "\" & BarsWFSSE232
        End If
        If PathOK(BarsWFCUDA64) Then
            BarsWFPath = CurrentDirectory & "\" & BarsWFCUDA64
        End If
        If PathOK(BarsWFCUDA32) Then
            BarsWFPath = CurrentDirectory & "\" & BarsWFCUDA32
        End If
        If PathOK(BarsWFBrook64) Then
            BarsWFPath = CurrentDirectory & "\" & BarsWFBrook64
        End If
        If PathOK(BarsWFBrook32) Then
            BarsWFPath = CurrentDirectory & "\" & BarsWFBrook32
        End If
        tbxPathtoEXE.Text = BarsWFPath
        'tbxHash.Text = "098f6bcd4621d373cade4e832627b4f6"
        tmrCheckThings.Start()
    End Sub

    Private Sub tmrCheckThings_Tick(sender As Object, e As EventArgs) Handles tmrCheckThings.Tick
        tbxPathtoEXE.Text = BarsWFPath
        If tbxPathtoEXE.Text = "" Then
            grpStep2.Enabled = False
            grpStep3.Enabled = False
        Else
            If System.IO.File.Exists(tbxPathtoEXE.Text) Then
                grpStep2.Enabled = True
                If System.IO.File.Exists(BarsWFPath.Substring(0, BarsWFPath.LastIndexOf("\") + 1) & "barswf.save") Then
                    rdoContinue.Enabled = True
                    BarsWFSave = True
                Else
                    rdoContinue.Checked = False
                    rdoContinue.Enabled = False
                End If
                If rdoContinue.Checked Or (tbxHash.Text <> "" And _
                                           (chkLower.Checked Or chkUpper.Checked Or _
                                            chkNumbers.Checked Or chkSpecials.Checked Or _
                                           (chkInclude.Checked And tbxSpecials.Text <> "") Or _
                                           (chkHex.Checked And tbxHex.Text <> ""))) Then
                    grpStep3.Enabled = True
                Else
                    grpStep3.Enabled = False
                End If
            Else
                grpStep2.Enabled = False
                grpStep3.Enabled = False
            End If
        End If
        If chkInclude.Checked Then
            tbxSpecials.Enabled = True
        Else
            tbxSpecials.Enabled = False
        End If
        If chkHex.Checked Then
            tbxHex.Enabled = True
        Else
            tbxHex.Enabled = False
        End If
        If BarsWFStillRunning() Then
            btnStart.Enabled = False
        Else
            btnStart.Enabled = True
        End If
        ShellStringForTextbox()
    End Sub

    Private Function BarsWFStillRunning() As Boolean
        Dim running() As Process
        running = Process.GetProcesses
        For Each procs As Process In running
            If procs.Id = ProcessID Then
                Return True
            Else
                Return False
            End If
        Next
    End Function

    Private Sub ShellStringForTextbox()
        Try
            tbxShellString.Text = ShellString().Substring(ShellString().LastIndexOf("\"), ShellString().Length - ShellString().LastIndexOf("\"))
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnChangePath_Click(sender As Object, e As EventArgs) Handles btnChangePath.Click
        If OpenBarsWFexe.ShowDialog = Windows.Forms.DialogResult.OK Then
            BarsWFPath = OpenBarsWFexe.FileName
        End If
    End Sub

    Private Function PathOK(ByVal path As String) As Boolean
        If IO.File.Exists(path) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub rdoContinue_CheckedChanged(sender As Object, e As EventArgs) Handles rdoContinue.CheckedChanged
        ClickState(False)
    End Sub
    Private Sub rdoNewHash_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNewHash.CheckedChanged
        ClickState(True)
    End Sub

    Private Sub ClickState(ByVal onoroff As Boolean)
        If onoroff Then
            panControls.Enabled = True
        Else
            panControls.Enabled = False
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If rdoNewHash.Checked And BarsWFSave Then
            If MsgBox("There is a 'barswf.save' file in the selected directory." & vbNewLine _
                      & "Are you sure you want to start BarsWF with a new hash?", MsgBoxStyle.YesNo, _
                      "Sure?") = MsgBoxResult.Yes Then
                ProcessID = Shell(ShellString(), AppWinStyle.NormalFocus)
            Else
                rdoContinue.Checked = True
            End If
        Else
            ProcessID = Shell(ShellString(), AppWinStyle.NormalFocus)
        End If
    End Sub

    Private Function ShellString() As String
        If rdoContinue.Checked Then
            Return (BarsWFPath & " -r")
        Else
            Dim StringInParts As String = ""
            Dim Charset As String = ""

            'Hash
            StringInParts &= "-h " & tbxHash.Text & " "

            'Minimal password length
            If (Int(tbxLength.Text) > 15) Or (Int(tbxLength.Text) < 0) Or tbxLength.Text = "" Then
                tbxLength.Text = "0"
            End If
            If tbxLength.Text <> "0" Then
                StringInParts &= "-min_len " & Int(tbxLength.Text) & " "
            End If

            'Charset
            If chkLower.Checked Then
                Charset &= "a"
            End If
            If chkUpper.Checked Then
                Charset &= "A"
            End If
            If chkNumbers.Checked Then
                Charset &= "0"
            End If
            If chkSpecials.Checked Then
                Charset &= "~"
            End If
            If Charset <> "" Then
                StringInParts &= "-c " & Charset & " "
            End If

            'Special chars to include
            If chkInclude.Checked And tbxSpecials.Text <> "" Then
                StringInParts &= "-C """ & tbxSpecials.Text & """ "
            End If

            'Special chars in HEX to include
            If chkHex.Checked And tbxHex.Text <> "" Then
                StringInParts &= "-X """ & tbxHex.Text & """ "
            End If

            'Return whole term
            Return BarsWFPath & " " & StringInParts
        End If
    End Function

End Class
