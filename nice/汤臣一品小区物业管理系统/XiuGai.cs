using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static 汤臣一品小区物业管理系统.Main;

namespace 汤臣一品小区物业管理系统
{
    public partial class XiuGai : Form
    {
        public XiuGai()
        {
            InitializeComponent();
        }
        //确认修改密码按钮的点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.newpassword.Text.ToString().Trim() == "" || this.password.Text.ToString().Trim() == "")
            {
                MessageBox.Show("密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (this.newpassword.Text.ToString().Trim().Length < 6)
            {
                MessageBox.Show("密码长度大于6位", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (this.newpassword.Text.ToString().Trim() != this.password.Text.ToString().Trim())
            {
                MessageBox.Show("前后输入的密码不一致", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string One = WangJi.ad;
            string nwp = newpassword.Text;
            string SQLst = string.Format("update userinfo_table set password='{0}' where user_id='{1}'", nwp,One );
            string Two = WangJi.ab;
            string SQlst = string.Format("update Users set userspwd='{0}' where UserID='{1}'", nwp, Two);
            if (DBHepler.ExecuteNonQuery(SQLst)||DBHepler.ExecuteNonQuery(SQlst))
            {
                DialogResult result = MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                if (result == DialogResult.OK)
                {
                    this.Hide();//隐藏上一个界面
                    Win32.AnimateWindow(this.Handle, 200, Win32.AW_HOR_POSITIVE | Win32.AW_HIDE);
                    new Form1().ShowDialog();//调用窗体
                    this.Dispose();//释放所有资源
                }
                return;
            }
            
            
        }
        //窗体加载事件
        private void XiuGai_Load(object sender, EventArgs e)
        {
            /*由左至右窗体*/
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE);
        }
    }
}
