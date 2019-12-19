Public Class frm_menu

    Private Sub DaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DaToolStripMenuItem.Click

    End Sub

    Private Sub DataKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub LemburToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LemburToolStripMenuItem.Click
        Frm_lembur.Show()
    End Sub

    Private Sub JabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JabatanToolStripMenuItem.Click
        frm_jabatan.Show()
    End Sub

    Private Sub GajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GajiToolStripMenuItem.Click
        Frm_gaji.Show()
    End Sub

    Private Sub CetakJabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakJabatanToolStripMenuItem.Click
        frm_cetak_jabatan.Show()
    End Sub

    Private Sub RekapGajiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RekapGajiToolStripMenuItem.Click
        frm_cetak_rekapgaji.Show()
    End Sub

    Private Sub AbsenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsenToolStripMenuItem.Click
        frm_absensi.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class