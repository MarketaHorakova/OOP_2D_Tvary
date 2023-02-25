using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// vytvoř třídu obdélník
// ve třídě vytvoř konstruktor, kde parametry budou délky stran (double, double)
// vytvoř ve třídě tyto metody:
//		- string Info() pro získání informací o obdélníku, bude vracet string vhodně formátovaný např.: strana A: 5, strana B: 7
//		- bool JeCtverec() pro zjištění, zda jde o čtverec, podle rovnosti stran vrátí bool
//		- void ZvetsiStrany(double, double) pro zvětšení obou stran
// pouzij konstruktor i metody vhodně v Main.

//Na základě úkolu pro breakout room, který byl v lekci, zkus:
//1) přidat třídě obdélník metody pro výpočet obvodu a obsahu
//2) zkus vytvořit obdobné třídy s obdobnými metodami pro jiné tvary jako trojuhelnik, kruh apod (zde asi nebude metoda JeCtverec :) ). Případně můžeš obdobu udělat
//i pro tělesa jako krychle, kvádr atd. a zde mít i metodu pro výpočet objemu.
//3) zkus udělat dobrý způsob využití pro uživatele, aby mohl si vybrat z tvarů/těles, zadat potřebné údaje a vybrat co chce vypočítat.


namespace OOP_obdelnik
{

         
        internal class Program
    {
        static void Main(string[] args)
        {
            string userTextInput = "n/a";
            double userInput1 = 0;
            double userInput2 = 0;
            //double userInput3 = 0;
            //double userInput4 = 0;
            Console.WriteLine("Ahoj, umim pocitat 2d tvary, který bys chtěl spočítat?");
            Console.WriteLine("Kruh (0), Kruhova vysec (0a), Trojuhelnik (3), Obdelnik (4), Pravidelny mohouhelnik (5).");
                switch (Console.ReadLine())
                {
                    case "0": 
                        Console.WriteLine("Vybral jsi kruh. Kruh je definovan polomerem r nebo prumerem d. Podle ceho chces pocitat (r/d)?");
                        userTextInput = Console.ReadLine();

                        while ((userTextInput != "r" ) && (userTextInput != "R") && (userTextInput != "d") && (userTextInput != "D"))
                            {
                                Console.WriteLine("Nerozumim, zadej ještě jednou");
                                userTextInput = Console.ReadLine();
                            }

                        Console.WriteLine("A hodnota v metrech:");

                        while (!(double.TryParse(Console.ReadLine(), out userInput1)))
                        {
                            Console.WriteLine("To neni cislo..");
                        }

                        if ((userTextInput == "r") || (userTextInput == "R"))
                        {
                            Kruh tvar2 = new Kruh(true, userInput1, 360);
                            Console.WriteLine(tvar2.Info());
                        }
                        else if ((userTextInput == "d") || (userTextInput == "D"))
                        {
                            Kruh tvar2 = new Kruh(false, userInput1, 360);
                            Console.WriteLine(tvar2.Info());
                        }
                                                
                        Console.ReadLine();
                        
                        break;
                    case "0a": 
                        Console.WriteLine("Vybral jsi kruhovou vysec. \nKruhova vysec je definovana polomerem r ci prumerem d a uhlem. Podle ceho chces pocitat (r/d)?)");
                        userTextInput = Console.ReadLine();

                        while ((userTextInput != "r") && (userTextInput != "R") && (userTextInput != "d") && (userTextInput != "D"))
                        {
                            Console.WriteLine("Nerozumim, zadej ještě jednou");
                            userTextInput = Console.ReadLine();
                        }

                        Console.WriteLine("Hodnota v metrech:");
                        while (!(double.TryParse(Console.ReadLine(), out userInput1)))
                        {
                            Console.WriteLine("To neni cislo..");
                        }

                        Console.WriteLine("Uhel vysece ve stupnich:");
                        while (!(double.TryParse(Console.ReadLine(), out userInput2)))
                        {
                            Console.WriteLine("To neni cislo..");
                        }

                    if ((userTextInput == "r") || (userTextInput == "R"))
                        {
                            Kruh tvar2 = new Kruh(true, userInput1, userInput2);
                            Console.WriteLine(tvar2.InfoVysec());
                        }
                        else if ((userTextInput == "d") || (userTextInput == "D"))
                        {
                            Kruh tvar2 = new Kruh(false, userInput1, userInput2);
                            Console.WriteLine(tvar2.InfoVysec());
                        }

                        Console.ReadLine();

                    break;
                    case "1":
                        Console.WriteLine("Bod ti pocitat nebudu..");
                        break;
                    case "2":
                        Console.WriteLine("Primka");
                        break;
                    case "3":
                        Console.WriteLine("Trojuhelnik");
                        Trojuhelnik tvar3 = new Trojuhelnik();
                        tvar3.Vypocet();
                        Console.WriteLine(tvar3.Info());
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Vybral jsi Obdelnik.");

                        Console.WriteLine("Napis delku strany A");
                        while (!(double.TryParse(Console.ReadLine(), out userInput1)))
                        {
                            Console.WriteLine("To neni cislo..");
                        }

                        Console.WriteLine("Napis delku strany B");
                        while (!(double.TryParse(Console.ReadLine(), out userInput2)))
                        {
                            Console.WriteLine("To neni cislo..");
                        }

                        Obdelnik tvar1 = new Obdelnik(userInput1, userInput2);
                        Console.WriteLine(tvar1.Info());

                        Console.ReadLine();

                        //tvar1.ZvetsiStrany();
                        //Console.WriteLine(tvar1.Info());
                        //Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("Mnohouhelnik neni naprogramovany.");
                        break;
                    default: 
                        Console.WriteLine("Nebylo na vyber");
                        Console.ReadLine();
                        break;
                }
          



        }
    }
}
