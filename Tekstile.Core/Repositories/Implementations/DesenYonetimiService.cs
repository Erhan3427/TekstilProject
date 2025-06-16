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
    public class DesenYonetimiService : IDesenYonetimiRepo
    {
        MyDbContext _db;
        public DesenYonetimiService(MyDbContext context)
        {
            _db = context;
            
        }
        public List<DesenBoyalar> Listele()
        {
            var DesenBoyaListele = _db.DesenBoyalari.ToList();
            return DesenBoyaListele;
        }

        public void Ekle(DesenBoyalar boya)
        {
            _db.DesenBoyalari.Add(boya);
            _db.SaveChanges();
        }

        public void guncelle(DesenBoyalar boya)
        {
            _db.DesenBoyalari.Update(boya);
            _db.SaveChanges();
        }

        public void Sil(int id)
        {
            var DesenBoyaId = _db.DesenBoyalari.Find(id);
            if (DesenBoyaId != null)
            {
                _db.DesenBoyalari.Remove(DesenBoyaId);
                _db.SaveChanges();
            }
        }
    }
}
