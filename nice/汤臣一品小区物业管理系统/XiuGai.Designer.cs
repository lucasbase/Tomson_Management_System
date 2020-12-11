namespace 汤臣一品小区物业管理系统
{
    partial class XiuGai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XiuGai));
            this.affirm_pwd = new System.Windows.Forms.Label();
            this.newpwd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.password = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.newpassword = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.SuspendLayout();
            // 
            // affirm_pwd
            // 
            this.affirm_pwd.AutoSize = true;
            this.affirm_pwd.BackColor = System.Drawing.Color.Transparent;
            this.affirm_pwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.affirm_pwd.Location = new System.Drawing.Point(300, 276);
            this.affirm_pwd.Name = "affirm_pwd";
            this.affirm_pwd.Size = new System.Drawing.Size(112, 27);
            this.affirm_pwd.TabIndex = 0;
            this.affirm_pwd.Text = "确认密码：";
            // 
            // newpwd
            // 
            this.newpwd.AutoSize = true;
            this.newpwd.BackColor = System.Drawing.Color.Transparent;
            this.newpwd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newpwd.Location = new System.Drawing.Point(320, 207);
            this.newpwd.Name = "newpwd";
            this.newpwd.Size = new System.Drawing.Size(92, 27);
            this.newpwd.TabIndex = 0;
            this.newpwd.Text = "新密码：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(382, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "确认修改";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.password.ImeMode = System.Windows.Forms.ImeMode.On;
            this.password.Location = new System.Drawing.Point(427, 273);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(181, 34);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            this.password.WatermarkText = "确认你的密码";
            // 
            // newpassword
            // 
            this.newpassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newpassword.ImeMode = System.Windows.Forms.ImeMode.On;
            this.newpassword.Location = new System.Drawing.Point(427, 204);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(181, 34);
            this.newpassword.TabIndex = 1;
            this.newpassword.UseSystemPasswordChar = true;
            this.newpassword.WatermarkText = "修改你的密码";
            // 
            // XiuGai
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources.忘记密码6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(908, 496);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.affirm_pwd);
            this.Controls.Add(this.newpwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XiuGai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XiuGai";
            this.Load += new System.EventHandler(this.XiuGai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WatermarkTextBox password;
        private WatermarkTextBox newpassword;
        private System.Windows.Forms.Label affirm_pwd;
        private System.Windows.Forms.Label newpwd;
        private System.Windows.Forms.Button button1;
    }
}