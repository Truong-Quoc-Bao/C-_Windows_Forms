using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp_Bai_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CenterLabelHorizontally(); // Gọi hàm căn giữa label theo chiều ngang khi form được tải
        }

        private void CenterLabelHorizontally()
        {
            // Tính toán vị trí để căn giữa label1 theo chiều ngang trên form
            int x = (this.ClientSize.Width - this.label_header.Width) / 2; // Tính toán vị trí x
            this.label_header.Location = new System.Drawing.Point(x, this.label_header.Location.Y); // Cập nhật vị trí x, y giữ nguyên
        }
        private void InitializeComponent()
        {
            // khai báo 
            this.label_header = new System.Windows.Forms.Label();
            this.label_so = new System.Windows.Forms.Label();
            this.textBox_so = new System.Windows.Forms.TextBox();
            this.label_kq = new System.Windows.Forms.Label();
            this.textBox_kq = new System.Windows.Forms.TextBox();
            this.groupbox_phep_toan  = new System.Windows.Forms.GroupBox();
            this.button_binh_phuong = new System.Windows.Forms.Button();
            this.button_lap_phuong = new System.Windows.Forms.Button();
            this.button_giai_thua = new System.Windows.Forms.Button();
            this.button_out = new System.Windows.Forms.Button();

            this.SuspendLayout();
           
            // label1
            this.label_header.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_header.ForeColor = System.Drawing.Color.Black;
            this.label_header.Location = new System.Drawing.Point(0, 10);
            this.label_header.Name = "label1";
            this.label_header.Size = new System.Drawing.Size(150, 20);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Chương trình tính toán";
            this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
           
           
            //
            this.label_so.AutoSize = true;
            this.label_so.Text = "Số: ";
            this.label_so.Location = new System.Drawing.Point(30, 35);

            // textBox1
            this.textBox_so.Location = new System.Drawing.Point(55, 35);
            this.textBox_so.Name = "";
            this.textBox_so.Size = new System.Drawing.Size(45, 15);
            this.textBox_so.Text = " "; // rỗng ban đầu
            this.textBox_so.TabIndex = 1;
            // this.textBox_so.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox_so.KeyPress += new KeyPressEventHandler(this.textBox_so_KeyPress);

            //
            this.label_kq.AutoSize = true;
            this.label_kq.Text = "Kết quả: ";
            this.label_kq.Location = new System.Drawing.Point(5, 60);


            //
            this.textBox_kq.AutoSize = true;
            this.textBox_kq.Location = new System.Drawing.Point(55, 60);
            this.textBox_kq.Name = "";
            this.textBox_kq.Text = "";
            this.textBox_kq.ReadOnly = true;
            this.textBox_kq.Enabled = false;
            this.textBox_kq.Size = new System.Drawing.Size(90, 15);
            //this.textBox_kq.TextChanged += new System.EventHandler(this.textBox2_TextChanged);

            // gán button vào  groupbox và 
            this.groupbox_phep_toan.Controls.Add(this.button_binh_phuong);
            this.groupbox_phep_toan.Controls.Add(this.button_lap_phuong);
            this.groupbox_phep_toan.Controls.Add(this.button_giai_thua);
            this.groupbox_phep_toan.Location = new System.Drawing.Point(150, 35);
            this.groupbox_phep_toan.Name = "groupBox1";
            this.groupbox_phep_toan.Size = new System.Drawing.Size(100, 95);
            this.groupbox_phep_toan.TabIndex = 0;
            this.groupbox_phep_toan.TabStop = false;
            this.groupbox_phep_toan.ForeColor = System.Drawing.Color.Blue;
            this.groupbox_phep_toan.Text = "Phép toán";

            //
            this.button_binh_phuong.AutoSize = true;
            this.button_binh_phuong.Location = new System.Drawing.Point(15, 15);
            this.button_binh_phuong.Text = "Bình phương";
            this.button_binh_phuong.ForeColor = System.Drawing.Color.Black;
            this.button_binh_phuong.Click += new EventHandler(this.button_binh_phuong_Click); 
            this.button_binh_phuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button_binh_phuong_KeyDown);


            //
            this.button_lap_phuong.AutoSize = true;
            this.button_lap_phuong.Location = new System.Drawing.Point(15, 40);
            this.button_lap_phuong.Text = "Lập phương";
            this.button_lap_phuong.ForeColor = System.Drawing.Color.Black;
            this.button_lap_phuong.Click += new EventHandler(this.button_lap_phuong_Click);

            //
            this.button_giai_thua.AutoSize = true;
            this.button_giai_thua.Location = new System.Drawing.Point(15, 65);
            this.button_giai_thua.Text = "Giai thừa";
            this.button_giai_thua.ForeColor = System.Drawing.Color.Black;
            this.button_giai_thua.Click += new EventHandler(this.button_giai_thua_Click);

            //
            this.button_out.AutoSize = true;
            this.button_out.Location = new System.Drawing.Point(70, 105);
            this.button_out.Text = "Thoát";
            this.button_out.Click += new EventHandler(this.button_out_Click);


            // Form1
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(260, 140);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.label_so);
            this.Controls.Add(this.textBox_so);
            this.Controls.Add(this.label_kq);
            this.Controls.Add(this.textBox_kq);
            this.Controls.Add(this.groupbox_phep_toan);
            this.Controls.Add(this.button_out);
            this.Name = "Form1";
            this.Text = "Tính toán";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void textBox_so_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép nhập số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Phải nhập số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_binh_phuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_binh_phuong.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        private void button_binh_phuong_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox_so.Text, out int inputNumber))
            {
                int resultBinhPhuong = (int)Math.Pow(inputNumber, 2);
                textBox_kq.Text = resultBinhPhuong.ToString();
            }
            else
            {
                MessageBox.Show("Phải nhập số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_lap_phuong_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_so.Text, out int inputNumber))
            {
                int resultLaplPhuong = (int)Math.Pow(inputNumber, 3);

                textBox_kq.Text = resultLaplPhuong.ToString();
            }
            else
            {
                MessageBox.Show("Phải là số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_giai_thua_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox_so.Text, out int inputNumber))

            {
                if(inputNumber < 0)
                {
                    throw new ArgumentOutOfRangeException("inputNumber)", "Số không được âm.");
                    return;
                }
                int resultGiaiThua = 1;
                for(int i =1; i <= inputNumber; i++)
                {
                    resultGiaiThua = resultGiaiThua * i;
                }
                textBox_kq.Text = resultGiaiThua.ToString();
            }
            else
            {
                MessageBox.Show("Phải là số", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_out_Click(object sender, EventArgs e) 
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    this.Close();
                }
            }    
        }
    }
}
