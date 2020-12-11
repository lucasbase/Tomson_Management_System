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
    public partial class Staff_Revamp : Form
    {
        public Staff_Revamp()
        {
            InitializeComponent();
        }
        //窗体加载事件
        private void Form2_Load(object sender, EventArgs e)
        {
            /*由左至右窗体*/
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_POSITIVE);
            //查询职位表，并遍历所有的部门
            string SQL = "select distinct duty from post_info_table";
            DataTable dt = DBHepler.GetDataTable(SQL);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.cbb_section.Items.Add(dt.Rows[i][0]);
            }
            //查询职位表，并遍历所有的岗位
            string SqL = "select  distinct department from post_info_table";
            DataTable dt_1 = DBHepler.GetDataTable(SqL);
            for (int i = 0; i < dt_1.Rows.Count; i++)
            {
                this.cbb_post.Items.Add(dt_1.Rows[i][0]);
            }
            string Sql = string.Format("select * from staff_info_table where staffinfo_id='{0}'",ID.id);
            DataRow dr = DBHepler.GetDataSet(Sql).Tables[0].Rows[0];
            this.num_tb.Text = dr[0].ToString();
            this.name_tb.Text = dr[1].ToString();
            this.cbb_sex.Text = dr[2].ToString();
            this.age_tb.Text = dr[3].ToString();
            this.cbb_section.Text = dr[4].ToString();
            this.cbb_post.Text = dr[5].ToString();
            this.tb_ID.Text = dr[6].ToString();
            this.tb_brithday.Text = dr[7].ToString();
            this.tb_address.Text = dr[8].ToString();
            this.tb_Salary.Text = dr[9].ToString();
            this.tb_Phone.Text = dr[10].ToString();
        }

        //确认修改员工信息按钮点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            //非空验证
            if (ID.id == "" || name_tb.Text == "" || cbb_sex.Text == "" || age_tb.Text == "" || cbb_section.Text == "" || cbb_post.Text == "" || tb_ID.Text == "" || tb_brithday.Text == "" || tb_address.Text == "" || tb_Salary.Text == "" || tb_Phone.Text == "")
            {
                MessageBox.Show("修改的信息不能有空项！", "修改");
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
            if (!(dReg.IsMatch(tb_Phone.Text) || tReg.IsMatch(tb_Phone.Text) || yReg.IsMatch(tb_Phone.Text)))
            {
                MessageBox.Show("手机号格式错误，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);//弹框提示
                tb_Phone.Text = ""; //如果手机号码格式不正确则输入框变成空
                return;
            }
            //添加成功后刷新列表
            string selectSql = string.Format("update staff_info_table set name='{0}',sex='{1}',age='{2}',bu='{3}',section='{4}',ID_number='{5}',birthday='{6}',address='{7}',Salary='{8}',Phone='{9}' where staffinfo_id='{10}'", name_tb.Text, cbb_sex.Text, age_tb.Text, cbb_section.Text, cbb_post.Text, tb_ID.Text, tb_brithday.Text, tb_address.Text, tb_Salary.Text, tb_Phone.Text, ID.id);
            if (DBHepler.ExecuteNonQuery(selectSql))
            {
                MessageBox.Show("修改成功！");
                Close();
            }
        }

        //取消按钮点击事件
        private void btn_QX_Click(object sender, EventArgs e)
        {
            //关闭当前窗体
            this.Close();
        }

        private void Staff_Revamp_FormClosed(object sender, FormClosedEventArgs e)
        {
            //由下至上的关闭动画
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_HOR_NEGATIVE | Win32.AW_HIDE);
        }
    }
}
