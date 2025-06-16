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
    public class GiderService : IGiderService
    {
        IGiderRepo _gR;
        public GiderService(IGiderRepo gR)
        {
            _gR = gR;
        }
        public void Ekle(Giderler gider)
        {
            _gR.Ekle(gider);
        }

        public Giderler GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Giderler gider)
        {
            _gR.guncelle(gider);
        }

        public List<Giderler> HepsiniGetir()
        {
            return _gR.Listele();
        }

        public void Sil(int id)
        {
            _gR.Sil(id);
        }
    }
}
