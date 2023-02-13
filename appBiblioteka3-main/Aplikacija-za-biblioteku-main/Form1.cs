using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacijaZaBiblioteku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKorisnik_Click(object sender, EventArgs e)
        {
            UnosKorisnika korisnik = new UnosKorisnika();
            korisnik.Show();
        }

        private void buttonKnjiga_Click(object sender, EventArgs e)
        {
            UnosKnjiga knjiga = new UnosKnjiga();
            knjiga.Show();
        }

        private void buttonPregledPodataka_Click(object sender, EventArgs e)
        {
            pregledPodataka podatci = new pregledPodataka();
            podatci.Show();
        }

        private void btnPosudiVrati_Click(object sender, EventArgs e)
        {
            posudiVrati posvrat = new posudiVrati();
            posvrat.Show();
        }
    }   
}
