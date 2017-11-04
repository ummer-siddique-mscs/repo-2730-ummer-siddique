' Name:         Jetters Project
' Purpose:      Display the discount and total due
' Programmer:   Ummer Siddique on 11/04/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtPrice_Enter(sender As Object, e As EventArgs) Handles txtPrice.Enter
        txtPrice.SelectAll()
    End Sub

    Private Sub txtQuantity_Enter(sender As Object, e As EventArgs) Handles txtQuantity.Enter
        txtQuantity.SelectAll()
    End Sub

    Private Sub ClearLabel(sender As Object, e As EventArgs) Handles txtPrice.TextChanged, txtQuantity.TextChanged
        lblDiscount.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalcIf.Click
        ' calculate discount and total due using If

        Dim dblPrice As Double
        Dim intQuantity As Integer
        Dim dblRate As Double = 0.0
        Dim dblTotalWithoutDiscount As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Double.TryParse(txtPrice.Text, dblPrice)
        Integer.TryParse(txtQuantity.Text, intQuantity)

        If intQuantity > 0 AndAlso intQuantity <= 10 Then
            dblRate = 0.0
        End If

        If intQuantity > 10 AndAlso intQuantity <= 15 Then
            dblRate = 0.02
        End If


        If intQuantity > 15 AndAlso intQuantity <= 20 Then
            dblRate = 0.025
        End If

        If intQuantity > 20 Then
            dblRate = 0.03
        End If

        dblTotalWithoutDiscount = dblPrice * intQuantity
        dblDiscount = dblTotalWithoutDiscount * dblRate
        dblTotalDue = dblTotalWithoutDiscount - dblDiscount

        lblDiscount.Text = dblDiscount.ToString("C2")
        lblTotalDue.Text = dblTotalDue.ToString("C2")
    End Sub


    Private Sub btnCalcNestedIf_Click(sender As Object, e As EventArgs) Handles btnCalcNestedIf.Click
        ' calculate discount and total due using Nested If
        Dim dblPrice As Double
        Dim intQuantity As Integer
        Dim dblRate As Double = 0.0
        Dim dblTotalWithoutDiscount As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Double.TryParse(txtPrice.Text, dblPrice)
        Integer.TryParse(txtQuantity.Text, intQuantity)

        If intQuantity > 20 Then
            dblRate = 0.03
        Else
            If intQuantity > 15 Then
                dblRate = 0.025
            Else
                If intQuantity > 10 Then
                    dblRate = 0.02
                Else
                    dblRate = 0.0
                End If
            End If
        End If


        dblTotalWithoutDiscount = dblPrice * intQuantity
        dblDiscount = dblTotalWithoutDiscount * dblRate
        dblTotalDue = dblTotalWithoutDiscount - dblDiscount

        lblDiscount.Text = dblDiscount.ToString("C2")
        lblTotalDue.Text = dblTotalDue.ToString("C2")
    End Sub

    Private Sub btnCalcIfElseIf_Click(sender As Object, e As EventArgs) Handles btnCalcIfElseIf.Click
        ' calculate discount and total due using If-ElseIf
        Dim dblPrice As Double
        Dim intQuantity As Integer
        Dim dblRate As Double = 0.0
        Dim dblTotalWithoutDiscount As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Double.TryParse(txtPrice.Text, dblPrice)
        Integer.TryParse(txtQuantity.Text, intQuantity)

        If intQuantity > 20 Then
            dblRate = 0.03
        ElseIf intQuantity > 15 Then
            dblRate = 0.025
        ElseIf intQuantity > 10 Then
            dblRate = 0.02
        Else
            dblRate = 0.0
        End If

        dblTotalWithoutDiscount = dblPrice * intQuantity
        dblDiscount = dblTotalWithoutDiscount * dblRate
        dblTotalDue = dblTotalWithoutDiscount - dblDiscount

        lblDiscount.Text = dblDiscount.ToString("C2")
        lblTotalDue.Text = dblTotalDue.ToString("C2")
    End Sub

    Private Sub btnCalcSelect_Click(sender As Object, e As EventArgs) Handles btnCalcSelect.Click
        ' calculate discount and total due using Select
        Dim dblPrice As Double
        Dim intQuantity As Integer
        Dim dblRate As Double = 0.0
        Dim dblTotalWithoutDiscount As Double
        Dim dblDiscount As Double
        Dim dblTotalDue As Double

        Double.TryParse(txtPrice.Text, dblPrice)
        Integer.TryParse(txtQuantity.Text, intQuantity)

        Select Case intQuantity
            Case > 20
                dblRate = 0.03
            Case > 15
                dblRate = 0.025
            Case > 10
                dblRate = 0.02
            Case Else
                dblRate = 0.0
        End Select

        dblTotalWithoutDiscount = dblPrice * intQuantity
        dblDiscount = dblTotalWithoutDiscount * dblRate
        dblTotalDue = dblTotalWithoutDiscount - dblDiscount

        lblDiscount.Text = dblDiscount.ToString("C2")
        lblTotalDue.Text = dblTotalDue.ToString("C2")
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub
End Class
