<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jarticlesearch
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
        Dim TitleLabel As System.Windows.Forms.Label
        Dim DOILabel As System.Windows.Forms.Label
        Dim CitationsLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.DOITextBox = New System.Windows.Forms.TextBox()
        Me.CitationsTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        DOILabel = New System.Windows.Forms.Label()
        CitationsLabel = New System.Windows.Forms.Label()
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
        Label2.TabIndex = 65
        Label2.Text = "Search:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.BackColor = System.Drawing.Color.Transparent
        TitleLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(171, 479)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(53, 25)
        TitleLabel.TabIndex = 66
        TitleLabel.Text = "Title:"
        '
        'DOILabel
        '
        DOILabel.AutoSize = True
        DOILabel.BackColor = System.Drawing.Color.Transparent
        DOILabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOILabel.Location = New System.Drawing.Point(171, 529)
        DOILabel.Name = "DOILabel"
        DOILabel.Size = New System.Drawing.Size(46, 25)
        DOILabel.TabIndex = 68
        DOILabel.Text = "DOI:"
        '
        'CitationsLabel
        '
        CitationsLabel.AutoSize = True
        CitationsLabel.BackColor = System.Drawing.Color.Transparent
        CitationsLabel.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CitationsLabel.Location = New System.Drawing.Point(171, 580)
        CitationsLabel.Name = "CitationsLabel"
        CitationsLabel.Size = New System.Drawing.Size(86, 25)
        CitationsLabel.TabIndex = 70
        CitationsLabel.Text = "Citations:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(171, 421)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(145, 25)
        Label3.TabIndex = 72
        Label3.Text = "Name of Journal:"
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(577, 281)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(243, 36)
        Me.TextBox5.TabIndex = 64
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(430, 184)
        Me.DataGridView1.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 34)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "JOURNAL INFORMATON DATABASE"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FinalJournal.My.Resources.Resources.PIC1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(911, 138)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(393, 471)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(341, 32)
        Me.TitleTextBox.TabIndex = 67
        '
        'DOITextBox
        '
        Me.DOITextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOITextBox.Location = New System.Drawing.Point(393, 521)
        Me.DOITextBox.Name = "DOITextBox"
        Me.DOITextBox.Size = New System.Drawing.Size(341, 32)
        Me.DOITextBox.TabIndex = 69
        '
        'CitationsTextBox
        '
        Me.CitationsTextBox.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CitationsTextBox.Location = New System.Drawing.Point(393, 575)
        Me.CitationsTextBox.Name = "CitationsTextBox"
        Me.CitationsTextBox.Size = New System.Drawing.Size(341, 32)
        Me.CitationsTextBox.TabIndex = 71
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(393, 413)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(341, 32)
        Me.TextBox1.TabIndex = 73
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Bernard MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(795, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 49)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'jarticlesearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalJournal.My.Resources.Resources.Plain_Wallpapers_HD_A25
        Me.ClientSize = New System.Drawing.Size(935, 670)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(DOILabel)
        Me.Controls.Add(Me.DOITextBox)
        Me.Controls.Add(CitationsLabel)
        Me.Controls.Add(Me.CitationsTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "jarticlesearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jarticlesearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOITextBox As System.Windows.Forms.TextBox
    Friend WithEvents CitationsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
