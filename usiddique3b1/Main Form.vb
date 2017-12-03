' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   Ummer Siddique on 12/03/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Const dblTAXRATE As Double = 0.05
    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("Do loop:")
        Integer.TryParse(txtNumber.Text, number)
        'For loop
        count = 1
        Do While count <= 9
            product = number * count
            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
            'Add strOutput to ListBox
            lstMultTable.Items.Add(strOutput)
            count += 1
        Loop
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click

        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, number)
        'For loop
        For count = 1 To 9
            product = number * count
            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
            'Add strOutput to ListBox
            lstMultTable.Items.Add(strOutput)
        Next count
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        'Clear ListBox
        lstMultTable.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'load ListBox with text data:
        For index As Double = 1 To 4
            lstPrices.Items.Add(index.ToString("n2"))
        Next index
        'calculate pretax total:
        Dim dblPretaxtTotal As Double = 0
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Dim dblTax As Double
        Dim dblTotal As Double
        For index As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = index
            strSelectedItem = Convert.ToString(lstPrices.SelectedItem)
            Double.TryParse(strSelectedItem, dblSelectedPrice)
            dblPretaxtTotal = dblPretaxtTotal + dblSelectedPrice
        Next index
        dblTax = dblPretaxtTotal * dblTAXRATE
        dblTotal = dblPretaxtTotal + dblTax

        lblPreTaxTotal.Text = dblPretaxtTotal.ToString("n2")
        lblTax.Text = dblTax.ToString("n2")
        lblTotal.Text = dblTotal.ToString("n2")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim dblPrice As Double
        Dim strPrice As String
        Const strPROMPT As String =
         "Enter a Price. " &
         ControlChars.NewLine &
         "Valid prices: 1.00 to 9.99"
        Const strTITLE As String = "Price Entry"

        strPrice = InputBox(strPROMPT, strTITLE, "0.00")
        Double.TryParse(strPrice, dblPrice)
        Do While dblPrice < 1.0 OrElse dblPrice > 9.99
            strPrice = InputBox(strPROMPT, "Invalid Price", "0.00")
            Double.TryParse(strPrice, dblPrice)
        Loop
        'Add item to list
        lstPrices.Items.Add(dblPrice.ToString("n2"))
        'calculate pretax total:
        Dim dblPretaxtTotal As Double = 0
        Dim strSelectedItem As String
        Dim dblSelectedPrice As Double
        Dim dblTax As Double
        Dim dblTotal As Double
        For index As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = index
            strSelectedItem = Convert.ToString(lstPrices.SelectedItem)
            Double.TryParse(strSelectedItem, dblSelectedPrice)
            dblPretaxtTotal = dblPretaxtTotal + dblSelectedPrice
        Next index
        dblTax = dblPretaxtTotal * dblTAXRATE
        dblTotal = dblPretaxtTotal + dblTax

        lblPreTaxTotal.Text = dblPretaxtTotal.ToString("n2")
        lblTax.Text = dblTax.ToString("n2")
        lblTotal.Text = dblTotal.ToString("n2")
    End Sub

    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown
        ' delete item from the listbox of delete or backspace key is pressed
        If e.KeyValue = Keys.Delete OrElse e.KeyValue = Keys.Back Then
            'Delete item From list
            lstPrices.Items.Remove(lstPrices.SelectedItem)
            Dim dblPretaxtTotal As Double = 0
            Dim strSelectedItem As String
            Dim dblSelectedPrice As Double
            Dim dblTax As Double
            Dim dblTotal As Double
            For index As Integer = 0 To lstPrices.Items.Count - 1
                lstPrices.SelectedIndex = index
                strSelectedItem = Convert.ToString(lstPrices.SelectedItem)
                Double.TryParse(strSelectedItem, dblSelectedPrice)
                dblPretaxtTotal = dblPretaxtTotal + dblSelectedPrice
            Next index
            dblTax = dblPretaxtTotal * dblTAXRATE
            dblTotal = dblPretaxtTotal + dblTax

            lblPreTaxTotal.Text = dblPretaxtTotal.ToString("n2")
            lblTax.Text = dblTax.ToString("n2")
            lblTotal.Text = dblTotal.ToString("n2")
        Else
            ' cancel the key
            e.Handled = True
        End If
    End Sub
End Class
