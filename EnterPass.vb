Imports MySql.Data.MySqlClient

Public Class EnterPass

    Dim mysql As MySqlConnection
    Dim mysq As MySqlConnection
    Dim Comm As MySqlCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mysq = New MySqlConnection
        mysq.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=superuser"
        Dim reader As MySqlDataReader

        Try
            mysq.Open()
            Dim Query As String
            Query = "select * from superuser.super where password = '" & TextBox1.Text & "' "
            Comm = New MySqlCommand(Query, mysq)
            reader = Comm.ExecuteReader
            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                If CheckBox1.Checked Then
                    MessageBox.Show("Correct Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Addnewuser.Show()
                    Me.Close()
                ElseIf CheckBox2.Checked Then
                    MessageBox.Show("Correct Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SuperUser.Show()
                    Me.Close()
                ElseIf CheckBox3.Checked Then
                    MessageBox.Show("Correct Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    adminform.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Select any checkbox to proceed..!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
                TextBox1.Clear()
            ElseIf count > 1 Then
                MessageBox.Show("Duplicate Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Clear()
            Else
                MessageBox.Show("Wrong Password", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextBox1.Clear()
            End If

            mysq.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysq.Dispose()

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Mainlogin.Show()
        Me.Close()
    End Sub

    Private Sub EnterPass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub
End Class