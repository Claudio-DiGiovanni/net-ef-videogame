using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame.models
{
    public record Videogame
    {
        public Videogame(long id, string name, string overview, string releaseDate, long softwareHouseId)
        {
            Id = id;
            Name = name;
            Overview = overview;
            ReleaseDate = Convert.ToDateTime(releaseDate);
            SoftwareHouseId = softwareHouseId;
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Overview { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long SoftwareHouseId { get; set; }
    }
}
