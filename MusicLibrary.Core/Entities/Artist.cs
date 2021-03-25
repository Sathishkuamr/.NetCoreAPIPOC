using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MusicLibrary.Core.Entities
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string CreatedBy { get; set; } = "System";
        public DateTime CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; } = "System";
        public DateTime LastUpdatedDate { get; set; }

        [JsonIgnore]
        public virtual ICollection<Album> Albums { get; set; }
    }
}