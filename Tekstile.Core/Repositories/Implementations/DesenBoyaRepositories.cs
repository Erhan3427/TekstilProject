using Microsoft.EntityFrameworkCore;
using Tekstile.Context;
using Tekstile.DAL.Repositories.Interfaces;
using Tekstile.Entities.Data;

namespace Tekstile.DAL.Repositories.Implementations
{
    public class DesenBoyaRepositories : IDesenBoyaRepo
    {
        private readonly MyDbContext _context;
        public DesenBoyaRepositories(MyDbContext context)
        {
            _context = context;
        }

        public List<DesenBoyalar> HepsiniGetir()
        {
            return _context.DesenBoyalari
                           .Include(x => x.Boya)
                           .Include(x => x.Musteri)
                           .Include(x => x.Desen)
                           .ToList();
        }

        public void Ekle(DesenBoyalar entity)
        {
            _context.DesenBoyalari.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(DesenBoyalar entity)
        {
            _context.DesenBoyalari.Update(entity);
            _context.SaveChanges();
        }

        public void Sil(int id)
        {
            var desenBoya = _context.DesenBoyalari.Find(id);
            if (desenBoya != null)
            {
                _context.DesenBoyalari.Remove(desenBoya);
                _context.SaveChanges();
            }   
        }

        public DesenBoyalar GetirById(int id)
        {
            return _context.DesenBoyalari.FirstOrDefault(x => x.Id == id)!;
        }
    }

}
