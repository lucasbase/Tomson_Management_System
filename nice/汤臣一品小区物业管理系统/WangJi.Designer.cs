namespace 汤臣一品小区物业管理系统
{
    partial class WangJi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WangJi));
            this.account = new System.Windows.Forms.Label();
            this.Phone_Num = new System.Windows.Forms.Label();
            this.ma = new System.Windows.Forms.Label();
            this.btn_Downstep = new System.Windows.Forms.Button();
            this.yanzheng = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Upstep = new System.Windows.Forms.Button();
            this.txtValidCode = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.phone = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.username = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.BackColor = System.Drawing.Color.Transparent;
            this.account.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.account.Location = new System.Drawing.Point(298, 199);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(72, 27);
            this.account.TabIndex = 3;
            this.account.Text = "账号：";
            // 
            // Phone_Num
            // 
            this.Phone_Num.AutoSize = true;
            this.Phone_Num.BackColor = System.Drawing.Color.Transparent;
            this.Phone_Num.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Phone_Num.Location = new System.Drawing.Point(278, 263);
            this.Phone_Num.Name = "Phone_Num";
            this.Phone_Num.Size = new System.Drawing.Size(92, 27);
            this.Phone_Num.TabIndex = 4;
            this.Phone_Num.Text = "手机号：";
            // 
            // ma
            // 
            this.ma.AutoSize = true;
            this.ma.BackColor = System.Drawing.Color.Transparent;
            this.ma.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ma.Location = new System.Drawing.Point(279, 324);
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(92, 27);
            this.ma.TabIndex = 5;
            this.ma.Text = "验证码：";
            // 
            // btn_Downstep
            // 
            this.btn_Downstep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_Downstep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Downstep.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Downstep.ForeColor = System.Drawing.Color.White;
            this.btn_Downstep.Location = new System.Drawing.Point(486, 398);
            this.btn_Downstep.Name = "btn_Downstep";
            this.btn_Downstep.Size = new System.Drawing.Size(144, 37);
            this.btn_Downstep.TabIndex = 5;
            this.btn_Downstep.Text = "下一步";
            this.btn_Downstep.UseVisualStyleBackColor = false;
            this.btn_Downstep.Click += new System.EventHandler(this.btn_Downstep_Click);
            // 
            // yanzheng
            // 
            this.yanzheng.BackColor = System.Drawing.Color.Salmon;
            this.yanzheng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yanzheng.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.yanzheng.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yanzheng.Location = new System.Drawing.Point(646, 322);
            this.yanzheng.Name = "yanzheng";
            this.yanzheng.Size = new System.Drawing.Size(127, 35);
            this.yanzheng.TabIndex = 3;
            this.yanzheng.Text = "获取验证码";
            this.yanzheng.UseVisualStyleBackColor = false;
            this.yanzheng.Click += new System.EventHandler(this.yanzheng_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btn_Upstep
            // 
            this.btn_Upstep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(174)))), ((int)(((byte)(239)))));
            this.btn_Upstep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Upstep.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Upstep.ForeColor = System.Drawing.Color.White;
            this.btn_Upstep.Location = new System.Drawing.Point(303, 398);
            this.btn_Upstep.Name = "btn_Upstep";
            this.btn_Upstep.Size = new System.Drawing.Size(144, 37);
            this.btn_Upstep.TabIndex = 4;
            this.btn_Upstep.Text = "上一步";
            this.btn_Upstep.UseVisualStyleBackColor = false;
            this.btn_Upstep.Click += new System.EventHandler(this.btn_Upstep_Click);
            // 
            // txtValidCode
            // 
            this.txtValidCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtValidCode.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtValidCode.Location = new System.Drawing.Point(377, 321);
            this.txtValidCode.Name = "txtValidCode";
            this.txtValidCode.Size = new System.Drawing.Size(229, 34);
            this.txtValidCode.TabIndex = 2;
            this.txtValidCode.WatermarkText = "请输入验证码";
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.phone.ImeMode = System.Windows.Forms.ImeMode.On;
            this.phone.Location = new System.Drawing.Point(376, 260);
            this.phone.MaxLength = 11;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(230, 34);
            this.phone.TabIndex = 1;
            this.phone.WatermarkText = "请输入你的电话";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.username.ImeMode = System.Windows.Forms.ImeMode.On;
            this.username.Location = new System.Drawing.Point(376, 199);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(230, 34);
            this.username.TabIndex = 0;
            this.username.WatermarkText = "请输入你的账号";
            // 
            // WangJi
            // 
            this.AcceptButton = this.btn_Downstep;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources.忘记密码5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(908, 496);
            this.Controls.Add(this.btn_Upstep);
            this.Controls.Add(this.yanzheng);
            this.Controls.Add(this.btn_Downstep);
            this.Controls.Add(this.txtValidCode);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Phone_Num);
            this.Controls.Add(this.account);
            this.Controls.Add(this.ma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WangJi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WangJi";
            this.Load += new System.EventHandler(this.WangJi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WatermarkTextBox username;
        private WatermarkTextBox phone;
        private WatermarkTextBox txtValidCode;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label Phone_Num;
        private System.Windows.Forms.Label ma;
        private System.Windows.Forms.Button btn_Downstep;
        private System.Windows.Forms.Button yanzheng;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Upstep;
    }
}