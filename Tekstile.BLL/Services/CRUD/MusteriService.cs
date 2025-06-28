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
    public class MusteriService : IMusteriService
    {
        IMusteriRepo _mR;
        public MusteriService(IMusteriRepo musteriRepo)
        {
            _mR = musteriRepo;
            
        }
        public void Ekle(Musteriler musteri)
        {
            _mR.MusteriEkle(musteri);
        }

        public Musteriler GetById(int id)
        {
            return _mR.GetById(id);

        }

        public void Guncelle(Musteriler musteri)
        {
            _mR.Guncelle(musteri);
        }

        public List<Musteriler> HepsiniGetir()
        {
            return _mR.Listele();
        }

        public void Sil(int id)
        {
            _mR.MusteriSil(id);

        }
    }
}
