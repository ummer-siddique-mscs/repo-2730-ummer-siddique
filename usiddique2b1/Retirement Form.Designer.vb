<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.txtEmployeecont = New System.Windows.Forms.TextBox()
        Me.txtEmployercont = New System.Windows.Forms.TextBox()
        Me.lblEmployeeannualcont = New System.Windows.Forms.Label()
        Me.lblEmployerannualcont = New System.Windows.Forms.Label()
        Me.lblTotalannualcont = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Gross weekly pay:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(281, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Employee contribution rate (decimal form):"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employe&r contribution rate (decimal form):"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee annual contribution:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Employer annual contribution:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total annual contribution:"
        '
        'txtGross
        '
        Me.txtGross.Location = New System.Drawing.Point(315, 39)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(143, 20)
        Me.txtGross.TabIndex = 6
        Me.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployeecont
        '
        Me.txtEmployeecont.Location = New System.Drawing.Point(358, 82)
        Me.txtEmployeecont.Name = "txtEmployeecont"
        Me.txtEmployeecont.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeecont.TabIndex = 7
        Me.txtEmployeecont.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployercont
        '
        Me.txtEmployercont.Location = New System.Drawing.Point(358, 124)
        Me.txtEmployercont.Name = "txtEmployercont"
        Me.txtEmployercont.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployercont.TabIndex = 8
        Me.txtEmployercont.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmployeeannualcont
        '
        Me.lblEmployeeannualcont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeannualcont.Location = New System.Drawing.Point(358, 208)
        Me.lblEmployeeannualcont.Name = "lblEmployeeannualcont"
        Me.lblEmployeeannualcont.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeeannualcont.TabIndex = 9
        '
        'lblEmployerannualcont
        '
        Me.lblEmployerannualcont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployerannualcont.Location = New System.Drawing.Point(358, 254)
        Me.lblEmployerannualcont.Name = "lblEmployerannualcont"
        Me.lblEmployerannualcont.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployerannualcont.TabIndex = 10
        '
        'lblTotalannualcont
        '
        Me.lblTotalannualcont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalannualcont.Location = New System.Drawing.Point(358, 294)
        Me.lblTotalannualcont.Name = "lblTotalannualcont"
        Me.lblTotalannualcont.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalannualcont.TabIndex = 11
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(69, 348)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(101, 33)
        Me.btnCalc.TabIndex = 12
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(207, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 33)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(346, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 33)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.usiddique1f1.My.Resources.Resources.retirement
        Me.PictureBox1.Location = New System.Drawing.Point(479, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 409)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTotalannualcont)
        Me.Controls.Add(Me.lblEmployerannualcont)
        Me.Controls.Add(Me.lblEmployeeannualcont)
        Me.Controls.Add(Me.txtEmployercont)
        Me.Controls.Add(Me.txtEmployeecont)
        Me.Controls.Add(Me.txtGross)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRetirement"
        Me.Text = "Retirement_Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGross As TextBox
    Friend WithEvents txtEmployeecont As TextBox
    Friend WithEvents txtEmployercont As TextBox
    Friend WithEvents lblEmployeeannualcont As Label
    Friend WithEvents lblEmployerannualcont As Label
    Friend WithEvents lblTotalannualcont As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
