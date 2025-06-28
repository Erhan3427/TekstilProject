using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.BLL.Services.Interfaces;
using Tekstile.DAL.Repositories.Interfaces;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.CRUD
{
    public class DesenBoyaService : IDesenBoyaService
    {
        private readonly IDesenBoyaRepo _repo;
        public DesenBoyaService(IDesenBoyaRepo repo)
        {
            _repo = repo;
        }

        public List<DesenBoyalar> HepsiniGetir() => _repo.HepsiniGetir();

        public void Ekle(DesenBoyalar entity) => _repo.Ekle(entity);

        public void Guncelle(DesenBoyalar entity) => _repo.Guncelle(entity);

        public void Sil(int id) => _repo.Sil(id);

        public DesenBoyalar GetirById(int id) => _repo.GetirById(id);
    }

}
