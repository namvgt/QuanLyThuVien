using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_hocvien_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 2);
        }

        private void btn_dausach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 69);
        }

        private void btn_sach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 136);
        }

        private void btn_muonsach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 203);
        }

        private void btn_trasach_Click(object sender, EventArgs e)
        {
            lb_control.Visible = true;
            lb_control.Location = new Point(0, 270);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
