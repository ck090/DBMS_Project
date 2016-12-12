Imports MySql.Data.MySqlClient

Public Class SuperUser

    Dim mysql As MySqlConnection
    Dim Comm As MySqlCommand

    Private Sub Login1BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Data)

    End Sub

    Private Sub SuperUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Data.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Data.Table1)
        'TODO: This line of code loads data into the 'LogDataSet.Table1' table. You can move, or remove it, as needed.
        'Me.Table1TableAdapter.Fill(Me.LogDataSet.Table1)
        'TODO: This line of code loads data into the 'LoginDataSet.Login1' table. You can move, or remove it, as needed.
        'Me.Login1TableAdapter.Fill(Me.LoginDataSet.Login1)
        Load_table()

    End Sub

    Private Sub Load_table()
        mysql = New MySqlConnection
        mysql.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=login"
        Dim SDA As New MySqlDataAdapter
        Dim db As New DataTable
        Dim bsource As New BindingSource

        Try
            mysql.Open()
            Dim query As String
            query = "select * from login.login_table"
            Comm = New MySqlCommand(query, mysql)
            SDA.SelectCommand = Comm
            SDA.Fill(db)
            bsource.DataSource = db
            DataGridView1.DataSource = bsource
            SDA.Update(db)
            mysql.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mysql.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each Row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(Row)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Mainlogin.Show()
    End Sub
End Class