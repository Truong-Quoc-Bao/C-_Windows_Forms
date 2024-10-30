using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Windows_Forms_NC_Bai_2
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Label labelMNV;
        private System.Windows.Forms.TextBox TextBoxMNV;
        private System.Windows.Forms.Label labelHoten;
        private System.Windows.Forms.TextBox TextBoxHoten;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.DateTimePicker DatetimePickerNgaySinh;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox TextBoxDiaChi;
        private System.Windows.Forms.GroupBox GroupBoxChucNang;
        private System.Windows.Forms.Button ButtonThem;
        private System.Windows.Forms.Button ButtonXoa;
        private System.Windows.Forms.Button ButtonThoat;
        private System.Windows.Forms.ListView listView1;
        public Form1()
        {
            InitializeComponent();
            InitializeListView();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
        }
        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Mã nhân viên", 70);
            listView1.Columns.Add("Họ tên", 70);
            listView1.Columns.Add("Ngày sinh", 60);
            listView1.Columns.Add("Địa chỉ", 80);

        }
        private void InitializeComponent()
        {
            //khai báo
            this.labelMNV = new Label();
            this.TextBoxMNV = new TextBox();
            this.labelHoten = new Label();
            this.TextBoxHoten = new TextBox();
            this.labelNgaySinh = new Label();
            this.DatetimePickerNgaySinh = new DateTimePicker();
            this.labelDiaChi = new Label();
            this.TextBoxDiaChi = new TextBox();
            this.GroupBoxChucNang = new GroupBox();
            this.ButtonThem = new Button();
            this.ButtonThoat = new Button();
            this.ButtonXoa = new Button();
            this.listView1 = new System.Windows.Forms.ListView();


            this.labelMNV.AutoSize = true;
            this.labelMNV.Location = new System.Drawing.Point(15, 20);
            this.labelMNV.Size = new System.Drawing.Size(20, 15);
            this.labelMNV.Text = "Mã nhân viên:";

            this.TextBoxMNV.AutoSize = true;
            this.TextBoxMNV.Location = new System.Drawing.Point(90, 20);
            this.TextBoxMNV.Size = new System.Drawing.Size(100, 15);
            this.TextBoxHoten.TabIndex = 1;

            this.labelHoten.AutoSize = true;
            this.labelHoten.Location = new System.Drawing.Point(15, 50);
            this.labelHoten.Size = new System.Drawing.Size(20, 15);
            this.labelHoten.Text = "Họ tên:";

            this.TextBoxHoten.AutoSize = true;
            this.TextBoxHoten.Location = new System.Drawing.Point(90, 50);
            this.TextBoxHoten.Size = new System.Drawing.Size(200, 15);
            this.TextBoxHoten.TabIndex = 2;

            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(15, 80);
            this.labelNgaySinh.Size = new System.Drawing.Size(20, 15);
            this.labelNgaySinh.Text = "Ngày sinh:";

            this.DatetimePickerNgaySinh.AutoSize = true;
            this.DatetimePickerNgaySinh.Location = new System.Drawing.Point(90, 80);
            this.DatetimePickerNgaySinh.Size = new System.Drawing.Size(200, 15);
            this.DatetimePickerNgaySinh.Format = DateTimePickerFormat.Custom;
            this.DatetimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.TextBoxHoten.TabIndex = 3;

            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(15, 110);
            this.labelDiaChi.Size = new System.Drawing.Size(20, 15);
            this.labelDiaChi.Text = "Địa chỉ:";

            this.TextBoxDiaChi.AutoSize = true;
            this.TextBoxDiaChi.Location = new System.Drawing.Point(90, 110);
            this.TextBoxDiaChi.Size = new System.Drawing.Size(200, 15);
            this.TextBoxHoten.TabIndex = 4;

            this.GroupBoxChucNang.Controls.Add(this.ButtonThem);
            this.GroupBoxChucNang.Controls.Add(this.ButtonThoat);
            this.GroupBoxChucNang.Controls.Add(this.ButtonXoa);
            this.GroupBoxChucNang.AutoSize = true;
            this.GroupBoxChucNang.Size = new System.Drawing.Size(100, 130);
            this.GroupBoxChucNang.Location = new System.Drawing.Point(308, 20);
            this.GroupBoxChucNang.Text = "Chức năng";

            this.ButtonThem.AutoSize = true;
            this.ButtonThem.Location = new System.Drawing.Point(12, 30);
            this.ButtonThem.Text = "Thêm";
            this.ButtonThem.Click += new EventHandler(this.ButtonThem_Click);

            this.ButtonXoa.AutoSize = true;
            this.ButtonXoa.Location = new System.Drawing.Point(12, 60);
            this.ButtonXoa.Text = "Xóa";
            this.ButtonXoa.Click += new EventHandler(this.ButtonXoa_Click);

            this.ButtonThoat.AutoSize = true;
            this.ButtonThoat.Location = new System.Drawing.Point(12, 90);
            this.ButtonThoat.Text = "Thoát";
            this.ButtonThoat.Click += new EventHandler(this.ButtonThoat_Click);

            this.listView1.AutoSize = true;
            this.listView1.Location = new System.Drawing.Point(8, 140);
            this.listView1.Size = new System.Drawing.Size(280, 160);
            this.listView1.TabIndex = 0;
            this.listView1.Font = new Font("Normal", 7);
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;

            //form
            this.AutoSize = true;
            this.Size = new System.Drawing.Size(430, 350);
            this.Text = "Nhân viên";
            this.Controls.Add(this.labelMNV);
            this.Controls.Add(this.TextBoxMNV);
            this.Controls.Add(this.labelHoten);
            this.Controls.Add(this.TextBoxHoten);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.DatetimePickerNgaySinh);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.TextBoxDiaChi);
            this.Controls.Add(this.GroupBoxChucNang);
            this.Controls.Add(this.listView1);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.SuspendLayout();
        }
        private void ButtonThem_Click(object sender, EventArgs e)
        {
            string inputmnv = this.TextBoxMNV.Text;
            string inputhoten = this.TextBoxHoten.Text;
            DateTime selectedDate = DatetimePickerNgaySinh.Value;
            string inputdiachi = this.TextBoxDiaChi.Text;
            if (string.IsNullOrWhiteSpace(inputmnv))
            {
                MessageBox.Show("Mã nhân viên không được trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(inputhoten))
            {
                MessageBox.Show("Họ tên không được trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrWhiteSpace(inputdiachi))
            {
                MessageBox.Show("Địa chỉ không được trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ListViewItem item = new ListViewItem(inputmnv);
                item.SubItems.Add(inputhoten);
                item.SubItems.Add(selectedDate.ToShortDateString());
                item.SubItems.Add(inputdiachi);
                // Thêm item vào ListView
                listView1.Items.Add(item);
            }
            // Xóa nội dung của các TextBox sau khi thêm
            TextBoxMNV.Clear();
            TextBoxHoten.Clear();
            DatetimePickerNgaySinh.Value = DateTime.Now;
            TextBoxDiaChi.Clear();
        }
        private void ButtonXoa_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count == 0)
            {
                MessageBox.Show("Không có nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult XacNhanXoa = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(XacNhanXoa == DialogResult.Yes)
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    listView1.Items.Remove(selectedItem);
                }

                MessageBox.Show("Nhân viên đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat = MessageBox.Show("Bạn có  muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult thoatesc = MessageBox.Show("Bạn có  muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (thoatesc == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
