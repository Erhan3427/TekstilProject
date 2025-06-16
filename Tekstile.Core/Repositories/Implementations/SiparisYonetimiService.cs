using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Context;
using Tekstile.DAL.Repositories.Interfaces;
using Tekstile.Entities.Data;

namespace Tekstile.DAL.Repositories.Services
{
    public class SiparisYonetimiService : ISiparisYonetimiRepo
    {
        MyDbContext _db;
        public SiparisYonetimiService(MyDbContext context)
        {
            _db = context;
            
        }
        public List<Siparisler> Listele()
        {
            var list = _db.Siparisler.ToList();
            return list;    
        }

        public void Ekle(Siparisler boya)
        {
            _db.Siparisler.Add(boya);
            _db.SaveChanges();
        }

        public void guncelle(Siparisler boya)
        {
            _db.Siparisler.Update(boya);
            _db.SaveChanges();
        }

        public void Sil(int id)
        {
            var SiparisID = _db.Siparisler.Find(id);
            if (SiparisID != null)
            {
                _db.Siparisler.Remove(SiparisID);
                _db.SaveChanges();
            }
        }
    }
}
