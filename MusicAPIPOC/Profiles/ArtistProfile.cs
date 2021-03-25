using AutoMapper;
using MusicLibrary.Core.Entities;
using MusicLibrary.Core.Models;
using System.Collections.Generic;

namespace MusicLibrary.Core.Profiles
{
    public class ArtistProfile : Profile
    {
        public ArtistProfile()
        {
            CreateMap<Artist, ArtistDTO>();

            //.ForMember(dest => dest.Id, act => act.MapFrom(src => src.Id.ToString()))
            //.ForMember(dest => dest.Name, act => act.MapFrom(src => src.Name.ToString()))
            //.ForMember(dest => dest.Address, act => act.MapFrom(src => src.Address.ToString()))
            //.ForMember(dest => dest.Country, act => act.MapFrom(src => src.Country.ToString()))
            //.ForMember(dest => dest.CreatedDate, act => act.Ignore())
            //.ForMember(dest => dest.CreatedBy, act => act.Ignore())
            //.ForMember(dest => dest.LastUpdatedBy, act => act.Ignore())
            //.ForMember(dest => dest.LastUpdatedDate, act => act.Ignore());
        }
    }
}