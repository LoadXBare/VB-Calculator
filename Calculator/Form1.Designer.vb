<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Keypad_1 = New System.Windows.Forms.Button()
        Me.Keypad_2 = New System.Windows.Forms.Button()
        Me.Keypad_3 = New System.Windows.Forms.Button()
        Me.Keypad_4 = New System.Windows.Forms.Button()
        Me.Keypad_5 = New System.Windows.Forms.Button()
        Me.Keypad_6 = New System.Windows.Forms.Button()
        Me.Keypad_8 = New System.Windows.Forms.Button()
        Me.Keypad_7 = New System.Windows.Forms.Button()
        Me.Keypad_0 = New System.Windows.Forms.Button()
        Me.Keypad_9 = New System.Windows.Forms.Button()
        Me.Keypad_div = New System.Windows.Forms.Button()
        Me.Keypad_multi = New System.Windows.Forms.Button()
        Me.Keypad_minus = New System.Windows.Forms.Button()
        Me.Keypad_plus = New System.Windows.Forms.Button()
        Me.Keypad_equal = New System.Windows.Forms.Button()
        Me.Keypad_clear = New System.Windows.Forms.Button()
        Me.Screen = New System.Windows.Forms.Label()
        Me.Screen_Prev = New System.Windows.Forms.Label()
        Me.Screen_Operator = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Keypad_1
        '
        Me.Keypad_1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_1.Location = New System.Drawing.Point(12, 139)
        Me.Keypad_1.Name = "Keypad_1"
        Me.Keypad_1.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_1.TabIndex = 0
        Me.Keypad_1.Text = "1"
        Me.Keypad_1.UseVisualStyleBackColor = True
        '
        'Keypad_2
        '
        Me.Keypad_2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_2.Location = New System.Drawing.Point(75, 139)
        Me.Keypad_2.Name = "Keypad_2"
        Me.Keypad_2.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_2.TabIndex = 1
        Me.Keypad_2.Text = "2"
        Me.Keypad_2.UseVisualStyleBackColor = True
        '
        'Keypad_3
        '
        Me.Keypad_3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_3.Location = New System.Drawing.Point(141, 139)
        Me.Keypad_3.Name = "Keypad_3"
        Me.Keypad_3.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_3.TabIndex = 2
        Me.Keypad_3.Text = "3"
        Me.Keypad_3.UseVisualStyleBackColor = True
        '
        'Keypad_4
        '
        Me.Keypad_4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_4.Location = New System.Drawing.Point(9, 205)
        Me.Keypad_4.Name = "Keypad_4"
        Me.Keypad_4.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_4.TabIndex = 3
        Me.Keypad_4.Text = "4"
        Me.Keypad_4.UseVisualStyleBackColor = True
        '
        'Keypad_5
        '
        Me.Keypad_5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_5.Location = New System.Drawing.Point(75, 205)
        Me.Keypad_5.Name = "Keypad_5"
        Me.Keypad_5.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_5.TabIndex = 4
        Me.Keypad_5.Text = "5"
        Me.Keypad_5.UseVisualStyleBackColor = True
        '
        'Keypad_6
        '
        Me.Keypad_6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_6.Location = New System.Drawing.Point(141, 205)
        Me.Keypad_6.Name = "Keypad_6"
        Me.Keypad_6.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_6.TabIndex = 5
        Me.Keypad_6.Text = "6"
        Me.Keypad_6.UseVisualStyleBackColor = True
        '
        'Keypad_8
        '
        Me.Keypad_8.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_8.Location = New System.Drawing.Point(75, 271)
        Me.Keypad_8.Name = "Keypad_8"
        Me.Keypad_8.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_8.TabIndex = 6
        Me.Keypad_8.Text = "8"
        Me.Keypad_8.UseVisualStyleBackColor = True
        '
        'Keypad_7
        '
        Me.Keypad_7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_7.Location = New System.Drawing.Point(9, 271)
        Me.Keypad_7.Name = "Keypad_7"
        Me.Keypad_7.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_7.TabIndex = 7
        Me.Keypad_7.Text = "7"
        Me.Keypad_7.UseVisualStyleBackColor = True
        '
        'Keypad_0
        '
        Me.Keypad_0.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_0.Location = New System.Drawing.Point(75, 337)
        Me.Keypad_0.Name = "Keypad_0"
        Me.Keypad_0.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_0.TabIndex = 8
        Me.Keypad_0.Text = "0"
        Me.Keypad_0.UseVisualStyleBackColor = True
        '
        'Keypad_9
        '
        Me.Keypad_9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_9.Location = New System.Drawing.Point(141, 271)
        Me.Keypad_9.Name = "Keypad_9"
        Me.Keypad_9.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_9.TabIndex = 9
        Me.Keypad_9.Text = "9"
        Me.Keypad_9.UseVisualStyleBackColor = True
        '
        'Keypad_div
        '
        Me.Keypad_div.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Keypad_div.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_div.ForeColor = System.Drawing.SystemColors.Control
        Me.Keypad_div.Location = New System.Drawing.Point(208, 139)
        Me.Keypad_div.Name = "Keypad_div"
        Me.Keypad_div.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_div.TabIndex = 10
        Me.Keypad_div.Text = "/"
        Me.Keypad_div.UseVisualStyleBackColor = False
        '
        'Keypad_multi
        '
        Me.Keypad_multi.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Keypad_multi.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_multi.ForeColor = System.Drawing.SystemColors.Control
        Me.Keypad_multi.Location = New System.Drawing.Point(208, 205)
        Me.Keypad_multi.Name = "Keypad_multi"
        Me.Keypad_multi.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_multi.TabIndex = 11
        Me.Keypad_multi.Text = "*"
        Me.Keypad_multi.UseVisualStyleBackColor = False
        '
        'Keypad_minus
        '
        Me.Keypad_minus.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Keypad_minus.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_minus.ForeColor = System.Drawing.SystemColors.Control
        Me.Keypad_minus.Location = New System.Drawing.Point(208, 271)
        Me.Keypad_minus.Name = "Keypad_minus"
        Me.Keypad_minus.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_minus.TabIndex = 12
        Me.Keypad_minus.Text = "-"
        Me.Keypad_minus.UseVisualStyleBackColor = False
        '
        'Keypad_plus
        '
        Me.Keypad_plus.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Keypad_plus.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_plus.ForeColor = System.Drawing.SystemColors.Control
        Me.Keypad_plus.Location = New System.Drawing.Point(208, 337)
        Me.Keypad_plus.Name = "Keypad_plus"
        Me.Keypad_plus.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_plus.TabIndex = 13
        Me.Keypad_plus.Text = "+"
        Me.Keypad_plus.UseVisualStyleBackColor = False
        '
        'Keypad_equal
        '
        Me.Keypad_equal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Keypad_equal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_equal.ForeColor = System.Drawing.SystemColors.Control
        Me.Keypad_equal.Location = New System.Drawing.Point(9, 403)
        Me.Keypad_equal.Name = "Keypad_equal"
        Me.Keypad_equal.Size = New System.Drawing.Size(192, 60)
        Me.Keypad_equal.TabIndex = 14
        Me.Keypad_equal.Text = "="
        Me.Keypad_equal.UseVisualStyleBackColor = False
        '
        'Keypad_clear
        '
        Me.Keypad_clear.BackColor = System.Drawing.Color.Firebrick
        Me.Keypad_clear.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Keypad_clear.ForeColor = System.Drawing.SystemColors.Control
        Me.Keypad_clear.Location = New System.Drawing.Point(207, 403)
        Me.Keypad_clear.Name = "Keypad_clear"
        Me.Keypad_clear.Size = New System.Drawing.Size(60, 60)
        Me.Keypad_clear.TabIndex = 15
        Me.Keypad_clear.Text = "C"
        Me.Keypad_clear.UseVisualStyleBackColor = False
        '
        'Screen
        '
        Me.Screen.AutoSize = True
        Me.Screen.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Screen.Location = New System.Drawing.Point(12, 90)
        Me.Screen.Name = "Screen"
        Me.Screen.Size = New System.Drawing.Size(184, 32)
        Me.Screen.TabIndex = 16
        Me.Screen.Text = "Enter number(s)"
        '
        'Screen_Prev
        '
        Me.Screen_Prev.AutoSize = True
        Me.Screen_Prev.Location = New System.Drawing.Point(75, 63)
        Me.Screen_Prev.Name = "Screen_Prev"
        Me.Screen_Prev.Size = New System.Drawing.Size(0, 20)
        Me.Screen_Prev.TabIndex = 17
        '
        'Screen_Operator
        '
        Me.Screen_Operator.AutoSize = True
        Me.Screen_Operator.Location = New System.Drawing.Point(242, 90)
        Me.Screen_Operator.Name = "Screen_Operator"
        Me.Screen_Operator.Size = New System.Drawing.Size(0, 20)
        Me.Screen_Operator.TabIndex = 18
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 475)
        Me.Controls.Add(Me.Screen_Operator)
        Me.Controls.Add(Me.Screen_Prev)
        Me.Controls.Add(Me.Screen)
        Me.Controls.Add(Me.Keypad_clear)
        Me.Controls.Add(Me.Keypad_equal)
        Me.Controls.Add(Me.Keypad_plus)
        Me.Controls.Add(Me.Keypad_minus)
        Me.Controls.Add(Me.Keypad_multi)
        Me.Controls.Add(Me.Keypad_div)
        Me.Controls.Add(Me.Keypad_9)
        Me.Controls.Add(Me.Keypad_0)
        Me.Controls.Add(Me.Keypad_7)
        Me.Controls.Add(Me.Keypad_8)
        Me.Controls.Add(Me.Keypad_6)
        Me.Controls.Add(Me.Keypad_5)
        Me.Controls.Add(Me.Keypad_4)
        Me.Controls.Add(Me.Keypad_3)
        Me.Controls.Add(Me.Keypad_2)
        Me.Controls.Add(Me.Keypad_1)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Keypad_1 As Button
    Friend WithEvents Keypad_2 As Button
    Friend WithEvents Keypad_3 As Button
    Friend WithEvents Keypad_4 As Button
    Friend WithEvents Keypad_5 As Button
    Friend WithEvents Keypad_6 As Button
    Friend WithEvents Keypad_8 As Button
    Friend WithEvents Keypad_7 As Button
    Friend WithEvents Keypad_0 As Button
    Friend WithEvents Keypad_9 As Button
    Friend WithEvents Keypad_div As Button
    Friend WithEvents Keypad_multi As Button
    Friend WithEvents Keypad_minus As Button
    Friend WithEvents Keypad_plus As Button
    Friend WithEvents Keypad_equal As Button
    Friend WithEvents Screen As Label
    Friend WithEvents Screen_Prev As Label
    Friend WithEvents Screen_Operator As Label
    Private WithEvents Keypad_clear As Button
End Class
