using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectVanzari
{
    public class Produse
    {
        public string denumire;
        public double pret;
        public int cantitate;

        private readonly Dictionary<string, double> preturi = new Dictionary<string, double>()
        {
            {"Strawberry Cake", 125 },
            {"Tiramisu",67 },
            {"Ecler", 15},
            {"Black Forest Cake", 94},
            {"Savarina", 12}, 
            {"Cupcake",7}
        };

        public override string ToString()
        {
            return string.Format("Denumire: {0}, Pret: {1}, Cantitate: {2}", denumire, pret, cantitate) + " ; ";
        }

        public string Denumire
        {
            get => denumire;
            set => denumire = value;
        }

        public double Pret
        {
            get => pret;
            set => pret = value;
        }

        public int Cantitate
        {
            get => cantitate;
            set => cantitate = value;
        }

        public Produse()
        {

        }

        public Produse(string denumire, int cantitate)
        {
            Denumire = denumire;
            Cantitate = cantitate;

            Pret = preturi[Denumire] * cantitate;
        }


    }
}
