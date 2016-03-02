Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmNhanvien
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=hoangntps03065.mssql.somee.com;packet size=4096;user id=hoangnt7101993_SQLLogin_1;pwd=fn9mnrpsum;data source=hoangntps03065.mssql.somee.com;persist security info=False;initial catalog=hoangntps03065"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub Nhanvien_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into NHANVIEN values(@MANV,@TENNV,@NGAYSINH,@DIACHI,@SODT)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtManv.Focus()
            If txtManv.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtManv.Focus()
                If txtTennv.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtNgaysinh.Focus()
                    If txtDiachi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtDiachi.Focus()
                        If txtSodt.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            txtSodt.Focus()
                        Else
                            save.Parameters.AddWithValue("@MANV", txtManv.Text)
                            save.Parameters.AddWithValue("@TENNV", txtTennv.Text)
                            save.Parameters.AddWithValue("@NGAYSINH", txtNgaysinh.Text)
                            save.Parameters.AddWithValue("@DIACHI", txtDiachi.Text)
                            save.Parameters.AddWithValue("@SODT", txtSodt.Text)
                            save.ExecuteNonQuery()
                            MessageBox.Show("Lưu thành công")
                            'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                            txtManv.Text = Nothing
                            txtTennv.Text = Nothing
                            txtNgaysinh.Text = Nothing
                            txtDiachi.Text = Nothing
                            txtSodt.Text = Nothing

                        End If
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MANV as 'Mã NV' ,TENNV as 'Tên Nhân Viên', NGAYSINH as 'Ngày Sinh', DIACHI as 'Địa Chỉ', SODT from NHANVIEN", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles BtnLoad.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MANV as 'Mã NV' ,TENNV as 'Tên Nhân Viên', NGAYSINH as 'Ngày Sinh', DIACHI as 'Địa Chỉ', SODT from NHANVIEN where MANV=N'" & txtManv.Text & "'", connect)
        Try
            If txtManv.Text = "" Then
                MessageBox.Show("Bạn cần nhập MANV", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                DataGridView1.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    DataGridView1.DataSource = db.DefaultView
                    txtManv.Text = Nothing
                    btnXoa.Enabled = True
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtManv.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCapnhap_Click(sender As Object, e As EventArgs) Handles btnCapnhap.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update NHANVIEN set MANV=@MANV, TENNV=@TENNV, NGAYSINH=@NGAYSINH, DIACHI=@DIACHI, SODT=@SODT where MANV=@MANV"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtManv.Focus()
            If txtManv.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtManv.Focus()
                If txtTennv.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtTennv.Focus()
                    If txtNgaysinh.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtNgaysinh.Focus()
                        If txtDiachi.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtDiachi.Focus()
                            If txtSodt.Text = "" Then
                                MessageBox.Show("Bạn chưa nhập email", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Else

                                addupdate.Parameters.AddWithValue("@MANV", txtManv.Text)
                                addupdate.Parameters.AddWithValue("@TENNV", txtTennv.Text)
                                addupdate.Parameters.AddWithValue("@NGAYSINH", txtNgaysinh.Text)
                                addupdate.Parameters.AddWithValue("@DIACHI", txtDiachi.Text)
                                addupdate.Parameters.AddWithValue("@SODT", txtSodt.Text)
                                addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                                txtManv.Text = Nothing
                                txtTennv.Text = Nothing
                                txtNgaysinh.Text = Nothing
                                txtDiachi.Text = Nothing
                                txtSodt.Text = Nothing
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        DataGridView1.DataSource = db
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MANV as 'Mã NV' ,TENNV as 'Tên Nhân Viên', NGAYSINH as 'Ngày Sinh', DIACHI as 'Địa Chỉ', SODT from NHANVIEN", conn)

        conn.Open()
        load.Fill(db)
        DataGridView1.DataSource = db.DefaultView
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        Dim delquery As String = "delete from NHANVIEN where MANV=@MANV"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtManv.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtManv.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MANV", txtManv.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtManv.Text = Nothing
                    txtTennv.Text = Nothing
                    txtNgaysinh.Text = Nothing
                    txtDiachi.Text = Nothing
                    txtSodt.Text = Nothing
                    txtManv.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        DataGridView1.DataSource = db
        DataGridView1.DataSource = Nothing
        LoadData()
    End Sub
End Class