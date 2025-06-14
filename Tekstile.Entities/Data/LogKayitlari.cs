using System;
using System.ComponentModel.DataAnnotations;

namespace Tekstile.Entities.Data
{
    public class LogKayitlari
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string IslemTuru { get; set; }
        public string IslemDetayi { get; set; }
        public DateTime IslemTarihi { get; set; }
       
    }
} 