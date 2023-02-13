using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikacijaZaBiblioteku
{
    internal class Korisnik
    {
        string mail, ime, prezime, adresa;
        int brojTelefona;

        public Korisnik(string mail, string ime, string prezime, string adresa, int brojTelefona)
        {
            this.mail = mail;
            this.ime = ime;
            this.prezime = prezime;
            this.adresa = adresa;
            this.brojTelefona = brojTelefona;
        }

        public string Mail { get => mail; set => mail = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public int BrojTelefona { get => brojTelefona; set => brojTelefona = value; }

        public override string ToString()
        {
            return "E-mail: " + Mail + "\r\nIme: " + Ime + "\r\nPrezime:" + Prezime + "\r\nAdresa:" + Adresa + "\r\nBroj telefona: " + brojTelefona;
        }
    }
}
