<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
      Me.submitButton = New System.Windows.Forms.Button()
      Me.cancelButton = New System.Windows.Forms.Button()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.TextBox2 = New System.Windows.Forms.TextBox()
      Me.TextBox3 = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'submitButton
      '
      Me.submitButton.Location = New System.Drawing.Point(209, 204)
      Me.submitButton.Name = "submitButton"
      Me.submitButton.Size = New System.Drawing.Size(75, 23)
      Me.submitButton.TabIndex = 0
      Me.submitButton.Text = "OK"
      Me.submitButton.UseVisualStyleBackColor = True
      '
      'cancelButton
      '
      Me.cancelButton.Location = New System.Drawing.Point(303, 204)
      Me.cancelButton.Name = "cancelButton"
      Me.cancelButton.Size = New System.Drawing.Size(75, 23)
      Me.cancelButton.TabIndex = 1
      Me.cancelButton.Text = "Cancel"
      Me.cancelButton.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(206, 55)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(58, 13)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "User name"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(206, 94)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(53, 13)
      Me.Label2.TabIndex = 3
      Me.Label2.Text = "Password"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(206, 133)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(59, 13)
      Me.Label3.TabIndex = 4
      Me.Label3.Text = "Host String"
      '
      'TextBox1
      '
      Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.TextBox1.Location = New System.Drawing.Point(209, 71)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(142, 20)
      Me.TextBox1.TabIndex = 5
      '
      'TextBox2
      '
      Me.TextBox2.Location = New System.Drawing.Point(209, 110)
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.TextBox2.Size = New System.Drawing.Size(142, 20)
      Me.TextBox2.TabIndex = 6
      '
      'TextBox3
      '
      Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
      Me.TextBox3.Location = New System.Drawing.Point(209, 149)
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.Size = New System.Drawing.Size(142, 20)
      Me.TextBox3.TabIndex = 7
      '
      'LoginForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(534, 283)
      Me.Controls.Add(Me.TextBox3)
      Me.Controls.Add(Me.TextBox2)
      Me.Controls.Add(Me.TextBox1)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.cancelButton)
      Me.Controls.Add(Me.submitButton)
      Me.Name = "LoginForm"
      Me.Text = "CS3630 seelyv_arlingk"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents submitButton As Button
   Friend WithEvents cancelButton As Button
   Friend WithEvents Label1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents Label3 As Label
   Friend WithEvents TextBox1 As TextBox
   Friend WithEvents TextBox2 As TextBox
   Friend WithEvents TextBox3 As TextBox
End Class
