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
    public class MakineService : IMakineService
    {
        IMakineRepo _mR;
        public MakineService(IMakineRepo makineRepo)
        {
            _mR = makineRepo;
            
        }
        public void Ekle(Makineler makine)
        {
            _mR.Ekle(makine);
        }

        public Makineler GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Makineler makine)
        {
            _mR.Guncelle(makine);
        }


        public List<Makineler> HepsiniGetir()
        {
            return _mR.Listele();
        }

        public void Sil(int id)
        {
            _mR.Sil(id);
        }
    }
}
