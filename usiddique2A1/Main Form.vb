' Name:         Bakery Project
' Purpose:      Calculates the total number of
'               items sold and the total sales
' Programmer:   Ummer Siddique on 10/08/2017

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    'class-level variable for storing salesclerk's name
    'Private strClerk As String

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales
        Const strPROMPT As String = "Salesclerk's name:"
        Const strTITLE As String = "Name Entry"
        Const decITEM_PRICE As Decimal = 0.5D
        Const decTAX_RATE As Decimal = 0.02D
        Dim intDonuts As Integer
        Dim intMuffins As Integer
        Dim intTotalItems As Integer
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotalSales As Decimal
        Static strClerk As String

        'assign name to class-level variable
        strClerk = InputBox(strPROMPT, strTITLE, strClerk)

        Integer.TryParse(txtDonuts.Text, intDonuts)
        Integer.TryParse(txtMuffins.Text, intMuffins)

        intTotalItems = intDonuts + intMuffins

        ' calculate the subtotal
        decSubtotal = intTotalItems * decITEM_PRICE

        'calculate the sales tax
        decSalesTax = decSubtotal * decTAX_RATE

        'calculate the total sales
        decTotalSales = decSubtotal + decSalesTax

        'display total amounts
        lblTotalItems.Text = Convert.ToString(intTotalItems)
        lblTotalSales.Text = decTotalSales.ToString("C2")

        ' display tax and salesclerk's name
        lblMsg.Text = "The sales tax was " &
            decSalesTax.ToString("C2") & "." &
            ControlChars.NewLine & strClerk


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
        ' send the focus to the Doughnuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'get salesclerk's name

        'Const strPROMPT As String = "Salesclerk's name:"
        'Const strTITLE As String = "Name Entry"
        'assign name to class-level variable
        'strClerk = InputBox(strPROMPT, strTITLE)

    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
            Handles txtDonuts.TextChanged, txtMuffins.TextChanged
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
    End Sub
End Class
