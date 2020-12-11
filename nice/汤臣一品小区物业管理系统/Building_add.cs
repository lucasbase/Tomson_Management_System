using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 汤臣一品小区物业管理系统
{
    public partial class Building_add : Form
    {
        public Building_add()
        {
            InitializeComponent();
        }
        //全局变量
        DataSet ds = new DataSet();
        //窗体加载事件
        private void Building_add_Load(object sender, EventArgs e)
        {
            string Sql = "select * from property_table";
            ds = DBHepler.GetDataSet(Sql);
            //取消自动生成列
            louPan.AutoGenerateColumns = false;
            //填充数据集
            louPan.DataSource = ds;
            //`绑定数据源
            this.louPan.DataSource = DBHepler.GetDataTable(Sql);
        }
        //添加楼盘信息按钮点击事件
        private void btn_add_Click(object sender, EventArgs e)
        { //非空验证
            if (Q_Name.Text == "")
            {
                MessageBox.Show("小区名不能为空", "添加");
                return;
            }
            else if (DName.Text == "")
            {
                MessageBox.Show("楼栋名不能为空", "添加");
                return;
            }
            else if (CNum.Text == "")
            {
                MessageBox.Show("楼层不能为空", "添加");
                return;
            }
            else if (hu_tb.Text=="")
            {
                MessageBox.Show("总户数不能为空", "添加");
                return;
            }
            else
            {
                string strSQL = "select * from property_table where building_number='" + this.DName.Text.ToString().Trim() + "'";
                ds = DBHepler.GetDataSet(strSQL);
                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("该楼栋名已经存在", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        //添加楼盘信息Sql语句
                        string SQL = string.Format("insert  property_table (village_name,building_number,tier_number,totality,yezhnum,idle) values('{0}','{1}','{2}','{3}','0','{4}')", Q_Name.Text.ToString().Trim(), DName.Text.ToString().Trim(), CNum.Text.ToString().Trim(),hu_tb.Text.Trim(), hu_tb.Text.Trim());
                        //如果添加成功则初始化数据
                        if (DBHepler.ExecuteNonQuery(SQL))
                        {
                            MessageBox.Show("楼盘添加成功", "提示", MessageBoxButtons.OK);
                            //清空文本框内容
                            this.Q_Name.Text = "";
                            this.DName.Text = "";
                            this.CNum.Text = "";
                            hu_tb.Text = "";
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("请联系管理员！" + ex.Message);
                    }
                    finally
                    {
                        //刷新当前表中的数据
                        string Sql = string.Format("select * from property_table");
                        ds = DBHepler.GetDataSet(Sql);
                        //取消自动生成列
                        louPan.AutoGenerateColumns = false;
                        louPan.DataSource = ds.Tables[0];
                        //清空文本框内容
                        this.Q_Name.Text = "";
                        this.DName.Text = "";
                        this.CNum.Text = "";
                    }
                }
            }
        }
        //重置按钮点击事件
        private void btn_reset_Click(object sender, EventArgs e)
        {
            //清空文本框内容
            this.Q_Name.Text = "";
            this.DName.Text = "";
            this.CNum.Text = "";
            //刷新列表
            string Sql = "select * from property_table";
            ds = DBHepler.GetDataSet(Sql);
            //取消自动生成列
            louPan.AutoGenerateColumns = false;
            //填充数据集
            louPan.DataSource = ds;
            //`绑定数据源
            this.louPan.DataSource = DBHepler.GetDataTable(Sql);
        }
    }
}
