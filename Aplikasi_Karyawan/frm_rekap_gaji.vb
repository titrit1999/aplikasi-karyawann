Imports CrystalDecisions.CrystalReports.Engine

Public Class frm_rekap_gaji

    Private Sub frm_rekap_gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Report_detail As New ReportDocument
        Report_detail.Load("..\..\cr_rekapgaji.rpt")

        Report_detail.SetParameterValue("dari", dtp_dari.Text)
        Report_detail.SetParameterValue("sampai", dtp_sampai.Text)

        frm_cetak_rekapgaji.CrystalReportViewer1.ReportSource = Report_detail
        frm_cetak_rekapgaji.CrystalReportViewer1.Refresh()
        frm_cetak_rekapgaji.Show()

    End Sub
End Class