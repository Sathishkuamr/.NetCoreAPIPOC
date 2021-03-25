using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MusicLibrary.Core.Entities
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int ArtistId { get; set; }
        public int ReleaseYear { get; set; }
        public string CreatedBy { get; set; } = "System";
        public DateTime CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; } = "System";
        public DateTime LastUpdatedDate { get; set; }

        [JsonIgnore]
        public virtual Artist Artist { get; set; }
    }
}