<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CurrencyConverterGroupBox = New System.Windows.Forms.GroupBox()
        Me.btnNotEqual = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAmDollar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnConvertEqual = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSARand = New System.Windows.Forms.Label()
        Me.lblBritishPound = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TeaTimeGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculateTeaTime = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalPricebyPounds = New System.Windows.Forms.Label()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.txtPricePerPound = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TripleCountyElectricGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPrevious = New System.Windows.Forms.TextBox()
        Me.btnCalculateElectricBill = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblMonthlybill = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.btnCalculateQuotient = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblQuotient = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.CurrencyConverterGroupBox.SuspendLayout()
        Me.TeaTimeGroupBox.SuspendLayout()
        Me.TripleCountyElectricGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CurrencyConverterGroupBox
        '
        Me.CurrencyConverterGroupBox.Controls.Add(Me.btnNotEqual)
        Me.CurrencyConverterGroupBox.Controls.Add(Me.Label4)
        Me.CurrencyConverterGroupBox.Controls.Add(Me.txtAmDollar)
        Me.CurrencyConverterGroupBox.Controls.Add(Me.Label7)
        Me.CurrencyConverterGroupBox.Controls.Add(Me.btnConvertEqual)
        Me.CurrencyConverterGroupBox.Controls.Add(Me.Label6)
        Me.CurrencyConverterGroupBox.Controls.Add(Me.Label5)
        Me.CurrencyConverterGroupBox.Controls.Add(Me.lblSARand)
        Me.CurrencyConverterGroupBox.Controls.Add(Me.lblBritishPound)
        Me.CurrencyConverterGroupBox.Controls.Add(Me.lblEuro)
        Me.CurrencyConverterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CurrencyConverterGroupBox.Location = New System.Drawing.Point(14, 13)
        Me.CurrencyConverterGroupBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CurrencyConverterGroupBox.Name = "CurrencyConverterGroupBox"
        Me.CurrencyConverterGroupBox.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CurrencyConverterGroupBox.Size = New System.Drawing.Size(778, 115)
        Me.CurrencyConverterGroupBox.TabIndex = 0
        Me.CurrencyConverterGroupBox.TabStop = False
        Me.CurrencyConverterGroupBox.Text = "Page 231 #1 Currency Converter"
        '
        'btnNotEqual
        '
        Me.btnNotEqual.Location = New System.Drawing.Point(164, 60)
        Me.btnNotEqual.Name = "btnNotEqual"
        Me.btnNotEqual.Size = New System.Drawing.Size(85, 24)
        Me.btnNotEqual.TabIndex = 6
        Me.btnNotEqual.Text = "C&onvert <>"
        Me.btnNotEqual.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "American &dollar:"
        '
        'txtAmDollar
        '
        Me.txtAmDollar.Location = New System.Drawing.Point(28, 51)
        Me.txtAmDollar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAmDollar.Name = "txtAmDollar"
        Me.txtAmDollar.Size = New System.Drawing.Size(116, 25)
        Me.txtAmDollar.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(629, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "South African &rand:"
        '
        'btnConvertEqual
        '
        Me.btnConvertEqual.Location = New System.Drawing.Point(164, 30)
        Me.btnConvertEqual.Name = "btnConvertEqual"
        Me.btnConvertEqual.Size = New System.Drawing.Size(85, 24)
        Me.btnConvertEqual.TabIndex = 3
        Me.btnConvertEqual.Text = "&Convert ="
        Me.btnConvertEqual.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(465, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "British &pound:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(301, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "&Euro:"
        '
        'lblSARand
        '
        Me.lblSARand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSARand.Location = New System.Drawing.Point(632, 47)
        Me.lblSARand.Name = "lblSARand"
        Me.lblSARand.Size = New System.Drawing.Size(140, 32)
        Me.lblSARand.TabIndex = 2
        Me.lblSARand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBritishPound
        '
        Me.lblBritishPound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBritishPound.Location = New System.Drawing.Point(468, 47)
        Me.lblBritishPound.Name = "lblBritishPound"
        Me.lblBritishPound.Size = New System.Drawing.Size(140, 32)
        Me.lblBritishPound.TabIndex = 1
        Me.lblBritishPound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEuro
        '
        Me.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuro.Location = New System.Drawing.Point(304, 47)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(140, 32)
        Me.lblEuro.TabIndex = 0
        Me.lblEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(666, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 56)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TeaTimeGroupBox
        '
        Me.TeaTimeGroupBox.Controls.Add(Me.Label2)
        Me.TeaTimeGroupBox.Controls.Add(Me.txtPricePerPound)
        Me.TeaTimeGroupBox.Controls.Add(Me.Label1)
        Me.TeaTimeGroupBox.Controls.Add(Me.txtPounds)
        Me.TeaTimeGroupBox.Controls.Add(Me.btnCalculateTeaTime)
        Me.TeaTimeGroupBox.Controls.Add(Me.Label8)
        Me.TeaTimeGroupBox.Controls.Add(Me.lblTotalPricebyPounds)
        Me.TeaTimeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TeaTimeGroupBox.Location = New System.Drawing.Point(14, 149)
        Me.TeaTimeGroupBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TeaTimeGroupBox.Name = "TeaTimeGroupBox"
        Me.TeaTimeGroupBox.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TeaTimeGroupBox.Size = New System.Drawing.Size(553, 115)
        Me.TeaTimeGroupBox.TabIndex = 7
        Me.TeaTimeGroupBox.TabStop = False
        Me.TeaTimeGroupBox.Text = "Page 231 #3 Tea Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "&Pounds:"
        '
        'btnCalculateTeaTime
        '
        Me.btnCalculateTeaTime.Location = New System.Drawing.Point(287, 50)
        Me.btnCalculateTeaTime.Name = "btnCalculateTeaTime"
        Me.btnCalculateTeaTime.Size = New System.Drawing.Size(85, 24)
        Me.btnCalculateTeaTime.TabIndex = 3
        Me.btnCalculateTeaTime.Text = "Calc&ulate"
        Me.btnCalculateTeaTime.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(378, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "&Total due:"
        '
        'lblTotalPricebyPounds
        '
        Me.lblTotalPricebyPounds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalPricebyPounds.Location = New System.Drawing.Point(381, 53)
        Me.lblTotalPricebyPounds.Name = "lblTotalPricebyPounds"
        Me.lblTotalPricebyPounds.Size = New System.Drawing.Size(140, 32)
        Me.lblTotalPricebyPounds.TabIndex = 0
        Me.lblTotalPricebyPounds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(28, 51)
        Me.txtPounds.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(116, 25)
        Me.txtPounds.TabIndex = 1
        '
        'txtPricePerPound
        '
        Me.txtPricePerPound.Location = New System.Drawing.Point(150, 51)
        Me.txtPricePerPound.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPricePerPound.Name = "txtPricePerPound"
        Me.txtPricePerPound.Size = New System.Drawing.Size(116, 25)
        Me.txtPricePerPound.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Price/lb:"
        '
        'TripleCountyElectricGroupBox
        '
        Me.TripleCountyElectricGroupBox.Controls.Add(Me.Label3)
        Me.TripleCountyElectricGroupBox.Controls.Add(Me.txtCurrent)
        Me.TripleCountyElectricGroupBox.Controls.Add(Me.Label9)
        Me.TripleCountyElectricGroupBox.Controls.Add(Me.txtPrevious)
        Me.TripleCountyElectricGroupBox.Controls.Add(Me.btnCalculateElectricBill)
        Me.TripleCountyElectricGroupBox.Controls.Add(Me.Label10)
        Me.TripleCountyElectricGroupBox.Controls.Add(Me.lblMonthlybill)
        Me.TripleCountyElectricGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TripleCountyElectricGroupBox.Location = New System.Drawing.Point(14, 285)
        Me.TripleCountyElectricGroupBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TripleCountyElectricGroupBox.Name = "TripleCountyElectricGroupBox"
        Me.TripleCountyElectricGroupBox.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TripleCountyElectricGroupBox.Size = New System.Drawing.Size(553, 115)
        Me.TripleCountyElectricGroupBox.TabIndex = 8
        Me.TripleCountyElectricGroupBox.TabStop = False
        Me.TripleCountyElectricGroupBox.Text = "Page 232 #4 Triple County Electric w/validation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&Current:"
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(150, 51)
        Me.txtCurrent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(116, 25)
        Me.txtCurrent.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "&Previous:"
        '
        'txtPrevious
        '
        Me.txtPrevious.Location = New System.Drawing.Point(28, 51)
        Me.txtPrevious.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.Size = New System.Drawing.Size(116, 25)
        Me.txtPrevious.TabIndex = 1
        '
        'btnCalculateElectricBill
        '
        Me.btnCalculateElectricBill.Location = New System.Drawing.Point(287, 50)
        Me.btnCalculateElectricBill.Name = "btnCalculateElectricBill"
        Me.btnCalculateElectricBill.Size = New System.Drawing.Size(85, 24)
        Me.btnCalculateElectricBill.TabIndex = 3
        Me.btnCalculateElectricBill.Text = "Calcul&ate"
        Me.btnCalculateElectricBill.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(378, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "&Monthly bill:"
        '
        'lblMonthlybill
        '
        Me.lblMonthlybill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlybill.Location = New System.Drawing.Point(381, 53)
        Me.lblMonthlybill.Name = "lblMonthlybill"
        Me.lblMonthlybill.Size = New System.Drawing.Size(140, 32)
        Me.lblMonthlybill.TabIndex = 0
        Me.lblMonthlybill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtSecond)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtFirst)
        Me.GroupBox1.Controls.Add(Me.btnCalculateQuotient)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lblQuotient)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(14, 421)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(553, 115)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Page 232 #5 Division Calculator"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(147, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 17)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "&Second:"
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(150, 51)
        Me.txtSecond.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(116, 25)
        Me.txtSecond.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(25, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "&First:"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(28, 51)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(116, 25)
        Me.txtFirst.TabIndex = 1
        '
        'btnCalculateQuotient
        '
        Me.btnCalculateQuotient.Location = New System.Drawing.Point(287, 50)
        Me.btnCalculateQuotient.Name = "btnCalculateQuotient"
        Me.btnCalculateQuotient.Size = New System.Drawing.Size(85, 24)
        Me.btnCalculateQuotient.TabIndex = 3
        Me.btnCalculateQuotient.Text = "Calcula&te"
        Me.btnCalculateQuotient.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(378, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 17)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "&Quotient:"
        '
        'lblQuotient
        '
        Me.lblQuotient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuotient.Location = New System.Drawing.Point(381, 53)
        Me.lblQuotient.Name = "lblQuotient"
        Me.lblQuotient.Size = New System.Drawing.Size(140, 32)
        Me.lblQuotient.TabIndex = 0
        Me.lblQuotient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(666, 412)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 56)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 554)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TripleCountyElectricGroupBox)
        Me.Controls.Add(Me.TeaTimeGroupBox)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.CurrencyConverterGroupBox)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "mwille 2D1"
        Me.CurrencyConverterGroupBox.ResumeLayout(False)
        Me.CurrencyConverterGroupBox.PerformLayout()
        Me.TeaTimeGroupBox.ResumeLayout(False)
        Me.TeaTimeGroupBox.PerformLayout()
        Me.TripleCountyElectricGroupBox.ResumeLayout(False)
        Me.TripleCountyElectricGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CurrencyConverterGroupBox As GroupBox
    Friend WithEvents lblSARand As Label
    Friend WithEvents lblBritishPound As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents txtAmDollar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnConvertEqual As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnNotEqual As Button
    Friend WithEvents TeaTimeGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculateTeaTime As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalPricebyPounds As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPricePerPound As TextBox
    Friend WithEvents txtPounds As TextBox
    Friend WithEvents TripleCountyElectricGroupBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrevious As TextBox
    Friend WithEvents btnCalculateElectricBill As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblMonthlybill As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents btnCalculateQuotient As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents lblQuotient As Label
    Friend WithEvents btnClear As Button
End Class
