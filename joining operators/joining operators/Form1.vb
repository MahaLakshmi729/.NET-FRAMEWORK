Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim customer = New List(Of customer)(New customer() {New customer With {.key = 1, .name = "keerthi"},
        New customer With {.key = 2, .name = "maha"},
        New customer With {.key = 3, .name = "anas"},
        New customer With {.key = 4, .name = "liki"},
        New customer With {.key = 5, .name = "resh"},
        New customer With {.key = 6, .name = "piuh"}})
        Dim orders = New List(Of order)(New order() {New order With {.key = 1, .order = "order 1"},
        New order With {.key = 2, .order = "order 2"},
        New order With {.key = 3, .order = "order 3"},
        New order With {.key = 4, .order = "order 4"},
        New order With {.key = 5, .order = "order 5"},
        New order With {.key = 6, .order = "order 6"}})
        Dim query = From c In customer Join o In orders On c.key Equals o.key
                    Select New With {Key c.name, Key o.order}
        For Each q In query
            listbox1.items.add(q.order.ToString() & "--->" & q.name)
        Next q
    End Sub

End Class
Public Class customer
    Public key As Integer
    Public name As String
End Class
Public Class order
    Public key As Integer
    Public order As String
End Class





