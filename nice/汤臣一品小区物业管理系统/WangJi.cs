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
    public partial class WangJi : Form
    {
        public WangJi()
        {
            InitializeComponent();
        }
        //定义公共全局
        public static string ad = "";
        public static string ab = "";
        private int rand = 0;
        private void yanzheng_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.phone.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("手机号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                    return;
                }
                else
                {
                    string Phon = phone.Text;//手机号码
                    Random rando = new Random();
                    rand = rando.Next(10000, 99999);
                    sms.Dd(Phon, rand);
                    timer1.Start();
                    datTo = new TimeSpan(0, 0, 60);//设置开始时间
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请联系管理员！","提示");
            }
        }
        TimeSpan datTo = new TimeSpan(0, 0, 60);//设置开始时间.
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            this.yanzheng.Enabled = false;
            datTo = datTo.Subtract(new TimeSpan(0, 0, 1));
            yanzheng.Text = "(" + datTo.Seconds.ToString() + "s)" + "重新发送";
            if (datTo.TotalSeconds == 0.0)//当倒计时完毕
            {
                this.yanzheng.Enabled = true;
                this.timer1.Stop();
                timer1.Dispose();
                yanzheng.Text = "获取验证码";
                yanzheng.ForeColor = Color.White;
            }
        }

        private void WangJi_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            /*由上至下窗体*/
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE);
        }

        private void btn_Downstep_Click(object sender, EventArgs e)
        {
                //非空验证
                if (this.username.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("账号不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    ad = "";
                    ab = "";
                    //查询业主用户表
                    string str1SQL = "select * from Users where usersnum='" + this.username.Text.ToString().Trim() + "'";
                    DataSet dt1 = DBHepler.GetDataSet(str1SQL);
                    string strSQL = "select * from userinfo_table where account_number='" + this.username.Text.ToString().Trim() + "'";
                    DataSet dt = DBHepler.GetDataSet(strSQL);
                    //判断数据库中是否存在用户输入对应账号
                    if (!(dt.Tables.Count == 0 || dt.Tables[0].Rows.Count > 0))
                    {
                        if (!(dt1.Tables.Count == 0 || dt1.Tables[0].Rows.Count > 0))
                        {
                            MessageBox.Show("用户不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                            return;
                        }
                    }
                    //查询管理员信息表的电话
                    string stSQL = "select * from userinfo_table where user_tel='" + this.phone.Text.ToString().Trim() + "'";
                    DataSet da = DBHepler.GetDataSet(stSQL);
                    //查询业主用户信息表电话
                    string sttSQL = "select * from Users where usersPhone='" + this.phone.Text.ToString().Trim() + "'";
                    DataSet dd = DBHepler.GetDataSet(sttSQL);
                    //非空验证
                    if (phone.Text == "")
                    {
                        MessageBox.Show("电话号码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    //判断数据库中是否有用户输入的对应的手机号
                    if (!(da.Tables.Count == 0 || da.Tables[0].Rows.Count > 0))
                    {
                        if (!(dd.Tables.Count == 0 || dd.Tables[0].Rows.Count > 0))
                        {
                            MessageBox.Show("手机号不存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                            return;
                        }
                    }
                    //判断验证码是否正确
                    if (this.phone.Text.ToString().Trim() == "" || this.txtValidCode.Text.ToString().Trim() == "")
                    {
                        MessageBox.Show("验证码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (dt.Tables[0].Rows.Count == 0)
                    {
                        ab = dt1.Tables[0].Rows[0]["UserID"].ToString();
                    //判断验证码是否正确
                    int ra = int.Parse(txtValidCode.Text);
                    if (rand != 0)
                        {
                            if (ra != rand)//如果输入的验证码不一致则提示用户
                            {
                                MessageBox.Show("验证码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            else
                            {
                                this.Hide();//隐藏上一个界面
                                new XiuGai().ShowDialog();//调用窗体
                                this.Dispose();//释放所有资源    
                            }
                        }
                        else
                        {
                            MessageBox.Show("验证码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    else
                    {
                        ad = dt.Tables[0].Rows[0]["user_id"].ToString();
                    //判断验证码是否正确
                    int ra = int.Parse(txtValidCode.Text);
                    if (rand != 0)
                        {
                            if (ra != rand)//如果输入的验证码不一致则提示用户
                            {
                                MessageBox.Show("验证码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            else
                            {
                                this.Hide();//隐藏上一个界面
                                new XiuGai().ShowDialog();//调用窗体
                                this.Dispose();//释放所有资源    
                            }
                        }
                        else
                        {
                            MessageBox.Show("验证码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
        }

        private void btn_Upstep_Click(object sender, EventArgs e)
        {
            this.Hide();//隐藏界面
            Win32.AnimateWindow(this.Handle, 200, Win32.AW_VER_NEGATIVE | Win32.AW_HIDE);
            new Form1().ShowDialog();//模式化窗体
            this.Dispose();//释放所有资源
        }
    }
}


