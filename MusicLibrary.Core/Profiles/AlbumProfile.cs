using AutoMapper;
using MusicLibrary.Core.Entities;
using MusicLibrary.Core.Models;

namespace MusicLibrary.Core.Profiles
{
    public class AlbumProfile : Profile
    {
        public AlbumProfile()
        {
            CreateMap<AlbumDTO, Album>();
        }
    }
}