<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class journalsearch
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
        Dim Journal_NameLabel As System.Windows.Forms.Label
        Dim Name_PublisherLabel As System.Windows.Forms.Label
        Dim Date_of_PublishingLabel As System.Windows.Forms.Label
        Dim ISSNLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Journal_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Name_PublisherTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_PublishingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ISSNTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Journal_NameLabel = New System.Windows.Forms.Label()
        Name_PublisherLabel = New System.Windows.Forms.Label()
        Date_of_PublishingLabel = New System.Windows.Forms.Label()
        ISSNLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Journal_NameLabel
        '
        Journal_NameLabel.AutoSize = True
        Journal_NameLabel.BackColor = System.Drawing.Color.Transparent
        Journal_NameLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Journal_NameLabel.Location = New System.Drawing.Point(189, 428)
        Journal_NameLabel.Name = "Journal_NameLabel"
        Journal_NameLabel.Size = New System.Drawing.Size(125, 25)
        Journal_NameLabel.TabIndex = 45
        Journal_NameLabel.Text = "Journal Name:"
        '
        'Name_PublisherLabel
        '
        Name_PublisherLabel.AutoSize = True
        Name_PublisherLabel.BackColor = System.Drawing.Color.Transparent
        Name_PublisherLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Name_PublisherLabel.Location = New System.Drawing.Point(189, 473)
        Name_PublisherLabel.Name = "Name_PublisherLabel"
        Name_PublisherLabel.Size = New System.Drawing.Size(141, 25)
        Name_PublisherLabel.TabIndex = 47
        Name_PublisherLabel.Text = "Name Publisher:"
        '
        'Date_of_PublishingLabel
        '
        Date_of_PublishingLabel.AutoSize = True
        Date_of_PublishingLabel.BackColor = System.Drawing.Color.Transparent
        Date_of_PublishingLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_PublishingLabel.Location = New System.Drawing.Point(189, 526)
        Date_of_PublishingLabel.Name = "Date_of_PublishingLabel"
        Date_of_PublishingLabel.Size = New System.Drawing.Size(162, 25)
        Date_of_PublishingLabel.TabIndex = 49
        Date_of_PublishingLabel.Text = "Date of Publishing:"
        '
        'ISSNLabel
        '
        ISSNLabel.AutoSize = True
        ISSNLabel.BackColor = System.Drawing.Color.Transparent
        ISSNLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ISSNLabel.Location = New System.Drawing.Point(189, 571)
        ISSNLabel.Name = "ISSNLabel"
        ISSNLabel.Size = New System.Drawing.Size(67, 25)
        ISSNLabel.TabIndex = 51
        ISSNLabel.Text = "Access:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(664, 238)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(70, 25)
        Label2.TabIndex = 55
        Label2.Text = "Search:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 34)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "JOURNAL INFORMATON DATABASE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalJournal.My.Resources.Resources.PIC1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(911, 138)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Journal_NameTextBox
        '
        Me.Journal_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Journal_NameTextBox.Location = New System.Drawing.Point(411, 425)
        Me.Journal_NameTextBox.Name = "Journal_NameTextBox"
        Me.Journal_NameTextBox.Size = New System.Drawing.Size(341, 32)
        Me.Journal_NameTextBox.TabIndex = 46
        '
        'Name_PublisherTextBox
        '
        Me.Name_PublisherTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_PublisherTextBox.Location = New System.Drawing.Point(411, 470)
        Me.Name_PublisherTextBox.Name = "Name_PublisherTextBox"
        Me.Name_PublisherTextBox.Size = New System.Drawing.Size(341, 32)
        Me.Name_PublisherTextBox.TabIndex = 48
        '
        'Date_of_PublishingDateTimePicker
        '
        Me.Date_of_PublishingDateTimePicker.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_of_PublishingDateTimePicker.Location = New System.Drawing.Point(411, 520)
        Me.Date_of_PublishingDateTimePicker.Name = "Date_of_PublishingDateTimePicker"
        Me.Date_of_PublishingDateTimePicker.Size = New System.Drawing.Size(341, 32)
        Me.Date_of_PublishingDateTimePicker.TabIndex = 50
        '
        'ISSNTextBox
        '
        Me.ISSNTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISSNTextBox.Location = New System.Drawing.Point(411, 568)
        Me.ISSNTextBox.Name = "ISSNTextBox"
        Me.ISSNTextBox.Size = New System.Drawing.Size(200, 32)
        Me.ISSNTextBox.TabIndex = 52
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.Size = New System.Drawing.Size(430, 184)
        Me.DataGridView1.TabIndex = 53
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(577, 281)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(243, 36)
        Me.TextBox5.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bernard MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(795, 594)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 49)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'journalsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalJournal.My.Resources.Resources.Plain_Wallpapers_HD_A251
        Me.ClientSize = New System.Drawing.Size(935, 652)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Journal_NameLabel)
        Me.Controls.Add(Me.Journal_NameTextBox)
        Me.Controls.Add(Name_PublisherLabel)
        Me.Controls.Add(Me.Name_PublisherTextBox)
        Me.Controls.Add(Date_of_PublishingLabel)
        Me.Controls.Add(Me.Date_of_PublishingDateTimePicker)
        Me.Controls.Add(ISSNLabel)
        Me.Controls.Add(Me.ISSNTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "journalsearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "journalsearch"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Journal_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_PublisherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_PublishingDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ISSNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
