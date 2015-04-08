Public Class frmMain

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnNguoiDang.Click
        frmNguoiDang.Show()
    End Sub

    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        frmDangNhap.Show()
        Me.Close()
    End Sub

    Private Sub btnLoaiNha_Click(sender As Object, e As EventArgs) Handles btnLoaiNha.Click
        frmLoaiNha.Show()
    End Sub

    Private Sub btnDanhSachNhaTro_Click(sender As Object, e As EventArgs) Handles btnDanhSachNhaTro.Click
        frmNhaTro.Show()
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub

End Class