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

namespace 汤臣一品小区物业管理系统
{
    public partial class Staff_Management : Form
    {
        public Staff_Management()
        {
            InitializeComponent();
        }
        //定义全局
        DataSet ds = new DataSet();
        string id;
        DateTime Time;
        /// <summary>
        /// 是否为日期型字符串
        /// </summary>
        /// <param name="StrSource">日期字符串(2008-05-08)</param>
        /// <returns></returns>
        public static bool IsDate(string StrSource)
        {
            //生日格式的正则表达式
            return Regex.IsMatch(StrSource, @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$");
        }

        //窗体加载事件
        private void Staff_Management_Load(object sender, EventArgs e)
        { 
            //查询职位表信息SQL语句
            string SelectSql = "select * from post_info_table";
            ds = DBHepler.GetDataSet(SelectSql);
            dgv_dividion.DataSource = ds.Tables[0];
            //查询员工信息表信息SQL语句
            string selectSql = "select * from staff_info_table";
            ds = DBHepler.GetDataSet(selectSql);
            staff_dgv.DataSource = ds.Tables[0];
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
        }

        //查询员工信息按钮点击事件
        private void btn_Query1_Click(object sender, EventArgs e)
        {
            try
            {
                string SelectSql = string.Format("select * from staff_info_table where name like '%{0}%' or staffinfo_id like '%{0}%'", InFo_tb.Text);//模糊查询员工信息SQL语句
                ds = DBHepler.GetDataSet(SelectSql);
                staff_dgv.DataSource = ds.Tables[0];//绑定数据源
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("未找到与关键字‘ " + InFo_tb.Text + " ’;相匹配的员工信息！", "查询");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请联系管理员！");
            }
        }

        private void staff_dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //将表中信息显示在文本框中
            try
            {
                this.job_num_tb.Text = staff_dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.tb_staffname.Text = staff_dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.cbb_sex.Text = staff_dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.tb_age.Text = staff_dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.cbb_section.Text = staff_dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.cbb_post.Text = staff_dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.tb_ID.Text = staff_dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.tb_brithday.Text = staff_dgv.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.tb_address.Text = staff_dgv.Rows[e.RowIndex].Cells[8].Value.ToString();
                this.tb_Salary.Text = staff_dgv.Rows[e.RowIndex].Cells[9].Value.ToString();
                this.tb_Phone.Text = staff_dgv.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确位置", "错误");
            }
        }

