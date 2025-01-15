using ClassLibrary.Data;
using ClassLibrary.Models;

Adatbazis db = new Adatbazis();

if (!db.Huzas.Any())
{
    string[] sorok = File.ReadAllLines(@"F:\Fajlok\AngularCuccok\Dolgozat\Forrasok\VikingLottoSzamok.csv");

	foreach (var sor in sorok)
	{
		Huzas huzas = new Huzas();
		Boolean oks = true;
		try {
			huzas = new Huzas(sor);
		}
		catch {
			Console.WriteLine("Hibás sor: "+ sor);
			oks = false;
		}
		if (oks) { 
			db.Huzas.Add(huzas);
		}

	}

	db.SaveChanges();

	foreach (var item in db.Huzas)
	{
		Console.WriteLine(item);
	}
}

//HashSet<Huzas> JoSzamok = new HashSet<Huzas>();
//if (!db.Huzas.Any())
//{
//    string[] sorok = File.ReadAllLines(@"C:\Users\Bea\Documents\Külker\Asztali alkalmazások\lotto5\adat\VikingLottoSzamok.csv");

//    foreach (var sor in sorok)
//    {
//        Huzas huzas = new Huzas();
//        Boolean oks = true;
//        try
//        {
//            huzas = new Huzas(sor);
//        }
//        catch
//        {
//            Console.WriteLine("Hibás sor: " + sor);
//            oks = false;
//        }
//        if (oks)
//        {
//            JoSzamok.Add(huzas);
//        }
//        //Console.WriteLine(sor);
//    }
//    foreach (var szam in JoSzamok)
//    {
//        Console.WriteLine(szam);
//    }
//}