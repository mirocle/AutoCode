using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AutoCode.DataAccess
{
    public static class Access
    {
        public static DataTable GetAllTables(string strConnetion)
        {
            var conn = new SqlConnection(strConnetion);
            var ds = new DataSet();
            try
            {
                conn.Open();
                const string strSql = "select [name],[object_id] from sys.objects where type='U' order by [name] ";
                var adapter = new SqlDataAdapter(strSql, conn);

                adapter.Fill(ds);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return ds.Tables[0];
        }

        public static bool CheckDbConnection(string strConnetion)
        {
            var conn = new SqlConnection(strConnetion);
            try
            {
                conn.Open();
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return true;
        }

        public static DataTable GetDataBasesByType(string strConn)
        {
            const string strSql = " SELECT name FROM sysdatabases order by name ";

            return GetDataBases(strConn, strSql);
        }

        private static DataTable GetDataBases(string strConn, string strSql)
        {
            var conn = new SqlConnection(strConn);
            var ds = new DataSet();
            try
            {
                conn.Open();
                var sda = new SqlDataAdapter();
                var selCommand = new SqlCommand
                {
                    CommandType = CommandType.Text,
                    CommandText = strSql,
                    Connection = conn
                };

                sda.SelectCommand = selCommand;

                sda.Fill(ds);

            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }

        public static DataTable GetTableColunms(string tableName, string strConnetion)
        {
            var conn = new SqlConnection(strConnetion);
            var ds = new DataSet();
            try
            {
                conn.Open();
                var strSql = new StringBuilder();
                //strSQL.Append(" select  A.name as TableName,B.name as ColunmName,C.name TypeName,case WHEN left(D.CONSTRAINT_NAME,2)='PK' THEN '1' else '0' end as ISPkID,B.is_identity from sys.objects A ");
                //strSQL.Append(" left join sys.columns B on A.object_id=B.object_id ");
                //strSQL.Append(" left join sys.types C on B.system_type_id=C.user_type_id ");
                //strSQL.Append(" left join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE D on A.name=D.TABLE_NAME AND B.name=D.COLUMN_NAME ");
                //strSQL.Append(" where A.name=@name ");
                strSql.Append(@" select  A.name as TableName,B.name as ColunmName,C.name TypeName,case WHEN left(D.CONSTRAINT_NAME,2)='PK' THEN '1' else '0' end as ISPkID, B.is_identity
                                 from sys.objects A
                                 left join sys.columns B on A.object_id=B.object_id
                                 left join sys.types C on B.system_type_id=C.user_type_id
                                 left join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE D on A.name=D.TABLE_NAME AND B.name=D.COLUMN_NAME AND LEFT(D.CONSTRAINT_NAME,2)='PK'
                                 where A.name=@name ");

                var sqlparameter = new SqlParameter("@name", SqlDbType.VarChar, 100) {Value = tableName};
                var sqlcommand = new SqlCommand
                {
                    Connection = conn,
                    CommandText = strSql.ToString(),
                    CommandType = CommandType.Text
                };
                sqlcommand.Parameters.Add(sqlparameter);
                var adapter = new SqlDataAdapter(sqlcommand);
                adapter.Fill(ds);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return ds.Tables[0];
        }
    }

}
