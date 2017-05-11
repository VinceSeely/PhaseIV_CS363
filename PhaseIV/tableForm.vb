Public Class tableForm
   Private staffBindingSource As New BindingSource
   Private qualificationsBindingSource As New BindingSource
   Private experienceBindingSource As New BindingSource
   Private staffDataView As New DataView()
   Private experienceDataView As New DataView()
   Private qualificationsDataView As New DataView()
   Private Sub tableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      staffDataView.Table = Oracle.staffTable
      staffBindingSource.DataSource = staffDataView

      experienceDataView.Table = Oracle.experienceTable
      experienceBindingSource.DataSource = experienceDataView

      qualificationsDataView.Table = Oracle.qualificationsTable
      qualificationsBindingSource.DataSource = qualificationsDataView

      txtStaffNo.DataBindings.Add("Text", staffBindingSource, "StaffNo")
      txtFname.DataBindings.Add("Text", staffBindingSource, "fName")
      txtLname.DataBindings.Add("Text", staffBindingSource, "lName")
      txtStreet.DataBindings.Add("Text", staffBindingSource, "street")
      txtCity.DataBindings.Add("Text", staffBindingSource, "city")
      txtState.DataBindings.Add("Text", staffBindingSource, "state")
      txtZip.DataBindings.Add("Text", staffBindingSource, "zip")
      txtPhone.DataBindings.Add("Text", staffBindingSource, "phone")
      txtDOB.DataBindings.Add("Text", staffBindingSource, "DOB")
      txtGender.DataBindings.Add("Text", staffBindingSource, "gender")
      txtNIN.DataBindings.Add("Text", staffBindingSource, "NIN")
      txtPosition.DataBindings.Add("Text", staffBindingSource, "position")
      txtCurSal.DataBindings.Add("Text", staffBindingSource, "curSalary")
      txtSalScale.DataBindings.Add("Text", staffBindingSource, "salaryScale")
      txtHours.DataBindings.Add("Text", staffBindingSource, "hrsPerWk")
      txtTempPerm.DataBindings.Add("Text", staffBindingSource, "posPermTemp")
      txtTypePay.DataBindings.Add("Text", staffBindingSource, "typeOfPay")
      'change query for qual and exp
      'should query where txtStaffNo = q or exp . staffno
      Dim tempID = txtStaffNo.Text

      Oracle.qualificationsCommand.CommandText = "select * from UWP_Qualifications where staffNo = '" & tempID & "'"
      Oracle.experienceCommand.CommandText = "select * from UWP_WorkExperience where staffNo = '" & tempID & "'"

      txtQualDate.DataBindings.Add("Text", qualificationsBindingSource, "qualDate")
      txtType.DataBindings.Add("Text", qualificationsBindingSource, "type")
      txtInsName.DataBindings.Add("Text", qualificationsBindingSource, "instName")

      txtOrgName.DataBindings.Add("Text", experienceBindingSource, "orgName")
      txtExpPos.DataBindings.Add("Text", experienceBindingSource, "position")
      txtStart.DataBindings.Add("Text", experienceBindingSource, "startDate")
      txtFinish.DataBindings.Add("Text", experienceBindingSource, "finishDate")

      numEmp.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      numQual.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
      numExp.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
   End Sub

   Private Sub empFirst_Click(sender As Object, e As EventArgs) Handles empFirst.Click
      staffBindingSource.MoveFirst()
      numEmp.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
   End Sub

   Private Sub empPre_Click(sender As Object, e As EventArgs) Handles empPre.Click
      staffBindingSource.MovePrevious()
      numEmp.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
   End Sub

   Private Sub empNxt_Click(sender As Object, e As EventArgs) Handles empNxt.Click
      staffBindingSource.MoveNext()
      numEmp.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
   End Sub

   Private Sub empLast_Click(sender As Object, e As EventArgs) Handles empLast.Click
      staffBindingSource.MoveLast()
      numEmp.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
   End Sub

   Private Sub qualFirst_Click(sender As Object, e As EventArgs) Handles qualFirst.Click
      qualificationsBindingSource.MoveFirst()
      numQual.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
   End Sub

   Private Sub qualPre_Click(sender As Object, e As EventArgs) Handles qualPre.Click
      qualificationsBindingSource.MovePrevious()
      numQual.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
   End Sub

   Private Sub qualNxt_Click(sender As Object, e As EventArgs) Handles qualNxt.Click
      qualificationsBindingSource.MoveNext()
      numQual.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
   End Sub

   Private Sub qualLast_Click(sender As Object, e As EventArgs) Handles qualLast.Click
      qualificationsBindingSource.MoveLast()
      numQual.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
   End Sub

   Private Sub expFirst_Click(sender As Object, e As EventArgs) Handles expFirst.Click
      experienceBindingSource.MoveFirst()
      numExp.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
   End Sub

   Private Sub expPre_Click(sender As Object, e As EventArgs) Handles expPre.Click
      experienceBindingSource.MovePrevious()
      numExp.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
   End Sub

   Private Sub expNxt_Click(sender As Object, e As EventArgs) Handles expNxt.Click
      experienceBindingSource.MoveNext()
      numExp.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
   End Sub

   Private Sub expLast_Click(sender As Object, e As EventArgs) Handles expLast.Click
      experienceBindingSource.MoveLast()
      numExp.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub
End Class