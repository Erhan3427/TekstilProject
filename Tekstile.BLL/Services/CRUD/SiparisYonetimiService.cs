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
    public class SiparisYonetimiService : ISiparisYonetimiService
    {
        ISiparisYonetimiRepo _sYP;
        public SiparisYonetimiService(ISiparisYonetimiRepo siparisYonetimiRepo)
        {
            _sYP = siparisYonetimiRepo;
            
        }
        public void Ekle(Siparisler siparis)
        {
            _sYP.Ekle(siparis);
        }

        public Siparisler GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Siparisler siparis)
        {
            _sYP.guncelle(siparis);
        }

        public List<Siparisler> HepsiniListele()
        {
            return _sYP.Listele();
        }

        public void Sil(int id)
        {
            _sYP.Sil(id);
        }

    }
}
