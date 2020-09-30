namespace QuanLyThuVien
{
    partial class Form1
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Eye_0 = new System.Windows.Forms.Button();
            this.btn_Eye = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_err = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Teal;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(363, 1);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(35, 35);
            this.btn_Exit.TabIndex = 26;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Adobe Hebrew", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.Black;
            this.btn_Login.Location = new System.Drawing.Point(39, 383);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(305, 49);
            this.btn_Login.TabIndex = 22;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(35, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 1);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(35, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 1);
            this.label1.TabIndex = 20;
            this.label1.Text = "label1";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Teal;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Location = new System.Drawing.Point(34, 328);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(270, 30);
            this.txt_Password.TabIndex = 17;
            this.txt_Password.Text = "Enter Password";
            this.txt_Password.Enter += new System.EventHandler(this.txt_Password_Enter);
            this.txt_Password.Leave += new System.EventHandler(this.txt_Password_Leave);
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.Teal;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.Black;
            this.txt_Username.Location = new System.Drawing.Point(34, 231);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(282, 30);
            this.txt_Username.TabIndex = 16;
            this.txt_Username.Text = "Enter Username";
            this.txt_Username.Enter += new System.EventHandler(this.txt_Username_Enter);
            this.txt_Username.Leave += new System.EventHandler(this.txt_Username_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::QuanLyThuVien.Properties.Resources._1200px_User_font_awesome_svg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ErrorImage = global::QuanLyThuVien.Properties.Resources._1200px_User_font_awesome1;
            this.pictureBox1.Image = global::QuanLyThuVien.Properties.Resources._1200px_User_font_awesome_svg;
            this.pictureBox1.InitialImage = global::QuanLyThuVien.Properties.Resources._1200px_User_font_awesome_svg;
            this.pictureBox1.Location = new System.Drawing.Point(116, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 123);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Eye_0
            // 
            this.btn_Eye_0.BackColor = System.Drawing.Color.Teal;
            this.btn_Eye_0.FlatAppearance.BorderSize = 0;
            this.btn_Eye_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eye_0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Eye_0.Image = global::QuanLyThuVien.Properties.Resources.visibility__1_1;
            this.btn_Eye_0.Location = new System.Drawing.Point(304, 313);
            this.btn_Eye_0.Name = "btn_Eye_0";
            this.btn_Eye_0.Size = new System.Drawing.Size(50, 50);
            this.btn_Eye_0.TabIndex = 29;
            this.btn_Eye_0.UseVisualStyleBackColor = false;
            this.btn_Eye_0.Click += new System.EventHandler(this.btn_Eye_0_Click);
            // 
            // btn_Eye
            // 
            this.btn_Eye.BackColor = System.Drawing.Color.Teal;
            this.btn_Eye.FlatAppearance.BorderSize = 0;
            this.btn_Eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eye.ForeColor = System.Drawing.Color.Red;
            this.btn_Eye.Image = global::QuanLyThuVien.Properties.Resources.visibility;
            this.btn_Eye.Location = new System.Drawing.Point(302, 313);
            this.btn_Eye.Name = "btn_Eye";
            this.btn_Eye.Size = new System.Drawing.Size(50, 50);
            this.btn_Eye.TabIndex = 28;
            this.btn_Eye.UseVisualStyleBackColor = false;
            this.btn_Eye.Visible = false;
            this.btn_Eye.Click += new System.EventHandler(this.btn_Eye_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Adobe Hebrew", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 46);
            this.label3.TabIndex = 31;
            this.label3.Text = "Login here";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Adobe Hebrew", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Lost your password?";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Adobe Hebrew", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 34);
            this.label5.TabIndex = 33;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Adobe Hebrew", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 37);
            this.label6.TabIndex = 34;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Adobe Hebrew", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Don\'t have an account?";
            // 
            // lb_err
            // 
            this.lb_err.Font = new System.Drawing.Font("Adobe Hebrew", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_err.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lb_err.Location = new System.Drawing.Point(36, 481);
            this.lb_err.Name = "lb_err";
            this.lb_err.Size = new System.Drawing.Size(308, 56);
            this.lb_err.TabIndex = 36;
            this.lb_err.Text = "Incorrect account information or password";
            this.lb_err.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lb_err.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(400, 573);
            this.Controls.Add(this.lb_err);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Eye_0);
            this.Controls.Add(this.btn_Eye);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Eye_0;
        private System.Windows.Forms.Button btn_Eye;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_err;
    }
}

