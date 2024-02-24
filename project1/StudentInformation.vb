Imports System.Data.SqlClient
Imports System.Data

Public Class StudentInformation

    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kanch\OneDrive\Desktop\projectcollege\project1\Database1.mdf;Integrated Security=True")
    Sub fillgrid()
        Dim cmd As New SqlCommand("select * from tblstudent", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "student")
        DataGridView1.DataSource = ds.Tables("student")
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
                Dim cmd As New SqlCommand("insert into tblstudent values(@id,@name,@marks1,@marks2,@marks3)", con)
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtno.Text
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text
                cmd.Parameters.Add("@marks1", SqlDbType.Int).Value = txtm1.Text
                cmd.Parameters.Add("@marks2", SqlDbType.Int).Value = txtm2.Text
                cmd.Parameters.Add("@marks3", SqlDbType.Int).Value = txtm3.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Records are inserted")
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
                Dim cmd As New SqlCommand("update tblstudent set name=@name,marks1=@marks1,marks2=@marks2,marks3=@marks3 where id=@id", con)
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtno.Text
                cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtname.Text
                cmd.Parameters.Add("@marks1", SqlDbType.Int).Value = txtm1.Text
                cmd.Parameters.Add("@marks2", SqlDbType.Int).Value = txtm2.Text
                cmd.Parameters.Add("@marks3", SqlDbType.Int).Value = txtm3.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Records are updated")
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
                Dim cmd As New SqlCommand("delete from tblstudent where id=@id", con)
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = txtno.Text
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Records are deleted")
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
        Dim cmd As New SqlCommand("select * from tblstudent", con)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds, "student")
        Dim dt As DataTable = ds.Tables("student")
        Dim filteredRows = dt.Select("((marks1 + marks2 + marks3) / 3) > 75")
        Dim filteredDt As DataTable = dt.Clone()
        For Each row As DataRow In filteredRows
            filteredDt.ImportRow(row)
        Next
        DataGridView1.DataSource = filteredDt
    End Sub
End Class