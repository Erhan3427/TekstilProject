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
    public class KumasService : IKumasRepo
    {
        MyDbContext _db;
        public KumasService(MyDbContext context)
        {
            _db = context;
            
        }
        public List<Desenler> Listele()
        {
            var list = _db.Desenler.ToList();
            return list;
        }

        public void Ekle(Desenler desen)
        {
            _db.Desenler.Add(desen);
            _db.SaveChanges();
        }

        public void guncelle(Desenler desen)
        {
            _db.Desenler.Update(desen);
            _db.SaveChanges();
        }

        public void Sil(int id)
        {
            var DesenID = _db.Desenler.Find(id);
            if (DesenID != null)
            {
                _db.Desenler.Remove(DesenID);
                _db.SaveChanges();
            }
        }
    }
}
