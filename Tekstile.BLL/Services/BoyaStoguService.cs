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
    public class BoyaStoguService : IStokService
    {
        MyDbContext _db;
        public BoyaStoguService()
        {
            _db = new MyDbContext();
        }
        public List<StokHareket> StokListele()
        {
            var list = _db.StokHareket.Include(b=>b.Boya).ToList();
                
            return list;    
        }
        public void Ekle(StokHareket hareket)
        {
            _db.StokHareket.Add(hareket);
            _db.SaveChanges();
        }
    }
}
