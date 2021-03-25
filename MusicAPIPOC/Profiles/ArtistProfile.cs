using AutoMapper;
using MusicLibrary.Core.Entities;
using MusicLibrary.Core.Models;

namespace MusicLibrary.Profiles
{
    public class ArtistProfile : Profile
    {
        public ArtistProfile()
        {
            CreateMap<Artist, ArtistDTO>();
        }
    }
}