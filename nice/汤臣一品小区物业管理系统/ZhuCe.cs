using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static 汤臣一品小区物业管理系统.Main;

namespace 汤臣一品小区物业管理系统
{
    public partial class ZhuCe : Form
    {
        public ZhuCe()
        {
            InitializeComponent();
        }
        private void post_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          //  this.Hide();//隐藏上一个界面
            Close();
            new Form1().ShowDialog();//调用窗体
          //  this.Dispose();//释放所有资源
        }

        private void ZhuCe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 250, Win32.AW_CENTER |Win32. AW_HIDE);
        }

        private void ZhuCe_Load(object sender, EventArgs e)
        {
            /*淡入窗体*/
           Win32.AnimateWindow(this.Handle, 300, Win32.AW_CENTER);
        }
        private bool Fa()
        {
            string ZH_Wat = ZH_wat.Text;
            //判断账号是否为空
            if (ZH_Wat.ToString().Trim() == "")
            {
                MessageBox.Show("账号不能为空!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                return false;
            }
            else
            {
                //查询数据库中并判断是否已经存在该用户名
                string strSQL = "select * from Users where usersnum='" + this.ZH_wat.Text.ToString().Trim() + "'";
                DataSet dt = DBHepler.GetDataSet(strSQL);
                if (dt.Tables.Count == 0 || dt.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("该用户名已经存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                    return false;
                }
            }
            //判断密码是否为空以及密码长度
            if (this.MM_wat.Text.ToString().Trim() == "" || (this.MM_wat.Text.ToString().Trim().Length > 18 && this.MM_wat.Text.ToString().Trim().Length < 6))
            {
                MessageBox.Show("密码不能为空且长度必须6-18位数！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                return false;
            }
            //判断手机号码是否为空以及输入的手机号码长度和手机号码格式
            if (this.phone_wat.Text.ToString().Trim() == "" || this.phone_wat.Text.ToString().Trim().Length != 11)
            {
                MessageBox.Show("手机号不能为空且长度必须为11位！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                return false;
            }
            else
            {
                //电信手机号码正则        
                string dianxin = @"^1[35789][01379]\d{8}$";
                Regex dReg = new Regex(dianxin);//实例化对象
                                                //联通手机号正则        
                string liantong = @"^1[345678][01256]\d{8}$";
                Regex tReg = new Regex(liantong);//实例化对象
                                                 //移动手机号正则        
                string yidong = @"^(134[0123456789]\d{7}|1[34578][012356789]\d{8})$";
                Regex yReg = new Regex(yidong);//实例化对象
                                               //判断输入的手机号码格式是否正确
                if (!(dReg.IsMatch(phone_wat.Text) || tReg.IsMatch(phone_wat.Text) || yReg.IsMatch(phone_wat.Text)))
                {
                    MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                    phone_wat.Text = ""; //如果手机号码格式不正确则输入框变成空
                    return false;
                }
                else
                {
                    //查询数据库并判断输入的手机号是否已被注册
                    string strSQL = "select * from Users where usersPhone='" + this.phone_wat.Text.ToString().Trim() + "'";
                    DataSet dt = DBHepler.GetDataSet(strSQL);
                    if (dt.Tables.Count == 0 || dt.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("该手机号已被注册！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                        return false;
                    }
                }
            }
            return true;
        }
        private void Zhuce_2_Click(object sender, EventArgs e)
        {  //判断注册信息
            if (Fa() == false)
                return;
            //Sql语句
            string SQl = string.Format("insert into Users(usersnum,userspwd,usersPhone) values('{0}','{1}','{2}')", ZH_wat.Text, MM_wat.Text, phone_wat.Text);
            //判断数据库是否受影响
            if (DBHepler.ExecuteNonQuery(SQl))
            {
                DialogResult result = MessageBox.Show("注册成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                if (result == DialogResult.OK)
                {
                    this.Hide();//隐藏上一个界面
                    new Form1().ShowDialog();//调用窗体
                    this.Dispose();//释放所有资源
                }
            }
        }
    }
}
