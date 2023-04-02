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
           
        }

        public void DeleteVideogame(Videogame videogame)
        {

        }
       
    }
}
