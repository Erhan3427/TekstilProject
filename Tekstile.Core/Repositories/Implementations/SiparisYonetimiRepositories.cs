using Microsoft.EntityFrameworkCore;
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
    public class SiparisYonetimiRepositories : ISiparisYonetimiRepo
    {
        MyDbContext _db;
        public SiparisYonetimiRepositories(MyDbContext context)
        {
            _db = context;

        }
        public List<Siparisler> Listele()
        {
            return _db.Siparisler
                    .Include(s => s.Musteri)
                    .Include(s => s.Desen)
                    .Include(s => s.Kumas)
                    .Include(s => s.Makine)
                    .ToList();
        }

        public void Ekle(Siparisler boya)
        {
            _db.Siparisler.Add(boya);
            _db.SaveChanges();
        }

        public void Guncelle(Siparisler boya)
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
        public Siparisler GetById(int id)
        {
            return _db.Siparisler.Find(id);
        }
    }
}
