using Microsoft.Extensions.DependencyInjection;
using MusicLibrary.DatatAccess;
using MusicLibrary.Service.Interface;
using MusicLibrary.Service.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicLibrary.Service
{
    public static class ServiceRegistration
    {
        public static void AddServiecLayer(this IServiceCollection services)
        {
            services.AddDataAccess();
            services.AddTransient<IArtistService, ArtistService>();
            services.AddTransient<IAlbumnService, AlbumService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}