using net_ef_videogame.models;
using System.Data.SqlClient;

var connectionString = "Data Source=localhost;Initial Catalog=videogame-db;Integrated Security=True";
var videogameManager = new VideogameManager(connectionString);
var videogame = new Videogame(501,"cacca","ciao", "10/07/1997", 5);

var idDaCercare = Convert.ToInt64(Console.ReadLine());
var videogame2 = videogameManager.GetVideogameById(idDaCercare);


Console.WriteLine();
Console.WriteLine(videogame2.Name);
Console.WriteLine(videogame2.Overview);
Console.WriteLine(videogame2.ReleaseDate);


