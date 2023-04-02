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
    [Index(nameof(Id))]
    public class Videogame
    {

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Overview { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long SoftwareHouseId { get; set; }
        public SoftwareHouse? SoftwareHouse { get; set; }
    }
}
