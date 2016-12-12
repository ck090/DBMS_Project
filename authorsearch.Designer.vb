<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class authorsearch
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
        Dim ORCIDLabel As System.Windows.Forms.Label
        Dim F_NameLabel As System.Windows.Forms.Label
        Dim L_NameLabel As System.Windows.Forms.Label
        Dim UniversityLabel As System.Windows.Forms.Label
        Dim Co_AuthorLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ORCIDTextBox = New System.Windows.Forms.TextBox()
        Me.F_NameTextBox = New System.Windows.Forms.TextBox()
        Me.L_NameTextBox = New System.Windows.Forms.TextBox()
        Me.UniversityTextBox = New System.Windows.Forms.TextBox()
        Me.Co_AuthorTextBox = New System.Windows.Forms.TextBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        ORCIDLabel = New System.Windows.Forms.Label()
        F_NameLabel = New System.Windows.Forms.Label()
        L_NameLabel = New System.Windows.Forms.Label()
        UniversityLabel = New System.Windows.Forms.Label()
        Co_AuthorLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
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
        Label2.TabIndex = 60
        Label2.Text = "Search:"
        '
        'ORCIDLabel
        '
        ORCIDLabel.AutoSize = True
        ORCIDLabel.BackColor = System.Drawing.Color.Transparent
        ORCIDLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ORCIDLabel.Location = New System.Drawing.Point(241, 414)
        ORCIDLabel.Name = "ORCIDLabel"
        ORCIDLabel.Size = New System.Drawing.Size(66, 25)
        ORCIDLabel.TabIndex = 61
        ORCIDLabel.Text = "ORCID:"
        '
        'F_NameLabel
        '
        F_NameLabel.AutoSize = True
        F_NameLabel.BackColor = System.Drawing.Color.Transparent
        F_NameLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        F_NameLabel.Location = New System.Drawing.Point(238, 466)
        F_NameLabel.Name = "F_NameLabel"
        F_NameLabel.Size = New System.Drawing.Size(76, 25)
        F_NameLabel.TabIndex = 63
        F_NameLabel.Text = "F Name:"
        '
        'L_NameLabel
        '
        L_NameLabel.AutoSize = True
        L_NameLabel.BackColor = System.Drawing.Color.Transparent
        L_NameLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        L_NameLabel.Location = New System.Drawing.Point(238, 518)
        L_NameLabel.Name = "L_NameLabel"
        L_NameLabel.Size = New System.Drawing.Size(76, 25)
        L_NameLabel.TabIndex = 65
        L_NameLabel.Text = "L Name:"
        '
        'UniversityLabel
        '
        UniversityLabel.AutoSize = True
        UniversityLabel.BackColor = System.Drawing.Color.Transparent
        UniversityLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UniversityLabel.Location = New System.Drawing.Point(237, 569)
        UniversityLabel.Name = "UniversityLabel"
        UniversityLabel.Size = New System.Drawing.Size(94, 25)
        UniversityLabel.TabIndex = 67
        UniversityLabel.Text = "University:"
        '
        'Co_AuthorLabel
        '
        Co_AuthorLabel.AutoSize = True
        Co_AuthorLabel.BackColor = System.Drawing.Color.Transparent
        Co_AuthorLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Co_AuthorLabel.Location = New System.Drawing.Point(237, 621)
        Co_AuthorLabel.Name = "Co_AuthorLabel"
        Co_AuthorLabel.Size = New System.Drawing.Size(96, 25)
        Co_AuthorLabel.TabIndex = 69
        Co_AuthorLabel.Text = "Co-Author:"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.BackColor = System.Drawing.Color.Transparent
        E_mailLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        E_mailLabel.Location = New System.Drawing.Point(238, 678)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(68, 25)
        E_mailLabel.TabIndex = 71
        E_mailLabel.Text = "E-mail:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(577, 281)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(243, 36)
        Me.TextBox5.TabIndex = 59
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 195)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 184)
        Me.DataGridView1.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 34)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "JOURNAL INFORMATON DATABASE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalJournal.My.Resources.Resources.PIC1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(911, 138)
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'ORCIDTextBox
        '
        Me.ORCIDTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ORCIDTextBox.Location = New System.Drawing.Point(427, 411)
        Me.ORCIDTextBox.Name = "ORCIDTextBox"
        Me.ORCIDTextBox.Size = New System.Drawing.Size(262, 32)
        Me.ORCIDTextBox.TabIndex = 62
        '
        'F_NameTextBox
        '
        Me.F_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F_NameTextBox.Location = New System.Drawing.Point(427, 463)
        Me.F_NameTextBox.Name = "F_NameTextBox"
        Me.F_NameTextBox.Size = New System.Drawing.Size(262, 32)
        Me.F_NameTextBox.TabIndex = 64
        '
        'L_NameTextBox
        '
        Me.L_NameTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_NameTextBox.Location = New System.Drawing.Point(427, 515)
        Me.L_NameTextBox.Name = "L_NameTextBox"
        Me.L_NameTextBox.Size = New System.Drawing.Size(262, 32)
        Me.L_NameTextBox.TabIndex = 66
        '
        'UniversityTextBox
        '
        Me.UniversityTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UniversityTextBox.Location = New System.Drawing.Point(427, 566)
        Me.UniversityTextBox.Name = "UniversityTextBox"
        Me.UniversityTextBox.Size = New System.Drawing.Size(262, 32)
        Me.UniversityTextBox.TabIndex = 68
        '
        'Co_AuthorTextBox
        '
        Me.Co_AuthorTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Co_AuthorTextBox.Location = New System.Drawing.Point(427, 618)
        Me.Co_AuthorTextBox.Name = "Co_AuthorTextBox"
        Me.Co_AuthorTextBox.Size = New System.Drawing.Size(262, 32)
        Me.Co_AuthorTextBox.TabIndex = 70
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.E_mailTextBox.Location = New System.Drawing.Point(427, 673)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(262, 32)
        Me.E_mailTextBox.TabIndex = 72
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bernard MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(795, 678)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 49)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'authorsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalJournal.My.Resources.Resources.Plain_Wallpapers_HD_A252
        Me.ClientSize = New System.Drawing.Size(931, 737)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ORCIDLabel)
        Me.Controls.Add(Me.ORCIDTextBox)
        Me.Controls.Add(F_NameLabel)
        Me.Controls.Add(Me.F_NameTextBox)
        Me.Controls.Add(L_NameLabel)
        Me.Controls.Add(Me.L_NameTextBox)
        Me.Controls.Add(UniversityLabel)
        Me.Controls.Add(Me.UniversityTextBox)
        Me.Controls.Add(Co_AuthorLabel)
        Me.Controls.Add(Me.Co_AuthorTextBox)
        Me.Controls.Add(E_mailLabel)
        Me.Controls.Add(Me.E_mailTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "authorsearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "authorsearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ORCIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents F_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents L_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UniversityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Co_AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents E_mailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
