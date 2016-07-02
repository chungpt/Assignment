<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChiTiet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChiTiet))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNoiDungND = New System.Windows.Forms.Label()
        Me.lblGioiThieuND = New System.Windows.Forms.Label()
        Me.lblMaSachND = New System.Windows.Forms.Label()
        Me.lblBiaSachND = New System.Windows.Forms.Label()
        Me.lblTenSachND = New System.Windows.Forms.Label()
        Me.btnThoatND = New System.Windows.Forms.Button()
        Me.btnMuonSachND = New System.Windows.Forms.Button()
        Me.ptbHinhSachND = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ptbHinhSachND, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblNoiDungND)
        Me.Panel1.Controls.Add(Me.lblGioiThieuND)
        Me.Panel1.Controls.Add(Me.lblMaSachND)
        Me.Panel1.Controls.Add(Me.lblBiaSachND)
        Me.Panel1.Controls.Add(Me.ptbHinhSachND)
        Me.Panel1.Controls.Add(Me.lblTenSachND)
        Me.Panel1.Location = New System.Drawing.Point(21, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 327)
        Me.Panel1.TabIndex = 12
        '
        'lblNoiDungND
        '
        Me.lblNoiDungND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNoiDungND.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblNoiDungND.Location = New System.Drawing.Point(333, 72)
        Me.lblNoiDungND.Name = "lblNoiDungND"
        Me.lblNoiDungND.Size = New System.Drawing.Size(399, 239)
        Me.lblNoiDungND.TabIndex = 7
        '
        'lblGioiThieuND
        '
        Me.lblGioiThieuND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGioiThieuND.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblGioiThieuND.Location = New System.Drawing.Point(333, 36)
        Me.lblGioiThieuND.Name = "lblGioiThieuND"
        Me.lblGioiThieuND.Size = New System.Drawing.Size(399, 36)
        Me.lblGioiThieuND.TabIndex = 6
        Me.lblGioiThieuND.Text = "Giới thiệu"
        Me.lblGioiThieuND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaSachND
        '
        Me.lblMaSachND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaSachND.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblMaSachND.Location = New System.Drawing.Point(-1, 275)
        Me.lblMaSachND.Name = "lblMaSachND"
        Me.lblMaSachND.Size = New System.Drawing.Size(328, 36)
        Me.lblMaSachND.TabIndex = 5
        Me.lblMaSachND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBiaSachND
        '
        Me.lblBiaSachND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBiaSachND.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblBiaSachND.Location = New System.Drawing.Point(42, 0)
        Me.lblBiaSachND.Name = "lblBiaSachND"
        Me.lblBiaSachND.Size = New System.Drawing.Size(243, 36)
        Me.lblBiaSachND.TabIndex = 5
        Me.lblBiaSachND.Text = "Hình ảnh"
        Me.lblBiaSachND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTenSachND
        '
        Me.lblTenSachND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTenSachND.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.lblTenSachND.Location = New System.Drawing.Point(333, 0)
        Me.lblTenSachND.Name = "lblTenSachND"
        Me.lblTenSachND.Size = New System.Drawing.Size(399, 36)
        Me.lblTenSachND.TabIndex = 0
        Me.lblTenSachND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnThoatND
        '
        Me.btnThoatND.BackgroundImage = Global.PS03893_QuanLyCuaHang.My.Resources.Resources.Actions_dialog_cancel_icon
        Me.btnThoatND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnThoatND.Location = New System.Drawing.Point(511, 346)
        Me.btnThoatND.Name = "btnThoatND"
        Me.btnThoatND.Size = New System.Drawing.Size(40, 40)
        Me.btnThoatND.TabIndex = 14
        Me.btnThoatND.UseVisualStyleBackColor = True
        '
        'btnMuonSachND
        '
        Me.btnMuonSachND.BackgroundImage = Global.PS03893_QuanLyCuaHang.My.Resources.Resources.shopping_cart_accept_icon
        Me.btnMuonSachND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMuonSachND.Location = New System.Drawing.Point(230, 346)
        Me.btnMuonSachND.Name = "btnMuonSachND"
        Me.btnMuonSachND.Size = New System.Drawing.Size(40, 40)
        Me.btnMuonSachND.TabIndex = 13
        Me.btnMuonSachND.UseVisualStyleBackColor = True
        '
        'ptbHinhSachND
        '
        Me.ptbHinhSachND.BackgroundImage = CType(resources.GetObject("ptbHinhSachND.BackgroundImage"), System.Drawing.Image)
        Me.ptbHinhSachND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbHinhSachND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptbHinhSachND.Location = New System.Drawing.Point(42, 36)
        Me.ptbHinhSachND.Name = "ptbHinhSachND"
        Me.ptbHinhSachND.Size = New System.Drawing.Size(243, 236)
        Me.ptbHinhSachND.TabIndex = 4
        Me.ptbHinhSachND.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Mua hàng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(553, 357)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Đóng"
        '
        'frmChiTiet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 400)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnThoatND)
        Me.Controls.Add(Me.btnMuonSachND)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Name = "frmChiTiet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Chi tiết sản phẩm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ptbHinhSachND, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnThoatND As System.Windows.Forms.Button
    Friend WithEvents btnMuonSachND As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblNoiDungND As System.Windows.Forms.Label
    Friend WithEvents lblGioiThieuND As System.Windows.Forms.Label
    Friend WithEvents lblMaSachND As System.Windows.Forms.Label
    Friend WithEvents lblBiaSachND As System.Windows.Forms.Label
    Friend WithEvents ptbHinhSachND As System.Windows.Forms.PictureBox
    Friend WithEvents lblTenSachND As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
