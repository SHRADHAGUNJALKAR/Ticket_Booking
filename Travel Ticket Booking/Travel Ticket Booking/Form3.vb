Imports System.Data.OleDb
Public Class Form3


    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        regid()
        bregid()
        'TextBox1.Enabled = False
        ' TextBox8.Enabled = False



    End Sub
    Public Sub regid()
        cn.Open()
        Dim rs As String
        rs = "select max(D_id) from Bus_Driver "
        Dim cmd As New OleDbCommand(rs, cn)
        Dim rd As OleDbDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            If rd.IsDBNull(0) Then
                TextBox8.Text = "101"
            Else
                TextBox8.Text = rd(0) + 1
                TextBox9.Text = " "
                TextBox10.Text = " "
                TextBox11.Text = " "



            End If
        End If
        cn.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Open()
        Dim rs As String
        rs = " insert into Bus values ( " & TextBox1.Text & ",'" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "') "
        Dim cmd As New OleDbCommand(rs, cn)
        cmd.ExecuteNonQuery()
        MsgBox("Bus Details Inserted")
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "


        cn.Close()
        bregid()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub bregid()
        cn.Open()
        Dim rs As String
        rs = "select max(Reg_id) from Bus "
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


            End If
        End If
        cn.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
     
        cn.Open()
        Dim rs As String
        rs = " insert into Bus_Driver values ( " & TextBox8.Text & ",'" & TextBox9.Text & "'," & TextBox10.Text & ",'" & TextBox11.Text & "','" & ComboBox1.Text & "') "


        Dim cmd As New OleDbCommand(rs, cn)



        cmd.ExecuteNonQuery()
        MsgBox("Bus Details Inserted")
        TextBox9.Text = " "
        TextBox10.Text = " "
        TextBox11.Text = " "
        ComboBox1.Text = " "



        cn.Close()
        regid()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        cn.Open()
        Dim rs As String
        rs = "select * from Bus where Reg_id = " & TextBox1.Text & ""
        Dim cmd As New OleDbCommand(rs, cn)
        Dim rd As OleDbDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            TextBox1.Text = rd(0)
            TextBox2.Text = rd(1)
            TextBox3.Text = rd(2)
            TextBox4.Text = rd(3)
            TextBox5.Text = rd(4)
            TextBox6.Text = rd(5)
            TextBox7.Text = rd(6)
        End If
        cn.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cn.Open()
        Dim rs As String
        rs = " delete from Bus where Reg_id=" & TextBox1.Text & ""

        Dim cmd As New OleDbCommand(rs, cn)
        cmd.ExecuteNonQuery()
        MsgBox("Record Dleted")
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "

        cn.Close()
        bregid()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cn.Open()
        Dim rs As String
        rs = " delete from Bus_Driver where D_id=" & TextBox8.Text & ""

        Dim cmd As New OleDbCommand(rs, cn)
        cmd.ExecuteNonQuery()
        MsgBox("Record Dleted")
        TextBox9.Text = " "
        TextBox10.Text = " "
        TextBox11.Text = " "
        ComboBox1.Text = " "
       

        cn.Close()
        regid()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cn.Open()
        Dim rs As String
        rs = "select * from Bus_Driver where D_id = " & TextBox8.Text & ""
        Dim cmd As New OleDbCommand(rs, cn)
        Dim rd As OleDbDataReader
        rd = cmd.ExecuteReader
        If rd.Read Then
            TextBox9.Text = rd(1)
            TextBox10.Text = rd(2)
            TextBox11.Text = rd(3)
            ComboBox1.Text = rd(4)
           
        End If
        cn.Close()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub
End Class