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
    internal class DesenYonetimService : IDesenYonetimService
    {
        IDesenYonetimiRepo _dyr;
        public DesenYonetimService(IDesenYonetimiRepo desenYonetimiRepo)
        {
            _dyr = desenYonetimiRepo;
            
        }
        public void Ekle(DesenBoyalar boya)
        {
            _dyr.Ekle(boya);

        }

        public DesenBoyalar GetById(int id) => _dyr.GetById(id);



        public void Guncelle(DesenBoyalar desenBoya)
        {
            _dyr.Guncelle(desenBoya);
        }

        public List<DesenBoyalar> HepsiniGetir()
        {
            return _dyr.Listele();
        }


        public void Sil(int id)
        {
            _dyr.Sil(id);
        }
    }
}
