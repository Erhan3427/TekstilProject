using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Context;
using Tekstile.DAL.Repositories.Interfaces;
using Tekstile.Entities.Data;

namespace Tekstile.DAL.Repositories.Implementations
{
    public class CalisanRepositories : ICalisanRepo
    {
        private readonly MyDbContext _context;

        public CalisanRepositories(MyDbContext context)
        {
            _context = context;
        }

        public List<Calisan> HepsiniGetir()
        {
            return _context.Calisanlar.ToList();
        }

        public Calisan? IdyeGoreGetir(int id)
        {
            return _context.Calisanlar.Find(id);
        }

        public void Ekle(Calisan calisan)
        {
            _context.Calisanlar.Add(calisan);
        }

        public void Guncelle(Calisan calisan)
        {
            _context.Calisanlar.Update(calisan);
        }

        public void Sil(int id)
        {
            var silinecek = _context.Calisanlar.Find(id);
            if (silinecek != null)
                _context.Calisanlar.Remove(silinecek);
        }

        public void Kaydet()
        {
            _context.SaveChanges();
        }
    }

}
