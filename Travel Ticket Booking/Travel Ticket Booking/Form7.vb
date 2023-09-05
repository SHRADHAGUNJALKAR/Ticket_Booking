Imports System.Data.OleDb
Public Class Form7

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox3.Text = TextBox4.Text Then


            cn.Open()
            Dim rs As String
            rs = "insert into Account values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "') "
            Dim cmd As New OleDbCommand(rs, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Created Acreated Successfully")
            cn.Close()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            Form6.Show()
            Me.Hide()


        Else
            MsgBox("Please Check Confirm Password")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class