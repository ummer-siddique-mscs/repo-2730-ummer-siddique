' Name:         Chapter 6, Counting Loops, 5 Versions and Input-Controlled Loops
' Programmer:   Ummer Siddique on 11/06/2017
Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub pretestDoWhileButton_Click(sender As Object, e As EventArgs) Handles pretestDoWhileButton.Click
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub pretestDoUntilButton_Click(sender As Object, e As EventArgs) Handles pretestDoUntilButton.Click
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub posttestLoopWhileButton_Click(sender As Object, e As EventArgs) Handles posttestLoopWhileButton.Click
        lblEven.Text = "Posttest Loop While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop While i <= 20
    End Sub

    Private Sub posttestLoopUntilButton_Click(sender As Object, e As EventArgs) Handles posttestLoopUntilButton.Click
        lblEven.Text = "Posttest Loop Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i > 20
    End Sub



    Private Sub forLoopButton_Click(sender As Object, e As EventArgs) Handles forLoopButton.Click
        lblEven.Text = "Pretest For" & ControlChars.NewLine
        For i As Integer = 2 To 20 Step 2
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
        Next i
    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'calculates average
        Const strPROMPT As String =
            "Enter a Number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' Enter Numbers in Input Box to calculate Average and Count
        strNum = InputBox(strPROMPT, strTITLE, "0")

        ' *** Begin loop here: repeat as long as input is not empty
        Do While strNum <> String.Empty


            'convert the input to a number
            Int32.TryParse(strNum, intNum)


            'display the input in the text box
            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            'update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' ***Update control variable
            strNum = InputBox(strPROMPT, strTITLE, "0")
            ' *** End loop here
        Loop
        lblCount.Text = intCount.ToString
        'verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If

    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles btnSumLoopUntil.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        'calculates average
        Const strPROMPT As String =
            "Enter a Number. " &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' Enter Numbers in Input Box to calculate Average and Count
        strNum = InputBox(strPROMPT, strTITLE, "0")

        ' *** Begin loop here: repeat as long as input is not empty
        Do


            'convert the input to a number
            Int32.TryParse(strNum, intNum)


            'display the input in the text box
            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            'update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' ***Update control variable
            strNum = InputBox(strPROMPT, strTITLE, "0")
            ' *** End loop here
        Loop Until strNum = String.Empty

        lblCount.Text = intCount.ToString
        'verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If

    End Sub


    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty


        'For Next Loop Input Box
        Const strForLoopPROMPT As String =
            "Enter quantity of numbers "
        Const strForLoopTITLE As String = "Quantity"

        'calculates average
        Const strPROMPT As String =
            "Enter Number #"
        Const strTITLE As String = "Number Entry"
        Dim strForLoopNum As String
        Dim intForLoopNum As Integer
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double


        strForLoopNum = InputBox(strForLoopPROMPT, strForLoopTITLE, "0")
        'convert the For Loop input to a number

        Int32.TryParse(strForLoopNum, intForLoopNum)



        ' *** Begin loop here: 
        For i As Integer = 1 To intForLoopNum


            ' Enter Numbers in Input Box to calculate Average and Count
            strNum = InputBox(strPROMPT & i.ToString, strTITLE, "0")


            'convert the input to a number
            Int32.TryParse(strNum, intNum)


            'display the input in the text box
            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            'update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' *** End loop here
        Next i

        lblCount.Text = intCount.ToString
        'verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
