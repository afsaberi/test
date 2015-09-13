Public Class Mainform

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clock As Date
        Dim ww As Timer
        clock = Now
        Time.Text = clock

        ww.Enabled = True
        MsgBox(ww)

    End Sub

    Private Sub Clock_Click(sender As Object, e As EventArgs) Handles Clock.Click

    End Sub

    Public Sub Time_Click(sender As Object, e As EventArgs) Handles Time.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("hi")
    End Sub
End Class
