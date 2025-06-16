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
        IDesenYonetimiRepo _dYR;
        public DesenYonetimService(IDesenYonetimiRepo desenYonetimiRepo)
        {
            _dYR = desenYonetimiRepo;
            
        }
        public void Ekle(DesenBoyalar boya)
        {
            _dYR.Ekle(boya);

        }

        public Desenler GetById(int id)
        {
            throw new NotImplementedException();
        }

      

        public void Guncelle(DesenBoyalar desenBoya)
        {
            _dYR.guncelle(desenBoya);
        }

        public List<DesenBoyalar> HepsiniGetir()
        {
            return _dYR.Listele();
        }

       

        public void Sil(int id)
        {
            _dYR.Sil(id);
        }
    }
}
