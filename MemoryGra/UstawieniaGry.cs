using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGra
{
    internal class UstawieniaGry
    {
        public int CzasGry;
        public int CzasPodgladu;

        public int Punkty;
        public int MaxPunkty;

        public int Wiersze;
        public int Kolumny;
        public int Bok;
        public int Margines;

        public string PlikLogo = $@"{AppDomain.CurrentDomain.BaseDirectory}\obrazki\logo.jpg";
        public string FolderObrazki = $@"{AppDomain.CurrentDomain.BaseDirectory}\obrazki\memory";

        public UstawieniaGry()
        {
            UstawStartowe();
        }

        public void UstawStartowe()
        {
            CzasGry = 60;
            CzasPodgladu = 5;
            Punkty = 0;
            MaxPunkty = 0;
            Wiersze = 4;
            Kolumny = 6;
            Bok = 150;
            Margines = 2;
        }
        
    }
}
