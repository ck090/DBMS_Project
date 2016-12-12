Imports MySql.Data.MySqlClient

Public Class Login

    Dim mysql As MySqlConnection
    Dim mysq As MySqlConnection
    Dim Comm As MySqlCommand



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Mainlogin.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mysq = New MySqlConnection
        mysq.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=login"
        Dim reader As MySqlDataReader

        Try
            mysq.Open()
            Dim Query As String
            Query = "select * from login.login_table where Username = '" & TextBox1.Text & "' and Password = '" & TextBox2.Text & "' "
            Comm = New MySqlCommand(Query, mysq)
            reader = Comm.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Correct Username and Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBox1.Clear()
                TextBox2.Clear()
                Main_Page.Show()
                Me.Close()
            ElseIf count > 1 Then
                MessageBox.Show("Duplicate Username and Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Clear()
                TextBox2.Clear()
            Else
                MessageBox.Show("Wrong Username and Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Clear()
                TextBox2.Clear()
            End If

            mysq.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysq.Dispose()

        End Try

    End Sub
End Class