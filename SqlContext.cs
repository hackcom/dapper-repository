using System.Data;
using System.Data.SqlClient;

namespace Hackcom.Dapper
{
    public class SqlContext : IRepoContext
    {
        private string _connectionString;
        public SqlContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IDbConnection CeateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
