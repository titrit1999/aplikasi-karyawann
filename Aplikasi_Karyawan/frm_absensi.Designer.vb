<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_absensi
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
        Me.components = New System.ComponentModel.Container
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtNik = New System.Windows.Forms.TextBox
        Me.lbltglsekarang = New System.Windows.Forms.Label
        Me.lbljamsekarang = New System.Windows.Forms.Label
        Me.lblnik = New System.Windows.Forms.Label
        Me.lblinfo = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbllembur = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(144, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 354)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtNik
        '
        Me.txtNik.ForeColor = System.Drawing.Color.DarkRed
        Me.txtNik.Location = New System.Drawing.Point(144, 431)
        Me.txtNik.Name = "txtNik"
        Me.txtNik.Size = New System.Drawing.Size(340, 20)
        Me.txtNik.TabIndex = 1
        '
        'lbltglsekarang
        '
        Me.lbltglsekarang.AutoSize = True
        Me.lbltglsekarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltglsekarang.Location = New System.Drawing.Point(590, 97)
        Me.lbltglsekarang.Name = "lbltglsekarang"
        Me.lbltglsekarang.Size = New System.Drawing.Size(72, 24)
        Me.lbltglsekarang.TabIndex = 2
        Me.lbltglsekarang.Text = "Label1"
        '
        'lbljamsekarang
        '
        Me.lbljamsekarang.AutoSize = True
        Me.lbljamsekarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljamsekarang.Location = New System.Drawing.Point(590, 170)
        Me.lbljamsekarang.Name = "lbljamsekarang"
        Me.lbljamsekarang.Size = New System.Drawing.Size(72, 24)
        Me.lbljamsekarang.TabIndex = 3
        Me.lbljamsekarang.Text = "Label2"
        '
        'lblnik
        '
        Me.lblnik.AutoSize = True
        Me.lblnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnik.Location = New System.Drawing.Point(590, 247)
        Me.lblnik.Name = "lblnik"
        Me.lblnik.Size = New System.Drawing.Size(72, 24)
        Me.lblnik.TabIndex = 4
        Me.lblnik.Text = "Label3"
        '
        'lblinfo
        '
        Me.lblinfo.AutoSize = True
        Me.lblinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfo.Location = New System.Drawing.Point(590, 330)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(72, 24)
        Me.lblinfo.TabIndex = 5
        Me.lblinfo.Text = "Label4"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lbllembur
        '
        Me.lbllembur.AutoSize = True
        Me.lbllembur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllembur.Location = New System.Drawing.Point(590, 400)
        Me.lbllembur.Name = "lbllembur"
        Me.lbllembur.Size = New System.Drawing.Size(72, 24)
        Me.lbllembur.TabIndex = 6
        Me.lbllembur.Text = "Label5"
        '
        'frm_absensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(840, 608)
        Me.Controls.Add(Me.lbllembur)
        Me.Controls.Add(Me.lblinfo)
        Me.Controls.Add(Me.lblnik)
        Me.Controls.Add(Me.lbljamsekarang)
        Me.Controls.Add(Me.lbltglsekarang)
        Me.Controls.Add(Me.txtNik)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Name = "frm_absensi"
        Me.Text = "ABSENSI"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNik As System.Windows.Forms.TextBox
    Friend WithEvents lbltglsekarang As System.Windows.Forms.Label
    Friend WithEvents lbljamsekarang As System.Windows.Forms.Label
    Friend WithEvents lblnik As System.Windows.Forms.Label
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbllembur As System.Windows.Forms.Label
End Class
