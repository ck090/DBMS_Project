Imports MySql.Data.MySqlClient

Public Class SuperUserUpdate

    Dim mysql As MySqlConnection
    Dim comm As MySqlCommand

    Private Sub JournalBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.JournalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JMDataSet)

    End Sub

    Private Sub SuperUserUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDataSet.Login1' table. You can move, or remove it, as needed.
        Me.Login1TableAdapter.Fill(Me.LoginDataSet.Login1)
        'TODO: This line of code loads data into the 'SuperUserDataSet.SUUS' table. You can move, or remove it, as needed.
        Me.SUUSTableAdapter.Fill(Me.SuperUserDataSet.SUUS)
        Timer1.Start()
        'TODO: This line of code loads data into the 'JMDataSet._Journal_Articles' table. You can move, or remove it, as needed.
        Me.Journal_ArticlesTableAdapter.Fill(Me.JMDataSet._Journal_Articles)
        'TODO: This line of code loads data into the 'JMDataSet.Author' table. You can move, or remove it, as needed.
        Me.AuthorTableAdapter.Fill(Me.JMDataSet.Author)
        'TODO: This line of code loads data into the 'JMDataSet.Journal_Disciplines' table. You can move, or remove it, as needed.
        Me.Journal_DisciplinesTableAdapter.Fill(Me.JMDataSet.Journal_Disciplines)
        'TODO: This line of code loads data into the 'JMDataSet.Journal' table. You can move, or remove it, as needed.
        Me.JournalTableAdapter.Fill(Me.JMDataSet.Journal)
        'TODO: This line of code loads data into the 'JMDataSet.Sponsorers' table. You can move, or remove it, as needed.
        Me.SponsorersTableAdapter.Fill(Me.JMDataSet.Sponsorers)
        'TODO: This line of code loads data into the 'JMDataSet.Sponsorer_Locations' table. You can move, or remove it, as needed.
        Me.Sponsorer_LocationsTableAdapter.Fill(Me.JMDataSet.Sponsorer_Locations)
        'TODO: This line of code loads data into the 'JMDataSet.Sponsored' table. You can move, or remove it, as needed.
        Me.SponsoredTableAdapter.Fill(Me.JMDataSet.Sponsored)
        'TODO: This line of code loads data into the 'JMDataSet.Publisher_Domains' table. You can move, or remove it, as needed.
        Me.Publisher_DomainsTableAdapter.Fill(Me.JMDataSet.Publisher_Domains)
        'TODO: This line of code loads data into the 'JMDataSet.Publisher' table. You can move, or remove it, as needed.
        Me.PublisherTableAdapter.Fill(Me.JMDataSet.Publisher)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Mainlogin.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Count As Integer
        Count = AuthorBindingSource.Count
        Label2.Text = "There are a total of " + Count.ToString + " entires in the Journal Information DataBase"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Charts.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        SponsoredBindingSource.AddNew()
        Sponsorer_LocationsBindingSource.AddNew()
        SponsorersBindingSource.AddNew()
        Publisher_DomainsBindingSource.AddNew()
        PublisherBindingSource.AddNew()
        JournalBindingSource.AddNew()
        Journal_ArticlesBindingSource.AddNew()
        Journal_DisciplinesBindingSource.AddNew()
        AuthorBindingSource.AddNew()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        JMDataSet.EnforceConstraints = False
        Me.AuthorBindingSource.EndEdit()
        Me.Journal_DisciplinesBindingSource.EndEdit()
        Me.JournalBindingSource.EndEdit()
        Me.Journal_ArticlesBindingSource.EndEdit()
        Me.Publisher_DomainsBindingSource.EndEdit()
        Me.PublisherBindingSource.EndEdit()
        Me.SponsoredBindingSource.EndEdit()
        Me.Sponsorer_LocationsBindingSource.EndEdit()
        Me.SponsorersBindingSource.EndEdit()

        Me.AuthorTableAdapter.Update(JMDataSet.Author)
        Me.Journal_DisciplinesTableAdapter.Update(JMDataSet.Journal_Disciplines)
        Me.JournalTableAdapter.Update(JMDataSet.Journal)
        Me.Journal_ArticlesTableAdapter.Update(JMDataSet._Journal_Articles)
        Me.Publisher_DomainsTableAdapter.Update(JMDataSet.Publisher_Domains)
        Me.SponsoredTableAdapter.Update(JMDataSet.Sponsored)
        Me.SponsorersTableAdapter.Update(JMDataSet.Sponsorers)
        Me.Sponsorer_LocationsTableAdapter.Update(JMDataSet.Sponsorer_Locations)

        MessageBox.Show("Journal Has Been Successfully Saved ... !!", "SAVED")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        JMDataSet.EnforceConstraints = False
        Me.AuthorBindingSource.EndEdit()
        Me.Journal_DisciplinesBindingSource.EndEdit()
        Me.JournalBindingSource.EndEdit()
        Me.Journal_ArticlesBindingSource.EndEdit()
        Me.Publisher_DomainsBindingSource.EndEdit()
        Me.PublisherBindingSource.EndEdit()
        Me.SponsoredBindingSource.EndEdit()
        Me.Sponsorer_LocationsBindingSource.EndEdit()
        Me.SponsorersBindingSource.EndEdit()

        Me.AuthorTableAdapter.Update(JMDataSet.Author)
        Me.Journal_DisciplinesTableAdapter.Update(JMDataSet.Journal_Disciplines)
        Me.JournalTableAdapter.Update(JMDataSet.Journal)
        Me.Journal_ArticlesTableAdapter.Update(JMDataSet._Journal_Articles)
        Me.Publisher_DomainsTableAdapter.Update(JMDataSet.Publisher_Domains)
        Me.SponsoredTableAdapter.Update(JMDataSet.Sponsored)
        Me.SponsorersTableAdapter.Update(JMDataSet.Sponsorers)
        Me.Sponsorer_LocationsTableAdapter.Update(JMDataSet.Sponsorer_Locations)

        MessageBox.Show("Journal Has Been Successfully Updated ... !!", "UPDATED")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Select Case MessageBox.Show("Are you Sure you want to delete..!", "Message", MessageBoxButtons.YesNo)
            Case MsgBoxResult.Yes
                Try
                    AuthorBindingSource.RemoveCurrent()
                    Journal_DisciplinesBindingSource.RemoveCurrent()
                    JournalBindingSource.RemoveCurrent()
                    Journal_ArticlesBindingSource.RemoveCurrent()
                    Publisher_DomainsBindingSource.RemoveCurrent()
                    PublisherBindingSource.RemoveCurrent()
                    SponsoredBindingSource.RemoveCurrent()
                    Sponsorer_LocationsBindingSource.RemoveCurrent()
                    SponsorersBindingSource.RemoveCurrent()
                Catch ex As Exception
                    MessageBox.Show("Cannot Delete last file ... !!", "DELETED")
                End Try

            Case MsgBoxResult.No
                ''nothing
        End Select

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim Jname As String
        Dim Pname As String
        Dim Sname As String

        Jname = Journal_NameTextBox.Text
        Journal_NameTextBox1.Text = Jname
        Name_JournalTextBox.Text = Jname
        Name_JournalTextBox1.Text = Jname

        Pname = Name_PublisherTextBox.Text
        Name_PublisherTextBox1.Text = Pname
        Pub_NameTextBox.Text = Pname

        Sname = Name_SponsorerTextBox.Text
        Name_SponsorerTextBox1.Text = Sname
        Sponsorer_NameTextBox.Text = Sname

        JMDataSet.EnforceConstraints = False
        AuthorBindingSource.MoveNext()
        Journal_DisciplinesBindingSource.MoveNext()
        JournalBindingSource.MoveNext()
        Publisher_DomainsBindingSource.MoveNext()
        PublisherBindingSource.MoveNext()
        SponsoredBindingSource.MoveNext()
        Sponsorer_LocationsBindingSource.MoveNext()
        SponsorersBindingSource.MoveNext()
        Journal_ArticlesBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Dim Jname As String
        Dim Pname As String
        Dim Sname As String

        Jname = Journal_NameTextBox.Text
        Journal_NameTextBox1.Text = Jname
        Name_JournalTextBox.Text = Jname
        Name_JournalTextBox1.Text = Jname

        Pname = Name_PublisherTextBox.Text
        Name_PublisherTextBox1.Text = Pname
        Pub_NameTextBox.Text = Pname

        Sname = Name_SponsorerTextBox.Text
        Name_SponsorerTextBox1.Text = Sname
        Sponsorer_NameTextBox.Text = Sname

        JMDataSet.EnforceConstraints = False
        AuthorBindingSource.MovePrevious()
        Journal_DisciplinesBindingSource.MovePrevious()
        JournalBindingSource.MovePrevious()
        Journal_ArticlesBindingSource.MovePrevious()
        Publisher_DomainsBindingSource.MovePrevious()
        PublisherBindingSource.MovePrevious()
        SponsoredBindingSource.MovePrevious()
        Sponsorer_LocationsBindingSource.MovePrevious()
        SponsorersBindingSource.MovePrevious()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Dim Jname As String
        Dim Pname As String
        Dim Sname As String

        Jname = Journal_NameTextBox.Text
        Journal_NameTextBox1.Text = Jname
        Name_JournalTextBox.Text = Jname
        Name_JournalTextBox1.Text = Jname

        Pname = Name_PublisherTextBox.Text
        Name_PublisherTextBox1.Text = Pname
        Pub_NameTextBox.Text = Pname

        Sname = Name_SponsorerTextBox.Text
        Name_SponsorerTextBox1.Text = Sname
        Sponsorer_NameTextBox.Text = Sname

        JMDataSet.EnforceConstraints = False
        AuthorBindingSource.MoveLast()
        Journal_DisciplinesBindingSource.MoveLast()
        JournalBindingSource.MoveLast()
        Journal_ArticlesBindingSource.MoveLast()
        Publisher_DomainsBindingSource.MoveLast()
        PublisherBindingSource.MoveLast()
        SponsoredBindingSource.MoveLast()
        Sponsorer_LocationsBindingSource.MoveLast()
        SponsorersBindingSource.MoveLast()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        JMDataSet.EnforceConstraints = False
        AuthorBindingSource.MoveFirst()
        Journal_DisciplinesBindingSource.MoveFirst()
        JournalBindingSource.MoveFirst()
        Journal_ArticlesBindingSource.MoveFirst()
        Publisher_DomainsBindingSource.MoveFirst()
        PublisherBindingSource.MoveFirst()
        SponsoredBindingSource.MoveFirst()
        Sponsorer_LocationsBindingSource.MoveFirst()
        SponsorersBindingSource.MoveFirst()
    End Sub

    'Dim Jname As String
    'Dim Pname As String
    'Dim Sname As String

    '   Jname = Journal_NameTextBox.Text
    '  Journal_NameTextBox1.Text = Jname
    ' Name_JournalTextBox.Text = Jname
    'Name_JournalTextBox1.Text = Jname
    '
    '   Pname = Name_PublisherTextBox.Text
    '  Name_PublisherTextBox1.Text = Pname
    '   Pub_NameTextBox.Text = Pname
    '
    '   Sname = Name_SponsorerTextBox.Text
    '  Name_SponsorerTextBox1.Text = Sname
    ' Sponsorer_NameTextBox.Text = Sname

    Private Sub Journal_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Journal_NameTextBox.Click
        Dim Jname As String

        Jname = Journal_NameTextBox.Text
        Journal_NameTextBox1.Text = Jname
        Name_JournalTextBox.Text = Jname
        Name_JournalTextBox1.Text = Jname
    End Sub

    Private Sub Name_PublisherTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_PublisherTextBox.Click
        Dim Pname As String
        Pname = Name_PublisherTextBox.Text
        Name_PublisherTextBox1.Text = Pname
        Pub_NameTextBox.Text = Pname
    End Sub

    Private Sub Name_SponsorerTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_SponsorerTextBox.Click
        Dim Sname As String
        Sname = Name_SponsorerTextBox.Text
        Name_SponsorerTextBox1.Text = Sname
        Sponsorer_NameTextBox.Text = Sname
    End Sub

    Private Sub Name_PublisherTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Name_PublisherTextBox1.TextChanged

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim val1, val2, val3, val4, val5, val6 As Integer
        val1 = AuthorBindingSource.Count
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\N Chandra Kanth\Desktop\Report of Journals.txt", True)
        file.Write("Number of Journal: ")
        file.WriteLine(val1)
        file.Write("Number of Publishers: ")
        val2 = PublisherBindingSource.Count
        file.WriteLine(val2)
        file.Write("Last Updated: ")
        file.Write(TimeOfDay)
        file.WriteLine(DayOfWeek.Friday)
        file.Write("Number of SuperUser with login ID: ")
        val3 = SUUSBindingSource.Count
        file.WriteLine(val3)
        file.Write("Number of User with Login ID: ")
        val4 = Login1BindingSource.Count
        file.WriteLine(val4)
        file.Write("Number of Authors: ")
        file.WriteLine(val1)
        file.Write("Number of Journal Citation Report: ")
        val5 = Journal_DisciplinesBindingSource.Count
        file.WriteLine(val5)
        file.Write("Number of Sponsorers: ")
        val6 = SponsoredBindingSource.Count
        file.WriteLine(val6)
        file.Write("Number of Location of Sponsorers: ")
        file.WriteLine(val6)
        file.Close()
        MessageBox.Show(" Report Generated and saved on Desktop", "Report", MessageBoxButtons.OK)
    End Sub
End Class
