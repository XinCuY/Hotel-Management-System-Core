using System;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    /// <summary>
    /// 数据库操作帮助类
    /// </summary>
    class DBHelper
    {
        /// <summary>
        /// 执行SQL语句，返回影响的记录数（用于单行记录的增、删、改操作）
        /// </summary>
        /// <param name="SQLString">SQL语句</param>
        /// <returns>影响的记录数</returns>
        public static int ExecuteSql(string SQLString)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.con);
            SqlCommand cmd = new SqlCommand(SQLString, con);
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch (SqlException ex)
            {
                con.Close();
                throw ex; // 把异常抛出，方便上层调用者处理
            }
        }

        /// <summary>
        /// 执行查询语句，返回DataSet（用于查询操作）
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public static DataSet GetDataSet(string SQLString)
        {
            SqlConnection con = new SqlConnection(Properties.Resources.con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlDataAdapter cmd = new SqlDataAdapter(SQLString, con);
                cmd.Fill(ds, "ds");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close(); 
            }
            return ds;
        }
    }
}