        //判断身份证  生日格式是否正确以及身份证号已经存在的方法
        private bool format()
        {
            string is_ID = @"^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)$";//身份证格式的正则表达式
            Regex reg = new Regex(is_ID);
            if (!reg.IsMatch(tb_ID.Text))
            {
                MessageBox.Show("请输入正确的身份证！", "添加", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tb_ID.Text = ""; //如果身份证不正确则输入框变成空
                return false;
            }
            if (IsDate(tb_brithday.Text) != true)
            {
                MessageBox.Show("请填写正确的生日！", "添加", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tb_brithday.Text = ""; //如果生日格式不正确则输入框变成空
                return false;
            }
            //判断身份证是否已存在
            string strSQL = "select * from staff_info_table where ID_number='" + this.tb_ID.Text.ToString().Trim() + "'";
            DataSet db = DBHepler.GetDataSet(strSQL);
            if (db.Tables.Count == 0 || db.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("该身份证号已经存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                return false;
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
                return false;
            }
            return true;
        }

        //添加员工信息按钮点击事件
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                //声明变量存储文本框信息
                string job_num = job_num_tb.Text;
                string staffname = tb_staffname.Text;
                string sex = cbb_sex.Text;
                string age = tb_age.Text;
                string section = cbb_section.Text;
                string post = cbb_post.Text;
                string FID = tb_ID.Text;
                string brithday = tb_brithday.Text;
                string address = tb_address.Text;
                string Salary = tb_Salary.Text;
                string Phone = tb_Phone.Text;
                if (job_num == "" || staffname == "" || sex == "" || age == "" || section == "" || post == "" || FID == "" || brithday == "" || address == "" || Salary == "" || Phone == "")
                {
                    MessageBox.Show("所有员工信息不允许为空！", "添加");
                    return;
                }
                else
                {
                    //判断员工工号是否已存在
                    string strSQL = "select * from staff_info_table where staffinfo_id='" + job_num.Trim() + "'";
                    DataSet db = DBHepler.GetDataSet(strSQL);
                    if (db.Tables.Count == 0 || db.Tables[0].Rows.Count > 0)
                    {
                        MessageBox.Show("该工号已经存在！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                        return;
                    }
                    //判断方法
                    if (format() == false)
                    {
                        return;
                    }
                    //添加信息
                    string insertSql = string.Format("insert staff_info_table(staffinfo_id,name,sex,age,bu,section,ID_number,birthday,address,Salary,Phone) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", job_num, staffname, sex, age, section, post, FID, brithday, address, Salary, Phone);
                    //判断数据库是否受影响
                    if (DBHepler.ExecuteNonQuery(insertSql))
                    {
                        MessageBox.Show("成功添加员工信息", "添加");
                        //添加成功后清空文本框
                        job_num = "";
                        staffname = "";
                        sex = "";
                        age = "";
                        post = "";
                        FID = "";
                        brithday = "";
                        address = "";
                        Salary = "";
                        Phone = "";
                        //添加成功后刷新列表
                        string selectSql = string.Format("select * from staff_info_table");
                        DataTable dt = DBHepler.GetDataTable(selectSql);
                        staff_dgv.DataSource = dt;//绑定数据源
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("不允许存在相同的工号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        //修改员工信息按钮点击事件
        private void btn_alter_Click(object sender, EventArgs e)
        {
            string id = staff_dgv.SelectedRows[0].Cells[0].Value.ToString();
            //非空验证
            if (id == "" || tb_staffname.Text == "" || cbb_sex.Text == "" || tb_age.Text == "" || cbb_section.Text == "" || cbb_post.Text == "" || tb_ID.Text == "" || tb_brithday.Text == "" || tb_address.Text == "" || tb_Salary.Text == "" || tb_Phone.Text == "")
            {
                MessageBox.Show("请选择您需要修改信息的员工!", "修改");
                return;
            }
            Time = DateTime.Parse(this.staff_dgv.SelectedRows[0].Cells[11].Value.ToString());
            //判断用户修改的身份证格式是否正确
            string is_ID = @"^[1-9]\d{5}[1-9]\d{3}((0\d)|(1[0-2]))(([0|1|2]\d)|3[0-1])\d{3}([0-9]|X)$";
            Regex reg = new Regex(is_ID);
            if (!reg.IsMatch(tb_ID.Text))
            {
                MessageBox.Show("请输入正确的身份证！", "添加", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tb_ID.Text = ""; //如果身份证不正确则输入框变成空
                return;
            }
            if (IsDate(tb_brithday.Text) != true)//判断用户修改的生日格式是否正确
            {
                MessageBox.Show("请填写正确的生日！", "添加", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tb_brithday.Text = ""; //如果生日格式不正确则输入框变成空
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
            //修改员工信息SQL语句
            string alterSql = string.Format("update staff_info_table set name='{0}',sex='{1}',age='{2}',bu='{3}',section='{4}',ID_number='{5}',birthday='{6}',address='{7}',Salary='{8}',Phone='{9}',Time='{10}' where staffinfo_id='{11}'", tb_staffname.Text, cbb_sex.Text, tb_age.Text, cbb_section.Text, cbb_post.Text, tb_ID.Text, tb_brithday.Text, tb_address.Text, tb_Salary.Text, tb_Phone.Text, Time, id);
            //判断修改是否成功
            if (DBHepler.ExecuteNonQuery(alterSql))
            {
                MessageBox.Show("成功修改工号：" + id + " 员工的信息", "修改");
                //成功修改员工信息后清空文本框
                job_num_tb.Text = "";
                tb_staffname.Text = "";
                cbb_sex.Text = "";
                tb_age.Text = "";
                cbb_section.Text = "";
                cbb_post.Text = "";
                tb_ID.Text = "";
                tb_brithday.Text = "";
                tb_address.Text = "";
                tb_Salary.Text = "";
                tb_Phone.Text = "";
                //成功修改员工信息后刷新列表
                string selectSql = string.Format("select * from staff_info_table");
                DataTable dt = DBHepler.GetDataTable(selectSql);
                staff_dgv.DataSource = dt;//绑定数据源
                return;
            }
        }

        //右键删除信息点击事件
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //声明变量存储结果
            bool result = true;
            if (staff_dgv.SelectedRows.Count > 0)
            {
                for (int i = 0; i < staff_dgv.SelectedRows.Count; i++)
                {
                    //获取工号
                    id = staff_dgv.SelectedRows[i].Cells[0].Value.ToString();
                    string delSql = string.Format("delete staff_info_table where staffinfo_id='{0}'", id);
                    result = DBHepler.ExecuteNonQuery(delSql);
                }
                if (result == true)
                {
                    MessageBox.Show("删除成功", "删除");
                    //清空文本框并刷新列表
                    job_num_tb.Text = "";
                    tb_staffname.Text = "";
                    cbb_sex.Text = "";
                    tb_age.Text = "";
                    cbb_section.Text = "";
                    cbb_post.Text = "";
                    tb_ID.Text = "";
                    tb_brithday.Text = "";
                    tb_address.Text = "";
                    tb_Salary.Text = "";
                    tb_Phone.Text = "";
                    //Sql语句
                    string selectSql = string.Format("select * from staff_info_table");
                    DataTable dt = DBHepler.GetDataTable(selectSql);
                    staff_dgv.DataSource = dt;//绑定数据源
                    return;
                }
            }
        }
        private void dgv_dividion_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //将表中的信息显示在文本框中
                duty_tb.Text = dgv_dividion.Rows[e.RowIndex].Cells[1].Value.ToString();
                department_tb.Text = dgv_dividion.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("请点击正确位置", "提示");
            }
        }

        //查询部门信息按钮点击事件
        private void btn_inquire_Click(object sender, EventArgs e)
        {
            //模糊查询部门信息SQL语句
            string selSql = string.Format("select * from post_info_table where duty like '%{0}%' or department like '%{0}%'", key2_tb.Text);
            ds = DBHepler.GetDataSet(selSql);
            //绑定数据源
            dgv_dividion.DataSource = ds.Tables[0];
            //判断是否查到信息
            if (ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("操作失败，未找到与关键字‘" + key2_tb.Text + "’相匹配的信息！", "查询", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        //添加部门按钮点击事件
        private void btn_Add2_Click(object sender, EventArgs e)
        {
            //非空验证
            if (duty_tb.Text == "" || department_tb.Text == "")
            {
                MessageBox.Show("部门或岗位不允许为空！", "添加");
                return;
            }
            //判断岗位是否已存在
            string strSQL = "select * from post_info_table where department='" + this.department_tb.Text.ToString().Trim() + "'";
            DataSet db = DBHepler.GetDataSet(strSQL);
            if (db.Tables.Count == 0 || db.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("添加失败，岗位" + department_tb.Text + "已经存在,请检查！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//弹框提示
                department_tb.Text = "";
                return;
            }

            //添加部门信息SQL语句
            string inserSql = string.Format("insert post_info_table values('{0}','{1}')", duty_tb.Text, department_tb.Text);
            //判断是否添加成功
            if (DBHepler.ExecuteNonQuery(inserSql))
            {
                MessageBox.Show("添加部门信息成功！", "提示", MessageBoxButtons.OK);
                //添加成功后刷新列表并清空文本框
                string SelectSql = "select * from post_info_table";
                ds = DBHepler.GetDataSet(SelectSql);
                dgv_dividion.DataSource = ds.Tables[0];
                duty_tb.Text = "";
                department_tb.Text = "";
                return;
            }
        }

        //修改部门信息按钮点击事件
        private void btn_amend_Click(object sender, EventArgs e)
        {
            int post_id = int.Parse(dgv_dividion.SelectedRows[0].Cells["col_num"].Value.ToString());
            //非控验证
            if (duty_tb.Text == "" || department_tb.Text == "")
            {
                MessageBox.Show("操作失败，请选择需要修改的信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //修改部门信息SQL语句
            string updateSql = string.Format("update post_info_table set duty='{0}',department='{1}' where postinfo_id='{2}'", duty_tb.Text, department_tb.Text, post_id);
            //判断信息是否修改成功
            if (DBHepler.ExecuteNonQuery(updateSql))
            {
                MessageBox.Show("修改成功！", "修改");
                //修改成功后刷新列表并清空文本框
                string SelectSql = "select * from post_info_table";
                ds = DBHepler.GetDataSet(SelectSql);
                dgv_dividion.DataSource = ds.Tables[0];
                duty_tb.Text = "";
                department_tb.Text = "";
                return;
            }
        }

        //删除按钮点击事件
        private void btn_del_Click(object sender, EventArgs e)
        {
            int post_id = int.Parse(dgv_dividion.SelectedRows[0].Cells["col_num"].Value.ToString());
            //非控验证
            if (duty_tb.Text == "" || department_tb.Text == "")
            {
                MessageBox.Show("操作失败，请选择需要删除的信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //sahnchu部门信息SQL语句
            string delSql = string.Format("delete post_info_table  where postinfo_id='{0}'", post_id);
            //判断信息是否删除成功
            if (DBHepler.ExecuteNonQuery(delSql))
            {
                MessageBox.Show("删除成功！", "删除");
                //删除成功后刷新列表并清空文本框
                string DelSql = "select * from post_info_table";
                ds = DBHepler.GetDataSet(DelSql);
                dgv_dividion.DataSource = ds.Tables[0];
                duty_tb.Text = "";
                department_tb.Text = "";
                return;
            }
        }

        //导出Execl明细
        private void btn_dao_Click(object sender, EventArgs e)
        {
            #region  导出Execl的具体代码
            string fileName = "汤臣一品小区物业员工信息表";
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
            Microsoft.Office.Interop.Excel.Workbook workbook =
                        workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet =
                        (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 
                                                                                         //写入标题             
            for (int i = 0; i < staff_dgv.ColumnCount; i++)
            {
                worksheet.Cells[1, i + 1] = staff_dgv.Columns[i].HeaderText;
            }
            //写入数值
            for (int r = 0; r < staff_dgv.Rows.Count; r++)
            {
                for (int i = 0; i < staff_dgv.ColumnCount; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = staff_dgv.Rows[r].Cells[i].Value;
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
                catch (Exception ex)
                {
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁   
            #endregion
        }

        //列的双击事件
        private void staff_dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID.id = staff_dgv.Rows[e.RowIndex].Cells[0].Value.ToString();//获取ID存储在ID类中
            //判断ID是否为空
            if (ID.id=="")
            {
                MessageBox.Show("请点击正确位置！");
                return;
            }
            Staff_Revamp form2 = new Staff_Revamp();//实例化窗口对象
            form2.ShowDialog();//模式化窗口
            //查询员工信息表信息SQL语句
            string selectSql = "select * from staff_info_table";
            ds = DBHepler.GetDataSet(selectSql);
            staff_dgv.DataSource = ds.Tables[0];//绑定数据源
        }
        
    }
}
