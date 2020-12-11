using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static 汤臣一品小区物业管理系统.Main;

namespace 汤臣一品小区物业管理系统
{
    public partial class Super_Admin : Form
    {
        public Super_Admin()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
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

        private void shut_MouseClick(object sender, MouseEventArgs e)
        {
            //判断是否是鼠标左键点击的关闭图标，如果是鼠标左键点击，则关闭窗体
            if (e.Button == MouseButtons.Left)
            {
                Application.Exit();
            }
        }

        private void shut_MouseEnter(object sender, EventArgs e)
        {
            shut.BackColor = Color.FromArgb(235, 0, 0);
        }

        private void shut_MouseLeave(object sender, EventArgs e)
        {
            shut.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void shut_MouseHover(object sender, EventArgs e)
        {
            // 创建the ToolTip 
            ToolTip toolTip1 = new ToolTip();
            // 设置显示样式
            toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
            toolTip1.InitialDelay = 550;//事件触发多久后出现提示
            toolTip1.ReshowDelay = 100;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;//是否显示提示框
            //  设置伴随的对象.
            toolTip1.SetToolTip(shut, "关闭");//设置提示按钮和提示内容
        }

        private void minimize_MouseHover(object sender, EventArgs e)
        {
            // 创建the ToolTip 
            ToolTip toolTip1 = new ToolTip();
            // 设置显示样式
            toolTip1.AutoPopDelay = 5000;//提示信息的可见时间
            toolTip1.InitialDelay = 550;//事件触发多久后出现提示
            toolTip1.ReshowDelay = 100;//指针从一个控件移向另一个控件时，经过多久才会显示下一个提示框
            toolTip1.ShowAlways = true;//是否显示提示框
            //  设置伴随的对象.
            toolTip1.SetToolTip(minimize, "最小化");//设置提示按钮和提示内容
        }

        private void minimize_MouseClick(object sender, MouseEventArgs e)
        {
            //判断是否是鼠标左键点击的最小化图标，如果是鼠标左键点击，则窗体最小化
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void Super_Admin_Load(object sender, EventArgs e)
        {
            super_lb.Text = info.num;
            /*由上至下窗体*/
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_VER_POSITIVE);
            string i = string.Format("select * from userinfo_table");
            ds = DBHepler.GetDataSet(i);
            Admin_InFo.AutoGenerateColumns = false;
            Admin_InFo.DataSource = ds.Tables[0];
        }

        private void btn_jin_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏界面
            Main main = new Main();
            main.ShowDialog();//模式化窗体
            this.Dispose();//释放所有资源
        }

        private void btn_amend_Click(object sender, EventArgs e)
        {
            Admin_add admin_Add = new Admin_add();
            admin_Add.ShowDialog();
            //刷新列表
            string i = string.Format("select * from userinfo_table");
            ds = DBHepler.GetDataSet(i);
            Admin_InFo.AutoGenerateColumns = false;
            Admin_InFo.DataSource = ds.Tables[0];
        }

        private void Super_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 250, Win32.AW_BLEND | Win32.AW_HIDE);
        }

        private void btn_seclt_Click(object sender, EventArgs e)
        {
            string seSQl = string.Format("select * from userinfo_table where account_number like '%{0}%' ", key_tb.Text);
            ds = DBHepler.GetDataSet(seSQl);
            Admin_InFo.AutoGenerateColumns = false;
            Admin_InFo.DataSource = ds.Tables[0];
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ID= Admin_InFo.SelectedRows[0].Cells["number"].Value.ToString();
            string name = Admin_InFo.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("是否要删除管理员："+name,"提示",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (dialogResult==DialogResult.Yes)
            {
                string delSql = string.Format("delete from userinfo_table where user_id='{0}'", ID);
                if (DBHepler.ExecuteNonQuery(delSql))
                {
                    MessageBox.Show("删除成功！","提示");
                    //删除成功后刷新列表
                    string i = string.Format("select * from userinfo_table");
                    ds = DBHepler.GetDataSet(i);
                    Admin_InFo.AutoGenerateColumns = false;
                    Admin_InFo.DataSource = ds.Tables[0];
                    return;
                }
            }
        }
    }
}
