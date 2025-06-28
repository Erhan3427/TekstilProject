using System;
using Tekstile.Context;
using Tekstile.Entities.Data;
using Tekstile.Helpers;
namespace Tekstile.Helpers
{
    public static class LogKayit
    {
        public static void LogEkle(string kullaniciAdi, string islemTuru, string islemDetayi)
        {
            MyDbContext _db = new MyDbContext();
            var projeDizini = AppDomain.CurrentDomain.BaseDirectory;
            var hedefKlasor = Path.Combine(projeDizini, "..", "..", "..", "Loglar");

            if (!Directory.Exists(hedefKlasor))
            {
                Directory.CreateDirectory(hedefKlasor);
            }

            var filePath = Path.Combine(hedefKlasor, "log.txt");

            var log = new LogKayitlari
                {
                    KullaniciAdi = kullaniciAdi,
                    IslemTuru = islemTuru,
                    IslemDetayi = islemDetayi,
                    IslemTarihi = DateTime.Now,
                  
                };
            _db.LogKayitlari.Add(log);
            _db.SaveChanges();
            
            var yeniLog = new
            {
                KullaniciAdi = kullaniciAdi,
                IslemTuru = islemTuru,
                IslemDetayi = islemDetayi,
                IslemTarihi = DateTime.Now
            };
            List<object> list;

            if (File.Exists(filePath))
            {
                var logs = File.ReadAllText(filePath);
                list = System.Text.Json.JsonSerializer.Deserialize<List<object>>(logs);
            }
            else
            {
                list = new List<object>();
            }
            list.Add(yeniLog);
            var options = new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            File.WriteAllText(filePath, System.Text.Json.JsonSerializer.Serialize(list, options));

        }



    }
} 