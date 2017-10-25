'Name: Ch4 Lesson B, if statements, message boxes
'Purpose: Currency, Tea, Electric, Quotient
'Programmer" Ummer Siddique on 10/24/2017


Option Strict On
Option Explicit On
Option Infer Off


Public Class frmMain
    'This application converts American dollars to Euro, British Pound and South African Rand

    Private Sub btnConvertEqual_Click(sender As Object, e As EventArgs) Handles btnConvertEq.Click
        Const dblEURO_RATE As Double = 0.85
        Const dblPOUND_RATE As Double = 0.76
        Const dblRAND_RATE As Double = 13.75
        Dim dblAMDOLLAR As Double
        Dim dblEURO As Double
        Dim dblPOUND As Double
        Dim dblRAND As Double


        If txtAmDollar.Text = String.Empty Then
            MessageBox.Show("Please enter the number in American dollars", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Double.TryParse(txtAmDollar.Text, dblAMDOLLAR)

            dblEURO = dblAMDOLLAR * dblEURO_RATE
            dblPOUND = dblAMDOLLAR * dblPOUND_RATE
            dblRAND = dblAMDOLLAR * dblRAND_RATE

            lblEuro.Text = dblEURO.ToString("n2")
            lblPound.Text = dblPOUND.ToString("n2")
            lblRand.Text = dblRAND.ToString("n2")

        End If

    End Sub


    Private Sub btnConvertNE_Click(sender As Object, e As EventArgs) Handles btnConvertNE.Click

        Const dblEURO_RATE As Double = 0.85
        Const dblPOUND_RATE As Double = 0.76
        Const dblRAND_RATE As Double = 13.75
        Dim dblAMDOLLAR As Double
        Dim dblEURO As Double
        Dim dblPOUND As Double
        Dim dblRAND As Double

        If txtAmDollar.Text <> String.Empty Then
            Double.TryParse(txtAmDollar.Text, dblAMDOLLAR)

            dblEURO = dblAMDOLLAR * dblEURO_RATE
            dblPOUND = dblAMDOLLAR * dblPOUND_RATE
            dblRAND = dblAMDOLLAR * dblRAND_RATE

            lblEuro.Text = dblEURO.ToString("n2")
            lblPound.Text = dblPOUND.ToString("n2")
            lblRand.Text = dblRAND.ToString("n2")
        Else
            MessageBox.Show("Please enter the number in American dollars", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ClearCurrencyLabels_TextChanged(sender As Object, e As EventArgs) Handles txtAmDollar.TextChanged
        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        txtAmDollar.Focus()
    End Sub


    'This application allows the clerk to enter the number of pounds of tea ordered, the price per pound
    'and whether the customer should be charged $15 shippinh fee.

    Private Sub btnCalcTea_Click(sender As Object, e As EventArgs) Handles btnCalcTea.Click
        Dim dlgResult As DialogResult
        Const dblSHIPPING As Double = 15
        Dim dblPOUNDS As Double
        Dim dblPRICE As Double
        Dim dblTOTAL As Double

        Double.TryParse(txtPounds.Text, dblPOUNDS)
        Double.TryParse(txtPrice.Text, dblPRICE)

        dblTOTAL = dblPOUNDS * dblPRICE


        dlgResult = MessageBox.Show("Do you want to add shipping charge?", "Shipping", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgResult = DialogResult.Yes Then
            lblTotalDue.Text = (dblSHIPPING + dblTOTAL).ToString("C2")

        ElseIf dlgResult = DialogResult.No Then
            lblTotalDue.Text = dblTOTAL.ToString("C2")

        End If

        txtPounds.Focus()

    End Sub
    Private Sub ClearTextBoxandLabels_TextChanged(sender As Object, e As EventArgs) Handles txtPounds.TextChanged, txtPrice.TextChanged

        lblTotalDue.Text = String.Empty
    End Sub

    'This application calculates customer's monthly electric bill
    'If the current reading is less than the previous reading, it gives an error message

    Private Sub btnCalcElectric_Click(sender As Object, e As EventArgs) Handles btnCalcElectric.Click
        Const dblCHARGE As Double = 0.13
        Dim dblPREVIOUS As Double
        Dim dblCURRENT As Double
        Dim dblMONTHLYBILL As Double

        Double.TryParse(txtPrevious.Text, dblPREVIOUS)
        Double.TryParse(txtCurrent.Text, dblCURRENT)

        If txtCurrent.Text = String.Empty OrElse txtPrevious.Text = String.Empty OrElse dblCURRENT < dblPREVIOUS Then
            MessageBox.Show("The current reading must be greater than or equal to the previous reading.", "Triple County", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            dblMONTHLYBILL = (dblCURRENT - dblPREVIOUS) * dblCHARGE

            lblBill.Text = dblMONTHLYBILL.ToString("C2")

        End If

    End Sub


    Private Sub ClearElectricBillLabels_TextChanged(sender As Object, e As EventArgs) Handles txtPrevious.TextChanged, txtCurrent.TextChanged
        lblBill.Text = String.Empty
    End Sub

    'This application displays the result of dividing the larger of two numbers
    'and gives error message if the division is by 0

    Private Sub btnCalcQuot_Click(sender As Object, e As EventArgs) Handles btnCalcQuot.Click
        Dim dblFIRST As Double
        Dim dblSECOND As Double
        Dim dblQUOTIENT As Double

        Double.TryParse(txtNum1.Text, dblFIRST)
        Double.TryParse(txtNum2.Text, dblSECOND)


        If txtNum1.Text = "0" OrElse txtNum2.Text = "0" OrElse txtNum1.Text = String.Empty OrElse txtNum2.Text = String.Empty Then
            MessageBox.Show("Cannot divide by 0!", "Division by 0", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        ElseIf dblFIRST < dblSECOND Then
            Dim dblTEMP As Double
            dblTEMP = dblFIRST
            dblFIRST = dblSECOND
            dblSECOND = dblTEMP

        End If

        dblQUOTIENT = dblFIRST / dblSECOND

        lblQuotient.Text = dblQUOTIENT.ToString("F")

    End Sub


    Private Sub ClearCalculateQuotient_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged, txtNum2.TextChanged
        lblQuotient.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
