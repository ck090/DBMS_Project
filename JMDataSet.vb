Partial Class JMDataSet
    Partial Class AuthorDataTable

        Private Sub AuthorDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging

        End Sub

        Private Sub AuthorDataTable_AuthorRowChanging(ByVal sender As System.Object, ByVal e As AuthorRowChangeEvent) Handles Me.AuthorRowChanging

        End Sub

    End Class

End Class

Namespace JMDataSetTableAdapters
    
    Partial Public Class Journal_ArticlesTableAdapter
    End Class
End Namespace
