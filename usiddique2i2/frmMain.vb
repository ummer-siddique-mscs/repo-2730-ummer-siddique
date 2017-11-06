' Name:         Exercise 2 I 
' Purpose:      Manipulates Strings
' Programmer:   Ummer Siddique on 11/05/2017
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: Insert
        Dim strWord As String = txt03RemoveInsert.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03RemoveInsert.Text = strWord

        '#04: Substring
        Dim strItem As String = txt04Substring.Text
        Dim strcolor As String
        strcolor = strItem.Substring(2, 4)
        lbl04Substring.Text = strcolor

        '#05a: Length
        Dim strLength As String = txt05aLength.Text
        Dim intNumChars As Integer
        intNumChars = strLength.Length
        lbl5aLength.Text = intNumChars.ToString("f0")

        '#05b: Trim
        Dim strTrim As String
        strTrim = txt05bTrim.Text.Trim
        lbl05bTrim.Text = strTrim

        '#05c: Remove/Insert
        Dim strRemoveInsert As String
        strRemoveInsert = txt05cRemoveInsert.Text
        strRemoveInsert = strRemoveInsert.Remove(1, 1)
        strRemoveInsert = strRemoveInsert.Insert(1, "rit")
        lbl05cRemoveInsert.Text = strRemoveInsert


        '#05d: Insert
        Dim strInsert As String
        strInsert = txt05dInsert.Text
        strInsert = strInsert.Insert(0, "Mon")
        lbl05dInsert.Text = strInsert

        '#05e: Pad
        Dim strPay As String
        strPay = txt05ePad.Text
        strPay = strPay.PadLeft(10, "*"c)
        lbl05ePad.Text = strPay

        '#06: Remove
        Dim strRemove As String
        strRemove = txt06Remove.Text
        strRemove = strRemove.Remove(1, 1)
        strRemove = strRemove.Remove(4, 1)
        lbl06Remove.Text = strRemove

        '#07: Contains
        Dim strContains As String
        strContains = txt07Contains.Text
        If strContains.ToUpper.Contains("JEFFERSON STREET") Then
            lbl07Contains.Text = "Jefferson Street"
        Else
            lbl07Contains.Text = "Jeff St not Found"
        End If


        '#12: Len / Remove
        Dim strLenghthRemove As String
        Dim intLastTwoChars As Integer
        Dim dblTaxRate As Double
        Dim dblLengthRemove As Double
        Const intSalesAmount As Integer = 1000
        strLenghthRemove = txt12LenRemove.Text
        intLastTwoChars = strLenghthRemove.Length - 2
        strLenghthRemove = strLenghthRemove.Remove(intLastTwoChars)
        Double.TryParse(strLenghthRemove, dblLengthRemove)

        dblTaxRate = (dblLengthRemove / 100) * intSalesAmount
        lbl12LenRemove.Text = dblTaxRate.ToString("f0")

        '#13: Like
        Dim strLike As String
        Dim intNumCharacters As Integer
        strLike = txt13Like.Text
        intNumCharacters = strLike.Length
        If intNumCharacters = 5 Then
            If strLike Like "605##" Then
                lbl13Like.Text = "$25 Shipping Charge"
            ElseIf strLike Like "606##" Then
                lbl13Like.Text = "$30 Shipping Charge"
            Else
                lbl13Like.Text = "Invalid Zip Code"
            End If
        End If

        If intNumCharacters <> 5 Then
            lbl13Like.Text = "Invalid Zip Code"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
