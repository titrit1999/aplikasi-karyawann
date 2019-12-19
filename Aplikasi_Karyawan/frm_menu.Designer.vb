<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbsenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LemburToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JabatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakLaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CetakJabatanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RekapGajiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DaToolStripMenuItem, Me.CetakLaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbsenToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AbsenToolStripMenuItem
        '
        Me.AbsenToolStripMenuItem.Image = CType(resources.GetObject("AbsenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbsenToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AbsenToolStripMenuItem.Name = "AbsenToolStripMenuItem"
        Me.AbsenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AbsenToolStripMenuItem.Text = "Absen"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'DaToolStripMenuItem
        '
        Me.DaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataKaryawanToolStripMenuItem, Me.LemburToolStripMenuItem, Me.JabatanToolStripMenuItem, Me.GajiToolStripMenuItem})
        Me.DaToolStripMenuItem.Image = CType(resources.GetObject("DaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DaToolStripMenuItem.Name = "DaToolStripMenuItem"
        Me.DaToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.DaToolStripMenuItem.Text = "Data Master"
        '
        'DataKaryawanToolStripMenuItem
        '
        Me.DataKaryawanToolStripMenuItem.Image = CType(resources.GetObject("DataKaryawanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DataKaryawanToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DataKaryawanToolStripMenuItem.Name = "DataKaryawanToolStripMenuItem"
        Me.DataKaryawanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DataKaryawanToolStripMenuItem.Text = "Data Karyawan"
        '
        'LemburToolStripMenuItem
        '
        Me.LemburToolStripMenuItem.Image = CType(resources.GetObject("LemburToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LemburToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LemburToolStripMenuItem.Name = "LemburToolStripMenuItem"
        Me.LemburToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LemburToolStripMenuItem.Text = "Lembur"
        '
        'JabatanToolStripMenuItem
        '
        Me.JabatanToolStripMenuItem.Image = CType(resources.GetObject("JabatanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JabatanToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.JabatanToolStripMenuItem.Name = "JabatanToolStripMenuItem"
        Me.JabatanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JabatanToolStripMenuItem.Text = "Jabatan"
        '
        'GajiToolStripMenuItem
        '
        Me.GajiToolStripMenuItem.Image = CType(resources.GetObject("GajiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GajiToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GajiToolStripMenuItem.Name = "GajiToolStripMenuItem"
        Me.GajiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GajiToolStripMenuItem.Text = "Gaji"
        '
        'CetakLaporanToolStripMenuItem
        '
        Me.CetakLaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CetakJabatanToolStripMenuItem, Me.RekapGajiToolStripMenuItem})
        Me.CetakLaporanToolStripMenuItem.Image = CType(resources.GetObject("CetakLaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CetakLaporanToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CetakLaporanToolStripMenuItem.Name = "CetakLaporanToolStripMenuItem"
        Me.CetakLaporanToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.CetakLaporanToolStripMenuItem.Text = "Cetak Laporan"
        '
        'CetakJabatanToolStripMenuItem
        '
        Me.CetakJabatanToolStripMenuItem.Image = CType(resources.GetObject("CetakJabatanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CetakJabatanToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CetakJabatanToolStripMenuItem.Name = "CetakJabatanToolStripMenuItem"
        Me.CetakJabatanToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CetakJabatanToolStripMenuItem.Text = "Cetak Jabatan"
        '
        'RekapGajiToolStripMenuItem
        '
        Me.RekapGajiToolStripMenuItem.Image = CType(resources.GetObject("RekapGajiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RekapGajiToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RekapGajiToolStripMenuItem.Name = "RekapGajiToolStripMenuItem"
        Me.RekapGajiToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.RekapGajiToolStripMenuItem.Text = "Rekap Gaji"
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(784, 594)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_menu"
        Me.Text = "MENU  UTAMA"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbsenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LemburToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JabatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GajiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakLaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CetakJabatanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekapGajiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
