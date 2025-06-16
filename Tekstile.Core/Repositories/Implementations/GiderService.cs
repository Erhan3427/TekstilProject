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
    public class GiderService : IGiderRepo
    {
        MyDbContext _db;
        public GiderService(MyDbContext context)
        {
            _db = context;

        }
        public List<Giderler> Listele()
        {
            var listele = _db.Giderler.ToList();
            return listele;
        }

        public void Ekle(Giderler boya)
        {
            _db.Giderler.Add(boya);
        }

        public void guncelle(Giderler boya)
        {
            _db.Giderler.Update(boya);
        }

        public void Sil(int id)
        {
            var GiderId = _db.Giderler.Find(id);
            if (GiderId != null)
            {
                _db.Giderler.Remove(GiderId);
                _db.SaveChanges();
            }
        }
    }
}
