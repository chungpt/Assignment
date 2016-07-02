<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuanLy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuanLy))
        Me.lblTieuDeQL = New System.Windows.Forms.Label()
        Me.grbTieuDe2QL = New System.Windows.Forms.GroupBox()
        Me.dgvXemDanhSach = New System.Windows.Forms.DataGridView()
        Me.txtTacGia = New System.Windows.Forms.TextBox()
        Me.txtMaSachTK = New System.Windows.Forms.TextBox()
        Me.txtTenSachTK = New System.Windows.Forms.TextBox()
        Me.lblTacGia = New System.Windows.Forms.Label()
        Me.lblMaSach = New System.Windows.Forms.Label()
        Me.lblTenSach = New System.Windows.Forms.Label()
        Me.btnTimKiemTK = New System.Windows.Forms.Button()
        Me.ptbHinhSachQL = New System.Windows.Forms.PictureBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnThoatQL = New System.Windows.Forms.Button()
        Me.btnThemQL = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvXemDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbHinhSachQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTieuDeQL
        '
        Me.lblTieuDeQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTieuDeQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTieuDeQL.Location = New System.Drawing.Point(17, 70)
        Me.lblTieuDeQL.Name = "lblTieuDeQL"
        Me.lblTieuDeQL.Size = New System.Drawing.Size(469, 24)
        Me.lblTieuDeQL.TabIndex = 10
        Me.lblTieuDeQL.Text = "Danh Sách Sản Phẩm"
        Me.lblTieuDeQL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbTieuDe2QL
        '
        Me.grbTieuDe2QL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.grbTieuDe2QL.Location = New System.Drawing.Point(493, 54)
        Me.grbTieuDe2QL.Name = "grbTieuDe2QL"
        Me.grbTieuDe2QL.Size = New System.Drawing.Size(236, 19)
        Me.grbTieuDe2QL.TabIndex = 12
        Me.grbTieuDe2QL.TabStop = False
        Me.grbTieuDe2QL.Text = "Hình ảnh"
        '
        'dgvXemDanhSach
        '
        Me.dgvXemDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXemDanhSach.Location = New System.Drawing.Point(17, 97)
        Me.dgvXemDanhSach.Name = "dgvXemDanhSach"
        Me.dgvXemDanhSach.RowHeadersVisible = False
        Me.dgvXemDanhSach.Size = New System.Drawing.Size(469, 229)
        Me.dgvXemDanhSach.TabIndex = 20
        '
        'txtTacGia
        '
        Me.txtTacGia.Location = New System.Drawing.Point(446, 22)
        Me.txtTacGia.Name = "txtTacGia"
        Me.txtTacGia.Size = New System.Drawing.Size(132, 23)
        Me.txtTacGia.TabIndex = 12
        '
        'txtMaSachTK
        '
        Me.txtMaSachTK.Location = New System.Drawing.Point(290, 22)
        Me.txtMaSachTK.Name = "txtMaSachTK"
        Me.txtMaSachTK.Size = New System.Drawing.Size(80, 23)
        Me.txtMaSachTK.TabIndex = 11
        '
        'txtTenSachTK
        '
        Me.txtTenSachTK.Location = New System.Drawing.Point(77, 22)
        Me.txtTenSachTK.Name = "txtTenSachTK"
        Me.txtTenSachTK.Size = New System.Drawing.Size(142, 23)
        Me.txtTenSachTK.TabIndex = 10
        '
        'lblTacGia
        '
        Me.lblTacGia.AutoSize = True
        Me.lblTacGia.Location = New System.Drawing.Point(388, 26)
        Me.lblTacGia.Name = "lblTacGia"
        Me.lblTacGia.Size = New System.Drawing.Size(55, 15)
        Me.lblTacGia.TabIndex = 28
        Me.lblTacGia.Tag = ""
        Me.lblTacGia.Text = "Hãng SX:"
        '
        'lblMaSach
        '
        Me.lblMaSach.AutoSize = True
        Me.lblMaSach.Location = New System.Drawing.Point(241, 25)
        Me.lblMaSach.Name = "lblMaSach"
        Me.lblMaSach.Size = New System.Drawing.Size(43, 15)
        Me.lblMaSach.TabIndex = 29
        Me.lblMaSach.Text = "Mã SP:"
        '
        'lblTenSach
        '
        Me.lblTenSach.AutoSize = True
        Me.lblTenSach.Location = New System.Drawing.Point(25, 25)
        Me.lblTenSach.Name = "lblTenSach"
        Me.lblTenSach.Size = New System.Drawing.Size(46, 15)
        Me.lblTenSach.TabIndex = 30
        Me.lblTenSach.Text = "Tên SP:"
        '
        'btnTimKiemTK
        '
        Me.btnTimKiemTK.BackgroundImage = Global.PS03893_QuanLyCuaHang.My.Resources.Resources.Start_Menu_Search_icon
        Me.btnTimKiemTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTimKiemTK.Location = New System.Drawing.Point(584, 20)
        Me.btnTimKiemTK.Name = "btnTimKiemTK"
        Me.btnTimKiemTK.Size = New System.Drawing.Size(27, 27)
        Me.btnTimKiemTK.TabIndex = 13
        Me.btnTimKiemTK.UseVisualStyleBackColor = True
        '
        'ptbHinhSachQL
        '
        Me.ptbHinhSachQL.BackgroundImage = CType(resources.GetObject("ptbHinhSachQL.BackgroundImage"), System.Drawing.Image)
        Me.ptbHinhSachQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhSachQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhSachQL.Location = New System.Drawing.Point(515, 70)
        Me.ptbHinhSachQL.Name = "ptbHinhSachQL"
        Me.ptbHinhSachQL.Size = New System.Drawing.Size(198, 256)
        Me.ptbHinhSachQL.TabIndex = 4
        Me.ptbHinhSachQL.TabStop = False
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImage = Global.PS03893_QuanLyCuaHang.My.Resources.Resources.Actions_trash_empty_icon
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnXoa.Location = New System.Drawing.Point(345, 335)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(40, 40)
        Me.btnXoa.TabIndex = 16
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapNhat
        '
        Me.btnCapNhat.BackgroundImage = Global.PS03893_QuanLyCuaHang.My.Resources.Resources.Text_Edit_icon
        Me.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCapNhat.Location = New System.Drawing.Point(218, 335)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(40, 40)
        Me.btnCapNhat.TabIndex = 15
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnThoatQL
        '
        Me.btnThoatQL.BackgroundImage = Global.PS03893_QuanLyCuaHang.My.Resources.Resources.Actions_dialog_cancel_icon
        Me.btnThoatQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThoatQL.Location = New System.Drawing.Point(601, 335)
        Me.btnThoatQL.Name = "btnThoatQL"
        Me.btnThoatQL.Size = New System.Drawing.Size(40, 40)
        Me.btnThoatQL.TabIndex = 17
        Me.btnThoatQL.UseVisualStyleBackColor = True
        '
        'btnThemQL
        '
        Me.btnThemQL.BackgroundImage = Global.PS03893_QuanLyCuaHang.My.Resources.Resources.chart_add_icon
        Me.btnThemQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThemQL.Location = New System.Drawing.Point(99, 335)
        Me.btnThemQL.Name = "btnThemQL"
        Me.btnThemQL.Size = New System.Drawing.Size(40, 40)
        Me.btnThemQL.TabIndex = 14
        Me.btnThemQL.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(613, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 21)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Tìm kiếm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 21)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Thêm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(220, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 21)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Sửa"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(348, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 21)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Xóa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label5.Location = New System.Drawing.Point(599, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 21)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Đóng"
        '
        'frmQuanLy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 415)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTacGia)
        Me.Controls.Add(Me.btnTimKiemTK)
        Me.Controls.Add(Me.txtMaSachTK)
        Me.Controls.Add(Me.txtTenSachTK)
        Me.Controls.Add(Me.lblTacGia)
        Me.Controls.Add(Me.lblMaSach)
        Me.Controls.Add(Me.lblTenSach)
        Me.Controls.Add(Me.dgvXemDanhSach)
        Me.Controls.Add(Me.ptbHinhSachQL)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Controls.Add(Me.lblTieuDeQL)
        Me.Controls.Add(Me.btnThoatQL)
        Me.Controls.Add(Me.btnThemQL)
        Me.Controls.Add(Me.grbTieuDe2QL)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmQuanLy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Quản lý"
        CType(Me.dgvXemDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbHinhSachQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTieuDeQL As System.Windows.Forms.Label
    Friend WithEvents btnThoatQL As System.Windows.Forms.Button
    Friend WithEvents btnThemQL As System.Windows.Forms.Button
    Friend WithEvents grbTieuDe2QL As System.Windows.Forms.GroupBox
    Friend WithEvents ptbHinhSachQL As System.Windows.Forms.PictureBox
    Friend WithEvents btnCapNhat As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents dgvXemDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents txtTacGia As System.Windows.Forms.TextBox
    Friend WithEvents btnTimKiemTK As System.Windows.Forms.Button
    Friend WithEvents txtMaSachTK As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSachTK As System.Windows.Forms.TextBox
    Friend WithEvents lblTacGia As System.Windows.Forms.Label
    Friend WithEvents lblMaSach As System.Windows.Forms.Label
    Friend WithEvents lblTenSach As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
