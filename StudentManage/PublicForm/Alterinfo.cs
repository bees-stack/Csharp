﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManage.PublicForm
{
    public partial class Alterinfo : Form
    {
        public Alterinfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Superuser.id.ToString();
            textBox2.Text = Superuser.age.ToString();
            textBox3.Text = Superuser.name.ToString();
            comboBox1.Text = Superuser.sex.ToString();
            textBox4.Text = Superuser.phone.ToString();
            textBox5.Text = Superuser.QQ.ToString();
            textBox6.Text = Superuser.email.ToString();

            int id = int.Parse(this.textBox1.Text.Trim());
            int age = int.Parse(this.textBox2.Text.Trim());
            string name = this.textBox3.Text.Trim();
            string sex = this.comboBox1.Text.Trim();
            string phone = this.textBox5.Text.Trim();
            string QQ = this.textBox6.Text.Trim();
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
                //通过SQL修改语句根据ID修改信息
                string sqlstr = string.Format("update student_info set Name='{0}',Age='{1}',Sex='{2}',Phone='{3}' ,QQ={4},Email={5},where ID='{6}' ", name, age, sex, phone, QQ, email, id);
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
