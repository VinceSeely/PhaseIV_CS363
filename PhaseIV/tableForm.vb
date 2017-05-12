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

      txtQualDate.DataBindings.Add("Text", qualificationsBindingSource, "qualDate")
      txtType.DataBindings.Add("Text", qualificationsBindingSource, "type")
      txtInsName.DataBindings.Add("Text", qualificationsBindingSource, "instName")

      txtOrgName.DataBindings.Add("Text", experienceBindingSource, "orgName")
      txtExpPos.DataBindings.Add("Text", experienceBindingSource, "position")
      txtStart.DataBindings.Add("Text", experienceBindingSource, "startDate")
      txtFinish.DataBindings.Add("Text", experienceBindingSource, "finishDate")

      experienceDataView.RowFilter = "StaffNo = '" & txtStaffNo.Text & "'"
      qualificationsDataView.RowFilter = "StaffNo = '" & txtStaffNo.Text & "'"
      numEmp.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      numQual.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
      numExp.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
   End Sub

   Private Sub empFirst_Click(sender As Object, e As EventArgs) Handles empFirst.Click
      staffBindingSource.MoveFirst()
      numEmp.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      experienceDataView.RowFilter = "StaffNo = '" & txtStaffNo.Text & "'"
      qualificationsDataView.RowFilter = "StaffNo = '" & txtStaffNo.Text & "'"
      numQual.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
      numExp.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
   End Sub

   Private Sub empPre_Click(sender As Object, e As EventArgs) Handles empPre.Click
      staffBindingSource.MovePrevious()
      numEmp.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      experienceDataView.RowFilter = "StaffNo = '" & txtStaffNo.Text & "'"
      qualificationsDataView.RowFilter = "StaffNo = '" & txtStaffNo.Text & "'"
      numQual.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
      numExp.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
   End Sub

   Private Sub empNxt_Click(sender As Object, e As EventArgs) Handles empNxt.Click
      staffBindingSource.MoveNext()
      numEmp.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      experienceDataView.RowFilter = "StaffNo = '" & txtStaffNo.Text & "'"
      qualificationsDataView.RowFilter = "StaffNo = '" & txtStaffNo.Text & "'"
      numQual.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
      numExp.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
   End Sub

   Private Sub empLast_Click(sender As Object, e As EventArgs) Handles empLast.Click
      staffBindingSource.MoveLast()
      numEmp.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      experienceDataView.RowFilter = "StaffNo = '" & txtStaffNo.Text & "'"
      qualificationsDataView.RowFilter = "StaffNo = '" & txtStaffNo.Text & "'"
      numQual.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
      numExp.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
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

   Private Sub empNew_Click(sender As Object, e As EventArgs) Handles empNew.Click
      Dim r As DataRow

      r = Oracle.staffTable.NewRow
      Oracle.staffTable.Rows.Add(r)
      ' The new row is added at the end
      staffBindingSource.MoveLast()

      txtPosition.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
   End Sub

   Private Sub empSave_Click(sender As Object, e As EventArgs) Handles empSave.Click
      Try
         staffBindingSource.EndEdit()
         Oracle.staffAdapter.Update(Oracle.staffTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub empDelete_Click(sender As Object, e As EventArgs) Handles empDelete.Click
      Try
         staffBindingSource.RemoveCurrent()
         txtPosition.Text = (staffBindingSource.Position + 1) & "/" & staffBindingSource.Count
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub qualNew_Click(sender As Object, e As EventArgs) Handles qualNew.Click
      Dim r As DataRow

      r = Oracle.qualificationsTable.NewRow
      Oracle.qualificationsTable.Rows.Add(r)
      ' The new row is added at the end
      qualificationsBindingSource.MoveLast()

      txtPosition.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
   End Sub

   Private Sub qualSave_Click(sender As Object, e As EventArgs) Handles qualSave.Click
      Try
         qualificationsBindingSource.EndEdit()
         Oracle.qualificationsAdapter.Update(Oracle.qualificationsTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub qualDelete_Click(sender As Object, e As EventArgs) Handles qualDelete.Click
      Try
         qualificationsBindingSource.RemoveCurrent()
         txtPosition.Text = (qualificationsBindingSource.Position + 1) & "/" & qualificationsBindingSource.Count
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub expNew_Click(sender As Object, e As EventArgs) Handles expNew.Click
      Dim r As DataRow

      r = Oracle.experienceTable.NewRow
      Oracle.experienceTable.Rows.Add(r)
      ' The new row is added at the end
      experienceBindingSource.MoveLast()

      txtPosition.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
   End Sub

   Private Sub expSave_Click(sender As Object, e As EventArgs) Handles expSave.Click
      Try
         experienceBindingSource.EndEdit()
         Oracle.experienceAdapter.Update(Oracle.experienceTable)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub expDelete_Click(sender As Object, e As EventArgs) Handles expDelete.Click
      Try
         experienceBindingSource.RemoveCurrent()
         txtPosition.Text = (experienceBindingSource.Position + 1) & "/" & experienceBindingSource.Count
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
      Oracle.staffCommand.CommandText = "Select * from UWP_Staff"

      Oracle.staffTable.Clear()
      Oracle.staffAdapter.Fill(Oracle.staffTable)
   End Sub

   Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
      Dim searchPhrase = "Select * from UWP_Staff join UWP_WorkExperience on UWP_Staff.staffNo = UWP_WorkExperience.staffNo join UWP_Qualifications on UWP_Staff.staffNo = UWP_Qualifications.staffNo  where " & cboField.Text & " = '" & txtValue.Text & "'"
      Oracle.staffCommand.CommandText = searchPhrase
      Oracle.experienceCommand.CommandText = searchPhrase
      Oracle.qualificationsCommand.CommandText = searchPhrase
      Oracle.staffTable.Clear()
      Oracle.staffAdapter.Fill(Oracle.staffTable)
      Oracle.qualificationsTable.Clear()
      Oracle.qualificationsAdapter.Fill(Oracle.qualificationsTable)
      Oracle.experienceTable.Clear()
      Oracle.experienceAdapter.Fill(Oracle.experienceTable)
   End Sub
End Class