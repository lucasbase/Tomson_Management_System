namespace 汤臣一品小区物业管理系统
{
    partial class Admin_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_add));
            this.coping = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_num = new System.Windows.Forms.TextBox();
            this.tell_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pwd_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_infoadd = new System.Windows.Forms.Button();
            this.btn_xaio = new System.Windows.Forms.Button();
            this.coping.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coping
            // 
            this.coping.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coping.BackColor = System.Drawing.Color.OrangeRed;
            this.coping.Controls.Add(this.label5);
            this.coping.Location = new System.Drawing.Point(-2, 0);
            this.coping.Name = "coping";
            this.coping.Size = new System.Drawing.Size(376, 34);
            this.coping.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "添加管理员";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "账号：";
            // 
            // text_num
            // 
            this.text_num.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_num.Location = new System.Drawing.Point(125, 38);
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(139, 27);
            this.text_num.TabIndex = 30;
            // 
            // tell_text
            // 
            this.tell_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tell_text.Location = new System.Drawing.Point(127, 176);
            this.tell_text.MaxLength = 11;
            this.tell_text.Name = "tell_text";
            this.tell_text.Size = new System.Drawing.Size(137, 27);
            this.tell_text.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(36, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "联系电话：";
            // 
            // Pwd_text
            // 
            this.Pwd_text.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Pwd_text.Location = new System.Drawing.Point(125, 106);
            this.Pwd_text.Name = "Pwd_text";
            this.Pwd_text.Size = new System.Drawing.Size(139, 27);
            this.Pwd_text.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(66, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "密码：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pwd_text);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tell_text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_num);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(301, 241);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加信息";
            // 
            // btn_infoadd
            // 
            this.btn_infoadd.BackColor = System.Drawing.Color.Red;
            this.btn_infoadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_infoadd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_infoadd.ForeColor = System.Drawing.Color.White;
            this.btn_infoadd.Location = new System.Drawing.Point(45, 350);
            this.btn_infoadd.Name = "btn_infoadd";
            this.btn_infoadd.Size = new System.Drawing.Size(87, 31);
            this.btn_infoadd.TabIndex = 38;
            this.btn_infoadd.Text = "添加";
            this.btn_infoadd.UseVisualStyleBackColor = false;
            this.btn_infoadd.Click += new System.EventHandler(this.btn_infoadd_Click);
            // 
            // btn_xaio
            // 
            this.btn_xaio.BackColor = System.Drawing.Color.Transparent;
            this.btn_xaio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xaio.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_xaio.ForeColor = System.Drawing.Color.Black;
            this.btn_xaio.Location = new System.Drawing.Point(236, 350);
            this.btn_xaio.Name = "btn_xaio";
            this.btn_xaio.Size = new System.Drawing.Size(87, 31);
            this.btn_xaio.TabIndex = 39;
            this.btn_xaio.Text = "取消";
            this.btn_xaio.UseVisualStyleBackColor = false;
            this.btn_xaio.Click += new System.EventHandler(this.btn_xaio_Click);
            // 
            // Admin_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(369, 408);
            this.Controls.Add(this.btn_xaio);
            this.Controls.Add(this.btn_infoadd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.coping);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_add";
            this.Load += new System.EventHandler(this.Admin_add_Load);
            this.coping.ResumeLayout(false);
            this.coping.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel coping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_num;
        private System.Windows.Forms.TextBox tell_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pwd_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_infoadd;
        private System.Windows.Forms.Button btn_xaio;
    }
}