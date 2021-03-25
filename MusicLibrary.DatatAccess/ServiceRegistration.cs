using Microsoft.Extensions.DependencyInjection;
using MusicLibrary.DatatAccess.DBFactory;
using MusicLibrary.DatatAccess.Interface;
using MusicLibrary.DatatAccess.Repository;

namespace MusicLibrary.DatatAccess
{
    public static class ServiceRegistration
    {
        public static void AddDataAccess(this IServiceCollection services)
        {
            services.AddTransient<IArtistRepository, ArtistRepository>();
            services.AddTransient<IAlbumRepository, AlbumRepository>();
            services.AddSingleton<IDbFactory>(new SqlServerConnectionProvider(AppSettings.Instance.ConnectionString));
        }
    }
}