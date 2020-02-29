Public Class Form1
    Public xz As New Timer With {.Interval = 1, .Enabled = False}, xy As New Timer With {.Interval = 1, .Enabled = False}, xx As New Timer With {.Interval = 1, .Enabled = False}
    Dim num = 0, num1 = 0, num2 = 0
    Public speed = 10
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler xz.Tick, AddressOf startosc
        AddHandler xy.Tick, AddressOf startosc1
        AddHandler xx.Tick, AddressOf startosc2
        xx.Start()
        xz.Start()
        xy.Start()
    End Sub

    Private Sub startosc()
        num += 1
        movt_obj.Location = New Point((movt_obj.Parent.Width / 2) - (movt_obj.Width / 2) + ((movt_obj.Parent.Width / 3) * Math.Sin(num / speed)), movt_obj.Location.Y)
    End Sub

    Private Sub startosc1()
        num1 += 1
        movt_obj2.Location = New Point((movt_obj2.Parent.Width / 2) - (movt_obj2.Width / 2) + ((movt_obj2.Parent.Width / 3) * Math.Sin(num1 / speed)), (movt_obj2.Parent.Height / 2) - (movt_obj2.Height / 2) + ((movt_obj2.Parent.Height / 3) * Math.Cos(num1 / speed)))
    End Sub

    Private Sub startosc2()
        num2 += 1
        movt_obj3.Location = New Point((movt_obj3.Parent.Width / 2) - (movt_obj3.Width / 2) + ((movt_obj3.Parent.Width / 3) * Math.Sin(num2 / speed)), ((movt_obj3.Parent.Height / 2) - (movt_obj3.Height / 2) + ((movt_obj3.Parent.Height / 3) * Math.Sin(num2 / speed))))
    End Sub

    Private Sub speed_bar_ValueChanged(sender As Object, e As EventArgs) Handles speed_bar.ValueChanged
        speed = 20 - speed_bar.Value
    End Sub

    Private Sub Speed_bar_Scroll(sender As Object, e As EventArgs) Handles speed_bar.Scroll

    End Sub
End Class
