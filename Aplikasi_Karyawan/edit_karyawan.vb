Public Class edit_karyawan

    Private Sub BTNUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNUPDATE.Click
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


        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        'cmd = New Odbc.OdbcCommand(strcon, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Sudah Diupdate", MsgBoxStyle.Information)
        Call UpdateKaryawan()

    End Sub

    Private Sub edit_karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call UpdateKaryawan()
    End Sub

    Sub UpdateKaryawan()

        TxtNIK.Enabled = False
        konek()
        cmd = New Odbc.OdbcCommand("SELECT * FROM t_karyawan WHERE nik ='" & TxtNIK.Text & "'", conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            TxtNAMA.Text = rd(1).ToString
            TxtTEMPATLAHIR.Text = rd(2).ToString
            DTTANGGALLAHIR.Text = rd(3).ToString
            CMBAGAMA.Text = rd(4).ToString
            CMBSTATUS.Text = rd(5).ToString
            CMBKEWARGANEGARAAN.Text = rd(6).ToString
            TXTNOHP.Text = rd(7).ToString
            TXTEMAIL.Text = rd(8).ToString
            TXTALAMAT.Text = rd(9).ToString
            CMDPENDIDIKANTERAKHIR.Text = rd(10).ToString
            TXTPERGURUANTINGGI.Text = rd(11).ToString
            TXTJABATAN.Text = rd(12).ToString
            DTTANGGALMASUK.Text = rd(13).ToString
            TXTBAGIAN.Text = rd(14).ToString
            TXTGAJI.Text = rd(15).ToString
            CMDSTATUSKARYAWAN.Text = rd(16).ToString
            CMDSTATUSKERJA.Text = rd(17).ToString
        Else
            Exit Sub
            MsgBox("Tidak Ditemukan")
        End If
        conn.Close()
    End Sub
End Class