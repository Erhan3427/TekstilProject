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
    public class BoyaService : IBoyaService
    {
        IBoyaRepo _bR;
        public BoyaService(IBoyaRepo boyaRepo)
        {
            _bR=boyaRepo;

        }
        public void Ekle(Boyalar boya)
        {

            _bR.Ekle(boya);
        }

        public Boyalar GetById(int id)
        {
            return _bR.GetById(id);
        }

        public void Guncelle(Boyalar boya)
        {
            _bR.Guncelle(boya);
        }

        public List<Boyalar> HepsiniGetir()
        {
            return _bR.Listele();
        }

        public void Sil(int id)
        {
            _bR.Sil(id);
        }
    }
}
