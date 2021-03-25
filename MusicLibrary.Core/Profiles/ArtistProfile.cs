using AutoMapper;
using MusicLibrary.Core.Entities;
using MusicLibrary.Core.Models;
using System.Collections.Generic;

namespace MusicAPIPOC.Mappings
{
    public class ArtistProfile : Profile
    {
        public ArtistProfile()
        {
            CreateMap<Artist, ArtistDTO>();
        }
    }
}