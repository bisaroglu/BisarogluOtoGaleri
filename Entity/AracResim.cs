using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisarogluOtoGaleri.Entity
{
    public class AracResim
    {
        public int ResimID { get; set; }
        public int ArabaID { get; set; } // Hangi arabaya ait? (Foreign Key)
        public string ResimYolu { get; set; } // Dosya adı (örn: guid.jpg)
    }
}
