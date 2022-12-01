
namespace SchoolMs.DAL.Dapper
{
    public interface IDapperRepo
    {
        T ExecuteReturnScalar<T>(string procrdureName, DynamicParameters param = null);
        void Execute(string procrdureName, DynamicParameters param);
        IEnumerable<T> ReturnList<T>(string procrdureName, DynamicParameters param = null);
        int CreateReturnInt(string StoredProcedure, DynamicParameters param = null);

    }
}
