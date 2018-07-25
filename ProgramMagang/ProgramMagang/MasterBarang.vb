Public Class MasterBarang
    Private Sub MasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub
    Private Sub MasterBarangJadiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterBarangJadiToolStripMenuItem.Click
        MasterBarangJadi.IsMdiContainer = True
        MasterBarangJadi.Show()
    End Sub
    Private Sub MasterBahanBakuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterBahanBakuToolStripMenuItem.Click
        MasterBahanBaku.IsMdiContainer = True
        MasterBahanBaku.Show()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
        MainMenu.Show()
    End Sub
End Class