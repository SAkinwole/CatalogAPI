using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Domain.Entities
{
    public class Artist
    {
        public Guid ArtistId { get; set; }
        public string ArtistName { get; set; }
        public ICollection<Item> Items { get; set; } 
    }
}