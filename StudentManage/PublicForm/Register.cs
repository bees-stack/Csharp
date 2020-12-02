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

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            string id = this.textBox4.Text.Trim();
            string paw = this.textBox5.Text.Trim();
            string againpaw = this.textBox6.Text.Trim();
            //非空验证
            if (id == "" || paw == "")
            {
                MessageBox.Show("请输入完整信息！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (paw != againpaw)
            {
                MessageBox.Show("两次密码输入不一致！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dao dao = new Dao();
            //判断注册的账号与数据库中账号有无重复
            string sql = "select * from su where ID='" + id + "'";
            DataTable dt = dao.GetDataTable(sql);
            //满足条件输入提示：账号有重复
            if (dt != null && dt.Rows.Count > 0)
            {
                MessageBox.Show("账号重复");
                return;
            }
            else
            {
                //如果没有重复
                //通过SQL添加语句添加
                string sqlstr = string.Format("insert su(ID,Paw) select '{0}','{1}'", id, paw);
                if (dao.ExecuteNonQuery(sqlstr))
                {
                    MessageBox.Show("注册成功！");
                    return;
                }
                else
                {
                    MessageBox.Show("注册失败！");
                    return;
                }
            }

        }
        //修改密码
        private void button1_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text.Trim();
            string paw = this.textBox2.Text.Trim();
            string newpaw = this.textBox7.Text.Trim();
            string agnewpaw = this.textBox3.Text.Trim();
            //非空验证
            if (id == "" || paw == "" || newpaw == "" || agnewpaw == "")
            {
                MessageBox.Show("请输入完整信息！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Dao dao = new Dao();
                //通过SQL修改语句根据UserID修改
                string sqlstr = string.Format("update su set Paw='{0}' where ID='{1}' ", newpaw, id);
                if (dao.ExecuteNonQuery(sqlstr))
                {
                    MessageBox.Show("修改成功！");
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }

        }
    }
}
