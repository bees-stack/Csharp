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
    public partial class Addinfo : Form
    {
        public Addinfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //加载性别
        private void LoadInfmtSex()
        {
            //清空combobox控件中的项
            this.comboBox1.Items.Clear();
            //通过sql查询（聚合函数）性别删除重复项
            string sqlStr = "select Sex from student_info GROUP BY Sex";
            Dao dao = new Dao();
            DataTable dt = dao.GetDataTable(sqlStr);
            if (dt != null && dt.Rows.Count > 0)
            {
                //结果循环添加到conbobox中
                //foreach适用于循环次数未知、
                //foreach（元素类型  元素名称 ： 遍历数组（集合）（或者能进行迭代的）
                {// 语句//}
                 //foreach适用于只是进行集合或数组遍历，for则在较复杂的循环中效率更高。
                 //foreach不能对数组或集合进行修改（添加删除操作），如果想要修改就要用for循环。
                    foreach (DataRow row in dt.Rows)
                    {
                        //将性别添加到combobox每一项中
                        this.comboBox1.Items.Add(row["Sex"]);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            int id = int.Parse(this.textBox1.Text.Trim());
            int age = int.Parse(this.textBox2.Text.Trim());
            string name = this.textBox3.Text.Trim();
            string sex = this.comboBox1.Text.Trim();
            string phone = this.textBox4.Text.Trim();
            string QQ = this.textBox5.Text.Trim();
            string email = this.textBox6.Text.Trim();
            //非空验证
            if (id == 0 || name == "" || age == 0 || sex == "" || phone == "" || QQ == "" || email == "")
            {
                MessageBox.Show("请输入完整信息！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Dao dao = new Dao();
                //先做一次查询，判断数据存在，如果存在弹出提示，禁止添加
                string sqlstr = "select * from student_info where ID='" + id + "'";
                DataTable dt = dao.GetDataTable(sqlstr);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("学号重复，请修改", "警告：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //Sql添加语句
                    string sqlstr1 = string.Format("Insert student_info(ID,Name,Age,Sex,Phone,QQ,Email) select '{0}','{1}','{2}','{3}','{4}','{5}','{6}'", id, name, age, sex, phone, QQ, email);
                    if (dao.ExecuteNonQuery(sqlstr1))
                    {
                        MessageBox.Show("添加成功！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        comboBox1.Text = "";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("添加失败！", "警告：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

        private void keypressed(object sender, KeyPressEventArgs e)
        {
            //允许输入退格键
            if (e.KeyChar != '\b') 
            {
                //这是允许输入0-9数字
                if ((e.KeyChar < '0') || (e.KeyChar > '9')) 
                {
                    e.Handled = true;
                }
            }
        }
    }
}