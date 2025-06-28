using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.DAL.Repositories.Interfaces
{
    public interface IDesenBoyaRepo
    {
        List<DesenBoyalar> HepsiniGetir();
        void Ekle(DesenBoyalar desenBoya);
        void Guncelle(DesenBoyalar desenBoya);
        void Sil(int id);
        DesenBoyalar GetirById(int id);
    }

}
