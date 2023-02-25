using OOP_obdelnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_obdelnik
{
    // Zkouska interakce s uzivatelem z class
    public class Trojuhelnik
    {
        public double StranaA;
        public double StranaB;
        public double StranaC;
        public double Vyska;
        public double UhelA;
        public double UhelB;
        public double UhelC;
        public double RadUhelA;
        public double RadUhelB;
        public double RadUhelC;
        public double SinUhelA;
        public double SinUhelB;
        public double SinUhelC;
        public double CosUhelC;
        public double CosUhelB;
        public string Input1;


        public string Info() 
        {
            return $"Trojuhelnik \n Strana a: {StranaA} m, strana b: {StranaB} m, strana c: {StranaC} m. \n Obvod: {Obvod()} m Obsah: {Obsah()} m2";
        }

        private void ConsoleInputs()
        {
            Console.WriteLine("Vybral jsi Trojuhelnik. Trojuhelnik je definovan: \n1) 3 stranami \n2) 2 stramami a uhlem \n3) 1 stranou a 2 uhly \nJak jej chces definovat? (1/2/3) ");
            Input1 = Console.ReadLine();
            while ((Input1 != "1") && (Input1 != "2") && (Input1 != "3"))
            {
                Console.WriteLine("Nerozumim, zadej ještě jednou");
                Input1 = Console.ReadLine();
            }

            if (Input1 == "1")
            {
                Console.WriteLine("Zadej delku strany A v metrech:");
                while (!(double.TryParse(Console.ReadLine(), out StranaA)))
                {
                    Console.WriteLine("To neni cislo..");
                }
                Console.WriteLine("Zadej delku strany B v metrech:");
                while (!(double.TryParse(Console.ReadLine(), out StranaB)))
                {
                    Console.WriteLine("To neni cislo..");
                }
                Console.WriteLine("Zadej delku strany C v metrech:");
                while (!(double.TryParse(Console.ReadLine(), out StranaC)))
                {
                    Console.WriteLine("To neni cislo..");
                }
            }
            else if (Input1 == "2")
            {
                Console.WriteLine("Zadej delku strany A v metrech:");
                while (!(double.TryParse(Console.ReadLine(), out StranaA)))
                {
                    Console.WriteLine("To neni cislo..");
                }
                Console.WriteLine("Zadej delku strany B v metrech:");
                while (!(double.TryParse(Console.ReadLine(), out StranaB)))
                {
                    Console.WriteLine("To neni cislo..");
                }
                Console.WriteLine("Zadej velikost uhlu Gama ve stupnich:");
                while (!(double.TryParse(Console.ReadLine(), out UhelC)))
                {
                    Console.WriteLine("To neni cislo..");
                }
            }
            else if (Input1 == "3")
            {
                Console.WriteLine("Zadej delku strany A v metrech:");
                while (!(double.TryParse(Console.ReadLine(), out StranaA)))
                {
                    Console.WriteLine("To neni cislo..");
                }
                Console.WriteLine("Zadej velikost uhlu Beta ve stupnich:");
                while (!(double.TryParse(Console.ReadLine(), out UhelB)))
                {
                    Console.WriteLine("To neni cislo..");
                }
                Console.WriteLine("Zadej velikost uhlu Gama ve stupnich:");
                while (!(double.TryParse(Console.ReadLine(), out UhelC)))
                {
                    Console.WriteLine("To neni cislo..");
                }
            }

        }

        public void Vypocet() //Matematicky chybne vypocty uhlu.
        {
            ConsoleInputs();

            if (Input1 == "1")
            {
                CosUhelC = ((StranaA * StranaA) + (StranaB * StranaB) - (StranaC * StranaC)) / (2 * StranaA * StranaB);
                UhelC = CosUhelC;
                //UhelC = 180 * RadUhelC / Math.PI;
                CosUhelB = ((StranaA * StranaA) + (StranaC * StranaC) - (StranaB * StranaB)) / (2 * StranaA * StranaC);
                RadUhelB = 1/Math.Sin(CosUhelB);
                UhelB = 180 * RadUhelB / Math.PI;

                UhelA = 180 - UhelB - UhelC;

            }
            else if (Input1 == "2")
            {
                RadUhelC = Math.PI * UhelC / 180;
                CosUhelC= Math.Cos(RadUhelC);
                SinUhelC = Math.Sin(UhelC);

                StranaC = Math.Sqrt((StranaA*StranaA)+(StranaB*StranaB)-(2*StranaA*StranaB*CosUhelC));

                SinUhelA = SinUhelC * StranaA * StranaC;
                RadUhelA = Math.Cos(SinUhelA);
                UhelA = 180 * RadUhelA / Math.PI;
 
                UhelB = 180 - UhelC - UhelA;

            }
            else if (Input1 == "3")
            {
                UhelA = 180 - UhelC - UhelB;
                RadUhelC = Math.PI * UhelC / 180;
                RadUhelA = Math.PI * UhelA / 180;
                RadUhelB = Math.PI * UhelB / 180;
                SinUhelA = Math.Sin(UhelA);
                SinUhelB = Math.Sin(UhelB);
                SinUhelC = Math.Sin(UhelC);

                StranaB = StranaA * Math.Abs(SinUhelB / SinUhelC);
                StranaC = StranaA * Math.Abs(SinUhelC / SinUhelA);

            }
        }

        public double Obvod()
        {
            return StranaA + StranaB + StranaC;
        }

        public double Obsah()
        {
            double pulObvod = Obvod() / 2;
            return Math.Sqrt(pulObvod * (pulObvod-StranaA) * (pulObvod - StranaB) * (pulObvod - StranaC));
        }

    }
}
