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
    public class CalisanService : ICalisanService
    {
        private readonly ICalisanRepo _repo;

        public CalisanService(ICalisanRepo repo)
        {
            _repo = repo;
        }

        public List<Calisan> HepsiniGetir()
        {
            return _repo.HepsiniGetir();
        }

        public Calisan? IdyeGoreGetir(int id)
        {
            return _repo.IdyeGoreGetir(id);
        }

        public void Ekle(Calisan calisan)
        {
            _repo.Ekle(calisan);
            _repo.Kaydet();
        }

        public void Guncelle(Calisan calisan)
        {
            _repo.Guncelle(calisan);
            _repo.Kaydet();
        }

        public void Sil(int id)
        {
            _repo.Sil(id);
            _repo.Kaydet();
        }
    }

}
