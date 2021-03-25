using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MusicLibrary.DatatAccess
{
    public sealed class AppSettings
    {
        private static AppSettings _instance = null;
        private static readonly object padlock = new object();
        public readonly string _connectionString = string.Empty;

        private AppSettings()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"), optional: false)
                .Build();

            _connectionString = configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
        }

        public static AppSettings Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new AppSettings();
                    }
                    return _instance;
                }
            }
        }

        public string ConnectionString
        {
            get => _connectionString;
        }
    }
}