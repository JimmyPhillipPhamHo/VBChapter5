<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RightTriangle
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSideA = New System.Windows.Forms.TextBox()
        Me.RadioA = New System.Windows.Forms.RadioButton()
        Me.RadioB = New System.Windows.Forms.RadioButton()
        Me.RadioC = New System.Windows.Forms.RadioButton()
        Me.txtSideB = New System.Windows.Forms.TextBox()
        Me.txtSideC = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioC)
        Me.GroupBox1.Controls.Add(Me.RadioB)
        Me.GroupBox1.Controls.Add(Me.RadioA)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtSideA
        '
        Me.txtSideA.Location = New System.Drawing.Point(232, 97)
        Me.txtSideA.Name = "txtSideA"
        Me.txtSideA.Size = New System.Drawing.Size(100, 20)
        Me.txtSideA.TabIndex = 1
        '
        'RadioA
        '
        Me.RadioA.AutoSize = True
        Me.RadioA.Location = New System.Drawing.Point(22, 34)
        Me.RadioA.Name = "RadioA"
        Me.RadioA.Size = New System.Drawing.Size(104, 17)
        Me.RadioA.TabIndex = 0
        Me.RadioA.TabStop = True
        Me.RadioA.Text = "Solve For A Side"
        Me.RadioA.UseVisualStyleBackColor = True
        '
        'RadioB
        '
        Me.RadioB.AutoSize = True
        Me.RadioB.Location = New System.Drawing.Point(22, 68)
        Me.RadioB.Name = "RadioB"
        Me.RadioB.Size = New System.Drawing.Size(104, 17)
        Me.RadioB.TabIndex = 1
        Me.RadioB.TabStop = True
        Me.RadioB.Text = "Solve For B Side"
        Me.RadioB.UseVisualStyleBackColor = True
        '
        'RadioC
        '
        Me.RadioC.AutoSize = True
        Me.RadioC.Location = New System.Drawing.Point(22, 102)
        Me.RadioC.Name = "RadioC"
        Me.RadioC.Size = New System.Drawing.Size(104, 17)
        Me.RadioC.TabIndex = 2
        Me.RadioC.TabStop = True
        Me.RadioC.Text = "Solve For C Side"
        Me.RadioC.UseVisualStyleBackColor = True
        '
        'txtSideB
        '
        Me.txtSideB.Location = New System.Drawing.Point(232, 133)
        Me.txtSideB.Name = "txtSideB"
        Me.txtSideB.Size = New System.Drawing.Size(100, 20)
        Me.txtSideB.TabIndex = 2
        '
        'txtSideC
        '
        Me.txtSideC.Location = New System.Drawing.Point(232, 168)
        Me.txtSideC.Name = "txtSideC"
        Me.txtSideC.Size = New System.Drawing.Size(100, 20)
        Me.txtSideC.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(119, 241)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'RightTriangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 399)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSideC)
        Me.Controls.Add(Me.txtSideB)
        Me.Controls.Add(Me.txtSideA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RightTriangle"
        Me.Text = "RightTriangle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioC As System.Windows.Forms.RadioButton
    Friend WithEvents RadioB As System.Windows.Forms.RadioButton
    Friend WithEvents RadioA As System.Windows.Forms.RadioButton
    Friend WithEvents txtSideA As System.Windows.Forms.TextBox
    Friend WithEvents txtSideB As System.Windows.Forms.TextBox
    Friend WithEvents txtSideC As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
End Class
