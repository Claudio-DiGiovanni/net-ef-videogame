using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame.models
{
    [Table("software_houses")]
    public class SoftwareHouse
    {
        [Key]
        public long Id {  get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("tax_id")]
        public long TaxId { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set;}
        public IEnumerable<Videogame>? Videogames { get; set; }

    }
}
