Imports System.Data.OleDb

Public Class Form6

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form7.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Open()
        Dim rs As String
        rs = "select * from Account where username= '" & TextBox1.Text & "'"
        Dim cmd As New OleDbCommand(rs, cn)
        Dim rd As OleDbDataReader
        rd = cmd.ExecuteReader
        If rd.Read() Then
            If TextBox2.Text = rd(2) Then
                MsgBox("Welcome")
                Form2.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect Password")
                TextBox2.Text = ""
                TextBox2.Focus()

            End If
        Else
            MsgBox("incorrect Username")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Focus()

        End If
        cn.Close()

    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class