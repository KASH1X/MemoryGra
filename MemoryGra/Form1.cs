using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGra
{
    public partial class Form1 : Form
    {
        KartaMemory odkytaKarta1 = null;
        KartaMemory odkytaKarta2 = null;
        UstawieniaGry ustawienia;
        public Form1()
        {
            InitializeComponent();
            ustawienia = new UstawieniaGry();
            UstawKontrolki();
            GenerujKarty();
            timerCzasPodgladu.Start();
            
        }

        void UstawKontrolki()
        {
            czas.Text = ustawienia.CzasGry.ToString();
            punkty.Text = ustawienia.Punkty.ToString();
            startGry.Text = $"Poczatek gry za {ustawienia.CzasPodgladu}";

            panelKart.Width = ustawienia.Bok * ustawienia.Kolumny + ustawienia.Margines * (ustawienia.Kolumny - 1);
            panelKart.Height = ustawienia.Bok * ustawienia.Wiersze + ustawienia.Margines * (ustawienia.Wiersze - 1);

            Width = panelKart.Width + 50;
            Height = panelKart.Height + 150;
        }

        void GenerujKarty()
        {
            string[] obrazki = Directory.GetFiles(ustawienia.FolderObrazki);
            ustawienia.MaxPunkty = obrazki.Length;
            List<KartaMemory> listaKart = new List<KartaMemory>();

            foreach (string obrazek in obrazki)
            {
                Guid id = Guid.NewGuid();
                KartaMemory karta1 = new KartaMemory(id, ustawienia.PlikLogo, obrazek);
                KartaMemory karta2 = new KartaMemory(id, ustawienia.PlikLogo, obrazek);

                listaKart.Add(karta1);
                listaKart.Add(karta2);
                
            }

            Random random = new Random();
            panelKart.Controls.Clear();
            for(int y = 0; y < ustawienia.Wiersze; y++)
            {
                for(int x = 0; x < ustawienia.Kolumny; x++)
                {
                    int numer = random.Next(0,listaKart.Count);
                    KartaMemory karta = listaKart[numer];
                    karta.Location = new Point(x * (ustawienia.Bok + ustawienia.Margines), y * (ustawienia.Bok + ustawienia.Margines));

                    karta.Width = ustawienia.Bok;
                    karta.Height = ustawienia.Bok;

                    karta.Click += KartaKliknieta;

                    karta.Odkryj();
                    panelKart.Controls.Add(karta);
                    listaKart.Remove(karta);

                    
                }
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerCzasPodgladu_Tick(object sender, EventArgs e)
        {
            ustawienia.CzasPodgladu--;
            startGry.Text = $"Poczatek gry za {ustawienia.CzasPodgladu}";
            if(ustawienia.CzasPodgladu == 0)
            {
                timerCzasPodgladu.Stop();
                startGry.Visible = false;
                foreach (Control kontrolka in panelKart.Controls)
                {
                    KartaMemory kartaa = (KartaMemory)kontrolka;
                    kartaa.Zakryj();
                }
                timerCzasGry.Start();
            }
            
        }

        private void timerCzasGry_Tick(object sender, EventArgs e)
        {
            ustawienia.CzasGry--;
            czas.Text = ustawienia.CzasGry.ToString();

            if (ustawienia.Punkty == ustawienia.MaxPunkty)
            {
                timerCzasGry.Stop();
                timerZakrywacz.Stop();
                panelKart.Enabled = false;
                DialogResult odp = MessageBox.Show($"Punkty: {ustawienia.Punkty}. Czy chcesz zagrac ponownie?", "Koniec gry", MessageBoxButtons.YesNo);
                if (odp == DialogResult.Yes)
                {
                    ustawienia.UstawStartowe();
                    UstawKontrolki();
                    GenerujKarty();
                    timerCzasPodgladu.Start();

                    odkytaKarta1 = null;
                    odkytaKarta2 = null;
                    panelKart.Enabled = true;
                    startGry.Visible = true;

                }
                else
                {
                    Application.Exit();
                }
            }

            if (ustawienia.CzasGry == 0)
            {
                timerCzasGry.Stop();
                timerZakrywacz.Stop();

                DialogResult odp = MessageBox.Show($"Punkty: {ustawienia.Punkty}. Czy chcesz zagrac ponownie?", "Koniec gry", MessageBoxButtons.YesNo);
                if(odp == DialogResult.Yes)
                {
                    ustawienia.UstawStartowe();
                    UstawKontrolki();
                    GenerujKarty();
                    timerCzasPodgladu.Start();

                    odkytaKarta1 = null;
                    odkytaKarta2 = null;
                    panelKart.Enabled = true;
                    startGry.Visible = true;

                }
                else
                {
                    Application.Exit();
                }
            }
            
            
        }

        private void KartaKliknieta(object sender, EventArgs e)
        {
            KartaMemory karta = sender as KartaMemory;

            if(odkytaKarta1 == null)
            {
                odkytaKarta1 = karta;
                odkytaKarta1.Odkryj();
            }
            else
            {
                odkytaKarta2 = karta;
                odkytaKarta2.Odkryj();
                panelKart.Enabled = false;

                if(odkytaKarta1.Id == odkytaKarta2.Id)
                {
                    odkytaKarta2 = null;
                    odkytaKarta1 = null;
                    ustawienia.Punkty++;
                    punkty.Text = ustawienia.Punkty.ToString();
                    panelKart.Enabled = true;
                }
                else
                {
                    timerZakrywacz.Start();
                    
                }
            }
        }

        private void timerZakrywacz_Tick(object sender, EventArgs e)
        {
           
            odkytaKarta1.Zakryj();
            odkytaKarta2.Zakryj();
            odkytaKarta1 = null;
            odkytaKarta2 = null;
            panelKart.Enabled = true;
            timerZakrywacz.Stop();
        }
    }
}
