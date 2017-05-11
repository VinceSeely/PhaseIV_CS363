Public Class Oracle
   Friend Shared EmployeeRegistry As New tableForm

   Friend Shared UserName As String
   Friend Shared Password As String
   Friend Shared Server As String
   Friend Shared Result As ResponseType
   Public Enum ResponseType
      OK
      Cancel
   End Enum

   Friend Shared myConnection As New System.Data.OleDb.OleDbConnection

   Friend Shared staffAdapter As New System.Data.OleDb.OleDbDataAdapter
   Friend Shared staffCommand As New System.Data.OleDb.OleDbCommand
   Friend Shared staffBuilder As System.Data.OleDb.OleDbCommandBuilder
   Friend Shared staffTable As New System.Data.DataTable("staff")

   ' variable for booking
   ' . . .

   ' One command, adapter and builder for each table
   Friend Shared experienceAdapter As New System.Data.OleDb.OleDbDataAdapter
   Friend Shared experienceCommand As New System.Data.OleDb.OleDbCommand
   Friend Shared experienceBuilder As System.Data.OleDb.OleDbCommandBuilder
   Friend Shared experienceTable As New System.Data.DataTable("experience")

   Friend Shared qualificationsAdapter As New System.Data.OleDb.OleDbDataAdapter
   Friend Shared qualificationsCommand As New System.Data.OleDb.OleDbCommand
   Friend Shared qualificationsBuilder As System.Data.OleDb.OleDbCommandBuilder
   Friend Shared qualificationsTable As New System.Data.DataTable("qualifications")

   Public Shared Sub LogInAtRunTime()
      UserName = "seelyv"
      Password = "ubZM9cmoUV&^"
      Server = "eddb"
      myConnection.ConnectionString = "Provider=MSDAORA;user id=" & UserName & ";data source=" & Server &
                                      ";password=" & Password & ";persist security info=False"

      staffCommand.CommandType = CommandType.Text
      staffCommand.CommandText = "Select * from UWP_Staff"
      staffCommand.Connection = myConnection

      staffAdapter.SelectCommand = staffCommand
      staffBuilder = New System.Data.OleDb.OleDbCommandBuilder(staffAdapter)
      staffAdapter.Fill(staffTable)

      experienceCommand.CommandType = CommandType.Text
      experienceCommand.CommandText = "Select * from UWP_WorkExperience"
      experienceCommand.Connection = myConnection

      experienceAdapter.SelectCommand = experienceCommand
      experienceBuilder = New System.Data.OleDb.OleDbCommandBuilder(experienceAdapter)
      experienceAdapter.Fill(experienceTable)

      qualificationsCommand.CommandType = CommandType.Text
      qualificationsCommand.CommandText = "Select * from UWP_Qualifications"
      qualificationsCommand.Connection = myConnection

      qualificationsAdapter.SelectCommand = qualificationsCommand
      qualificationsBuilder = New System.Data.OleDb.OleDbCommandBuilder(qualificationsAdapter)
      qualificationsAdapter.Fill(qualificationsTable)
   End Sub

   Public Shared Sub main()
      Dim connected As Boolean

      While Not connected
         LoginForm.ShowDialog()
         If Result = ResponseType.Cancel Then
            Exit While
         End If

         Try
            LogInAtRunTime()
            connected = True
         Catch ex As Exception
            MessageBox.Show(ex.Message)
         End Try
      End While
      If connected Then
         Application.Run(EmployeeRegistry)
      End If
   End Sub
End Class
