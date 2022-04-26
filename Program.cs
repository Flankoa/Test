using System;

namespace ConsoleApp28
{

    class Racun
    {
        private string brojracuna;
        private double stanje;

        public void Uplata(double iznos)
        {
            stanje = stanje + iznos;
        }

        public string Brojracuna
        {
            get
            {
                return brojracuna;
            }
            set
            {
                brojracuna = value;
            }
        }

        public double Stanje
        {
            get
            {
                return stanje;
            }
            set
            {
                stanje = value;
            }
        }

        public Racun(double promo_iznos)
        {
            stanje = promo_iznos;
        }
        static void Main(string[] args)
        {
            double u;
            Racun mojracun = new Racun(2000);
            Console.WriteLine("Broj racuna:{0} \t Stanje je:{1} \t", mojracun.Brojracuna, mojracun.Stanje);
            Console.WriteLine("Unesite jmbg:");
            mojracun.Brojracuna = Console.ReadLine();
            Console.WriteLine("Upisite iznos uplate:");
            u = Convert.ToDouble(Console.ReadLine());
            mojracun.Uplata(u);
            Console.WriteLine("Broj racuna:{0} \t Stanje je:{1} \t", mojracun.Brojracuna, mojracun.Stanje);
            Console.ReadKey();
        }
    } 