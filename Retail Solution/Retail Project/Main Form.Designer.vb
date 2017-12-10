<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRetail = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstRetail = New System.Windows.Forms.ListBox()
        Me.lstWholesale = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnWholesale = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(266, 101)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(210, 27)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        '
        'btnRetail
        '
        Me.btnRetail.Location = New System.Drawing.Point(266, 39)
        Me.btnRetail.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRetail.Name = "btnRetail"
        Me.btnRetail.Size = New System.Drawing.Size(210, 27)
        Me.btnRetail.TabIndex = 0
        Me.btnRetail.Text = "&Update Array to Retail Prices"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Retail prices:"
        '
        'lstRetail
        '
        Me.lstRetail.Enabled = False
        Me.lstRetail.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRetail.FormattingEnabled = True
        Me.lstRetail.ItemHeight = 16
        Me.lstRetail.Location = New System.Drawing.Point(173, 39)
        Me.lstRetail.Margin = New System.Windows.Forms.Padding(2)
        Me.lstRetail.Name = "lstRetail"
        Me.lstRetail.Size = New System.Drawing.Size(59, 164)
        Me.lstRetail.TabIndex = 6
        '
        'lstWholesale
        '
        Me.lstWholesale.Enabled = False
        Me.lstWholesale.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWholesale.FormattingEnabled = True
        Me.lstWholesale.ItemHeight = 16
        Me.lstWholesale.Location = New System.Drawing.Point(55, 39)
        Me.lstWholesale.Margin = New System.Windows.Forms.Padding(2)
        Me.lstWholesale.Name = "lstWholesale"
        Me.lstWholesale.Size = New System.Drawing.Size(59, 164)
        Me.lstWholesale.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Wholesale prices:"
        '
        'btnWholesale
        '
        Me.btnWholesale.Location = New System.Drawing.Point(266, 70)
        Me.btnWholesale.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWholesale.Name = "btnWholesale"
        Me.btnWholesale.Size = New System.Drawing.Size(210, 27)
        Me.btnWholesale.TabIndex = 1
        Me.btnWholesale.Text = "&Return Array to Wholesale Prices"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 238)
        Me.Controls.Add(Me.btnWholesale)
        Me.Controls.Add(Me.lstWholesale)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstRetail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRetail)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wholesale to Retail"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRetail As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstRetail As System.Windows.Forms.ListBox
    Friend WithEvents lstWholesale As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnWholesale As Button
End Class
