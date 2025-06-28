using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.BLL.Services.Interfaces;
using Tekstile.Entities.Data;
using Tekstile.DAL.Repositories.Interfaces;

namespace Tekstile.BLL.Services.CRUD
{
    public class RaporService : IRaporService
    {
        private readonly IGiderRepo _giderRepo;
        public RaporService(IGiderRepo giderRepo)
        {
            _giderRepo = giderRepo;
        }

        public decimal ToplamGelir()
        {
            return _giderRepo.Listele().Where(x => x.GiderTuru == "Gelir").Sum(x => x.Tutar);
        }

        public decimal ToplamGider()
        {
            return _giderRepo.Listele().Where(x => x.GiderTuru == "Gider").Sum(x => x.Tutar);
        }

        public decimal Bakiye()
        {
            return ToplamGelir() - ToplamGider();
        }

        public decimal ToplamGelir(DateTime baslangic, DateTime bitis)
        {
            return _giderRepo.Listele().Where(x => x.GiderTuru == "Gelir" && x.Tarih >= baslangic && x.Tarih <= bitis).Sum(x => x.Tutar);
        }

        public decimal ToplamGider(DateTime baslangic, DateTime bitis)
        {
            return _giderRepo.Listele().Where(x => x.GiderTuru == "Gider" && x.Tarih >= baslangic && x.Tarih <= bitis).Sum(x => x.Tutar);
        }

        public decimal Bakiye(DateTime baslangic, DateTime bitis)
        {
            return ToplamGelir(baslangic, bitis) - ToplamGider(baslangic, bitis);
        }

        public List<Giderler> RaporGetir(string tur, DateTime? baslangic, DateTime? bitis)
        {
            var sırala = _giderRepo.Listele().AsQueryable();
            if (!string.IsNullOrEmpty(tur))
                sırala = sırala.Where(x => x.GiderTuru == tur);
            if (baslangic.HasValue)
                sırala = sırala.Where(x => x.Tarih >= baslangic.Value);
            if (bitis.HasValue)
                sırala = sırala.Where(x => x.Tarih <= bitis.Value);
            return sırala.ToList();
        }
    }
}
