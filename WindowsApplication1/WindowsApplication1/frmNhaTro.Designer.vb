<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhaTro
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
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.lblGia = New System.Windows.Forms.Label()
        Me.txtDienTich = New System.Windows.Forms.TextBox()
        Me.txtMota = New System.Windows.Forms.TextBox()
        Me.lblMaNhaTro = New System.Windows.Forms.Label()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.txtMaNhaTro = New System.Windows.Forms.TextBox()
        Me.lblDienTich = New System.Windows.Forms.Label()
        Me.lblMoTa = New System.Windows.Forms.Label()
        Me.lblNguoiDang = New System.Windows.Forms.Label()
        Me.txtGiaPhong = New System.Windows.Forms.TextBox()
        Me.txtNguoiDang = New System.Windows.Forms.TextBox()
        Me.lblmet = New System.Windows.Forms.Label()
        Me.lblVND = New System.Windows.Forms.Label()
        Me.txtMaNguoiDang = New System.Windows.Forms.TextBox()
        Me.txtMaLoaiNha = New System.Windows.Forms.TextBox()
        Me.lblMaNguoiDang = New System.Windows.Forms.Label()
        Me.lblMaLoaiNha = New System.Windows.Forms.Label()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(282, 162)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 26)
        Me.btnXoa.TabIndex = 6
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(201, 162)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 26)
        Me.btnSua.TabIndex = 5
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(161, 162)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 26)
        Me.btnThem.TabIndex = 17
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        Me.btnThem.Visible = False
        '
        'lblGia
        '
        Me.lblGia.AutoSize = True
        Me.lblGia.Location = New System.Drawing.Point(290, 29)
        Me.lblGia.Name = "lblGia"
        Me.lblGia.Size = New System.Drawing.Size(72, 17)
        Me.lblGia.TabIndex = 8
        Me.lblGia.Text = "Giá phòng:"
        '
        'txtDienTich
        '
        Me.txtDienTich.Location = New System.Drawing.Point(378, 57)
        Me.txtDienTich.Name = "txtDienTich"
        Me.txtDienTich.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDienTich.Size = New System.Drawing.Size(53, 25)
        Me.txtDienTich.TabIndex = 3
        Me.txtDienTich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMota
        '
        Me.txtMota.Location = New System.Drawing.Point(378, 88)
        Me.txtMota.Multiline = True
        Me.txtMota.Name = "txtMota"
        Me.txtMota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMota.Size = New System.Drawing.Size(161, 50)
        Me.txtMota.TabIndex = 4
        '
        'lblMaNhaTro
        '
        Me.lblMaNhaTro.AutoSize = True
        Me.lblMaNhaTro.Location = New System.Drawing.Point(26, 29)
        Me.lblMaNhaTro.Name = "lblMaNhaTro"
        Me.lblMaNhaTro.Size = New System.Drawing.Size(76, 17)
        Me.lblMaNhaTro.TabIndex = 10
        Me.lblMaNhaTro.Text = "Mã nhà trọ:"
        '
        'grdData
        '
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Location = New System.Drawing.Point(12, 194)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(534, 150)
        Me.grdData.TabIndex = 7
        '
        'txtMaNhaTro
        '
        Me.txtMaNhaTro.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaNhaTro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaNhaTro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaNhaTro.ForeColor = System.Drawing.Color.Red
        Me.txtMaNhaTro.HideSelection = False
        Me.txtMaNhaTro.Location = New System.Drawing.Point(134, 26)
        Me.txtMaNhaTro.Name = "txtMaNhaTro"
        Me.txtMaNhaTro.ReadOnly = True
        Me.txtMaNhaTro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaNhaTro.Size = New System.Drawing.Size(93, 25)
        Me.txtMaNhaTro.TabIndex = 15
        Me.txtMaNhaTro.TabStop = False
        Me.txtMaNhaTro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDienTich
        '
        Me.lblDienTich.AutoSize = True
        Me.lblDienTich.Location = New System.Drawing.Point(290, 60)
        Me.lblDienTich.Name = "lblDienTich"
        Me.lblDienTich.Size = New System.Drawing.Size(61, 17)
        Me.lblDienTich.TabIndex = 11
        Me.lblDienTich.Text = "Diện tích:"
        '
        'lblMoTa
        '
        Me.lblMoTa.AutoSize = True
        Me.lblMoTa.Location = New System.Drawing.Point(290, 91)
        Me.lblMoTa.Name = "lblMoTa"
        Me.lblMoTa.Size = New System.Drawing.Size(46, 17)
        Me.lblMoTa.TabIndex = 20
        Me.lblMoTa.Text = "Mô tả:"
        '
        'lblNguoiDang
        '
        Me.lblNguoiDang.AutoSize = True
        Me.lblNguoiDang.Location = New System.Drawing.Point(26, 122)
        Me.lblNguoiDang.Name = "lblNguoiDang"
        Me.lblNguoiDang.Size = New System.Drawing.Size(82, 17)
        Me.lblNguoiDang.TabIndex = 21
        Me.lblNguoiDang.Text = "Người đăng:"
        '
        'txtGiaPhong
        '
        Me.txtGiaPhong.Location = New System.Drawing.Point(378, 26)
        Me.txtGiaPhong.Name = "txtGiaPhong"
        Me.txtGiaPhong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGiaPhong.Size = New System.Drawing.Size(99, 25)
        Me.txtGiaPhong.TabIndex = 2
        Me.txtGiaPhong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNguoiDang
        '
        Me.txtNguoiDang.Location = New System.Drawing.Point(134, 119)
        Me.txtNguoiDang.Name = "txtNguoiDang"
        Me.txtNguoiDang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNguoiDang.Size = New System.Drawing.Size(140, 25)
        Me.txtNguoiDang.TabIndex = 1
        Me.txtNguoiDang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblmet
        '
        Me.lblmet.AutoSize = True
        Me.lblmet.Location = New System.Drawing.Point(437, 63)
        Me.lblmet.Name = "lblmet"
        Me.lblmet.Size = New System.Drawing.Size(26, 17)
        Me.lblmet.TabIndex = 24
        Me.lblmet.Text = "m2"
        '
        'lblVND
        '
        Me.lblVND.AutoSize = True
        Me.lblVND.Location = New System.Drawing.Point(483, 29)
        Me.lblVND.Name = "lblVND"
        Me.lblVND.Size = New System.Drawing.Size(35, 17)
        Me.lblVND.TabIndex = 25
        Me.lblVND.Text = "VNĐ"
        '
        'txtMaNguoiDang
        '
        Me.txtMaNguoiDang.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaNguoiDang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaNguoiDang.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaNguoiDang.ForeColor = System.Drawing.Color.Blue
        Me.txtMaNguoiDang.Location = New System.Drawing.Point(134, 88)
        Me.txtMaNguoiDang.Name = "txtMaNguoiDang"
        Me.txtMaNguoiDang.ReadOnly = True
        Me.txtMaNguoiDang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaNguoiDang.Size = New System.Drawing.Size(93, 25)
        Me.txtMaNguoiDang.TabIndex = 29
        Me.txtMaNguoiDang.TabStop = False
        Me.txtMaNguoiDang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMaLoaiNha
        '
        Me.txtMaLoaiNha.BackColor = System.Drawing.SystemColors.Control
        Me.txtMaLoaiNha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaLoaiNha.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtMaLoaiNha.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtMaLoaiNha.HideSelection = False
        Me.txtMaLoaiNha.Location = New System.Drawing.Point(134, 57)
        Me.txtMaLoaiNha.Name = "txtMaLoaiNha"
        Me.txtMaLoaiNha.ReadOnly = True
        Me.txtMaLoaiNha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMaLoaiNha.Size = New System.Drawing.Size(93, 25)
        Me.txtMaLoaiNha.TabIndex = 28
        Me.txtMaLoaiNha.TabStop = False
        Me.txtMaLoaiNha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMaNguoiDang
        '
        Me.lblMaNguoiDang.AutoSize = True
        Me.lblMaNguoiDang.Location = New System.Drawing.Point(26, 91)
        Me.lblMaNguoiDang.Name = "lblMaNguoiDang"
        Me.lblMaNguoiDang.Size = New System.Drawing.Size(102, 17)
        Me.lblMaNguoiDang.TabIndex = 27
        Me.lblMaNguoiDang.Text = "Mã người đăng:"
        '
        'lblMaLoaiNha
        '
        Me.lblMaLoaiNha.AutoSize = True
        Me.lblMaLoaiNha.Location = New System.Drawing.Point(26, 60)
        Me.lblMaLoaiNha.Name = "lblMaLoaiNha"
        Me.lblMaLoaiNha.Size = New System.Drawing.Size(80, 17)
        Me.lblMaLoaiNha.TabIndex = 26
        Me.lblMaLoaiNha.Text = "Mã loại nhà:"
        '
        'frmNhaTro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(558, 356)
        Me.Controls.Add(Me.txtMaNguoiDang)
        Me.Controls.Add(Me.txtMaLoaiNha)
        Me.Controls.Add(Me.lblMaNguoiDang)
        Me.Controls.Add(Me.lblMaLoaiNha)
        Me.Controls.Add(Me.lblVND)
        Me.Controls.Add(Me.lblmet)
        Me.Controls.Add(Me.txtNguoiDang)
        Me.Controls.Add(Me.txtGiaPhong)
        Me.Controls.Add(Me.lblNguoiDang)
        Me.Controls.Add(Me.lblMoTa)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.lblGia)
        Me.Controls.Add(Me.txtDienTich)
        Me.Controls.Add(Me.txtMota)
        Me.Controls.Add(Me.lblMaNhaTro)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.txtMaNhaTro)
        Me.Controls.Add(Me.lblDienTich)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmNhaTro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin nhà trọ"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents lblGia As System.Windows.Forms.Label
    Friend WithEvents txtDienTich As System.Windows.Forms.TextBox
    Friend WithEvents txtMota As System.Windows.Forms.TextBox
    Friend WithEvents lblMaNhaTro As System.Windows.Forms.Label
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaNhaTro As System.Windows.Forms.TextBox
    Friend WithEvents lblDienTich As System.Windows.Forms.Label
    Friend WithEvents lblMoTa As System.Windows.Forms.Label
    Friend WithEvents lblNguoiDang As System.Windows.Forms.Label
    Friend WithEvents txtGiaPhong As System.Windows.Forms.TextBox
    Friend WithEvents txtNguoiDang As System.Windows.Forms.TextBox
    Friend WithEvents lblmet As System.Windows.Forms.Label
    Friend WithEvents lblVND As System.Windows.Forms.Label
    Friend WithEvents txtMaNguoiDang As System.Windows.Forms.TextBox
    Friend WithEvents txtMaLoaiNha As System.Windows.Forms.TextBox
    Friend WithEvents lblMaNguoiDang As System.Windows.Forms.Label
    Friend WithEvents lblMaLoaiNha As System.Windows.Forms.Label
End Class
