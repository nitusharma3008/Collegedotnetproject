Imports System.Data.SqlClient
Imports System.Data

Public Class Flightmanagement

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kanch\OneDrive\Desktop\projectcollege\project1\Database1.mdf;Integrated Security=True")
    Sub fillgrid()
        Dim cmd As New SqlCommand("select * from tblflight", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "flights")
        DataGridView1.DataSource = ds.Tables("flights")

    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        fillgrid()
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        If txtfid.Text = "" Then
            MessageBox.Show("Please enter flight id ")
            txtfid.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("insert into tblflight values(@fid,@fname,@ftype,@fcap,@fsource,@fdes)", con)
                cmd.Parameters.Add("@fid", SqlDbType.VarChar).Value = txtfid.Text
                cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = txtname.Text
                cmd.Parameters.Add("@ftype", SqlDbType.VarChar).Value = comtype.Text
                cmd.Parameters.Add("@fcap", SqlDbType.VarChar).Value = txtcap.Text
                cmd.Parameters.Add("@fsource", SqlDbType.VarChar).Value = txts.Text
                cmd.Parameters.Add("@fdes", SqlDbType.VarChar).Value = txtd.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Recored are inserted.")
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
        If txtfid.Text = "" Then
            MessageBox.Show("Please enter flight id ")
            txtfid.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("update tblflight set fname=@fname,ftype=@ftype,fcap=@fcap,fsource=@fsource,fdes=@fdes where fid=@fid", con)
                cmd.Parameters.Add("@fid", SqlDbType.VarChar).Value = txtfid.Text
                cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = txtname.Text
                cmd.Parameters.Add("@ftype", SqlDbType.VarChar).Value = comtype.Text
                cmd.Parameters.Add("@fcap", SqlDbType.VarChar).Value = txtcap.Text
                cmd.Parameters.Add("@fsource", SqlDbType.VarChar).Value = txts.Text
                cmd.Parameters.Add("@fdes", SqlDbType.VarChar).Value = txtd.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Recored are updated.")
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
        If txtfid.Text = "" Then
            MessageBox.Show("Please enter flight id ")
            txtfid.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("delete from tblflight where fid=@fid", con)
                cmd.Parameters.Add("@fid", SqlDbType.VarChar).Value = txtfid.Text
                cmd.Parameters.Add("@fname", SqlDbType.VarChar).Value = txtname.Text
                cmd.Parameters.Add("@ftype", SqlDbType.VarChar).Value = comtype.Text
                cmd.Parameters.Add("@fcap", SqlDbType.VarChar).Value = txtcap.Text
                cmd.Parameters.Add("@fsource", SqlDbType.VarChar).Value = txts.Text
                cmd.Parameters.Add("@fdes", SqlDbType.VarChar).Value = txtd.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Recored are deleted.")
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

    Private Sub btnstod_Click(sender As Object, e As EventArgs) Handles btnstod.Click
        Dim cmd As New SqlCommand("select * from tblflight where fsource='surat' and fdes='delhi'", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "report")
        DataGridView1.DataSource = ds.Tables("report")
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Dim cmd As New SqlCommand("select * from tblflight where fsource=@fsource and fdes=@fdes", con)
        cmd.Parameters.Add("@fsource", SqlDbType.VarChar).Value = txtsor.Text
        cmd.Parameters.Add("@fdes", SqlDbType.VarChar).Value = txtde.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "report")
        DataGridView1.DataSource = ds.Tables("report")
    End Sub
End Class