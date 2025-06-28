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
    public class MakineRepositories : IMakineRepo
    {
        MyDbContext _db;
        public MakineRepositories()
        {
            _db = new MyDbContext();
        }
        public List<Makineler> Listele() => _db.Makineler.ToList();
        public void Ekle(Makineler makine)
        {
            _db.Makineler.Add(makine);
            _db.SaveChanges();

        }
        public void Sil(int id)
        {
            var makine = _db.Makineler.Find(id);
            if (makine != null)
            {
                _db.Makineler.Remove(makine);
                _db.SaveChanges();
            }
        }

        public void Guncelle(Makineler makine)
        {
            _db.Makineler.Update(makine);
            _db.SaveChanges();
        }
        public Makineler GetById(int id)
        {
            return _db.Makineler.Find(id);
        }
    }
}
