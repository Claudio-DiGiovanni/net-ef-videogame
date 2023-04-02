using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame.models
{
    [Table("software_houses")]
    public class SoftwareHouse
    {
        public long Id {  get; set; }
        public string? Name { get; set; }
        public long TaxId { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set;}
        public IEnumerable<Videogame>? Videogames { get; set; }

    }
}
