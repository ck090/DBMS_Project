<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim Journal_NameLabel As System.Windows.Forms.Label
        Dim Journal_ArticleLabel As System.Windows.Forms.Label
        Dim PagesLabel As System.Windows.Forms.Label
        Dim ISSN_NumberLabel As System.Windows.Forms.Label
        Dim Date_of_PublishingLabel As System.Windows.Forms.Label
        Dim Impact_FactorLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TabBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TabBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Journal12DataSet = New FinalJournal.journal12DataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TabBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.Journal_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Journal_ArticleTextBox = New System.Windows.Forms.TextBox()
        Me.PagesTextBox = New System.Windows.Forms.TextBox()
        Me.ISSN_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_PublishingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Impact_FactorTextBox = New System.Windows.Forms.TextBox()
        Me.AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.TabTableAdapter = New FinalJournal.journal12DataSetTableAdapters.TabTableAdapter()
        Me.TableAdapterManager = New FinalJournal.journal12DataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        IDLabel = New System.Windows.Forms.Label()
        Journal_NameLabel = New System.Windows.Forms.Label()
        Journal_ArticleLabel = New System.Windows.Forms.Label()
        PagesLabel = New System.Windows.Forms.Label()
        ISSN_NumberLabel = New System.Windows.Forms.Label()
        Date_of_PublishingLabel = New System.Windows.Forms.Label()
        Impact_FactorLabel = New System.Windows.Forms.Label()
        AuthorLabel = New System.Windows.Forms.Label()
        CType(Me.TabBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabBindingNavigator.SuspendLayout()
        CType(Me.TabBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Journal12DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(60, 134)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(33, 21)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'Journal_NameLabel
        '
        Journal_NameLabel.AutoSize = True
        Journal_NameLabel.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Journal_NameLabel.Location = New System.Drawing.Point(60, 180)
        Journal_NameLabel.Name = "Journal_NameLabel"
        Journal_NameLabel.Size = New System.Drawing.Size(130, 21)
        Journal_NameLabel.TabIndex = 3
        Journal_NameLabel.Text = "Journal Name:"
        '
        'Journal_ArticleLabel
        '
        Journal_ArticleLabel.AutoSize = True
        Journal_ArticleLabel.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Journal_ArticleLabel.Location = New System.Drawing.Point(60, 219)
        Journal_ArticleLabel.Name = "Journal_ArticleLabel"
        Journal_ArticleLabel.Size = New System.Drawing.Size(136, 21)
        Journal_ArticleLabel.TabIndex = 5
        Journal_ArticleLabel.Text = "Journal Article:"
        '
        'PagesLabel
        '
        PagesLabel.AutoSize = True
        PagesLabel.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PagesLabel.Location = New System.Drawing.Point(60, 263)
        PagesLabel.Name = "PagesLabel"
        PagesLabel.Size = New System.Drawing.Size(64, 21)
        PagesLabel.TabIndex = 7
        PagesLabel.Text = "Pages:"
        AddHandler PagesLabel.Click, AddressOf Me.PagesLabel_Click
        '
        'ISSN_NumberLabel
        '
        ISSN_NumberLabel.AutoSize = True
        ISSN_NumberLabel.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ISSN_NumberLabel.Location = New System.Drawing.Point(60, 302)
        ISSN_NumberLabel.Name = "ISSN_NumberLabel"
        ISSN_NumberLabel.Size = New System.Drawing.Size(123, 21)
        ISSN_NumberLabel.TabIndex = 9
        ISSN_NumberLabel.Text = "ISSN Number:"
        '
        'Date_of_PublishingLabel
        '
        Date_of_PublishingLabel.AutoSize = True
        Date_of_PublishingLabel.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_PublishingLabel.Location = New System.Drawing.Point(60, 347)
        Date_of_PublishingLabel.Name = "Date_of_PublishingLabel"
        Date_of_PublishingLabel.Size = New System.Drawing.Size(168, 21)
        Date_of_PublishingLabel.TabIndex = 11
        Date_of_PublishingLabel.Text = "Date of Publishing:"
        '
        'Impact_FactorLabel
        '
        Impact_FactorLabel.AutoSize = True
        Impact_FactorLabel.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Impact_FactorLabel.Location = New System.Drawing.Point(60, 392)
        Impact_FactorLabel.Name = "Impact_FactorLabel"
        Impact_FactorLabel.Size = New System.Drawing.Size(130, 21)
        Impact_FactorLabel.TabIndex = 13
        Impact_FactorLabel.Text = "Impact Factor:"
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AuthorLabel.Location = New System.Drawing.Point(60, 436)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(71, 21)
        AuthorLabel.TabIndex = 15
        AuthorLabel.Text = "Author:"
        '
        'TabBindingNavigator
        '
        Me.TabBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TabBindingNavigator.BindingSource = Me.TabBindingSource
        Me.TabBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TabBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TabBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TabBindingNavigatorSaveItem})
        Me.TabBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TabBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TabBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TabBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TabBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TabBindingNavigator.Name = "TabBindingNavigator"
        Me.TabBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TabBindingNavigator.Size = New System.Drawing.Size(930, 25)
        Me.TabBindingNavigator.TabIndex = 0
        Me.TabBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'TabBindingSource
        '
        Me.TabBindingSource.DataMember = "Tab"
        Me.TabBindingSource.DataSource = Me.Journal12DataSet
        '
        'Journal12DataSet
        '
        Me.Journal12DataSet.DataSetName = "journal12DataSet"
        Me.Journal12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TabBindingNavigatorSaveItem
        '
        Me.TabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TabBindingNavigatorSaveItem.Image = CType(resources.GetObject("TabBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TabBindingNavigatorSaveItem.Name = "TabBindingNavigatorSaveItem"
        Me.TabBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TabBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(370, 134)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(308, 29)
        Me.IDTextBox.TabIndex = 2
        '
        'Journal_NameTextBox
        '
        Me.Journal_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabBindingSource, "Journal Name", True))
        Me.Journal_NameTextBox.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Journal_NameTextBox.Location = New System.Drawing.Point(370, 177)
        Me.Journal_NameTextBox.Name = "Journal_NameTextBox"
        Me.Journal_NameTextBox.Size = New System.Drawing.Size(308, 29)
        Me.Journal_NameTextBox.TabIndex = 4
        '
        'Journal_ArticleTextBox
        '
        Me.Journal_ArticleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabBindingSource, "Journal Article", True))
        Me.Journal_ArticleTextBox.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Journal_ArticleTextBox.Location = New System.Drawing.Point(370, 216)
        Me.Journal_ArticleTextBox.Name = "Journal_ArticleTextBox"
        Me.Journal_ArticleTextBox.Size = New System.Drawing.Size(308, 29)
        Me.Journal_ArticleTextBox.TabIndex = 6
        '
        'PagesTextBox
        '
        Me.PagesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabBindingSource, "Pages", True))
        Me.PagesTextBox.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PagesTextBox.Location = New System.Drawing.Point(370, 255)
        Me.PagesTextBox.Name = "PagesTextBox"
        Me.PagesTextBox.Size = New System.Drawing.Size(308, 29)
        Me.PagesTextBox.TabIndex = 8
        '
        'ISSN_NumberTextBox
        '
        Me.ISSN_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabBindingSource, "ISSN Number", True))
        Me.ISSN_NumberTextBox.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISSN_NumberTextBox.Location = New System.Drawing.Point(370, 299)
        Me.ISSN_NumberTextBox.Name = "ISSN_NumberTextBox"
        Me.ISSN_NumberTextBox.Size = New System.Drawing.Size(308, 29)
        Me.ISSN_NumberTextBox.TabIndex = 10
        '
        'Date_of_PublishingDateTimePicker
        '
        Me.Date_of_PublishingDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TabBindingSource, "Date of Publishing", True))
        Me.Date_of_PublishingDateTimePicker.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_of_PublishingDateTimePicker.Location = New System.Drawing.Point(370, 341)
        Me.Date_of_PublishingDateTimePicker.Name = "Date_of_PublishingDateTimePicker"
        Me.Date_of_PublishingDateTimePicker.Size = New System.Drawing.Size(308, 29)
        Me.Date_of_PublishingDateTimePicker.TabIndex = 12
        '
        'Impact_FactorTextBox
        '
        Me.Impact_FactorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabBindingSource, "Impact Factor", True))
        Me.Impact_FactorTextBox.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Impact_FactorTextBox.Location = New System.Drawing.Point(370, 389)
        Me.Impact_FactorTextBox.Name = "Impact_FactorTextBox"
        Me.Impact_FactorTextBox.Size = New System.Drawing.Size(308, 29)
        Me.Impact_FactorTextBox.TabIndex = 14
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TabBindingSource, "Author", True))
        Me.AuthorTextBox.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorTextBox.Location = New System.Drawing.Point(370, 433)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(308, 29)
        Me.AuthorTextBox.TabIndex = 16
        '
        'TabTableAdapter
        '
        Me.TabTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TabTableAdapter = Me.TabTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalJournal.journal12DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(568, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 32)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(64, 64)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(494, 32)
        Me.TextBox1.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(747, 533)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 43)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "LOGOUT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(510, 533)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 43)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(260, 533)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(162, 43)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 533)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(162, 43)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "NEW"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 588)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Journal_NameLabel)
        Me.Controls.Add(Me.Journal_NameTextBox)
        Me.Controls.Add(Journal_ArticleLabel)
        Me.Controls.Add(Me.Journal_ArticleTextBox)
        Me.Controls.Add(PagesLabel)
        Me.Controls.Add(Me.PagesTextBox)
        Me.Controls.Add(ISSN_NumberLabel)
        Me.Controls.Add(Me.ISSN_NumberTextBox)
        Me.Controls.Add(Date_of_PublishingLabel)
        Me.Controls.Add(Me.Date_of_PublishingDateTimePicker)
        Me.Controls.Add(Impact_FactorLabel)
        Me.Controls.Add(Me.Impact_FactorTextBox)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(Me.TabBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Main Page"
        CType(Me.TabBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabBindingNavigator.ResumeLayout(False)
        Me.TabBindingNavigator.PerformLayout()
        CType(Me.TabBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Journal12DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Journal12DataSet As FinalJournal.journal12DataSet
    Friend WithEvents TabBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TabTableAdapter As FinalJournal.journal12DataSetTableAdapters.TabTableAdapter
    Friend WithEvents TableAdapterManager As FinalJournal.journal12DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TabBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Journal_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Journal_ArticleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PagesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ISSN_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_PublishingDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Impact_FactorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
