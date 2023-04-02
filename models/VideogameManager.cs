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
        string connectionString;

        public VideogameManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Videogame? GetVideogameById(long idDaCercare)
        {
            using var context = new VideogameContext();
            return context.Videogames.FirstOrDefault(v => v.Id == idDaCercare);
        }

        public void InsertVideogame(Videogame videogame)
        {
            using var connection = new SqlConnection(connectionString);
            //using var tran = connection.BeginTransaction();
            try
            {
                connection.Open();
                var query = $"INSERT INTO videogames (name, overview, release_date, software_house_id) VALUES ({videogame.Name},{videogame.Overview},{videogame.ReleaseDate},{videogame.SoftwareHouseId})";
                using var cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
               // tran.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
               // tran.Rollback();
            }
        }

        public void DeleteVideogame(Videogame videogame)
        {

        }
        private SqlCommand GetCommand(string query)
        {
            var connection = new SqlConnection(connectionString);
            return new SqlCommand(query, connection);
        }
    }
}
