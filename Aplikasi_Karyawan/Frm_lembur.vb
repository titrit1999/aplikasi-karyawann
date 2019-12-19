Public Class Frm_lembur
    Sub get_idjabatan()

        konek()
        da = New Odbc.OdbcDataAdapter("select id_jabatan from t_jabatan", conn)

        ds = New DataSet
        da.Fill(ds, "t_jabatan")
        cmdIDJABATAN.DataSource = (ds.Tables("t_jabatan"))
        cmdIDJABATAN.ValueMember = "id_jabatan"
        cmdIDJABATAN.DisplayMember = "id_jabatan"

    End Sub
    Sub get_nik()

        konek()
        da = New Odbc.OdbcDataAdapter("select nik from t_karyawan", conn)

        ds = New DataSet
        da.Fill(ds, "t_karyawan")
        cmdIDJABATAN.DataSource = (ds.Tables("t_karyawan"))
        cmdIDJABATAN.ValueMember = "nik"
        cmdIDJABATAN.DisplayMember = "nik"

    End Sub
    Private Sub Frm_lembur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        konek()
        da = New Odbc.OdbcDataAdapter("select * from t_lembur", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_lembur")
        DataGridView1.DataSource = (ds.Tables("t_lembur"))
        Call get_nik()
        Call get_idjabatan()

    End Sub
    Sub datauser()
        da = New Odbc.OdbcDataAdapter("select * from t_lembur", conn)
        ds = New DataSet
        da.Fill(ds, "t_lembur")
        DataGridView1.DataSource = ds.Tables("t_lembur")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub BtnHAPUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHAPUS.Click
        If MsgBox("Apa Anda Yakin Menghapus Data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strcon = "DELETE FROM t_lembur WHERE id_lembur = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

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

    Private Sub BtnSIMPAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSIMPAN.Click
        Call konek()
        If txtnik.Text = "" Or txtNAMAKARYAWAN.Text = "" Then
            MsgBox("Data Harus Diisi", MsgBoxStyle.OkOnly)
        Else
            strcon = "select * from t_lembur WHERE nik = '" & txtnik.Text & "'"
            cmd = New Odbc.OdbcCommand(strcon, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                strcon = "INSERT INTO t_lembur " _
                + "VALUES ('','" & txtnik.Text & "'," _
                + "'" & txtNAMAKARYAWAN.Text & "'," _
                + "'" & cmdIDJABATAN.Text & "'," _
                + "'" & DTTGLLEMBUR.Text & "'," _
                + "'" & txtJUMJAMLEMBUR.Text & "'," _
                + "'" & txtUANGLEMBUR.Text & "'," _
                + "'" & txtTOTALUANGLEMBUR.Text & "')"
                cmd = New Odbc.OdbcCommand(strcon, conn)
                cmd.ExecuteNonQuery()
                conn.Close()

                MsgBox("Data Berhasil Disimpan", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                Call kosongkan()
                Call datauser()
            Else
                MsgBox("Data Sudah Ada", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                Call kosongkan()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        set_editjabatan(e.RowIndex)
    End Sub
    Private Sub set_editjabatan(ByVal x As Integer)
        Try
            TxtIDLEMBUR.Text = DataGridView1.Rows(x).Cells(0).Value
            txtnik.Text = DataGridView1.Rows(x).Cells(1).Value
            txtNAMAKARYAWAN.Text = DataGridView1.Rows(x).Cells(2).Value
            cmdIDJABATAN.Text = DataGridView1.Rows(x).Cells(3).Value
            DTTGLLEMBUR.Text = DataGridView1.Rows(x).Cells(4).Value
            txtJUMJAMLEMBUR.Text = DataGridView1.Rows(x).Cells(5).Value
            txtUANGLEMBUR.Text = DataGridView1.Rows(x).Cells(6).Value
            txtTOTALUANGLEMBUR.Text = DataGridView1.Rows(x).Cells(7).Value

        Catch ex As Exception
        End Try
    End Sub


    Private Sub BtnPERBAIKI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPERBAIKI.Click
        Call konek()

        strcon = "UPDATE t_lembur SET " _
        + "nik = '" & txtnik.Text & "'," _
        + "nama_karyawan = '" & txtNAMAKARYAWAN.Text & "'," _
        + "id_jabatan = '" & cmdIDJABATAN.Text & "'," _
        + "tgl_lembur = '" & DTTGLLEMBUR.Text & "'," _
        + "jum_jam_lembur = '" & txtJUMJAMLEMBUR.Text & "'," _
        + "uang_lembur = '" & txtUANGLEMBUR.Text & "'," _
        + "total_uang_lembur = '" & txtTOTALUANGLEMBUR.Text & "'" _
        + " WHERE id_lembur = '" & TxtIDLEMBUR.Text & "'"
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

    Private Sub txtTOTALUANGLEMBUR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTOTALUANGLEMBUR.KeyPress
        If Asc(e.KeyChar) = 13 Then

            BtnSIMPAN.Focus()

        End If
    End Sub

    Sub kosongkan()

        txtnik.Text = ""
        cmdIDJABATAN.Text = ""
        txtNAMAKARYAWAN.Clear()
        txtJUMJAMLEMBUR.Clear()
        txtUANGLEMBUR.Clear()
        txtTOTALUANGLEMBUR.Clear()

    End Sub
   

    Private Sub cmdIDJABATAN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIDJABATAN.SelectedIndexChanged
        'UNTUK ID OTOMATIS
        konek()
        cmd = New Odbc.OdbcCommand("SELECT nama_jabatan,gaji_pokok FROM t_jabatan WHERE id_jabatan = '" & cmdIDJABATAN.Text & "'", conn)

        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtNAMAJABATAN.Text = rd(0).ToString
            txtgajipokok.Text = rd(1).ToString
        End If
    End Sub

    Private Sub CMBNIK_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'UNTUK ID OTOMATIS
        ' konek()
        ' cmd = New Odbc.OdbcCommand("SELECT nama,tempat_lahir FROM t_karyawan WHERE nik = '" & CMBNIK.Text & "'", conn)

        ' rd = cmd.ExecuteReader
        ' rd.Read()
        'If rd.HasRows Then
        ' Txtnama.Text = rd(0).ToString
        'Txttempatlahir.Text = rd(1).ToString
        ' End If
    End Sub

    Private Sub txtnik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnik.KeyPress
        If (e.KeyChar = Chr(13)) Then
            konek()
            cmd = New Odbc.OdbcCommand("SELECT * FROM t_Karyawan WHERE nik ='" & txtnik.Text & "'", conn)
            rd = cmd.ExecuteReader
            If rd.Read Then
                Txtnama.Text = rd(1).ToString
                cmdIDJABATAN.Text = rd(12).ToString
            Else
                'exit sub
                MsgBox("TIDAK DITEMUKAN")
                txtnik.Focus()
                txtnik.Clear()
            End If
            txtnik.Focus()
        End If


    End Sub

    Private Sub txtUANGLEMBUR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUANGLEMBUR.TextChanged
        'untuk total uang lembur otomatis
        txtTOTALUANGLEMBUR.Text = Val(txtJUMJAMLEMBUR.Text) * Val(txtUANGLEMBUR.Text)
    End Sub
    Private Sub txtTOTALUANGLEMBUR_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTOTALUANGLEMBUR.TextChanged
        'untuk total uang lembur otomatis
        txtTOTALUANGLEMBUR.Text = Val(txtJUMJAMLEMBUR.Text) * Val(txtUANGLEMBUR.Text)
    End Sub
End Class