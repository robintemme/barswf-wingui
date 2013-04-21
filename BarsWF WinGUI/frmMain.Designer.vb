<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grpStep1 = New System.Windows.Forms.GroupBox()
        Me.btnChangePath = New System.Windows.Forms.Button()
        Me.tbxPathtoEXE = New System.Windows.Forms.TextBox()
        Me.grpStep2 = New System.Windows.Forms.GroupBox()
        Me.rdoNewHash = New System.Windows.Forms.RadioButton()
        Me.rdoContinue = New System.Windows.Forms.RadioButton()
        Me.panControls = New System.Windows.Forms.Panel()
        Me.tbxLength = New System.Windows.Forms.TextBox()
        Me.lblPWLength = New System.Windows.Forms.Label()
        Me.tbxHex = New System.Windows.Forms.TextBox()
        Me.chkHex = New System.Windows.Forms.CheckBox()
        Me.tbxSpecials = New System.Windows.Forms.TextBox()
        Me.chkSpecials = New System.Windows.Forms.CheckBox()
        Me.lblHash = New System.Windows.Forms.Label()
        Me.lblCharset = New System.Windows.Forms.Label()
        Me.tbxHash = New System.Windows.Forms.TextBox()
        Me.chkInclude = New System.Windows.Forms.CheckBox()
        Me.chkUpper = New System.Windows.Forms.CheckBox()
        Me.chkNumbers = New System.Windows.Forms.CheckBox()
        Me.chkLower = New System.Windows.Forms.CheckBox()
        Me.grpStep3 = New System.Windows.Forms.GroupBox()
        Me.tbxShellString = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.OpenBarsWFexe = New System.Windows.Forms.OpenFileDialog()
        Me.tmrCheckThings = New System.Windows.Forms.Timer(Me.components)
        Me.tip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpStep1.SuspendLayout()
        Me.grpStep2.SuspendLayout()
        Me.panControls.SuspendLayout()
        Me.grpStep3.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStep1
        '
        Me.grpStep1.Controls.Add(Me.btnChangePath)
        Me.grpStep1.Controls.Add(Me.tbxPathtoEXE)
        Me.grpStep1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpStep1.Location = New System.Drawing.Point(12, 12)
        Me.grpStep1.Name = "grpStep1"
        Me.grpStep1.Size = New System.Drawing.Size(479, 48)
        Me.grpStep1.TabIndex = 0
        Me.grpStep1.TabStop = False
        Me.grpStep1.Text = "Step 1: Getting Started (Path to BarsWF-exe)"
        '
        'btnChangePath
        '
        Me.btnChangePath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnChangePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePath.Image = CType(resources.GetObject("btnChangePath.Image"), System.Drawing.Image)
        Me.btnChangePath.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnChangePath.Location = New System.Drawing.Point(403, 12)
        Me.btnChangePath.Name = "btnChangePath"
        Me.btnChangePath.Size = New System.Drawing.Size(70, 30)
        Me.btnChangePath.TabIndex = 0
        Me.btnChangePath.Text = "Change"
        Me.btnChangePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChangePath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChangePath.UseVisualStyleBackColor = True
        '
        'tbxPathtoEXE
        '
        Me.tbxPathtoEXE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxPathtoEXE.Location = New System.Drawing.Point(6, 19)
        Me.tbxPathtoEXE.Name = "tbxPathtoEXE"
        Me.tbxPathtoEXE.ReadOnly = True
        Me.tbxPathtoEXE.Size = New System.Drawing.Size(391, 20)
        Me.tbxPathtoEXE.TabIndex = 9999
        Me.tbxPathtoEXE.TabStop = False
        '
        'grpStep2
        '
        Me.grpStep2.Controls.Add(Me.rdoNewHash)
        Me.grpStep2.Controls.Add(Me.rdoContinue)
        Me.grpStep2.Controls.Add(Me.panControls)
        Me.grpStep2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpStep2.Location = New System.Drawing.Point(12, 66)
        Me.grpStep2.Name = "grpStep2"
        Me.grpStep2.Size = New System.Drawing.Size(479, 122)
        Me.grpStep2.TabIndex = 1
        Me.grpStep2.TabStop = False
        Me.grpStep2.Text = "Step 2: Options"
        '
        'rdoNewHash
        '
        Me.rdoNewHash.AutoSize = True
        Me.rdoNewHash.Checked = True
        Me.rdoNewHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoNewHash.Location = New System.Drawing.Point(9, 19)
        Me.rdoNewHash.Name = "rdoNewHash"
        Me.rdoNewHash.Size = New System.Drawing.Size(100, 17)
        Me.rdoNewHash.TabIndex = 3
        Me.rdoNewHash.TabStop = True
        Me.rdoNewHash.Text = "Brute new Hash"
        Me.tip1.SetToolTip(Me.rdoNewHash, "Continue is only available if barswf.save exists in the selected directory.")
        Me.rdoNewHash.UseVisualStyleBackColor = True
        '
        'rdoContinue
        '
        Me.rdoContinue.AutoSize = True
        Me.rdoContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoContinue.Location = New System.Drawing.Point(324, 19)
        Me.rdoContinue.Name = "rdoContinue"
        Me.rdoContinue.Size = New System.Drawing.Size(149, 17)
        Me.rdoContinue.TabIndex = 4
        Me.rdoContinue.Text = "Continue from barswf.save"
        Me.tip1.SetToolTip(Me.rdoContinue, "Only available if barswf.save exists in the selected directory.")
        Me.rdoContinue.UseVisualStyleBackColor = True
        '
        'panControls
        '
        Me.panControls.Controls.Add(Me.tbxLength)
        Me.panControls.Controls.Add(Me.lblPWLength)
        Me.panControls.Controls.Add(Me.tbxHex)
        Me.panControls.Controls.Add(Me.chkHex)
        Me.panControls.Controls.Add(Me.tbxSpecials)
        Me.panControls.Controls.Add(Me.chkSpecials)
        Me.panControls.Controls.Add(Me.lblHash)
        Me.panControls.Controls.Add(Me.lblCharset)
        Me.panControls.Controls.Add(Me.tbxHash)
        Me.panControls.Controls.Add(Me.chkInclude)
        Me.panControls.Controls.Add(Me.chkUpper)
        Me.panControls.Controls.Add(Me.chkNumbers)
        Me.panControls.Controls.Add(Me.chkLower)
        Me.panControls.Location = New System.Drawing.Point(6, 42)
        Me.panControls.Name = "panControls"
        Me.panControls.Size = New System.Drawing.Size(467, 71)
        Me.panControls.TabIndex = 12
        '
        'tbxLength
        '
        Me.tbxLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxLength.Location = New System.Drawing.Point(448, 2)
        Me.tbxLength.Name = "tbxLength"
        Me.tbxLength.Size = New System.Drawing.Size(19, 20)
        Me.tbxLength.TabIndex = 15
        Me.tbxLength.TabStop = False
        Me.tbxLength.Text = "0"
        Me.tbxLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPWLength
        '
        Me.lblPWLength.AutoSize = True
        Me.lblPWLength.Location = New System.Drawing.Point(306, 4)
        Me.lblPWLength.Name = "lblPWLength"
        Me.lblPWLength.Size = New System.Drawing.Size(136, 13)
        Me.lblPWLength.TabIndex = 14
        Me.lblPWLength.Text = "Length (default: 0, max 15):"
        '
        'tbxHex
        '
        Me.tbxHex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxHex.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxHex.Location = New System.Drawing.Point(377, 51)
        Me.tbxHex.Name = "tbxHex"
        Me.tbxHex.Size = New System.Drawing.Size(90, 20)
        Me.tbxHex.TabIndex = 13
        Me.tbxHex.TabStop = False
        Me.tbxHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkHex
        '
        Me.chkHex.AutoSize = True
        Me.chkHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHex.Location = New System.Drawing.Point(256, 51)
        Me.chkHex.Name = "chkHex"
        Me.chkHex.Size = New System.Drawing.Size(115, 17)
        Me.chkHex.TabIndex = 12
        Me.chkHex.Text = "extra symbols (hex):"
        Me.chkHex.UseVisualStyleBackColor = True
        '
        'tbxSpecials
        '
        Me.tbxSpecials.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxSpecials.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxSpecials.Location = New System.Drawing.Point(148, 51)
        Me.tbxSpecials.Name = "tbxSpecials"
        Me.tbxSpecials.Size = New System.Drawing.Size(90, 20)
        Me.tbxSpecials.TabIndex = 11
        Me.tbxSpecials.TabStop = False
        Me.tbxSpecials.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkSpecials
        '
        Me.chkSpecials.AutoSize = True
        Me.chkSpecials.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkSpecials.Location = New System.Drawing.Point(340, 29)
        Me.chkSpecials.Name = "chkSpecials"
        Me.chkSpecials.Size = New System.Drawing.Size(112, 17)
        Me.chkSpecials.TabIndex = 10
        Me.chkSpecials.Text = "~ (special symbols)"
        Me.chkSpecials.UseVisualStyleBackColor = True
        '
        'lblHash
        '
        Me.lblHash.AutoSize = True
        Me.lblHash.Location = New System.Drawing.Point(12, 4)
        Me.lblHash.Name = "lblHash"
        Me.lblHash.Size = New System.Drawing.Size(35, 13)
        Me.lblHash.TabIndex = 2
        Me.lblHash.Text = "Hash:"
        '
        'lblCharset
        '
        Me.lblCharset.AutoSize = True
        Me.lblCharset.Location = New System.Drawing.Point(1, 29)
        Me.lblCharset.Name = "lblCharset"
        Me.lblCharset.Size = New System.Drawing.Size(46, 13)
        Me.lblCharset.TabIndex = 9
        Me.lblCharset.Text = "Charset:"
        '
        'tbxHash
        '
        Me.tbxHash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxHash.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tbxHash.Location = New System.Drawing.Point(53, 2)
        Me.tbxHash.Name = "tbxHash"
        Me.tbxHash.Size = New System.Drawing.Size(207, 20)
        Me.tbxHash.TabIndex = 1
        Me.tbxHash.TabStop = False
        Me.tbxHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkInclude
        '
        Me.chkInclude.AutoSize = True
        Me.chkInclude.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkInclude.Location = New System.Drawing.Point(53, 51)
        Me.chkInclude.Name = "chkInclude"
        Me.chkInclude.Size = New System.Drawing.Size(89, 17)
        Me.chkInclude.TabIndex = 8
        Me.chkInclude.Text = "extra symbols:"
        Me.chkInclude.UseVisualStyleBackColor = True
        '
        'chkUpper
        '
        Me.chkUpper.AutoSize = True
        Me.chkUpper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkUpper.Location = New System.Drawing.Point(53, 28)
        Me.chkUpper.Name = "chkUpper"
        Me.chkUpper.Size = New System.Drawing.Size(97, 17)
        Me.chkUpper.TabIndex = 5
        Me.chkUpper.Text = "A (upper letters)"
        Me.chkUpper.UseVisualStyleBackColor = True
        '
        'chkNumbers
        '
        Me.chkNumbers.AutoSize = True
        Me.chkNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkNumbers.Location = New System.Drawing.Point(256, 29)
        Me.chkNumbers.Name = "chkNumbers"
        Me.chkNumbers.Size = New System.Drawing.Size(78, 17)
        Me.chkNumbers.TabIndex = 7
        Me.chkNumbers.Text = "0 (numbers)"
        Me.chkNumbers.UseVisualStyleBackColor = True
        '
        'chkLower
        '
        Me.chkLower.AutoSize = True
        Me.chkLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkLower.Location = New System.Drawing.Point(156, 28)
        Me.chkLower.Name = "chkLower"
        Me.chkLower.Size = New System.Drawing.Size(94, 17)
        Me.chkLower.TabIndex = 6
        Me.chkLower.Text = "a (lower letters)"
        Me.chkLower.UseVisualStyleBackColor = True
        '
        'grpStep3
        '
        Me.grpStep3.Controls.Add(Me.tbxShellString)
        Me.grpStep3.Controls.Add(Me.btnStart)
        Me.grpStep3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpStep3.Location = New System.Drawing.Point(12, 194)
        Me.grpStep3.Name = "grpStep3"
        Me.grpStep3.Size = New System.Drawing.Size(479, 83)
        Me.grpStep3.TabIndex = 1
        Me.grpStep3.TabStop = False
        Me.grpStep3.Text = "Step 3: Brute!"
        '
        'tbxShellString
        '
        Me.tbxShellString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxShellString.Location = New System.Drawing.Point(6, 19)
        Me.tbxShellString.Name = "tbxShellString"
        Me.tbxShellString.ReadOnly = True
        Me.tbxShellString.Size = New System.Drawing.Size(464, 20)
        Me.tbxShellString.TabIndex = 10000
        Me.tbxShellString.TabStop = False
        Me.tip1.SetToolTip(Me.tbxShellString, "String to execute, please check before starting BarsWF.")
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Image = CType(resources.GetObject("btnStart.Image"), System.Drawing.Image)
        Me.btnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnStart.Location = New System.Drawing.Point(6, 45)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(464, 30)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Brute!"
        Me.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tip1.SetToolTip(Me.btnStart, "Make sure that the settings above are right before starting BarsWF.")
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'OpenBarsWFexe
        '
        Me.OpenBarsWFexe.Filter = "BarsWF-exe|*.exe"
        '
        'tmrCheckThings
        '
        Me.tmrCheckThings.Interval = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 284)
        Me.Controls.Add(Me.grpStep3)
        Me.Controls.Add(Me.grpStep2)
        Me.Controls.Add(Me.grpStep1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BarsWF - WinGUI - by Zwerch™"
        Me.grpStep1.ResumeLayout(False)
        Me.grpStep1.PerformLayout()
        Me.grpStep2.ResumeLayout(False)
        Me.grpStep2.PerformLayout()
        Me.panControls.ResumeLayout(False)
        Me.panControls.PerformLayout()
        Me.grpStep3.ResumeLayout(False)
        Me.grpStep3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpStep1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbxPathtoEXE As System.Windows.Forms.TextBox
    Friend WithEvents grpStep2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpStep3 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenBarsWFexe As System.Windows.Forms.OpenFileDialog
    Private WithEvents btnChangePath As System.Windows.Forms.Button
    Friend WithEvents rdoNewHash As System.Windows.Forms.RadioButton
    Friend WithEvents rdoContinue As System.Windows.Forms.RadioButton
    Friend WithEvents lblHash As System.Windows.Forms.Label
    Friend WithEvents tbxHash As System.Windows.Forms.TextBox
    Private WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents tbxSpecials As System.Windows.Forms.TextBox
    Friend WithEvents chkSpecials As System.Windows.Forms.CheckBox
    Friend WithEvents lblCharset As System.Windows.Forms.Label
    Friend WithEvents chkInclude As System.Windows.Forms.CheckBox
    Friend WithEvents chkNumbers As System.Windows.Forms.CheckBox
    Friend WithEvents chkLower As System.Windows.Forms.CheckBox
    Friend WithEvents chkUpper As System.Windows.Forms.CheckBox
    Friend WithEvents panControls As System.Windows.Forms.Panel
    Friend WithEvents tmrCheckThings As System.Windows.Forms.Timer
    Friend WithEvents tip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tbxHex As System.Windows.Forms.TextBox
    Friend WithEvents chkHex As System.Windows.Forms.CheckBox
    Friend WithEvents tbxShellString As System.Windows.Forms.TextBox
    Friend WithEvents tbxLength As System.Windows.Forms.TextBox
    Friend WithEvents lblPWLength As System.Windows.Forms.Label

End Class
