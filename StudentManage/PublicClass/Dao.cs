using System;
using System.Data;
using System.Data.SqlClient;

namespace StudentManage
{
    class Dao
    {
        //连接字符串为自己数据库的        
        public static string connstr = "Data Source=.;Initial Catalog=Student;Integrated Security=True";
        public static SqlConnection sc;
        //public static void mycon() {
        //    //database==null
        //    if (sc == null) {
        //        sc = new SqlConnection(connstr);
        //        sc.Open();
        //    }
        //    //database==broken
        //    if (sc.State == ConnectionState.Broken) {
        //        sc.Close();
        //        sc.Open();
        //    }
        //    //database==closed
        //    if (sc.State ==  ConnectionState.Closed) {
        //        sc.Close();
        //        sc.Open();
        //    }
        //}

        //数据库连接方法
        public static SqlConnection getcon()
        {
            //新建一个连接，返回连接值
            sc = new SqlConnection(connstr);
            sc.Open();
            return sc;
        }

        //数据库关闭方法
        public static void scclose()
        {
            //判断数据库当前连接状态 如果为连接状态，则关闭并释放sc的所有空间(dispose方法)
            if (sc.State == ConnectionState.Open)
            {
                sc.Close();
                sc.Dispose();
            }
        }
        public DataTable GetDataTable(string sqlstr)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                getcon();
                SqlDataAdapter dap = new SqlDataAdapter(sqlstr, getcon());
                dap.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            finally
            {
                if (sc != null)
                    scclose();
            }
            return dt;
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sqlstr">sql命令</param>
        /// <returns>增删改成功，返回true；否则，返回false</returns>
        public bool ExecuteNonQuery(string sqlstr)
        {
            try
            {   
                //数据库连接
                getcon();
                SqlCommand cmd = new SqlCommand(sqlstr, sc);
                return (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (sc != null)
                    sc.Close();
            }
        }

        //SqlDataReader 对象以只读方式读取数据库中信息，getcom方法
        public SqlDataReader getcom(string sqlstr)
        {

            //连接数据库
            getcon();
            //创建command对象执行sql语句
            SqlCommand scmd = new SqlCommand();
            //获取指定sql语句
            scmd.CommandText = sqlstr;
            //执行sql语句,生成sqlDataReader对象
            SqlDataReader sdr = scmd.ExecuteReader();
            //返回sdr对象
            return sdr;

        }
        public void getsqlcommand(string sqlstr)
        {
            getcon();
            SqlCommand sqlcommand = new SqlCommand(sqlstr, sc);
            //执行sql语句
            sqlcommand.ExecuteNonQuery();
            //释放资源
            sqlcommand.Dispose();
            //关闭数据库连接
            scclose();
        }
        //getDaaSet方法通过command对象执行数据库中添加，修改和删除
        public DataSet getDataSet(string sqlstr)
        {
            //数据库连接
            getcon();
            SqlDataAdapter sda = new SqlDataAdapter(sqlstr, sc);
            DataSet ds = new DataSet();
            //调用SqlDataAdapter 对象中的Fill
            sda.Fill(ds);
            //数据库关闭
            scclose();
            //返回dataset对象
            return ds;
        }
    }
}
