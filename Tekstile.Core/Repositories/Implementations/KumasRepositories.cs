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
    public class KumasRepositories : IKumasRepo
    {
        MyDbContext _db;
        public KumasRepositories(MyDbContext context)
        {
            _db = context;
            
        }

        public void Ekle(Kumascinsleri boya)
        {
            
            _db.Kumascinsleri.Add(boya);
            _db.SaveChanges();

        }

        public Kumascinsleri GetById(int id)
        {
           
            return   _db.Kumascinsleri.Find(id);
          
        }

        public void Guncelle(Kumascinsleri boya)
        {
            
           _db.Kumascinsleri.Update(boya);
            _db.SaveChanges();

        }

        public List<Kumascinsleri> Listele()
        {
            return _db.Kumascinsleri.ToList();

        }

        public void Sil(int id)
        {
            var silinecek = _db.Kumascinsleri.Find(id);
          
                _db.Kumascinsleri.Remove(silinecek);
                _db.SaveChanges();
           

        }
    }
}
