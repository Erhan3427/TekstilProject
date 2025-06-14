using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Tekstile.BLL.Interfaces;
using Tekstile.Context;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services
{
    public class MakineService:IMakineService
    {
        MyDbContext _db;
        public MakineService()
        {
            _db = new MyDbContext();
        }
        public List<Makineler> MakineleriListele() => _db.Makineler.ToList();
        public void Ekle(Makineler makine)
        {
            _db.Makineler.Add(makine);
            _db.SaveChanges();

        }
        public void Sil(int id)
        {
            var makine = _db.Makineler.Find(id);
            _db.Makineler.Remove(makine);
            _db.SaveChanges();
        }

    }
}
