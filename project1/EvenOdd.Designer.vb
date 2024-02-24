<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EvenOdd
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnclick = New System.Windows.Forms.Button()
        Me.lblans = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Number :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(275, 67)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(239, 30)
        Me.TextBox1.TabIndex = 1
        '
        'btnclick
        '
        Me.btnclick.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclick.Location = New System.Drawing.Point(181, 160)
        Me.btnclick.Name = "btnclick"
        Me.btnclick.Size = New System.Drawing.Size(150, 51)
        Me.btnclick.TabIndex = 2
        Me.btnclick.Text = "Click"
        Me.btnclick.UseVisualStyleBackColor = True
        '
        'lblans
        '
        Me.lblans.AutoSize = True
        Me.lblans.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblans.Location = New System.Drawing.Point(59, 311)
        Me.lblans.Name = "lblans"
        Me.lblans.Size = New System.Drawing.Size(69, 31)
        Me.lblans.TabIndex = 3
        Me.lblans.Text = "Ans:"
        '
        'EvenOdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 450)
        Me.Controls.Add(Me.lblans)
        Me.Controls.Add(Me.btnclick)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EvenOdd"
        Me.Text = "EvenOdd"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnclick As Button
    Friend WithEvents lblans As Label
End Class
