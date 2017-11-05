' Name:         Marshall Project
' Purpose:      Calculates Commission based on Sales
' Programmer:   Ummer Siddique on 11/04/2017



Public Class frmMain

    Private Sub btnCalc_IFThen_Click(sender As Object, e As EventArgs) Handles btnCalc_IFThen.Click
        'calculate commission using If-Then
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)
        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number format error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End If

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_NestedIf_Click(sender As Object, e As EventArgs) Handles btnCalc_NestedIf.Click
        'calculate commission using Nested If
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If boolSalesOK Then
            If dblSales >= 30000.0 Then
                dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
            Else
                If dblSales >= 6000.0 Then
                    dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
                Else
                    If dblSales >= 1.0 Then
                        dblCommissionOnly = dblSales * 0.1
                    Else
                        dblCommissionOnly = 0.0
                    End If
                End If
            End If
        End If

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number format error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnCalc_IfElseIf_Click(sender As Object, e As EventArgs) Handles btnCalc_IfElseIf.Click
        'calculate commission using If Else If
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If boolSalesOK Then
            If dblSales >= 30000.0 Then
                dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
            ElseIf dblSales >= 6000.0 Then
                dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
            ElseIf dblSales >= 1.0 Then
                dblCommissionOnly = dblSales * 0.1
            Else
                dblCommissionOnly = 0.0
            End If
        End If

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number format error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnCalc_SelectCase_Click(sender As Object, e As EventArgs) Handles btnCalc_SelectCase.Click
        'calculate commission using Select Case
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If boolSalesOK Then
            Select Case dblSales
                Case >= 30000.0
                    dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
                Case >= 6000.0
                    dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
                Case >= 1.0
                    dblCommissionOnly = dblSales * 0.1
                Case Else
                    dblCommissionOnly = 0.0
            End Select
        End If

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number format error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            ' cancel the key
            e.Handled = True
        End If
    End Sub


    Private Sub ClearCommission(sender As Object, e As EventArgs) Handles txtSales.TextChanged, chkMoreThan10.CheckedChanged, chkTravel.CheckedChanged
        'clear Lables
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty
    End Sub

End Class
