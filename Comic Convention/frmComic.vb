Public Class frmComic
    Private Sub frmComic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCostTickets.Text = ""
        txtGroup.Clear()
        txtGroup.Focus()
        radSuperhero.Checked = True
        radAutographs.Checked = False
        radConvention.Checked = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblCostTickets.Text = ""
        txtGroup.Clear()
        txtGroup.Focus()
        radSuperhero.Checked = True
        radAutographs.Checked = False
        radConvention.Checked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intGroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D

        If IsNumeric(txtGroup.Text) Then
            intGroup = Convert.ToInt32(txtGroup.Text)
            If intGroup > 0 And intGroup Then
                If radSuperhero.Checked Then
                    decRegistration = decSuperHero
                ElseIf radAutographs.Checked Then
                    decRegistration = decAutographs
                ElseIf radConvention.Checked Then
                    decRegistration = decConvention
                End If

                decTotalCost = (intGroup * decRegistration)
                lblCostTickets.Text = decTotalCost.ToString("C")
            Else
                MsgBox("Enter a positive number between 1 and 20", , "Invalid Number Error")
            End If
        Else
            MsgBox("Enter a reasonable number between 1 and 20", , "Invalid Number Error")
        End If
    End Sub
End Class
