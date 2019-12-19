<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_karyawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_karyawan))
        Me.BTNUPDATE = New System.Windows.Forms.Button
        Me.CMDSTATUSKARYAWAN = New System.Windows.Forms.ComboBox
        Me.CMDSTATUSKERJA = New System.Windows.Forms.ComboBox
        Me.TXTBAGIAN = New System.Windows.Forms.TextBox
        Me.TXTGAJI = New System.Windows.Forms.TextBox
        Me.DTTANGGALMASUK = New System.Windows.Forms.DateTimePicker
        Me.TXTPERGURUANTINGGI = New System.Windows.Forms.TextBox
        Me.TXTJABATAN = New System.Windows.Forms.TextBox
        Me.CMDPENDIDIKANTERAKHIR = New System.Windows.Forms.ComboBox
        Me.TXTEMAIL = New System.Windows.Forms.TextBox
        Me.TXTALAMAT = New System.Windows.Forms.TextBox
        Me.CMBKEWARGANEGARAAN = New System.Windows.Forms.ComboBox
        Me.CMBSTATUS = New System.Windows.Forms.ComboBox
        Me.CMBAGAMA = New System.Windows.Forms.ComboBox
        Me.DTTANGGALLAHIR = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtTEMPATLAHIR = New System.Windows.Forms.TextBox
        Me.TXTNOHP = New System.Windows.Forms.TextBox
        Me.TxtNAMA = New System.Windows.Forms.TextBox
        Me.TxtNIK = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'BTNUPDATE
        '
        Me.BTNUPDATE.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNUPDATE.ForeColor = System.Drawing.Color.DarkRed
        Me.BTNUPDATE.Image = CType(resources.GetObject("BTNUPDATE.Image"), System.Drawing.Image)
        Me.BTNUPDATE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNUPDATE.Location = New System.Drawing.Point(407, 461)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(236, 73)
        Me.BTNUPDATE.TabIndex = 76
        Me.BTNUPDATE.Text = "UPDATE"
        Me.BTNUPDATE.UseVisualStyleBackColor = True
        '
        'CMDSTATUSKARYAWAN
        '
        Me.CMDSTATUSKARYAWAN.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDSTATUSKARYAWAN.ForeColor = System.Drawing.Color.DarkRed
        Me.CMDSTATUSKARYAWAN.FormattingEnabled = True
        Me.CMDSTATUSKARYAWAN.Items.AddRange(New Object() {"TETAP", "KONTRAK"})
        Me.CMDSTATUSKARYAWAN.Location = New System.Drawing.Point(695, 332)
        Me.CMDSTATUSKARYAWAN.Name = "CMDSTATUSKARYAWAN"
        Me.CMDSTATUSKARYAWAN.Size = New System.Drawing.Size(212, 23)
        Me.CMDSTATUSKARYAWAN.TabIndex = 74
        '
        'CMDSTATUSKERJA
        '
        Me.CMDSTATUSKERJA.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDSTATUSKERJA.ForeColor = System.Drawing.Color.DarkRed
        Me.CMDSTATUSKERJA.FormattingEnabled = True
        Me.CMDSTATUSKERJA.Items.AddRange(New Object() {"AKTIF ", "TIDAK AKTIF"})
        Me.CMDSTATUSKERJA.Location = New System.Drawing.Point(695, 372)
        Me.CMDSTATUSKERJA.Name = "CMDSTATUSKERJA"
        Me.CMDSTATUSKERJA.Size = New System.Drawing.Size(212, 23)
        Me.CMDSTATUSKERJA.TabIndex = 73
        '
        'TXTBAGIAN
        '
        Me.TXTBAGIAN.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBAGIAN.ForeColor = System.Drawing.Color.DarkRed
        Me.TXTBAGIAN.Location = New System.Drawing.Point(695, 251)
        Me.TXTBAGIAN.Name = "TXTBAGIAN"
        Me.TXTBAGIAN.Size = New System.Drawing.Size(212, 20)
        Me.TXTBAGIAN.TabIndex = 72
        '
        'TXTGAJI
        '
        Me.TXTGAJI.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGAJI.ForeColor = System.Drawing.Color.DarkRed
        Me.TXTGAJI.Location = New System.Drawing.Point(695, 294)
        Me.TXTGAJI.Name = "TXTGAJI"
        Me.TXTGAJI.Size = New System.Drawing.Size(212, 20)
        Me.TXTGAJI.TabIndex = 71
        '
        'DTTANGGALMASUK
        '
        Me.DTTANGGALMASUK.CalendarForeColor = System.Drawing.Color.DarkRed
        Me.DTTANGGALMASUK.CalendarTitleForeColor = System.Drawing.Color.DarkRed
        Me.DTTANGGALMASUK.CustomFormat = "yyyy-MM-dd"
        Me.DTTANGGALMASUK.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTTANGGALMASUK.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTTANGGALMASUK.Location = New System.Drawing.Point(695, 212)
        Me.DTTANGGALMASUK.Name = "DTTANGGALMASUK"
        Me.DTTANGGALMASUK.Size = New System.Drawing.Size(212, 20)
        Me.DTTANGGALMASUK.TabIndex = 70
        '
        'TXTPERGURUANTINGGI
        '
        Me.TXTPERGURUANTINGGI.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPERGURUANTINGGI.ForeColor = System.Drawing.Color.DarkRed
        Me.TXTPERGURUANTINGGI.Location = New System.Drawing.Point(695, 131)
        Me.TXTPERGURUANTINGGI.Name = "TXTPERGURUANTINGGI"
        Me.TXTPERGURUANTINGGI.Size = New System.Drawing.Size(212, 20)
        Me.TXTPERGURUANTINGGI.TabIndex = 69
        '
        'TXTJABATAN
        '
        Me.TXTJABATAN.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTJABATAN.ForeColor = System.Drawing.Color.DarkRed
        Me.TXTJABATAN.Location = New System.Drawing.Point(695, 172)
        Me.TXTJABATAN.Name = "TXTJABATAN"
        Me.TXTJABATAN.Size = New System.Drawing.Size(212, 20)
        Me.TXTJABATAN.TabIndex = 68
        '
        'CMDPENDIDIKANTERAKHIR
        '
        Me.CMDPENDIDIKANTERAKHIR.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDPENDIDIKANTERAKHIR.ForeColor = System.Drawing.Color.DarkRed
        Me.CMDPENDIDIKANTERAKHIR.FormattingEnabled = True
        Me.CMDPENDIDIKANTERAKHIR.Items.AddRange(New Object() {"SD", "SMP", "SMA", "D3", "S1", "S2", "S3"})
        Me.CMDPENDIDIKANTERAKHIR.Location = New System.Drawing.Point(695, 88)
        Me.CMDPENDIDIKANTERAKHIR.Name = "CMDPENDIDIKANTERAKHIR"
        Me.CMDPENDIDIKANTERAKHIR.Size = New System.Drawing.Size(212, 23)
        Me.CMDPENDIDIKANTERAKHIR.TabIndex = 67
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEMAIL.ForeColor = System.Drawing.Color.DarkRed
        Me.TXTEMAIL.Location = New System.Drawing.Point(232, 379)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(212, 20)
        Me.TXTEMAIL.TabIndex = 66
        '
        'TXTALAMAT
        '
        Me.TXTALAMAT.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTALAMAT.ForeColor = System.Drawing.Color.DarkRed
        Me.TXTALAMAT.Location = New System.Drawing.Point(695, 43)
        Me.TXTALAMAT.Multiline = True
        Me.TXTALAMAT.Name = "TXTALAMAT"
        Me.TXTALAMAT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTALAMAT.Size = New System.Drawing.Size(212, 20)
        Me.TXTALAMAT.TabIndex = 65
        '
        'CMBKEWARGANEGARAAN
        '
        Me.CMBKEWARGANEGARAAN.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBKEWARGANEGARAAN.ForeColor = System.Drawing.Color.DarkRed
        Me.CMBKEWARGANEGARAAN.FormattingEnabled = True
        Me.CMBKEWARGANEGARAAN.Items.AddRange(New Object() {"WNI", "WNA"})
        Me.CMBKEWARGANEGARAAN.Location = New System.Drawing.Point(232, 296)
        Me.CMBKEWARGANEGARAAN.Name = "CMBKEWARGANEGARAAN"
        Me.CMBKEWARGANEGARAAN.Size = New System.Drawing.Size(212, 23)
        Me.CMBKEWARGANEGARAAN.TabIndex = 64
        '
        'CMBSTATUS
        '
        Me.CMBSTATUS.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBSTATUS.ForeColor = System.Drawing.Color.DarkRed
        Me.CMBSTATUS.FormattingEnabled = True
        Me.CMBSTATUS.Items.AddRange(New Object() {"MENIKAH", "BELUM MENIKAH"})
        Me.CMBSTATUS.Location = New System.Drawing.Point(232, 255)
        Me.CMBSTATUS.Name = "CMBSTATUS"
        Me.CMBSTATUS.Size = New System.Drawing.Size(212, 23)
        Me.CMBSTATUS.TabIndex = 63
        '
        'CMBAGAMA
        '
        Me.CMBAGAMA.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBAGAMA.ForeColor = System.Drawing.Color.DarkRed
        Me.CMBAGAMA.FormattingEnabled = True
        Me.CMBAGAMA.Items.AddRange(New Object() {"ISLAM", "PROTESTAN", "KATOLIK", "KONGHUCU", "BUDHA"})
        Me.CMBAGAMA.Location = New System.Drawing.Point(232, 213)
        Me.CMBAGAMA.Name = "CMBAGAMA"
        Me.CMBAGAMA.Size = New System.Drawing.Size(212, 23)
        Me.CMBAGAMA.TabIndex = 62
        '
        'DTTANGGALLAHIR
        '
        Me.DTTANGGALLAHIR.CalendarForeColor = System.Drawing.Color.DarkRed
        Me.DTTANGGALLAHIR.CalendarMonthBackground = System.Drawing.Color.DarkRed
        Me.DTTANGGALLAHIR.CalendarTitleBackColor = System.Drawing.Color.Maroon
        Me.DTTANGGALLAHIR.CalendarTitleForeColor = System.Drawing.Color.DarkRed
        Me.DTTANGGALLAHIR.CalendarTrailingForeColor = System.Drawing.Color.DarkRed
        Me.DTTANGGALLAHIR.CustomFormat = "yyyy-MM-dd"
        Me.DTTANGGALLAHIR.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTTANGGALLAHIR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTTANGGALLAHIR.Location = New System.Drawing.Point(232, 173)
        Me.DTTANGGALLAHIR.Name = "DTTANGGALLAHIR"
        Me.DTTANGGALLAHIR.Size = New System.Drawing.Size(212, 20)
        Me.DTTANGGALLAHIR.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(524, 375)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 15)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "STATUS KERJA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(524, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 15)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "STATUS KARYAWAN"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(524, 297)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 15)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "GAJI"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(524, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 15)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "BAGIAN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(524, 215)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 15)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "TANGGAL MASUK"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(524, 175)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 15)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "JABATAN"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(524, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 15)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "PERGURUAN TINGGI"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(524, 91)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(169, 15)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "PENDIDIKAN TERAKHIR"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(524, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 15)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "ALAMAT"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(79, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "EMAIL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(79, 340)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 15)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "NO HP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(79, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 15)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "KEWARGANEGARAAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(79, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "STATUS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "AGAMA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 15)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "TANGGAL LAHIR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 15)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "TEMPAT LAHIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "NIK"
        '
        'TxtTEMPATLAHIR
        '
        Me.TxtTEMPATLAHIR.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTEMPATLAHIR.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtTEMPATLAHIR.Location = New System.Drawing.Point(232, 131)
        Me.TxtTEMPATLAHIR.Name = "TxtTEMPATLAHIR"
        Me.TxtTEMPATLAHIR.Size = New System.Drawing.Size(212, 20)
        Me.TxtTEMPATLAHIR.TabIndex = 42
        '
        'TXTNOHP
        '
        Me.TXTNOHP.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOHP.ForeColor = System.Drawing.Color.DarkRed
        Me.TXTNOHP.Location = New System.Drawing.Point(232, 336)
        Me.TXTNOHP.Name = "TXTNOHP"
        Me.TXTNOHP.Size = New System.Drawing.Size(212, 20)
        Me.TXTNOHP.TabIndex = 41
        '
        'TxtNAMA
        '
        Me.TxtNAMA.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNAMA.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNAMA.Location = New System.Drawing.Point(232, 88)
        Me.TxtNAMA.Name = "TxtNAMA"
        Me.TxtNAMA.Size = New System.Drawing.Size(212, 20)
        Me.TxtNAMA.TabIndex = 40
        '
        'TxtNIK
        '
        Me.TxtNIK.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNIK.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNIK.Location = New System.Drawing.Point(232, 43)
        Me.TxtNIK.Name = "TxtNIK"
        Me.TxtNIK.Size = New System.Drawing.Size(212, 20)
        Me.TxtNIK.TabIndex = 39
        '
        'edit_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(975, 606)
        Me.Controls.Add(Me.BTNUPDATE)
        Me.Controls.Add(Me.CMDSTATUSKARYAWAN)
        Me.Controls.Add(Me.CMDSTATUSKERJA)
        Me.Controls.Add(Me.TXTBAGIAN)
        Me.Controls.Add(Me.TXTGAJI)
        Me.Controls.Add(Me.DTTANGGALMASUK)
        Me.Controls.Add(Me.TXTPERGURUANTINGGI)
        Me.Controls.Add(Me.TXTJABATAN)
        Me.Controls.Add(Me.CMDPENDIDIKANTERAKHIR)
        Me.Controls.Add(Me.TXTEMAIL)
        Me.Controls.Add(Me.TXTALAMAT)
        Me.Controls.Add(Me.CMBKEWARGANEGARAAN)
        Me.Controls.Add(Me.CMBSTATUS)
        Me.Controls.Add(Me.CMBAGAMA)
        Me.Controls.Add(Me.DTTANGGALLAHIR)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTEMPATLAHIR)
        Me.Controls.Add(Me.TXTNOHP)
        Me.Controls.Add(Me.TxtNAMA)
        Me.Controls.Add(Me.TxtNIK)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "edit_karyawan"
        Me.Text = "edit_karyawan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNUPDATE As System.Windows.Forms.Button
    Friend WithEvents CMDSTATUSKARYAWAN As System.Windows.Forms.ComboBox
    Friend WithEvents CMDSTATUSKERJA As System.Windows.Forms.ComboBox
    Friend WithEvents TXTBAGIAN As System.Windows.Forms.TextBox
    Friend WithEvents TXTGAJI As System.Windows.Forms.TextBox
    Friend WithEvents DTTANGGALMASUK As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTPERGURUANTINGGI As System.Windows.Forms.TextBox
    Friend WithEvents TXTJABATAN As System.Windows.Forms.TextBox
    Friend WithEvents CMDPENDIDIKANTERAKHIR As System.Windows.Forms.ComboBox
    Friend WithEvents TXTEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents TXTALAMAT As System.Windows.Forms.TextBox
    Friend WithEvents CMBKEWARGANEGARAAN As System.Windows.Forms.ComboBox
    Friend WithEvents CMBSTATUS As System.Windows.Forms.ComboBox
    Friend WithEvents CMBAGAMA As System.Windows.Forms.ComboBox
    Friend WithEvents DTTANGGALLAHIR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTEMPATLAHIR As System.Windows.Forms.TextBox
    Friend WithEvents TXTNOHP As System.Windows.Forms.TextBox
    Friend WithEvents TxtNAMA As System.Windows.Forms.TextBox
    Friend WithEvents TxtNIK As System.Windows.Forms.TextBox
End Class
