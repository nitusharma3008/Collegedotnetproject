<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentInformation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtm1 = New System.Windows.Forms.TextBox()
        Me.txtm2 = New System.Windows.Forms.TextBox()
        Me.txtm3 = New System.Windows.Forms.TextBox()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Roll No :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name  :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Marks1 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 31)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Marks2 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 31)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Marks3 :"
        '
        'txtno
        '
        Me.txtno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.Location = New System.Drawing.Point(192, 64)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(184, 30)
        Me.txtno.TabIndex = 1
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(192, 116)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(184, 30)
        Me.txtname.TabIndex = 1
        '
        'txtm1
        '
        Me.txtm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtm1.Location = New System.Drawing.Point(192, 179)
        Me.txtm1.Name = "txtm1"
        Me.txtm1.Size = New System.Drawing.Size(184, 30)
        Me.txtm1.TabIndex = 1
        '
        'txtm2
        '
        Me.txtm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtm2.Location = New System.Drawing.Point(192, 243)
        Me.txtm2.Name = "txtm2"
        Me.txtm2.Size = New System.Drawing.Size(184, 30)
        Me.txtm2.TabIndex = 1
        '
        'txtm3
        '
        Me.txtm3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtm3.Location = New System.Drawing.Point(192, 302)
        Me.txtm3.Name = "txtm3"
        Me.txtm3.Size = New System.Drawing.Size(184, 30)
        Me.txtm3.TabIndex = 1
        '
        'btnreport
        '
        Me.btnreport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.Location = New System.Drawing.Point(405, 211)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(129, 69)
        Me.btnreport.TabIndex = 3
        Me.btnreport.Text = "Marks >75"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(405, 128)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(98, 40)
        Me.btninsert.TabIndex = 4
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(548, 128)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(98, 40)
        Me.btnupdate.TabIndex = 5
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(679, 128)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(98, 40)
        Me.btndelete.TabIndex = 6
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(566, 225)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(98, 40)
        Me.btnshow.TabIndex = 7
        Me.btnshow.Text = "Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 362)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(722, 327)
        Me.DataGridView1.TabIndex = 8
        '
        'StudentInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 695)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.txtm3)
        Me.Controls.Add(Me.txtm2)
        Me.Controls.Add(Me.txtm1)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StudentInformation"
        Me.Text = "StudentInformation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtno As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtm1 As TextBox
    Friend WithEvents txtm2 As TextBox
    Friend WithEvents txtm3 As TextBox
    Friend WithEvents btnreport As Button
    Friend WithEvents btninsert As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnshow As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
