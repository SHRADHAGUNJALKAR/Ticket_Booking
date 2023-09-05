Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Timer1.Start()
        Me.Show()
        Me.Refresh()
        System.Threading.Thread.Sleep(2000)
        AllowTransparency = False

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Form6.Show()
        Me.Hide()
        AllowTransparency = True

    End Sub
End Class
