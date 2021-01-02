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
    public partial class Publicuser : Form
    {
        Dao dao = new Dao();
        public Publicuser()
        {
            InitializeComponent();
        }

        private void Publicuser_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“studentDataSet7.student_info”中。您可以根据需要移动或删除它。
            this.student_infoTableAdapter1.Fill(this.studentDataSet7.student_info);
            // TODO: 这行代码将数据加载到表“studentDataSet2.student_info”中。您可以根据需要移动或删除它。
            //this.student_infoTableAdapter.Fill(this.studentDataSet2.student_info);
        }
        //查询
        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text.Trim();
            //必须在文本框内输值，非空判断
            if (name == "")
            {
                this.student_infoTableAdapter.Fill(this.studentDataSet2.student_info);
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
                    MessageBox.Show("查无此姓!","警告!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
            }
        }
        //切换登录角色
        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        //退出
        private void button3_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}