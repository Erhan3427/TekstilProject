using System;
using Tekstile.Context;
using Tekstile.Entities.Data;

namespace Tekstile.Helpers
{
    public static class LogHelper
    {
        public static void LogEkle(string kullaniciAdi, string islemTuru, string islemDetayi)
        {
            MyDbContext _db = new MyDbContext();    

            var log = new LogKayitlari
                {
                    KullaniciAdi = kullaniciAdi,
                    IslemTuru = islemTuru,
                    IslemDetayi = islemDetayi,
                    IslemTarihi = DateTime.Now,
                  
                };

                _db.SaveChanges();
            
        }

      
    }
} 