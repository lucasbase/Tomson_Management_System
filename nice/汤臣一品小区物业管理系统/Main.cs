using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace 汤臣一品小区物业管理系统
{
    public partial class Main : Form
    {

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



        #region  窗体动画
        public class Win32
        {
            public const Int32 AW_HOR_POSITIVE = 0x00000001; // 从左到右打开窗口
            public const Int32 AW_HOR_NEGATIVE = 0x00000002; // 从右到左打开窗口
            public const Int32 AW_VER_POSITIVE = 0x00000004; // 从上到下打开窗口
            public const Int32 AW_VER_NEGATIVE = 0x00000008; // 从下到上打开窗口
            public const Int32 AW_CENTER = 0x00000010; //若使用了AW_HIDE标志，则使窗口向内重叠；若未使用AW_HIDE标志，则使窗口向外扩展。
            public const Int32 AW_HIDE = 0x00010000; //隐藏窗口，缺省则显示窗口。
            public const Int32 AW_ACTIVATE = 0x00020000; //激活窗口。在使用了AW_HIDE标志后不要使用这个标志。
            public const Int32 AW_SLIDE = 0x00040000; //使用滑动类型。缺省则为滚动动画类型。当使用AW_CENTER标志时，这个标志就被忽略。
            public const Int32 AW_BLEND = 0x00080000; //使用淡出效果。只有当hWnd为顶层窗口的时候才可以使用此标志。
            [DllImport("user32.dll", CharSet = CharSet.Auto)]
            public static extern bool AnimateWindow(
              IntPtr hwnd, // handle to window
              int dwTime, // duration of animation
              int dwFlags // animation type
              );
        }

        private const int WM_NCLBUTTONDOWN = 0x00A1;
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ReleaseCapture();
        #endregion

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

        public Main()
        {

            InitializeComponent();
            this.toer.Click += toer_Click;
            this.owner_management.Click += owner_management_Click;
            this.Car_management.Click += Car_management_Click;
            this.maintain_Down.Click += maintain_Down_Click;
            this.customer_service.Click += customer_service_Click;
            this.personal_Down.Click += personal_Down_Click;
            this.UserDown.Click += UserDown_Click;
            this.panel1.Click += panel1_Click;
        }
        //背景变色的方法
        public void invit()
        {
            toer.BackColor = Color.FromArgb(243, 243, 241);
            owner_management.BackColor = Color.FromArgb(243, 243, 241);
            Car_management.BackColor = Color.FromArgb(243, 243, 241);
            maintain_Down.BackColor = Color.FromArgb(243, 243, 241);
            customer_service.BackColor = Color.FromArgb(243, 243, 241);
            personal_Down.BackColor = Color.FromArgb(243, 243, 241);
            UserDown.BackColor = Color.FromArgb(243, 243, 241);
            panel1.BackColor = Color.FromArgb(243, 243, 241);
        }

        /// <summary>
        /// 向操作区域内部添加选项卡页,并在选项卡页中展示窗体
        /// </summary>
        /// <param name="TabName">标签文本</param>
        /// <param name="from">需要显示的窗体</param>
        private void AddTabPage(string TabName, Form form)
        {
            //根据标签文本，判断该选项卡页是否已经存在，防止重复
            if (TabPgeIsExist(TabName)) return;
            //选项卡页不存在，需要动态创建
            //创建选项卡页，并设置标签文本
            TabPage page = new TabPage(TabName);
            //将窗体form，添加到选项卡页中
            //注意：在TabPage中添加窗体，需要设置窗体以下两个属性
            form.TopLevel = false;  //设置为非顶级控件，否则运行报错
            form.Visible = true;    //设置为可见，否则窗体内容不显示
            page.Controls.Add(form);//将窗体添加到TabPage中
            //将TabPage对象添加到TabControl中
            this.One_form.TabPages.Add(page);
            //添加后，选中该选项卡页
            this.One_form.SelectedTab = page;
        }

        /// <summary>
        /// 判断选项卡页是否已经存在
        /// </summary>
        /// <param name="TabName">判断的依据：标签文本</param>
        /// <returns>是否存在</returns>
        private bool TabPgeIsExist(string TabName)
        {
            //先假设该选项卡不存在
            bool isExist = false;
            //遍历所有的选项卡页，验证假设是否成立
            foreach (TabPage page in this.One_form.TabPages)
            {
                if (page.Text == TabName)
                {
                    //假设不成立，更改结果
                    isExist = true;
                    //选项卡页已经存在，直接选中该选项卡
                    this.One_form.SelectedTab = page;
                    break;
                }
            }
            //返回最终结果
            return isExist;
        }
        //窗体加载事件
        private void Main_Load(object sender, EventArgs e)
        {
            //Sql语句
            string selectSql = string.Format("select * from property_table");
            ds = DBHepler.GetDataSet(selectSql);
            //取消自动生成列
            tower_list.AutoGenerateColumns = false;
            tower_list.DataSource = ds.Tables[0];//绑定数据源
            ming_pl.Text = info.num;
            /*由上至下窗体*/
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_VER_POSITIVE);
            invit();
            toer.BackColor = Color.FromArgb(230, 230, 250);
            //双缓冲
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
            if (ming_pl.Text=="Admin")
            {
                fanhui.Visible = true;
            }
        }

        //定义全局数据集对象
        DataSet ds = new DataSet();
        int id;

        //刷新页面的方法
        public  void shuaxin()
        {
            //刷新页面
            //Sql语句
            string selectSql = string.Format("select * from property_table");
            ds = DBHepler.GetDataSet(selectSql);
            //取消自动生成列
            tower_list.AutoGenerateColumns = false;
            tower_list.DataSource = ds.Tables[0];//绑定数据源
        }
        //查询楼盘按钮点击事件
        private void btn_Query_Click(object sender, EventArgs e)
        {
            //查询楼盘信息Sql语句
            string selectSql = string.Format("select * from property_table where village_name like '%{0}%' and  building_number like '%{1}%'", Cell_name_text.Text.Trim().ToString(), Building_Name_Txt.Text.Trim());
            DataTable dt = DBHepler.GetDataTable(selectSql);
            //取消自动生成列
            tower_list.AutoGenerateColumns = false;
            tower_list.DataSource = dt;
            //如果未查询到信息弹出提示
            if (tower_list.Rows.Count <= 0)
            {
                MessageBox.Show("未能找到相关信息,请核对您输入的信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//弹框提示
                return;
            }
        }
        //表中单元格点击事件
        private void tower_list_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //将选中单元格中信息提出
                id = int.Parse(this.tower_list.Rows[e.RowIndex].Cells["col_num"].Value.ToString());
                this.Name_text.Text = tower_list.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.Building_txt.Text = tower_list.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.level_txt.Text = tower_list.Rows[e.RowIndex].Cells[2].Value.ToString();
                hushu_tb.Text = tower_list.Rows[e.RowIndex].Cells[3].Value.ToString();
                konghu_tb.Text = tower_list.Rows[e.RowIndex].Cells[5].Value.ToString();
                //当鼠标选中表中数据时，文本框变为可编辑状态
                Name_text.ReadOnly = false;
                Building_txt.ReadOnly = false;
                level_txt.ReadOnly = false;
                hushu_tb.ReadOnly = false;
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确位置！","提示");
                return;
            }
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

        private void shut_MouseClick(object sender, MouseEventArgs e)
        {
            //判断是否是鼠标左键点击的关闭图标，如果是鼠标左键点击，则关闭窗体
            if (e.Button == MouseButtons.Left)
            {
                Application.Exit();
            }
        }

        private void minimize_MouseClick(object sender, MouseEventArgs e)
        {
            //判断是否是鼠标左键点击的最小化图标，如果是鼠标左键点击，则窗体最小化
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        //删除楼盘按钮点击事件
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //声明变量接收文本框信息
            string Name = Name_text.Text;
            string Two = Building_txt.Text;
            string list = level_txt.Text;
            //非空验证
            if (Name == "" || Two == "" || list == "")
            {
                MessageBox.Show("请选择需要删除的楼盘！", "提示");//弹框提示
                return;
            }
            else
            {
                try
                {
                    DialogResult dr = MessageBox.Show("是否要将您选中的楼盘删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string sql = string.Format("delete from property_table where house_id={0}", id);
                        if (DBHepler.ExecuteNonQuery(sql))
                        {
                            MessageBox.Show("删除成功", "删除");//弹框提示
                            //删除成功后清空文本框
                            Name_text.Text = "";
                            Building_txt.Text = "";
                            level_txt.Text = "";
                        }
                    }
                }
                finally
                {
                    shuaxin();
                }
            }
        }
        //修改信息按钮点击事件
        private void btn_alter_Click(object sender, EventArgs e)
        {
            //非空判断
            if (Name_text.Text == "" || Building_txt.Text == "" || level_txt.Text == "")
            {
                MessageBox.Show("修改内容不能为空！", "楼盘修改", MessageBoxButtons.OK);
                return;
            }
            else
            {
                try
                {
                    //更新信息SQL语句
                    string SQL = string.Format("update property_table set village_name='{0}',building_number='{1}',tier_number='{2}',totality={3} where house_id='{4}'", Name_text.Text, Building_txt.Text, level_txt.Text,hushu_tb.Text.Trim(), id);
                    //判断数据库是否受影响
                    if (DBHepler.ExecuteNonQuery(SQL))
                    {
                        //查询入住数量
                        string shu = string.Format("select totality,yezhnum from property_table where village_name='{0}' and building_number='{1}'", Name_text.Text, Building_txt.Text);
                        ds = DBHepler.GetDataSet(shu);
                        int one = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                        int two = Convert.ToInt32(ds.Tables[0].Rows[0][1].ToString());
                        int cha = one - two;
                        string updateSQL = string.Format("update property_table set idle = '{0}' where village_name = '{1}' and building_number = '{2}'", cha, Name_text.Text, Building_txt.Text);
                        if (DBHepler.ExecuteNonQuery(updateSQL))
                        {
                        MessageBox.Show("修改成功", "楼盘修改", MessageBoxButtons.OK);//弹框提示
                        return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("请联系管理员，" + ex.Message);
                }
                finally
                {
                    shuaxin();
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示building_Add窗体
            Building_add building_Add = new Building_add();
            AddTabPage("添加楼盘", building_Add);
        }

        private void Real_txt_Click(object sender, EventArgs e)
        {
            //回到首页
            this.One_form.SelectedIndex = 0;
            invit();
            toer.BackColor = Color.FromArgb(230, 230, 250);
        }
        //退出本次登录
        private void Tui_chu_Click(object sender, EventArgs e)
        {
            invit();
            DialogResult result = MessageBox.Show("是否退出本次登录？", "退出登录", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                this.Hide();//隐藏上一个界面
                Form1 Lg = new Form1();
                Lg.ShowDialog();//模式化窗体
                this.Dispose();//释放资源
            }
        }

        private void Useer_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示user_Control窗体
            User_Control user_Control = new User_Control();
            AddTabPage("用户管理", user_Control);
            invit();
            UserDown.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void maintain_Up_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示repairs窗体
            Repairs repairs = new Repairs();
            AddTabPage("报修管理", repairs);
            invit();
            maintain_Down.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void One_form_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //获取当前选中的Tab标签
            TabPage selectedPage = this.One_form.SelectedTab;
            //首页标签不允许移除
            if (selectedPage.Text == "首页") return;
            //移除选中的标签
            this.One_form.TabPages.Remove(selectedPage);
        }

        private void toer_Click(object sender, EventArgs e)
        {
            this.One_form.SelectedIndex = 0;
            invit();
            toer.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void owner_management_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示owner_Management窗体
            Owner_Management owner_Management = new Owner_Management();
            AddTabPage("业主信息管理", owner_Management);
            invit();
            owner_management.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void Car_management_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示StopCar窗体
            StopCar stopCar = new StopCar();
            AddTabPage("车辆管理", stopCar);
            invit();
            Car_management.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void maintain_Down_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示repairs窗体
            Repairs repairs = new Repairs();
            AddTabPage("报修管理", repairs);
            invit();
            maintain_Down.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void customer_service_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示Complain窗体
            Complain complain = new Complain();
            AddTabPage("客服管理", complain);
            invit();
            customer_service.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void personal_Down_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示Staff_Management窗体
            Staff_Management staff_Management = new Staff_Management();
            AddTabPage("员工管理", staff_Management);
            invit();
            personal_Down.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void UserDown_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示user_Control窗体
            User_Control user_Control = new User_Control();
            AddTabPage("用户管理", user_Control);
            invit();
            UserDown.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void Up_owner_management_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示owner_Management窗体
            Owner_Management owner_Management = new Owner_Management();
            AddTabPage("业主信息管理", owner_Management);
            invit();
            owner_management.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void Car_management1_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示StopCar窗体
            StopCar stopCar = new StopCar();
            AddTabPage("车辆管理", stopCar);
            invit();
            Car_management.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void customer_txtservice_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示Complain窗体
            Complain complain = new Complain();
            AddTabPage("客服管理", complain);
            invit();
            customer_service.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void personal_txt_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示user_Control窗体
            Staff_Management staff_Management = new Staff_Management();
            AddTabPage("员工管理", staff_Management);
            invit();
            personal_Down.BackColor = Color.FromArgb(230, 230, 250);
        }

        //右键删除多行信息
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //声明变量存储结果
            bool result = true;
            //判断用户是否选中行
            try
            {
                if (tower_list.SelectedRows.Count > 0)
                {
                    //for循环选中行
                    for (int i = 0; i < tower_list.SelectedRows.Count; i++)
                    {
                        //获取ID
                        int id_1 = int.Parse(tower_list.SelectedRows[i].Cells["col_num"].Value.ToString());
                        //删除信息SQL语句
                        string sql = string.Format("delete from property_table where house_id={0}", id_1);
                        result = DBHepler.ExecuteNonQuery(sql);
                    }
                    //判断是否删除信息成功
                    if (result)
                    {
                        MessageBox.Show("删除成功", "删除");
                        //清空文本框并刷新列表
                        Name_text.Text = "";
                        Building_txt.Text = "";
                        level_txt.Text = "";
                        shuaxin();
                        return;
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("您未选中行！", "提示");
                    return;
                }
            }
            catch (Exception)
            {
                //点击空白行的异常弹框
                MessageBox.Show("该楼栋中还有住户，操作无效！", "提示");
            }
        }

        private void shut_MouseEnter(object sender, EventArgs e)
        {
            shut.BackColor = Color.FromArgb(238, 0, 0);
        }

        private void shut_MouseLeave(object sender, EventArgs e)
        {
            shut.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void financing_pi_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示StopCar窗体
            Charge charge = new Charge();
            AddTabPage("收费管理", charge);
            invit();
        }

        private void system_setup_Click(object sender, EventArgs e)
        {
            if (Set_the_box.Visible == true)
            {
                Set_the_box.Visible = false;
            }
            else
            {
                Set_the_box.Visible = true;
            }
            invit();
        }
        //用户管理按钮点击事件
        private void Useer_Click_1(object sender, EventArgs e)
        {//在操作区域内部添加选项卡页，显示user_Control窗体
            User_Control user_Control = new User_Control();
            AddTabPage("用户管理", user_Control);
            invit();
            UserDown.BackColor = Color.FromArgb(230, 230, 250);
        }
        //导出Execl明细按钮点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (tower_list.Rows.Count <= 0)
            {
                MessageBox.Show("该表中没有需要导出的数据！", "提示");
                return;
            }
            string fileName = "楼盘信息表";
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xlsx";
            saveDialog.Filter = "Excel文件|*.xlsx";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet =(Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 
                                                                                         //写入标题             
            for (int i = 0; i < tower_list.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = tower_list.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < tower_list.Rows.Count; r++)
            {
                for (int i = 0; i < tower_list.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = tower_list.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();
            }
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            MessageBox.Show(fileName + "资料保存成功", "提示", MessageBoxButtons.OK);
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)//异常处理
                {
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁           
        }
        //关于程序的点击事件
        private void About_Us_Click(object sender, EventArgs e)
        {
            //判断控件的可见方式
            if (Set_the_box.Visible == true)
            {
                Set_the_box.Visible = false;
            }
            else
            {
                Set_the_box.Visible = true;
            }
            //弹框提示关于程序
            MessageBox.Show("系统名称：汤臣一品小区物业管理系统\n工作室名称：小黑屋工作室\n工作室负责人：戴铖\n工作室成员：陈晨逸、李宇航、周婷立\n系统版本号：V 1.1.0\n发布日期：2019-06-14\n联系邮箱：Luacswork@163.com\n所有权：小黑屋工作室所有成员", "关于");
        }
        //帮助与反馈点击事件
        private void Help_Click(object sender, EventArgs e)
        {
            //超链接
            System.Diagnostics.Process.Start("chrome.exe", "http://help.toppms.com/showforum-10.aspx");
            //判断控件的可见方式
            if (Set_the_box.Visible == true)
            {
                Set_the_box.Visible = false;
            }
            else
            {
                Set_the_box.Visible = true;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 250, Win32.AW_BLEND | Win32.AW_HIDE);
        }
        private void Home_page_Enter_1(object sender, EventArgs e)
        {
            //刷新当前表中的数据
            string Sql = string.Format("select * from property_table");
            ds = DBHepler.GetDataSet(Sql);
            //取消自动生成列
            tower_list.AutoGenerateColumns = false;
            tower_list.DataSource = ds.Tables[0];//绑定数据源
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示Staff_Management窗体
            Truck_space truck_Space = new Truck_space();
            AddTabPage("车位管理", truck_Space);
            invit();
            panel1.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //在操作区域内部添加选项卡页，显示Staff_Management窗体
            Truck_space truck_Space = new Truck_space();
            AddTabPage("车位管理", truck_Space);
            invit();
            panel1.BackColor = Color.FromArgb(230, 230, 250);
        }

        private void fanhui_Click(object sender, EventArgs e)
        {
            this.Hide();
            Super_Admin super_Admin = new Super_Admin();
            super_Admin.ShowDialog();
            this.Dispose();
        }

    }
}
