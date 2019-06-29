using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelGry;
using static ModelGry.Gra;

namespace GraGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Gra g;
        private Stopwatch stoper = new Stopwatch();
        private double punkty { get; set; }
      
        private void buttonNowaGra_Click(object sender, EventArgs e)
        {
            if (g != null)
            {
                stoper.Reset();
                punkty = 0;
                textBoxOd.Text = "";
                textBoxDo.Text = "";
                PropozycjaBox.Text = "";
                groupBoxLosuj.Enabled = true;
            }
            else
            {
                groupBoxLosuj.Visible = true;
                buttonNowaGra.Enabled = false;
            }
        }

        private void buttonLosuj_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;

            // wczytaj zakres do losowania
            if (!Int32.TryParse(textBoxOd.Text, out a) || !Int32.TryParse(textBoxDo.Text, out b))
            {
                MessageBox.Show("Można wpisywać tylko liczby całkowite!");
                return;
            }

            // sprawdz czy wartosc b(TextBoxDo) nie jest wieksza niz a(TextBoxOd), jezeli tak zamienia
            if (b < a)
            {
                int temp = 0;
                temp = a;
                a = b;
                b = temp;
                textBoxOd.Text = a.ToString();
                textBoxDo.Text = b.ToString();
            }

            // utwórz grę
            g = new Gra(a, b);

            // przydzielenie 20 punktów startowych
            punkty = 20;
            MessageBox.Show("Otrzymałeś 20 punktów. Każde nie trafienie odejmuje 0,5 punkta. Jeżeli Twoje punkty spadną do 0, przegrywasz.");

            // wyświetl/ukryj kolejne elementy formularza
            odgadywaniebox.Visible = true;
            wylosowanalabel.Visible = true;
            odgadywaniebox.Enabled = true;
            stoper.Start();
            timer1.Enabled = true;
            groupBoxLosuj.Enabled = false;
            buttonNowaGra.Enabled = false;
            buttonhistoria.Visible = true;

        }

        private void sprbutton_Click(object sender, EventArgs e)
        {
            int num;

            if (!Int32.TryParse(PropozycjaBox.Text, out num))
            {
                MessageBox.Show("Można wpisywać tylko liczby całkowite!");
                return;
            }

            Odpowiedz sprawdz = g.Ocena(num);
            
            switch (sprawdz)
            {
                case Gra.Odpowiedz.ZaMalo:
                    if (!OdejmijPunkty())
                        break;
                    MessageBox.Show("Za mało. Odjęto 0.5 punkta(Pozostało " + punkty + " punktów). " + "Próba nr: " + g.LicznikRuchow);
                    break;
                case Gra.Odpowiedz.Trafiono:
                    KoniecGry();
                    MessageBox.Show("Trafiłeś! Za " + g.LicznikRuchow + " razem. Zachowałeś " + punkty + " punktów");
                    break;
                case Gra.Odpowiedz.ZaDuzo:
                    if (!OdejmijPunkty())
                        break;
                    MessageBox.Show("Za dużo. Odjęto 0.5 punkta(Pozostało " + punkty + " punktów). " + "Próba nr: " + g.LicznikRuchow);
                    break;
                default:
                    break;
            }
        }

        // przycisk - poddaj się
        private void buttonpoddaj(object sender, EventArgs e)
        {
            g.Poddaj();
            stoper.Stop();
            int a = g.LicznikRuchow;
            a += 1;
            MessageBox.Show("Poddałeś się za " + a + " razem. Liczba to " + g.Wylosowana);
            KoniecGry();
        }

        // przycisk historia
        private void buttonhistoria_Click(object sender, EventArgs e)
        {
            Form f2 = new Historia(g);
            f2.Show();
        }

        // timer (działa na nim stoper)
        private void timer1_Tick(object sender, EventArgs e)
        {
            czaslabel.Text = string.Format("{0:00}:{1:00}:{2:00}", stoper.Elapsed.Hours, stoper.Elapsed.Minutes, stoper.Elapsed.Seconds);
        }

        //Odejmowanie punktów
        private bool OdejmijPunkty()
        {
            punkty -= 0.5;

            if (punkty <= 0)
            {
                g.Poddaj();
                MessageBox.Show("Przegrałeś! Twoje punkty spadły do 0");
                KoniecGry();
                return false;
            }
            return true;
        }

        //Koniec Gry
        private void KoniecGry()
        {
            stoper.Stop();
            odgadywaniebox.Enabled = false;
            wylosowanalabel.Visible = false;
            buttonNowaGra.Enabled = true;
        }
    }
}
