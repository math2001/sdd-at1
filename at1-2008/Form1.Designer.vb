<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblReply = New System.Windows.Forms.Label
        Me.btnCheck = New System.Windows.Forms.Button
        Me.lblOperator = New System.Windows.Forms.Label
        Me.txtRest = New System.Windows.Forms.TextBox
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblRest = New System.Windows.Forms.Label
        Me.lblOperand1 = New System.Windows.Forms.Label
        Me.lblOperand2 = New System.Windows.Forms.Label
        Me.lblSuccessRate = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblScore = New System.Windows.Forms.Label
        Me.lblStrike = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AT1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReply
        '
        Me.lblReply.Location = New System.Drawing.Point(2, 46)
        Me.lblReply.Name = "lblReply"
        Me.lblReply.Size = New System.Drawing.Size(281, 23)
        Me.lblReply.TabIndex = 0
        Me.lblReply.Text = "Doesn't everyone love maths?"
        Me.lblReply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCheck
        '
        Me.btnCheck.AllowDrop = True
        Me.btnCheck.Location = New System.Drawing.Point(101, 112)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 3
        Me.btnCheck.Text = "Check!"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblOperator
        '
        Me.lblOperator.AutoSize = True
        Me.lblOperator.Location = New System.Drawing.Point(45, 78)
        Me.lblOperator.Name = "lblOperator"
        Me.lblOperator.Size = New System.Drawing.Size(13, 13)
        Me.lblOperator.TabIndex = 4
        Me.lblOperator.Text = "+"
        '
        'txtRest
        '
        Me.txtRest.Enabled = False
        Me.txtRest.Location = New System.Drawing.Point(222, 75)
        Me.txtRest.Name = "txtRest"
        Me.txtRest.Size = New System.Drawing.Size(35, 20)
        Me.txtRest.TabIndex = 2
        Me.txtRest.Text = "0"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(108, 75)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(35, 20)
        Me.txtResult.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "="
        '
        'lblRest
        '
        Me.lblRest.AutoSize = True
        Me.lblRest.Enabled = False
        Me.lblRest.Location = New System.Drawing.Point(149, 78)
        Me.lblRest.Name = "lblRest"
        Me.lblRest.Size = New System.Drawing.Size(67, 13)
        Me.lblRest.TabIndex = 8
        Me.lblRest.Text = "with a rest of"
        '
        'lblOperand1
        '
        Me.lblOperand1.AutoSize = True
        Me.lblOperand1.Location = New System.Drawing.Point(20, 78)
        Me.lblOperand1.Name = "lblOperand1"
        Me.lblOperand1.Size = New System.Drawing.Size(19, 13)
        Me.lblOperand1.TabIndex = 10
        Me.lblOperand1.Text = "64"
        Me.lblOperand1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOperand2
        '
        Me.lblOperand2.AutoSize = True
        Me.lblOperand2.Location = New System.Drawing.Point(64, 78)
        Me.lblOperand2.Name = "lblOperand2"
        Me.lblOperand2.Size = New System.Drawing.Size(19, 13)
        Me.lblOperand2.TabIndex = 10
        Me.lblOperand2.Text = "64"
        Me.lblOperand2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSuccessRate
        '
        Me.lblSuccessRate.AutoSize = True
        Me.lblSuccessRate.Location = New System.Drawing.Point(167, 154)
        Me.lblSuccessRate.Name = "lblSuccessRate"
        Me.lblSuccessRate.Size = New System.Drawing.Size(21, 13)
        Me.lblSuccessRate.TabIndex = 12
        Me.lblSuccessRate.Text = "?%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Score:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(167, 203)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(13, 13)
        Me.lblScore.TabIndex = 12
        Me.lblScore.Text = "0"
        '
        'lblStrike
        '
        Me.lblStrike.AutoSize = True
        Me.lblStrike.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrike.Location = New System.Drawing.Point(167, 179)
        Me.lblStrike.Name = "lblStrike"
        Me.lblStrike.Size = New System.Drawing.Size(13, 13)
        Me.lblStrike.TabIndex = 12
        Me.lblStrike.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Current strike:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Average:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AT1ToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(277, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AT1ToolStripMenuItem
        '
        Me.AT1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.AT1ToolStripMenuItem.Name = "AT1ToolStripMenuItem"
        Me.AT1ToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.AT1ToolStripMenuItem.Text = "&File"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.HelpToolStripMenuItem1.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'frmAsk
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblStrike)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblOperand2)
        Me.Controls.Add(Me.lblSuccessRate)
        Me.Controls.Add(Me.lblOperand1)
        Me.Controls.Add(Me.lblRest)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblOperator)
        Me.Controls.Add(Me.txtRest)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.lblReply)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAsk"
        Me.Text = "  "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReply As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents lblOperator As System.Windows.Forms.Label
    Friend WithEvents txtRest As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblRest As System.Windows.Forms.Label
    Friend WithEvents lblOperand1 As System.Windows.Forms.Label
    Friend WithEvents lblOperand2 As System.Windows.Forms.Label
    Friend WithEvents lblSuccessRate As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblStrike As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AT1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
