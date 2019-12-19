
Public Class frm_jabatan

    Private Sub frm_jabatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        konek()
        da = New Odbc.OdbcDataAdapter("select * from t_jabatan", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_jabatan")
        DataGridView1.DataSource = (ds.Tables("t_jabatan"))
    End Sub
    Sub datauser()
        da = New Odbc.OdbcDataAdapter("select * from t_jabatan", conn)
        ds = New DataSet
        da.Fill(ds, "t_jabatan")
        DataGridView1.DataSource = ds.Tables("t_jabatan")
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub BtnHAPUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHAPUS.Click
        If MsgBox("Apa Anda Yakin Menghapus Data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strcon = "DELETE FROM t_jabatan WHERE id_jabatan = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

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

        'konek()
        'strcon = "INSERT INTO t_jabatan " _
        '+ "VALUES (''," _
        '+ "'" & TextBoxNAMAJABATAN.Text & "'," _
        '+ "'" & TextBoxGAJIPOKOK.Text & "')"

        'MsgBox(strcon)

        'Dim cmd As New Odbc.OdbcCommand
        'cmd.Connection = conn
        'cmd.CommandText = strcon
        'cmd.ExecuteNonQuery()
        'conn.Close()
        'MsgBox("DATA BERHASIL DISIMPAN", MsgBoxStyle.Information)

        Call konek()
        If TextBoxNAMAJABATAN.Text = "" Or TextBoxGAJIPOKOK.Text = "" Then
            MsgBox("Data Harus Diisi", MsgBoxStyle.OkOnly)
        Else
            strcon = "select * from t_jabatan WHERE nama_jabatan = '" & TextBoxNAMAJABATAN.Text & "'"
            cmd = New Odbc.OdbcCommand(strcon, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                strcon = "INSERT INTO t_jabatan " _
                + "VALUES ('','" & TextBoxNAMAJABATAN.Text & "'," _
                + "'" & TextBoxGAJIPOKOK.Text & "')"
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub set_editjabatan(ByVal x As Integer)
        Try
            TextBoxID.Text = DataGridView1.Rows(x).Cells(0).Value
            TextBoxNAMAJABATAN.Text = DataGridView1.Rows(x).Cells(1).Value
            TextBoxGAJIPOKOK.Text = DataGridView1.Rows(x).Cells(2).Value
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BtnPERBAIKI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPERBAIKI.Click
        Call konek()

        strcon = "UPDATE t_jabatan SET " _
        + "nama_jabatan = '" & TextBoxNAMAJABATAN.Text & "'," _
        + "gaji_pokok = '" & TextBoxGAJIPOKOK.Text & "'" _
        + " WHERE id_jabatan = '" & TextBoxID.Text & "'"
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

    Private Sub TextBoxNAMAJABATAN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxNAMAJABATAN.KeyPress
       
    End Sub

    Private Sub TextBoxGAJIPOKOK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxGAJIPOKOK.KeyPress
        If Asc(e.KeyChar) = 13 Then

            BtnSIMPAN.Focus()

        End If
    End Sub

    Private Sub TextBoxGAJIPOKOK_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxGAJIPOKOK.TextChanged

    End Sub

    Sub kosongkan()

        TextBoxNAMAJABATAN.Clear()
        TextBoxGAJIPOKOK.Clear()

    End Sub

    Private Sub TextBoxNAMAJABATAN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxNAMAJABATAN.TextChanged

    End Sub

    Private Sub TextBoxID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxID.TextChanged
      
    End Sub

End Class