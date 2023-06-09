﻿using net_ef_videogame.models;
var videogameManager = new VideogameManager();

while (true)
{
    int opzione = 0;

    while (opzione is 0)
    {
        menu();

        var input = Console.ReadLine();

        opzione = identificaOpzione(input);
    }

    switch (opzione)
    {
        case 1:
            {
                nuovoGioco();
            }
            break;
        case 2:
            {
                cercaGioco();
            }
            break;
        case 3:
            {
                cercaListaGiochi();
            }
            break;
        case 4:
            {
                cancellaGioco();
            }
            break;
        case 5:
            {
                creaSoftwareHouse();
            }
                break;
        case 6:
            {
                cercaPerSoftwareHouseId();
            }
                break;
        case 7:
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
        case "cerca per software house":
            return 6;
        case "7":
        case "chiudi":
            return 7;
        default:
            Console.WriteLine("Input non valido.");
            return 0;
    }
}
void nuovoGioco()
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
void cercaGioco()
{
    Console.Write("Passa l'id: ");

    var id = Convert.ToInt64(Console.ReadLine());
    var vg = videogameManager.GetVideogameById(id);

    if (vg is null) Console.WriteLine("Videogame non trovato.");
    else Console.WriteLine(vg.ToString());
}

void cercaListaGiochi()
{
    Console.WriteLine("Inserisci il nome o una parte del nome del videogame che stai cercando: ");
    var search = Console.ReadLine();
    var videogames = videogameManager.GetVideogames(search);
    foreach (var videogame in videogames)
    {
        Console.WriteLine(videogame.ToString());
    }
}

void cancellaGioco()
{
    Console.Write("Passa l'id: ");

    var id = Convert.ToInt64(Console.ReadLine());
    videogameManager.DeleteVideogame(id);
}

void creaSoftwareHouse()
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
}

void cercaPerSoftwareHouseId()
{
    Console.Write("Passa l'id della software house: ");

    var id = Convert.ToInt64(Console.ReadLine());
    var vg = videogameManager.GetVideogamesBySoftwareHouseId(id);

    if (vg is null) Console.WriteLine("software house non trovata.");
    else
    {
        foreach (var v in vg)
        {
            Console.WriteLine(v.ToString());
        }
    };
}

void menu()
{
    Console.WriteLine("Scegli una di queste opzioni:");
    Console.WriteLine("inserire un nuovo videogioco (1 o 'inserisci')");
    Console.WriteLine("ricercare un videogioco per id (2 o 'ricerca')");
    Console.WriteLine("ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input (3 o 'filtra')");
    Console.WriteLine("eliminare un videogioco (4 o 'elimina')");
    Console.WriteLine("aggiungere una software house (5 o 'aggiungi software house')");
    Console.WriteLine("ricercare tutti i giochi prodotti da una software house (6 o 'cerca per software house')");
    Console.WriteLine("chiudere il programma (7 o 'chiudi')");
}