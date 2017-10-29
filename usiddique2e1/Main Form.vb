'Name: Exercise 2e, AndAlso, OrElse
'Purpose: Calculate Shipping and commission using AndAlso/OrElse
'Programmer" Ummer Siddique on 10/29/2017


Option Strict On
Option Explicit On
Option Infer Off



Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculateAnd_Click(sender As Object, e As EventArgs) Handles btnCalculateAnd.Click
        Const dblShipping_Charge As Double = 9.0
        Const dblNo_Shipping_Charge As Double = 0.0
        Dim dblOrder As Double
        Dim strSavannah As String
        strSavannah = txtSavannah.Text
        Double.TryParse(txtOrder.Text, dblOrder)
        If strSavannah.ToUpper = "Y" AndAlso dblOrder >= 100 Then

            lblShipping.Text = dblNo_Shipping_Charge.ToString("c2")
        Else

            lblShipping.Text = dblShipping_Charge.ToString("c2")
        End If

    End Sub

    Private Sub btnCalculateOr_Click(sender As Object, e As EventArgs) Handles btnCalculateOr.Click
        Const dblShipping_Charge As Double = 9.0
        Const dblNo_Shipping_Charge As Double = 0.0
        Dim dblOrder As Double
        Dim strSavannah As String
        strSavannah = txtSavannah.Text
        Double.TryParse(txtOrder.Text, dblOrder)
        If strSavannah.ToUpper <> "Y" OrElse dblOrder < 100 Then
            lblShipping.Text = dblShipping_Charge.ToString("c2")

        Else
            lblShipping.Text = dblNo_Shipping_Charge.ToString("c2")
        End If

    End Sub

    Private Sub ClearShippingLabels(sender As Object, e As EventArgs) _
        Handles txtOrder.TextChanged, txtSavannah.TextChanged
        lblShipping.Text = String.Empty
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim dblSales As Double
        Dim dblCommission As Double
        Dim strId As String
        strId = txtID.Text.ToUpper
        Double.TryParse(txtSales.Text, dblSales)
        If (strId = "A1" OrElse
           strId = "B2" OrElse
           strId = "C3") AndAlso dblSales >= 25000 Then
            dblCommission = dblSales * 0.15
            lblCommission.Text = dblCommission.ToString("c2")

        Else
            dblCommission = dblSales * 0.12
            lblCommission.Text = dblCommission.ToString("c2")
        End If
    End Sub

    Private Sub btnNotEqual_Click(sender As Object, e As EventArgs) Handles btnNotEqual.Click
        Dim dblSales As Double
        Dim dblCommission As Double
        Dim strId As String
        strId = txtID.Text.ToUpper
        Double.TryParse(txtSales.Text, dblSales)
        If (strId <> "A1" AndAlso
           strId <> "B2" AndAlso
           strId <> "C3") OrElse dblSales < 25000 Then
            dblCommission = dblSales * 0.12
            lblCommission.Text = dblCommission.ToString("c2")
        Else

            dblCommission = dblSales * 0.15
            lblCommission.Text = dblCommission.ToString("c2")
        End If

    End Sub

    Private Sub ClearCommissionLabels(sender As Object, e As EventArgs) _
     Handles txtID.TextChanged, txtSales.TextChanged
        lblCommission.Text = String.Empty
    End Sub
End Class
