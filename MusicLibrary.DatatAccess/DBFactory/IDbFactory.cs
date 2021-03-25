using System.Data;

namespace MusicLibrary.DatatAccess.DBFactory
{
    public interface IDbFactory
    {
        IDbConnection GetConnection();
    }
}