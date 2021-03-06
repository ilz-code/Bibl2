
using Biblio.Data;
using Biblio.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblio.Data
{
    public class DataToAdd
    {
        public DbContext context;
        public DataToAdd(Bibl2DbContext Context)
        {
            context = Context;
        }
        public static void AutorsData(Bibl2DbContext context)
    {
        var aut = new Autors[]
        {
            new Autors { Vards = "Aleksandrs Grīns" },
            new Autors { Vards = "A. Dž. Kronins" },
            new Autors { Vards = "Žils Verns" },
            new Autors { Vards = "Franss G. Bengtsons" },
            
        };

        foreach (Autors a in aut)
        {
            context.Autors.Add(a);
        }

        context.SaveChanges();
    }

    public static void GramatasData(Bibl2DbContext context)
    {
        var gramata = new Gramata[]
        {
            new Gramata { AutoraId = 1, Gads = 1942, Nosaukums = "Zemes atjaunotāji", Lpp = 443 },
            new Gramata { AutoraId = 2, Gads = 1969, Nosaukums = "Jaunības gadi", Lpp = 580 },
            new Gramata { AutoraId = 2, Gads = 1966, Nosaukums = "Cepurnieka pils", Lpp = 400 },
            new Gramata { AutoraId = 3, Gads = 1978, Nosaukums = "Noslēpumu sala", Lpp = 555 },
            new Gramata { AutoraId = 4, Gads = 1991, Nosaukums = "Sarkanais pūķis", Lpp = 458 },
            new Gramata { AutoraId = 5, Gads = 1974, Nosaukums = "Mēness akmens", Lpp = 523 },
            new Gramata { AutoraId = 6, Gads = 1967, Nosaukums = "Montesumas meita", Lpp = 339 },
            new Gramata { AutoraId = 7, Gads = 1989, Nosaukums = "Marakota bezdibenis", Lpp = 346 },
            new Gramata { AutoraId = 8, Gads = 2014, Nosaukums = "Šāntarāms", Lpp = 943 },
            new Gramata { AutoraId = 7, Gads = 1966, Nosaukums = "Etīde purpura toņos", Lpp = 400 },
            new Gramata { AutoraId = 9, Gads = 2013, Nosaukums = "Citādie", Lpp = 412 },
            new Gramata { AutoraId = 10, Gads = 2007, Nosaukums = "Madonnas saraksts", Lpp = 429 },
            new Gramata { AutoraId = 11, Gads = 2010, Nosaukums = "Tanatonauti", Lpp = 637 },
            new Gramata { AutoraId = 12, Gads = 2008, Nosaukums = "Fināla teorija", Lpp = 430 }
        };
        foreach (Gramata g in gramata)
        {
            context.Gramatas.Add(g);
        }

        context.SaveChanges();
    }
    }
}
