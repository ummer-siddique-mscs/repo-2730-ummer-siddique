'Name: Retirement Project
'Purpose: Calculates Employer, Employee and Total Annual Contributions
'Programmer" Ummer Siddique on 10/08/2017

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmRetirement
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate Employer, Employee and Total Annual Contributions
        Dim decGross As Decimal
        Dim decEmployeecont As Decimal
        Dim decEmployercont As Decimal
        Dim decEmployeeannualcont As Decimal
        Dim decEmployerannualcont As Decimal
        Dim decTotalannualcont As Decimal
        Const intpaychecks As Integer = 52

        Decimal.TryParse(txtGross.Text, decGross)
        Decimal.TryParse(txtEmployeecont.Text, decEmployeecont)
        Decimal.TryParse(txtEmployercont.Text, decEmployercont)

        decEmployeeannualcont = (decGross * intpaychecks) * decEmployeecont
        decEmployerannualcont = (decGross * intpaychecks) * decEmployercont
        decTotalannualcont = decEmployeeannualcont + decEmployerannualcont

        lblEmployeeannualcont.Text = decEmployeeannualcont.ToString("C2")
        lblEmployerannualcont.Text = decEmployerannualcont.ToString("C2")
        lblTotalannualcont.Text = decTotalannualcont.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' prepare screen for the next contributions Calculation
        txtGross.Text = String.Empty
        txtEmployeecont.Text = String.Empty
        txtEmployercont.Text = String.Empty
        lblEmployeeannualcont.Text = String.Empty
        lblEmployerannualcont.Text = String.Empty
        lblTotalannualcont.Text = String.Empty

        ' send the focus to the gross weekly pay box
        txtGross.Focus()
    End Sub
End Class