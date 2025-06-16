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
    public class DesenService : IDesenRepo
    {
        MyDbContext _db;

        public DesenService(MyDbContext context)
        {
            _db = context;
        }
        public List<Desenler> Listele()
        {
            var Boyalistele = _db.Desenler.ToList();
            return Boyalistele;
            
        }

        public void Ekle(Desenler boya)
        {
            _db.Desenler.Add(boya);
            _db.SaveChanges();
        }

        public void Sil(int id)
        {
            var DesenId = _db.Desenler.Find(id);
            if (DesenId != null)
            {
                _db.Desenler.Remove(DesenId);
                _db.SaveChanges();
            }
        }

        public void guncelle(Desenler boya)
        {
            _db.Desenler.Update(boya);
            _db.SaveChanges();
        }
    }
}
