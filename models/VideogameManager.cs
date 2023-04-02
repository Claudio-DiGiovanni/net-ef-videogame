using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static net_ef_videogame.models.Videogame;

namespace net_ef_videogame.models
{
    public class VideogameManager
    {

        public Videogame? GetVideogameById(long idDaCercare)
        {
            using var context = new VideogameContext();
            return context.Videogames.FirstOrDefault(v => v.Id == idDaCercare);
            
        }

        public void InsertVideogame(Videogame videogame)
        {
            using var context = new VideogameContext();
            context.Videogames.Add(videogame);
            context.SaveChanges();

        }

        public void DeleteVideogame(long id)
        {
            using var context = new VideogameContext();
            var videogame = context.Videogames.FirstOrDefault(v => v.Id == id);
            context.Videogames.Remove(videogame);
            context.SaveChanges();
        }

        public List<Videogame> GetVideogames(string input)
        {
            using var context = new VideogameContext();
            return context.Videogames.Where(v => v.Name.Contains(input)).ToList();
        }

        public void InsertSoftwareHouse(SoftwareHouse softwarehouse)
        {
            using var context = new VideogameContext();
            context.SoftwareHouses.Add(softwarehouse);
            context.SaveChanges();
        }

        public List<Videogame> GetVideogamesBySoftwareHouseId(long softwareHouseId)
        {
            using var context = new VideogameContext();
            return context.Videogames.Where(v => v.SoftwareHouseId == softwareHouseId).ToList();
        }
    }
}
