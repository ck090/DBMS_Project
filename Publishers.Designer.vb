<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Publishers
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
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Num_of_JournalsLabel As System.Windows.Forms.Label
        Dim Name_PublisherLabel As System.Windows.Forms.Label
        Dim DomainLabel As System.Windows.Forms.Label
        Dim Name_JournalLabel As System.Windows.Forms.Label
        Dim Name_SponsorerLabel As System.Windows.Forms.Label
        Me.JMDataSet = New FinalJournal.JMDataSet()
        Me.PublisherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PublisherTableAdapter = New FinalJournal.JMDataSetTableAdapters.PublisherTableAdapter()
        Me.TableAdapterManager = New FinalJournal.JMDataSetTableAdapters.TableAdapterManager()
        Me.Publisher_DomainsTableAdapter = New FinalJournal.JMDataSetTableAdapters.Publisher_DomainsTableAdapter()
        Me.SponsoredTableAdapter = New FinalJournal.JMDataSetTableAdapters.SponsoredTableAdapter()
        Me.Sponsorer_LocationsTableAdapter = New FinalJournal.JMDataSetTableAdapters.Sponsorer_LocationsTableAdapter()
        Me.SponsorersTableAdapter = New FinalJournal.JMDataSetTableAdapters.SponsorersTableAdapter()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Num_of_JournalsTextBox = New System.Windows.Forms.TextBox()
        Me.Publisher_DomainsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Name_PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.DomainTextBox = New System.Windows.Forms.TextBox()
        Me.SponsoredBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Name_JournalTextBox = New System.Windows.Forms.TextBox()
        Me.Name_SponsorerTextBox = New System.Windows.Forms.TextBox()
        Me.Sponsorer_LocationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sponsorer_LocationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SponsorersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SponsorersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CountryLabel = New System.Windows.Forms.Label()
        Num_of_JournalsLabel = New System.Windows.Forms.Label()
        Name_PublisherLabel = New System.Windows.Forms.Label()
        DomainLabel = New System.Windows.Forms.Label()
        Name_JournalLabel = New System.Windows.Forms.Label()
        Name_SponsorerLabel = New System.Windows.Forms.Label()
        CType(Me.JMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PublisherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Publisher_DomainsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponsoredBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sponsorer_LocationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sponsorer_LocationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponsorersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SponsorersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.BackColor = System.Drawing.Color.Transparent
        CountryLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.Location = New System.Drawing.Point(88, 204)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(79, 25)
        CountryLabel.TabIndex = 3
        CountryLabel.Text = "Country:"
        '
        'Num_of_JournalsLabel
        '
        Num_of_JournalsLabel.AutoSize = True
        Num_of_JournalsLabel.BackColor = System.Drawing.Color.Transparent
        Num_of_JournalsLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_of_JournalsLabel.Location = New System.Drawing.Point(88, 255)
        Num_of_JournalsLabel.Name = "Num_of_JournalsLabel"
        Num_of_JournalsLabel.Size = New System.Drawing.Size(143, 25)
        Num_of_JournalsLabel.TabIndex = 5
        Num_of_JournalsLabel.Text = "Num of Journals:"
        '
        'Name_PublisherLabel
        '
        Name_PublisherLabel.AutoSize = True
        Name_PublisherLabel.BackColor = System.Drawing.Color.Transparent
        Name_PublisherLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_PublisherLabel.Location = New System.Drawing.Point(88, 150)
        Name_PublisherLabel.Name = "Name_PublisherLabel"
        Name_PublisherLabel.Size = New System.Drawing.Size(141, 25)
        Name_PublisherLabel.TabIndex = 7
        Name_PublisherLabel.Text = "Publisher Name:"
        '
        'DomainLabel
        '
        DomainLabel.AutoSize = True
        DomainLabel.BackColor = System.Drawing.Color.Transparent
        DomainLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DomainLabel.Location = New System.Drawing.Point(88, 311)
        DomainLabel.Name = "DomainLabel"
        DomainLabel.Size = New System.Drawing.Size(79, 25)
        DomainLabel.TabIndex = 9
        DomainLabel.Text = "Domain:"
        '
        'Name_JournalLabel
        '
        Name_JournalLabel.AutoSize = True
        Name_JournalLabel.BackColor = System.Drawing.Color.Transparent
        Name_JournalLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_JournalLabel.Location = New System.Drawing.Point(604, 158)
        Name_JournalLabel.Name = "Name_JournalLabel"
        Name_JournalLabel.Size = New System.Drawing.Size(125, 25)
        Name_JournalLabel.TabIndex = 10
        Name_JournalLabel.Text = "Name Journal:"
        '
        'Name_SponsorerLabel
        '
        Name_SponsorerLabel.AutoSize = True
        Name_SponsorerLabel.BackColor = System.Drawing.Color.Transparent
        Name_SponsorerLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_SponsorerLabel.Location = New System.Drawing.Point(604, 244)
        Name_SponsorerLabel.Name = "Name_SponsorerLabel"
        Name_SponsorerLabel.Size = New System.Drawing.Size(145, 25)
        Name_SponsorerLabel.TabIndex = 12
        Name_SponsorerLabel.Text = "Name Sponsorer:"
        '
        'JMDataSet
        '
        Me.JMDataSet.DataSetName = "JMDataSet"
        Me.JMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PublisherBindingSource
        '
        Me.PublisherBindingSource.DataMember = "Publisher"
        Me.PublisherBindingSource.DataSource = Me.JMDataSet
        '
        'PublisherTableAdapter
        '
        Me.PublisherTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AuthorTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Journal_ArticlesTableAdapter = Nothing
        Me.TableAdapterManager.Journal_Citations_ReportTableAdapter = Nothing
        Me.TableAdapterManager.Journal_DisciplinesTableAdapter = Nothing
        Me.TableAdapterManager.JournalTableAdapter = Nothing
        Me.TableAdapterManager.Publisher_DomainsTableAdapter = Me.Publisher_DomainsTableAdapter
        Me.TableAdapterManager.PublisherTableAdapter = Me.PublisherTableAdapter
        Me.TableAdapterManager.SponsoredTableAdapter = Me.SponsoredTableAdapter
        Me.TableAdapterManager.Sponsorer_LocationsTableAdapter = Me.Sponsorer_LocationsTableAdapter
        Me.TableAdapterManager.SponsorersTableAdapter = Me.SponsorersTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalJournal.JMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WritesTableAdapter = Nothing
        '
        'Publisher_DomainsTableAdapter
        '
        Me.Publisher_DomainsTableAdapter.ClearBeforeFill = True
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
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublisherBindingSource, "Country", True))
        Me.CountryTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryTextBox.Location = New System.Drawing.Point(264, 201)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(189, 32)
        Me.CountryTextBox.TabIndex = 4
        '
        'Num_of_JournalsTextBox
        '
        Me.Num_of_JournalsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublisherBindingSource, "Num_of_Journals", True))
        Me.Num_of_JournalsTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_of_JournalsTextBox.Location = New System.Drawing.Point(264, 252)
        Me.Num_of_JournalsTextBox.Name = "Num_of_JournalsTextBox"
        Me.Num_of_JournalsTextBox.Size = New System.Drawing.Size(189, 32)
        Me.Num_of_JournalsTextBox.TabIndex = 6
        '
        'Publisher_DomainsBindingSource
        '
        Me.Publisher_DomainsBindingSource.DataMember = "Publisher_Domains"
        Me.Publisher_DomainsBindingSource.DataSource = Me.JMDataSet
        '
        'Name_PublisherTextBox
        '
        Me.Name_PublisherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Publisher_DomainsBindingSource, "Name_Publisher", True))
        Me.Name_PublisherTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_PublisherTextBox.Location = New System.Drawing.Point(264, 147)
        Me.Name_PublisherTextBox.Name = "Name_PublisherTextBox"
        Me.Name_PublisherTextBox.Size = New System.Drawing.Size(189, 32)
        Me.Name_PublisherTextBox.TabIndex = 8
        '
        'DomainTextBox
        '
        Me.DomainTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Publisher_DomainsBindingSource, "Domain", True))
        Me.DomainTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomainTextBox.Location = New System.Drawing.Point(264, 308)
        Me.DomainTextBox.Name = "DomainTextBox"
        Me.DomainTextBox.Size = New System.Drawing.Size(189, 32)
        Me.DomainTextBox.TabIndex = 10
        '
        'SponsoredBindingSource
        '
        Me.SponsoredBindingSource.DataMember = "Sponsored"
        Me.SponsoredBindingSource.DataSource = Me.JMDataSet
        '
        'Name_JournalTextBox
        '
        Me.Name_JournalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SponsoredBindingSource, "Name_Journal", True))
        Me.Name_JournalTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_JournalTextBox.Location = New System.Drawing.Point(553, 186)
        Me.Name_JournalTextBox.Name = "Name_JournalTextBox"
        Me.Name_JournalTextBox.Size = New System.Drawing.Size(244, 32)
        Me.Name_JournalTextBox.TabIndex = 11
        '
        'Name_SponsorerTextBox
        '
        Me.Name_SponsorerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SponsoredBindingSource, "Name_Sponsorer", True))
        Me.Name_SponsorerTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_SponsorerTextBox.Location = New System.Drawing.Point(553, 272)
        Me.Name_SponsorerTextBox.Name = "Name_SponsorerTextBox"
        Me.Name_SponsorerTextBox.Size = New System.Drawing.Size(244, 32)
        Me.Name_SponsorerTextBox.TabIndex = 13
        '
        'Sponsorer_LocationsBindingSource
        '
        Me.Sponsorer_LocationsBindingSource.DataMember = "Sponsorer_Locations"
        Me.Sponsorer_LocationsBindingSource.DataSource = Me.JMDataSet
        '
        'Sponsorer_LocationsDataGridView
        '
        Me.Sponsorer_LocationsDataGridView.AutoGenerateColumns = False
        Me.Sponsorer_LocationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sponsorer_LocationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.Sponsorer_LocationsDataGridView.DataSource = Me.Sponsorer_LocationsBindingSource
        Me.Sponsorer_LocationsDataGridView.Location = New System.Drawing.Point(93, 416)
        Me.Sponsorer_LocationsDataGridView.Name = "Sponsorer_LocationsDataGridView"
        Me.Sponsorer_LocationsDataGridView.Size = New System.Drawing.Size(243, 119)
        Me.Sponsorer_LocationsDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Name_Sponsorer"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name_Sponsorer"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Location"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Location"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'SponsorersBindingSource
        '
        Me.SponsorersBindingSource.DataMember = "Sponsorers"
        Me.SponsorersBindingSource.DataSource = Me.JMDataSet
        '
        'SponsorersDataGridView
        '
        Me.SponsorersDataGridView.AutoGenerateColumns = False
        Me.SponsorersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SponsorersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SponsorersDataGridView.DataSource = Me.SponsorersBindingSource
        Me.SponsorersDataGridView.Location = New System.Drawing.Point(387, 418)
        Me.SponsorersDataGridView.Name = "SponsorersDataGridView"
        Me.SponsorersDataGridView.Size = New System.Drawing.Size(443, 117)
        Me.SponsorersDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Sponsorer_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Sponsorer_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Num_of_Sponsorships"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Num_of_Sponsorships"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Money_Spent"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Money_Spent"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(361, 577)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 63)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Previous"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(464, 577)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 63)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Next "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(777, 577)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 63)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Go Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(219, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 34)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "SPONSORS AND CITATION INFORMATION PAGE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalJournal.My.Resources.Resources.PIC1
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(881, 62)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Publishers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalJournal.My.Resources.Resources.Plain_Wallpapers_HD_A25
        Me.ClientSize = New System.Drawing.Size(906, 652)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SponsorersDataGridView)
        Me.Controls.Add(Me.Sponsorer_LocationsDataGridView)
        Me.Controls.Add(Name_JournalLabel)
        Me.Controls.Add(Me.Name_JournalTextBox)
        Me.Controls.Add(Name_SponsorerLabel)
        Me.Controls.Add(Me.Name_SponsorerTextBox)
        Me.Controls.Add(Name_PublisherLabel)
        Me.Controls.Add(Me.Name_PublisherTextBox)
        Me.Controls.Add(DomainLabel)
        Me.Controls.Add(Me.DomainTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Num_of_JournalsLabel)
        Me.Controls.Add(Me.Num_of_JournalsTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Publishers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Publishers"
        CType(Me.JMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PublisherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Publisher_DomainsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponsoredBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sponsorer_LocationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sponsorer_LocationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponsorersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SponsorersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JMDataSet As FinalJournal.JMDataSet
    Friend WithEvents PublisherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PublisherTableAdapter As FinalJournal.JMDataSetTableAdapters.PublisherTableAdapter
    Friend WithEvents TableAdapterManager As FinalJournal.JMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Num_of_JournalsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Publisher_DomainsTableAdapter As FinalJournal.JMDataSetTableAdapters.Publisher_DomainsTableAdapter
    Friend WithEvents Publisher_DomainsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Name_PublisherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DomainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SponsoredTableAdapter As FinalJournal.JMDataSetTableAdapters.SponsoredTableAdapter
    Friend WithEvents SponsoredBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sponsorer_LocationsTableAdapter As FinalJournal.JMDataSetTableAdapters.Sponsorer_LocationsTableAdapter
    Friend WithEvents Name_JournalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_SponsorerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sponsorer_LocationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponsorersTableAdapter As FinalJournal.JMDataSetTableAdapters.SponsorersTableAdapter
    Friend WithEvents Sponsorer_LocationsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SponsorersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SponsorersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
