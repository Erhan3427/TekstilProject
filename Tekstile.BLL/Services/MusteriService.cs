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
    
    public class MusteriService:IMusteriService
    {
        MyDbContext _db;
        public MusteriService(MyDbContext context)
        {
            _db = context;
        }
        public List<Musteriler> MusteriListele()
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

    }
}
