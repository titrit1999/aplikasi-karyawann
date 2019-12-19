Public Class Form1


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ContextMenuStrip = ContextMenuStrip1
        konek()
        da = New Odbc.OdbcDataAdapter("select * from t_karyawan", conn)
        'da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "t_karyawan")
        DataGridView1.DataSource = (ds.Tables("t_karyawan"))
    End Sub
    Sub datauser()
        da = New Odbc.OdbcDataAdapter("select nik, nama, jabatan, tgl_masuk, status_kerja from t_karyawan", conn)
        ds = New DataSet
        da.Fill(ds, "t_karyawan")
        DataGridView1.DataSource = ds.Tables("t_karyawan")
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Private Sub form_edit(ByVal x As Integer)
        Try
            edit_karyawan.txtnik.Text = DataGridView1.Rows(x).Cells(0).Value
            edit_karyawan.txtnama.Text = DataGridView1.Rows(x).Cells(1).Value
            edit_karyawan.txttempatlahir.Text = DataGridView1.Rows(x).Cells(2).Value
            edit_karyawan.DTTANGGALLAHIR.Text = DataGridView1.Rows(x).Cells(3).Value
            edit_karyawan.cmbagama.Text = DataGridView1.Rows(x).Cells(4).Value
            edit_karyawan.cmbstatus.Text = DataGridView1.Rows(x).Cells(5).Value
            edit_karyawan.cmbkewarganegaraan.Text = DataGridView1.Rows(x).Cells(6).Value
            edit_karyawan.txtnohp.Text = DataGridView1.Rows(x).Cells(7).Value
            edit_karyawan.txtemail.Text = DataGridView1.Rows(x).Cells(8).Value
            edit_karyawan.txtalamat.Text = DataGridView1.Rows(x).Cells(9).Value
            edit_karyawan.CMDPENDIDIKANTERAKHIR.Text = DataGridView1.Rows(x).Cells(10).Value
            edit_karyawan.CMDPENDIDIKANTERAKHIR.Text = DataGridView1.Rows(x).Cells(11).Value
            edit_karyawan.txtjabatan.Text = DataGridView1.Rows(x).Cells(12).Value
            edit_karyawan.DTTANGGALMASUK.Text = DataGridView1.Rows(x).Cells(13).Value
            edit_karyawan.txtbagian.Text = DataGridView1.Rows(x).Cells(14).Value
            edit_karyawan.txtgaji.Text = DataGridView1.Rows(x).Cells(15).Value
            edit_karyawan.CMDSTATUSKARYAWAN.Text = DataGridView1.Rows(x).Cells(16).Value
            edit_karyawan.CMDSTATUSKERJA.Text = DataGridView1.Rows(x).Cells(17).Value
        Catch ex As Exception

        End Try
    End Sub
    Private Sub set_editkaryawan(ByVal x As Integer)
        Try
            edit_karyawan.txtnik.Text = DataGridView1.Rows(x).Cells(0).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        set_editkaryawan(e.RowIndex)
        Me.Visible = False
        edit_karyawan.Show()
    End Sub

    Private Sub Menu1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Menu1ToolStripMenuItem.Click
        If MsgBox("Apa Anda Yakin Menghapus Data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strcon = "DELETE FROM t_karyawan WHERE nik = '" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"

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

    Private Sub BtnINSERT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnINSERT.Click
        Me.Visible = False
        tambah_karyawan.Show()
    End Sub

    Private Sub BTNCLOSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCLOSE.Click
        Close()
    End Sub
End Class
