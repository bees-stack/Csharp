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
        Addinfo addinfo = new Addinfo();
        Alterinfo alterinfo = new Alterinfo();
        Dao dao = new Dao();
        public static int id;
        public static string name;
        public static int age;
        public static string sex,phone;
        public static string QQ;
        public static string email;
        public Superuser()
        {
            InitializeComponent();
        }

        //
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒");
        }

        //写一个方法加载表中重要信息
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
            int m = 0;
            //如果查询结果不为空
            if (dao.GetDataTable(sqlm) != null)
            {
                //将结果（表中第一行第一列）Object类型转化为整型赋给变量
                m = (int)dao.GetDataTable(sqlm).Rows[0][0];
            }
            //通过SQL查询语句（聚合函数）获取表中女生人数
            string sqlwm = "select COUNT(*) from student_info where Sex='女'";
            int wm = 0;
            if (dao.GetDataTable(sqlm) != null)
            {
                wm = (int)dao.GetDataTable(sqlwm).Rows[0][0];
            }
            //将查询结果显示到label标签上
            this.label3.Text = string.Format("共有学生{0}人,男生{1}人，女生{2}人", num, m, wm);
        }


        private void Superuser_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet1.su”中。您可以根据需要移动或删除它。
            this.suTableAdapter.Fill(this.studentDataSet1.su);
            // TODO: 这行代码将数据加载到表“studentDataSet.student_info”中。您可以根据需要移动或删除它。
            this.student_infoTableAdapter.Fill(this.studentDataSet.student_info);

        }


        //刷新
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet1.su”中。您可以根据需要移动或删除它。
            this.suTableAdapter.Fill(this.studentDataSet1.su);
            // TODO: 这行代码将数据加载到表“studentDataSet.student_info”中。您可以根据需要移动或删除它。
            this.student_infoTableAdapter.Fill(this.studentDataSet.student_info);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addinfo.ShowDialog(this);
        }
        
        //删除信息
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //判断容器内有无数据
            if (this.dataGridView2.SelectedRows.Count > 0)
            {
                //获取容器中选中的那一行数据
                DataGridViewRow selerow = this.dataGridView2.SelectedRows[0];
                //将id这个单元格的值赋给变量，类型不同时要进行类型转换
                int id = (int)selerow.Cells["ID"].Value;
                //通过SQL删除语句删除ID那一行信息
                string sqlstr = string.Format("delete from st where ID={0}", id);
                if (new Dao().ExecuteNonQuery(sqlstr))
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        //修改
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //判断容器内有无数据
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                //获取容器中选中的那一行数据
                DataGridViewRow selerow = this.dataGridView1.SelectedRows[0];
                //将id这个单元格的值赋给静态方法中定义的变量，实现值传递，类型不同时要进行类型转换
                id = (int)selerow.Cells["iDDataGridViewTextBoxColumn"].Value;
                //将name这个单元格的值赋给变量，类型不同时要进行类型转换
                name = (string)selerow.Cells["nameDataGridViewTextBoxColumn"].Value;
                //将age这个单元格的值赋给静态方法中定义的变量，实现值传递，类型不同时要进行类型转换
                age = (int)selerow.Cells["ageDataGridViewTextBoxColumn"].Value;
                //将sex这个单元格的值赋给静态方法中定义的变量，实现值传递，类型不同时要进行类型转换
                sex = (string)selerow.Cells["sexDataGridViewTextBoxColumn"].Value;
                //将phone这个单元格的值赋给静态方法中定义的变量，实现值传递，类型不同时要进行类型转换
                phone = (string)selerow.Cells["phoneDataGridViewTextBoxColumn"].Value;
                //将QQ这个单元格的值赋给静态方法中定义的变量，实现值传递，类型不同时要进行类型转换
                QQ = (string)selerow.Cells["QQDataGridViewTextBoxColumn"].Value;
                //将email这个单元格的值赋给静态方法中定义的变量，实现值传递，类型不同时要进行类型转换
                email = (string)selerow.Cells["emailDataGridViewTextBoxColumn"].Value;
                //获取完毕之后跳转到修改窗体
                
                alterinfo.ShowDialog(this);

            }

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.ExitThread();
        }

        ////功能（模糊查询姓名）：
        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text.Trim();
            //必须在文本框内输值，非空判断
            if (name == "")
            {
                MessageBox.Show("请输入需要查寻人的姓氏");
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
                    MessageBox.Show("查无此姓！");
                    return;
                }
            }
        }
    }
}
