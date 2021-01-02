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
    public partial class Altersu : Form
    {
        public Altersu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //修改密码
            string id = this.textBox1.Text.Trim();
            string newpaw = this.textBox2.Text.Trim();
            //非空验证
            if (id == "" || newpaw == "")
            {
                MessageBox.Show("请输入完整信息！", "警告：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Dao dao = new Dao();
                //通过SQL修改语句根据UserID修改
                string sqlstr = string.Format("update su set Paw='{0}' where ID='{1}' ", newpaw, id);
                if (id == "1001" || id == "1002")
                {
                    MessageBox.Show("超级用户不允许被修改", "警告：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dao.ExecuteNonQuery(sqlstr))
                {
                    MessageBox.Show("修改成功!", "提示：修改成功!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.textBox2.Text = "";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败!", "提示：修改失败!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Altersu_Load(object sender, EventArgs e)
        {
            //将Supersu窗体中的数据传过来
            textBox1.Text = Superuser.id.ToString();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //点错
        }
    }
}