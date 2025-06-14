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

        [Required]
        public DateTime Tarih { get; set; }

        [Required]
        [StringLength(50)]
        public string GiderTuru { get; set; }

        [Required]
        [StringLength(500)]
        public string Aciklama { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Tutar { get; set; }
    }
} 