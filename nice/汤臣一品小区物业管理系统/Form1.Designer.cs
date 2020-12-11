namespace 汤臣一品小区物业管理系统
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picValidCode = new System.Windows.Forms.PictureBox();
            this.Denglu = new System.Windows.Forms.Button();
            this.ZhuChe = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.max = new System.Windows.Forms.Label();
            this.small = new System.Windows.Forms.Label();
            this.cbb_Type = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtValidCode = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.PassWord = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.UserName = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources.icon_用户11;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(224, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 29);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources.icon_密码1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(225, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 29);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources.icon_验证码2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(225, 324);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 29);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // picValidCode
            // 
            this.picValidCode.BackColor = System.Drawing.Color.Transparent;
            this.picValidCode.Location = new System.Drawing.Point(364, 324);
            this.picValidCode.Name = "picValidCode";
            this.picValidCode.Size = new System.Drawing.Size(88, 31);
            this.picValidCode.TabIndex = 6;
            this.picValidCode.TabStop = false;
            this.picValidCode.Click += new System.EventHandler(this.picValidCode_Click);
            // 
            // Denglu
            // 
            this.Denglu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Denglu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Denglu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Denglu.FlatAppearance.BorderSize = 0;
            this.Denglu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Denglu.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.Denglu.ForeColor = System.Drawing.Color.White;
            this.Denglu.Location = new System.Drawing.Point(225, 402);
            this.Denglu.Name = "Denglu";
            this.Denglu.Size = new System.Drawing.Size(233, 35);
            this.Denglu.TabIndex = 6;
            this.Denglu.Text = "登录";
            this.Denglu.UseVisualStyleBackColor = false;
            this.Denglu.Click += new System.EventHandler(this.Denglu_Click);
            // 
            // ZhuChe
            // 
            this.ZhuChe.AutoSize = true;
            this.ZhuChe.BackColor = System.Drawing.Color.Transparent;
            this.ZhuChe.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.ZhuChe.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.ZhuChe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ZhuChe.LinkColor = System.Drawing.Color.Transparent;
            this.ZhuChe.Location = new System.Drawing.Point(230, 363);
            this.ZhuChe.Name = "ZhuChe";
            this.ZhuChe.Size = new System.Drawing.Size(69, 20);
            this.ZhuChe.TabIndex = 4;
            this.ZhuChe.TabStop = true;
            this.ZhuChe.Text = "用户注册";
            this.ZhuChe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ZhuChe_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.LinkColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Location = new System.Drawing.Point(383, 363);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "忘记密码？";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.Transparent;
            this.max.Image = global::汤臣一品小区物业管理系统.Properties.Resources._2;
            this.max.Location = new System.Drawing.Point(654, -1);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(35, 29);
            this.max.TabIndex = 10;
            this.max.MouseClick += new System.Windows.Forms.MouseEventHandler(this.max_MouseClick);
            this.max.MouseEnter += new System.EventHandler(this.max_MouseEnter);
            this.max.MouseLeave += new System.EventHandler(this.max_MouseLeave);
            this.max.MouseHover += new System.EventHandler(this.max_MouseHover);
            // 
            // small
            // 
            this.small.BackColor = System.Drawing.Color.Transparent;
            this.small.Image = global::汤臣一品小区物业管理系统.Properties.Resources._123456;
            this.small.Location = new System.Drawing.Point(619, -1);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(35, 29);
            this.small.TabIndex = 11;
            this.small.MouseClick += new System.Windows.Forms.MouseEventHandler(this.small_MouseClick);
            this.small.MouseEnter += new System.EventHandler(this.small_MouseEnter);
            this.small.MouseLeave += new System.EventHandler(this.small_MouseLeave);
            this.small.MouseHover += new System.EventHandler(this.small_MouseHover);
            // 
            // cbb_Type
            // 
            this.cbb_Type.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbb_Type.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbb_Type.FormattingEnabled = true;
            this.cbb_Type.Items.AddRange(new object[] {
            "管理员",
            "业主",
            "超级管理员"});
            this.cbb_Type.Location = new System.Drawing.Point(256, 174);
            this.cbb_Type.Name = "cbb_Type";
            this.cbb_Type.Size = new System.Drawing.Size(198, 32);
            this.cbb_Type.TabIndex = 0;
            this.cbb_Type.Text = "管理员";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources.选择1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(224, 174);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 29);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // txtValidCode
            // 
            this.txtValidCode.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.txtValidCode.Location = new System.Drawing.Point(257, 323);
            this.txtValidCode.Name = "txtValidCode";
            this.txtValidCode.Size = new System.Drawing.Size(97, 31);
            this.txtValidCode.TabIndex = 3;
            this.txtValidCode.WatermarkText = "验证码";
            // 
            // PassWord
            // 
            this.PassWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.PassWord.Location = new System.Drawing.Point(256, 271);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(198, 34);
            this.PassWord.TabIndex = 2;
            this.PassWord.UseSystemPasswordChar = true;
            this.PassWord.WatermarkText = "请输入密码";
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.UserName.Location = new System.Drawing.Point(256, 219);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(198, 34);
            this.UserName.TabIndex = 1;
            this.UserName.WatermarkText = "请输入账号";
            // 
            // Form1
            // 
            this.AcceptButton = this.Denglu;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources.登录界面背景图2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 520);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cbb_Type);
            this.Controls.Add(this.small);
            this.Controls.Add(this.max);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ZhuChe);
            this.Controls.Add(this.Denglu);
            this.Controls.Add(this.picValidCode);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtValidCode);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "汤臣一品小区物业管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WatermarkTextBox UserName;
        private WatermarkTextBox PassWord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private WatermarkTextBox txtValidCode;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picValidCode;
        private System.Windows.Forms.Button Denglu;
        private System.Windows.Forms.LinkLabel ZhuChe;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.Label small;
        private System.Windows.Forms.ComboBox cbb_Type;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}