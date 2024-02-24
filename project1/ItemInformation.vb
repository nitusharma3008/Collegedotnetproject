Imports System.Data.SqlClient
Imports System.Data

Public Class ItemInformation

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kanch\OneDrive\Desktop\projectcollege\project1\Database1.mdf;Integrated Security=True")

    Sub fillgrid()
        Dim cmd As New SqlCommand("select * from Itemmast", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "items")
        DataGridView1.DataSource = ds.Tables("items")
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        fillgrid()
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        If txtno.Text = " " Then
            MessageBox.Show("Please enter id")
            txtno.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("insert into Itemmast values(@itemno,@name,@cost,@quantity)", con)
                cmd.Parameters.Add("@itemno", SqlDbType.Int).Value = txtno.Text
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text
                cmd.Parameters.Add("@cost", SqlDbType.Int).Value = txtcost.Text
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = txtqua.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data are inserted")
                fillgrid()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtno.Text = " " Then
            MessageBox.Show("Please enter id")
            txtno.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("update Itemmast set name=@name,cost=@cost,quantity=@quantity where itemno=@itemno", con)
                cmd.Parameters.Add("@itemno", SqlDbType.Int).Value = txtno.Text
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text
                cmd.Parameters.Add("@cost", SqlDbType.Int).Value = txtcost.Text
                cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = txtqua.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data are updated")
                fillgrid()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If txtno.Text = " " Then
            MessageBox.Show("Please enter id")
            txtno.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("delete from Itemmast where itemno=@itemno", con)
                cmd.Parameters.Add("@itemno", SqlDbType.Int).Value = txtno.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Data are deleted")
                fillgrid()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Dim cmd As New SqlCommand("select * from Itemmast where name=@name", con)
        cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "items")
        DataGridView1.DataSource = ds.Tables("items")
    End Sub
End Class