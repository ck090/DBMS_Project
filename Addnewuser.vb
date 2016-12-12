Imports MySql.Data.MySqlClient

Public Class Addnewuser

    Dim mys As MySqlConnection
    Dim Comm As MySqlCommand

    Private Sub Table1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Data)

    End Sub

    Private Sub Addnewuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Data.Table1' table. You can move, or remove it, as needed.
        'Me.Table1TableAdapter.Fill(Me.Data.Table1)
        'TODO: This line of code loads data into the 'LogDataSet.Table1' table. You can move, or remove it, as needed.
        'Me.Table1TableAdapter.Fill(Me.LogDataSet.Table1)
        Me.Table1BindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim str1, str2 As String
        str1 = TextBox1.Text
        str2 = TextBox2.Text
        If String.Compare(str1, str2) = 0 Then
            ''nothing
        Else
            MessageBox.Show("Passwords don't match")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            Exit Sub
        End If

        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=login"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "insert into login.login_table (Username, Password) values ('" & TextBox3.Text & "', '" & TextBox2.Text & "')"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("User data is saved..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
        'Dim Str1 As String
        'Str1 = PasswordTextBox.Text
        'Dim str2 As String
        'str2 = TextBox1.Text
        'If StrComp(Str1, str2) = 0 Then
        'Me.Table1BindingSource.EndEdit()
        'Me.Table1TableAdapter.Update(Data.Table1)
        'MsgBox("New User Saved and Updated.!")
        'UsernameTextBox.Clear()
        'PasswordTextBox.Clear()
        'TextBox1.Clear()
        'Else
        'MessageBox.Show("Passwords didn't match", "PASSWORD MATCHING", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'PasswordTextBox.Clear()
        'TextBox1.Clear()
        'UsernameTextBox.Clear()
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Table1BindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Data)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
    End Sub
End Class