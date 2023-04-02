using net_ef_videogame.models;
using var context = new VideogameContext();
var videogameManager = new VideogameManager();

var idDaCercare = Convert.ToInt64(Console.ReadLine());
var videogame2 = context.Videogames.FirstOrDefault(v => v.Id == idDaCercare);


Console.WriteLine();
Console.WriteLine(videogame2);



