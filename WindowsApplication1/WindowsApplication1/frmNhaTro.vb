Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmNhaTro
    'Khai báo chuoiketnoi để tạo chuỗi kết nối
    Dim chuoiketnoi As String = "workstation id=quanlynhatro.mssql.somee.com;packet size=4096;user id=nhanlaps01756_SQLLogin_1;pwd=n2u5hww4xo;data source=quanlynhatro.mssql.somee.com;persist security info=False;initial catalog=quanlynhatro"
    'Khai báo ketnoi để tạo kết nối thông qua chuỗi
    Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub txtGiaPhong_TextChanged(sender As Object, e As EventArgs) Handles txtGiaPhong.TextChanged
        txtGiaPhong.Text = FormatNumber(txtGiaPhong.Text, 0)

    End Sub

    'Sự kiện load frmNhaTro
    Private Sub frmNhaTro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tạo bảng csdl
        Dim csdl As New DataTable
       
        Try
            'Khai báo truyvan để thực hiện truy vấn
            Dim truyvan As SqlDataAdapter = New SqlDataAdapter("select MaNhaTro as 'Mã nhà trọ', DienTich as 'Diện tích',Mota as 'Mô tả',replace(CONVERT(varchar,giaphong,1),',','.') AS N'Giá phòng',NguoiDang as 'Người đăng',MaLoaiNha as 'Mã loại nhà', MaNguoiDang as 'Mã người đăng' from NhaTro join NguoiDang on Nhatro.NguoiDang_MaNguoiDang = NguoiDang.MaNguoiDang join LoaiNha on Nhatro.Loainha_MaLoaiNha = Loainha.MaLoaiNha", ketnoi)
            'Mở ketnoi
            ketnoi.Open()
            'Điền dữ liệu từ truyvan vào bảng csdl
            truyvan.Fill(csdl)
        Catch ex As Exception

        End Try
        grdData.DataSource = csdl.DefaultView
        ketnoi.Close()
    End Sub



    'Sự kiện click grdData
    Private Sub grdData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdData.CellClick
        Dim index As Integer = grdData.CurrentCell.RowIndex
        txtMaNhaTro.Text = grdData.Item(0, index).Value
        txtDienTich.Text = grdData.Item(1, index).Value
        txtMota.Text = grdData.Item(2, index).Value
        txtGiaPhong.Text = grdData.Item(3, index).Value
        txtNguoiDang.Text = grdData.Item(4, index).Value
        txtMaLoaiNha.Text = grdData.Item(5, index).Value
        txtMaNguoiDang.Text = grdData.Item(6, index).Value
    End Sub


    'Sự kiện nút btnSua
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Tạo bảng csdl
        Dim csdl As New DataTable
        'Mở kết nối
        ketnoi.Open()
        'Truy vấn
        Dim truyvan_sua1 As String = "update loainha set  mota=@mota where maloainha=@maloainha"
        Dim truyvan_sua2 As String = "update nguoidang set nguoidang=@nguoidang where manguoidang=@manguoidang"
        Dim truyvan_sua3 As String = "update nhatro set dientich=@dientich,giaphong=@giaphong where manhatro = @manhatro"

        Dim com1 As New SqlCommand(truyvan_sua1, ketnoi)
        Dim com2 As New SqlCommand(truyvan_sua2, ketnoi)
        Dim com3 As New SqlCommand(truyvan_sua3, ketnoi)

        Try
            'Thêm dữ liệu
            com1.Parameters.AddWithValue("@maloainha", txtMaLoaiNha.Text)
            com1.Parameters.AddWithValue("@mota", txtMota.Text)

            com2.Parameters.AddWithValue("@manguoidang", txtMaNguoiDang.Text)
            com2.Parameters.AddWithValue("@nguoidang", txtNguoiDang.Text)

            com3.Parameters.AddWithValue("@manhatro", txtMaNhaTro.Text)
            com3.Parameters.AddWithValue("@dientich", txtDienTich.Text)
            com3.Parameters.AddWithValue("@giaphong", txtGiaPhong.Text)

            'Thực thi truy vấn và sửa dữ liệu
            com1.ExecuteNonQuery()
            com2.ExecuteNonQuery()
            com3.ExecuteNonQuery()

            'Đóng kết nối
            ketnoi.Close()

            'Xóa textbox
            txtDienTich.Text = ""
            txtGiaPhong.Text = FormatNumber(0)
            txtMaLoaiNha.Text = ""
            txtMaNguoiDang.Text = ""
            txtMaNhaTro.Text = ""
            txtMota.Text = ""
            txtNguoiDang.Text = ""


        Catch ex As Exception
            MessageBox.Show("Lỗi!")
        End Try

        Dim truyvan As SqlDataAdapter = New SqlDataAdapter("select MaNhaTro as 'Mã nhà trọ', DienTich as 'Diện tích',Mota as 'Mô tả', GiaPhong AS 'Giá phòng',NguoiDang as 'Người đăng',MaLoaiNha as 'Mã loại nhà', MaNguoiDang as 'Mã người đăng' from NhaTro join NguoiDang on Nhatro.NguoiDang_MaNguoiDang = NguoiDang.MaNguoiDang join LoaiNha on Nhatro.Loainha_MaLoaiNha = Loainha.MaLoaiNha", ketnoi)
        truyvan.Fill(csdl)
        grdData.DataSource = csdl.DefaultView
        ketnoi.Close()
    End Sub



    'Sự kiện btnXoa

    

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim csdl As New DataTable

        ketnoi.Open()

        Dim truyvan_xoa As String = "delete from NhaTro where manhatro=@manhatro"

        Dim com As New SqlCommand(truyvan_xoa, ketnoi)
        Try
            com.Parameters.AddWithValue("@manhatro", txtMaNhaTro.Text)

            com.ExecuteNonQuery()

            'Xóa textbox
            txtDienTich.Text = ""
            txtGiaPhong.Text = ""
            txtMaLoaiNha.Text = ""
            txtMaNguoiDang.Text = ""
            txtMaNhaTro.Text = ""
            txtMota.Text = ""
            txtNguoiDang.Text = ""

        Catch ex As Exception
            MessageBox.Show("Lỗi không thể kết nối tới cơ sở dữ liệu!")
        End Try
        '
        Dim truyvan As SqlDataAdapter = New SqlDataAdapter("select MaNhaTro as 'Mã nhà trọ', DienTich as 'Diện tích',Mota as 'Mô tả', GiaPhong AS 'Giá phòng',NguoiDang as 'Người đăng',MaLoaiNha as 'Mã loại nhà', MaNguoiDang as 'Mã người đăng' from NhaTro join NguoiDang on Nhatro.NguoiDang_MaNguoiDang = NguoiDang.MaNguoiDang join LoaiNha on Nhatro.Loainha_MaLoaiNha = Loainha.MaLoaiNha", ketnoi)
        truyvan.Fill(csdl)
        grdData.DataSource = csdl.DefaultView

        ketnoi.Close()
    End Sub


End Class