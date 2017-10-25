
'Name: Chapter 4 If Statements and Message Boxes
'Purpose: Currency, Tea, Electric, Quotient
'Programmer: Ummer Siddique - 10-24-2017


Option Infer Off
Option Strict On
Option Explicit On


Public Class frmMain
    Private Sub btnConvertEqual_Click(sender As Object, e As EventArgs) Handles btnConvertEqual.Click
        'Convert American dollar to Euro, British pound and the South African Rand
        Const dblEURO_RATE As Double = 0.85
        Const dblPOUND_RATE As Double = 0.76
        Const dblRAND_RATE As Double = 13.89
        Dim dblAMDOLLAR As Double
        Dim dblEURO As Double
        Dim dblPOUND As Double
        Dim dblRAND As Double


        'Display message box if no American currency is entered in text box
        If txtAmDollar.Text = String.Empty Then
            MessageBox.Show("Please enter the amount of American dollars", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Double.TryParse(txtAmDollar.Text, dblAMDOLLAR)

            dblEURO = dblAMDOLLAR * dblEURO_RATE
            dblPOUND = dblAMDOLLAR * dblPOUND_RATE
            dblRAND = dblAMDOLLAR * dblRAND_RATE

            lblEuro.Text = "€" & dblEURO.ToString("F")
            lblBritishPound.Text = "£" & dblPOUND.ToString("F")
            lblSARand.Text = "R" & dblRAND.ToString("F")

            txtAmDollar.Focus()

        End If



    End Sub


    Private Sub ClearCurrencyLabels_TextChanged(sender As Object, e As EventArgs) Handles txtAmDollar.TextChanged
        lblEuro.Text = String.Empty
        lblBritishPound.Text = String.Empty
        lblSARand.Text = String.Empty

        txtAmDollar.Focus()
    End Sub



    Private Sub btnNE_Click(sender As Object, e As EventArgs) Handles btnNotEqual.Click


        'Convert American dollar to Euro, British pound and the South African Rand
        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89
        Dim dblAMDOLLAR As Double
        Dim dblEURO As Double
        Dim dblPOUND As Double
        Dim dblRAND As Double


        If txtAmDollar.Text <> String.Empty Then
            Double.TryParse(txtAmDollar.Text, dblAMDOLLAR)

            dblEURO = dblAMDOLLAR * dblEURO_RATE
            dblPOUND = dblAMDOLLAR * dblPOUND_RATE
            dblRAND = dblAMDOLLAR * dblRAND_RATE

            lblEuro.Text = "€" & dblEURO.ToString("F")
            lblBritishPound.Text = "£" & dblPOUND.ToString("F")
            lblSARand.Text = "R" & dblRAND.ToString("F")

            txtAmDollar.Focus()

        Else
            MessageBox.Show("Please enter the amount of American dollars", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnCalculateTeaTime_Click(sender As Object, e As EventArgs) Handles btnCalculateTeaTime.Click
        Dim dlgR As DialogResult
        Const dblSHIPPING As Double = 15
        Dim dblPOUNDS As Double
        Dim dblPRICE As Double
        Dim dblTOTAL As Double

        Double.TryParse(txtPounds.Text, dblPOUNDS)
        Double.TryParse(txtPricePerPound.Text, dblPRICE)

        dblTOTAL = dblPOUNDS * dblPRICE


        dlgR = MessageBox.Show("Add shipping charge?", "Shipping", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

        If dlgR = DialogResult.Yes Then
            lblTotalPricebyPounds.Text = (dblSHIPPING + dblTOTAL).ToString("C2")

            txtPounds.Focus()

        ElseIf dlgR = DialogResult.No Then
            lblTotalPricebyPounds.Text = dblTOTAL.ToString("C2")

            txtPounds.Focus()

        ElseIf dlgR = DialogResult.Cancel Then
            txtPounds.Text = String.Empty
            txtPricePerPound.Text = String.Empty
            lblTotalPricebyPounds.Text = String.Empty

            txtPounds.Focus()

        End If

        txtPounds.Focus()


    End Sub


    Private Sub ClearTextBoxandLabels_TextChanged(sender As Object, e As EventArgs) Handles txtPounds.TextChanged, txtPricePerPound.TextChanged

        lblTotalPricebyPounds.Text = String.Empty
    End Sub



    Private Sub btnCalculateElectricBill_Click(sender As Object, e As EventArgs) Handles btnCalculateElectricBill.Click
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

            lblMonthlybill.Text = dblMONTHLYBILL.ToString("C2")

        End If

        txtPrevious.Focus()

    End Sub


    Private Sub ClearElectricBillLabels_TextChanged(sender As Object, e As EventArgs) Handles txtPrevious.TextChanged, txtCurrent.TextChanged
        lblMonthlybill.Text = String.Empty
    End Sub

    Private Sub btnCalculateQuotient_Click(sender As Object, e As EventArgs) Handles btnCalculateQuotient.Click
        Dim dblFIRST As Double
        Dim dblSECOND As Double
        Dim dblQUOTIENT As Double

        Double.TryParse(txtFirst.Text, dblFIRST)
        Double.TryParse(txtSecond.Text, dblSECOND)


        If txtFirst.Text = "0" OrElse txtSecond.Text = "0" Then
            MessageBox.Show("Cannot be divided by 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


        ElseIf dblFIRST < dblSECOND Then
            Dim dblTEMP As Double
            dblTEMP = dblFIRST
            dblFIRST = dblSECOND
            dblSECOND = dblTEMP

        End If

        dblQUOTIENT = dblFIRST / dblSECOND

        lblQuotient.Text = dblQUOTIENT.ToString("F")

        txtFirst.Focus()



    End Sub


    Private Sub ClearCalculateQuotient_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged, txtSecond.TextChanged
        lblQuotient.Text = String.Empty
    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmDollar.Text = String.Empty
        txtPrevious.Text = String.Empty
        txtCurrent.Text = String.Empty
        txtFirst.Text = String.Empty
        txtSecond.Text = String.Empty
        txtPounds.Text = String.Empty
        txtPricePerPound.Text = String.Empty
        lblEuro.Text = String.Empty
        lblBritishPound.Text = String.Empty
        lblSARand.Text = String.Empty
        lblTotalPricebyPounds.Text = String.Empty
        lblMonthlybill.Text = String.Empty
        lblQuotient.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
