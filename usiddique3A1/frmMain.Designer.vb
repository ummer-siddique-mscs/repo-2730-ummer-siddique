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
        Me.pretestDoWhileButton = New System.Windows.Forms.Button()
        Me.pretestDoUntilButton = New System.Windows.Forms.Button()
        Me.posttestLoopWhileButton = New System.Windows.Forms.Button()
        Me.posttestLoopUntilButton = New System.Windows.Forms.Button()
        Me.forLoopButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEven = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSumDoWhile = New System.Windows.Forms.Button()
        Me.btnSumLoopUntil = New System.Windows.Forms.Button()
        Me.btnSumForNext = New System.Windows.Forms.Button()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pretestDoWhileButton
        '
        Me.pretestDoWhileButton.Location = New System.Drawing.Point(158, 31)
        Me.pretestDoWhileButton.Name = "pretestDoWhileButton"
        Me.pretestDoWhileButton.Size = New System.Drawing.Size(162, 23)
        Me.pretestDoWhileButton.TabIndex = 0
        Me.pretestDoWhileButton.Text = "Pretest: Do While"
        Me.pretestDoWhileButton.UseVisualStyleBackColor = True
        '
        'pretestDoUntilButton
        '
        Me.pretestDoUntilButton.Location = New System.Drawing.Point(158, 72)
        Me.pretestDoUntilButton.Name = "pretestDoUntilButton"
        Me.pretestDoUntilButton.Size = New System.Drawing.Size(162, 23)
        Me.pretestDoUntilButton.TabIndex = 1
        Me.pretestDoUntilButton.Text = "Pretest: Do Until"
        Me.pretestDoUntilButton.UseVisualStyleBackColor = True
        '
        'posttestLoopWhileButton
        '
        Me.posttestLoopWhileButton.Location = New System.Drawing.Point(158, 117)
        Me.posttestLoopWhileButton.Name = "posttestLoopWhileButton"
        Me.posttestLoopWhileButton.Size = New System.Drawing.Size(162, 23)
        Me.posttestLoopWhileButton.TabIndex = 2
        Me.posttestLoopWhileButton.Text = "Posttest: Loop While"
        Me.posttestLoopWhileButton.UseVisualStyleBackColor = True
        '
        'posttestLoopUntilButton
        '
        Me.posttestLoopUntilButton.Location = New System.Drawing.Point(158, 163)
        Me.posttestLoopUntilButton.Name = "posttestLoopUntilButton"
        Me.posttestLoopUntilButton.Size = New System.Drawing.Size(162, 23)
        Me.posttestLoopUntilButton.TabIndex = 3
        Me.posttestLoopUntilButton.Text = "Posttest: Loop Until"
        Me.posttestLoopUntilButton.UseVisualStyleBackColor = True
        '
        'forLoopButton
        '
        Me.forLoopButton.Location = New System.Drawing.Point(158, 205)
        Me.forLoopButton.Name = "forLoopButton"
        Me.forLoopButton.Size = New System.Drawing.Size(162, 23)
        Me.forLoopButton.TabIndex = 4
        Me.forLoopButton.Text = "Pretest: For"
        Me.forLoopButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEven)
        Me.GroupBox1.Controls.Add(Me.forLoopButton)
        Me.GroupBox1.Controls.Add(Me.posttestLoopUntilButton)
        Me.GroupBox1.Controls.Add(Me.posttestLoopWhileButton)
        Me.GroupBox1.Controls.Add(Me.pretestDoUntilButton)
        Me.GroupBox1.Controls.Add(Me.pretestDoWhileButton)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 255)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p347#13 Loop 2-20"
        '
        'lblEven
        '
        Me.lblEven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEven.Location = New System.Drawing.Point(10, 20)
        Me.lblEven.Name = "lblEven"
        Me.lblEven.Size = New System.Drawing.Size(126, 216)
        Me.lblEven.TabIndex = 5
        '
        'lblAvg
        '
        Me.lblAvg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvg.Location = New System.Drawing.Point(201, 58)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(100, 42)
        Me.lblAvg.TabIndex = 8
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCount.Location = New System.Drawing.Point(316, 58)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(100, 42)
        Me.lblCount.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtList)
        Me.GroupBox2.Controls.Add(Me.btnSumForNext)
        Me.GroupBox2.Controls.Add(Me.btnSumLoopUntil)
        Me.GroupBox2.Controls.Add(Me.btnSumDoWhile)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.lblAvg)
        Me.GroupBox2.Location = New System.Drawing.Point(392, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(436, 298)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p332-348 #22 Addition"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Average:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(313, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Count:"
        '
        'btnSumDoWhile
        '
        Me.btnSumDoWhile.Location = New System.Drawing.Point(223, 117)
        Me.btnSumDoWhile.Name = "btnSumDoWhile"
        Me.btnSumDoWhile.Size = New System.Drawing.Size(172, 32)
        Me.btnSumDoWhile.TabIndex = 12
        Me.btnSumDoWhile.Text = "Sum, Do While"
        Me.btnSumDoWhile.UseVisualStyleBackColor = True
        '
        'btnSumLoopUntil
        '
        Me.btnSumLoopUntil.Location = New System.Drawing.Point(223, 168)
        Me.btnSumLoopUntil.Name = "btnSumLoopUntil"
        Me.btnSumLoopUntil.Size = New System.Drawing.Size(172, 32)
        Me.btnSumLoopUntil.TabIndex = 13
        Me.btnSumLoopUntil.Text = "Sum, Loop Until"
        Me.btnSumLoopUntil.UseVisualStyleBackColor = True
        '
        'btnSumForNext
        '
        Me.btnSumForNext.Location = New System.Drawing.Point(223, 219)
        Me.btnSumForNext.Name = "btnSumForNext"
        Me.btnSumForNext.Size = New System.Drawing.Size(172, 32)
        Me.btnSumForNext.TabIndex = 14
        Me.btnSumForNext.Text = "Sum, For Next"
        Me.btnSumForNext.UseVisualStyleBackColor = True
        '
        'txtList
        '
        Me.txtList.Location = New System.Drawing.Point(9, 28)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.Size = New System.Drawing.Size(178, 252)
        Me.txtList.TabIndex = 15
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(323, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 29)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 384)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pretestDoWhileButton As Button
    Friend WithEvents pretestDoUntilButton As Button
    Friend WithEvents posttestLoopWhileButton As Button
    Friend WithEvents posttestLoopUntilButton As Button
    Friend WithEvents forLoopButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblEven As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSumLoopUntil As Button
    Friend WithEvents btnSumDoWhile As Button
    Friend WithEvents btnSumForNext As Button
    Friend WithEvents txtList As TextBox
    Friend WithEvents btnExit As Button
End Class
