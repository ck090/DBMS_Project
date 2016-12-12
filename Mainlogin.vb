Public Class Mainlogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim logi As New Login
        logi.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim syslogi As New EnterPass
        syslogi.Show()
        Me.Hide()
    End Sub

    Private Sub Mainlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\N Chandra Kanth\Desktop\Report of Journals.txt", True)
        file.WriteLine("-------------JOURNAL INFORMATION DATABASE REPORT GENERATION-------------")
        file.WriteLine(" ")
        file.Close()
        Dim file2 As System.IO.StreamWriter
        file2 = My.Computer.FileSystem.OpenTextFileWriter("C:\Users\N Chandra Kanth\Desktop\Report of Journals Users.txt", True)
        file2.WriteLine("-------------JOURNAL INFORMATION DATABASE REPORT GENERATION-------------")
        file2.WriteLine(" ")
        file2.Close()
    End Sub
End Class