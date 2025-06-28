using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.BLL.Interfaces;
using Tekstile.Context;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services
{
    public class BoyaRepositories:IBoyaRepo
    {
        MyDbContext _db;
        public BoyaRepositories()
        {
            _db = new MyDbContext();
        }
        public void Ekle(Boyalar boya)
        {
            _db.Boyalar.Add(boya);
            _db.SaveChanges();
        }

        public void Sil(int id)
        {
            var boya = _db.Boyalar.Find(id);

             _db.Boyalar.Remove(boya);
             _db.SaveChanges();
        }

        public List<Boyalar> Listele()
        {
            return _db.Boyalar.ToList();
        }

        public Boyalar GetById(int id)
        {
            return _db.Boyalar.Find(id);
        }

        public void Guncelle(Boyalar boya)
        {
            _db.Boyalar.Update(boya);
            _db.SaveChanges();
        }
    }
}
