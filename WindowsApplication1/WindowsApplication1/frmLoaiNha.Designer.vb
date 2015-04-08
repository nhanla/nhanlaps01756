<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiNha
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
        Me.txtMota = New System.Windows.Forms.TextBox()
        Me.txtLoaiNha = New System.Windows.Forms.TextBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.lblMoTa = New System.Windows.Forms.Label()
        Me.lblLoaiNha = New System.Windows.Forms.Label()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMota
        '
        Me.txtMota.Location = New System.Drawing.Point(119, 58)
        Me.txtMota.Multiline = True
        Me.txtMota.Name = "txtMota"
        Me.txtMota.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMota.Size = New System.Drawing.Size(149, 50)
        Me.txtMota.TabIndex = 2
        '
        'txtLoaiNha
        '
        Me.txtLoaiNha.Location = New System.Drawing.Point(119, 27)
        Me.txtLoaiNha.Name = "txtLoaiNha"
        Me.txtLoaiNha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLoaiNha.Size = New System.Drawing.Size(149, 25)
        Me.txtLoaiNha.TabIndex = 1
        Me.txtLoaiNha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(194, 126)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 26)
        Me.btnXoa.TabIndex = 5
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(113, 126)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 26)
        Me.btnSua.TabIndex = 4
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(32, 126)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 26)
        Me.btnThem.TabIndex = 3
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'grdData
        '
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Location = New System.Drawing.Point(12, 158)
        Me.grdData.Name = "grdData"
        Me.grdData.Size = New System.Drawing.Size(277, 150)
        Me.grdData.TabIndex = 24
        '
        'lblMoTa
        '
        Me.lblMoTa.AutoSize = True
        Me.lblMoTa.Location = New System.Drawing.Point(33, 61)
        Me.lblMoTa.Name = "lblMoTa"
        Me.lblMoTa.Size = New System.Drawing.Size(46, 17)
        Me.lblMoTa.TabIndex = 31
        Me.lblMoTa.Text = "Mô tả:"
        '
        'lblLoaiNha
        '
        Me.lblLoaiNha.AutoSize = True
        Me.lblLoaiNha.Location = New System.Drawing.Point(33, 30)
        Me.lblLoaiNha.Name = "lblLoaiNha"
        Me.lblLoaiNha.Size = New System.Drawing.Size(80, 17)
        Me.lblLoaiNha.TabIndex = 30
        Me.lblLoaiNha.Text = "Mã loại nhà:"
        '
        'frmLoaiNha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(301, 320)
        Me.Controls.Add(Me.lblMoTa)
        Me.Controls.Add(Me.lblLoaiNha)
        Me.Controls.Add(Me.txtMota)
        Me.Controls.Add(Me.txtLoaiNha)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.grdData)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoaiNha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loại nhà"
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMota As System.Windows.Forms.TextBox
    Friend WithEvents txtLoaiNha As System.Windows.Forms.TextBox
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents lblMoTa As System.Windows.Forms.Label
    Friend WithEvents lblLoaiNha As System.Windows.Forms.Label
End Class
