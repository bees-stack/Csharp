using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string UID = textBox1.Text.Trim();
            string UPAW = textBox2.Text.Trim();
            //非空验证
            if (UID == "" && UPAW == "") {
                MessageBox.Show("重新输入哦");
            }
            //实例化对象
            ConnectionDatabase cd = new ConnectionDatabase();
            string sqlStr = "select * from login_in where username='"+textBox1.Text+"' and password='"+textBox2.Text+"'";
            //读入数据库操作  执行完操作后dr已经读到上一条语句后的内容
            IDataReader dr = cd.read(sqlStr);
            if (dr.Read())
            {
                MessageBox.Show("登录成功,即将跳转到下一个页面");
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("登录失败");
                return ;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Application.ExitThread();
        }
    }
}
