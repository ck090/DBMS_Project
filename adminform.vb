Imports MySql.Data.MySqlClient

Public Class adminform
    Dim mysql As MySqlConnection
    Dim mysq As MySqlConnection
    Dim mys As MySqlConnection
    Dim Comm As MySqlCommand
    Dim tex1t As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "insert into journal.publisher (Name, Country, No_of_Journals_Published) values ('" & Name_PublisherTextBox1.Text & "', '" & CountryTextBox.Text & "', '" & Num_of_JournalsTextBox.Text & "'); insert into journal.journal (Name_Publisher, Name_Journal, Date_of_Publishing, Access) values ('" & Name_PublisherTextBox1.Text & "', '" & Journal_NameTextBox.Text & "', '" & TextBox1.Text & "', '" & ISSNTextBox.Text & "'); insert into journal.publisher_domain (Name_Publisher, Domain) values ('" & Name_PublisherTextBox1.Text & "', '" & DomainTextBox.Text & "');  insert into journal.journal_articles (Name_Journal, Title, DOI, Citations) values ('" & Journal_NameTextBox.Text & "', '" & TitleTextBox.Text & "', '" & DOITextBox.Text & "', '" & CitationsTextBox.Text & "');  insert into journal.sponsors (Name, No_of_Sponsorships, Address, Money_Spent) values ('" & Name_SponsorerTextBox1.Text & "', '" & Num_of_SponsorshipsTextBox.Text & "', '" & LocationTextBox.Text & "', '" & Money_SpentTextBox.Text & "'); insert into journal.journal_citation_report (ISSN, Journal_Impact_Factor, Citation_Index) values ('" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "'); insert into journal.author (ORCID, F_Name, L_Name, University, Co_Author, E_Mail) values ('" & ORCIDTextBox.Text & "', '" & F_NameTextBox.Text & "', '" & L_NameTextBox.Text & "', '" & UniversityTextBox.Text & "', '" & Co_AuthorTextBox.Text & "', '" & E_mailTextBox.Text & "') "
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is saved..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub adminform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        GroupBox5.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
        GroupBox4.Enabled = True
        GroupBox6.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tex1t = ComboBox2.Text

        If StrComp(tex1t, "Journal Name") = 0 Then
            Updatejournal()
        ElseIf StrComp(tex1t, "ORCID") = 0 Then
            UpdateAuthor()
        ElseIf StrComp(tex1t, "DOI of Journal Article") = 0 Then
            UpdateJArticle()
        ElseIf StrComp(tex1t, "ISSN") = 0 Then
            UpdateJCR()
        ElseIf StrComp(tex1t, "Name of Sponsor") = 0 Then
            UpdateSponsor()
        ElseIf StrComp(tex1t, "Name of Publisher") = 0 Then
            Updatepublisher()
            UpdatePubdomain()
        Else
            MessageBox.Show("Select one Value from the ComboBox to Continue", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.TextChanged
        tex1t = ComboBox2.Text

        If StrComp(tex1t, "Journal Name") = 0 Then
            GroupBox5.Enabled = True
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            GroupBox6.Enabled = False
        ElseIf StrComp(tex1t, "ORCID") = 0 Then
            GroupBox4.Enabled = True
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox5.Enabled = False
            GroupBox6.Enabled = False
        ElseIf StrComp(tex1t, "DOI of Journal Article") = 0 Then
            GroupBox1.Enabled = True
            GroupBox5.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            GroupBox6.Enabled = False
        ElseIf StrComp(tex1t, "ISSN") = 0 Then
            GroupBox6.Enabled = True
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            GroupBox5.Enabled = False
        ElseIf StrComp(tex1t, "Name of Sponsor") = 0 Then
            GroupBox2.Enabled = True
            GroupBox1.Enabled = False
            GroupBox5.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
            GroupBox6.Enabled = False
        ElseIf StrComp(tex1t, "Name of Publisher") = 0 Then
            GroupBox3.Enabled = True
            GroupBox1.Enabled = False
            GroupBox5.Enabled = False
            GroupBox2.Enabled = False
            GroupBox4.Enabled = False
            GroupBox6.Enabled = False
        End If

    End Sub

    Private Sub Updatepublisher()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "update journal.publisher set Name = '" & Name_PublisherTextBox1.Text & "', Country = '" & CountryTextBox.Text & "',  No_of_Journals_Published = '" & Num_of_JournalsTextBox.Text & "' where Name = '" & Name_PublisherTextBox1.Text & "'"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is Updated..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub Updatejournal()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = " update journal.journal set Name_Publisher = '" & Name_PublisherTextBox1.Text & "', Name_Journal = '" & Journal_NameTextBox.Text & "', Date_of_Publishing = '" & TextBox1.Text & "', Access = '" & ISSNTextBox.Text & "' where  Name_Journal = '" & Journal_NameTextBox.Text & "'"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is Updated..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub UpdateJArticle()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "  update journal.journal_articles set Name_Journal = '" & Journal_NameTextBox.Text & "', Title = '" & TitleTextBox.Text & "', DOI = '" & DOITextBox.Text & "', Citations = '" & CitationsTextBox.Text & "' where  DOI = '" & DOITextBox.Text & "'"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is Updated..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub UpdateSponsor()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = " update journal.sponsors set  Name = '" & Name_SponsorerTextBox1.Text & "', No_of_Sponsorships = '" & Num_of_SponsorshipsTextBox.Text & "', Address = '" & LocationTextBox.Text & "', Money_Spent = '" & Money_SpentTextBox.Text & "' where Name = '" & Name_SponsorerTextBox1.Text & "'"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is saved..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub UpdatePubdomain()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "update journal.publisher_domain set Name_Publisher = '" & Name_PublisherTextBox1.Text & "', Domain = '" & DomainTextBox.Text & "' where Name_Publisher = '" & Name_PublisherTextBox1.Text & "' "
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is saved..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub UpdateAuthor()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = " update journal.author set ORCID = '" & ORCIDTextBox.Text & "', F_Name = '" & F_NameTextBox.Text & "', L_Name = '" & L_NameTextBox.Text & "', University = '" & UniversityTextBox.Text & "', Co_Author = '" & Co_AuthorTextBox.Text & "', E_Mail = '" & E_mailTextBox.Text & "' where ORCID = '" & ORCIDTextBox.Text & "' "
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is saved..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub UpdateJCR()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = " update journal.journal_citation_report set ISSN = '" & TextBox2.Text & "', Journal_Impact_Factor = '" & TextBox3.Text & "', Citation_Index = '" & TextBox4.Text & "' where ISSN = '" & TextBox2.Text & "'"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is saved..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        tex1t = ComboBox2.Text

        If StrComp(tex1t, "Journal Name") = 0 Then
            Deletejournal()
            Journal_NameTextBox.Clear()
        ElseIf StrComp(tex1t, "ORCID") = 0 Then
            DeleteAuthor()
            ORCIDTextBox.Clear()
        ElseIf StrComp(tex1t, "DOI of Journal Article") = 0 Then
            DeleteJArticle()
            DOITextBox.Clear()
        ElseIf StrComp(tex1t, "ISSN") = 0 Then
            DeleteJCR()
            TextBox2.Clear()
        ElseIf StrComp(tex1t, "Name of Sponsor") = 0 Then
            DeleteSponsor()
            Name_SponsorerTextBox1.Clear()
        ElseIf StrComp(tex1t, "Name of Publisher") = 0 Then
            Deletepublisher()
            DeletePubdomain()
            Name_PublisherTextBox1.Clear()
            DomainTextBox.Clear()
        Else
            MessageBox.Show("Select one Value from the ComboBox to Continue", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Deletepublisher()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "delete from journal.publisher where Name = '" & Name_PublisherTextBox1.Text & "'"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is Deleted..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub Deletejournal()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = " delete from journal.journal where  Name_Journal = '" & Journal_NameTextBox.Text & "'"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is Deleted..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub DeleteJArticle()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "delete from journal.journal_articles where  DOI = '" & DOITextBox.Text & "'"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is Deleted..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub DeleteSponsor()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = " delete from journal.sponsors where Name = '" & Name_SponsorerTextBox1.Text & "'"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is Deleted..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub DeletePubdomain()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "delete from journal.publisher_domain where Name_Publisher = '" & Name_PublisherTextBox1.Text & "' "
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is Deleted..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub DeleteAuthor()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = "delete from journal.author where ORCID = '" & ORCIDTextBox.Text & "' "
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is Deleted..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub DeleteJCR()
        mys = New MySqlConnection
        mys.ConnectionString =
            "server=localhost;userid=root;password=Aiden8055;database=journal"
        Dim reader As MySqlDataReader

        Try
            mys.Open()
            Dim Query As String
            Query = " delete from journal.journal_citation_report where ISSN = '" & TextBox2.Text & "'"
            Comm = New MySqlCommand(Query, mys)
            reader = Comm.ExecuteReader
            MessageBox.Show("Data is Deleted..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mys.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            mys.Dispose()

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Mainlogin.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        alltables_.Show()
        Me.Hide()
    End Sub

    Private Sub adminform_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        chartssql.Show()
        Me.Hide()
    End Sub

End Class