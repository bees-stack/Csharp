using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApp2
{
    class ConnectionDatabase
    {
        //定义sqlConnection，判断是否连接成功,直接初始化
        public static  SqlConnection sqlConnection=null;
        //新建一个连接字符串
        public static string sqlConnectionStr = @"Data Source=LEEYANGY\LEEYANGY;Initial Catalog=Student;Integrated Security=True";

        //i定义Sql_Connection()与数据库建立连接，Sql_Connection()后续还需要被调用
        public static SqlConnection Sql_Connection() {
            sqlConnection = new SqlConnection(sqlConnectionStr);
            sqlConnection.Open();
            return sqlConnection;
        }

        //关闭数据库连接
        public void sqlConnection_close() {
            if (sqlConnection.State == ConnectionState.Open) {
                //关闭并释放资源
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
        }

        //Command查询
        public  SqlCommand command(string sqlStr) {
            //连接数据库
            Sql_Connection();
            //实例化对象，把值传入
            SqlCommand cmd = new SqlCommand(sqlStr,sqlConnection);
            return cmd;
        }

        //
        public int Excute(string sqlStr) {
            return command(sqlStr).ExecuteNonQuery();
        }


        //读取数据库中的内容
        public SqlDataReader read(string sqlStr)
        {
            //连接数据库
            Sql_Connection();
            return command(sqlStr).ExecuteReader();
        }





    }
}
