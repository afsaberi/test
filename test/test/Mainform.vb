Public Class Mainform

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim clock As Date
        ' Dim ww As Timer
        'Clock = Now
        'Time.Text = clock
        Timer.Enabled = True
        ' ww.Enabled = True
        ' ww.Start()

        ' MsgBox(ww)

    End Sub

    Private Sub Clock_Click(sender As Object, e As EventArgs) Handles Clock.Click

    End Sub

    Public Sub Time_Click(sender As Object, e As EventArgs) Handles Time3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' MsgBox("this is weird")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Time3.Text = Date.Now.ToString("hh:mm:ss")

    End Sub
End Class
