using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.BLL.Interfaces;
using Tekstile.Context;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.MusteriService
{
    
    public class MusteriRepositories:IMusteriRepo
    {
        MyDbContext _db;
        public MusteriRepositories()
        {
            _db = new MyDbContext();
        }
        public List<Musteriler> Listele()
        {
            return _db.Musteriler.ToList();

        }
        public void MusteriEkle(Musteriler musteri)
        {
            _db.Musteriler.Add(musteri);
            _db.SaveChanges();
        }
        public void MusteriSil(int musteriId) {


            var musteri = _db.Musteriler.Find(musteriId);

            _db.Remove(musteri);
            _db.SaveChanges();


        }

        public void Guncelle(Musteriler musteri)
        {
            _db.Musteriler.Update(musteri);
            _db.SaveChanges();
        }
        public Musteriler GetById(int id)
        {
            return _db.Musteriler.Find(id);
        }
    }
}
