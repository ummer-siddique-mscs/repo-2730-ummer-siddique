'Name: Data Type Exercise
'Programmer" Ummer Siddique on 10/08/2017
Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1

    Private str1, str2, str3 As String
    Private byte1, byte2, byte3 As Byte
    Private short1, short2, short3 As Short
    Private integer1, integer2, integer3 As Integer
    Private long1, long2, long3 As Long
    Private single1, single2, single3 As Single
    Private double1, double2, double3 As Double
    Private decimal1, decimal2, decimal3 As Decimal
    Private date1, date2, date3 As DateTime
    Private timeSpan2 As TimeSpan

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        str1 = String.Empty
        str2 = String.Empty
        str3 = String.Empty
        byte1 = 0
        byte2 = 0
        byte3 = 0
        short1 = 0S
        short2 = 0S
        short3 = 0S
        integer1 = 0
        integer2 = 0
        integer3 = 0
        long1 = 0L
        long2 = 0L
        long3 = 0L
        single1 = 0.0F
        single2 = 0.0F
        single3 = 0.0F
        double1 = 0.0
        double2 = 0.0
        double3 = 0.0
        decimal1 = 0.0D
        decimal2 = 0.0D
        decimal3 = 0.0D
        date1 = Date.MinValue
        date2 = Date.MinValue
        date3 = Date.MinValue

        lblString3.Text = String.Empty
        lblByte3.Text = String.Empty
        lblShort3.Text = String.Empty
        lblInteger3.Text = String.Empty
        lblLong3.Text = String.Empty
        lblSingle3.Text = String.Empty
        lblDouble3.Text = String.Empty
        lblDecimal3.Text = String.Empty
        lblDate3.Text = String.Empty
        str1 = txtInput1.Text
        str2 = txtInput2.Text
        lblString1.Text = str1
        lblString2.Text = str2

        Byte.TryParse(txtInput1.Text, byte1)
        Byte.TryParse(txtInput2.Text, byte2)
        lblByte1.Text = byte1.ToString()
        lblByte2.Text = byte2.ToString()

        Short.TryParse(txtInput1.Text, short1)
        Short.TryParse(txtInput2.Text, short2)
        lblShort1.Text = short1.ToString()
        lblShort2.Text = short2.ToString()

        Integer.TryParse(txtInput1.Text, integer1)
        Integer.TryParse(txtInput2.Text, integer2)
        lblInteger1.Text = integer1.ToString()
        lblInteger2.Text = integer2.ToString()

        Long.TryParse(txtInput1.Text, long1)
        Long.TryParse(txtInput2.Text, long2)
        lblLong1.Text = long1.ToString()
        lblLong2.Text = long2.ToString()

        Single.TryParse(txtInput1.Text, single1)
        Single.TryParse(txtInput2.Text, single2)
        lblSingle1.Text = single1.ToString()
        lblSingle2.Text = single2.ToString()

        Double.TryParse(txtInput1.Text, double1)
        Double.TryParse(txtInput2.Text, double2)
        lblDouble1.Text = double1.ToString()
        lblDouble2.Text = double2.ToString()

        Decimal.TryParse(txtInput1.Text, decimal1)
        Decimal.TryParse(txtInput2.Text, decimal2)
        lblDecimal1.Text = decimal1.ToString()
        lblDecimal2.Text = decimal2.ToString()

        Date.TryParse(txtInput1.Text, date1)
        Date.TryParse(txtInput2.Text, date2)
        TimeSpan.TryParse(txtInput2.Text, timeSpan2)
        lblDate1.Text = date1.ToString()
        lblDate2.Text = date2.ToString()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next
        str3 = str1 + str2
        lblString3.Text = str3
        byte3 = byte1 + byte2
        lblByte3.Text = byte3.ToString()
        short3 = short1 + short2
        lblShort3.Text = short3.ToString()
        integer3 = integer1 + integer2
        lblInteger3.Text = integer3.ToString()
        long3 = long1 + long2
        lblLong3.Text = long3.ToString()
        single3 = single1 + single2
        lblSingle3.Text = single3.ToString()
        double3 = double1 + double2
        lblDouble3.Text = double3.ToString()
        decimal3 = decimal1 + decimal2
        lblDecimal3.Text = decimal3.ToString()
        lblDate3.Text = date1.Add(timeSpan2).ToString()


    End Sub

    Private Sub btnSubstract_Click(sender As Object, e As EventArgs) Handles btnSubstract.Click
        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next
        'str3 = str1 - str2
        'lblString3.Text = str3
        byte3 = byte1 - byte2
        lblByte3.Text = byte3.ToString()
        short3 = short1 - short2
        lblShort3.Text = short3.ToString()
        integer3 = integer1 - integer2
        lblInteger3.Text = integer3.ToString()
        long3 = long1 - long2
        lblLong3.Text = long3.ToString()
        single3 = single1 - single2
        lblSingle3.Text = single3.ToString()
        double3 = double1 - double2
        lblDouble3.Text = double3.ToString()
        decimal3 = decimal1 - decimal2
        lblDecimal3.Text = decimal3.ToString()
        lblDate3.Text = date1.Subtract(timeSpan2).ToString()

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next
        'str3 = str1 * str2
        'lblString3.Text = str3
        byte3 = byte1 * byte2
        lblByte3.Text = byte3.ToString()
        short3 = short1 * short2
        lblShort3.Text = short3.ToString()
        integer3 = integer1 * integer2
        lblInteger3.Text = integer3.ToString()
        long3 = long1 * long2
        lblLong3.Text = long3.ToString()
        single3 = single1 * single2
        lblSingle3.Text = single3.ToString()
        double3 = double1 * double2
        lblDouble3.Text = double3.ToString()
        decimal3 = decimal1 * decimal2
        lblDecimal3.Text = decimal3.ToString()

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next
        'str3 = str1 / str2
        'lblString3.Text = str3
        byte3 = byte1 \ byte2
        lblByte3.Text = byte3.ToString()
        short3 = short1 \ short2
        lblShort3.Text = short3.ToString()
        integer3 = integer1 \ integer2
        lblInteger3.Text = integer3.ToString()
        long3 = long1 \ long2
        lblLong3.Text = long3.ToString()
        single3 = single1 / single2
        lblSingle3.Text = single3.ToString()
        double3 = double1 / double2
        lblDouble3.Text = double3.ToString()
        decimal3 = decimal1 / decimal2
        lblDecimal3.Text = decimal3.ToString()

    End Sub



End Class
