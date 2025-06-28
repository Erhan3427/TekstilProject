using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstile.Entities.Data
{
    public class MaasOdeme
    {
        public int Id { get; set; }
        public int CalisanId { get; set; }
        public decimal Tutar { get; set; }
        public DateTime OdemeTarihi { get; set; }

        public Calisan Calisan { get; set; } = null!;
    }

}
