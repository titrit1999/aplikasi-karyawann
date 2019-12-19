Public Class hapus_karyawan
    
    Private Sub hapus_karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call konek()

        strcon = "UPDATE t_karyawan SET nama = '" & TxtNAMA.Text & "'," _
                  + "tempat_lahir = '" & TxtTEMPATLAHIR.Text & "'," _
                  + "tgl_lahir = '" & DTTANGGALLAHIR.Text & "'," _
                  + "agama = '" & CMBAGAMA.Text & "'," _
                  + "status = '" & CMBSTATUS.Text & "'," _
                  + "kewarganegaraan = '" & CMBKEWARGANEGARAAN.Text & "'," _
                  + "no_hp = '" & TXTNOHP.Text & "'," _
                  + "email = '" & TXTEMAIL.Text & "'," _
                  + "alamat = '" & TXTALAMAT.Text & "'," _
                  + "pendidikan_terakhir = '" & CMDPENDIDIKANTERAKHIR.Text & "'," _
                  + "pt_terakhir = '" & CMDPENDIDIKANTERAKHIR.Text & "'," _
                  + "jabatan = '" & TXTJABATAN.Text & "'," _
                  + "tgl_masuk = '" & DTTANGGALMASUK.Text & "'," _
                  + "bagian = '" & TXTBAGIAN.Text & "'," _
                  + "gaji = '" & TXTGAJI.Text & "'," _
                  + "status_karyawan = '" & CMDSTATUSKARYAWAN.Text & "'," _
                  + "status_kerja = '" & CMDSTATUSKERJA.Text & "'" _
                  + "WHERE nik = '" & TxtNIK.Text & "'"


     
    End Sub

    Private Sub BTNDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNDELETE.Click
        Dim hapus As String
        hapus = "delete from t_karyawan where nik='" & TxtNIK.Text & "'"
        cmd = New Odbc.OdbcCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("APAKAH ANDA YAKIN AKAN MENGHAPUS DATA INI")
        MsgBox("DATA SUDAH TERHAPUS", MsgBoxStyle.Information, "INFORMASI")
        TxtNIK.Enabled = True
    End Sub
End Class