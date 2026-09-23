namespace BaiTap4_2_DangKyHocVien
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void frmDangKy_Load(object sender, EventArgs e)
        {
            // Tạo danh sách Khóa học giả lập
            var danhSachKhoaHoc = new[]
            {
        new { MaKhoa = "CNTT", TenKhoa = "Công nghệ thông tin" },
        new { MaKhoa = "KT", TenKhoa = "Kế toán" },
        new { MaKhoa = "QTKD", TenKhoa = "Quản trị kinh doanh" },
        new { MaKhoa = "NN", TenKhoa = "Ngôn ngữ Anh" }
    };

            // Nạp dữ liệu vào ComboBox
            cboCourse.DataSource = danhSachKhoaHoc;
            cboCourse.DisplayMember = "TenKhoa"; // Hiển thị tên khóa học
            cboCourse.ValueMember = "MaKhoa";    // Giá trị ngầm là mã khóa học
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Lấy thông tin cơ bản
            string hoTen = txtHoTen.Text;
            string sdt = mtxtPhone.Text;
            string ngaySinh = dtpBirthDate.Value.ToString("dd/MM/yyyy");
            string khoaHoc = cboCourse.Text; // Lấy tên khóa học đang hiển thị

            // 2. Xử lý Giới tính (RadioButton)
            string gioiTinh = "Chưa chọn";
            if (rdoNam.Checked) gioiTinh = "Nam";
            else if (rdoNu.Checked) gioiTinh = "Nữ";

            // 3. Xử lý Sở thích (CheckBox)
            string soThich = "";
            if (chkDocSach.Checked) soThich += "Đọc sách, ";
            if (chkNgheNhac.Checked) soThich += "Nghe nhạc, ";
            if (chkTheThao.Checked) soThich += "Thể thao, ";

            // Cắt bỏ dấu phẩy cuối cùng nếu có
            if (soThich.EndsWith(", ")) soThich = soThich.Substring(0, soThich.Length - 2);

            // 4. Kiểm tra dữ liệu rỗng (Validation cơ bản)
            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Tổng hợp và hiển thị thông tin
            string thongTin = $"--- THÔNG TIN ĐĂNG KÝ ---\n" +
                              $"Họ tên: {hoTen}\n" +
                              $"SĐT: {sdt}\n" +
                              $"Ngày sinh: {ngaySinh}\n" +
                              $"Khóa học: {khoaHoc}\n" +
                              $"Giới tính: {gioiTinh}\n" +
                              $"Sở thích: {soThich}";

            MessageBox.Show(thongTin, "Kết quả đăng ký",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
