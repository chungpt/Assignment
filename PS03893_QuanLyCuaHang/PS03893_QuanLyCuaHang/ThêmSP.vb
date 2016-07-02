Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmThem
    'khai báo biến
    Dim noiluu As String = Application.StartupPath & "\data\hinh\"
    Dim tenhinh As String
    Dim duongdan As String
    Dim chuoiketnoi As String = "Data Source=HP-PC;Initial Catalog=QuanLyCuaHang;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim db As New DataTable
    ' chọn ảnh
    Private Sub btnChonHinhAnhTDS_Click(sender As Object, e As EventArgs) Handles btnChonHinhAnhTDS.Click
        Dim hinhanh As New OpenFileDialog
        'điều kiện để lấy file
        If hinhanh.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            duongdan = hinhanh.FileName
            If duongdan.EndsWith(".jpg") Then
                tenhinh = hinhanh.FileName.Substring(hinhanh.FileName.LastIndexOf("\") + 1)
            Else
                MessageBox.Show("Chỉ cho phép file JPG", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                hinhanh.FileName = Nothing
                duongdan = Nothing
            End If
        End If
        Dim image As Image
        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(duongdan, IO.FileMode.Open, IO.FileAccess.Read)
        image = System.Drawing.Image.FromStream(fs)
        fs.Close()
        ptbHinhTDS.BackgroundImage = image
        lblTenHinh.Text = tenhinh
    End Sub
    'click thêm để ghi dữ liệu ra data
    Private Sub btnThemTDS_Click(sender As Object, e As EventArgs) Handles btnThemTDS.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "Insert Into SANPHAM values (@MASP,@MALOAI,@TENSP,@NOIDUNG,@HANGSX,@NGAYDANG,@TRANGTHAI)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open() 'mở kết nối
        Try 'kiểm tra có dữ liệu hay chưa
            txtMaTDS.Focus()
            If txtMaTDS.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtMaTDS.Focus()
                If txtTenTacGia.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên tác giả", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTenTacGia.Focus()
                    If txtTenTDS.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập tên sách", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtTenTDS.Focus()
                        If txtNoiDungTDS.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập nội dung", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else 'lấy dữ liệu đưa vào các biến                         
                            save.Parameters.AddWithValue("@MASP", txtMaTDS.Text)
                            save.Parameters.AddWithValue("@MALOAI", cbbTL.Text)
                            save.Parameters.AddWithValue("@TENSP", txtTenTDS.Text)
                            save.Parameters.AddWithValue("@HANGSX", txtTenTacGia.Text)
                            save.Parameters.AddWithValue("@NOIDUNG", txtNoiDungTDS.Text)
                            save.Parameters.AddWithValue("@NGAYDANG", dtpNgayTDS.Text)
                            save.Parameters.AddWithValue("@TRANGTHAI", cbbTrangThaiTDS.Text)
                            save.Parameters.AddWithValue("@FILEANH", lblTenHinh.Text)
                            save.ExecuteNonQuery()
                            'tiến hành chép file ảnh vào thư mục của ứng dụng
                            Try 'nếu không lựa chọn hình ảnh thì bỏ qua
                                If System.IO.File.Exists(noiluu & txtMaTDS.Text & ".jpg") Then
                                    Kill(noiluu & txtMaTDS.Text & ".jpg")
                                    FileCopy(duongdan, noiluu & tenhinh & "1")
                                    Rename(noiluu & tenhinh & "1", noiluu & txtMaTDS.Text & ".jpg")
                                Else
                                    FileCopy(duongdan, noiluu & tenhinh & "1")
                                    Rename(noiluu & tenhinh & "1", noiluu & txtMaTDS.Text & ".jpg")
                                End If
                            Catch ex As Exception
                            End Try
                            conn.Close() 'đóng kết nối
                            MessageBox.Show("Thêm thành công")
                        End If
                    End If
                End If
            End If
            Me.Close()
            'Sau khi thêm xong sẽ tự làm mới lại bảng
            conn.Open()
            Dim sachmoi As SqlDataAdapter = New SqlDataAdapter("select MASP as 'Mã SP', MALOAI as 'Mã loại', TENSP as 'Tên SP',  NOIDUNG as 'Nội dung',HANGSX as 'Hãng SX', NGAYDANG as 'Ngày đăng' , TRANGTHAI as 'Trạng thái' from SANPHAM", conn)
            frmQuanLy.dgvXemDanhSach.DataSource = db.DefaultView
            db.Clear()
            sachmoi.Fill(db)
            conn.Close()
            Try
                Dim image As Image
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(Application.StartupPath & "\data\hinh\" & frmQuanLy.dgvXemDanhSach.Item(0, 0).Value & ".jpg", IO.FileMode.Open, IO.FileAccess.Read)
                image = System.Drawing.Image.FromStream(fs)
                fs.Close()
                frmQuanLy.ptbHinhSachQL.BackgroundImage = image
            Catch ex As Exception
                frmQuanLy.ptbHinhSachQL.BackgroundImage = Image.FromFile(Application.StartupPath & "\data\hinh\Sach000.jpg")
            End Try
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    'nhập lại
    Private Sub btnNhapLaiTDS_Click(sender As Object, e As EventArgs) Handles btnNhapLaiTDS.Click
        txtMaTDS.Text = ""
        txtNoiDungTDS.Text = ""
        txtTenTacGia.Text = ""
        txtTenTDS.Text = ""
    End Sub

    Private Sub frmThem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpNgayTDS.Value = Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class