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
    public class DesenService : IDesenService
    {
        IDesenRepo _dR;
        public DesenService(IDesenRepo desenRepository)
        {
            _dR = desenRepository;
        }
        public void Ekle(Desenler desen)
        {
            _dR.Ekle(desen);
        }

        public Desenler GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Desenler desen)
        {
            _dR.guncelle(desen);
        }

        public List<Desenler> HepsiniGetir()
        {
            return _dR.Listele();
        }

        public void Sil(int id)
        {
            _dR.Sil(id);
        }
    }
}
