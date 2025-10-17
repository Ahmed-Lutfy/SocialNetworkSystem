using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Social.Domain.Entities
{
    public abstract class BaseEntity
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [JsonIgnore]
        public DateTime? UpdatedAt { get; set; } = DateTime.UtcNow;
        [JsonIgnore]
        public bool IsDeleted { get; set; } = false;
    }
}

