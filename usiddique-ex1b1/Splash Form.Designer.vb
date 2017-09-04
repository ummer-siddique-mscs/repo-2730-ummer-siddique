<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picStorks = New System.Windows.Forms.PictureBox()
        Me.picIguanas = New System.Windows.Forms.PictureBox()
        Me.tmrExit = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picStorks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIguanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.GreenYellow
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(180, 70)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(111, 21)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Crighton Zoo"
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.BackColor = System.Drawing.Color.GreenYellow
        Me.lblMsg.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.Red
        Me.lblMsg.Location = New System.Drawing.Point(180, 115)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(188, 21)
        Me.lblMsg.TabIndex = 1
        Me.lblMsg.Text = "Come visit our residents!"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.GreenYellow
        Me.Label1.Location = New System.Drawing.Point(10, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 282)
        Me.Label1.TabIndex = 2
        '
        'picStorks
        '
        Me.picStorks.Image = Global.usiddique_ex1b1.My.Resources.Resources.Storks
        Me.picStorks.Location = New System.Drawing.Point(216, 153)
        Me.picStorks.Name = "picStorks"
        Me.picStorks.Size = New System.Drawing.Size(152, 136)
        Me.picStorks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picStorks.TabIndex = 4
        Me.picStorks.TabStop = False
        '
        'picIguanas
        '
        Me.picIguanas.Image = Global.usiddique_ex1b1.My.Resources.Resources.Iguanas1
        Me.picIguanas.Location = New System.Drawing.Point(22, 22)
        Me.picIguanas.Name = "picIguanas"
        Me.picIguanas.Size = New System.Drawing.Size(152, 136)
        Me.picIguanas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIguanas.TabIndex = 3
        Me.picIguanas.TabStop = False
        '
        'tmrExit
        '
        Me.tmrExit.Enabled = True
        Me.tmrExit.Interval = 4000
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 301)
        Me.ControlBox = False
        Me.Controls.Add(Me.picStorks)
        Me.Controls.Add(Me.picIguanas)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crighton Zoo"
        CType(Me.picStorks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIguanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblMsg As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents picIguanas As PictureBox
    Friend WithEvents picStorks As PictureBox
    Friend WithEvents tmrExit As Timer
End Class
