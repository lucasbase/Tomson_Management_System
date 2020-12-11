using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 汤臣一品小区物业管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ValidCode validCode = new ValidCode(5, ValidCode.CodeType.Numbers);//实例化这个对象

        private void Form1_Load_1(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//加载验证码图片

        }
        private void picValidCode_Click_1(object sender, EventArgs e)
        {
            picValidCode.Image = Bitmap.FromStream(validCode.CreateCheckCodeImage());//点击图片更换验证码
        }

        private void Denglu_Click(object sender, EventArgs e)
        {
            if (Fa() == false)
            {
                return;
            }
            string UsN = UserName.Text;
            string Pwd = PassWord.Text;
            string cmdsql = string.Format("select * from userinfo_table where account_number='{0}' and password='{1}'", UsN, Pwd);
            SqlDataReader reader = DBHepler.GetDataReader(cmdsql);
            if (reader.Read())
            {
                MessageBox.Show("登陆成功");
            }
            reader.Close();
        }  //判断登录界面信息
        private bool Fa()
        {
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
            //查询数据库中并判断是否存在该用户名
            string strSQL = "select * from userinfo_table where account_number='" + this.UserName.Text.ToString().Trim() + "'";
            DataSet dt = DBHepler.GetDataSet(strSQL);
            if (!(dt.Tables.Count == 0 || dt.Tables[0].Rows.Count > 0))
            {
                MessageBox.Show("用户不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                return false;
            }

            return true;
        }

        private void ZhuChe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();//隐藏上一个界面
            new ZhuCe().ShowDialog();//调用窗体
            this.Dispose();//释放所有资源
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
