<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnLoaiNha = New System.Windows.Forms.Button()
        Me.btnDanhSachNhaTro = New System.Windows.Forms.Button()
        Me.btnNguoiDang = New System.Windows.Forms.Button()
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLoaiNha
        '
        Me.btnLoaiNha.Image = CType(resources.GetObject("btnLoaiNha.Image"), System.Drawing.Image)
        Me.btnLoaiNha.Location = New System.Drawing.Point(159, 147)
        Me.btnLoaiNha.Name = "btnLoaiNha"
        Me.btnLoaiNha.Size = New System.Drawing.Size(90, 90)
        Me.btnLoaiNha.TabIndex = 3
        Me.btnLoaiNha.Text = "Loại nhà"
        Me.btnLoaiNha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLoaiNha.UseVisualStyleBackColor = True
        '
        'btnDanhSachNhaTro
        '
        Me.btnDanhSachNhaTro.Image = CType(resources.GetObject("btnDanhSachNhaTro.Image"), System.Drawing.Image)
        Me.btnDanhSachNhaTro.Location = New System.Drawing.Point(282, 147)
        Me.btnDanhSachNhaTro.Name = "btnDanhSachNhaTro"
        Me.btnDanhSachNhaTro.Size = New System.Drawing.Size(90, 90)
        Me.btnDanhSachNhaTro.TabIndex = 4
        Me.btnDanhSachNhaTro.Text = "Danh sách nhà trọ"
        Me.btnDanhSachNhaTro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDanhSachNhaTro.UseVisualStyleBackColor = True
        '
        'btnNguoiDang
        '
        Me.btnNguoiDang.Image = CType(resources.GetObject("btnNguoiDang.Image"), System.Drawing.Image)
        Me.btnNguoiDang.Location = New System.Drawing.Point(36, 147)
        Me.btnNguoiDang.Name = "btnNguoiDang"
        Me.btnNguoiDang.Size = New System.Drawing.Size(90, 90)
        Me.btnNguoiDang.TabIndex = 2
        Me.btnNguoiDang.Text = "Người đăng"
        Me.btnNguoiDang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnNguoiDang.UseVisualStyleBackColor = True
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Image = CType(resources.GetObject("btnDangNhap.Image"), System.Drawing.Image)
        Me.btnDangNhap.Location = New System.Drawing.Point(36, 31)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(90, 90)
        Me.btnDangNhap.TabIndex = 1
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(282, 31)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(90, 90)
        Me.btnThoat.TabIndex = 5
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(392, 271)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Controls.Add(Me.btnNguoiDang)
        Me.Controls.Add(Me.btnDanhSachNhaTro)
        Me.Controls.Add(Me.btnLoaiNha)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý nhà trọ"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoaiNha As System.Windows.Forms.Button
    Friend WithEvents btnDanhSachNhaTro As System.Windows.Forms.Button
    Friend WithEvents btnNguoiDang As System.Windows.Forms.Button
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
End Class
