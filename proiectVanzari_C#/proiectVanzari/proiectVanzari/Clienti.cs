using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectVanzari
{
    public class Clienti
    {
        public string nume;
        public string prenume;
        public string telefon;
        public string email;
        public BindingList<Produse> produse;


        public string Nume { get=>nume; set=>nume = value;
        }
        public string Prenume
        {
            get => prenume; set => prenume = value;
        }
        public string Telefon
        {
            get => telefon; set => telefon = value;
        }
        public string Email
        {
            get => email; set => email = value;
        }

        public BindingList<Produse> Produse
        {
            get => produse;
            set => produse = value;
        }

        public Clienti()
        {
            produse = new BindingList<Produse>();
        }

        public Clienti(string nume, string prenume, string telefon, string email, BindingList<Produse> produse)
        {
            Nume = nume;
            Prenume = prenume;
            Telefon = telefon;
            Email = email;
            this.produse = produse;
        }


    }
}
