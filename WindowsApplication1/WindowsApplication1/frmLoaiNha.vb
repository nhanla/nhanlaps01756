Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmLoaiNha
    'Khai báo chuoiketnoi để tạo chuỗi kết nối
    Dim chuoiketnoi As String = "workstation id=quanlynhatro.mssql.somee.com;packet size=4096;user id=nhanlaps01756_SQLLogin_1;pwd=n2u5hww4xo;data source=quanlynhatro.mssql.somee.com;persist security info=False;initial catalog=quanlynhatro"
    'Khai báo ketnoi để tạo kết nối thông qua chuỗi
    Dim ketnoi As SqlConnection = New SqlConnection(chuoiketnoi)

    Private Sub frmLoaiNha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Khai báo truyvan để thực hiện truy vấn
        Dim truyvan As SqlDataAdapter = New SqlDataAdapter("select MaLoaiNha as 'Mã loại nhà', Mota As 'Mô tả' from LoaiNha", ketnoi)

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
        txtLoaiNha.Text = grdData.Item(0, index).Value
        txtMota.Text = grdData.Item(1, index).Value
    End Sub



    'Sự kiện nút btnThem
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        'Khai báo csdl để tạo bảng dữ liệu
        Dim csdl As New DataTable
        grdData.DataSource = "" 'làm rỗng grdData
        '
        
        Try
            'Tạo truy vấn
            Dim truyvan_them As SqlDataAdapter = New SqlDataAdapter("insert into LoaiNha values(N'" & txtMota.Text & "')", ketnoi)
            'Mở kết nối
            ketnoi.Open()
            'Thêm đầy dữ liệu vào bảng csdl
            truyvan_them.Fill(csdl)

        Catch ex As Exception

        End Try
        Dim truyvan_xem As SqlDataAdapter = New SqlDataAdapter("select MaLoaiNha as 'Mã loại nhà', Mota As 'Mô tả' from LoaiNha", ketnoi)
        truyvan_xem.Fill(csdl)
        grdData.DataSource = csdl.DefaultView
        ketnoi.Close()
    End Sub



    'Sự kiện nút btnSua
    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        'Tạo bảng csdl
        Dim csdl As New DataTable
        'Mở kết nối
        ketnoi.Open()
        'Truy vấn
        Dim truyvan_sua As String = "update loainha set  mota=@mota where maloainha=@loainha"

        Dim com As New SqlCommand(truyvan_sua, ketnoi)

        Try
            'Thêm dữ liệu
            com.Parameters.AddWithValue("@loainha", txtLoaiNha.Text)
            com.Parameters.AddWithValue("@mota", txtMota.Text)

            'Thực thi truy vấn và sửa dữ liệu
            com.ExecuteNonQuery()

            'Đóng kết nối
            ketnoi.Close()

            'Làm rỗng textbox sau khi thực thi
            txtLoaiNha.Text = ""
            txtMota.Text = ""

        Catch ex As Exception
            MessageBox.Show("Lỗi kết nối không thành công!")
        End Try

        Dim truyvan As SqlDataAdapter = New SqlDataAdapter("select MaLoaiNha as 'Mã loại nhà', Mota As 'Mô tả' from LoaiNha", ketnoi)
        truyvan.Fill(csdl)
        grdData.DataSource = csdl.DefaultView
        ketnoi.Close()
    End Sub



    'Sự kiện nút btnXoa
    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim csdl As New DataTable

        ketnoi.Open()

        Dim truyvan_xoa As String = "delete from LoaiNha where maloainha=@loainha"

        Dim com As New SqlCommand(truyvan_xoa, ketnoi)
        Try
            com.Parameters.AddWithValue("@loainha", txtLoaiNha.Text)

            com.ExecuteNonQuery()
            txtLoaiNha.Text = ""
            txtMota.Text = ""

        Catch ex As Exception
            MsgBox("Lỗi không thể kết nối tới cơ sở dữ liệu!", MsgBoxStyle.OkCancel)
        End Try
        '
        Dim truyvan As SqlDataAdapter = New SqlDataAdapter("select MaLoaiNha as 'Mã loại nhà', Mota As 'Mô tả' from LoaiNha", ketnoi)
        truyvan.Fill(csdl)
        grdData.DataSource = csdl.DefaultView

        ketnoi.Close()
    End Sub
End Class