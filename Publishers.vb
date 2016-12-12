Public Class Publishers

    Private Sub PublisherBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PublisherBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JMDataSet)

    End Sub

    Private Sub Publishers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'JMDataSet.Sponsorers' table. You can move, or remove it, as needed.
        Me.SponsorersTableAdapter.Fill(Me.JMDataSet.Sponsorers)
        'TODO: This line of code loads data into the 'JMDataSet.Sponsorer_Locations' table. You can move, or remove it, as needed.
        Me.Sponsorer_LocationsTableAdapter.Fill(Me.JMDataSet.Sponsorer_Locations)
        'TODO: This line of code loads data into the 'JMDataSet.Sponsored' table. You can move, or remove it, as needed.
        Me.SponsoredTableAdapter.Fill(Me.JMDataSet.Sponsored)
        'TODO: This line of code loads data into the 'JMDataSet.Publisher_Domains' table. You can move, or remove it, as needed.
        Me.Publisher_DomainsTableAdapter.Fill(Me.JMDataSet.Publisher_Domains)
        'TODO: This line of code loads data into the 'JMDataSet.Publisher' table. You can move, or remove it, as needed.
        Me.PublisherTableAdapter.Fill(Me.JMDataSet.Publisher)

    End Sub

    Private Sub Pub_NameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.SponsoredBindingSource.MoveNext()
        Me.Publisher_DomainsBindingSource.MoveNext()
        Me.PublisherBindingSource.MoveNext()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.SponsoredBindingSource.MovePrevious()
        Me.Publisher_DomainsBindingSource.MovePrevious()
        Me.PublisherBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Main_Page.Show()
        Me.Close()
    End Sub
End Class