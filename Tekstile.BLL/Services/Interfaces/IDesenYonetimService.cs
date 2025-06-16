using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.Interfaces
{
    public interface IDesenYonetimService
    {
        List<DesenBoyalar> HepsiniGetir();
        Desenler GetById(int id);
        void Ekle(DesenBoyalar desenBoya);
        void Guncelle(DesenBoyalar desenBoya);
        void Sil(int id);
    }
}
