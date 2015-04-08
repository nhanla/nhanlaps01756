Imports System.Data.SqlClient
Imports System.Data.DataTable


Public Class frmNguoiDang
    'Khai báo chuoiketnoi để tạo chuỗi kết nối
    Dim chuoiketnoi As String = "workstation id=quanlynhatro.mssql.somee.com;packet size=4096;user id=nhanlaps01756_SQLLogin_1;pwd=n2u5hww4xo;data source=quanlynhatro.mssql.somee.com;persist security info=False;initial catalog=quanlynhatro"
    'Khai báo ketnoi để tạo kết nối thông qua chuỗi
    Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)


    'Sự kiện load frmNguoiDang 
    Private Sub frmNguoiDang_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Khai báo truyvan để thực hiện truy vấn
        Dim truyvan As SqlDataAdapter = New SqlDataAdapter("select MaNguoiDang as 'Mã người đăng', NguoiDang as 'Người đăng', Email, SDT from NguoiDang", ketnoi)

        'Khai báo csdl để tạo bảng dữ liệu
        Dim csdl As New DataTable
        Try
            'Mở ketnoi
            ketnoi.Open()
            'Điền dữ liệu từ truyvan vào bảng csdl
            truyvan.Fill(csdl)
        Catch ex As Exception

        End Try
        grdData.DataSource = csdl.DefaultView
        ketnoi.Close()
    End Sub



    Private Sub grdData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellClick
        Dim index As Integer = grdData.CurrentCell.RowIndex
        txtID.Text = grdData.Item(0, index).Value
        txtTen.Text = grdData.Item(1, index).Value
        txtEmail.Text = grdData.Item(2, index).Value
        txtDienThoai.Text = grdData.Item(3, index).Value
    End Sub



    'Sự kiện btnThem
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        'Khai báo csdl để tạo bảng dữ liệu
        Dim csdl As New DataTable
        'Mở kết nối
        ketnoi.Open()
        grdData.DataSource = "" 'làm rỗng grdData
        Try
            'Thực hiện thêm dữ liệu vào bảng
            Dim truyvan_them As SqlDataAdapter = New SqlDataAdapter("insert into NguoiDang values( N'" & txtTen.Text & "','" & txtEmail.Text & "', '" & txtDienThoai.Text & "')", ketnoi)
            'Sau đó đổ dữ liệu về bảng csdl
            truyvan_them.Fill(csdl)
            'Đóng kết nối
            ketnoi.Close()
        Catch ex As Exception
            'Nếu gặp lỗi, hiện msgbox
            MessageBox.Show("Không nhập trùng Email")
        End Try

        'Sau khi thực thi xong, trả dữ liệu về bảng csdl
        Dim truyvan_xem As SqlDataAdapter = New SqlDataAdapter("select MaNguoiDang as 'Mã người đăng', NguoiDang as 'Người đăng', Email, SDT from NguoiDang", ketnoi)
        truyvan_xem.Fill(csdl)
        grdData.DataSource = csdl.DefaultView
        ketnoi.Close()

    End Sub



    'Sự kiện btnSua
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        Dim csdl As New DataTable
        'Mở kết nối
        ketnoi.Open()
        'Truy vấn
        Dim truyvan_sua As String = "update nguoidang set nguoidang = @nguoidang, email = @email, sdt = @sdt where manguoidang = @id"
        'Kết nối với truy vấn
        Dim com As New SqlCommand(truyvan_sua, ketnoi)
        '
        Try
            'Thêm dữ liệu
            com.Parameters.AddWithValue("@id", txtID.Text)
            com.Parameters.AddWithValue("@nguoidang", txtTen.Text)
            com.Parameters.AddWithValue("@email", txtEmail.Text)
            com.Parameters.AddWithValue("@sdt", txtDienThoai.Text)

            'Thực thi truy vấn và sửa dữ liệu
            com.ExecuteNonQuery()

            'Đóng kết nối
            ketnoi.Close()

            'Làm rỗng các textbox
            txtDienThoai.Text = ""
            txtEmail.Text = ""
            txtID.Text = ""
            txtTen.Text = ""

        Catch ex As Exception
            'Nếu gặp lỗi, hiện msgbox
            MessageBox.Show("Sửa dữ liệu không thành công")
        End Try
        'Sau khi thực thi xong, trả dữ liệu về bảng csdl
        Dim truyvan As SqlDataAdapter = New SqlDataAdapter("select MaNguoiDang as 'Mã người đăng', NguoiDang as 'Người đăng', Email, SDT from NguoiDang", ketnoi)
        truyvan.Fill(csdl)
        grdData.DataSource = csdl.DefaultView

        ketnoi.Close()

    End Sub


    'Sự kiện btnXoa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        'Tạo bảng csdl
        Dim csdl As New DataTable
        'Kết nối
        ketnoi.Open()
        'Tạo truy vấn
        Dim truyvan_xoa As String = "delete from Nguoidang where manguoidang=@id"
        'Kết nối với truy vấn
        Dim com As New SqlCommand(truyvan_xoa, ketnoi)
        Try
            com.Parameters.AddWithValue("@id", txtID.Text)
            'Thực thi truy vấn
            com.ExecuteNonQuery()
            'Sau khi thực thi, làm rỗng các textbox
            txtDienThoai.Text = ""
            txtEmail.Text = ""
            txtID.Text = ""
            txtTen.Text = ""
        Catch ex As Exception
            'Nếu gặp lỗi, hiện msgbox
            MessageBox.Show("Không có dữ liệu để xóa!")
        End Try
        'Sau khi thực thi xong, trả dữ liệu về bảng csdl
        Dim truyvan As SqlDataAdapter = New SqlDataAdapter("select MaNguoiDang as 'Mã người đăng', NguoiDang as 'Người đăng', Email, SDT from NguoiDang", ketnoi)
        truyvan.Fill(csdl)
        grdData.DataSource = csdl.DefaultView
        'Đóng kết nối
        ketnoi.Close()


    End Sub
End Class