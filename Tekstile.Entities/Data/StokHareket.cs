using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstile.Entities.Data;


   
        public class StokHareket
        {
            public int Id { get; set; }
            public int BoyaId { get; set; }
            public Boyalar Boya { get; set; }
            public DateTime IslemTarihi { get; set; }
            public string IslemTuru { get; set; } // Gelen, Açılan, Biten
            public int Adet { get; set; }
            public string? Aciklama { get; set; }
        }

    

