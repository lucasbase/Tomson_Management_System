using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static 汤臣一品小区物业管理系统.Main;

namespace 汤臣一品小区物业管理系统
{
    public partial class Repair_application : Form
    {
        public Repair_application()
        {
            InitializeComponent();
        }/// <summary>
         /// 重写WndProc方法,实现窗体移动和禁止双击最大化
         /// </summary>
         /// <param name="m">Windows 消息</param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x4e:
                case 0xd:
                case 0xe:
                case 0x14:
                    base.WndProc(ref m);
                    break;
                case 0x84://鼠标点任意位置后可以拖动窗体
                    this.DefWndProc(ref m);
                    if (m.Result.ToInt32() == 0x01)
                    {
                        m.Result = new IntPtr(0x02);
                    }
                    break;
                case 0xA3://禁止双击最大化
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //定义全局
        DataSet ds = new DataSet();
        //报修提交按钮点击事件
        private void btn_addition_Click(object sender, EventArgs e)
        {
            //声明变量存储时间
            string Time = date_Time.Text;
            //非空验证
            if (water_Nom.Text == "" || water_Num.Text == "" || Time == "" || water_Address.Text == "" || content.Text == "")
            {
                MessageBox.Show("* 号项不允许为空！！！", "报修", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                //电信手机号码正则        
                string dianxin = @"^1[3578][01379]\d{8}$";
                Regex dReg = new Regex(dianxin);//实例化对象
                                                //联通手机号正则        
                string liantong = @"^1[34578][01256]\d{8}$";
                Regex tReg = new Regex(liantong);//实例化对象
                                                 //移动手机号正则        
                string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
                Regex yReg = new Regex(yidong);//实例化对象
                                               //判断输入的手机号码格式是否正确
                if (!(dReg.IsMatch(water_Num.Text) || tReg.IsMatch(water_Num.Text) || yReg.IsMatch(water_Num.Text)))
                {
                    MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                    water_Num.Text = ""; //如果手机号码格式不正确则输入框变成空
                    return;
                }
                else
                {
                    //查询是否已经提交过
                    string TiSql = string.Format("select * from repair_application_table ret join repair_record_table rrt on ret.proposer_name=rrt.proposer_name where ret.proposer_name='{0}'", water_Nom.Text);
                    ds = DBHepler.GetDataSet(TiSql);
                    if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("您已经提交过了，请勿重复提交！", "提示");
                        return;
                    }
                    else
                    {
                        try
                        {
                            string AddSql = string.Format("insert repair_application_table values('{0}','{1}','{2}','{3}','{4}')", water_Nom.Text.Trim(), water_Num.Text.Trim(), Convert.ToDateTime(Time).ToString("yyyy-MM-dd"), water_Address.Text, content.Text);
                            string sql = string.Format("insert repair_record_table(proposer_name) values('{0}')", water_Nom.Text);
                            if (DBHepler.ExecuteNonQuery(AddSql))
                            {
                                if (DBHepler.ExecuteNonQuery(sql))
                                {
                                    MessageBox.Show("提交成功！", "提示");//弹框提示
                                                                   //清空文本框
                                    water_Nom.Text = "";
                                    water_Num.Text = "";
                                    Time = "";
                                    water_Address.Text = "";
                                    content.Text = "";
                                    return;
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("请联系管理员！", "错误");
                        }
                    }
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //关闭
            Close();
        }

        private void Repair_application_Load(object sender, EventArgs e)
        {
            /*由上至下窗体*/
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_VER_POSITIVE);
        }
    }
}
