namespace QuanLyThuVien
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_dausach = new System.Windows.Forms.Button();
            this.btn_hocvien = new System.Windows.Forms.Button();
            this.btn_sach = new System.Windows.Forms.Button();
            this.btn_muonsach = new System.Windows.Forms.Button();
            this.btn_trasach = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lb_control = new System.Windows.Forms.Label();
            this.pn_trangchu = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1250, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thư viện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.lb_control);
            this.groupBox1.Controls.Add(this.btn_exit);
            this.groupBox1.Controls.Add(this.btn_trasach);
            this.groupBox1.Controls.Add(this.btn_muonsach);
            this.groupBox1.Controls.Add(this.btn_sach);
            this.groupBox1.Controls.Add(this.btn_hocvien);
            this.groupBox1.Controls.Add(this.btn_dausach);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 603);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_dausach
            // 
            this.btn_dausach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_dausach.FlatAppearance.BorderSize = 0;
            this.btn_dausach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dausach.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dausach.Location = new System.Drawing.Point(0, 106);
            this.btn_dausach.Name = "btn_dausach";
            this.btn_dausach.Size = new System.Drawing.Size(200, 80);
            this.btn_dausach.TabIndex = 1;
            this.btn_dausach.Text = "Đầu sách";
            this.btn_dausach.UseVisualStyleBackColor = false;
            this.btn_dausach.Click += new System.EventHandler(this.btn_dausach_Click);
            // 
            // btn_hocvien
            // 
            this.btn_hocvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_hocvien.FlatAppearance.BorderSize = 0;
            this.btn_hocvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hocvien.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hocvien.Location = new System.Drawing.Point(0, 3);
            this.btn_hocvien.Name = "btn_hocvien";
            this.btn_hocvien.Size = new System.Drawing.Size(200, 80);
            this.btn_hocvien.TabIndex = 2;
            this.btn_hocvien.Text = "Học viên";
            this.btn_hocvien.UseVisualStyleBackColor = false;
            this.btn_hocvien.Click += new System.EventHandler(this.btn_hocvien_Click);
            // 
            // btn_sach
            // 
            this.btn_sach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sach.FlatAppearance.BorderSize = 0;
            this.btn_sach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sach.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sach.Location = new System.Drawing.Point(0, 209);
            this.btn_sach.Name = "btn_sach";
            this.btn_sach.Size = new System.Drawing.Size(200, 80);
            this.btn_sach.TabIndex = 3;
            this.btn_sach.Text = "Sách";
            this.btn_sach.UseVisualStyleBackColor = false;
            this.btn_sach.Click += new System.EventHandler(this.btn_sach_Click);
            // 
            // btn_muonsach
            // 
            this.btn_muonsach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_muonsach.FlatAppearance.BorderSize = 0;
            this.btn_muonsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muonsach.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muonsach.Location = new System.Drawing.Point(0, 312);
            this.btn_muonsach.Name = "btn_muonsach";
            this.btn_muonsach.Size = new System.Drawing.Size(200, 80);
            this.btn_muonsach.TabIndex = 4;
            this.btn_muonsach.Text = "Mượn sách";
            this.btn_muonsach.UseVisualStyleBackColor = false;
            this.btn_muonsach.Click += new System.EventHandler(this.btn_muonsach_Click);
            // 
            // btn_trasach
            // 
            this.btn_trasach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_trasach.FlatAppearance.BorderSize = 0;
            this.btn_trasach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trasach.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trasach.Location = new System.Drawing.Point(0, 415);
            this.btn_trasach.Name = "btn_trasach";
            this.btn_trasach.Size = new System.Drawing.Size(200, 80);
            this.btn_trasach.TabIndex = 5;
            this.btn_trasach.Text = "Trả sách";
            this.btn_trasach.UseVisualStyleBackColor = false;
            this.btn_trasach.Click += new System.EventHandler(this.btn_trasach_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(0, 518);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(200, 84);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lb_control
            // 
            this.lb_control.BackColor = System.Drawing.Color.MediumPurple;
            this.lb_control.Location = new System.Drawing.Point(0, 3);
            this.lb_control.Name = "lb_control";
            this.lb_control.Size = new System.Drawing.Size(10, 80);
            this.lb_control.TabIndex = 7;
            this.lb_control.Visible = false;
            // 
            // pn_trangchu
            // 
            this.pn_trangchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pn_trangchu.BackgroundImage = global::QuanLyThuVien.Properties.Resources.ok1;
            this.pn_trangchu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_trangchu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_trangchu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pn_trangchu.Location = new System.Drawing.Point(200, 93);
            this.pn_trangchu.Name = "pn_trangchu";
            this.pn_trangchu.Size = new System.Drawing.Size(1050, 603);
            this.pn_trangchu.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1250, 696);
            this.Controls.Add(this.pn_trangchu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_trasach;
        private System.Windows.Forms.Button btn_muonsach;
        private System.Windows.Forms.Button btn_sach;
        private System.Windows.Forms.Button btn_hocvien;
        private System.Windows.Forms.Button btn_dausach;
        private System.Windows.Forms.Panel pn_trangchu;
        private System.Windows.Forms.Label lb_control;
    }
}