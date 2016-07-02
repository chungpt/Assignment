Public Class frmTrangChu
    'khách hàng click để vào thư viện 
    Private Sub tsbVaoThuVien_Click(sender As Object, e As EventArgs) Handles tsbVaoThuVien.Click
        frmQuanLySachThuVien.MdiParent = Me
        frmQuanLySachThuVien.Show()
        frmQuanLySachThuVien.BringToFront()
    End Sub
    'quản trị click để vào cập nhật thư viện
    Private Sub btnQuanLy_Click(sender As Object, e As EventArgs) Handles tsbQuanLy.Click
        If tsbTrangThai.Text = "Đăng xuất" Then
            frmQuanLy.BringToFront()
            frmQuanLySachThuVien.Close()
        Else
            frmDangNhap.ShowDialog()
        End If
    End Sub
    'thoát
    Private Sub tsbThoat_Click(sender As Object, e As EventArgs) Handles tsbThoat.Click
        Me.Close()
    End Sub
    'thay đổi thanh trạng thái
    Private Sub tsbTrangThai_Click(sender As Object, e As EventArgs) Handles tsbTrangThai.Click
        tsbTrangThai.Text = ""
        frmQuanLy.Close()
    End Sub
End Class