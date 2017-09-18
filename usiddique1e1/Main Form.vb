'Name:          Richardson County Property Tax Project
'Purpose:       Calculate the property tax based on property's assessed value
'Programmer:    Ummer Siddique on 09/18/2017

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next property tax calculation
        txtAssessed.Text = String.Empty
        lblTax.Text = String.Empty
        ' send the focus to the Assessed Value box
        txtAssessed.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate annual property tax
        lblTax.Text = Val(txtAssessed.Text) * 0.015
        lblTax.Text = Format(lblTax.Text, "currency")
    End Sub
End Class
