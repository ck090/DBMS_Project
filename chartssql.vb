Imports MySql.Data.MySqlClient

Public Class chartssql
    Dim mysql As MySqlConnection
    Dim mysq As MySqlConnection
    Dim mys As MySqlConnection
    Dim Comm As MySqlCommand
    Dim tex1t As String

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "select * from journal.sponsors"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            While reader.Read
                Chart1.Series("Publisher vs Money").Points.AddXY(reader.GetString("Name"), reader.GetUInt32("Money_Spent"))
                Chart1.Series("Publisher vs No of Journals").Points.AddXY(reader.GetString("Name"), reader.GetUInt32("No_of_Sponsorships"))
            End While
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "select * from journal.publisher"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            While reader.Read
                Chart2.Series("Publisher vs No of Journals Published").Points.AddXY(reader.GetString("Name"), reader.GetUInt32("No_of_Journals_Published"))
            End While
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "select * from journal.journal_articles"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            While reader.Read
                Chart3.Series("Series1").Points.AddXY(reader.GetString("Name_Journal"), reader.GetUInt32("Citations"))
            End While
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "select * from journal.journal_citation_report"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            While reader.Read
                Chart4.Series("Journal vs IF").Points.AddXY(reader.GetString("Name_of_Journal"), reader.GetUInt32("Journal_Impact_Factor"))
            End While
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub chartssql_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.PerformClick()
        Button6.PerformClick()
        Button2.PerformClick()
        Button3.PerformClick()
    End Sub

    Private Sub chartssql_Lad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        adminform.Show()
        Me.Close()
    End Sub
End Class