using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace aplikacijaZaBiblioteku
{
    public partial class UnosKorisnika : Form
    {
        List<Korisnik> korisnici = new List<Korisnik>();
        string dokument = "korisnik.xml";
        public UnosKorisnika()
        {
            InitializeComponent();
        }

        private void btnUnosPodatakaKorisnika_Click(object sender, EventArgs e)
        {
            Korisnik korisnik = new Korisnik(txtEmail.Text, txtIme.Text, txtPrezime.Text, txtAdresa.Text, Convert.ToInt32(txtBrojTelefona.Text));
            korisnici.Add(korisnik);

            DialogResult info = MessageBox.Show("Registracija korisnika uspiješna!", "Registracija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            if (info == DialogResult.OK)
            {
                if (File.Exists(dokument))
                {
                    var KorisniciXML = XDocument.Load(dokument);

                    foreach (Korisnik o in korisnici)
                    {
                        var Korisnik = new XElement("Korisnik",
                            new XElement("Mail", korisnik.Ime),
                            new XElement("Ime", korisnik.Ime),
                            new XElement("Prezime", korisnik.Prezime),
                            new XElement("Adresa", korisnik.Adresa),
                            new XElement("Broj telefona", korisnik.BrojTelefona));

                        KorisniciXML.Root.Add(Korisnik);
                    }
                    KorisniciXML.Save(dokument);
                }
                else
                {
                    var KorisniciXML = new XDocument();
                    KorisniciXML.Add(new XElement("Korisnik"));
                    foreach (Korisnik o in korisnici)
                    {
                        var Korisnik = new XElement("Korisnik",
                            new XElement("Mail", korisnik.Ime),
                            new XElement("Ime", korisnik.Ime),
                            new XElement("Prezime", korisnik.Prezime),
                            new XElement("Adresa", korisnik.Adresa),
                            new XElement("Broj telefona", korisnik.BrojTelefona));

                        KorisniciXML.Root.Add(Korisnik);
                    }
                    KorisniciXML.Save(dokument);
                }
                this.Close();
            }
        }
    }
}
