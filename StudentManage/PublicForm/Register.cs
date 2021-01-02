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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //点错了
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //点错了
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //注册
        private void button3_Click(object sender, EventArgs e)
        {
            string id = this.textBox5.Text.Trim();
            string paw = this.textBox6.Text.Trim();
            string againpaw = this.textBox7.Text.Trim();
            //非空验证
            if (id == "" || paw == "")
            {
                MessageBox.Show("请输入完整信息!", "警告：请输入完整信息!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (paw != againpaw)
            {
                MessageBox.Show("两次密码输入不一致!", "警告：两次密码输入不一致!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Dao dao = new Dao();
                //判断注册的账号与数据库中账号有无重复
                string sql = "select * from guess where ID='" + id + "'";
                DataTable dt = dao.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("账号重复!", "警告：账号重复!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //通过SQL添加语句添加
                    string sqlstr = string.Format("insert guess(ID,Paw) select '{0}','{1}'", id, paw);
                    dt = dao.GetDataTable(sqlstr);
                    if (dao.ExecuteNonQuery(sqlstr))
                    {
                        MessageBox.Show("注册成功!", "警告：注册成功!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //清空文本框
                        this.textBox5.Text = "";
                        this.textBox6.Text = "";
                        this.textBox7.Text = "";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败!", "警告：注册失败!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }
        //修改密码
        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text.Trim();
            string paw = this.textBox2.Text.Trim();
            string newpaw = this.textBox3.Text.Trim();
            string agnewpaw = this.textBox4.Text.Trim();
            //非空验证
            if (id == "" || paw == "" || newpaw == "" || agnewpaw == "")
            {
                MessageBox.Show("请输入完整信息!", "警告：请输入完整信息!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (newpaw != agnewpaw)
            {
                MessageBox.Show("两次密码输入不一致!", "警告：两次密码输入不一致!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Dao dao = new Dao();
                //通过SQL修改语句根据UserID修改
                string sqlstr = string.Format("update guess set Paw='{0}' where ID='{1}' ", newpaw, id);
                DataTable dt = dao.GetDataTable(sqlstr);
                if (id == "10001" || id == "10002")
                {
                    MessageBox.Show("超级用户不允许被修改", "警告：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dao.ExecuteNonQuery(sqlstr))
                {
                    MessageBox.Show("修改成功!", "提示：修改成功!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //清空文本框
                    this.textBox1.Text="";
                    this.textBox2.Text="";
                    this.textBox3.Text="";
                    this.textBox4.Text="";
                    return;
                }
                else
                {
                    MessageBox.Show("修改失败!", "提示：修改失败!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
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
