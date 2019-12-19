Imports System.Data.Odbc
Public Class frm_absensi

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbltglsekarang.Text = Format(Now, "yyyy-MM-dd")
        lbljamsekarang.Text = Format(Now, "HH:mm:ss")

    End Sub

    Private Sub txtNik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNik.KeyPress

        Dim jam_masuk, jam_kerja, jam_lembur, jam_pulang As DateTime
        'Dim jam_pulang As String
        Dim a1, a2 As String
        Dim tgl As DateTime

        'Dim jam_masuk, jam_kerja, jam_pulang As String
        'Dim tgl As String
        If (e.KeyChar = Chr(13)) Then
            konek()
            strcon = "Select * from t_karyawan where nik='" & txtNik.Text & "'"
            cmd = New Odbc.OdbcCommand(strcon, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                lblnik.Text = rd.Item("nik")
                PictureBox1.ImageLocation = rd.Item("lokasi_gambar")
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

                '===============================================CODE SIMPAN===============================================
                jam_masuk = Format(Now, "HH:mm:ss")
                jam_kerja = "07:00:00"
                a1 = Format(Now, "HH:hh:ss-HH:hh:ss")
                a2 = "07:00:00-16:00:00"

                jam_pulang = Format(Now, "HH:mm:ss")
                tgl = Format(Now, "yyyy-MM-dd")

                jam_lembur = Format(Now, "HH:mm:ss")


                Dim selisih As TimeSpan = New TimeSpan
                selisih = jam_masuk - jam_kerja
                lblinfo.Text = selisih.ToString

                Dim tambahan As TimeSpan = New TimeSpan
                tambahan = jam_masuk - jam_pulang
                lbllembur.Text = tambahan.ToString


                strcon = "Insert into t_absensi(id_absensi,nik,jam_masuk,jam_kerja,tgl_kerja,jam_pulang,telat_masuk) values(?,?,?,?,?,?,?)"
                Dim mycomm As OdbcCommand = New OdbcCommand(strcon, conn)
                With mycomm.Parameters
                    .Add("?", OdbcType.VarChar, 20).Value = Microsoft.VisualBasic.Left(txtNik.Text, 3) & Format(Now, "yyMMdd-HHmmss")
                    .Add("?", OdbcType.VarChar, 20).Value = txtNik.Text.Trim
                    '.Add("?", OdbcType.VarChar, 15).Value = jam_masuk
                    '.Add("?", OdbcType.VarChar, 15).Value = jam_kerja
                    .Add("?", OdbcType.VarChar, 15).Value = a1
                    .Add("?", OdbcType.VarChar, 15).Value = a2
                    .Add("?", OdbcType.Date).Value = tgl
                    .Add("?", OdbcType.VarChar, 15).Value = jam_pulang
                    .Add("?", OdbcType.VarChar, 10).Value = selisih.ToString
                    .Add("?", OdbcType.VarChar, 15).Value = tambahan.ToString
                End With

                mycomm.ExecuteNonQuery()
                mycomm = Nothing
                MsgBox("MENYIMPAN", MsgBoxStyle.MsgBoxSetForeground, "SAVE")
                '============================================END KODE SIMPAN===============================================
            Else
                txtNik.Clear()
                PictureBox1.Hide()
            End If
            PictureBox1.Visible = True
        End If
    End Sub
    Private Sub txtNik_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNik.TextChanged

    End Sub

    Private Sub frm_absensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblnik_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblnik.Click

    End Sub

    Private Sub lblinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblinfo.Click

    End Sub
End Class