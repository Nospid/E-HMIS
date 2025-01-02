<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class condom_distribution
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
		Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.ComboBox3 = New System.Windows.Forms.ComboBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'NumericUpDown1
		'
		Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.NumericUpDown1.Location = New System.Drawing.Point(532, 95)
		Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(2)
		Me.NumericUpDown1.Name = "NumericUpDown1"
		Me.NumericUpDown1.Size = New System.Drawing.Size(216, 23)
		Me.NumericUpDown1.TabIndex = 272
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label25.Location = New System.Drawing.Point(533, 75)
		Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(117, 18)
		Me.Label25.TabIndex = 271
		Me.Label25.Text = "वितरण गरिएको संख्या"
		'
		'DateTimePicker3
		'
		Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DateTimePicker3.Location = New System.Drawing.Point(290, 92)
		Me.DateTimePicker3.Margin = New System.Windows.Forms.Padding(2)
		Me.DateTimePicker3.Name = "DateTimePicker3"
		Me.DateTimePicker3.Size = New System.Drawing.Size(215, 23)
		Me.DateTimePicker3.TabIndex = 270
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.Location = New System.Drawing.Point(292, 72)
		Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(112, 18)
		Me.Label20.TabIndex = 269
		Me.Label20.Text = "वितरण गरिएको मिति"
		'
		'ComboBox3
		'
		Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ComboBox3.FormattingEnabled = True
		Me.ComboBox3.Location = New System.Drawing.Point(23, 92)
		Me.ComboBox3.Margin = New System.Windows.Forms.Padding(2)
		Me.ComboBox3.Name = "ComboBox3"
		Me.ComboBox3.Size = New System.Drawing.Size(220, 24)
		Me.ComboBox3.TabIndex = 268
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Location = New System.Drawing.Point(23, 70)
		Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(89, 18)
		Me.Label17.TabIndex = 267
		Me.Label17.Text = "वितरणको प्रकार"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(22, 22)
		Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(236, 24)
		Me.Label1.TabIndex = 273
		Me.Label1.Text = "कन्डम लिन आएका सेवाग्राहीको विवरण"
		'
		'Button2
		'
		Me.Button2.ForeColor = System.Drawing.Color.DarkBlue
		Me.Button2.Location = New System.Drawing.Point(664, 195)
		Me.Button2.Margin = New System.Windows.Forms.Padding(2)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 42)
		Me.Button2.TabIndex = 274
		Me.Button2.Text = "Submit"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.Red
		Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
		Me.Button3.Location = New System.Drawing.Point(560, 195)
		Me.Button3.Margin = New System.Windows.Forms.Padding(2)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(76, 42)
		Me.Button3.TabIndex = 275
		Me.Button3.Text = "Close"
		Me.Button3.UseVisualStyleBackColor = False
		'
		'condom_distribution
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 276)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.NumericUpDown1)
		Me.Controls.Add(Me.Label25)
		Me.Controls.Add(Me.DateTimePicker3)
		Me.Controls.Add(Me.Label20)
		Me.Controls.Add(Me.ComboBox3)
		Me.Controls.Add(Me.Label17)
		Me.Name = "condom_distribution"
		Me.Text = "condom_distribution"
		CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents NumericUpDown1 As NumericUpDown
	Friend WithEvents Label25 As Label
	Friend WithEvents DateTimePicker3 As DateTimePicker
	Friend WithEvents Label20 As Label
	Friend WithEvents ComboBox3 As ComboBox
	Friend WithEvents Label17 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
End Class
