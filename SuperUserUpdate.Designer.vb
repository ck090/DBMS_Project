<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuperUserUpdate
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
        Dim Pub_NameLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Num_of_JournalsLabel As System.Windows.Forms.Label
        Dim Name_PublisherLabel1 As System.Windows.Forms.Label
        Dim DomainLabel As System.Windows.Forms.Label
        Dim Name_JournalLabel1 As System.Windows.Forms.Label
        Dim Name_SponsorerLabel As System.Windows.Forms.Label
        Dim Name_SponsorerLabel1 As System.Windows.Forms.Label
        Dim LocationLabel As System.Windows.Forms.Label
        Dim Sponsorer_NameLabel As System.Windows.Forms.Label
        Dim Num_of_SponsorshipsLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Money_SpentLabel As System.Windows.Forms.Label
        Dim Journal_NameLabel As System.Windows.Forms.Label
        Dim Name_PublisherLabel As System.Windows.Forms.Label
        Dim Date_of_PublishingLabel As System.Windows.Forms.Label
        Dim ISSNLabel As System.Windows.Forms.Label
        Dim Journal_NameLabel1 As System.Windows.Forms.Label
        Dim DisciplinesLabel As System.Windows.Forms.Label
        Dim ORCIDLabel As System.Windows.Forms.Label
        Dim F_NameLabel As System.Windows.Forms.Label
        Dim L_NameLabel As System.Windows.Forms.Label
        Dim UniversityLabel As System.Windows.Forms.Label
        Dim Co_AuthorLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim Name_JournalLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim DOILabel As System.Windows.Forms.Label
        Dim CitationsLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JMDataSet = New FinalJournal.JMDataSet()
        Me.Publisher_DomainsTableAdapter = New FinalJournal.JMDataSetTableAdapters.Publisher_DomainsTableAdapter()
        Me.PublisherTableAdapter = New FinalJournal.JMDataSetTableAdapters.PublisherTableAdapter()
        Me.SponsoredTableAdapter = New FinalJournal.JMDataSetTableAdapters.SponsoredTableAdapter()
        Me.Sponsorer_LocationsTableAdapter = New FinalJournal.JMDataSetTableAdapters.Sponsorer_LocationsTableAdapter()
        Me.SponsorersTableAdapter = New FinalJournal.JMDataSetTableAdapters.SponsorersTableAdapter()
        Me.PublisherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pub_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Num_of_JournalsTextBox = New System.Windows.Forms.TextBox()
        Me.Publisher_DomainsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Name_PublisherTextBox1 = New System.Windows.Forms.TextBox()
        Me.DomainTextBox = New System.Windows.Forms.TextBox()
        Me.SponsoredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Name_JournalTextBox1 = New System.Windows.Forms.TextBox()
        Me.Name_SponsorerTextBox = New System.Windows.Forms.TextBox()
        Me.Sponsorer_LocationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Name_SponsorerTextBox1 = New System.Windows.Forms.TextBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.SponsorersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sponsorer_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Num_of_SponsorshipsTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Money_SpentTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.JournalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JournalTableAdapter = New FinalJournal.JMDataSetTableAdapters.JournalTableAdapter()
        Me.TableAdapterManager = New FinalJournal.JMDataSetTableAdapters.TableAdapterManager()
        Me.AuthorTableAdapter = New FinalJournal.JMDataSetTableAdapters.AuthorTableAdapter()
        Me.Journal_ArticlesTableAdapter = New FinalJournal.JMDataSetTableAdapters.Journal_ArticlesTableAdapter()
        Me.Journal_DisciplinesTableAdapter = New FinalJournal.JMDataSetTableAdapters.Journal_DisciplinesTableAdapter()
        Me.Journal_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Name_PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_PublishingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ISSNTextBox = New System.Windows.Forms.TextBox()
        Me.Journal_DisciplinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Journal_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.DisciplinesTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ORCIDTextBox = New System.Windows.Forms.TextBox()
        Me.F_NameTextBox = New System.Windows.Forms.TextBox()
        Me.L_NameTextBox = New System.Windows.Forms.TextBox()
        Me.UniversityTextBox = New System.Windows.Forms.TextBox()
        Me.Co_AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.Journal_ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Name_JournalTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.DOITextBox = New System.Windows.Forms.TextBox()
        Me.CitationsTextBox = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuperUserDataSet = New FinalJournal.SuperUserDataSet()
        Me.SUUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUUSTableAdapter = New FinalJournal.SuperUserDataSetTableAdapters.SUUSTableAdapter()
        Me.TableAdapterManager1 = New FinalJournal.SuperUserDataSetTableAdapters.TableAdapterManager()
        Me.LoginDataSet = New FinalJournal.LoginDataSet()
        Me.Login1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login1TableAdapter = New FinalJournal.LoginDataSetTableAdapters.Login1TableAdapter()
        Me.TableAdapterManager2 = New FinalJournal.LoginDataSetTableAdapters.TableAdapterManager()
        Pub_NameLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Num_of_JournalsLabel = New System.Windows.Forms.Label()
        Name_PublisherLabel1 = New System.Windows.Forms.Label()
        DomainLabel = New System.Windows.Forms.Label()
        Name_JournalLabel1 = New System.Windows.Forms.Label()
        Name_SponsorerLabel = New System.Windows.Forms.Label()
        Name_SponsorerLabel1 = New System.Windows.Forms.Label()
        LocationLabel = New System.Windows.Forms.Label()
        Sponsorer_NameLabel = New System.Windows.Forms.Label()
        Num_of_SponsorshipsLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Money_SpentLabel = New System.Windows.Forms.Label()
        Journal_NameLabel = New System.Windows.Forms.Label()
        Name_PublisherLabel = New System.Windows.Forms.Label()
        Date_of_PublishingLabel = New System.Windows.Forms.Label()
        ISSNLabel = New System.Windows.Forms.Label()
        Journal_NameLabel1 = New System.Windows.Forms.Label()
        DisciplinesLabel = New System.Windows.Forms.Label()
        ORCIDLabel = New System.Windows.Forms.Label()
        F_NameLabel = New System.Windows.Forms.Label()
        L_NameLabel = New System.Windows.Forms.Label()
        UniversityLabel = New System.Windows.Forms.Label()
        Co_AuthorLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        Name_JournalLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        DOILabel = New System.Windows.Forms.Label()
        CitationsLabel = New System.Windows.Forms.Label()
        CType(Me.JMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublisherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Publisher_DomainsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponsoredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sponsorer_LocationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponsorersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JournalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journal_DisciplinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journal_ArticlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.SuperUserDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pub_NameLabel
        '
        Pub_NameLabel.AutoSize = True
        Pub_NameLabel.BackColor = System.Drawing.Color.Transparent
        Pub_NameLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pub_NameLabel.Location = New System.Drawing.Point(502, 26)
        Pub_NameLabel.Name = "Pub_NameLabel"
        Pub_NameLabel.Size = New System.Drawing.Size(76, 19)
        Pub_NameLabel.TabIndex = 73
        Pub_NameLabel.Text = "Pub Name:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.BackColor = System.Drawing.Color.Transparent
        CountryLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.Location = New System.Drawing.Point(502, 66)
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
        Num_of_JournalsLabel.Location = New System.Drawing.Point(502, 109)
        Num_of_JournalsLabel.Name = "Num_of_JournalsLabel"
        Num_of_JournalsLabel.Size = New System.Drawing.Size(112, 19)
        Num_of_JournalsLabel.TabIndex = 77
        Num_of_JournalsLabel.Text = "Num of Journals:"
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
        'Name_JournalLabel1
        '
        Name_JournalLabel1.AutoSize = True
        Name_JournalLabel1.BackColor = System.Drawing.Color.Transparent
        Name_JournalLabel1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_JournalLabel1.Location = New System.Drawing.Point(32, 30)
        Name_JournalLabel1.Name = "Name_JournalLabel1"
        Name_JournalLabel1.Size = New System.Drawing.Size(98, 19)
        Name_JournalLabel1.TabIndex = 81
        Name_JournalLabel1.Text = "Name Journal:"
        '
        'Name_SponsorerLabel
        '
        Name_SponsorerLabel.AutoSize = True
        Name_SponsorerLabel.BackColor = System.Drawing.Color.Transparent
        Name_SponsorerLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_SponsorerLabel.Location = New System.Drawing.Point(32, 77)
        Name_SponsorerLabel.Name = "Name_SponsorerLabel"
        Name_SponsorerLabel.Size = New System.Drawing.Size(113, 19)
        Name_SponsorerLabel.TabIndex = 83
        Name_SponsorerLabel.Text = "Name Sponsorer:"
        '
        'Name_SponsorerLabel1
        '
        Name_SponsorerLabel1.AutoSize = True
        Name_SponsorerLabel1.BackColor = System.Drawing.Color.Transparent
        Name_SponsorerLabel1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_SponsorerLabel1.Location = New System.Drawing.Point(40, 48)
        Name_SponsorerLabel1.Name = "Name_SponsorerLabel1"
        Name_SponsorerLabel1.Size = New System.Drawing.Size(113, 19)
        Name_SponsorerLabel1.TabIndex = 84
        Name_SponsorerLabel1.Text = "Name Sponsorer:"
        '
        'LocationLabel
        '
        LocationLabel.AutoSize = True
        LocationLabel.BackColor = System.Drawing.Color.Transparent
        LocationLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LocationLabel.Location = New System.Drawing.Point(40, 83)
        LocationLabel.Name = "LocationLabel"
        LocationLabel.Size = New System.Drawing.Size(66, 19)
        LocationLabel.TabIndex = 86
        LocationLabel.Text = "Location:"
        '
        'Sponsorer_NameLabel
        '
        Sponsorer_NameLabel.AutoSize = True
        Sponsorer_NameLabel.BackColor = System.Drawing.Color.Transparent
        Sponsorer_NameLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sponsorer_NameLabel.Location = New System.Drawing.Point(40, 200)
        Sponsorer_NameLabel.Name = "Sponsorer_NameLabel"
        Sponsorer_NameLabel.Size = New System.Drawing.Size(113, 19)
        Sponsorer_NameLabel.TabIndex = 87
        Sponsorer_NameLabel.Text = "Sponsorer Name:"
        '
        'Num_of_SponsorshipsLabel
        '
        Num_of_SponsorshipsLabel.AutoSize = True
        Num_of_SponsorshipsLabel.BackColor = System.Drawing.Color.Transparent
        Num_of_SponsorshipsLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_of_SponsorshipsLabel.Location = New System.Drawing.Point(40, 240)
        Num_of_SponsorshipsLabel.Name = "Num_of_SponsorshipsLabel"
        Num_of_SponsorshipsLabel.Size = New System.Drawing.Size(139, 19)
        Num_of_SponsorshipsLabel.TabIndex = 89
        Num_of_SponsorshipsLabel.Text = "Num of Sponsorships:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.Transparent
        AddressLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(40, 286)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(60, 19)
        AddressLabel.TabIndex = 91
        AddressLabel.Text = "Address:"
        '
        'Money_SpentLabel
        '
        Money_SpentLabel.AutoSize = True
        Money_SpentLabel.BackColor = System.Drawing.Color.Transparent
        Money_SpentLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Money_SpentLabel.Location = New System.Drawing.Point(40, 325)
        Money_SpentLabel.Name = "Money_SpentLabel"
        Money_SpentLabel.Size = New System.Drawing.Size(89, 19)
        Money_SpentLabel.TabIndex = 93
        Money_SpentLabel.Text = "Money Spent:"
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
        'Name_PublisherLabel
        '
        Name_PublisherLabel.AutoSize = True
        Name_PublisherLabel.BackColor = System.Drawing.Color.Transparent
        Name_PublisherLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_PublisherLabel.Location = New System.Drawing.Point(16, 72)
        Name_PublisherLabel.Name = "Name_PublisherLabel"
        Name_PublisherLabel.Size = New System.Drawing.Size(110, 19)
        Name_PublisherLabel.TabIndex = 102
        Name_PublisherLabel.Text = "Name Publisher:"
        '
        'Date_of_PublishingLabel
        '
        Date_of_PublishingLabel.AutoSize = True
        Date_of_PublishingLabel.BackColor = System.Drawing.Color.Transparent
        Date_of_PublishingLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_PublishingLabel.Location = New System.Drawing.Point(16, 109)
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
        ISSNLabel.Size = New System.Drawing.Size(37, 19)
        ISSNLabel.TabIndex = 106
        ISSNLabel.Text = "ISSN:"
        '
        'Journal_NameLabel1
        '
        Journal_NameLabel1.AutoSize = True
        Journal_NameLabel1.BackColor = System.Drawing.Color.Transparent
        Journal_NameLabel1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Journal_NameLabel1.Location = New System.Drawing.Point(32, 134)
        Journal_NameLabel1.Name = "Journal_NameLabel1"
        Journal_NameLabel1.Size = New System.Drawing.Size(98, 19)
        Journal_NameLabel1.TabIndex = 107
        Journal_NameLabel1.Text = "Journal Name:"
        '
        'DisciplinesLabel
        '
        DisciplinesLabel.AutoSize = True
        DisciplinesLabel.BackColor = System.Drawing.Color.Transparent
        DisciplinesLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DisciplinesLabel.Location = New System.Drawing.Point(32, 172)
        DisciplinesLabel.Name = "DisciplinesLabel"
        DisciplinesLabel.Size = New System.Drawing.Size(77, 19)
        DisciplinesLabel.TabIndex = 109
        DisciplinesLabel.Text = "Disciplines:"
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
        'Name_JournalLabel
        '
        Name_JournalLabel.AutoSize = True
        Name_JournalLabel.BackColor = System.Drawing.Color.Transparent
        Name_JournalLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_JournalLabel.Location = New System.Drawing.Point(32, 244)
        Name_JournalLabel.Name = "Name_JournalLabel"
        Name_JournalLabel.Size = New System.Drawing.Size(98, 19)
        Name_JournalLabel.TabIndex = 121
        Name_JournalLabel.Text = "Name Journal:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.BackColor = System.Drawing.Color.Transparent
        TitleLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(32, 289)
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
        DOILabel.Location = New System.Drawing.Point(32, 328)
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
        CitationsLabel.Location = New System.Drawing.Point(32, 369)
        CitationsLabel.Name = "CitationsLabel"
        CitationsLabel.Size = New System.Drawing.Size(65, 19)
        CitationsLabel.TabIndex = 127
        CitationsLabel.Text = "Citations:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(508, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(426, 34)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "SUPERUSER LOGIN INFORMATION PAGE"
        '
        'JMDataSet
        '
        Me.JMDataSet.DataSetName = "JMDataSet"
        Me.JMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PublisherBindingSource
        '
        Me.PublisherBindingSource.DataMember = "Publisher"
        Me.PublisherBindingSource.DataSource = Me.JMDataSet
        '
        'Pub_NameTextBox
        '
        Me.Pub_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublisherBindingSource, "Pub_Name", True))
        Me.Pub_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pub_NameTextBox.Location = New System.Drawing.Point(1176, 144)
        Me.Pub_NameTextBox.Name = "Pub_NameTextBox"
        Me.Pub_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Pub_NameTextBox.TabIndex = 74
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublisherBindingSource, "Country", True))
        Me.CountryTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryTextBox.Location = New System.Drawing.Point(1176, 184)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CountryTextBox.TabIndex = 76
        '
        'Num_of_JournalsTextBox
        '
        Me.Num_of_JournalsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublisherBindingSource, "Num_of_Journals", True))
        Me.Num_of_JournalsTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_of_JournalsTextBox.Location = New System.Drawing.Point(1176, 224)
        Me.Num_of_JournalsTextBox.Name = "Num_of_JournalsTextBox"
        Me.Num_of_JournalsTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Num_of_JournalsTextBox.TabIndex = 78
        '
        'Publisher_DomainsBindingSource
        '
        Me.Publisher_DomainsBindingSource.DataMember = "Publisher_Domains"
        Me.Publisher_DomainsBindingSource.DataSource = Me.JMDataSet
        '
        'Name_PublisherTextBox1
        '
        Me.Name_PublisherTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Publisher_DomainsBindingSource, "Name_Publisher", True))
        Me.Name_PublisherTextBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_PublisherTextBox1.Location = New System.Drawing.Point(167, 35)
        Me.Name_PublisherTextBox1.Name = "Name_PublisherTextBox1"
        Me.Name_PublisherTextBox1.Size = New System.Drawing.Size(200, 26)
        Me.Name_PublisherTextBox1.TabIndex = 79
        '
        'DomainTextBox
        '
        Me.DomainTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Publisher_DomainsBindingSource, "Domain", True))
        Me.DomainTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainTextBox.Location = New System.Drawing.Point(167, 85)
        Me.DomainTextBox.Name = "DomainTextBox"
        Me.DomainTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DomainTextBox.TabIndex = 81
        '
        'SponsoredBindingSource
        '
        Me.SponsoredBindingSource.DataMember = "Sponsored"
        Me.SponsoredBindingSource.DataSource = Me.JMDataSet
        '
        'Name_JournalTextBox1
        '
        Me.Name_JournalTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SponsoredBindingSource, "Name_Journal", True))
        Me.Name_JournalTextBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_JournalTextBox1.Location = New System.Drawing.Point(159, 30)
        Me.Name_JournalTextBox1.Name = "Name_JournalTextBox1"
        Me.Name_JournalTextBox1.Size = New System.Drawing.Size(200, 26)
        Me.Name_JournalTextBox1.TabIndex = 82
        '
        'Name_SponsorerTextBox
        '
        Me.Name_SponsorerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SponsoredBindingSource, "Name_Sponsorer", True))
        Me.Name_SponsorerTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_SponsorerTextBox.Location = New System.Drawing.Point(159, 74)
        Me.Name_SponsorerTextBox.Name = "Name_SponsorerTextBox"
        Me.Name_SponsorerTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Name_SponsorerTextBox.TabIndex = 84
        '
        'Sponsorer_LocationsBindingSource
        '
        Me.Sponsorer_LocationsBindingSource.DataMember = "Sponsorer_Locations"
        Me.Sponsorer_LocationsBindingSource.DataSource = Me.JMDataSet
        '
        'Name_SponsorerTextBox1
        '
        Me.Name_SponsorerTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sponsorer_LocationsBindingSource, "Name_Sponsorer", True))
        Me.Name_SponsorerTextBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_SponsorerTextBox1.Location = New System.Drawing.Point(189, 41)
        Me.Name_SponsorerTextBox1.Name = "Name_SponsorerTextBox1"
        Me.Name_SponsorerTextBox1.Size = New System.Drawing.Size(200, 26)
        Me.Name_SponsorerTextBox1.TabIndex = 85
        '
        'LocationTextBox
        '
        Me.LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Sponsorer_LocationsBindingSource, "Location", True))
        Me.LocationTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationTextBox.Location = New System.Drawing.Point(189, 80)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.Size = New System.Drawing.Size(200, 26)
        Me.LocationTextBox.TabIndex = 87
        '
        'SponsorersBindingSource
        '
        Me.SponsorersBindingSource.DataMember = "Sponsorers"
        Me.SponsorersBindingSource.DataSource = Me.JMDataSet
        '
        'Sponsorer_NameTextBox
        '
        Me.Sponsorer_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SponsorersBindingSource, "Sponsorer_Name", True))
        Me.Sponsorer_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sponsorer_NameTextBox.Location = New System.Drawing.Point(189, 193)
        Me.Sponsorer_NameTextBox.Name = "Sponsorer_NameTextBox"
        Me.Sponsorer_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Sponsorer_NameTextBox.TabIndex = 88
        '
        'Num_of_SponsorshipsTextBox
        '
        Me.Num_of_SponsorshipsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SponsorersBindingSource, "Num_of_Sponsorships", True))
        Me.Num_of_SponsorshipsTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_of_SponsorshipsTextBox.Location = New System.Drawing.Point(189, 237)
        Me.Num_of_SponsorshipsTextBox.Name = "Num_of_SponsorshipsTextBox"
        Me.Num_of_SponsorshipsTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Num_of_SponsorshipsTextBox.TabIndex = 90
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SponsorersBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(189, 282)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 26)
        Me.AddressTextBox.TabIndex = 92
        '
        'Money_SpentTextBox
        '
        Me.Money_SpentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SponsorersBindingSource, "Money_Spent", True))
        Me.Money_SpentTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Money_SpentTextBox.Location = New System.Drawing.Point(189, 319)
        Me.Money_SpentTextBox.Name = "Money_SpentTextBox"
        Me.Money_SpentTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Money_SpentTextBox.TabIndex = 94
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(559, 773)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 51)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(760, 773)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 51)
        Me.Button2.TabIndex = 96
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(953, 773)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 51)
        Me.Button3.TabIndex = 97
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1181, 773)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(215, 51)
        Me.Button4.TabIndex = 98
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(529, 720)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(419, 19)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "There are a total of 13 entires in the Journal Informaion Database"
        '
        'JournalBindingSource
        '
        Me.JournalBindingSource.DataMember = "Journal"
        Me.JournalBindingSource.DataSource = Me.JMDataSet
        '
        'JournalTableAdapter
        '
        Me.JournalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuthorTableAdapter = Me.AuthorTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Journal_ArticlesTableAdapter = Me.Journal_ArticlesTableAdapter
        Me.TableAdapterManager.Journal_Citations_ReportTableAdapter = Nothing
        Me.TableAdapterManager.Journal_DisciplinesTableAdapter = Me.Journal_DisciplinesTableAdapter
        Me.TableAdapterManager.JournalTableAdapter = Me.JournalTableAdapter
        Me.TableAdapterManager.Publisher_DomainsTableAdapter = Me.Publisher_DomainsTableAdapter
        Me.TableAdapterManager.PublisherTableAdapter = Me.PublisherTableAdapter
        Me.TableAdapterManager.SponsoredTableAdapter = Me.SponsoredTableAdapter
        Me.TableAdapterManager.Sponsorer_LocationsTableAdapter = Me.Sponsorer_LocationsTableAdapter
        Me.TableAdapterManager.SponsorersTableAdapter = Me.SponsorersTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalJournal.JMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WritesTableAdapter = Nothing
        '
        'AuthorTableAdapter
        '
        Me.AuthorTableAdapter.ClearBeforeFill = True
        '
        'Journal_ArticlesTableAdapter
        '
        Me.Journal_ArticlesTableAdapter.ClearBeforeFill = True
        '
        'Journal_DisciplinesTableAdapter
        '
        Me.Journal_DisciplinesTableAdapter.ClearBeforeFill = True
        '
        'Journal_NameTextBox
        '
        Me.Journal_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JournalBindingSource, "Journal_Name", True))
        Me.Journal_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Journal_NameTextBox.Location = New System.Drawing.Point(163, 29)
        Me.Journal_NameTextBox.Name = "Journal_NameTextBox"
        Me.Journal_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Journal_NameTextBox.TabIndex = 101
        '
        'Name_PublisherTextBox
        '
        Me.Name_PublisherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JournalBindingSource, "Name_Publisher", True))
        Me.Name_PublisherTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_PublisherTextBox.Location = New System.Drawing.Point(163, 69)
        Me.Name_PublisherTextBox.Name = "Name_PublisherTextBox"
        Me.Name_PublisherTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Name_PublisherTextBox.TabIndex = 103
        '
        'Date_of_PublishingDateTimePicker
        '
        Me.Date_of_PublishingDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.JournalBindingSource, "Date_of_Publishing", True))
        Me.Date_of_PublishingDateTimePicker.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_of_PublishingDateTimePicker.Location = New System.Drawing.Point(163, 106)
        Me.Date_of_PublishingDateTimePicker.Name = "Date_of_PublishingDateTimePicker"
        Me.Date_of_PublishingDateTimePicker.Size = New System.Drawing.Size(250, 26)
        Me.Date_of_PublishingDateTimePicker.TabIndex = 105
        '
        'ISSNTextBox
        '
        Me.ISSNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.JournalBindingSource, "ISSN", True))
        Me.ISSNTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISSNTextBox.Location = New System.Drawing.Point(163, 151)
        Me.ISSNTextBox.Name = "ISSNTextBox"
        Me.ISSNTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ISSNTextBox.TabIndex = 107
        '
        'Journal_DisciplinesBindingSource
        '
        Me.Journal_DisciplinesBindingSource.DataMember = "Journal_Disciplines"
        Me.Journal_DisciplinesBindingSource.DataSource = Me.JMDataSet
        '
        'Journal_NameTextBox1
        '
        Me.Journal_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Journal_DisciplinesBindingSource, "Journal_Name", True))
        Me.Journal_NameTextBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Journal_NameTextBox1.Location = New System.Drawing.Point(159, 130)
        Me.Journal_NameTextBox1.Name = "Journal_NameTextBox1"
        Me.Journal_NameTextBox1.Size = New System.Drawing.Size(200, 26)
        Me.Journal_NameTextBox1.TabIndex = 108
        '
        'DisciplinesTextBox
        '
        Me.DisciplinesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Journal_DisciplinesBindingSource, "Disciplines", True))
        Me.DisciplinesTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisciplinesTextBox.Location = New System.Drawing.Point(159, 169)
        Me.DisciplinesTextBox.Name = "DisciplinesTextBox"
        Me.DisciplinesTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DisciplinesTextBox.TabIndex = 110
        '
        'AuthorBindingSource
        '
        Me.AuthorBindingSource.DataMember = "Author"
        Me.AuthorBindingSource.DataSource = Me.JMDataSet
        '
        'ORCIDTextBox
        '
        Me.ORCIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "ORCID", True))
        Me.ORCIDTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ORCIDTextBox.Location = New System.Drawing.Point(174, 44)
        Me.ORCIDTextBox.Name = "ORCIDTextBox"
        Me.ORCIDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.ORCIDTextBox.TabIndex = 111
        '
        'F_NameTextBox
        '
        Me.F_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "F_Name", True))
        Me.F_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_NameTextBox.Location = New System.Drawing.Point(174, 90)
        Me.F_NameTextBox.Name = "F_NameTextBox"
        Me.F_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.F_NameTextBox.TabIndex = 113
        '
        'L_NameTextBox
        '
        Me.L_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "L_Name", True))
        Me.L_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_NameTextBox.Location = New System.Drawing.Point(174, 136)
        Me.L_NameTextBox.Name = "L_NameTextBox"
        Me.L_NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.L_NameTextBox.TabIndex = 115
        '
        'UniversityTextBox
        '
        Me.UniversityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "University", True))
        Me.UniversityTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UniversityTextBox.Location = New System.Drawing.Point(174, 174)
        Me.UniversityTextBox.Name = "UniversityTextBox"
        Me.UniversityTextBox.Size = New System.Drawing.Size(200, 26)
        Me.UniversityTextBox.TabIndex = 117
        '
        'Co_AuthorTextBox
        '
        Me.Co_AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "Co-Author", True))
        Me.Co_AuthorTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Co_AuthorTextBox.Location = New System.Drawing.Point(174, 220)
        Me.Co_AuthorTextBox.Name = "Co_AuthorTextBox"
        Me.Co_AuthorTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Co_AuthorTextBox.TabIndex = 119
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorBindingSource, "E-mail", True))
        Me.E_mailTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E_mailTextBox.Location = New System.Drawing.Point(174, 265)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(200, 26)
        Me.E_mailTextBox.TabIndex = 121
        '
        'Journal_ArticlesBindingSource
        '
        Me.Journal_ArticlesBindingSource.DataMember = "Journal-Articles"
        Me.Journal_ArticlesBindingSource.DataSource = Me.JMDataSet
        '
        'Name_JournalTextBox
        '
        Me.Name_JournalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Journal_ArticlesBindingSource, "Name_Journal", True))
        Me.Name_JournalTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_JournalTextBox.Location = New System.Drawing.Point(159, 244)
        Me.Name_JournalTextBox.Name = "Name_JournalTextBox"
        Me.Name_JournalTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Name_JournalTextBox.TabIndex = 122
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Journal_ArticlesBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(159, 282)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TitleTextBox.TabIndex = 124
        '
        'DOITextBox
        '
        Me.DOITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Journal_ArticlesBindingSource, "DOI", True))
        Me.DOITextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOITextBox.Location = New System.Drawing.Point(159, 325)
        Me.DOITextBox.Name = "DOITextBox"
        Me.DOITextBox.Size = New System.Drawing.Size(200, 26)
        Me.DOITextBox.TabIndex = 126
        '
        'CitationsTextBox
        '
        Me.CitationsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Journal_ArticlesBindingSource, "Citations", True))
        Me.CitationsTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitationsTextBox.Location = New System.Drawing.Point(159, 366)
        Me.CitationsTextBox.Name = "CitationsTextBox"
        Me.CitationsTextBox.Size = New System.Drawing.Size(200, 26)
        Me.CitationsTextBox.TabIndex = 128
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(68, 773)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 51)
        Me.Button6.TabIndex = 129
        Me.Button6.Text = "Previous"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(167, 773)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(93, 51)
        Me.Button7.TabIndex = 130
        Me.Button7.Text = "Next"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(266, 773)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(50, 51)
        Me.Button8.TabIndex = 131
        Me.Button8.Text = "> |"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(12, 773)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 51)
        Me.Button9.TabIndex = 132
        Me.Button9.Text = "| <"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalJournal.My.Resources.Resources.PIC1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1384, 71)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(365, 773)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(150, 51)
        Me.Button10.TabIndex = 133
        Me.Button10.Text = "New"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Name_JournalLabel)
        Me.GroupBox1.Controls.Add(Me.Name_JournalTextBox)
        Me.GroupBox1.Controls.Add(TitleLabel)
        Me.GroupBox1.Controls.Add(Me.TitleTextBox)
        Me.GroupBox1.Controls.Add(DOILabel)
        Me.GroupBox1.Controls.Add(Me.DOITextBox)
        Me.GroupBox1.Controls.Add(CitationsLabel)
        Me.GroupBox1.Controls.Add(Me.CitationsTextBox)
        Me.GroupBox1.Controls.Add(Journal_NameLabel1)
        Me.GroupBox1.Controls.Add(Me.Journal_NameTextBox1)
        Me.GroupBox1.Controls.Add(DisciplinesLabel)
        Me.GroupBox1.Controls.Add(Me.DisciplinesTextBox)
        Me.GroupBox1.Controls.Add(Name_JournalLabel1)
        Me.GroupBox1.Controls.Add(Me.Name_JournalTextBox1)
        Me.GroupBox1.Controls.Add(Name_SponsorerLabel)
        Me.GroupBox1.Controls.Add(Me.Name_SponsorerTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(533, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 400)
        Me.GroupBox1.TabIndex = 134
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Related to Journal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Sponsorer_NameLabel)
        Me.GroupBox2.Controls.Add(Me.Sponsorer_NameTextBox)
        Me.GroupBox2.Controls.Add(Num_of_SponsorshipsLabel)
        Me.GroupBox2.Controls.Add(Me.Num_of_SponsorshipsTextBox)
        Me.GroupBox2.Controls.Add(AddressLabel)
        Me.GroupBox2.Controls.Add(Me.AddressTextBox)
        Me.GroupBox2.Controls.Add(Money_SpentLabel)
        Me.GroupBox2.Controls.Add(Me.Money_SpentTextBox)
        Me.GroupBox2.Controls.Add(Name_SponsorerLabel1)
        Me.GroupBox2.Controls.Add(Me.Name_SponsorerTextBox1)
        Me.GroupBox2.Controls.Add(LocationLabel)
        Me.GroupBox2.Controls.Add(Me.LocationTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(987, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 370)
        Me.GroupBox2.TabIndex = 135
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Related to Sponsorers"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Name_PublisherLabel1)
        Me.GroupBox3.Controls.Add(Me.Name_PublisherTextBox1)
        Me.GroupBox3.Controls.Add(DomainLabel)
        Me.GroupBox3.Controls.Add(Me.DomainTextBox)
        Me.GroupBox3.Controls.Add(Pub_NameLabel)
        Me.GroupBox3.Controls.Add(CountryLabel)
        Me.GroupBox3.Controls.Add(Num_of_JournalsLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(533, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(863, 143)
        Me.GroupBox3.TabIndex = 136
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Related to Publishers"
        '
        'GroupBox4
        '
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
        Me.GroupBox4.Location = New System.Drawing.Point(46, 340)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(427, 340)
        Me.GroupBox4.TabIndex = 137
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Data Related to Author"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Journal_NameLabel)
        Me.GroupBox5.Controls.Add(Me.Journal_NameTextBox)
        Me.GroupBox5.Controls.Add(Name_PublisherLabel)
        Me.GroupBox5.Controls.Add(Me.Name_PublisherTextBox)
        Me.GroupBox5.Controls.Add(Date_of_PublishingLabel)
        Me.GroupBox5.Controls.Add(Me.Date_of_PublishingDateTimePicker)
        Me.GroupBox5.Controls.Add(ISSNLabel)
        Me.GroupBox5.Controls.Add(Me.ISSNTextBox)
        Me.GroupBox5.Location = New System.Drawing.Point(42, 115)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(430, 206)
        Me.GroupBox5.TabIndex = 138
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data Related to Journal"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1181, 705)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(215, 51)
        Me.Button5.TabIndex = 139
        Me.Button5.Text = "Generate Report"
        Me.Button5.UseVisualStyleBackColor = True
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
        'LoginDataSet
        '
        Me.LoginDataSet.DataSetName = "LoginDataSet"
        Me.LoginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Login1BindingSource
        '
        Me.Login1BindingSource.DataMember = "Login1"
        Me.Login1BindingSource.DataSource = Me.LoginDataSet
        '
        'Login1TableAdapter
        '
        Me.Login1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Login1TableAdapter = Me.Login1TableAdapter
        Me.TableAdapterManager2.UpdateOrder = FinalJournal.LoginDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SuperUserUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1428, 865)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pub_NameTextBox)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Me.Num_of_JournalsTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "SuperUserUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuperUserUpdate"
        CType(Me.JMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublisherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Publisher_DomainsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponsoredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sponsorer_LocationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponsorersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JournalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journal_DisciplinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journal_ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.SuperUserDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents JMDataSet As FinalJournal.JMDataSet
    Friend WithEvents PublisherTableAdapter As FinalJournal.JMDataSetTableAdapters.PublisherTableAdapter
    Friend WithEvents PublisherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Publisher_DomainsTableAdapter As FinalJournal.JMDataSetTableAdapters.Publisher_DomainsTableAdapter
    Friend WithEvents Pub_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Num_of_JournalsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Publisher_DomainsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponsoredTableAdapter As FinalJournal.JMDataSetTableAdapters.SponsoredTableAdapter
    Friend WithEvents Name_PublisherTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DomainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SponsoredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sponsorer_LocationsTableAdapter As FinalJournal.JMDataSetTableAdapters.Sponsorer_LocationsTableAdapter
    Friend WithEvents Name_JournalTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Name_SponsorerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sponsorer_LocationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponsorersTableAdapter As FinalJournal.JMDataSetTableAdapters.SponsorersTableAdapter
    Friend WithEvents Name_SponsorerTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SponsorersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sponsorer_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Num_of_SponsorshipsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Money_SpentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents JournalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JournalTableAdapter As FinalJournal.JMDataSetTableAdapters.JournalTableAdapter
    Friend WithEvents TableAdapterManager As FinalJournal.JMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Journal_DisciplinesTableAdapter As FinalJournal.JMDataSetTableAdapters.Journal_DisciplinesTableAdapter
    Friend WithEvents Journal_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_PublisherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_PublishingDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ISSNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Journal_DisciplinesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuthorTableAdapter As FinalJournal.JMDataSetTableAdapters.AuthorTableAdapter
    Friend WithEvents Journal_NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DisciplinesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Journal_ArticlesTableAdapter As FinalJournal.JMDataSetTableAdapters.Journal_ArticlesTableAdapter
    Friend WithEvents ORCIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents F_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UniversityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Co_AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_mailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Journal_ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Name_JournalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOITextBox As System.Windows.Forms.TextBox
    Friend WithEvents CitationsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents SuperUserDataSet As FinalJournal.SuperUserDataSet
    Friend WithEvents SUUSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SUUSTableAdapter As FinalJournal.SuperUserDataSetTableAdapters.SUUSTableAdapter
    Friend WithEvents TableAdapterManager1 As FinalJournal.SuperUserDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LoginDataSet As FinalJournal.LoginDataSet
    Friend WithEvents Login1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Login1TableAdapter As FinalJournal.LoginDataSetTableAdapters.Login1TableAdapter
    Friend WithEvents TableAdapterManager2 As FinalJournal.LoginDataSetTableAdapters.TableAdapterManager
End Class
