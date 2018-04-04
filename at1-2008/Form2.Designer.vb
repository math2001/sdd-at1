<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.txtRangeMin = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ckbxRandomOperator = New System.Windows.Forms.CheckBox
        Me.cmbxOperator = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtRangeMax = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtRangeMin
        '
        Me.txtRangeMin.Location = New System.Drawing.Point(156, 82)
        Me.txtRangeMin.Name = "txtRangeMin"
        Me.txtRangeMin.Size = New System.Drawing.Size(31, 20)
        Me.txtRangeMin.TabIndex = 3
        Me.txtRangeMin.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Random number between"
        '
        'ckbxRandomOperator
        '
        Me.ckbxRandomOperator.AutoSize = True
        Me.ckbxRandomOperator.Checked = True
        Me.ckbxRandomOperator.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbxRandomOperator.Location = New System.Drawing.Point(130, 50)
        Me.ckbxRandomOperator.Name = "ckbxRandomOperator"
        Me.ckbxRandomOperator.Size = New System.Drawing.Size(66, 17)
        Me.ckbxRandomOperator.TabIndex = 2
        Me.ckbxRandomOperator.Text = "Random"
        Me.ckbxRandomOperator.UseVisualStyleBackColor = True
        '
        'cmbxOperator
        '
        Me.cmbxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxOperator.Enabled = False
        Me.cmbxOperator.FormattingEnabled = True
        Me.cmbxOperator.Items.AddRange(New Object() {"+", "-", "*", "/"})
        Me.cmbxOperator.Location = New System.Drawing.Point(130, 14)
        Me.cmbxOperator.Name = "cmbxOperator"
        Me.cmbxOperator.Size = New System.Drawing.Size(75, 21)
        Me.cmbxOperator.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Operator:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(197, 124)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 12
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtRangeMax
        '
        Me.txtRangeMax.Location = New System.Drawing.Point(224, 82)
        Me.txtRangeMax.Name = "txtRangeMax"
        Me.txtRangeMax.Size = New System.Drawing.Size(31, 20)
        Me.txtRangeMax.TabIndex = 4
        Me.txtRangeMax.Text = "12"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "and"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(116, 124)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(35, 124)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(284, 167)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRangeMax)
        Me.Controls.Add(Me.txtRangeMin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ckbxRandomOperator)
        Me.Controls.Add(Me.cmbxOperator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmOptions"
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRangeMin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ckbxRandomOperator As System.Windows.Forms.CheckBox
    Friend WithEvents cmbxOperator As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtRangeMax As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
