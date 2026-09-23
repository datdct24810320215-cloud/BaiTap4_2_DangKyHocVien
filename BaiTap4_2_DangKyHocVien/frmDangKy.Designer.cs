namespace BaiTap4_2_DangKyHocVien
{
    partial class frmDangKy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHoTen = new Label();
            lblSDT = new Label();
            lblNgaySinh = new Label();
            lblKhoaHoc = new Label();
            txtHoTen = new TextBox();
            mtxtPhone = new MaskedTextBox();
            dtpBirthDate = new DateTimePicker();
            cboCourse = new ComboBox();
            grpGioiTinh = new GroupBox();
            rdoNam = new RadioButton();
            rdoNu = new RadioButton();
            chkDocSach = new CheckBox();
            chkNgheNhac = new CheckBox();
            chkTheThao = new CheckBox();
            btnDangKy = new Button();
            grpGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(38, 30);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(43, 15);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(38, 66);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(76, 15);
            lblSDT.TabIndex = 0;
            lblSDT.Text = "Số điện thoại";
            lblSDT.Click += label2_Click;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(38, 109);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(60, 15);
            lblNgaySinh.TabIndex = 0;
            lblNgaySinh.Text = "Ngày sinh";
            lblNgaySinh.Click += label3_Click;
            // 
            // lblKhoaHoc
            // 
            lblKhoaHoc.AutoSize = true;
            lblKhoaHoc.Location = new Point(38, 152);
            lblKhoaHoc.Name = "lblKhoaHoc";
            lblKhoaHoc.Size = new Size(57, 15);
            lblKhoaHoc.TabIndex = 0;
            lblKhoaHoc.Text = "Khóa học";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(124, 30);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(455, 23);
            txtHoTen.TabIndex = 1;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(124, 63);
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(455, 23);
            mtxtPhone.TabIndex = 2;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(124, 103);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(229, 23);
            dtpBirthDate.TabIndex = 3;
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(124, 152);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(229, 23);
            cboCourse.TabIndex = 4;
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(rdoNam);
            grpGioiTinh.Controls.Add(rdoNu);
            grpGioiTinh.Location = new Point(379, 103);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(200, 72);
            grpGioiTinh.TabIndex = 5;
            grpGioiTinh.TabStop = false;
            grpGioiTinh.Text = "Giới tính";
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(32, 22);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(51, 19);
            rdoNam.TabIndex = 1;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(32, 47);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(41, 19);
            rdoNu.TabIndex = 0;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // chkDocSach
            // 
            chkDocSach.AutoSize = true;
            chkDocSach.Location = new Point(124, 216);
            chkDocSach.Name = "chkDocSach";
            chkDocSach.Size = new Size(74, 19);
            chkDocSach.TabIndex = 6;
            chkDocSach.Text = "Đọc sách";
            chkDocSach.UseVisualStyleBackColor = true;
            // 
            // chkNgheNhac
            // 
            chkNgheNhac.AutoSize = true;
            chkNgheNhac.Location = new Point(124, 241);
            chkNgheNhac.Name = "chkNgheNhac";
            chkNgheNhac.Size = new Size(84, 19);
            chkNgheNhac.TabIndex = 6;
            chkNgheNhac.Text = "Nghe nhạc";
            chkNgheNhac.UseVisualStyleBackColor = true;
            // 
            // chkTheThao
            // 
            chkTheThao.AutoSize = true;
            chkTheThao.Location = new Point(124, 266);
            chkTheThao.Name = "chkTheThao";
            chkTheThao.Size = new Size(72, 19);
            chkTheThao.TabIndex = 6;
            chkTheThao.Text = "Thể thao";
            chkTheThao.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(598, 345);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 37);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // frmDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangKy);
            Controls.Add(chkTheThao);
            Controls.Add(chkNgheNhac);
            Controls.Add(chkDocSach);
            Controls.Add(grpGioiTinh);
            Controls.Add(cboCourse);
            Controls.Add(dtpBirthDate);
            Controls.Add(mtxtPhone);
            Controls.Add(txtHoTen);
            Controls.Add(lblKhoaHoc);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Name = "frmDangKy";
            Text = "Đăng ký học viên";
            Load += frmDangKy_Load;
            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblSDT;
        private Label lblNgaySinh;
        private Label lblKhoaHoc;
        private TextBox txtHoTen;
        private MaskedTextBox mtxtPhone;
        private DateTimePicker dtpBirthDate;
        private ComboBox cboCourse;
        private GroupBox grpGioiTinh;
        private RadioButton rdoNam;
        private RadioButton rdoNu;
        private CheckBox chkDocSach;
        private CheckBox chkNgheNhac;
        private CheckBox chkTheThao;
        private Button btnDangKy;
    }
}
