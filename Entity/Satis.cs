using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace BisarogluOtoGaleri.Entity
{
    public class Satis
    {
        // Veritabanındaki Primary Key
        public int SatisID { get; set; }
        public int ArabaID { get; set; }
        public int MusteriID { get; set; }
        public decimal GercekSatisFiyati { get; set; }
        public DateTime SatisTarihi { get; set; }

        [NotMapped]
        public string AracBilgi { get; set; }

        [NotMapped]
        public string MusteriAdSoyad { get; set; }
    }
}
