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
    public class KumasService : IKumasService
    {
        IKumasRepo _kR;
        public KumasService(IKumasRepo kumasRepo)
        {
            _kR = kumasRepo;
            
        }
        public void Ekle(Kumascinsleri kumas)
        {
            _kR.Ekle(kumas);
        }

        public Kumascinsleri GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Kumascinsleri kumas)
        {
            _kR.guncelle(kumas);
        }

        public List<Kumascinsleri> HepsiniGetir()
        {
           return _kR.Listele();
        }


        public void Sil(int id)
        {
            _kR.Sil(id);
        }
    }
}
