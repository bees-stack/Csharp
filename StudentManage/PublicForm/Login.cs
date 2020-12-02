using StudentManage.PublicForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManage
{
    public partial class Login : Form
    {
        
        Superuser su = new Superuser();
        Publicuser pu = new Publicuser();
        Register register = new Register();
        public Login()
        {
            InitializeComponent();
            Rc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            string id = textBox1.Text.Trim();
            string paw = textBox2.Text.Trim();
            string verification = textBox3.Text.Trim();
            if (id == "" && paw == "" && verification == "")
            {
                MessageBox.Show("你还想怎样？账号密码验证码都不会输一下？", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (id == "")
            {
                MessageBox.Show("账号不能为空啊大兄弟", "警告：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (paw == "")
            {
                MessageBox.Show("密码不能为空啊大兄弟", "警告：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (verification == "")
            {
                MessageBox.Show("你是看没见框框右边滴验证码是咩？", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (verification != label4.Text)
                {
                    MessageBox.Show("验证码错啦兄弟！点确定回去重新输入！！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Rc();
                }
                else
                {
                    Dao dao = new Dao();
                    string sqlstr = string.Format("select * from su  where ID='{0}' and Paw='{1}'", id, paw);
                    DataTable dt = dao.GetDataTable(sqlstr);
                    //返回受影响行数>0即为登录成功
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        if (radioButton2.Checked == true)
                        {
                            su.Show();
                            this.Hide();
                        }
                        else
                        {   
                            pu.Show();
                            this.Hide();
                        }
                       login .Close();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误", "警告：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

        //随机数生成方法
        private void Rc()
        {
            //random() 方法返回随机生成的一个数
            Random random = new Random();
            string randomcode = "";
            for (int i = 0; i < 4; i++)
            {
                //随机两个数，0表示数字、1表示小写字母、2表示大写字母
                //将其赋值给type 大于等于最小数，小于最大数，不可取上线Next(0,3) = '0.1.2'
                int rc = random.Next(0, 3);
                if (rc == 0)
                {
                    randomcode += random.Next(0, 10).ToString();
                }
                else if (rc == 1)
                {
                    //char是整型数据可以实现为不带符号的，还可以通过编译开关来指定它是有符号数还是无符号数。
                    randomcode += ((char)random.Next(97, 123)).ToString();
                }
                else
                {
                    randomcode += ((char)random.Next(65, 91)).ToString();
                }
            }
            //将验证码写入label中
            label4.Text = randomcode;
            //设置验证码颜色随机
            label4.ForeColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            //设置验证码大小随机
            label4.Font = new Font("楷体", random.Next(16, 17));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Rc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            register.ShowDialog(this);
        }
    }
}
