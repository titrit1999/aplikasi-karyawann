<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_jabatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_jabatan))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxNAMAJABATAN = New System.Windows.Forms.TextBox
        Me.TextBoxGAJIPOKOK = New System.Windows.Forms.TextBox
        Me.BtnSIMPAN = New System.Windows.Forms.Button
        Me.BtnHAPUS = New System.Windows.Forms.Button
        Me.BtnPERBAIKI = New System.Windows.Forms.Button
        Me.BtnKELUAR = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.TextBoxID = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAMA_JABATAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GAJI_POKOK"
        '
        'TextBoxNAMAJABATAN
        '
        Me.TextBoxNAMAJABATAN.Location = New System.Drawing.Point(206, 50)
        Me.TextBoxNAMAJABATAN.Name = "TextBoxNAMAJABATAN"
        Me.TextBoxNAMAJABATAN.Size = New System.Drawing.Size(294, 20)
        Me.TextBoxNAMAJABATAN.TabIndex = 2
        '
        'TextBoxGAJIPOKOK
        '
        Me.TextBoxGAJIPOKOK.Location = New System.Drawing.Point(206, 91)
        Me.TextBoxGAJIPOKOK.Name = "TextBoxGAJIPOKOK"
        Me.TextBoxGAJIPOKOK.Size = New System.Drawing.Size(176, 20)
        Me.TextBoxGAJIPOKOK.TabIndex = 3
        '
        'BtnSIMPAN
        '
        Me.BtnSIMPAN.BackColor = System.Drawing.Color.Maroon
        Me.BtnSIMPAN.Image = CType(resources.GetObject("BtnSIMPAN.Image"), System.Drawing.Image)
        Me.BtnSIMPAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSIMPAN.Location = New System.Drawing.Point(65, 143)
        Me.BtnSIMPAN.Name = "BtnSIMPAN"
        Me.BtnSIMPAN.Size = New System.Drawing.Size(122, 38)
        Me.BtnSIMPAN.TabIndex = 5
        Me.BtnSIMPAN.Text = "SIMPAN"
        Me.BtnSIMPAN.UseVisualStyleBackColor = False
        '
        'BtnHAPUS
        '
        Me.BtnHAPUS.BackColor = System.Drawing.Color.Maroon
        Me.BtnHAPUS.Image = CType(resources.GetObject("BtnHAPUS.Image"), System.Drawing.Image)
        Me.BtnHAPUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHAPUS.Location = New System.Drawing.Point(228, 143)
        Me.BtnHAPUS.Name = "BtnHAPUS"
        Me.BtnHAPUS.Size = New System.Drawing.Size(127, 38)
        Me.BtnHAPUS.TabIndex = 6
        Me.BtnHAPUS.Text = "HAPUS"
        Me.BtnHAPUS.UseVisualStyleBackColor = False
        '
        'BtnPERBAIKI
        '
        Me.BtnPERBAIKI.BackColor = System.Drawing.Color.Maroon
        Me.BtnPERBAIKI.Image = CType(resources.GetObject("BtnPERBAIKI.Image"), System.Drawing.Image)
        Me.BtnPERBAIKI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPERBAIKI.Location = New System.Drawing.Point(403, 143)
        Me.BtnPERBAIKI.Name = "BtnPERBAIKI"
        Me.BtnPERBAIKI.Size = New System.Drawing.Size(120, 38)
        Me.BtnPERBAIKI.TabIndex = 7
        Me.BtnPERBAIKI.Text = "PERBAIKI"
        Me.BtnPERBAIKI.UseVisualStyleBackColor = False
        '
        'BtnKELUAR
        '
        Me.BtnKELUAR.BackColor = System.Drawing.Color.Maroon
        Me.BtnKELUAR.Image = CType(resources.GetObject("BtnKELUAR.Image"), System.Drawing.Image)
        Me.BtnKELUAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKELUAR.Location = New System.Drawing.Point(573, 143)
        Me.BtnKELUAR.Name = "BtnKELUAR"
        Me.BtnKELUAR.Size = New System.Drawing.Size(118, 38)
        Me.BtnKELUAR.TabIndex = 8
        Me.BtnKELUAR.Text = "KELUAR"
        Me.BtnKELUAR.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 198)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.Size = New System.Drawing.Size(772, 307)
        Me.DataGridView1.TabIndex = 9
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(12, 12)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(10, 20)
        Me.TextBoxID.TabIndex = 10
        Me.TextBoxID.Visible = False
        '
        'frm_jabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(796, 517)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnKELUAR)
        Me.Controls.Add(Me.BtnPERBAIKI)
        Me.Controls.Add(Me.BtnHAPUS)
        Me.Controls.Add(Me.BtnSIMPAN)
        Me.Controls.Add(Me.TextBoxGAJIPOKOK)
        Me.Controls.Add(Me.TextBoxNAMAJABATAN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "frm_jabatan"
        Me.Text = "DATA_JABATAN"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNAMAJABATAN As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGAJIPOKOK As System.Windows.Forms.TextBox
    Friend WithEvents BtnSIMPAN As System.Windows.Forms.Button
    Friend WithEvents BtnHAPUS As System.Windows.Forms.Button
    Friend WithEvents BtnPERBAIKI As System.Windows.Forms.Button
    Friend WithEvents BtnKELUAR As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
End Class
