using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_obdelnik
{
    internal class Kruh
    {
        public double Polomer;
        public double Prumer;
        public const double PI = 3.1415926535897931;
        public double Uhel;

        public Kruh(bool rd, double cislo, double uhel) 
        {
            Uhel = uhel;

            if (rd==true) 
            { 
                Polomer= cislo;
                Prumer = 2*cislo;
            }
            else
            {
                Prumer= cislo;
                Polomer= cislo/2;
            }
        }

        public string Info()
        {
            return $"Kruh o polomeru {Polomer} m ma obvod {ObvodKruh()} m a obsah {ObsahKruh()} m2.";
        }

        public string InfoVysec()
        {
            return $"Kruhova vysec o polomeru {Polomer} m a uhlu {Uhel} ma delku oblouku {DelkaOblouku()} m, obvod {ObvodVysec()} m a obsah {ObsahVysec()} m2.";
        }

        public double ObvodKruh()
        {
            return 2*PI*Polomer;
        }

        public double ObsahKruh ()
        {
            return PI*Polomer*Polomer;
        }

        public double DelkaOblouku()
        {
            return ((PI / 180) * Uhel * Polomer);
        }

        public double ObvodVysec()
        {
            // o = (rad + 2) * r
            return (((PI/180)*Uhel)+2)*Polomer;
        }

        public double ObsahVysec()
        {
            // S = rad*r2 / 2 + uprava zlomku
            return (((PI / 360) * Uhel) * Polomer*Polomer);
        }
    }
}
