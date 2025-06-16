using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstile.Entities.Data
{
    public class Giderler
    {
        [Key]
        public int Id { get; set; }

       
        public DateTime Tarih { get; set; }

    
        public string GiderTuru { get; set; }

      
        public string Aciklama { get; set; }

     
        public decimal Tutar { get; set; }
    }
} 