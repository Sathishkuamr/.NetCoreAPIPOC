using MusicLibrary.DatatAccess.DBFactory;
using System.Data;
using System.Data.SqlClient;

namespace MusicLibrary.DatatAccess.DBFactory
{
    public class SqlServerConnectionProvider : IDbFactory
    {
        private readonly string _connectionString;

        public SqlServerConnectionProvider(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}