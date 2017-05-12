Public Class LoginForm

   Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
      Oracle.UserName = TextBox1.Text
      Oracle.Password = TextBox2.Text
      Oracle.Server = TextBox3.Text

      Oracle.Result = Oracle.ResponseType.OK

      Me.Close()

   End Sub

   Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
      Oracle.Result = Oracle.ResponseType.Cancel

      Me.Close()
   End Sub
End Class
