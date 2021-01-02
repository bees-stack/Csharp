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
    public partial class Regsu : Form
    {
        public Regsu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text.Trim();
            string paw = this.textBox2.Text.Trim();
            //非空验证
            if (id == "" || paw == "")
            {
                MessageBox.Show("请输入完整信息！", "警告：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Dao dao = new Dao();
                //判断注册的账号与数据库中账号有无重复
                string sql = "select * from su where ID='" + id + "'";
                DataTable dt = dao.GetDataTable(sql);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("账号重复", "警告：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //通过SQL添加语句添加
                    string sqlstr = string.Format("insert su(ID,Paw) select '{0}','{1}'", id, paw);
                    if (dao.ExecuteNonQuery(sqlstr))
                    {
                        MessageBox.Show("注册成功！", "注册成功：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       //清空文本框
                        this.textBox1.Text = "";
                        this.textBox2.Text = "";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("注册失败！", "注册失败：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                //允许输入0-9数字 
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}