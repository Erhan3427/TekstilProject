using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.Interfaces
{
    public interface IDesenBoyaService
    {
        List<DesenBoyalar> HepsiniGetir();
        void Ekle(DesenBoyalar DesenBoya);
        void Guncelle(DesenBoyalar DesenBoya);
        void Sil(int id);
        DesenBoyalar GetirById(int id);
    }
}
