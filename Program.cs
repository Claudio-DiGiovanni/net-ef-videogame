using net_ef_videogame.models;
var videogameManager = new VideogameManager();

while (true)
{
    int opzione = 0;

    while (opzione is 0)
    {
        Console.WriteLine("Scegli una di queste opzioni:");
        Console.WriteLine("inserire un nuovo videogioco (1 o 'inserisci')");
        Console.WriteLine("ricercare un videogioco per id (2 o 'ricerca')");
        Console.WriteLine("ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input (3 o 'filtra')");
        Console.WriteLine("eliminare un videogioco (4 o 'elimina')");
        Console.WriteLine("aggiungere una software house (5 o 'aggiungi software house')");
        Console.WriteLine("chiudere il programma (6 o 'chiudi')");

        var input = Console.ReadLine();

        opzione = identificaOpzione(input);
    }

    switch (opzione)
    {
        case 1:
            {
                Console.Write("Passa il nome: ");
                var name = Console.ReadLine() ?? "";

                Console.Write("Passa l'overview: ");
                var overview = Console.ReadLine() ?? "";

                Console.Write("Passa la release date (yyyy-MM-dd): ");
                var releaseDate = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Passa l'id della software house: ");
                var softwareHouseId = Convert.ToInt64(Console.ReadLine());
                var vg = new Videogame();
                vg.Name = name;
                vg.Overview = overview;
                vg.ReleaseDate = releaseDate;
                vg.SoftwareHouseId = softwareHouseId;

                videogameManager.InsertVideogame(vg);
            }
            break;
        case 2:
            {
                Console.Write("Passa l'id: ");

                var id = Convert.ToInt64(Console.ReadLine());
                var vg = videogameManager.GetVideogameById(id);

                if (vg is null) Console.WriteLine("Videogame non trovato.");
                else Console.WriteLine(vg.ToString());
            }
            break;
        case 3:
            Console.WriteLine("Inserisci il nome o una parte del nome del videogame che stai cercando: ");
            var search = Console.ReadLine();
            var videogames = videogameManager.GetVideogames(search);
            foreach(var videogame in videogames)
            {
                Console.WriteLine(videogame.ToString());
            }
            break;
        case 4:
            {
                Console.Write("Passa l'id: ");

                var id = Convert.ToInt64(Console.ReadLine());
                videogameManager.DeleteVideogame(id);
            }
            break;
        case 5:
            {
                Console.Write("Passa il nome: ");
                var name = Console.ReadLine();
                Console.Write("Passa il tax id: ");
                var taxId = Convert.ToInt64(Console.ReadLine());
                Console.Write("Passa la città: ");
                var city = Console.ReadLine();
                Console.Write("Passa lo stato: ");
                var country = Console.ReadLine();
                var softwareHouse = new SoftwareHouse();
                softwareHouse.Name = name;
                softwareHouse.TaxId = taxId;
                softwareHouse.City = city;
                softwareHouse.Country = country;
                videogameManager.InsertSoftwareHouse(softwareHouse);

                break;
            }
        case 6:
            Console.WriteLine("Esco.");
            return;
    }
}

int identificaOpzione(string? input)
{
    switch (input)
    {
        case "1":
        case "inserisci":
            return 1;
        case "2":
        case "ricerca":
            return 2;
        case "3":
        case "filtra":
            return 3;
        case "4":
        case "elimina":
            return 4;
        case "5":
        case "aggiungi software house":
            return 5;
        case "6":
        case "chiudi":
            return 6;
        default:
            Console.WriteLine("Input non valido.");
            return 0;
    }
}