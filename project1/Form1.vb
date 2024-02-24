Imports System.Data.SqlClient


Public Class Form1
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kanch\OneDrive\Desktop\projectcollege\project1\Database1.mdf;Integrated Security=True")

    Sub fillgrid()
        Dim cmd As New SqlCommand("select * from demo", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "demotbl")
        DataGridView1.DataSource = ds.Tables("demotbl")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fillgrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As New SqlCommand("insert into demo values (@id,@name)", con)
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = TextBox1.Text
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox2.Text
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("record are inserted.")
        fillgrid()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As New SqlCommand("update demo set name=@name where id=@id", con)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox2.Text
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("record are updated.")
        fillgrid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As New SqlCommand("delete from demo where id=@id", con)
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = TextBox1.Text
        'cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox2.Text
        cmd.ExecuteNonQuery()
        con.Close()
        MsgBox("record are deleted.")
        fillgrid()
    End Sub
End Class
