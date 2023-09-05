Imports System.Data.OleDb
Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        id()
    End Sub
    Public Sub id()
        cn.Open()
        Dim rs As String
        rs = "select max(B_ID) from ticket "
        Dim cmd As New OleDbCommand(rs, cn)
        Dim rd As OleDbDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            If rd.IsDBNull(0) Then
                TextBox1.Text = "101"
            Else
                TextBox1.Text = rd(0) + 1
                TextBox2.Text = " "
                TextBox3.Text = " "
                TextBox4.Text = " "
                TextBox5.Text = " "
                TextBox6.Text = " "
                TextBox7.Text = " "
                ComboBox1.Text = " "
                ComboBox2.Text = " "
                ComboBox3.Text = " "
                ComboBox4.Text = " "

            End If
        End If
        cn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Open()
        Dim rs As String
        rs = " insert into Ticket values( " & TextBox1.Text & ",'" & TextBox2.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox4.Text & "')"


        Dim cmd As New OleDbCommand(rs, cn)



        cmd.ExecuteNonQuery()
        MsgBox("Now You Can Generate Ticket")


        ComboBox1.Text = " "
        ComboBox2.Text = " "
        ComboBox3.Text = " "
        ComboBox4.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
        cn.Close()
        crrt()
        id()
    End Sub
    Public Sub crrt()
        Dim crt As New CrystalReport1
        crt.Load("C:\Users\shrad\OneDrive\Documents\Travel Ticket Booking\Travel Ticket Booking\CrystalReport1.rpt")
        Form5.CrystalReportViewer1.ReportSource = crt
        Form5.CrystalReportViewer1.SelectionFormula = "{ Ticket.B_ID } = " & TextBox1.Text & ""


        Form5.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
End Class