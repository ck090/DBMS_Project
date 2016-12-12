<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Page
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
        Me.AuthorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JMDataSet = New FinalJournal.JMDataSet()
        Me.JournalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Journal_ArticlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Journal_DisciplinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AuthorTableAdapter = New FinalJournal.JMDataSetTableAdapters.AuthorTableAdapter()
        Me.TableAdapterManager = New FinalJournal.JMDataSetTableAdapters.TableAdapterManager()
        Me.Journal_ArticlesTableAdapter = New FinalJournal.JMDataSetTableAdapters.Journal_ArticlesTableAdapter()
        Me.Journal_DisciplinesTableAdapter = New FinalJournal.JMDataSetTableAdapters.Journal_DisciplinesTableAdapter()
        Me.JournalTableAdapter = New FinalJournal.JMDataSetTableAdapters.JournalTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JournalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journal_ArticlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journal_DisciplinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'JournalBindingSource
        '
        Me.JournalBindingSource.DataMember = "Journal"
        Me.JournalBindingSource.DataSource = Me.JMDataSet
        '
        'Journal_ArticlesBindingSource
        '
        Me.Journal_ArticlesBindingSource.DataMember = "Journal-Articles"
        Me.Journal_ArticlesBindingSource.DataSource = Me.JMDataSet
        '
        'Journal_DisciplinesBindingSource
        '
        Me.Journal_DisciplinesBindingSource.DataMember = "Journal_Disciplines"
        Me.Journal_DisciplinesBindingSource.DataSource = Me.JMDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(248, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(517, 34)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "WELCOME TO JOURNAL INFORMATON DATABASE"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Journal Name", "Title of Journal Article", "Citation Report", "Name of Author", "Publisher"})
        Me.ComboBox1.Location = New System.Drawing.Point(366, 168)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(249, 39)
        Me.ComboBox1.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(217, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 31)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Search By :"
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
        Me.TableAdapterManager.Journal_Citations_ReportTableAdapter = Nothing
        Me.TableAdapterManager.Journal_DisciplinesTableAdapter = Me.Journal_DisciplinesTableAdapter
        Me.TableAdapterManager.JournalTableAdapter = Me.JournalTableAdapter
        Me.TableAdapterManager.Publisher_DomainsTableAdapter = Nothing
        Me.TableAdapterManager.PublisherTableAdapter = Nothing
        Me.TableAdapterManager.SponsoredTableAdapter = Nothing
        Me.TableAdapterManager.Sponsorer_LocationsTableAdapter = Nothing
        Me.TableAdapterManager.SponsorersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FinalJournal.JMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WritesTableAdapter = Nothing
        '
        'Journal_ArticlesTableAdapter
        '
        Me.Journal_ArticlesTableAdapter.ClearBeforeFill = True
        '
        'Journal_DisciplinesTableAdapter
        '
        Me.Journal_DisciplinesTableAdapter.ClearBeforeFill = True
        '
        'JournalTableAdapter
        '
        Me.JournalTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalJournal.My.Resources.Resources.PIC1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(968, 73)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(636, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 39)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalJournal.My.Resources.Resources.Plain_Wallpapers_HD_A251
        Me.ClientSize = New System.Drawing.Size(988, 312)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Main_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main_Page"
        CType(Me.AuthorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JournalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journal_ArticlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journal_DisciplinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JMDataSet As FinalJournal.JMDataSet
    Friend WithEvents AuthorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AuthorTableAdapter As FinalJournal.JMDataSetTableAdapters.AuthorTableAdapter
    Friend WithEvents TableAdapterManager As FinalJournal.JMDataSetTableAdapters.TableAdapterManager
    Friend WithEvents JournalTableAdapter As FinalJournal.JMDataSetTableAdapters.JournalTableAdapter
    Friend WithEvents JournalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Journal_ArticlesTableAdapter As FinalJournal.JMDataSetTableAdapters.Journal_ArticlesTableAdapter
    Friend WithEvents Journal_ArticlesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Journal_DisciplinesTableAdapter As FinalJournal.JMDataSetTableAdapters.Journal_DisciplinesTableAdapter
    Friend WithEvents Journal_DisciplinesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
