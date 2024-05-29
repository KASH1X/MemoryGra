using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGra
{
    internal class KartaMemory : Label
    {
        public Image Tyl;
        public Image Obrazek;
        public Guid Id;

        public KartaMemory(Guid id, string nazwaTyl, string nazwaObrazek)
        {
            Id = id;
            Tyl = Image.FromFile(nazwaTyl);
            Obrazek = Image.FromFile(nazwaObrazek);
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void Zakryj()
        {
            BackgroundImage = Tyl;
            Enabled = true;
        }
        public void Odkryj()
        {
            BackgroundImage = Obrazek;
            Enabled = false;
        }
    }
}
