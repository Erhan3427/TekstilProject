using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstile.Entities.Data
{
    public class Calisan
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; } = null!;
        public string Departman { get; set; } = null!;
        public decimal Maas { get; set; }
        public bool AktifMi { get; set; } = true;

        public ICollection<MaasOdeme> MaasOdemeleri { get; set; } 
    }

}
