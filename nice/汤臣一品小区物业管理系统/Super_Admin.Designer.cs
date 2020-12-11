namespace 汤臣一品小区物业管理系统
{
    partial class Super_Admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Super_Admin));
            this.coping = new System.Windows.Forms.Panel();
            this.super_lb = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shut = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.btn_amend = new System.Windows.Forms.Button();
            this.Admin_InFo = new System.Windows.Forms.DataGridView();
            this.num_Z = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comm_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com_postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.key_tb = new 汤臣一品小区物业管理系统.WatermarkTextBox();
            this.btn_seclt = new System.Windows.Forms.Button();
            this.btn_jin = new System.Windows.Forms.Button();
            this.coping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_InFo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coping
            // 
            this.coping.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.coping.BackColor = System.Drawing.Color.OrangeRed;
            this.coping.Controls.Add(this.super_lb);
            this.coping.Controls.Add(this.pictureBox2);
            this.coping.Controls.Add(this.shut);
            this.coping.Controls.Add(this.minimize);
            this.coping.Location = new System.Drawing.Point(0, 0);
            this.coping.Name = "coping";
            this.coping.Size = new System.Drawing.Size(840, 41);
            this.coping.TabIndex = 27;
            // 
            // super_lb
            // 
            this.super_lb.AutoSize = true;
            this.super_lb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.super_lb.ForeColor = System.Drawing.Color.White;
            this.super_lb.Location = new System.Drawing.Point(56, 12);
            this.super_lb.Name = "super_lb";
            this.super_lb.Size = new System.Drawing.Size(0, 20);
            this.super_lb.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::汤臣一品小区物业管理系统.Properties.Resources.用1户;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Location = new System.Drawing.Point(24, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 25);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // shut
            // 
            this.shut.BackColor = System.Drawing.Color.Transparent;
            this.shut.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.shut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shut.Image = global::汤臣一品小区物业管理系统.Properties.Resources.关闭;
            this.shut.Location = new System.Drawing.Point(790, 0);
            this.shut.Name = "shut";
            this.shut.Size = new System.Drawing.Size(48, 40);
            this.shut.TabIndex = 5;
            this.shut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.shut_MouseClick);
            this.shut.MouseEnter += new System.EventHandler(this.shut_MouseEnter);
            this.shut.MouseLeave += new System.EventHandler(this.shut_MouseLeave);
            this.shut.MouseHover += new System.EventHandler(this.shut_MouseHover);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.minimize.Image = global::汤臣一品小区物业管理系统.Properties.Resources.小化;
            this.minimize.Location = new System.Drawing.Point(732, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(53, 40);
            this.minimize.TabIndex = 24;
            this.minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimize_MouseClick);
            this.minimize.MouseHover += new System.EventHandler(this.minimize_MouseHover);
            // 
            // btn_amend
            // 
            this.btn_amend.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_amend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_amend.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_amend.ForeColor = System.Drawing.Color.White;
            this.btn_amend.Location = new System.Drawing.Point(398, 77);
            this.btn_amend.Name = "btn_amend";
            this.btn_amend.Size = new System.Drawing.Size(141, 38);
            this.btn_amend.TabIndex = 28;
            this.btn_amend.Text = "添加管理员";
            this.btn_amend.UseVisualStyleBackColor = false;
            this.btn_amend.Click += new System.EventHandler(this.btn_amend_Click);
            // 
            // Admin_InFo
            // 
            this.Admin_InFo.AllowUserToAddRows = false;
            this.Admin_InFo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Admin_InFo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.Admin_InFo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Admin_InFo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Admin_InFo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admin_InFo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num_Z,
            this.Comm_Name,
            this.com_Address,
            this.com_postcode,
            this.number});
            this.Admin_InFo.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Admin_InFo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Admin_InFo.Location = new System.Drawing.Point(12, 186);
            this.Admin_InFo.Name = "Admin_InFo";
            this.Admin_InFo.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 10F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(178)))), ((int)(((byte)(238)))));
            this.Admin_InFo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Admin_InFo.RowTemplate.Height = 27;
            this.Admin_InFo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Admin_InFo.Size = new System.Drawing.Size(816, 317);
            this.Admin_InFo.TabIndex = 30;
            this.Admin_InFo.TabStop = false;
            // 
            // num_Z
            // 
            this.num_Z.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.num_Z.DataPropertyName = "account_number";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.num_Z.DefaultCellStyle = dataGridViewCellStyle2;
            this.num_Z.HeaderText = "账号";
            this.num_Z.Name = "num_Z";
            this.num_Z.ReadOnly = true;
            // 
            // Comm_Name
            // 
            this.Comm_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comm_Name.DataPropertyName = "password";
            this.Comm_Name.HeaderText = "密码";
            this.Comm_Name.Name = "Comm_Name";
            this.Comm_Name.ReadOnly = true;
            // 
            // com_Address
            // 
            this.com_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.com_Address.DataPropertyName = "user_tel";
            this.com_Address.HeaderText = "联系电话";
            this.com_Address.Name = "com_Address";
            this.com_Address.ReadOnly = true;
            // 
            // com_postcode
            // 
            this.com_postcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.com_postcode.DataPropertyName = "User_Type";
            this.com_postcode.HeaderText = "类别";
            this.com_postcode.Name = "com_postcode";
            this.com_postcode.ReadOnly = true;
            // 
            // number
            // 
            this.number.DataPropertyName = "user_id";
            this.number.HeaderText = "序号";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(840, 25);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(159, 20);
            this.toolStripStatusLabel1.Text = "欢迎登录！超级管理员";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(57, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "查询：";
            // 
            // key_tb
            // 
            this.key_tb.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.key_tb.Location = new System.Drawing.Point(127, 84);
            this.key_tb.Name = "key_tb";
            this.key_tb.Size = new System.Drawing.Size(145, 27);
            this.key_tb.TabIndex = 41;
            this.key_tb.WatermarkText = null;
            // 
            // btn_seclt
            // 
            this.btn_seclt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(205)))), ((int)(((byte)(0)))));
            this.btn_seclt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_seclt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_seclt.ForeColor = System.Drawing.Color.White;
            this.btn_seclt.Location = new System.Drawing.Point(278, 81);
            this.btn_seclt.Name = "btn_seclt";
            this.btn_seclt.Size = new System.Drawing.Size(89, 33);
            this.btn_seclt.TabIndex = 42;
            this.btn_seclt.Text = "查询";
            this.btn_seclt.UseVisualStyleBackColor = false;
            this.btn_seclt.Click += new System.EventHandler(this.btn_seclt_Click);
            // 
            // btn_jin
            // 
            this.btn_jin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_jin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_jin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_jin.ForeColor = System.Drawing.Color.White;
            this.btn_jin.Location = new System.Drawing.Point(643, 77);
            this.btn_jin.Name = "btn_jin";
            this.btn_jin.Size = new System.Drawing.Size(141, 38);
            this.btn_jin.TabIndex = 43;
            this.btn_jin.Text = "进入管理界面";
            this.btn_jin.UseVisualStyleBackColor = false;
            this.btn_jin.Click += new System.EventHandler(this.btn_jin_Click);
            // 
            // Super_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 541);
            this.Controls.Add(this.btn_jin);
            this.Controls.Add(this.btn_seclt);
            this.Controls.Add(this.key_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_amend);
            this.Controls.Add(this.Admin_InFo);
            this.Controls.Add(this.coping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Super_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Super_Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Super_Admin_FormClosed);
            this.Load += new System.EventHandler(this.Super_Admin_Load);
            this.coping.ResumeLayout(false);
            this.coping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_InFo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel coping;
        private System.Windows.Forms.Label shut;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label super_lb;
        private System.Windows.Forms.Button btn_amend;
        private System.Windows.Forms.DataGridView Admin_InFo;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Z;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comm_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn com_postcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private WatermarkTextBox key_tb;
        private System.Windows.Forms.Button btn_seclt;
        private System.Windows.Forms.Button btn_jin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}