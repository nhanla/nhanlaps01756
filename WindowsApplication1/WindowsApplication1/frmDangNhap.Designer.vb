<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangNhap
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
        Me.btnDangNhap = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.txtMatKhau = New System.Windows.Forms.TextBox()
        Me.txtTaiKhoan = New System.Windows.Forms.TextBox()
        Me.lblTaiKhoan = New System.Windows.Forms.Label()
        Me.lblMatKhau = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDangNhap
        '
        Me.btnDangNhap.Location = New System.Drawing.Point(102, 131)
        Me.btnDangNhap.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDangNhap.Name = "btnDangNhap"
        Me.btnDangNhap.Size = New System.Drawing.Size(87, 30)
        Me.btnDangNhap.TabIndex = 3
        Me.btnDangNhap.Text = "Đăng nhập"
        Me.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDangNhap.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(213, 131)
        Me.btnThoat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(87, 30)
        Me.btnThoat.TabIndex = 4
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'txtMatKhau
        '
        Me.txtMatKhau.Location = New System.Drawing.Point(102, 86)
        Me.txtMatKhau.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMatKhau.Name = "txtMatKhau"
        Me.txtMatKhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtMatKhau.Size = New System.Drawing.Size(198, 25)
        Me.txtMatKhau.TabIndex = 2
        Me.txtMatKhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTaiKhoan
        '
        Me.txtTaiKhoan.Location = New System.Drawing.Point(102, 46)
        Me.txtTaiKhoan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTaiKhoan.Name = "txtTaiKhoan"
        Me.txtTaiKhoan.Size = New System.Drawing.Size(198, 25)
        Me.txtTaiKhoan.TabIndex = 1
        Me.txtTaiKhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTaiKhoan
        '
        Me.lblTaiKhoan.AutoSize = True
        Me.lblTaiKhoan.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTaiKhoan.Location = New System.Drawing.Point(21, 49)
        Me.lblTaiKhoan.Name = "lblTaiKhoan"
        Me.lblTaiKhoan.Size = New System.Drawing.Size(67, 17)
        Me.lblTaiKhoan.TabIndex = 4
        Me.lblTaiKhoan.Text = "Tài khoản:"
        '
        'lblMatKhau
        '
        Me.lblMatKhau.AutoSize = True
        Me.lblMatKhau.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMatKhau.Location = New System.Drawing.Point(21, 89)
        Me.lblMatKhau.Name = "lblMatKhau"
        Me.lblMatKhau.Size = New System.Drawing.Size(65, 17)
        Me.lblMatKhau.TabIndex = 5
        Me.lblMatKhau.Text = "Mật khẩu:"
        '
        'frmDangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(330, 184)
        Me.Controls.Add(Me.lblMatKhau)
        Me.Controls.Add(Me.lblTaiKhoan)
        Me.Controls.Add(Me.txtTaiKhoan)
        Me.Controls.Add(Me.txtMatKhau)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnDangNhap)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDangNhap"
        Me.Opacity = 0.5R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDangNhap As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents txtMatKhau As System.Windows.Forms.TextBox
    Friend WithEvents txtTaiKhoan As System.Windows.Forms.TextBox
    Friend WithEvents lblTaiKhoan As System.Windows.Forms.Label
    Friend WithEvents lblMatKhau As System.Windows.Forms.Label

End Class
