' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   Ummer Siddique on 12/03/2017
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
        Handles txtMeasurement.TextChanged, radSubCentimeters.CheckedChanged,
        radSubInches.CheckedChanged, radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged
        Dim dblMeasurement As Double = 0.0
        Dim dblResult As Double = 0.0


        Double.TryParse(txtMeasurement.Text, dblMeasurement)

        If radSubCentimeters.Checked Then
            CalcCentimetersSub(dblMeasurement, dblResult)
        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblMeasurement, dblResult)
        ElseIf radFuncCentimeters.checked Then
            dblResult = CalcCentimetersFunc(dblMeasurement)
        ElseIf radFuncInches.Checked Then
            dblResult = CalcInchesFunc(dblMeasurement)
        End If
        lblResult.Text = dblResult.ToString("n2")
    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 2.54
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas / 2.54
    End Sub

    Private Function CalcCentimetersFunc(ByVal dblMeas As Double) As Double
        Dim dblRes As Double
        dblRes = dblMeas * 2.54
        Return dblRes
    End Function

    Private Function CalcInchesFunc(ByVal dblMeas As Double) As Double
        Dim dblRes As Double
        dblRes = dblMeas / 2.54
        Return dblRes
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Venus")
        cboPlanets.Items.Add("Earth")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Jupiter")
        cboPlanets.Items.Add("Saturn")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")
        cboPlanets.SelectedItem = "Earth"
    End Sub

    Private Sub Weight_InputChanged(sender As Object, e As EventArgs) _
        Handles txtEarthWeight.TextChanged, radSubWeight.CheckedChanged,
        radFuncWeight.CheckedChanged, cboPlanets.TextChanged
        Dim dblWeight As Double = 0.0
        Dim dblGravity As Double = 0.0
        Dim strPlanets As String

        Double.TryParse(txtEarthWeight.Text, dblWeight)
        strPlanets = cboPlanets.Text

        If radSubWeight.Checked Then
            CalcWeightSub(dblWeight, strPlanets, dblGravity)
        ElseIf radFuncWeight.Checked Then
            dblGravity = CalcWeightFunc(dblWeight, strPlanets)
        End If
        lblWeightPlanet.Text = dblGravity.ToString("n2")
    End Sub

    Private Sub CalcWeightSub(ByVal dblWght As Double, ByVal strPlnt As String, ByRef dblGrvty As Double)

        Select Case strPlnt
            Case "Mercury", "Mars"
                dblGrvty = dblWght * 0.38
            Case "Venus"
                dblGrvty = dblWght * 0.91
            Case "Earth"
                dblGrvty = dblWght * 1.0
            Case "Jupiter"
                dblGrvty = dblWght * 2.34
            Case "Saturn"
                dblGrvty = dblWght * 1.06
            Case "Uranus"
                dblGrvty = dblWght * 0.92
            Case "Neptune"
                dblGrvty = dblWght * 1.14
            Case "Pluto"
                dblGrvty = dblWght * 0.06
        End Select
    End Sub

    Private Function CalcWeightFunc(ByVal dblWght As Double, ByVal strPlnt As String) As Double
        Dim dblGrvty As Double
        Select Case strPlnt
            Case "Mercury", "Mars"
                dblGrvty = dblWght * 0.38
            Case "Venus"
                dblGrvty = dblWght * 0.91
            Case "Earth"
                dblGrvty = dblWght * 1.0
            Case "Jupiter"
                dblGrvty = dblWght * 2.34
            Case "Saturn"
                dblGrvty = dblWght * 1.06
            Case "Uranus"
                dblGrvty = dblWght * 0.92
            Case "Neptune"
                dblGrvty = dblWght * 1.14
            Case "Pluto"
                dblGrvty = dblWght * 0.06
        End Select
        Return dblGrvty
    End Function

    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthWeight.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    'Select all text in txtEarthWeight
    Private Sub txtEarthWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthWeight.Enter
        txtEarthWeight.SelectAll()
    End Sub
End Class
