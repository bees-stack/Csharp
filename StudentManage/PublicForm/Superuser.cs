using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.PublicForm
{
    public partial class Superuser : Form
    {
        //实例化对象
        Alterinfo alterinfo = new Alterinfo();
        Addinfo addinfo = new Addinfo();
        Altersu altersu = new Altersu();
        Regsu regsu = new Regsu();
        Dao dao = new Dao();
       
        public Superuser()
        {
            InitializeComponent();
            LoadInfo();
        }

        //加载时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒");
        }

        //加载表中重要信息
        private void LoadInfo()
        {
            Dao dao = new Dao();
            //通过SQL查询语句（聚合函数）获取表中总人数
            string sql = "select COUNT(*) from student_info";
            //将结果（表中第一行第一列）Object类型转化为整型赋给变量
            int num = (int)dao.GetDataTable(sql).Rows[0][0];
            //通过SQL查询语句（聚合函数）获取表中男生人数
            string sqlm = "select COUNT(*) from student_info where Sex='男'";
            //在查询之前先定义其人数为0 
            int man = 0;
            //如果查询结果不为空
            if (dao.GetDataTable(sqlm) != null)
            {
                //将结果（表中第一行第一列）Object类型转化为整型赋给变量
                man = (int)dao.GetDataTable(sqlm).Rows[0][0];
            }
            //通过SQL查询语句（聚合函数）获取表中女生人数
            string sqlwm = "select COUNT(*) from student_info where Sex='女'";
            int wm = 0;
            if (dao.GetDataTable(sqlm) != null)
            {
                wm = (int)dao.GetDataTable(sqlwm).Rows[0][0];
            }
            //将查询结果显示到label标签上
            label3.Text = string.Format("共有学生{0}人,男生{1}人，女生{2}人", num, man, wm);
        }

        public void Superuser_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet6.su”中。您可以根据需要移动或删除它。
            this.suTableAdapter1.Fill(this.studentDataSet6.su);
            // TODO: 这行代码将数据加载到表“studentDataSet5.student_info”中。您可以根据需要移动或删除它。
            this.student_infoTableAdapter1.Fill(this.studentDataSet5.student_info);
            // TODO: 这行代码将数据加载到表“studentDataSet1.su”中。您可以根据需要移动或删除它。
            //this.suTableAdapter.Fill(this.studentDataSet1.su);
            // TODO: 这行代码将数据加载到表“studentDataSet.student_info”中。您可以根据需要移动或删除它。
            //this.student_infoTableAdapter.Fill(this.studentDataSet.student_info);
        }

        //刷新
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet6.su”中。您可以根据需要移动或删除它。
            this.suTableAdapter1.Fill(this.studentDataSet6.su);
            // TODO: 这行代码将数据加载到表“studentDataSet5.student_info”中。您可以根据需要移动或删除它。
            this.student_infoTableAdapter1.Fill(this.studentDataSet5.student_info);
        }

        //新增
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {   
                //窗体跳转到添加信息窗体
                addinfo.ShowDialog(this);
                this.student_infoTableAdapter1.Fill(this.studentDataSet5.student_info);
                //取消行选中
                dataGridView1.ClearSelection();
            }
            else if (this.dataGridView2.SelectedRows.Count > 0)
            {
                //跳转到修改窗体
                regsu.ShowDialog(this);
                this.suTableAdapter1.Fill(this.studentDataSet6.su);
                //取消行选中
                dataGridView2.ClearSelection();
            }
            else 
            {
                MessageBox.Show("没有选中行，请选中行在进行操作!","错误操作",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
        //删除信息
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //判断容器内有无数据
            if (this.dataGridView1.SelectedRows.Count > 0) {
                //获取容器中选中行的数据
                DataGridViewRow selerow = this.dataGridView1.SelectedRows[0];
                //将id这个单元格的值赋给变量，类型不同时  要进行类型转换
                string id = (string)selerow.Cells["iDD"].Value.ToString();
                //通过SQL删除语句删除ID行数据    where ID =》条件
                string sqlstr = string.Format("use Student delete from student_info where ID={0}", id);
                if (dao.ExecuteNonQuery(sqlstr))
                {
                    MessageBox.Show("删除成功！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //取消选中行
                    dataGridView1.ClearSelection();
                    //刷新表
                    this.student_infoTableAdapter1.Fill(this.studentDataSet5.student_info);
                    return;
                }
                else
                {
                    MessageBox.Show("删除失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //取消选中行
                    dataGridView1.ClearSelection();
                    return;
                }
            }
            //判断容器内有无数据
            else if (this.dataGridView2.SelectedRows.Count > 0)
            {
                //获取容器中选中的那一行数据
                DataGridViewRow selerow = this.dataGridView2.SelectedRows[0];
                //将id这个单元格的值赋给变量，类型不同时  要进行类型转换
                string id = (string)selerow.Cells["IDDD"].Value.ToString();
                //通过SQL删除语句删除ID行   where ID =》条件
                string sqlstr = string.Format("use Student delete from su where ID={0}", id);
                if (id == "1001" || id == "1002")
                {
                    MessageBox.Show("您选中的是超级用户，超级用户不允许被删除", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //dao.getsqlcommand(sqlstr);
                //dao.getDataSet(sqlstr);
                else if (dao.ExecuteNonQuery(sqlstr))
                {
                    MessageBox.Show("删除成功！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //刷新表
                    this.suTableAdapter1.Fill(this.studentDataSet6.su);
                    //取消选中行
                    dataGridView2.ClearSelection();
                    return;
                }
                else
                {
                    MessageBox.Show("删除失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //取消选中行
                    dataGridView2.ClearSelection();
                    return;
                }
            }
            else
            {
                MessageBox.Show("未选中行，没有数据可删除", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static string id;
        public static string age;
        public static string name;
        public static string sex, phone;
        public static string QQ;
        public static string email;
        //修改
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //判断容器内有无数据
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                //修改预览数据表
                //获取容器中选中的行数据
                DataGridViewRow selerow = this.dataGridView1.SelectedRows[0];
                //将id，age，name，sex，phone，QQ，email单元格的值赋给静态方法中定义的变量，实现值传递，类型不同时要进行类型转换
                id = selerow.Cells["iDD"].Value.ToString();
                age = selerow.Cells["agee"].Value.ToString();
                name = (string)selerow.Cells["namee"].Value.ToString();
                sex = (string)selerow.Cells["sexx"].Value.ToString();
                phone = (string)selerow.Cells["phonee"].Value.ToString();
                QQ = (string)selerow.Cells["qQq"].Value.ToString();
                email = (string)selerow.Cells["emaill"].Value.ToString();
                //跳转窗体
                alterinfo.ShowDialog(this);
                //刷新表
                this.student_infoTableAdapter1.Fill(this.studentDataSet5.student_info);
                //取消选中行
                dataGridView1.ClearSelection();
            }
            else if (this.dataGridView2.SelectedRows.Count > 0)
            {
                //修改超级用户表
                //获取容器中选中的行数据
                DataGridViewRow selerow = this.dataGridView2.SelectedRows[0];
                id = selerow.Cells["iDDD"].Value.ToString();
                //窗体跳转
                altersu.ShowDialog(this);
                //刷新表
                this.suTableAdapter1.Fill(this.studentDataSet6.su);
                //取消选中行
                dataGridView2.ClearSelection();
            }
            else {
                MessageBox.Show("你没选中表，请选择一个表!","发生了一个错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
        }
        //退出
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //窗体跳转
            Login login = new Login();
            login.Show();
            this.Close();
        }

        //姓名模糊查询
        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text.Trim();
            //必须在文本框内输值，非空判断
            if (name == "")
            {
                this.student_infoTableAdapter1.Fill(this.studentDataSet5.student_info);
                MessageBox.Show("请输入需要查寻人的姓氏", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);   
                return;
            }
            else
            {
                //通过sql模糊查询语句查询姓氏
                string sqlstr = string.Format("select * from student_info where Name like '{0}%'", name);
                DataTable dt = dao.GetDataTable(sqlstr);
                if (dt != null && dt.Rows.Count > 0)
                {
                    //将结果返回到容器内
                    this.dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("查无此姓!", "警告: 查无此姓!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.student_infoTableAdapter1.Fill(this.studentDataSet5.student_info);
                    return;
                }
            }
        }
    }
}