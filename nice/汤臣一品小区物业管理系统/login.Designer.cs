namespace 汤臣一品小区物业管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
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
            this.txtValidCode = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.PassWord = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.UserName = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources._26bb5b3086ed7da86e;
            this.pictureBox1.Location = new System.Drawing.Point(105, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources._5ef4c93437737f0;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(106, 280);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources.favicon;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(104, 331);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 31);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // picValidCode
            // 
            this.picValidCode.Location = new System.Drawing.Point(244, 333);
            this.picValidCode.Name = "picValidCode";
            this.picValidCode.Size = new System.Drawing.Size(88, 31);
            this.picValidCode.TabIndex = 7;
            this.picValidCode.TabStop = false;
            this.picValidCode.Click += new System.EventHandler(this.picValidCode_Click_1);
            // 
            // Denglu
            // 
            this.Denglu.BackColor = System.Drawing.Color.Transparent;
            this.Denglu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Denglu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Denglu.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.Denglu.Location = new System.Drawing.Point(100, 404);
            this.Denglu.Name = "Denglu";
            this.Denglu.Size = new System.Drawing.Size(233, 35);
            this.Denglu.TabIndex = 8;
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
            this.ZhuChe.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ZhuChe.LinkColor = System.Drawing.Color.Gray;
            this.ZhuChe.Location = new System.Drawing.Point(110, 373);
            this.ZhuChe.Name = "ZhuChe";
            this.ZhuChe.Size = new System.Drawing.Size(69, 20);
            this.ZhuChe.TabIndex = 9;
            this.ZhuChe.TabStop = true;
            this.ZhuChe.Text = "立即注册";
            this.ZhuChe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ZhuChe_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(240, 373);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(84, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "忘记密码？";
            // 
            // txtValidCode
            // 
            this.txtValidCode.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.txtValidCode.Location = new System.Drawing.Point(141, 333);
            this.txtValidCode.Name = "txtValidCode";
            this.txtValidCode.Size = new System.Drawing.Size(97, 31);
            this.txtValidCode.TabIndex = 6;
            this.txtValidCode.WatermarkText = "验证码";
            // 
            // PassWord
            // 
            this.PassWord.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.PassWord.Location = new System.Drawing.Point(136, 281);
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(198, 34);
            this.PassWord.TabIndex = 4;
            this.PassWord.WatermarkText = "请输入密码";
            // 
            // UserName
            // 
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserName.Location = new System.Drawing.Point(136, 229);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(198, 34);
            this.UserName.TabIndex = 3;
            this.UserName.WatermarkText = "请输入账号";
            // 
            // Form1
            // 
            this.AcceptButton = this.Denglu;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources._01773;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(435, 500);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ZhuChe);
            this.Controls.Add(this.Denglu);
            this.Controls.Add(this.picValidCode);
            this.Controls.Add(this.txtValidCode);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "汤臣一品小区物业管理系统";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picValidCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private WatermarkTextBox UserName;
        private WatermarkTextBox PassWord;
        private System.Windows.Forms.PictureBox pictureBox3;
        private WatermarkTextBox txtValidCode;
        private System.Windows.Forms.PictureBox picValidCode;
        private System.Windows.Forms.Button Denglu;
        private System.Windows.Forms.LinkLabel ZhuChe;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

