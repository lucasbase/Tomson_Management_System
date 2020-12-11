using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 汤臣一品小区物业管理系统
{
    public partial class Admin_add : Form
    {
        public Admin_add()
        {
            InitializeComponent();
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
        }
        #region 窗体边框阴影效果变量申明

        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);
        //声明Win32 API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

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
        private void btn_xaio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_infoadd_Click(object sender, EventArgs e)
        {
            //非空验证
            if (text_num.Text==""||Pwd_text.Text==""||tell_text.Text=="")
            {
                MessageBox.Show("管理员账号信息不允许为空！","提示");
                return;
            }
            //电信手机号码正则        
            string dianxin = @"^1[35789][01379]\d{8}$";
            Regex dReg = new Regex(dianxin);//实例化对象
                                            //联通手机号正则        
            string liantong = @"^1[345678][01256]\d{8}$";
            Regex tReg = new Regex(liantong);//实例化对象
                                             //移动手机号正则        
            string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
            Regex yReg = new Regex(yidong);//实例化对象
                                           //判断输入的手机号码格式是否正确
            if (!(dReg.IsMatch(tell_text.Text) || tReg.IsMatch(tell_text.Text) || yReg.IsMatch(tell_text.Text)))
            {
                MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                tell_text.Text = ""; //如果手机号码格式不正确则输入框变成空
                return;
            }
            //添加管理员Sql语句
            string insertSql = string.Format("insert userinfo_table(account_number,password,user_tel) values('{0}','{1}','{2}')",text_num.Text.Trim(),Pwd_text.Text.Trim(),tell_text.Text.Trim());
            if (DBHepler.ExecuteNonQuery(insertSql))
            {
                this.Close();
            }
        }

        private void Admin_add_Load(object sender, EventArgs e)
        {

        }
    }
}
