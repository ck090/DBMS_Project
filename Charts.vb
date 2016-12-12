Public Class Charts

    Private Sub Journal_Citations_ReportBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()

    End Sub

    Private Sub Charts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JMDataSet.Sponsored' table. You can move, or remove it, as needed.
        Me.SponsoredTableAdapter.Fill(Me.JMDataSet.Sponsored)
        'TODO: This line of code loads data into the 'SuperUserDataSet.SUUS' table. You can move, or remove it, as needed.
        Me.SUUSTableAdapter.Fill(Me.SuperUserDataSet.SUUS)
        'TODO: This line of code loads data into the 'LoginDataSet.Login1' table. You can move, or remove it, as needed.
        Me.Login1TableAdapter.Fill(Me.LoginDataSet.Login1)
        'TODO: This line of code loads data into the 'JMDataSet.Publisher' table. You can move, or remove it, as needed.
        Me.PublisherTableAdapter.Fill(Me.JMDataSet.Publisher)
        'TODO: This line of code loads data into the 'LogDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.LogDataSet.Table1)
        'TODO: This line of code loads data into the 'JMDataSet.Journal_Disciplines' table. You can move, or remove it, as needed.
        Me.Journal_DisciplinesTableAdapter.Fill(Me.JMDataSet.Journal_Disciplines)
        'TODO: This line of code loads data into the 'JMDataSet._Journal_Citations_Report' table. You can move, or remove it, as needed.
        'Me.Journal_Citations_ReportTableAdapter.Fill(Me.JMDataSet._Journal_Citations_Report)
        'TODO: This line of code loads data into the 'JMDataSet._Journal_Articles' table. You can move, or remove it, as needed.
        Me.Journal_ArticlesTableAdapter.Fill(Me.JMDataSet._Journal_Articles)
        'TODO: This line of code loads data into the 'JMDataSet.Author' table. You can move, or remove it, as needed.
        Me.AuthorTableAdapter.Fill(Me.JMDataSet.Author)
        'TODO: This line of code loads data into the 'JMDataSet.Journal' table. You can move, or remove it, as needed.
        Me.JournalTableAdapter.Fill(Me.JMDataSet.Journal)

    End Sub

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim val1, val2, val3, val4, val5, val6 As Integer
        val1 = AuthorBindingSource.Count
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\N Chandra Kanth\Desktop\Report of Journals Users.txt", True)
        file.Write("Number of Journal: ")
        file.WriteLine(val1)
        file.Write("Number of Publishers: ")
        val2 = PublisherBindingSource.Count
        file.WriteLine(val2)
        file.Write("Number of SuperUser with login ID: ")
        val3 = SUUSBindingSource.Count
        file.WriteLine(val3)
        file.Write("Number of User with Login ID: ")
        val4 = Login1BindingSource.Count
        file.WriteLine(val4)
        file.Write("Number of Authors: ")
        file.WriteLine(val1)
        file.Write("Number of Journal Citation Report: ")
        val5 = JournalArticlesBindingSource.Count
        file.WriteLine(val5)
        file.Write("Number of Sponsorers: ")
        val6 = SponsoredBindingSource.Count
        file.WriteLine(val6)
        file.Write("Number of Location of Sponsorers: ")
        file.WriteLine(val6)
        file.Close()
        MessageBox.Show(" Report Generated and saved on Desktop", "Report", MessageBoxButtons.OK)
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Main_Page.Show()
    End Sub
End Class