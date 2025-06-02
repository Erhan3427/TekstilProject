using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Context;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services
{
    public class MakineService
    {
        MyDbContext _db;
        public MakineService(MyDbContext context)
        {
            _db = context;
        }
        public void Ekle(Makineler makine)
        {
            _db.Makineler.Add(makine);
            _db.SaveChanges();

        }
        public void sil(int id)
        {
            var makine = _db.Makineler.Find(id);
            _db.Makineler.Remove(makine);
            _db.SaveChanges();
        }

    }
}
