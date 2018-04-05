Public Class frmAsk

    Private score, currentStrike, totalQuestions, successQuestions As Integer
    Private operator_ As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        frmOptions.loadFromSettings()
        ask()
    End Sub

    Private Function choose(ByVal ParamArray elements() As Object)
        Dim rand As New Random
        Return elements(rand.Next(0, elements.Length))
    End Function

    Private Function getPositiveMessage(ByVal strike As Integer)
        If strike = 10 Then
            Return "Whoo! 10 in a row!"
        ElseIf strike = 100 Then
            Return "Are you cheating? :D"
        End If
        Return choose("Well done!", "Good answer!", "That's correct!", If(strike > 0, "An other one!", "Starting a strike!"))
    End Function

    Private Function getNegativeMessage(ByVal strike As Integer)
        If strike = -10 Then
            Return "That's not too good... Take your time"
        ElseIf strike = -100 Then
            Return "You do it wrong willingly, right?"
        End If
        Return choose("Oops...", "Hum... nah.", "Not quite...", "Nope. Give this one an other crack.")
    End Function

    Public Sub ask()
        operator_ = frmOptions.getOperator()

        lblOperand1.Text = frmOptions.getRndNumber()

        ' avoid division by 0
        Do
            lblOperand2.Text = frmOptions.getRndNumber()
        Loop While operator_ = "/" And lblOperand2.Text = "0"

        txtResult.Focus()
        txtResult.Text = ""
        txtRest.Text = "0"

        lblOperator.Text = operator_
        lblRest.Enabled = operator_ = "/"
        txtRest.Enabled = operator_ = "/"

    End Sub

    Private Sub setMessage(ByVal text As String, ByVal color As Color, Optional ByVal italic As Boolean = False)
        If italic Then
            lblReply.Font = New Font(lblReply.Font, FontStyle.Italic)
        End If
        lblReply.ForeColor = color
        lblReply.Text = text
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim operand1, operand2, actualResult, givenResult, actualRest, givenRest As Integer

        totalQuestions += 1

        operand1 = CInt(lblOperand1.Text)
        operand2 = CInt(lblOperand2.Text)

        actualRest = 0

        Select Case operator_
            Case "+"
                actualResult = operand1 + operand2
            Case "-"
                actualResult = operand1 - operand2
            Case "x"
                actualResult = operand1 * operand2
            Case "/"
                actualResult = operand1 \ operand2
                actualRest = operand1 Mod operand2
            Case Else
                setMessage("Internal bug: Unknown operator", Color.Red, True)
                Return
        End Select

        Try
            givenResult = CInt(txtResult.Text)
        Catch ex As Exception
            setMessage("Unvalid result: it should be a whole number, got '" & txtResult.Text + "' .", Color.Black)
            Return
        End Try

        Try
            givenRest = CInt(txtRest.Text)
        Catch ex As Exception
            setMessage("Unvalid rest: it should be a whole number, got '" & txtResult.Text + "' .", Color.Black)
            Return
        End Try

        ' givenRest is automatically set to 0 when asking a new question.
        If givenResult = actualResult And givenRest = actualRest Then
            If currentStrike < 0 Then
                currentStrike = 0
            Else
                currentStrike += 1
            End If
            successQuestions += 1
            setMessage(getPositiveMessage(currentStrike), Color.Green)
        Else
            setMessage("Oops... Wrong answer. ", Color.Red)
            If operator_ = "/" Then
                lblReply.Text += operand1 & " / " & operand2 & " = " & actualResult & " with a rest of " & actualRest
            Else
                lblReply.Text += operand1 & " " & operator_ & " " & operand2 & " = " & actualResult
            End If
            If currentStrike > 0 Then
                currentStrike = 0
            Else
                currentStrike -= 1
            End If

        End If

        ' current strike can be negative
        score += currentStrike

        ' update stats

        lblStrike.Text = currentStrike
        lblScore.Text = score

        ' set bold font when strike is different than 0
        If currentStrike = 0 Then
            lblStrike.Font = New Font(lblStrike.Font, New FontStyle())
        Else
            lblStrike.Font = New Font(lblStrike.Font, FontStyle.Bold)
        End If
        ' set the color
        If currentStrike < 0 Then
            lblStrike.ForeColor = Color.Red
        ElseIf currentStrike = 0 Then
            lblStrike.ForeColor = Color.Black
        Else
            lblStrike.ForeColor = Color.Green
        End If

        lblSuccessRate.Text = Math.Round(successQuestions / totalQuestions * 100, 2) & "%"

        ask()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        frmOptions.ShowDialog()
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        frmHelp.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Made by math2001 in march 2018", "About", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AT1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AT1ToolStripMenuItem.Click

    End Sub
End Class
