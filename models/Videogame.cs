using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame.models
{
    [Table("videogames")]
    public class Videogame
    {
        [Key]
        public long Id { get; set; }
        [Column("name")]
        public string? Name { get; set; }
        [Column("overview")]
        public string? Overview { get; set; }
        [Column("release_date")]
        public DateTime ReleaseDate { get; set; }
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [Column("software_house_id")]
        public long SoftwareHouseId { get; set; }
        public SoftwareHouse? SoftwareHouse { get; set; }

        public override string ToString()
        {
            var nl = Environment.NewLine;
            return $"ID: {Id + nl}Nome: {Name + nl}Trama: {Overview + nl}Data di uscita: {ReleaseDate + nl}";
        }
    }
}
