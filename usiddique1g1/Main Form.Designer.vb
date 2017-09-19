<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmName
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAvgScore = New System.Windows.Forms.Label()
        Me.txtscore1 = New System.Windows.Forms.TextBox()
        Me.txtscore2 = New System.Windows.Forms.TextBox()
        Me.txtscore3 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(49, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Test score 1"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(49, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Test score 2"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(49, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Test score 3"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(319, 112)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(97, 32)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(319, 155)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 32)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(319, 209)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 32)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Average Test Score:"
        '
        'lblAvgScore
        '
        Me.lblAvgScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgScore.Location = New System.Drawing.Point(200, 271)
        Me.lblAvgScore.Name = "lblAvgScore"
        Me.lblAvgScore.Size = New System.Drawing.Size(86, 30)
        Me.lblAvgScore.TabIndex = 10
        '
        'txtscore1
        '
        Me.txtscore1.Location = New System.Drawing.Point(166, 112)
        Me.txtscore1.Name = "txtscore1"
        Me.txtscore1.Size = New System.Drawing.Size(100, 27)
        Me.txtscore1.TabIndex = 1
        '
        'txtscore2
        '
        Me.txtscore2.Location = New System.Drawing.Point(166, 158)
        Me.txtscore2.Name = "txtscore2"
        Me.txtscore2.Size = New System.Drawing.Size(100, 27)
        Me.txtscore2.TabIndex = 3
        '
        'txtscore3
        '
        Me.txtscore3.Location = New System.Drawing.Point(166, 209)
        Me.txtscore3.Name = "txtscore3"
        Me.txtscore3.Size = New System.Drawing.Size(100, 27)
        Me.txtscore3.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.usiddique1g1.My.Resources.Resources.numbers
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 79)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'frmName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 346)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtscore3)
        Me.Controls.Add(Me.txtscore2)
        Me.Controls.Add(Me.txtscore1)
        Me.Controls.Add(Me.lblAvgScore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmName"
        Me.Text = "Average Test Scores"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblAvgScore As Label
    Friend WithEvents txtscore1 As TextBox
    Friend WithEvents txtscore2 As TextBox
    Friend WithEvents txtscore3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
