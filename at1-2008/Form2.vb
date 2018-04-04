Public Class frmOptions

    Private Sub frmOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Public Sub loadFromSettings()
        ckbxRandomOperator.Checked = My.Settings.randomOperator
        cmbxOperator.SelectedIndex = cmbxOperator.Items.IndexOf(My.Settings.operator_)
        txtRangeMax.Text = My.Settings.rangeMax
        txtRangeMin.Text = My.Settings.rangeMin
    End Sub

    Private Sub saveToSettings()
        My.Settings.randomOperator = ckbxRandomOperator.Checked
        My.Settings.operator_ = cmbxOperator.Text
        My.Settings.rangeMax = txtRangeMax.Text
        My.Settings.rangeMin = txtRangeMin.Text
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If IsNumeric(txtRangeMax.Text) = False Or IsNumeric(txtRangeMin.Text) = False Then
            errorMessage("Invalid range number(s)", "Error")
            Return
        End If
        If Math.Abs(txtRangeMax.Text - txtRangeMin.Text) <= 2 Then
            errorMessage("Nah... Come on! Give yourself a bit of a challenge. Set a widder range.", "Lazy brain spotter")
            Return
        End If

        saveToSettings()
        Me.Close()
        frmAsk.ask()
    End Sub

    Private Sub ckbxRandomOperator_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbxRandomOperator.CheckedChanged
        cmbxOperator.Enabled = Not ckbxRandomOperator.Checked
    End Sub

    Private Sub errorMessage(ByVal text As String, ByVal title As String)
        MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Function getRndNumber()
        Return CInt(Math.Ceiling(Rnd() * (My.Settings.rangeMax - My.Settings.rangeMin) + My.Settings.rangeMin))
    End Function

    Public Function getOperator()
        If ckbxRandomOperator.Checked = True Then
            Return cmbxOperator.Items.Item(CInt(Math.Ceiling(Rnd() * cmbxOperator.Items.Count - 1)))
        End If
        Return cmbxOperator.Text
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        cmbxOperator.SelectedIndex = 0
        ckbxRandomOperator.Checked = True
        txtRangeMax.Text = 12
        txtRangeMin.Text = 0
    End Sub
End Class