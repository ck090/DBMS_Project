Public Class Main_Page

    Dim tex1t As String

    Private Sub AuthorBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.AuthorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JMDataSet)

    End Sub

    Private Sub Main_Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tex1t = ComboBox1.Text

        If StrComp(tex1t, "Journal Name") = 0 Then
            journalsearch.Show()
            Me.Close()
        End If
        If StrComp(tex1t, "Citation Report") = 0 Then
            citationsearch.Show()
            Me.Close()
        End If
        If StrComp(tex1t, "Name of Author") = 0 Then
            authorsearch.Show()
            Me.Close()
        End If
        If StrComp(tex1t, "Publisher") = 0 Then
            publishersearch.Show()
            Me.Close()
        End If
        If StrComp(tex1t, "Title of Journal Article") = 0 Then
            jarticlesearch.Show()
            Me.Close()
        End If
    End Sub
End Class