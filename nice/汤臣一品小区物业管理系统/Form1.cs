using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static 汤臣一品小区物业管理系统.Main;

namespace 汤臣一品小区物业管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect, // x-coordinate of upper-left corner
       int nTopRect, // y-coordinate of upper-left corner
       int nRightRect, // x-coordinate of lower-right corner
       int nBottomRect, // y-coordinate of lower-right corner
       int nWidthEllipse, // height of ellipse
       int nHeightEllipse // width of ellipse
    );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

 #region 点击任务栏图标最小化
        // Minimize from taskbar  点击任务栏图标最小化
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }
        #endregion
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        /// <summary>
        /// 重写WndProc方法,实现窗体移动和禁止双击最大化
        /// </summary>
        /// <param name="m">Windows 消息</param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
                case 0xA3:
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        #region 鼠标左键的事件
        private void small_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.FindForm().WindowState = FormWindowState.Minimized;
            }
        }
        private void max_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Application.Exit();
            }
        }
        #endregion

        #region 鼠标放在控件上的Hover事件
        private void max_MouseHover(object sender, EventArgs e)
        {
            // 创建the ToolTip 
            ToolTip toolTip1 = new ToolTip();
            // 设置显示样式
            toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
            toolTip1.InitialDelay = 550;//事件触发多久后出现提示
            toolTip1.ReshowDelay = 100;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;//是否显示提示框
            //  设置伴随的对象.
            toolTip1.SetToolTip(max, "关闭");//设置提示按钮和提示内容
        }

        private void small_MouseHover(object sender, EventArgs e)
        {
            // 创建the ToolTip 
            ToolTip toolTip1 = new ToolTip();
            // 设置显示样式
            toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
            toolTip1.InitialDelay = 550;//事件触发多久后出现提示
            toolTip1.ReshowDelay = 100;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;//是否显示提示框
            //  设置伴随的对象.
            toolTip1.SetToolTip(small, "最小化");//设置提示按钮和提示内容
        }
        #endregion

        #region 鼠标放在控件上的事件
        private void max_MouseEnter(object sender, EventArgs e)
        {
            max.BackColor = Color.FromArgb(255, 0, 0);
        }
        private void max_MouseLeave(object sender, EventArgs e)
        {
            max.BackColor = Color.FromArgb(0, 0, 0, 0);
        }
        private void small_MouseEnter(object sender, EventArgs e)
        {
            small.BackColor = Color.FromArgb(130, 215, 218);
        }
        private void small_MouseLeave(object sender, EventArgs e)
        {
            small.BackColor = Color.FromArgb(0, 0, 0, 0);
        }
        #endregion

        ValidCode validCode = new ValidCode(5, ValidCode.CodeType.Numbers);//实例化这个对象
        //窗体加载事件
        private void Form1_Load_1(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//加载验证码图片
            /*淡入窗体*/
            Win32.AnimateWindow(this.Handle, 550, Win32.AW_BLEND);
        }
        //注册按钮点击事件
        private void ZhuChe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();//隐藏上一个界面
            new ZhuCe().ShowDialog();//调用窗体
            this.Dispose();//释放所有资源
        }
        
        public static string nom;
        //登录按钮点击事件
        private void Denglu_Click(object sender, EventArgs e)
        {
            info.num = UserName.Text;
            try
            {
                if (Fa() == false)
                {
                    return;
                }
                if (cbb_Type.Text == "管理员")
                {
                    string UsN = UserName.Text;
                    string Pwd = PassWord.Text;
                    string cmdsql = string.Format("select * from userinfo_table where account_number='{0}' and password='{1}'", UsN, Pwd);
                    SqlDataReader reader = DBHepler.GetDataReader(cmdsql);
                    if (reader.Read())
                    {
                        reader.Close();//关闭连接对象
                        this.Hide();//隐藏界面
                        Main One = new Main();
                        One.ShowDialog();
                        this.Dispose();//释放所有资源
                    }
                    else
                    {
                        MessageBox.Show("账号或密码不正确！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    reader.Close();
                }
                if (cbb_Type.Text == "业主")
                {
                    nom = UserName.Text;
                    string Pwd = PassWord.Text;
                    string cmdsql = string.Format("select * from Users where usersnum='{0}' and userspwd='{1}'", nom, Pwd);
                    SqlDataReader reader = DBHepler.GetDataReader(cmdsql);
                    if (reader.Read())
                    {
                        reader.Close();
                        this.Hide();
                        Owner_User_Interface owner_User_Interface = new Owner_User_Interface();
                        owner_User_Interface.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码不正确！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    reader.Close();
                }
                if (cbb_Type.Text == "超级管理员")
                {
                    nom = UserName.Text;
                    string Pwd = PassWord.Text;
                    string cmdsql = string.Format("select * from Super_Admin where number='{0}' and Pwd='{1}'", nom, Pwd);
                    SqlDataReader reader = DBHepler.GetDataReader(cmdsql);
                    if (reader.Read())
                    {
                        reader.Close();
                        this.Hide();
                        Super_Admin super_Admin = new Super_Admin();
                        super_Admin.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码不正确！", "登录", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    reader.Close();
                }
                if (!(cbb_Type.Text=="业主"||cbb_Type.Text=="管理员"|| cbb_Type.Text == "超级管理员"))
                {
                    MessageBox.Show("登录身份验证错误！", "提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("登录身份验证错误！","提示");
            }
           
        }
        //判断登录界面信息方法
        private bool Fa()
        {
            //非空验证
            if (this.UserName.Text.ToString().Trim() == "" || this.PassWord.Text.ToString().Trim() == "")
            {
                MessageBox.Show("账号或密码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (this.txtValidCode.Text == "")
                {
                    MessageBox.Show("验证码不能为空,请输入验证码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    if (!this.txtValidCode.Text.Equals(validCode.CheckCode))//验证是否输入正确
                    {
                        DialogResult result = MessageBox.Show("验证码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.txtValidCode.Focus();
                        this.txtValidCode.Text = "";
                        if (result == DialogResult.OK)
                        {
                            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//点击图片更换验证码
                        }
                        return false;
                    }
                }
            }
            //查询管理员信息表和业主用户中并判断是否存在该用户名
            string strSQL = "select * from userinfo_table where account_number='" + this.UserName.Text.ToString().Trim() + "'";
            DataSet dt = DBHepler.GetDataSet(strSQL);
            string strSQL1 = "select * from Users where usersnum='" + this.UserName.Text.ToString().Trim() + "'";
            DataSet dy = DBHepler.GetDataSet(strSQL1);
            string strSQL2 = "select * from Super_Admin where number='" + this.UserName.Text.ToString().Trim() + "'";
            DataSet du = DBHepler.GetDataSet(strSQL2);

            if (!(dt.Tables.Count == 0 || dt.Tables[0].Rows.Count > 0))
            {
                if (!(dy.Tables.Count == 0 || dy.Tables[0].Rows.Count > 0))
                {
                    if (!(du.Tables[0].Rows.Count > 0))
                    {
                MessageBox.Show("用户不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                return false;
                    }
                }
            }
            return true;
        }
        private void picValidCode_Click(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//点击图片更换验证码
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();//隐藏上一个界面
            new WangJi().ShowDialog();//调用窗体
            this.Dispose();//释放所有资源
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //由下至上的关闭动画
          Win32.AnimateWindow(this.Handle, 300, Win32. AW_VER_NEGATIVE | Win32.AW_HIDE);
        }
        
    }
}
