using System;


namespace OOP_obdelnik
{

    internal class Obdelnik
    {

        public double StranaA;
        public double StranaB;
     

        public Obdelnik(double a, double b)
        {
            StranaA = a;
            StranaB = b;
        }

        public string Info()
        {
            string jeCtverec = "neni";
            if (JeCtverec())
            {
                jeCtverec = "je";
            }

            return $"Strana A je {StranaA} a strana B je {StranaB} a {jeCtverec} to ctverec./n Obash je {Obsah()} a obvod je {Obvod()}.";
        }

        public double Obsah()
        {
            return StranaA* StranaB;
        }

        public double Obvod()
        {
            return (StranaA + StranaB) * 2;
        }
     
        public bool JeCtverec()
        {
            if (StranaA == StranaB)
            {
                return true;
            }
            return false;
        }

        public void ZvetsiStrany()
        {
            double a = 0;
            double b = 0;

            Console.WriteLine("O kolik zvetsit delku strany A");
            while (!(double.TryParse(Console.ReadLine(), out a)))
            {
                Console.WriteLine("To neni cislo..");
            }

            Console.WriteLine("O kolik zvetsit delku strany B");
            while (!(double.TryParse(Console.ReadLine(), out b)))
            {
                Console.WriteLine("To neni cislo..");
            }

            StranaA += a;
            StranaB += b;
        }
    }
}
