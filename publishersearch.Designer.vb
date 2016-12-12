<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class publishersearch
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Pub_NameLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Num_of_JournalsLabel As System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Pub_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.Num_of_JournalsTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        Pub_NameLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Num_of_JournalsLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(664, 238)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(70, 25)
        Label2.TabIndex = 75
        Label2.Text = "Search:"
        '
        'Pub_NameLabel
        '
        Pub_NameLabel.AutoSize = True
        Pub_NameLabel.BackColor = System.Drawing.Color.Transparent
        Pub_NameLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Pub_NameLabel.Location = New System.Drawing.Point(242, 428)
        Pub_NameLabel.Name = "Pub_NameLabel"
        Pub_NameLabel.Size = New System.Drawing.Size(141, 25)
        Pub_NameLabel.TabIndex = 76
        Pub_NameLabel.Text = "Publisher Name:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.BackColor = System.Drawing.Color.Transparent
        CountryLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.Location = New System.Drawing.Point(242, 484)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(79, 25)
        CountryLabel.TabIndex = 78
        CountryLabel.Text = "Country:"
        '
        'Num_of_JournalsLabel
        '
        Num_of_JournalsLabel.AutoSize = True
        Num_of_JournalsLabel.BackColor = System.Drawing.Color.Transparent
        Num_of_JournalsLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Num_of_JournalsLabel.Location = New System.Drawing.Point(242, 542)
        Num_of_JournalsLabel.Name = "Num_of_JournalsLabel"
        Num_of_JournalsLabel.Size = New System.Drawing.Size(169, 25)
        Num_of_JournalsLabel.TabIndex = 80
        Num_of_JournalsLabel.Text = "Number of Journals:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(577, 281)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(243, 36)
        Me.TextBox5.TabIndex = 74
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(77, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(359, 184)
        Me.DataGridView1.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 34)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "JOURNAL INFORMATON DATABASE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalJournal.My.Resources.Resources.PIC1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(911, 138)
        Me.PictureBox1.TabIndex = 72
        Me.PictureBox1.TabStop = False
        '
        'Pub_NameTextBox
        '
        Me.Pub_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pub_NameTextBox.Location = New System.Drawing.Point(470, 425)
        Me.Pub_NameTextBox.Name = "Pub_NameTextBox"
        Me.Pub_NameTextBox.Size = New System.Drawing.Size(222, 32)
        Me.Pub_NameTextBox.TabIndex = 77
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryTextBox.Location = New System.Drawing.Point(470, 477)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(222, 32)
        Me.CountryTextBox.TabIndex = 79
        '
        'Num_of_JournalsTextBox
        '
        Me.Num_of_JournalsTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Num_of_JournalsTextBox.Location = New System.Drawing.Point(470, 535)
        Me.Num_of_JournalsTextBox.Name = "Num_of_JournalsTextBox"
        Me.Num_of_JournalsTextBox.Size = New System.Drawing.Size(222, 32)
        Me.Num_of_JournalsTextBox.TabIndex = 81
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Font = New System.Drawing.Font("Bernard MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(795, 591)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 49)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'publishersearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalJournal.My.Resources.Resources.Plain_Wallpapers_HD_A252
        Me.ClientSize = New System.Drawing.Size(933, 652)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Pub_NameLabel)
        Me.Controls.Add(Me.Pub_NameTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(Num_of_JournalsLabel)
        Me.Controls.Add(Me.Num_of_JournalsTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "publishersearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "publishersearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Pub_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Num_of_JournalsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
