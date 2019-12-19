<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_gaji
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_gaji))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.BtnKELUAR = New System.Windows.Forms.Button
        Me.BtnPERBAIKI = New System.Windows.Forms.Button
        Me.BtnHAPUS = New System.Windows.Forms.Button
        Me.BtnSIMPAN = New System.Windows.Forms.Button
        Me.txtNOSLIP = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNIK = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNAMAJABATAN = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtGAJIPOKOK = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTUNJANGAN = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTOTALGAJI = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNAMA_BANK = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtNAMA_REKENING = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtNO_REKENING = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtPOT_LAIN2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPOT_BPJS_KET = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPOT_BPJS_KES = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtUANGLEMBUR = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtIDGAJI = New System.Windows.Forms.TextBox
        Me.DTTANGGALGAJI = New System.Windows.Forms.DateTimePicker
        Me.CMBIDJABATAN = New System.Windows.Forms.ComboBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.GridColor = System.Drawing.Color.Maroon
        Me.DataGridView1.Location = New System.Drawing.Point(12, 336)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.Size = New System.Drawing.Size(772, 291)
        Me.DataGridView1.TabIndex = 18
        '
        'BtnKELUAR
        '
        Me.BtnKELUAR.BackColor = System.Drawing.Color.Maroon
        Me.BtnKELUAR.Image = CType(resources.GetObject("BtnKELUAR.Image"), System.Drawing.Image)
        Me.BtnKELUAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKELUAR.Location = New System.Drawing.Point(937, 458)
        Me.BtnKELUAR.Name = "BtnKELUAR"
        Me.BtnKELUAR.Size = New System.Drawing.Size(118, 79)
        Me.BtnKELUAR.TabIndex = 17
        Me.BtnKELUAR.Text = "KELUAR"
        Me.BtnKELUAR.UseVisualStyleBackColor = False
        '
        'BtnPERBAIKI
        '
        Me.BtnPERBAIKI.BackColor = System.Drawing.Color.Maroon
        Me.BtnPERBAIKI.Image = CType(resources.GetObject("BtnPERBAIKI.Image"), System.Drawing.Image)
        Me.BtnPERBAIKI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPERBAIKI.Location = New System.Drawing.Point(801, 458)
        Me.BtnPERBAIKI.Name = "BtnPERBAIKI"
        Me.BtnPERBAIKI.Size = New System.Drawing.Size(130, 79)
        Me.BtnPERBAIKI.TabIndex = 16
        Me.BtnPERBAIKI.Text = "PERBAIKI"
        Me.BtnPERBAIKI.UseVisualStyleBackColor = False
        '
        'BtnHAPUS
        '
        Me.BtnHAPUS.BackColor = System.Drawing.Color.Maroon
        Me.BtnHAPUS.Image = CType(resources.GetObject("BtnHAPUS.Image"), System.Drawing.Image)
        Me.BtnHAPUS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHAPUS.Location = New System.Drawing.Point(937, 336)
        Me.BtnHAPUS.Name = "BtnHAPUS"
        Me.BtnHAPUS.Size = New System.Drawing.Size(118, 82)
        Me.BtnHAPUS.TabIndex = 15
        Me.BtnHAPUS.Text = "HAPUS"
        Me.BtnHAPUS.UseVisualStyleBackColor = False
        '
        'BtnSIMPAN
        '
        Me.BtnSIMPAN.BackColor = System.Drawing.Color.Maroon
        Me.BtnSIMPAN.Image = CType(resources.GetObject("BtnSIMPAN.Image"), System.Drawing.Image)
        Me.BtnSIMPAN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSIMPAN.Location = New System.Drawing.Point(801, 336)
        Me.BtnSIMPAN.Name = "BtnSIMPAN"
        Me.BtnSIMPAN.Size = New System.Drawing.Size(130, 82)
        Me.BtnSIMPAN.TabIndex = 14
        Me.BtnSIMPAN.Text = "SIMPAN"
        Me.BtnSIMPAN.UseVisualStyleBackColor = False
        '
        'txtNOSLIP
        '
        Me.txtNOSLIP.ForeColor = System.Drawing.Color.Maroon
        Me.txtNOSLIP.Location = New System.Drawing.Point(203, 64)
        Me.txtNOSLIP.Name = "txtNOSLIP"
        Me.txtNOSLIP.Size = New System.Drawing.Size(294, 20)
        Me.txtNOSLIP.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "NO_SLIP"
        '
        'txtNIK
        '
        Me.txtNIK.ForeColor = System.Drawing.Color.Maroon
        Me.txtNIK.Location = New System.Drawing.Point(203, 104)
        Me.txtNIK.Name = "txtNIK"
        Me.txtNIK.Size = New System.Drawing.Size(294, 20)
        Me.txtNIK.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "NIK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "TGL_GAJI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(80, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "ID_JABATAN"
        '
        'txtNAMAJABATAN
        '
        Me.txtNAMAJABATAN.ForeColor = System.Drawing.Color.Maroon
        Me.txtNAMAJABATAN.Location = New System.Drawing.Point(203, 210)
        Me.txtNAMAJABATAN.Name = "txtNAMAJABATAN"
        Me.txtNAMAJABATAN.Size = New System.Drawing.Size(294, 20)
        Me.txtNAMAJABATAN.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "NAMA_JABATAN"
        '
        'txtGAJIPOKOK
        '
        Me.txtGAJIPOKOK.ForeColor = System.Drawing.Color.Maroon
        Me.txtGAJIPOKOK.Location = New System.Drawing.Point(203, 251)
        Me.txtGAJIPOKOK.Name = "txtGAJIPOKOK"
        Me.txtGAJIPOKOK.Size = New System.Drawing.Size(294, 20)
        Me.txtGAJIPOKOK.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "GAJI_POKOK"
        '
        'txtTUNJANGAN
        '
        Me.txtTUNJANGAN.ForeColor = System.Drawing.Color.Maroon
        Me.txtTUNJANGAN.Location = New System.Drawing.Point(203, 293)
        Me.txtTUNJANGAN.Name = "txtTUNJANGAN"
        Me.txtTUNJANGAN.Size = New System.Drawing.Size(294, 20)
        Me.txtTUNJANGAN.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(80, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "TUNJANGAN"
        '
        'txtTOTALGAJI
        '
        Me.txtTOTALGAJI.ForeColor = System.Drawing.Color.Maroon
        Me.txtTOTALGAJI.Location = New System.Drawing.Point(694, 290)
        Me.txtTOTALGAJI.Name = "txtTOTALGAJI"
        Me.txtTOTALGAJI.Size = New System.Drawing.Size(294, 20)
        Me.txtTOTALGAJI.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(571, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "TOTAL_GAJI"
        '
        'txtNAMA_BANK
        '
        Me.txtNAMA_BANK.ForeColor = System.Drawing.Color.Maroon
        Me.txtNAMA_BANK.Location = New System.Drawing.Point(694, 248)
        Me.txtNAMA_BANK.Name = "txtNAMA_BANK"
        Me.txtNAMA_BANK.Size = New System.Drawing.Size(294, 20)
        Me.txtNAMA_BANK.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(571, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "NAMA_BANK"
        '
        'txtNAMA_REKENING
        '
        Me.txtNAMA_REKENING.ForeColor = System.Drawing.Color.Maroon
        Me.txtNAMA_REKENING.Location = New System.Drawing.Point(694, 207)
        Me.txtNAMA_REKENING.Name = "txtNAMA_REKENING"
        Me.txtNAMA_REKENING.Size = New System.Drawing.Size(294, 20)
        Me.txtNAMA_REKENING.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(571, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "NAMA_REKENING"
        '
        'txtNO_REKENING
        '
        Me.txtNO_REKENING.ForeColor = System.Drawing.Color.Maroon
        Me.txtNO_REKENING.Location = New System.Drawing.Point(694, 171)
        Me.txtNO_REKENING.Name = "txtNO_REKENING"
        Me.txtNO_REKENING.Size = New System.Drawing.Size(294, 20)
        Me.txtNO_REKENING.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(571, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "NO_REKENING"
        '
        'txtPOT_LAIN2
        '
        Me.txtPOT_LAIN2.ForeColor = System.Drawing.Color.Maroon
        Me.txtPOT_LAIN2.Location = New System.Drawing.Point(694, 136)
        Me.txtPOT_LAIN2.Name = "txtPOT_LAIN2"
        Me.txtPOT_LAIN2.Size = New System.Drawing.Size(294, 20)
        Me.txtPOT_LAIN2.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(571, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "POT_LAIN2"
        '
        'txtPOT_BPJS_KET
        '
        Me.txtPOT_BPJS_KET.ForeColor = System.Drawing.Color.Maroon
        Me.txtPOT_BPJS_KET.Location = New System.Drawing.Point(694, 101)
        Me.txtPOT_BPJS_KET.Name = "txtPOT_BPJS_KET"
        Me.txtPOT_BPJS_KET.Size = New System.Drawing.Size(294, 20)
        Me.txtPOT_BPJS_KET.TabIndex = 38
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(571, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "POT_BPJS_KET"
        '
        'txtPOT_BPJS_KES
        '
        Me.txtPOT_BPJS_KES.ForeColor = System.Drawing.Color.Maroon
        Me.txtPOT_BPJS_KES.Location = New System.Drawing.Point(694, 61)
        Me.txtPOT_BPJS_KES.Name = "txtPOT_BPJS_KES"
        Me.txtPOT_BPJS_KES.Size = New System.Drawing.Size(294, 20)
        Me.txtPOT_BPJS_KES.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(571, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "POT_BPJS_KES"
        '
        'txtUANGLEMBUR
        '
        Me.txtUANGLEMBUR.ForeColor = System.Drawing.Color.Maroon
        Me.txtUANGLEMBUR.Location = New System.Drawing.Point(694, 20)
        Me.txtUANGLEMBUR.Name = "txtUANGLEMBUR"
        Me.txtUANGLEMBUR.Size = New System.Drawing.Size(294, 20)
        Me.txtUANGLEMBUR.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(571, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 13)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "UANG_LEMBUR"
        '
        'TxtIDGAJI
        '
        Me.TxtIDGAJI.ForeColor = System.Drawing.Color.Maroon
        Me.TxtIDGAJI.Location = New System.Drawing.Point(12, 12)
        Me.TxtIDGAJI.Name = "TxtIDGAJI"
        Me.TxtIDGAJI.Size = New System.Drawing.Size(10, 20)
        Me.TxtIDGAJI.TabIndex = 12
        Me.TxtIDGAJI.Visible = False
        '
        'DTTANGGALGAJI
        '
        Me.DTTANGGALGAJI.CustomFormat = "yyyy-MM-dd"
        Me.DTTANGGALGAJI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTTANGGALGAJI.Location = New System.Drawing.Point(203, 139)
        Me.DTTANGGALGAJI.Name = "DTTANGGALGAJI"
        Me.DTTANGGALGAJI.Size = New System.Drawing.Size(294, 20)
        Me.DTTANGGALGAJI.TabIndex = 50
        '
        'CMBIDJABATAN
        '
        Me.CMBIDJABATAN.FormattingEnabled = True
        Me.CMBIDJABATAN.Location = New System.Drawing.Point(203, 174)
        Me.CMBIDJABATAN.Name = "CMBIDJABATAN"
        Me.CMBIDJABATAN.Size = New System.Drawing.Size(294, 21)
        Me.CMBIDJABATAN.TabIndex = 51
        '
        'Frm_gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1076, 648)
        Me.Controls.Add(Me.CMBIDJABATAN)
        Me.Controls.Add(Me.DTTANGGALGAJI)
        Me.Controls.Add(Me.txtTOTALGAJI)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNAMA_BANK)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNAMA_REKENING)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNO_REKENING)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPOT_LAIN2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPOT_BPJS_KET)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPOT_BPJS_KES)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtUANGLEMBUR)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtTUNJANGAN)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtGAJIPOKOK)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNAMAJABATAN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNIK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNOSLIP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnKELUAR)
        Me.Controls.Add(Me.BtnPERBAIKI)
        Me.Controls.Add(Me.BtnHAPUS)
        Me.Controls.Add(Me.BtnSIMPAN)
        Me.Controls.Add(Me.TxtIDGAJI)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Name = "Frm_gaji"
        Me.Text = "Frm_gaji"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnKELUAR As System.Windows.Forms.Button
    Friend WithEvents BtnPERBAIKI As System.Windows.Forms.Button
    Friend WithEvents BtnHAPUS As System.Windows.Forms.Button
    Friend WithEvents BtnSIMPAN As System.Windows.Forms.Button
    Friend WithEvents txtNOSLIP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNIK As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNAMAJABATAN As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGAJIPOKOK As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTUNJANGAN As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTOTALGAJI As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNAMA_BANK As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNAMA_REKENING As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNO_REKENING As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPOT_LAIN2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPOT_BPJS_KET As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPOT_BPJS_KES As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtUANGLEMBUR As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtIDGAJI As System.Windows.Forms.TextBox
    Friend WithEvents DTTANGGALGAJI As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMBIDJABATAN As System.Windows.Forms.ComboBox
End Class
