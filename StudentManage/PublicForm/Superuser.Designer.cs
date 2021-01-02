namespace StudentManage.PublicForm
{
    partial class Superuser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qQq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emaill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet5 = new StudentManage.StudentDataSet5();
            this.studentinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet = new StudentManage.StudentDataSet();
            this.student_infoTableAdapter = new StudentManage.StudentDataSetTableAdapters.student_infoTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet6 = new StudentManage.StudentDataSet6();
            this.suBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDataSet1 = new StudentManage.StudentDataSet1();
            this.suTableAdapter = new StudentManage.StudentDataSet1TableAdapters.suTableAdapter();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.studentDataSet4 = new StudentManage.StudentDataSet4();
            this.su2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.su2TableAdapter = new StudentManage.StudentDataSet4TableAdapters.su2TableAdapter();
            this.student_infoTableAdapter1 = new StudentManage.StudentDataSet5TableAdapters.student_infoTableAdapter();
            this.suTableAdapter1 = new StudentManage.StudentDataSet6TableAdapters.suTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.su2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 538);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "时间";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDD,
            this.agee,
            this.namee,
            this.sexx,
            this.phonee,
            this.qQq,
            this.emaill});
            this.dataGridView1.DataSource = this.studentinfoBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(849, 269);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDD
            // 
            this.iDD.DataPropertyName = "ID";
            this.iDD.HeaderText = "学号";
            this.iDD.MinimumWidth = 6;
            this.iDD.Name = "iDD";
            this.iDD.Width = 80;
            // 
            // agee
            // 
            this.agee.DataPropertyName = "Age";
            this.agee.HeaderText = "年龄";
            this.agee.MinimumWidth = 6;
            this.agee.Name = "agee";
            this.agee.Width = 80;
            // 
            // namee
            // 
            this.namee.DataPropertyName = "Name";
            this.namee.HeaderText = "姓名";
            this.namee.MinimumWidth = 6;
            this.namee.Name = "namee";
            this.namee.Width = 80;
            // 
            // sexx
            // 
            this.sexx.DataPropertyName = "Sex";
            this.sexx.HeaderText = "性别";
            this.sexx.MinimumWidth = 6;
            this.sexx.Name = "sexx";
            this.sexx.Width = 80;
            // 
            // phonee
            // 
            this.phonee.DataPropertyName = "Phone";
            this.phonee.HeaderText = "手机号";
            this.phonee.MinimumWidth = 6;
            this.phonee.Name = "phonee";
            this.phonee.Width = 80;
            // 
            // qQq
            // 
            this.qQq.DataPropertyName = "QQ";
            this.qQq.HeaderText = "QQ";
            this.qQq.MinimumWidth = 6;
            this.qQq.Name = "qQq";
            this.qQq.Width = 80;
            // 
            // emaill
            // 
            this.emaill.DataPropertyName = "Email";
            this.emaill.HeaderText = "电邮";
            this.emaill.MinimumWidth = 6;
            this.emaill.Name = "emaill";
            this.emaill.Width = 150;
            // 
            // studentinfoBindingSource1
            // 
            this.studentinfoBindingSource1.DataMember = "student_info";
            this.studentinfoBindingSource1.DataSource = this.studentDataSet5;
            // 
            // studentDataSet5
            // 
            this.studentDataSet5.DataSetName = "StudentDataSet5";
            this.studentDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentinfoBindingSource
            // 
            this.studentinfoBindingSource.DataMember = "student_info";
            this.studentinfoBindingSource.DataSource = this.studentDataSet;
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "StudentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_infoTableAdapter
            // 
            this.student_infoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDD,
            this.Paw});
            this.dataGridView2.DataSource = this.suBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(0, 346);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(301, 216);
            this.dataGridView2.TabIndex = 2;
            // 
            // IDDD
            // 
            this.IDDD.DataPropertyName = "ID";
            this.IDDD.HeaderText = "账号";
            this.IDDD.MinimumWidth = 6;
            this.IDDD.Name = "IDDD";
            this.IDDD.Width = 125;
            // 
            // Paw
            // 
            this.Paw.DataPropertyName = "Paw";
            this.Paw.HeaderText = "密码";
            this.Paw.MinimumWidth = 6;
            this.Paw.Name = "Paw";
            this.Paw.ReadOnly = true;
            this.Paw.Width = 125;
            // 
            // suBindingSource1
            // 
            this.suBindingSource1.DataMember = "su";
            this.suBindingSource1.DataSource = this.studentDataSet6;
            // 
            // studentDataSet6
            // 
            this.studentDataSet6.DataSetName = "StudentDataSet6";
            this.studentDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suBindingSource
            // 
            this.suBindingSource.DataMember = "su";
            this.suBindingSource.DataSource = this.studentDataSet1;
            // 
            // studentDataSet1
            // 
            this.studentDataSet1.DataSetName = "StudentDataSet1";
            this.studentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suTableAdapter
            // 
            this.suTableAdapter.ClearBeforeFill = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(849, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::StudentManage.Resource.刷新1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 28);
            this.toolStripButton1.Text = "刷新";
            this.toolStripButton1.ToolTipText = "刷新";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::StudentManage.Resource.添加1;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(63, 28);
            this.toolStripButton2.Text = "新增";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::StudentManage.Resource.退出2;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(63, 28);
            this.toolStripButton3.Text = "删除";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::StudentManage.Resource.修改1;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(63, 28);
            this.toolStripButton4.Text = "修改";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::StudentManage.Resource.退出1;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(93, 28);
            this.toolStripButton5.Text = "注销登录";
            this.toolStripButton5.ToolTipText = "退出";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "请输入要查找人的姓：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 25);
            this.textBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 538);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "人数统计";
            // 
            // studentDataSet4
            // 
            this.studentDataSet4.DataSetName = "StudentDataSet4";
            this.studentDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // su2BindingSource
            // 
            this.su2BindingSource.DataMember = "su2";
            this.su2BindingSource.DataSource = this.studentDataSet4;
            // 
            // su2TableAdapter
            // 
            this.su2TableAdapter.ClearBeforeFill = true;
            // 
            // student_infoTableAdapter1
            // 
            this.student_infoTableAdapter1.ClearBeforeFill = true;
            // 
            // suTableAdapter1
            // 
            this.suTableAdapter1.ClearBeforeFill = true;
            // 
            // Superuser
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Superuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎您~~超级用户";
            this.Load += new System.EventHandler(this.Superuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.su2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource studentinfoBindingSource;
        private StudentDataSetTableAdapters.student_infoTableAdapter student_infoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private StudentDataSet1 studentDataSet1;
        private System.Windows.Forms.BindingSource suBindingSource;
        private StudentDataSet1TableAdapters.suTableAdapter suTableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private StudentDataSet4 studentDataSet4;
        private System.Windows.Forms.BindingSource su2BindingSource;
        private StudentDataSet4TableAdapters.su2TableAdapter su2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn agee;
        private System.Windows.Forms.DataGridViewTextBoxColumn namee;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexx;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonee;
        private System.Windows.Forms.DataGridViewTextBoxColumn qQq;
        private System.Windows.Forms.DataGridViewTextBoxColumn emaill;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paw;
        private StudentDataSet5 studentDataSet5;
        private System.Windows.Forms.BindingSource studentinfoBindingSource1;
        private StudentDataSet5TableAdapters.student_infoTableAdapter student_infoTableAdapter1;
        private StudentDataSet6 studentDataSet6;
        private System.Windows.Forms.BindingSource suBindingSource1;
        private StudentDataSet6TableAdapters.suTableAdapter suTableAdapter1;
    }
}