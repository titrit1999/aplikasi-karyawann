Imports System.Data.Odbc
Public Class tambah_karyawan

    Private PathFile As String = Nothing

    Private Sub BTNSIMPAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSIMPAN.Click

        konek()
        'strcon = "INSERT INTO t_karyawan " _
        '+ "VALUES ('" & TxtNIK.Text & "'," _
        '+ "'" & TxtNAMA.Text & "'," _
        '+ "'" & TxtTEMPATLAHIR.Text & "'," _
        '+ "'" & DTTANGGALLAHIR.Text & "'," _
        '+ "'" & CMBAGAMA.Text & "'," _
        '+ "'" & CMBSTATUS.Text & "'," _
        '+ "'" & CMBKEWARGANEGARAAN.Text & "'," _
        '+ "'" & TXTNOHP.Text & "'," _
        '+ "'" & TXTEMAIL.Text & "'," _
        '+ "'" & TXTALAMAT.Text & "'," _
        '+ "'" & CMDPENDIDIKANTERAKHIR.Text & "'," _
        '+ "'" & TXTPERGURUANTINGGI.Text & "'," _
        '+ "'" & TXTJABATAN.Text & "'," _
        '+ "'" & DTTANGGALMASUK.Text & "'," _
        '+ "'" & TXTBAGIAN.Text & "'," _
        '+ "'" & TXTGAJI.Text & "'," _
        '+ "'" & CMDSTATUSKARYAWAN.Text & "'," _
        '+ "'" & CMDSTATUSKERJA.Text & "')"

        'MsgBox(strcon)

        'Dim cmd As New Odbc.OdbcCommand
        'cmd.Connection = conn
        'cmd.CommandText = strcon
        'cmd.ExecuteNonQuery()
        'conn.Close()
        'MsgBox("DATA BERHASIL DISIMPAN", MsgBoxStyle.Information)

        Try
            strcon = "Insert into t_karyawan(nik,nama,tempat_lahir,tgl_lahir,agama,status,kewarganegaraan,no_hp,email,alamat,pendidikan_terakhir,pt_terakhir,jabatan,tgl_masuk,bagian,status_karyawan,status_kerja,gaji,nama_gambar,lokasi_gambar)values(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)"
            Dim mycomm As OdbcCommand = New OdbcCommand(strcon, conn)
            With mycomm.Parameters
                .Add("?", OdbcType.VarChar, 15).Value = TxtNIK.Text.Trim
                .Add("?", OdbcType.VarChar, 30).Value = TxtNAMA.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = TxtTEMPATLAHIR.Text.Trim
                .Add("?", OdbcType.Date).Value = DTTANGGALLAHIR.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = CMBAGAMA.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = CMBSTATUS.Text.Trim
                .Add("?", OdbcType.VarChar, 3).Value = CMBKEWARGANEGARAAN.Text.Trim
                .Add("?", OdbcType.VarChar, 13).Value = TXTNOHP.Text.Trim
                .Add("?", OdbcType.VarChar, 25).Value = TXTEMAIL.Text.Trim
                .Add("?", OdbcType.VarChar, 35).Value = TXTALAMAT.Text.Trim
                .Add("?", OdbcType.VarChar, 4).Value = CMDPENDIDIKANTERAKHIR.Text.Trim
                .Add("?", OdbcType.VarChar, 40).Value = TXTPERGURUANTINGGI.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = TXTJABATAN.Text.Trim
                .Add("?", OdbcType.Date).Value = DTTANGGALMASUK.Text.Trim
                .Add("?", OdbcType.VarChar, 20).Value = TXTBAGIAN.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = CMDSTATUSKARYAWAN.Text.Trim
                .Add("?", OdbcType.VarChar, 15).Value = CMDSTATUSKERJA.Text.Trim
                .Add("?", OdbcType.VarChar, 10).Value = TXTGAJI.Text.Trim
                .Add("?", OdbcType.VarChar, 200).Value = txtNamaGbr.Text.Trim
                .Add("?", OdbcType.VarChar, 200).Value = lblpath.Text.Trim
            End With

            mycomm.ExecuteNonQuery()
            mycomm = Nothing
            MsgBox("Menyimpan", MsgBoxStyle.MsgBoxSetForeground, "Save")

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnpilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpilih.Click

        On Error Resume Next
        OpenFileDialog1.Filter = "JPG Files(*.jpg)|*.jpg| JPEG Files(*.jpeg)|*.jpeg| GIF Files(*.gif)|*.gif| PNG Files(*.png)|*.png|BMP Files(*.bmp)|*.bmp"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            pctgbr.SizeMode = PictureBoxSizeMode.StretchImage
            pctgbr.Image = New Bitmap(OpenFileDialog1.FileName)
            btnpilih.Enabled = True
            PathFile = OpenFileDialog1.FileName
            txtNamaGbr.Text = PathFile.Substring(PathFile.LastIndexOf("\") + 1)
            lblpath.Text = OpenFileDialog1.FileName
            pctgbr.Image = Image.FromFile(lblpath.Text)
        End If
        pctgbr.Visible = True

    End Sub
End Class





































