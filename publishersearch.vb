Imports MySql.Data.MySqlClient
Public Class publishersearch
    Dim mysql As MySqlConnection
    Dim Comm As MySqlCommand
    Dim db As New DataTable

    Private Sub Load_table()
        mysql = New MySqlConnection
        mysql.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource

        Try
            mysql.Open()
            Dim query As String
            query = "select * from journal.publisher"
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            Pub_NameTextBox.Text = row.Cells("Name").Value.ToString
            CountryTextBox.Text = row.Cells("Country").Value.ToString
            Num_of_JournalsTextBox.Text = row.Cells("No._of_Journals_Published").Value.ToString

        End If
    End Sub

    Private Sub publishersearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_table()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Dim DV As New DataView(db)
        DV.RowFilter = String.Format("Name Like '%{0}%'", TextBox5.Text)
        DataGridView1.DataSource = DV
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main_Page.Show()
        Me.Close()
    End Sub
End Class