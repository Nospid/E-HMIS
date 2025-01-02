<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class village_clinic_entry
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
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(17, 20)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(284, 22)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "गाउँघर क्लिनिक रजिस्टरमा नयाँ रेकर्ड थप्नुहोस् ।"
		'
		'ComboBox1
		'
		Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Location = New System.Drawing.Point(32, 84)
		Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(220, 24)
		Me.ComboBox1.TabIndex = 28
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(34, 60)
		Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(125, 18)
		Me.Label2.TabIndex = 27
		Me.Label2.Text = "गाउँघर क्लिनिकको नाम"
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DateTimePicker1.Location = New System.Drawing.Point(297, 84)
		Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(236, 23)
		Me.DateTimePicker1.TabIndex = 31
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(303, 60)
		Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(193, 18)
		Me.Label3.TabIndex = 30
		Me.Label3.Text = "गाउँघर क्लिनिक सन्चालन भएको मिति"
		'
		'TextBox1
		'
		Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(574, 83)
		Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(218, 23)
		Me.TextBox1.TabIndex = 33
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(580, 60)
		Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(179, 18)
		Me.Label8.TabIndex = 32
		Me.Label8.Text = "गाउँघर क्लिनिक सञ्चालन हुने स्थान"
		'
		'Button2
		'
		Me.Button2.ForeColor = System.Drawing.Color.DarkBlue
		Me.Button2.Location = New System.Drawing.Point(730, 173)
		Me.Button2.Margin = New System.Windows.Forms.Padding(2)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(62, 30)
		Me.Button2.TabIndex = 34
		Me.Button2.Text = "Submit"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.Red
		Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Button1.Location = New System.Drawing.Point(642, 173)
		Me.Button1.Margin = New System.Windows.Forms.Padding(2)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(60, 30)
		Me.Button1.TabIndex = 35
		Me.Button1.Text = "Close"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'village_clinic_entry
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(897, 296)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.DateTimePicker1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "village_clinic_entry"
		Me.Text = "village_clinic_entry"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label2 As Label
	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
End Class
