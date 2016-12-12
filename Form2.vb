Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Journal12DataSet.Tab' table. You can move, or remove it, as needed.
        'Me.TabTableAdapter.Fill(Me.Journal12DataSet.Tab)
        Me.TabTableAdapter.Fill(Me.Journal12DataSet.Tab)

    End Sub

    Private Sub TabBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TabBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Journal12DataSet)

    End Sub

    Private Sub PagesLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Search = TabTableAdapter.Searchid(TextBox1.Text)
        If Search Is Nothing Then
            MessageBox.Show("Invalid Search")
        Else

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim yesno As Integer = MessageBox.Show("Are you sure you want to Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If yesno = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TabBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.TabBindingSource.EndEdit()
        Me.TabTableAdapter.Update(Journal12DataSet.Tab)
        MsgBox("Journal Updated.!")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TabBindingSource.RemoveCurrent()
    End Sub
End Class