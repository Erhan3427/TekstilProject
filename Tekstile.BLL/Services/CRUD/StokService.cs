using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.BLL.Interfaces;
using Tekstile.BLL.Services.Interfaces;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.CRUD
{
    public class StokService : IStokService
    {
        IStokRepo _sR;
        public StokService(IStokRepo stokRepo)
        {
            _sR = stokRepo;
            
        }
        public void Ekle(StokHareket stok)
        {
            _sR.Ekle(stok);
        }

        public List<StokHareket> HepsiniGetir()
        {
           return _sR.Listele();
        }

     
    }
}
