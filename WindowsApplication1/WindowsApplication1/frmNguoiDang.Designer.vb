<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNguoiDang
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.txtDienThoai = New System.Windows.Forms.TextBox()
        Me.lblTen = New System.Windows.Forms.Label()
        Me.txtTen = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDienThoai = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(309, 39)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(102, 17)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Mã người đăng:"
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.Blue
        Me.txtID.Location = New System.Drawing.Point(461, 36)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtID.Size = New System.Drawing.Size(53, 25)
        Me.txtID.TabIndex = 3
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grdData
        '
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Location = New System.Drawing.Point(12, 150)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(508, 153)
        Me.grdData.TabIndex = 2
        '
        'txtDienThoai
        '
        Me.txtDienThoai.Location = New System.Drawing.Point(399, 67)
        Me.txtDienThoai.Name = "txtDienThoai"
        Me.txtDienThoai.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDienThoai.Size = New System.Drawing.Size(115, 25)
        Me.txtDienThoai.TabIndex = 4
        Me.txtDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTen
        '
        Me.lblTen.AutoSize = True
        Me.lblTen.Location = New System.Drawing.Point(18, 39)
        Me.lblTen.Name = "lblTen"
        Me.lblTen.Size = New System.Drawing.Size(104, 17)
        Me.lblTen.TabIndex = 0
        Me.lblTen.Text = "Tên người đăng:"
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(133, 36)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTen.Size = New System.Drawing.Size(165, 25)
        Me.txtTen.TabIndex = 1
        Me.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(18, 70)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email:"
        '
        'lblDienThoai
        '
        Me.lblDienThoai.AutoSize = True
        Me.lblDienThoai.Location = New System.Drawing.Point(309, 70)
        Me.lblDienThoai.Name = "lblDienThoai"
        Me.lblDienThoai.Size = New System.Drawing.Size(70, 17)
        Me.lblDienThoai.TabIndex = 0
        Me.lblDienThoai.Text = "Điện thoại:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(133, 67)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmail.Size = New System.Drawing.Size(165, 25)
        Me.txtEmail.TabIndex = 2
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(148, 118)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 26)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(229, 118)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 26)
        Me.btnSua.TabIndex = 6
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(310, 118)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 26)
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'frmNguoiDang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(532, 315)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblDienThoai)
        Me.Controls.Add(Me.txtTen)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtDienThoai)
        Me.Controls.Add(Me.lblTen)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmNguoiDang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin người đăng"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents txtDienThoai As System.Windows.Forms.TextBox
    Friend WithEvents lblTen As System.Windows.Forms.Label
    Friend WithEvents txtTen As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblDienThoai As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
End Class
