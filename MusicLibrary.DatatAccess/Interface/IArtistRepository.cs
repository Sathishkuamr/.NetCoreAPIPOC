using MusicLibrary.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MusicLibrary.DatatAccess.Interface
{
    public interface IArtistRepository
    {
        Task<List<Artist>> GetArtistDetails();

        Task<Artist> GetArtistById(int artistId);
    }
}