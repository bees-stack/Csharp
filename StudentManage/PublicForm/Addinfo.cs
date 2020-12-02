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
            string sqlStr = "select Sex from InFmt GROUP BY Sex";
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
            //int.Parse()是一种类型转换，类似于Convert.ToString();表示将数字内容的字符串转为int类型。
            // 1、int适合简单数据类型之间的 转换，C#的默认整型是int32(不支持bool型);
            //2、int.Parse(string sParameter)是个构造函数，参数类型只支持string类型;
            // 3、Convert.ToInt32()适合将Object类型转换为int型;
            // 4、Convert.ToInt32()和int.Parse()的细微差别：
            int id = int.Parse(this.textBox1.Text.Trim());
            int age = int.Parse(this.textBox2.Text.Trim());
            string name = this.textBox3.Text.Trim();
            string sex = this.comboBox1.Text.Trim();
            string phone = this.textBox5.Text.Trim();
            string QQ = this.textBox6.Text.Trim();
            string email = this.textBox7.Text.Trim();
            //非空验证
            if (id == 0 || name == "" || age == 0 || sex == "" || phone == "" || QQ == "" || email == "")
            {
                MessageBox.Show("请输入完整信息！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Dao dao = new Dao();
                //Sql添加语句
                string sqlstr = string.Format("Insert student_info(ID,Name,Age,Sex,Phone,QQ,Email) select '{0}','{1}','{2}','{3}','{4}','{5}','{6}'", id, name, age, sex, phone, QQ, email);
                if (dao.ExecuteNonQuery(sqlstr))
                {
                    MessageBox.Show("添加成功！");
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }

        }
    }
}
