Imports System.Data.SqlClient

Public Class frmDangNhap
    'Sự kiện click btnDangNhap
    Private Sub btnDangNhap_Click(sender As Object, e As EventArgs) Handles btnDangNhap.Click
        'Khai báo biến chuoiketnoi để tạo chuỗi kết nối
        Dim chuoiketnoi As String = "workstation id=quanlynhatro.mssql.somee.com;packet size=4096;user id=nhanlaps01756_SQLLogin_1;pwd=n2u5hww4xo;data source=quanlynhatro.mssql.somee.com;persist security info=False;initial catalog=quanlynhatro"

        'Khai báo biến ketnoi để tạo kết nối thông qua chuỗi kết nối
        Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)

        'Khai báo biến sqladapter thực hiện truy vấn
        Dim sqladapter As SqlDataAdapter = New SqlDataAdapter(" select * from TaiKhoan where TaiKhoan ='" & txtTaiKhoan.Text & "'and MatKhau='" & txtMatKhau.Text & "'", ketnoi)

        'Khai báo biến csdl là 1 bảng dữ liệu
        Dim csdl As New DataTable
        Try
            ketnoi.Open()
            sqladapter.Fill(csdl)
            If csdl.Rows.Count > 0 Then
                MsgBox("Đăng nhập thành công!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Thông báo")
                frmMain.Show()
                Me.Hide()
            Else
                MsgBox("Sai tài khoản hoặc mật khẩu!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Lỗi")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Application.Exit()
    End Sub


End Class
