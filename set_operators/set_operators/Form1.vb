Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim values() = {1, 2, 2, 3, 4, 5, 5}
        For Each v In values
            ListBox1.Items.Add(v.ToString())
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim values(6) As Integer
        For index = 0 To 6
            values(index) = ListBox1.Items(index)
        Next
        Dim distictvalues = From v In values Distinct
        ListBox2.Items.Clear()
        For Each v In distictvalues
            ListBox2.Items.Add(v.ToString())
        Next
    End Sub
End Class
