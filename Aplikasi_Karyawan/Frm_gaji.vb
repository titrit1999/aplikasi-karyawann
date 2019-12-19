Public Class Frm_gaji

    Sub get_idjabatan()

        'UNTUK ID OTOMATIS
        konek()
        da = New Odbc.OdbcDataAdapter("select id_jabatan from t_jabatan", conn)

        ds = New DataSet
        da.Fill(ds, "t_jabatan")
        CmbIDJABATAN.DataSource = (ds.Tables("t_jabatan"))
        CmbIDJABATAN.ValueMember = "id_jabatan"
        CmbIDJABATAN.DisplayMember = "id_jabatan"

    End Sub
    Sub auto_slip()

        Dim no_slip As String = "TR" + Format(Now, "yyMMdd-hhmmss")
        txtNOSLIP.Text = no_slip

    End Sub
    Private Sub cetak_slipgaji()

        frm_cetak_gaji.CrystalReportViewer1.SelectionFormula = "{t_gaji.no_slip} = '" & txtNOSLIP.Text & "'"
        frm_cetak_gaji.Show()

    End Sub


    Private Sub Frm_gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        konek()
        da = New Odbc.OdbcDataAdapter("select * from t_gaji", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_gaji")
        DataGridView1.DataSource = (ds.Tables("t_gaji"))
        Call get_idjabatan()
        Call auto_slip()

    End Sub

    Private Sub CmbIDJABATAN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub
    Sub datauser()
        da = New Odbc.OdbcDataAdapter("select * from t_gaji", conn)
        ds = New DataSet
        da.Fill(ds, "t_gaji")
        DataGridView1.DataSource = ds.Tables("t_gaji")
        DataGridView1.ReadOnly = True
    End Sub

    Sub kosongkan()

        txtNOSLIP.Clear()
        txtNIK.Clear()
        CMBIDJABATAN.Text = ""
        txtNAMAJABATAN.Clear()
        txtGAJIPOKOK.Clear()
        txtTUNJANGAN.Clear()
        txtUANGLEMBUR.Clear()
        txtPOT_BPJS_KES.Clear()
        txtPOT_BPJS_KET.Clear()
        txtPOT_LAIN2.Clear()
        txtNO_REKENING.Clear()
        txtNAMA_REKENING.Clear()
        txtNAMA_BANK.Clear()
        txtTOTALGAJI.Clear()

    End Sub
    Private Sub BtnSIMPAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSIMPAN.Click

        Call konek()
        If txtNAMAJABATAN.Text = "" Or txtGAJIPOKOK.Text = "" Then
            MsgBox("Data Harus Diisi", MsgBoxStyle.OkOnly)
        Else
            strcon = "select * from t_gaji WHERE id_gaji = '" & CMBIDJABATAN.Text & "'"
            cmd = New Odbc.OdbcCommand(strcon, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                strcon = "INSERT INTO t_gaji " _
                + "VALUES ('','" & txtNOSLIP.Text & "'," _
                + "'" & txtNIK.Text & "'," _
                + "'" & DTTANGGALGAJI.Text & "'," _
                + "'" & CMBIDJABATAN.Text & "'," _
                + "'" & txtNAMAJABATAN.Text & "'," _
                + "'" & txtGAJIPOKOK.Text & "'," _
                + "'" & txtTUNJANGAN.Text & "'," _
                + "'" & txtUANGLEMBUR.Text & "'," _
                + "'" & txtPOT_BPJS_KES.Text & "'," _
                + "'" & txtPOT_BPJS_KET.Text & "'," _
                + "'" & txtPOT_LAIN2.Text & "'," _
                + "'" & txtNO_REKENING.Text & "'," _
                + "'" & txtNAMA_REKENING.Text & "'," _
                + "'" & txtNAMA_BANK.Text & "'," _
                + "'" & txtTOTALGAJI.Text & "')"

                cmd = New Odbc.OdbcCommand(strcon, conn)
                cmd.ExecuteNonQuery()
                conn.Close()

                'MsgBox("Data Berhasil Disimpan", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                

                Dim pesan As Integer
                pesan = MsgBox("DATA BERHASIL DISIMPAN, " + "APAKAH ANDA AKAN MENCETAK TRANSAKSI...??? " + txtNOSLIP.Text, vbExclamation + vbYesNo, "CETAK TRANSAKSI")

                If pesan = vbNo Then
                    Exit Sub
                Else
                    Call cetak_slipgaji()
                End If

            Else
                MsgBox("Data Sudah Ada", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                Call kosongkan()
                Call cetak_slipgaji()
            End If
        End If
        Call kosongkan()
        Call datauser()

    End Sub

    Private Sub BtnHAPUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHAPUS.Click
        If MsgBox("Apa Anda Yakin Menghapus Data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strcon = "DELETE FROM t_gaji WHERE id_gaji = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

            Dim cmd As New Odbc.OdbcCommand
            cmd.Connection = conn
            cmd.CommandText = strcon
            cmd.ExecuteNonQuery()
            conn.Close()

            Call datauser()
            MsgBox("Data Sudah Dihapus", vbInformation)
        Else
        End If
    End Sub

    Private Sub BtnPERBAIKI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPERBAIKI.Click
        Call konek()

        strcon = "UPDATE t_gaji SET " _
        + "no_slip = '" & txtNOSLIP.Text & "'," _
        + "nik = '" & txtNIK.Text & "'," _
        + "tgl_gaji = '" & DTTANGGALGAJI.Text & "'," _
        + "id_jabatan = '" & CMBIDJABATAN.Text & "'," _
        + "nama_jabatan = '" & txtNAMAJABATAN.Text & "'," _
        + "gaji_pokok = '" & txtGAJIPOKOK.Text & "'," _
        + "tunjangan = '" & txtTUNJANGAN.Text & "'," _
        + "uang_lembur = '" & txtUANGLEMBUR.Text & "'," _
        + "pot_bpjs_kes = '" & txtPOT_BPJS_KES.Text & "'," _
        + "pot_bpjs_ket = '" & txtPOT_BPJS_KET.Text & "'," _
        + "pot_lain2 = '" & txtPOT_LAIN2.Text & "'," _
        + "no_rekening = '" & txtNO_REKENING.Text & "'," _
        + "nama_rekening = '" & txtNAMA_REKENING.Text & "'," _
        + "nama_bank = '" & txtNAMA_BANK.Text & "'," _
        + "total_gaji = '" & txtTOTALGAJI.Text & "'" _
        + " WHERE id_gaji = '" & TxtIDGAJI.Text & "'"
        Dim cmd As New Odbc.OdbcCommand
        cmd.Connection = conn
        cmd.CommandText = strcon
        'cmd = New Odbc.OdbcCommand(strcon, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("Data Sudah Diupdate", MsgBoxStyle.Information)
        'Call UpdateKaryawan()
        Form1.DataGridView1.Refresh()

    End Sub

    Private Sub BtnKELUAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKELUAR.Click
        Close()
    End Sub
    Private Sub set_editjabatan(ByVal x As Integer)
        Try
            TxtIDGAJI.Text = DataGridView1.Rows(x).Cells(0).Value
            txtNOSLIP.Text = DataGridView1.Rows(x).Cells(1).Value
            txtNIK.Text = DataGridView1.Rows(x).Cells(2).Value
            CMBIDJABATAN.Text = DataGridView1.Rows(x).Cells(3).Value
            CMBIDJABATAN.Text = DataGridView1.Rows(x).Cells(4).Value
            txtNAMAJABATAN.Text = DataGridView1.Rows(x).Cells(5).Value
            txtGAJIPOKOK.Text = DataGridView1.Rows(x).Cells(6).Value
            txtTUNJANGAN.Text = DataGridView1.Rows(x).Cells(7).Value
            txtUANGLEMBUR.Text = DataGridView1.Rows(x).Cells(8).Value
            txtPOT_BPJS_KES.Text = DataGridView1.Rows(x).Cells(9).Value
            txtPOT_BPJS_KET.Text = DataGridView1.Rows(x).Cells(10).Value
            txtPOT_LAIN2.Text = DataGridView1.Rows(x).Cells(11).Value
            txtNO_REKENING.Text = DataGridView1.Rows(x).Cells(12).Value
            txtNAMA_REKENING.Text = DataGridView1.Rows(x).Cells(13).Value
            txtNAMA_BANK.Text = DataGridView1.Rows(x).Cells(14).Value
            txtTOTALGAJI.Text = DataGridView1.Rows(x).Cells(15).Value

        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        set_editjabatan(e.RowIndex)
    End Sub

    Private Sub CMBIDJABATAN_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBIDJABATAN.SelectedIndexChanged
        'UNTUK ID OTOMATIS
        konek()
        cmd = New Odbc.OdbcCommand("SELECT nama_jabatan,gaji_pokok FROM t_jabatan WHERE id_jabatan = '" & CMBIDJABATAN.Text & "'", conn)

        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtNAMAJABATAN.Text = rd(0).ToString
            txtGAJIPOKOK.Text = rd(1).ToString
        End If
    End Sub

    Public Sub hitung_gaji()
        Dim jum_gaji As Integer
        Dim jum_potongan As Integer

        jum_gaji = Val(txtGAJIPOKOK.Text) + Val(txtTUNJANGAN.Text) + Val(txtUANGLEMBUR.Text)
        jum_potongan = Val(txtPOT_BPJS_KES.Text) + Val(txtPOT_BPJS_KET.Text) + Val(txtPOT_LAIN2.Text)
        txtTOTALGAJI.Text = jum_gaji - jum_potongan
    End Sub

    Private Sub txtGAJIPOKOK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGAJIPOKOK.TextChanged
        Call hitung_gaji()
    End Sub

    Private Sub txtTUNJANGAN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTUNJANGAN.TextChanged
        Call hitung_gaji()
    End Sub

    Private Sub txtUANGLEMBUR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUANGLEMBUR.TextChanged
        Call hitung_gaji()
    End Sub

    Private Sub txtPOT_BPJS_KES_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPOT_BPJS_KES.TextChanged
        Call hitung_gaji()
    End Sub

    Private Sub txtPOT_BPJS_KET_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPOT_BPJS_KET.TextChanged
        Call hitung_gaji()
    End Sub

    Private Sub txtPOT_LAIN2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPOT_LAIN2.TextChanged
        Call hitung_gaji()
    End Sub
End Class