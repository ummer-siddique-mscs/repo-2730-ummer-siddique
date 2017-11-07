' Name:         Chapter 8, String functions, list boxes
' Purpose:      #2: Interprets color code
'               #5: Sets proper upper/lower case
'               #6: Interprets shipping code
' Programmer:   Ummer Siddique on 11/06/2017
Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ItemNumbers_TextChanged(sender As Object, e As EventArgs) _
            Handles txtItem1.TextChanged, txtItem2.TextChanged, txtItem3.TextChanged, txtItem4.TextChanged, txtItem5.TextChanged
        lstColors.Items.Clear()
    End Sub

    Private Sub btnDisplayColor_Click(sender As Object, e As EventArgs) Handles btnDisplayColor.Click
        DisplayColor(txtItem1.Text)
        DisplayColor(txtItem2.Text)
        DisplayColor(txtItem3.Text)
        DisplayColor(txtItem4.Text)
        DisplayColor(txtItem5.Text)
    End Sub

    Private Sub DisplayColor(ByVal itemNum As String)
        Dim intNumChars As Integer
        Dim strColorCode As String
        intNumChars = itemNum.Length
        If intNumChars = 7 Then
            strColorCode = itemNum.ToUpper.Substring(3, 1)
            Select Case strColorCode
                Case = "B"
                    itemNum = "Blue"
                Case = "G"
                    itemNum = "Green"
                Case = "R"
                    itemNum = "Red"
                Case = "W"
                    itemNum = "White"
                Case Else
                    itemNum = "Invalid Entry"
            End Select
        Else
            itemNum = "Invalid Entry"
        End If
        lstColors.Items.Add(itemNum)
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblName.Text = String.Empty
    End Sub

    Private Sub btnDisplayDelivery_Click(sender As Object, e As EventArgs) Handles btnDisplayDelivery.Click
        DisplayDelivery(txtPartNum1.Text)
        DisplayDelivery(txtPartNum2.Text)
        DisplayDelivery(txtPartNum3.Text)
        DisplayDelivery(txtPartNum4.Text)
        DisplayDelivery(txtPartNum5.Text)
        DisplayDelivery(txtPartNum6.Text)
    End Sub

    Private Sub DisplayDelivery(ByVal partNum As String)
        Dim intNumCharacters As Integer
        Dim strDelivery As String
        intNumCharacters = partNum.Length
        If intNumCharacters > 2 AndAlso intNumCharacters < 5 Then
            strDelivery = partNum.ToUpper.Substring(2).Trim
            Select Case strDelivery
                Case = "MS"
                    partNum = "Mail Standard"
                Case = "MP"
                    partNum = "Mail Priority"
                Case = "FS"
                    partNum = "FedEx - Standard"
                Case = "FO"
                    partNum = "FedEx - Overnight"
                Case = "U"
                    partNum = "UPS"
                Case Else
                    partNum = "Invalid Entry"
            End Select
        Else
            partNum = "Invalid Entry"
        End If
        lstDelivery.Items.Add(partNum)
    End Sub

    Private Sub PartNum_TextChanged(sender As Object, e As EventArgs) _
            Handles txtPartNum1.TextChanged, txtPartNum2.TextChanged, txtPartNum3.TextChanged, txtPartNum4.TextChanged, txtPartNum5.TextChanged, txtPartNum6.TextChanged
        lstDelivery.Items.Clear()
    End Sub

    'btnProper_Click pseudocode:
    '1) Convert txtName to lower case, store in strName
    '2) Use strName.Substring() to get first character of strName, convert to upper case, store in strFirstChar
    '3) Remove first character of strName
    '4) Insert strFirstChar at beginning of strName
    '5) Use strName.IndexOf() to find the space character. Add 1 and store in index
    '6) Repeat steps 2 - 4 to remove/insert first letter of last name

    Private Sub btnProper_Click(sender As Object, e As EventArgs) Handles btnProper.Click
        Dim strname As String
        Dim intSpaceIndex As Integer
        Dim instLastNameIndex As Integer
        Dim strFirstCharofFirst As String
        Dim strFirstCharofLast As String
        strname = txtName.Text.ToLower
        intSpaceIndex = strname.IndexOf(" ")
        If intSpaceIndex <> -1 Then
            instLastNameIndex = intSpaceIndex + 1
            strFirstCharofFirst = strname.ToUpper.Substring(0, 1)
            strFirstCharofLast = strname.ToUpper.Substring(instLastNameIndex, 1)
            strname = strname.Remove(0, 1)
            strname = strname.Insert(0, strFirstCharofFirst)
            strname = strname.Remove(instLastNameIndex, 1)
            strname = strname.Insert(instLastNameIndex, strFirstCharofLast)
            lblName.Text = strname
        Else
            strFirstCharofFirst = strname.ToUpper.Substring(0, 1)
            strname = strname.Remove(0, 1)
            strname = strname.Insert(0, strFirstCharofFirst)
            lblName.Text = strname
        End If
    End Sub


End Class
