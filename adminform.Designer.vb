<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Journal_NameLabel As System.Windows.Forms.Label
        Dim Date_of_PublishingLabel As System.Windows.Forms.Label
        Dim ISSNLabel As System.Windows.Forms.Label
        Dim ORCIDLabel As System.Windows.Forms.Label
        Dim F_NameLabel As System.Windows.Forms.Label
        Dim L_NameLabel As System.Windows.Forms.Label
        Dim UniversityLabel As System.Windows.Forms.Label
        Dim Co_AuthorLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim Num_of_SponsorshipsLabel As System.Windows.Forms.Label
        Dim Money_SpentLabel As System.Windows.Forms.Label
        Dim Name_SponsorerLabel1 As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim DOILabel As System.Windows.Forms.Label
        Dim CitationsLabel As System.Windows.Forms.Label
        Dim Name_PublisherLabel1 As System.Windows.Forms.Label
        Dim DomainLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Num_of_JournalsLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Journal_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ISSNTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ORCIDTextBox = New System.Windows.Forms.TextBox()
        Me.F_NameTextBox = New System.Windows.Forms.TextBox()
        Me.L_NameTextBox = New System.Windows.Forms.TextBox()
        Me.UniversityTextBox = New System.Windows.Forms.TextBox()
        Me.Co_AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Num_of_SponsorshipsTextBox = New System.Windows.Forms.TextBox()
        Me.Money_SpentTextBox = New System.Windows.Forms.TextBox()
        Me.Name_SponsorerTextBox1 = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.DOITextBox = New System.Windows.Forms.TextBox()
        Me.CitationsTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Num_of_JournalsTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Name_PublisherTextBox1 = New System.Windows.Forms.TextBox()
        Me.DomainTextBox = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AuthorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JMDataSet = New FinalJournal.JMDataSet()
        Me.AuthorTableAdapter = New FinalJournal.JMDataSetTableAdapters.AuthorTableAdapter()
        Me.TableAdapterManager = New FinalJournal.JMDataSetTableAdapters.TableAdapterManager()
        Me.Journal_ArticlesTableAdapter = New FinalJournal.JMDataSetTableAdapters.Journal_ArticlesTableAdapter()
        Me.Journal_Citations_ReportTableAdapter = New FinalJournal.JMDataSetTableAdapters.Journal_Citations_ReportTableAdapter()
        Me.Journal_DisciplinesTableAdapter = New FinalJournal.JMDataSetTableAdapters.Journal_DisciplinesTableAdapter()
        Me.JournalTableAdapter = New FinalJournal.JMDataSetTableAdapters.JournalTableAdapter()
        Me.Publisher_DomainsTableAdapter = New FinalJournal.JMDataSetTableAdapters.Publisher_DomainsTableAdapter()
        Me.PublisherTableAdapter = New FinalJournal.JMDataSetTableAdapters.PublisherTableAdapter()
        Me.SponsoredTableAdapter = New FinalJournal.JMDataSetTableAdapters.SponsoredTableAdapter()
        Me.Sponsorer_LocationsTableAdapter = New FinalJournal.JMDataSetTableAdapters.Sponsorer_LocationsTableAdapter()
        Me.SponsorersTableAdapter = New FinalJournal.JMDataSetTableAdapters.SponsorersTableAdapter()
        Me.WritesTableAdapter = New FinalJournal.JMDataSetTableAdapters.WritesTableAdapter()
        Me.JournalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Journal_DisciplinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Journal_ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PublisherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Publisher_DomainsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SponsoredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sponsorer_LocationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Journal_Citations_ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SponsorersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WritesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuperUserDataSet = New FinalJournal.SuperUserDataSet()
        Me.SUUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUUSTableAdapter = New FinalJournal.SuperUserDataSetTableAdapters.SUUSTableAdapter()
        Me.TableAdapterManager1 = New FinalJournal.SuperUserDataSetTableAdapters.TableAdapterManager()
        Me.LoginDataSet1 = New FinalJournal.loginDataSet1()
        Me.Login_tableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login_tableTableAdapter = New FinalJournal.loginDataSet1TableAdapters.login_tableTableAdapter()
        Me.TableAdapterManager2 = New FinalJournal.loginDataSet1TableAdapters.TableAdapterManager()
        Me.JournalDataSet = New FinalJournal.journalDataSet()
        Me.AuthorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuthorTableAdapter1 = New FinalJournal.journalDataSetTableAdapters.authorTableAdapter()
        Me.TableAdapterManager3 = New FinalJournal.journalDataSetTableAdapters.TableAdapterManager()
        Me.JournalBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.JournalTableAdapter1 = New FinalJournal.journalDataSetTableAdapters.journalTableAdapter()
        Me.PublisherBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PublisherTableAdapter1 = New FinalJournal.journalDataSetTableAdapters.publisherTableAdapter()
        Me.Journal_citation_reportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Journal_citation_reportTableAdapter = New FinalJournal.journalDataSetTableAdapters.journal_citation_reportTableAdapter()
        Me.SponsorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SponsorsTableAdapter = New FinalJournal.journalDataSetTableAdapters.sponsorsTableAdapter()
        Journal_NameLabel = New System.Windows.Forms.Label()
        Date_of_PublishingLabel = New System.Windows.Forms.Label()
        ISSNLabel = New System.Windows.Forms.Label()
        ORCIDLabel = New System.Windows.Forms.Label()
        F_NameLabel = New System.Windows.Forms.Label()
        L_NameLabel = New System.Windows.Forms.Label()
        UniversityLabel = New System.Windows.Forms.Label()
        Co_AuthorLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        Num_of_SponsorshipsLabel = New System.Windows.Forms.Label()
        Money_SpentLabel = New System.Windows.Forms.Label()
        Name_SponsorerLabel1 = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        DOILabel = New System.Windows.Forms.Label()
        CitationsLabel = New System.Windows.Forms.Label()
        Name_PublisherLabel1 = New System.Windows.Forms.Label()
        DomainLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Num_of_JournalsLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JournalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journal_DisciplinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journal_ArticlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublisherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Publisher_DomainsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponsoredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sponsorer_LocationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journal_Citations_ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponsorersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WritesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuperUserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login_tableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JournalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JournalBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublisherBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journal_citation_reportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponsorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Journal_NameLabel
        '
        Journal_NameLabel.AutoSize = True
        Journal_NameLabel.BackColor = System.Drawing.Color.Transparent
        Journal_NameLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Journal_NameLabel.Location = New System.Drawing.Point(16, 32)
        Journal_NameLabel.Name = "Journal_NameLabel"
        Journal_NameLabel.Size = New System.Drawing.Size(98, 19)
        Journal_NameLabel.TabIndex = 100
        Journal_NameLabel.Text = "Journal Name:"
        '
        'Date_of_PublishingLabel
        '
        Date_of_PublishingLabel.AutoSize = True
        Date_of_PublishingLabel.BackColor = System.Drawing.Color.Transparent
        Date_of_PublishingLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_PublishingLabel.Location = New System.Drawing.Point(16, 95)
        Date_of_PublishingLabel.Name = "Date_of_PublishingLabel"
        Date_of_PublishingLabel.Size = New System.Drawing.Size(127, 19)
        Date_of_PublishingLabel.TabIndex = 104
        Date_of_PublishingLabel.Text = "Date of Publishing:"
        '
        'ISSNLabel
        '
        ISSNLabel.AutoSize = True
        ISSNLabel.BackColor = System.Drawing.Color.Transparent
        ISSNLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ISSNLabel.Location = New System.Drawing.Point(16, 151)
        ISSNLabel.Name = "ISSNLabel"
        ISSNLabel.Size = New System.Drawing.Size(50, 19)
        ISSNLabel.TabIndex = 106
        ISSNLabel.Text = "Access:"
        '
        'ORCIDLabel
        '
        ORCIDLabel.AutoSize = True
        ORCIDLabel.BackColor = System.Drawing.Color.Transparent
        ORCIDLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ORCIDLabel.Location = New System.Drawing.Point(27, 51)
        ORCIDLabel.Name = "ORCIDLabel"
        ORCIDLabel.Size = New System.Drawing.Size(52, 19)
        ORCIDLabel.TabIndex = 110
        ORCIDLabel.Text = "ORCID:"
        '
        'F_NameLabel
        '
        F_NameLabel.AutoSize = True
        F_NameLabel.BackColor = System.Drawing.Color.Transparent
        F_NameLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        F_NameLabel.Location = New System.Drawing.Point(27, 97)
        F_NameLabel.Name = "F_NameLabel"
        F_NameLabel.Size = New System.Drawing.Size(58, 19)
        F_NameLabel.TabIndex = 112
        F_NameLabel.Text = "F Name:"
        '
        'L_NameLabel
        '
        L_NameLabel.AutoSize = True
        L_NameLabel.BackColor = System.Drawing.Color.Transparent
        L_NameLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        L_NameLabel.Location = New System.Drawing.Point(27, 139)
        L_NameLabel.Name = "L_NameLabel"
        L_NameLabel.Size = New System.Drawing.Size(58, 19)
        L_NameLabel.TabIndex = 114
        L_NameLabel.Text = "L Name:"
        '
        'UniversityLabel
        '
        UniversityLabel.AutoSize = True
        UniversityLabel.BackColor = System.Drawing.Color.Transparent
        UniversityLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UniversityLabel.Location = New System.Drawing.Point(27, 181)
        UniversityLabel.Name = "UniversityLabel"
        UniversityLabel.Size = New System.Drawing.Size(72, 19)
        UniversityLabel.TabIndex = 116
        UniversityLabel.Text = "University:"
        '
        'Co_AuthorLabel
        '
        Co_AuthorLabel.AutoSize = True
        Co_AuthorLabel.BackColor = System.Drawing.Color.Transparent
        Co_AuthorLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Co_AuthorLabel.Location = New System.Drawing.Point(27, 224)
        Co_AuthorLabel.Name = "Co_AuthorLabel"
        Co_AuthorLabel.Size = New System.Drawing.Size(75, 19)
        Co_AuthorLabel.TabIndex = 118
        Co_AuthorLabel.Text = "Co-Author:"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.BackColor = System.Drawing.Color.Transparent
        E_mailLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        E_mailLabel.Location = New System.Drawing.Point(27, 272)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(53, 19)
        E_mailLabel.TabIndex = 120
        E_mailLabel.Text = "E-mail:"
        '
        'Num_of_SponsorshipsLabel
        '
        Num_of_SponsorshipsLabel.AutoSize = True
        Num_of_SponsorshipsLabel.BackColor = System.Drawing.Color.Transparent
        Num_of_SponsorshipsLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_of_SponsorshipsLabel.Location = New System.Drawing.Point(40, 174)
        Num_of_SponsorshipsLabel.Name = "Num_of_SponsorshipsLabel"
        Num_of_SponsorshipsLabel.Size = New System.Drawing.Size(139, 19)
        Num_of_SponsorshipsLabel.TabIndex = 89
        Num_of_SponsorshipsLabel.Text = "Num of Sponsorships:"
        '
        'Money_SpentLabel
        '
        Money_SpentLabel.AutoSize = True
        Money_SpentLabel.BackColor = System.Drawing.Color.Transparent
        Money_SpentLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Money_SpentLabel.Location = New System.Drawing.Point(40, 240)
        Money_SpentLabel.Name = "Money_SpentLabel"
        Money_SpentLabel.Size = New System.Drawing.Size(89, 19)
        Money_SpentLabel.TabIndex = 93
        Money_SpentLabel.Text = "Money Spent:"
        '
        'Name_SponsorerLabel1
        '
        Name_SponsorerLabel1.AutoSize = True
        Name_SponsorerLabel1.BackColor = System.Drawing.Color.Transparent
        Name_SponsorerLabel1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_SponsorerLabel1.Location = New System.Drawing.Point(40, 48)
        Name_SponsorerLabel1.Name = "Name_SponsorerLabel1"
        Name_SponsorerLabel1.Size = New System.Drawing.Size(100, 19)
        Name_SponsorerLabel1.TabIndex = 84
        Name_SponsorerLabel1.Text = "Name Sponsor:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.BackColor = System.Drawing.Color.Transparent
        LocationLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(40, 111)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(61, 19)
        LocationLabel.TabIndex = 86
        LocationLabel.Text = "Country:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.BackColor = System.Drawing.Color.Transparent
        TitleLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(40, 52)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(40, 19)
        TitleLabel.TabIndex = 123
        TitleLabel.Text = "Title:"
        '
        'DOILabel
        '
        DOILabel.AutoSize = True
        DOILabel.BackColor = System.Drawing.Color.Transparent
        DOILabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOILabel.Location = New System.Drawing.Point(40, 119)
        DOILabel.Name = "DOILabel"
        DOILabel.Size = New System.Drawing.Size(36, 19)
        DOILabel.TabIndex = 125
        DOILabel.Text = "DOI:"
        '
        'CitationsLabel
        '
        CitationsLabel.AutoSize = True
        CitationsLabel.BackColor = System.Drawing.Color.Transparent
        CitationsLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CitationsLabel.Location = New System.Drawing.Point(40, 180)
        CitationsLabel.Name = "CitationsLabel"
        CitationsLabel.Size = New System.Drawing.Size(65, 19)
        CitationsLabel.TabIndex = 127
        CitationsLabel.Text = "Citations:"
        '
        'Name_PublisherLabel1
        '
        Name_PublisherLabel1.AutoSize = True
        Name_PublisherLabel1.BackColor = System.Drawing.Color.Transparent
        Name_PublisherLabel1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_PublisherLabel1.Location = New System.Drawing.Point(40, 41)
        Name_PublisherLabel1.Name = "Name_PublisherLabel1"
        Name_PublisherLabel1.Size = New System.Drawing.Size(110, 19)
        Name_PublisherLabel1.TabIndex = 78
        Name_PublisherLabel1.Text = "Name Publisher:"
        '
        'DomainLabel
        '
        DomainLabel.AutoSize = True
        DomainLabel.BackColor = System.Drawing.Color.Transparent
        DomainLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DomainLabel.Location = New System.Drawing.Point(40, 88)
        DomainLabel.Name = "DomainLabel"
        DomainLabel.Size = New System.Drawing.Size(62, 19)
        DomainLabel.TabIndex = 80
        DomainLabel.Text = "Domain:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.BackColor = System.Drawing.Color.Transparent
        CountryLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.Location = New System.Drawing.Point(499, 42)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(61, 19)
        CountryLabel.TabIndex = 75
        CountryLabel.Text = "Country:"
        '
        'Num_of_JournalsLabel
        '
        Num_of_JournalsLabel.AutoSize = True
        Num_of_JournalsLabel.BackColor = System.Drawing.Color.Transparent
        Num_of_JournalsLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_of_JournalsLabel.Location = New System.Drawing.Point(499, 88)
        Num_of_JournalsLabel.Name = "Num_of_JournalsLabel"
        Num_of_JournalsLabel.Size = New System.Drawing.Size(112, 19)
        Num_of_JournalsLabel.TabIndex = 77
        Num_of_JournalsLabel.Text = "Num of Journals:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(40, 52)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(33, 19)
        Label3.TabIndex = 123
        Label3.Text = "ISSN"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(40, 119)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(99, 19)
        Label4.TabIndex = 125
        Label4.Text = "Impact Factor:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(40, 180)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(99, 19)
        Label5.TabIndex = 127
        Label5.Text = "Citation Index:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(1131, 663)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(97, 19)
        Label6.TabIndex = 95
        Label6.Text = "Primary Keys:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(508, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 34)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "ADMIN INFORMATION PAGE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(30, 771)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(189, 51)
        Me.Button5.TabIndex = 149
        Me.Button5.Text = "Generate Report"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Journal_NameLabel)
        Me.GroupBox5.Controls.Add(Me.Journal_NameTextBox)
        Me.GroupBox5.Controls.Add(Date_of_PublishingLabel)
        Me.GroupBox5.Controls.Add(ISSNLabel)
        Me.GroupBox5.Controls.Add(Me.ISSNTextBox)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(30, 112)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(430, 206)
        Me.GroupBox5.TabIndex = 148
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data Related to Journal"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(163, 92)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 26)
        Me.TextBox1.TabIndex = 108
        '
        'Journal_NameTextBox
        '
        Me.Journal_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Journal_NameTextBox.Location = New System.Drawing.Point(163, 29)
        Me.Journal_NameTextBox.Name = "Journal_NameTextBox"
        Me.Journal_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Journal_NameTextBox.TabIndex = 101
        '
        'ISSNTextBox
        '
        Me.ISSNTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISSNTextBox.Location = New System.Drawing.Point(163, 151)
        Me.ISSNTextBox.Name = "ISSNTextBox"
        Me.ISSNTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ISSNTextBox.TabIndex = 107
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(ORCIDLabel)
        Me.GroupBox4.Controls.Add(Me.ORCIDTextBox)
        Me.GroupBox4.Controls.Add(F_NameLabel)
        Me.GroupBox4.Controls.Add(Me.F_NameTextBox)
        Me.GroupBox4.Controls.Add(L_NameLabel)
        Me.GroupBox4.Controls.Add(Me.L_NameTextBox)
        Me.GroupBox4.Controls.Add(UniversityLabel)
        Me.GroupBox4.Controls.Add(Me.UniversityTextBox)
        Me.GroupBox4.Controls.Add(Co_AuthorLabel)
        Me.GroupBox4.Controls.Add(Me.Co_AuthorTextBox)
        Me.GroupBox4.Controls.Add(E_mailLabel)
        Me.GroupBox4.Controls.Add(Me.E_mailTextBox)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(34, 337)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(427, 340)
        Me.GroupBox4.TabIndex = 147
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data Related to Author"
        '
        'ORCIDTextBox
        '
        Me.ORCIDTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ORCIDTextBox.Location = New System.Drawing.Point(174, 44)
        Me.ORCIDTextBox.Name = "ORCIDTextBox"
        Me.ORCIDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ORCIDTextBox.TabIndex = 111
        '
        'F_NameTextBox
        '
        Me.F_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_NameTextBox.Location = New System.Drawing.Point(174, 90)
        Me.F_NameTextBox.Name = "F_NameTextBox"
        Me.F_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.F_NameTextBox.TabIndex = 113
        '
        'L_NameTextBox
        '
        Me.L_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_NameTextBox.Location = New System.Drawing.Point(174, 136)
        Me.L_NameTextBox.Name = "L_NameTextBox"
        Me.L_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.L_NameTextBox.TabIndex = 115
        '
        'UniversityTextBox
        '
        Me.UniversityTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UniversityTextBox.Location = New System.Drawing.Point(174, 174)
        Me.UniversityTextBox.Name = "UniversityTextBox"
        Me.UniversityTextBox.Size = New System.Drawing.Size(200, 26)
        Me.UniversityTextBox.TabIndex = 117
        '
        'Co_AuthorTextBox
        '
        Me.Co_AuthorTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Co_AuthorTextBox.Location = New System.Drawing.Point(174, 220)
        Me.Co_AuthorTextBox.Name = "Co_AuthorTextBox"
        Me.Co_AuthorTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Co_AuthorTextBox.TabIndex = 119
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E_mailTextBox.Location = New System.Drawing.Point(174, 265)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(200, 26)
        Me.E_mailTextBox.TabIndex = 121
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Num_of_SponsorshipsLabel)
        Me.GroupBox2.Controls.Add(Me.Num_of_SponsorshipsTextBox)
        Me.GroupBox2.Controls.Add(Money_SpentLabel)
        Me.GroupBox2.Controls.Add(Me.Money_SpentTextBox)
        Me.GroupBox2.Controls.Add(Name_SponsorerLabel1)
        Me.GroupBox2.Controls.Add(Me.Name_SponsorerTextBox1)
        Me.GroupBox2.Controls.Add(LocationLabel)
        Me.GroupBox2.Controls.Add(Me.LocationTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(975, 325)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 303)
        Me.GroupBox2.TabIndex = 145
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Related to Sponsorers"
        '
        'Num_of_SponsorshipsTextBox
        '
        Me.Num_of_SponsorshipsTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_of_SponsorshipsTextBox.Location = New System.Drawing.Point(189, 171)
        Me.Num_of_SponsorshipsTextBox.Name = "Num_of_SponsorshipsTextBox"
        Me.Num_of_SponsorshipsTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Num_of_SponsorshipsTextBox.TabIndex = 90
        '
        'Money_SpentTextBox
        '
        Me.Money_SpentTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money_SpentTextBox.Location = New System.Drawing.Point(189, 234)
        Me.Money_SpentTextBox.Name = "Money_SpentTextBox"
        Me.Money_SpentTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Money_SpentTextBox.TabIndex = 94
        '
        'Name_SponsorerTextBox1
        '
        Me.Name_SponsorerTextBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_SponsorerTextBox1.Location = New System.Drawing.Point(189, 41)
        Me.Name_SponsorerTextBox1.Name = "Name_SponsorerTextBox1"
        Me.Name_SponsorerTextBox1.Size = New System.Drawing.Size(200, 26)
        Me.Name_SponsorerTextBox1.TabIndex = 85
        '
        'LocationTextBox
        '
        Me.LocationTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(189, 108)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(200, 26)
        Me.LocationTextBox.TabIndex = 87
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(TitleLabel)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Controls.Add(DOILabel)
        Me.GroupBox1.Controls.Add(Me.DOITextBox)
        Me.GroupBox1.Controls.Add(CitationsLabel)
        Me.GroupBox1.Controls.Add(Me.CitationsTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(521, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 231)
        Me.GroupBox1.TabIndex = 144
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Related to Journal Article"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(167, 45)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TitleTextBox.TabIndex = 124
        '
        'DOITextBox
        '
        Me.DOITextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOITextBox.Location = New System.Drawing.Point(167, 116)
        Me.DOITextBox.Name = "DOITextBox"
        Me.DOITextBox.Size = New System.Drawing.Size(200, 26)
        Me.DOITextBox.TabIndex = 126
        '
        'CitationsTextBox
        '
        Me.CitationsTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitationsTextBox.Location = New System.Drawing.Point(167, 177)
        Me.CitationsTextBox.Name = "CitationsTextBox"
        Me.CitationsTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CitationsTextBox.TabIndex = 128
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(517, 717)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(419, 19)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "There are a total of 13 entires in the Journal Informaion Database"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryTextBox.Location = New System.Drawing.Point(643, 38)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CountryTextBox.TabIndex = 141
        '
        'Num_of_JournalsTextBox
        '
        Me.Num_of_JournalsTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_of_JournalsTextBox.Location = New System.Drawing.Point(643, 85)
        Me.Num_of_JournalsTextBox.Name = "Num_of_JournalsTextBox"
        Me.Num_of_JournalsTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Num_of_JournalsTextBox.TabIndex = 142
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Name_PublisherLabel1)
        Me.GroupBox3.Controls.Add(Me.Name_PublisherTextBox1)
        Me.GroupBox3.Controls.Add(DomainLabel)
        Me.GroupBox3.Controls.Add(Me.DomainTextBox)
        Me.GroupBox3.Controls.Add(CountryLabel)
        Me.GroupBox3.Controls.Add(Num_of_JournalsLabel)
        Me.GroupBox3.Controls.Add(Me.CountryTextBox)
        Me.GroupBox3.Controls.Add(Me.Num_of_JournalsTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(521, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(863, 143)
        Me.GroupBox3.TabIndex = 146
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Related to Publishers"
        '
        'Name_PublisherTextBox1
        '
        Me.Name_PublisherTextBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_PublisherTextBox1.Location = New System.Drawing.Point(167, 35)
        Me.Name_PublisherTextBox1.Name = "Name_PublisherTextBox1"
        Me.Name_PublisherTextBox1.Size = New System.Drawing.Size(200, 26)
        Me.Name_PublisherTextBox1.TabIndex = 79
        '
        'DomainTextBox
        '
        Me.DomainTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainTextBox.Location = New System.Drawing.Point(167, 85)
        Me.DomainTextBox.Name = "DomainTextBox"
        Me.DomainTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DomainTextBox.TabIndex = 81
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button9.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(264, 771)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(197, 51)
        Me.Button9.TabIndex = 157
        Me.Button9.Text = "Show all Tables"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(721, 771)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(215, 51)
        Me.Button4.TabIndex = 153
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1209, 752)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(175, 51)
        Me.Button3.TabIndex = 152
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1002, 752)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 51)
        Me.Button2.TabIndex = 151
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(521, 771)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 51)
        Me.Button1.TabIndex = 150
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Label3)
        Me.GroupBox6.Controls.Add(Me.TextBox2)
        Me.GroupBox6.Controls.Add(Label4)
        Me.GroupBox6.Controls.Add(Me.TextBox3)
        Me.GroupBox6.Controls.Add(Label5)
        Me.GroupBox6.Controls.Add(Me.TextBox4)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(521, 518)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(415, 235)
        Me.GroupBox6.TabIndex = 145
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Data Related to Journal Citation Report"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(167, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 26)
        Me.TextBox2.TabIndex = 124
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(167, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 26)
        Me.TextBox3.TabIndex = 126
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(167, 177)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 26)
        Me.TextBox4.TabIndex = 128
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Bernard MT Condensed", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Journal Name", "ORCID", "DOI of Journal Article", "ISSN", "Name of Sponsor", "Name of Publisher"})
        Me.ComboBox2.Location = New System.Drawing.Point(1101, 685)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(150, 32)
        Me.ComboBox2.TabIndex = 159
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(145, 702)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(197, 51)
        Me.Button6.TabIndex = 160
        Me.Button6.Text = "Show Charts"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalJournal.My.Resources.Resources.PIC1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1384, 71)
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'AuthorBindingSource
        '
        Me.AuthorBindingSource.DataMember = "Author"
        Me.AuthorBindingSource.DataSource = Me.JMDataSet
        '
        'JMDataSet
        '
        Me.JMDataSet.DataSetName = "JMDataSet"
        Me.JMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuthorTableAdapter
        '
        Me.AuthorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuthorTableAdapter = Me.AuthorTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Journal_ArticlesTableAdapter = Me.Journal_ArticlesTableAdapter
        Me.TableAdapterManager.Journal_Citations_ReportTableAdapter = Me.Journal_Citations_ReportTableAdapter
        Me.TableAdapterManager.Journal_DisciplinesTableAdapter = Me.Journal_DisciplinesTableAdapter
        Me.TableAdapterManager.JournalTableAdapter = Me.JournalTableAdapter
        Me.TableAdapterManager.Publisher_DomainsTableAdapter = Me.Publisher_DomainsTableAdapter
        Me.TableAdapterManager.PublisherTableAdapter = Me.PublisherTableAdapter
        Me.TableAdapterManager.SponsoredTableAdapter = Me.SponsoredTableAdapter
        Me.TableAdapterManager.Sponsorer_LocationsTableAdapter = Me.Sponsorer_LocationsTableAdapter
        Me.TableAdapterManager.SponsorersTableAdapter = Me.SponsorersTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalJournal.JMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WritesTableAdapter = Me.WritesTableAdapter
        '
        'Journal_ArticlesTableAdapter
        '
        Me.Journal_ArticlesTableAdapter.ClearBeforeFill = True
        '
        'Journal_Citations_ReportTableAdapter
        '
        Me.Journal_Citations_ReportTableAdapter.ClearBeforeFill = True
        '
        'Journal_DisciplinesTableAdapter
        '
        Me.Journal_DisciplinesTableAdapter.ClearBeforeFill = True
        '
        'JournalTableAdapter
        '
        Me.JournalTableAdapter.ClearBeforeFill = True
        '
        'Publisher_DomainsTableAdapter
        '
        Me.Publisher_DomainsTableAdapter.ClearBeforeFill = True
        '
        'PublisherTableAdapter
        '
        Me.PublisherTableAdapter.ClearBeforeFill = True
        '
        'SponsoredTableAdapter
        '
        Me.SponsoredTableAdapter.ClearBeforeFill = True
        '
        'Sponsorer_LocationsTableAdapter
        '
        Me.Sponsorer_LocationsTableAdapter.ClearBeforeFill = True
        '
        'SponsorersTableAdapter
        '
        Me.SponsorersTableAdapter.ClearBeforeFill = True
        '
        'WritesTableAdapter
        '
        Me.WritesTableAdapter.ClearBeforeFill = True
        '
        'JournalBindingSource
        '
        Me.JournalBindingSource.DataMember = "Journal"
        Me.JournalBindingSource.DataSource = Me.JMDataSet
        '
        'Journal_DisciplinesBindingSource
        '
        Me.Journal_DisciplinesBindingSource.DataMember = "Journal_Disciplines"
        Me.Journal_DisciplinesBindingSource.DataSource = Me.JMDataSet
        '
        'Journal_ArticlesBindingSource
        '
        Me.Journal_ArticlesBindingSource.DataMember = "Journal-Articles"
        Me.Journal_ArticlesBindingSource.DataSource = Me.JMDataSet
        '
        'PublisherBindingSource
        '
        Me.PublisherBindingSource.DataMember = "Publisher"
        Me.PublisherBindingSource.DataSource = Me.JMDataSet
        '
        'Publisher_DomainsBindingSource
        '
        Me.Publisher_DomainsBindingSource.DataMember = "Publisher_Domains"
        Me.Publisher_DomainsBindingSource.DataSource = Me.JMDataSet
        '
        'SponsoredBindingSource
        '
        Me.SponsoredBindingSource.DataMember = "Sponsored"
        Me.SponsoredBindingSource.DataSource = Me.JMDataSet
        '
        'Sponsorer_LocationsBindingSource
        '
        Me.Sponsorer_LocationsBindingSource.DataMember = "Sponsorer_Locations"
        Me.Sponsorer_LocationsBindingSource.DataSource = Me.JMDataSet
        '
        'Journal_Citations_ReportBindingSource
        '
        Me.Journal_Citations_ReportBindingSource.DataMember = "Journal­Citations-Report"
        Me.Journal_Citations_ReportBindingSource.DataSource = Me.JMDataSet
        '
        'SponsorersBindingSource
        '
        Me.SponsorersBindingSource.DataMember = "Sponsorers"
        Me.SponsorersBindingSource.DataSource = Me.JMDataSet
        '
        'WritesBindingSource
        '
        Me.WritesBindingSource.DataMember = "Writes"
        Me.WritesBindingSource.DataSource = Me.JMDataSet
        '
        'SuperUserDataSet
        '
        Me.SuperUserDataSet.DataSetName = "SuperUserDataSet"
        Me.SuperUserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SUUSBindingSource
        '
        Me.SUUSBindingSource.DataMember = "SUUS"
        Me.SUUSBindingSource.DataSource = Me.SuperUserDataSet
        '
        'SUUSTableAdapter
        '
        Me.SUUSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.SUUSTableAdapter = Me.SUUSTableAdapter
        Me.TableAdapterManager1.UpdateOrder = FinalJournal.SuperUserDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LoginDataSet1
        '
        Me.LoginDataSet1.DataSetName = "loginDataSet1"
        Me.LoginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Login_tableBindingSource
        '
        Me.Login_tableBindingSource.DataMember = "login_table"
        Me.Login_tableBindingSource.DataSource = Me.LoginDataSet1
        '
        'Login_tableTableAdapter
        '
        Me.Login_tableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = FinalJournal.loginDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JournalDataSet
        '
        Me.JournalDataSet.DataSetName = "journalDataSet"
        Me.JournalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuthorBindingSource1
        '
        Me.AuthorBindingSource1.DataMember = "author"
        Me.AuthorBindingSource1.DataSource = Me.JournalDataSet
        '
        'AuthorTableAdapter1
        '
        Me.AuthorTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager3
        '
        Me.TableAdapterManager3.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager3.Connection = Nothing
        Me.TableAdapterManager3.UpdateOrder = FinalJournal.journalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'JournalBindingSource1
        '
        Me.JournalBindingSource1.DataMember = "journal"
        Me.JournalBindingSource1.DataSource = Me.JournalDataSet
        '
        'JournalTableAdapter1
        '
        Me.JournalTableAdapter1.ClearBeforeFill = True
        '
        'PublisherBindingSource1
        '
        Me.PublisherBindingSource1.DataMember = "publisher"
        Me.PublisherBindingSource1.DataSource = Me.JournalDataSet
        '
        'PublisherTableAdapter1
        '
        Me.PublisherTableAdapter1.ClearBeforeFill = True
        '
        'Journal_citation_reportBindingSource
        '
        Me.Journal_citation_reportBindingSource.DataMember = "journal_citation_report"
        Me.Journal_citation_reportBindingSource.DataSource = Me.JournalDataSet
        '
        'Journal_citation_reportTableAdapter
        '
        Me.Journal_citation_reportTableAdapter.ClearBeforeFill = True
        '
        'SponsorsBindingSource
        '
        Me.SponsorsBindingSource.DataMember = "sponsors"
        Me.SponsorsBindingSource.DataSource = Me.JournalDataSet
        '
        'SponsorsTableAdapter
        '
        Me.SponsorsTableAdapter.ClearBeforeFill = True
        '
        'adminform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.FinalJournal.My.Resources.Resources.Plain_Wallpapers_HD_A251
        Me.ClientSize = New System.Drawing.Size(1428, 865)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "adminform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminform"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JournalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journal_DisciplinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journal_ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublisherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Publisher_DomainsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponsoredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sponsorer_LocationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journal_Citations_ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponsorersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WritesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuperUserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login_tableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JournalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JournalBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublisherBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journal_citation_reportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponsorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Journal_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ISSNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ORCIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents F_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UniversityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Co_AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_mailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Num_of_SponsorshipsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Money_SpentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_SponsorerTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOITextBox As System.Windows.Forms.TextBox
    Friend WithEvents CitationsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Num_of_JournalsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Name_PublisherTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DomainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents JMDataSet As FinalJournal.JMDataSet
    Friend WithEvents AuthorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuthorTableAdapter As FinalJournal.JMDataSetTableAdapters.AuthorTableAdapter
    Friend WithEvents TableAdapterManager As FinalJournal.JMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JournalTableAdapter As FinalJournal.JMDataSetTableAdapters.JournalTableAdapter
    Friend WithEvents JournalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Journal_DisciplinesTableAdapter As FinalJournal.JMDataSetTableAdapters.Journal_DisciplinesTableAdapter
    Friend WithEvents Journal_DisciplinesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Journal_ArticlesTableAdapter As FinalJournal.JMDataSetTableAdapters.Journal_ArticlesTableAdapter
    Friend WithEvents Journal_ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PublisherTableAdapter As FinalJournal.JMDataSetTableAdapters.PublisherTableAdapter
    Friend WithEvents PublisherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Publisher_DomainsTableAdapter As FinalJournal.JMDataSetTableAdapters.Publisher_DomainsTableAdapter
    Friend WithEvents Publisher_DomainsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponsoredTableAdapter As FinalJournal.JMDataSetTableAdapters.SponsoredTableAdapter
    Friend WithEvents SponsoredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sponsorer_LocationsTableAdapter As FinalJournal.JMDataSetTableAdapters.Sponsorer_LocationsTableAdapter
    Friend WithEvents Sponsorer_LocationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Journal_Citations_ReportTableAdapter As FinalJournal.JMDataSetTableAdapters.Journal_Citations_ReportTableAdapter
    Friend WithEvents Journal_Citations_ReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponsorersTableAdapter As FinalJournal.JMDataSetTableAdapters.SponsorersTableAdapter
    Friend WithEvents SponsorersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WritesTableAdapter As FinalJournal.JMDataSetTableAdapters.WritesTableAdapter
    Friend WithEvents WritesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SuperUserDataSet As FinalJournal.SuperUserDataSet
    Friend WithEvents SUUSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SUUSTableAdapter As FinalJournal.SuperUserDataSetTableAdapters.SUUSTableAdapter
    Friend WithEvents TableAdapterManager1 As FinalJournal.SuperUserDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoginDataSet1 As FinalJournal.loginDataSet1
    Friend WithEvents Login_tableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Login_tableTableAdapter As FinalJournal.loginDataSet1TableAdapters.login_tableTableAdapter
    Friend WithEvents TableAdapterManager2 As FinalJournal.loginDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents JournalDataSet As FinalJournal.journalDataSet
    Friend WithEvents AuthorBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AuthorTableAdapter1 As FinalJournal.journalDataSetTableAdapters.authorTableAdapter
    Friend WithEvents TableAdapterManager3 As FinalJournal.journalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JournalBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents JournalTableAdapter1 As FinalJournal.journalDataSetTableAdapters.journalTableAdapter
    Friend WithEvents PublisherBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PublisherTableAdapter1 As FinalJournal.journalDataSetTableAdapters.publisherTableAdapter
    Friend WithEvents Journal_citation_reportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Journal_citation_reportTableAdapter As FinalJournal.journalDataSetTableAdapters.journal_citation_reportTableAdapter
    Friend WithEvents SponsorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponsorsTableAdapter As FinalJournal.journalDataSetTableAdapters.sponsorsTableAdapter
End Class
