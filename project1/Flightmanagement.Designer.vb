<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Flightmanagement
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtfid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcap = New System.Windows.Forms.TextBox()
        Me.txts = New System.Windows.Forms.TextBox()
        Me.txtd = New System.Windows.Forms.TextBox()
        Me.comtype = New System.Windows.Forms.ComboBox()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnshow = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnstod = New System.Windows.Forms.Button()
        Me.lblsreport = New System.Windows.Forms.Label()
        Me.txtsor = New System.Windows.Forms.TextBox()
        Me.lblde = New System.Windows.Forms.Label()
        Me.txtde = New System.Windows.Forms.TextBox()
        Me.btnreport = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Flight Id :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 31)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Capacity :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(42, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Source :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 370)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 31)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Destination :"
        '
        'txtfid
        '
        Me.txtfid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfid.Location = New System.Drawing.Point(214, 55)
        Me.txtfid.Name = "txtfid"
        Me.txtfid.Size = New System.Drawing.Size(247, 30)
        Me.txtfid.TabIndex = 6
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(214, 117)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(247, 30)
        Me.txtname.TabIndex = 7
        '
        'txtcap
        '
        Me.txtcap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcap.Location = New System.Drawing.Point(214, 243)
        Me.txtcap.Name = "txtcap"
        Me.txtcap.Size = New System.Drawing.Size(247, 30)
        Me.txtcap.TabIndex = 8
        '
        'txts
        '
        Me.txts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txts.Location = New System.Drawing.Point(214, 310)
        Me.txts.Name = "txts"
        Me.txts.Size = New System.Drawing.Size(247, 30)
        Me.txts.TabIndex = 9
        '
        'txtd
        '
        Me.txtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtd.Location = New System.Drawing.Point(214, 370)
        Me.txtd.Name = "txtd"
        Me.txtd.Size = New System.Drawing.Size(247, 30)
        Me.txtd.TabIndex = 10
        '
        'comtype
        '
        Me.comtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comtype.FormattingEnabled = True
        Me.comtype.Items.AddRange(New Object() {"Business", "ECO"})
        Me.comtype.Location = New System.Drawing.Point(214, 175)
        Me.comtype.Name = "comtype"
        Me.comtype.Size = New System.Drawing.Size(247, 33)
        Me.comtype.TabIndex = 11
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(23, 465)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(109, 38)
        Me.btninsert.TabIndex = 12
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(165, 465)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(109, 38)
        Me.btnupdate.TabIndex = 13
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(299, 465)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(109, 38)
        Me.btndelete.TabIndex = 14
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnshow
        '
        Me.btnshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.Location = New System.Drawing.Point(428, 465)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.Size = New System.Drawing.Size(109, 38)
        Me.btnshow.TabIndex = 15
        Me.btnshow.Text = "Show"
        Me.btnshow.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(555, 243)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(845, 338)
        Me.DataGridView1.TabIndex = 16
        '
        'btnstod
        '
        Me.btnstod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstod.Location = New System.Drawing.Point(483, 97)
        Me.btnstod.Name = "btnstod"
        Me.btnstod.Size = New System.Drawing.Size(142, 140)
        Me.btnstod.TabIndex = 17
        Me.btnstod.Text = "Surat To delhi"
        Me.btnstod.UseVisualStyleBackColor = True
        '
        'lblsreport
        '
        Me.lblsreport.AutoSize = True
        Me.lblsreport.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsreport.Location = New System.Drawing.Point(528, 23)
        Me.lblsreport.Name = "lblsreport"
        Me.lblsreport.Size = New System.Drawing.Size(115, 31)
        Me.lblsreport.TabIndex = 18
        Me.lblsreport.Text = "Source :"
        '
        'txtsor
        '
        Me.txtsor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsor.Location = New System.Drawing.Point(649, 23)
        Me.txtsor.Name = "txtsor"
        Me.txtsor.Size = New System.Drawing.Size(172, 30)
        Me.txtsor.TabIndex = 19
        '
        'lblde
        '
        Me.lblde.AutoSize = True
        Me.lblde.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblde.Location = New System.Drawing.Point(856, 23)
        Me.lblde.Name = "lblde"
        Me.lblde.Size = New System.Drawing.Size(166, 31)
        Me.lblde.TabIndex = 20
        Me.lblde.Text = "Destination :"
        '
        'txtde
        '
        Me.txtde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtde.Location = New System.Drawing.Point(1028, 23)
        Me.txtde.Name = "txtde"
        Me.txtde.Size = New System.Drawing.Size(172, 30)
        Me.txtde.TabIndex = 21
        '
        'btnreport
        '
        Me.btnreport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.Location = New System.Drawing.Point(833, 97)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(220, 84)
        Me.btnreport.TabIndex = 22
        Me.btnreport.Text = "Report"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'Flightmanagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 636)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.txtde)
        Me.Controls.Add(Me.lblde)
        Me.Controls.Add(Me.txtsor)
        Me.Controls.Add(Me.lblsreport)
        Me.Controls.Add(Me.btnstod)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.comtype)
        Me.Controls.Add(Me.txtd)
        Me.Controls.Add(Me.txts)
        Me.Controls.Add(Me.txtcap)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtfid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Flightmanagement"
        Me.Text = "Flightmanagement"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtfid As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtcap As TextBox
    Friend WithEvents txts As TextBox
    Friend WithEvents txtd As TextBox
    Friend WithEvents comtype As ComboBox
    Friend WithEvents btninsert As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnshow As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnstod As Button
    Friend WithEvents lblsreport As Label
    Friend WithEvents txtsor As TextBox
    Friend WithEvents lblde As Label
    Friend WithEvents txtde As TextBox
    Friend WithEvents btnreport As Button
End Class
