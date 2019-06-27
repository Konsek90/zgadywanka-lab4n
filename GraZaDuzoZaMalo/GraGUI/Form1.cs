using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;

namespace GraGUI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private Gra gra;

        private int od { get; set; } // wartosc textBoxZakresOd 
        private int doo { get; set; } // wartosc textBoxZakresDo

        // Poddaj się
        private void button1_Click(object sender, EventArgs e)
        {
            int num = gra.LicznikRuchow;
            num++;
            gra.Poddaj();
            MessageBox.Show("Poddałeś się za " + num + " razem! Liczba to: " + gra.Wylosowana);
            textBoxLiczba.Text = "";
            textBoxZakresDo.Text = "";
            textBoxZakresOd.Text = "";
            groupBoxWylosowano.Visible = false;
            groupBoxLosuj.Visible = false;
        }

        // Przycisk Nowa Gra
        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            if (gra != null)
            {
                if (gra.StanGry == Gra.State.Trwa)
                {
                    MessageBox.Show("Gra już trwa! Poddaj się lub odgadnij liczbę");
                    return;
                }
            }
            groupBoxLosuj.Visible = true;
        }

        // Losowanie liczby
        private void buttonLosuj_Click_1(object sender, EventArgs e)
        {
            if (gra != null)
            {
                if (gra.StanGry == Gra.State.Trwa)
                {
                    MessageBox.Show("Gra już trwa! Poddaj się lub odgadnij liczbę");
                    return;
                }
            }
            if (textBoxZakresOd.Text == "")
            {
                MessageBox.Show("Podaj Zakres od!");
                return;
            }
            if (textBoxZakresDo.Text == "")
            {
                MessageBox.Show("Podaj Zakres do!");
                return;
            }

            int numod;
            if (!Int32.TryParse(textBoxZakresOd.Text, out numod))
            {
                MessageBox.Show("Nieprawidłowa wartość: Zakres od. Można podawać tylko liczby całkowite.");
                return;
            }

            int numdo;
            if (!Int32.TryParse(textBoxZakresDo.Text, out numdo))
            {
                MessageBox.Show("Nieprawidłowa wartość: Zakres do. Można podawać tylko liczby całkowite.");
                return;
            }

            od = numod;
            doo = numdo;

            gra = new Gra(od, doo);
            MessageBox.Show("Wylosowano!");
            groupBoxWylosowano.Visible = true;
        }

        // Sprawdzenie liczby
        private void buttonSprawdz_Click(object sender, EventArgs e)
        {

            if (textBoxLiczba.Text == "")
            {
                MessageBox.Show("Podaj Liczbe!");
                return;
            }

            int num;

            if (!Int32.TryParse(textBoxLiczba.Text, out num))
            {
                MessageBox.Show("Nieprawidłowa wartość: Zakres od. Można podawać tylko liczby całkowite.");
                return;
            }

            if (num > doo || num < od)
            {
                MessageBox.Show("Wybrałeś już zakres od " + od + " do " + doo);
                return;
            }

            switch (gra.Ocena(num))
            {
                case Gra.Odp.ZaMalo:
                    MessageBox.Show("Za mało! To była próba nr: " + gra.LicznikRuchow);
                    break;
                case Gra.Odp.Trafiono:
                    MessageBox.Show("Trafiłeś za " + gra.LicznikRuchow + " razem!");
                    textBoxLiczba.Text = "";
                    textBoxZakresDo.Text = "";
                    textBoxZakresOd.Text = "";
                    groupBoxWylosowano.Visible = false;
                    groupBoxLosuj.Visible = false;
                    break;
                case Gra.Odp.ZaDuzo:
                    MessageBox.Show("Za dużo! To była próba nr: " + gra.LicznikRuchow);
                    break;
                default:
                    break;
            }
        }
    }
}
