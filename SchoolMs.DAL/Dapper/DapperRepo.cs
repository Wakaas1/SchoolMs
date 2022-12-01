global using Dapper;
global using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace SchoolMs.DAL.Dapper
{
    public class DapperRepo : IDapperRepo
    {
        private string connectionString;


        public DapperRepo(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConn");
        }


        public T ExecuteReturnScalar<T>(string procrdureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.Execute(procrdureName, param, commandType: CommandType.StoredProcedure), typeof(T));
            }

        }
        public void Execute(string procrdureName, DynamicParameters param)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procrdureName, param, commandType: CommandType.StoredProcedure);
            }

        }

        //DapperORM.RetrunList<TeacherModel> <= IEnumberable<TeacherModel>

        public IEnumerable<T> ReturnList<T>(string procrdureName, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procrdureName, param, commandType: CommandType.StoredProcedure);
            }

        }
        public int CreateReturnInt(string StoredProcedure, DynamicParameters param = null)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(StoredProcedure, param, commandType: CommandType.StoredProcedure);
                return param.Get<int>("Id");
            }
        }

    }
}
