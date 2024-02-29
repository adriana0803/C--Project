using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectVanzari
{
    public class Tranzactii
    {
        public DateTime data_tranzactie;
        public double suma_total;
        public Clienti client;

        public void calculSumaTotala()
        {
            foreach (Produse p in client.produse)
            {
                this.suma_total += p.Pret;
            }
        }

        public Tranzactii(Clienti c)
        {
            client = c;
            suma_total = 0;
            this.calculSumaTotala();
            data_tranzactie = DateTime.Now;
        }

        public DateTime Data_Tranzactie
        {
            get => data_tranzactie;
            set => data_tranzactie = value;
        }

        public double Suma_Total
        {
            get => suma_total;
            set => suma_total = value;
        }

        public Clienti Client
        {
            get => client;
            set => client = value;
        }

    }
}
