using MusicLibrary.Core.Entities;
using MusicLibrary.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Service.Interface
{
    public interface IArtistService
    {
        Task<List<ArtistDTO>> GetArtistDetails();

        Task<ArtistDTO> GetArtistById(int artistId);
    }
}