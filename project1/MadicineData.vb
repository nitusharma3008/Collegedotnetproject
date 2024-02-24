Imports System.Data.SqlClient
Imports System.Data


Public Class MadicineData
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kanch\OneDrive\Desktop\projectcollege\project1\Database1.mdf;Integrated Security=True")

    Sub fillgrid()
        Dim cmd As New SqlCommand("select * from tblMedicine", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "medicine")
        DataGridView1.DataSource = ds.Tables("medicine")
    End Sub

    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        fillgrid()
    End Sub
    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click

        If txtmid.Text = "" Then
            MessageBox.Show("Please enter Medicine Id")
            txtmid.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("insert into tblMedicine values(@mid,@mname,@type,@com,@rate)", con)
                cmd.Parameters.Add("@mid", SqlDbType.Int).Value = txtmid.Text
                cmd.Parameters.Add("@mname", SqlDbType.VarChar).Value = txtmname.Text
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = comb.Text
                cmd.Parameters.Add("@com", SqlDbType.VarChar).Value = txtmcom.Text
                cmd.Parameters.Add("@rate", SqlDbType.Int).Value = txtrate.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Recored are inserted")
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
        If txtmid.Text = "" Then
            MessageBox.Show("Please enter id")
            txtmid.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("update tblMedicine set mname=@mname,type=@type,com=@com,rate=@rate where mid=@mid ", con)
                cmd.Parameters.Add("@mid", SqlDbType.Int).Value = txtmid.Text
                cmd.Parameters.Add("@mname", SqlDbType.VarChar).Value = txtmname.Text
                cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = comb.Text
                cmd.Parameters.Add("@com", SqlDbType.VarChar).Value = txtmcom.Text
                cmd.Parameters.Add("@rate", SqlDbType.Int).Value = txtrate.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Recored are updated")
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
        If txtmid.Text = "" Then
            MessageBox.Show("Please enter id")
            txtmid.Focus()
        Else
            Try
                Dim cmd As New SqlCommand("delete from tblMedicine where mid=@mid ", con)
                cmd.Parameters.Add("@mid", SqlDbType.Int).Value = txtmid.Text
                ' cmd.Parameters.Add("@mname", SqlDbType.VarChar).Value = txtmname.Text
                ' cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = comb.Text
                ' cmd.Parameters.Add("@com", SqlDbType.VarChar).Value = txtmcom.Text
                ' cmd.Parameters.Add("@rate", SqlDbType.Int).Value = txtrate.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Recored are deleted")
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

        Dim cmd As New SqlCommand("select * from tblMedicine where type=@type and rate=@rate", con)
        cmd.Parameters.Add("@type", SqlDbType.VarChar).Value = ComboBox1.Text
        cmd.Parameters.Add("@rate", SqlDbType.Int).Value = TextBox1.Text
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "medicine")
        DataGridView1.DataSource = ds.Tables("medicine")

    End Sub

    Private Sub staticreport_Click(sender As Object, e As EventArgs) Handles staticreport.Click
        Dim cmd As New SqlCommand("select mname from tblMedicine where type='syrup' and rate<500", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "report")
        DataGridView1.DataSource = ds.Tables("report")
    End Sub
End Class