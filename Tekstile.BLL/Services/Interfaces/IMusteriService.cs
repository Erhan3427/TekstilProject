using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.Interfaces
{
    public interface IMusteriService
    {
        List<Musteriler> HepsiniGetir();
        Musteriler GetById(int id);
        void Ekle(Musteriler musteri);
        void Guncelle(Musteriler musteri);
        void Sil(int id);
    }
}
