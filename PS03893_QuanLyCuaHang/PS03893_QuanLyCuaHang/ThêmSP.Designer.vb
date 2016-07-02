<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThem))
        Me.lblNoiDungTDS = New System.Windows.Forms.Label()
        Me.txtNoiDungTDS = New System.Windows.Forms.RichTextBox()
        Me.dtpNgayTDS = New System.Windows.Forms.DateTimePicker()
        Me.cbbTrangThaiTDS = New System.Windows.Forms.ComboBox()
        Me.lblHinhBiaSachTDS = New System.Windows.Forms.Label()
        Me.txtMaTDS = New System.Windows.Forms.TextBox()
        Me.txtTenTDS = New System.Windows.Forms.TextBox()
        Me.lblMaTDS = New System.Windows.Forms.Label()
        Me.lblTrangThaiTDS = New System.Windows.Forms.Label()
        Me.lblNgayTDS = New System.Windows.Forms.Label()
        Me.lblTenTDS = New System.Windows.Forms.Label()
        Me.lblTenTacGia = New System.Windows.Forms.Label()
        Me.txtTenTacGia = New System.Windows.Forms.TextBox()
        Me.cbbTL = New System.Windows.Forms.ComboBox()
        Me.lblTheLoai = New System.Windows.Forms.Label()
        Me.lblTenHinh = New System.Windows.Forms.Label()
        Me.btnThemTDS = New System.Windows.Forms.Button()
        Me.btnNhapLaiTDS = New System.Windows.Forms.Button()
        Me.btnChonHinhAnhTDS = New System.Windows.Forms.Button()
        Me.ptbHinhTDS = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.ptbHinhTDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNoiDungTDS
        '
        Me.lblNoiDungTDS.AutoSize = True
        Me.lblNoiDungTDS.Location = New System.Drawing.Point(370, 103)
        Me.lblNoiDungTDS.Name = "lblNoiDungTDS"
        Me.lblNoiDungTDS.Size = New System.Drawing.Size(57, 15)
        Me.lblNoiDungTDS.TabIndex = 26
        Me.lblNoiDungTDS.Text = "Nội dung"
        '
        'txtNoiDungTDS
        '
        Me.txtNoiDungTDS.Location = New System.Drawing.Point(436, 103)
        Me.txtNoiDungTDS.MaxLength = 255
        Me.txtNoiDungTDS.Name = "txtNoiDungTDS"
        Me.txtNoiDungTDS.Size = New System.Drawing.Size(243, 188)
        Me.txtNoiDungTDS.TabIndex = 23
        Me.txtNoiDungTDS.Text = ""
        '
        'dtpNgayTDS
        '
        Me.dtpNgayTDS.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNgayTDS.Location = New System.Drawing.Point(101, 58)
        Me.dtpNgayTDS.Name = "dtpNgayTDS"
        Me.dtpNgayTDS.Size = New System.Drawing.Size(116, 23)
        Me.dtpNgayTDS.TabIndex = 20
        Me.dtpNgayTDS.Value = New Date(2016, 2, 26, 0, 0, 0, 0)
        '
        'cbbTrangThaiTDS
        '
        Me.cbbTrangThaiTDS.FormattingEnabled = True
        Me.cbbTrangThaiTDS.Items.AddRange(New Object() {"Còn hàng", "Tạm hết", "Sắp có hàng"})
        Me.cbbTrangThaiTDS.Location = New System.Drawing.Point(336, 58)
        Me.cbbTrangThaiTDS.Name = "cbbTrangThaiTDS"
        Me.cbbTrangThaiTDS.Size = New System.Drawing.Size(116, 23)
        Me.cbbTrangThaiTDS.TabIndex = 21
        Me.cbbTrangThaiTDS.Text = "Còn hàng"
        '
        'lblHinhBiaSachTDS
        '
        Me.lblHinhBiaSachTDS.AutoSize = True
        Me.lblHinhBiaSachTDS.Location = New System.Drawing.Point(30, 103)
        Me.lblHinhBiaSachTDS.Name = "lblHinhBiaSachTDS"
        Me.lblHinhBiaSachTDS.Size = New System.Drawing.Size(111, 15)
        Me.lblHinhBiaSachTDS.TabIndex = 20
        Me.lblHinhBiaSachTDS.Text = "Hình ảnh sản phẩm"
        '
        'txtMaTDS
        '
        Me.txtMaTDS.Location = New System.Drawing.Point(336, 16)
        Me.txtMaTDS.MaxLength = 15
        Me.txtMaTDS.Name = "txtMaTDS"
        Me.txtMaTDS.Size = New System.Drawing.Size(116, 23)
        Me.txtMaTDS.TabIndex = 18
        '
        'txtTenTDS
        '
        Me.txtTenTDS.Location = New System.Drawing.Point(100, 16)
        Me.txtTenTDS.Name = "txtTenTDS"
        Me.txtTenTDS.Size = New System.Drawing.Size(164, 23)
        Me.txtTenTDS.TabIndex = 17
        '
        'lblMaTDS
        '
        Me.lblMaTDS.AutoSize = True
        Me.lblMaTDS.Location = New System.Drawing.Point(287, 19)
        Me.lblMaTDS.Name = "lblMaTDS"
        Me.lblMaTDS.Size = New System.Drawing.Size(43, 15)
        Me.lblMaTDS.TabIndex = 16
        Me.lblMaTDS.Text = "Mã SP:"
        '
        'lblTrangThaiTDS
        '
        Me.lblTrangThaiTDS.AutoSize = True
        Me.lblTrangThaiTDS.Location = New System.Drawing.Point(269, 62)
        Me.lblTrangThaiTDS.Name = "lblTrangThaiTDS"
        Me.lblTrangThaiTDS.Size = New System.Drawing.Size(61, 15)
        Me.lblTrangThaiTDS.TabIndex = 13
        Me.lblTrangThaiTDS.Text = "Trạng thái"
        '
        'lblNgayTDS
        '
        Me.lblNgayTDS.AutoSize = True
        Me.lblNgayTDS.Location = New System.Drawing.Point(30, 62)
        Me.lblNgayTDS.Name = "lblNgayTDS"
        Me.lblNgayTDS.Size = New System.Drawing.Size(68, 15)
        Me.lblNgayTDS.TabIndex = 14
        Me.lblNgayTDS.Text = "Ngày đăng:"
        '
        'lblTenTDS
        '
        Me.lblTenTDS.AutoSize = True
        Me.lblTenTDS.Location = New System.Drawing.Point(48, 19)
        Me.lblTenTDS.Name = "lblTenTDS"
        Me.lblTenTDS.Size = New System.Drawing.Size(46, 15)
        Me.lblTenTDS.TabIndex = 12
        Me.lblTenTDS.Text = "Tên SP:"
        '
        'lblTenTacGia
        '
        Me.lblTenTacGia.AutoSize = True
        Me.lblTenTacGia.Location = New System.Drawing.Point(465, 20)
        Me.lblTenTacGia.Name = "lblTenTacGia"
        Me.lblTenTacGia.Size = New System.Drawing.Size(55, 15)
        Me.lblTenTacGia.TabIndex = 12
        Me.lblTenTacGia.Text = "Hãng SX:"
        '
        'txtTenTacGia
        '
        Me.txtTenTacGia.Location = New System.Drawing.Point(521, 16)
        Me.txtTenTacGia.Name = "txtTenTacGia"
        Me.txtTenTacGia.Size = New System.Drawing.Size(158, 23)
        Me.txtTenTacGia.TabIndex = 19
        '
        'cbbTL
        '
        Me.cbbTL.FormattingEnabled = True
        Me.cbbTL.Items.AddRange(New Object() {"DTDD", "MTB", "LAPTOP", "DESKTOP", "PK"})
        Me.cbbTL.Location = New System.Drawing.Point(521, 60)
        Me.cbbTL.Name = "cbbTL"
        Me.cbbTL.Size = New System.Drawing.Size(158, 23)
        Me.cbbTL.TabIndex = 22
        Me.cbbTL.Text = "DTDD"
        '
        'lblTheLoai
        '
        Me.lblTheLoai.AutoSize = True
        Me.lblTheLoai.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblTheLoai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTheLoai.Location = New System.Drawing.Point(470, 64)
        Me.lblTheLoai.Name = "lblTheLoai"
        Me.lblTheLoai.Size = New System.Drawing.Size(49, 15)
        Me.lblTheLoai.TabIndex = 35
        Me.lblTheLoai.Text = "Thể loại"
        '
        'lblTenHinh
        '
        Me.lblTenHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTenHinh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenHinh.Location = New System.Drawing.Point(144, 351)
        Me.lblTenHinh.Name = "lblTenHinh"
        Me.lblTenHinh.Size = New System.Drawing.Size(186, 27)
        Me.lblTenHinh.TabIndex = 37
        Me.lblTenHinh.Text = "SP0000.jpg"
        Me.lblTenHinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnThemTDS
        '
        Me.btnThemTDS.BackgroundImage = Global.PS03893_QuanLyCuaHang.My.Resources.Resources.Ok_icon
        Me.btnThemTDS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThemTDS.Location = New System.Drawing.Point(536, 324)
        Me.btnThemTDS.Name = "btnThemTDS"
        Me.btnThemTDS.Size = New System.Drawing.Size(45, 40)
        Me.btnThemTDS.TabIndex = 26
        Me.btnThemTDS.UseVisualStyleBackColor = True
        '
        'btnNhapLaiTDS
        '
        Me.btnNhapLaiTDS.BackgroundImage = CType(resources.GetObject("btnNhapLaiTDS.BackgroundImage"), System.Drawing.Image)
        Me.btnNhapLaiTDS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNhapLaiTDS.Location = New System.Drawing.Point(439, 324)
        Me.btnNhapLaiTDS.Name = "btnNhapLaiTDS"
        Me.btnNhapLaiTDS.Size = New System.Drawing.Size(48, 40)
        Me.btnNhapLaiTDS.TabIndex = 25
        Me.btnNhapLaiTDS.UseVisualStyleBackColor = False
        '
        'btnChonHinhAnhTDS
        '
        Me.btnChonHinhAnhTDS.BackgroundImage = Global.PS03893_QuanLyCuaHang.My.Resources.Resources.open_file_icon
        Me.btnChonHinhAnhTDS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChonHinhAnhTDS.Location = New System.Drawing.Point(108, 348)
        Me.btnChonHinhAnhTDS.Name = "btnChonHinhAnhTDS"
        Me.btnChonHinhAnhTDS.Size = New System.Drawing.Size(30, 30)
        Me.btnChonHinhAnhTDS.TabIndex = 24
        Me.btnChonHinhAnhTDS.UseVisualStyleBackColor = True
        '
        'ptbHinhTDS
        '
        Me.ptbHinhTDS.BackgroundImage = CType(resources.GetObject("ptbHinhTDS.BackgroundImage"), System.Drawing.Image)
        Me.ptbHinhTDS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhTDS.Location = New System.Drawing.Point(144, 103)
        Me.ptbHinhTDS.Name = "ptbHinhTDS"
        Me.ptbHinhTDS.Size = New System.Drawing.Size(186, 245)
        Me.ptbHinhTDS.TabIndex = 21
        Me.ptbHinhTDS.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Chọn hình ảnh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(542, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 21)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Lưu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.Location = New System.Drawing.Point(432, 365)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Nhập lại"
        '
        'btnClose
        '
        Me.btnClose.Image = Global.PS03893_QuanLyCuaHang.My.Resources.Resources.Actions_dialog_cancel_icon
        Me.btnClose.Location = New System.Drawing.Point(631, 324)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(46, 40)
        Me.btnClose.TabIndex = 41
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label4.Location = New System.Drawing.Point(631, 365)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 21)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Đóng"
        '
        'frmThem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 395)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTenHinh)
        Me.Controls.Add(Me.cbbTL)
        Me.Controls.Add(Me.lblTheLoai)
        Me.Controls.Add(Me.btnThemTDS)
        Me.Controls.Add(Me.btnNhapLaiTDS)
        Me.Controls.Add(Me.lblNoiDungTDS)
        Me.Controls.Add(Me.txtNoiDungTDS)
        Me.Controls.Add(Me.dtpNgayTDS)
        Me.Controls.Add(Me.cbbTrangThaiTDS)
        Me.Controls.Add(Me.btnChonHinhAnhTDS)
        Me.Controls.Add(Me.ptbHinhTDS)
        Me.Controls.Add(Me.lblHinhBiaSachTDS)
        Me.Controls.Add(Me.txtMaTDS)
        Me.Controls.Add(Me.txtTenTacGia)
        Me.Controls.Add(Me.txtTenTDS)
        Me.Controls.Add(Me.lblMaTDS)
        Me.Controls.Add(Me.lblTrangThaiTDS)
        Me.Controls.Add(Me.lblNgayTDS)
        Me.Controls.Add(Me.lblTenTacGia)
        Me.Controls.Add(Me.lblTenTDS)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "frmThem"
        Me.Text = "Thêm sản phẩm"
        CType(Me.ptbHinhTDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThemTDS As System.Windows.Forms.Button
    Friend WithEvents btnNhapLaiTDS As System.Windows.Forms.Button
    Friend WithEvents lblNoiDungTDS As System.Windows.Forms.Label
    Friend WithEvents txtNoiDungTDS As System.Windows.Forms.RichTextBox
    Friend WithEvents dtpNgayTDS As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbbTrangThaiTDS As System.Windows.Forms.ComboBox
    Friend WithEvents btnChonHinhAnhTDS As System.Windows.Forms.Button
    Friend WithEvents ptbHinhTDS As System.Windows.Forms.PictureBox
    Friend WithEvents lblHinhBiaSachTDS As System.Windows.Forms.Label
    Friend WithEvents txtMaTDS As System.Windows.Forms.TextBox
    Friend WithEvents txtTenTDS As System.Windows.Forms.TextBox
    Friend WithEvents lblMaTDS As System.Windows.Forms.Label
    Friend WithEvents lblTrangThaiTDS As System.Windows.Forms.Label
    Friend WithEvents lblNgayTDS As System.Windows.Forms.Label
    Friend WithEvents lblTenTDS As System.Windows.Forms.Label
    Friend WithEvents lblTenTacGia As System.Windows.Forms.Label
    Friend WithEvents txtTenTacGia As System.Windows.Forms.TextBox
    Friend WithEvents cbbTL As System.Windows.Forms.ComboBox
    Friend WithEvents lblTheLoai As System.Windows.Forms.Label
    Friend WithEvents lblTenHinh As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
