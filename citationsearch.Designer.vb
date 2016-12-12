<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class citationsearch
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
        Dim ISSNLabel1 As System.Windows.Forms.Label
        Dim Journal_Impact_FactorLabel As System.Windows.Forms.Label
        Dim Citation_IndexLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ISSNTextBox1 = New System.Windows.Forms.TextBox()
        Me.Journal_Impact_FactorTextBox = New System.Windows.Forms.TextBox()
        Me.Citation_IndexTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Label2 = New System.Windows.Forms.Label()
        ISSNLabel1 = New System.Windows.Forms.Label()
        Journal_Impact_FactorLabel = New System.Windows.Forms.Label()
        Citation_IndexLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
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
        Label2.TabIndex = 70
        Label2.Text = "Search:"
        '
        'ISSNLabel1
        '
        ISSNLabel1.AutoSize = True
        ISSNLabel1.BackColor = System.Drawing.Color.Transparent
        ISSNLabel1.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ISSNLabel1.Location = New System.Drawing.Point(199, 458)
        ISSNLabel1.Name = "ISSNLabel1"
        ISSNLabel1.Size = New System.Drawing.Size(50, 25)
        ISSNLabel1.TabIndex = 71
        ISSNLabel1.Text = "ISSN:"
        '
        'Journal_Impact_FactorLabel
        '
        Journal_Impact_FactorLabel.AutoSize = True
        Journal_Impact_FactorLabel.BackColor = System.Drawing.Color.Transparent
        Journal_Impact_FactorLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Journal_Impact_FactorLabel.Location = New System.Drawing.Point(199, 513)
        Journal_Impact_FactorLabel.Name = "Journal_Impact_FactorLabel"
        Journal_Impact_FactorLabel.Size = New System.Drawing.Size(191, 25)
        Journal_Impact_FactorLabel.TabIndex = 73
        Journal_Impact_FactorLabel.Text = "Journal Impact Factor:"
        '
        'Citation_IndexLabel
        '
        Citation_IndexLabel.AutoSize = True
        Citation_IndexLabel.BackColor = System.Drawing.Color.Transparent
        Citation_IndexLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Citation_IndexLabel.Location = New System.Drawing.Point(199, 573)
        Citation_IndexLabel.Name = "Citation_IndexLabel"
        Citation_IndexLabel.Size = New System.Drawing.Size(128, 25)
        Citation_IndexLabel.TabIndex = 75
        Citation_IndexLabel.Text = "Citation Index:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(199, 400)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(145, 25)
        Label3.TabIndex = 78
        Label3.Text = "Name of Journal:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(577, 281)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(243, 36)
        Me.TextBox5.TabIndex = 69
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(35, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(435, 184)
        Me.DataGridView1.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 34)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "JOURNAL INFORMATON DATABASE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalJournal.My.Resources.Resources.PIC1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(911, 138)
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'ISSNTextBox1
        '
        Me.ISSNTextBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISSNTextBox1.Location = New System.Drawing.Point(453, 455)
        Me.ISSNTextBox1.Name = "ISSNTextBox1"
        Me.ISSNTextBox1.Size = New System.Drawing.Size(265, 32)
        Me.ISSNTextBox1.TabIndex = 72
        '
        'Journal_Impact_FactorTextBox
        '
        Me.Journal_Impact_FactorTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Journal_Impact_FactorTextBox.Location = New System.Drawing.Point(453, 510)
        Me.Journal_Impact_FactorTextBox.Name = "Journal_Impact_FactorTextBox"
        Me.Journal_Impact_FactorTextBox.Size = New System.Drawing.Size(265, 32)
        Me.Journal_Impact_FactorTextBox.TabIndex = 74
        '
        'Citation_IndexTextBox
        '
        Me.Citation_IndexTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Citation_IndexTextBox.Location = New System.Drawing.Point(453, 566)
        Me.Citation_IndexTextBox.Name = "Citation_IndexTextBox"
        Me.Citation_IndexTextBox.Size = New System.Drawing.Size(265, 32)
        Me.Citation_IndexTextBox.TabIndex = 76
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bernard MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(795, 591)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 49)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(453, 397)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(265, 32)
        Me.TextBox1.TabIndex = 79
        '
        'citationsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalJournal.My.Resources.Resources.Plain_Wallpapers_HD_A251
        Me.ClientSize = New System.Drawing.Size(931, 652)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ISSNLabel1)
        Me.Controls.Add(Me.ISSNTextBox1)
        Me.Controls.Add(Journal_Impact_FactorLabel)
        Me.Controls.Add(Me.Journal_Impact_FactorTextBox)
        Me.Controls.Add(Citation_IndexLabel)
        Me.Controls.Add(Me.Citation_IndexTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "citationsearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "citationsearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ISSNTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Journal_Impact_FactorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Citation_IndexTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
