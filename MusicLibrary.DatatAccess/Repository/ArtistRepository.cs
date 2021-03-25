using Dapper;
using Microsoft.Extensions.Logging;
using MusicLibrary.Core.Entities;
using MusicLibrary.DatatAccess.DBFactory;
using MusicLibrary.DatatAccess.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MusicLibrary.DatatAccess.Repository
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly ILogger<ArtistRepository> _logger;
        private readonly IDbFactory _sqlConnection;

        public ArtistRepository(IDbFactory sqlConnection, ILogger<ArtistRepository> logger)
        {
            _logger = logger;
            _sqlConnection = sqlConnection;
        }

        /// <summary>
        /// To Get Artist Infomration
        /// </summary>
        /// <returns>artist</returns>
        public async Task<List<Artist>> GetArtistDetails()
        {
            try
            {
                using (IDbConnection dbConnection = _sqlConnection.GetConnection())
                {
                    if (dbConnection.State == ConnectionState.Closed)
                        dbConnection.Open();

                    var artist = await dbConnection.QueryAsync<Artist>("GetArtistInformation", null, null, 0, CommandType.StoredProcedure).ConfigureAwait(false);

                    return artist.ToList();
                }
            }
            catch (SqlException ex)
            {
                _logger.LogError(ex, nameof(GetArtistDetails));
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(GetArtistDetails));
                throw;
            }
        }

        /// <summary>
        /// To Get Artist Infomration by artist id
        /// </summary>
        /// <returns>artist</returns>
        public async Task<Artist> GetArtistById(int artistId)
        {
            try
            {
                using (IDbConnection dbConnection = _sqlConnection.GetConnection())
                {
                    if (dbConnection.State == ConnectionState.Closed)
                        dbConnection.Open();

                    var parameter = new DynamicParameters();
                    parameter.Add("@Id", artistId);
                    return await dbConnection.QuerySingleOrDefaultAsync<Artist>("GetArtistByID", parameter, null, 0, CommandType.StoredProcedure).ConfigureAwait(false);
                }
            }
            catch (SqlException ex)
            {
                _logger.LogError(ex, nameof(GetArtistDetails));
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, nameof(GetArtistDetails));
                throw;
            }
        }
    }
}