using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.Interfaces
{
    public interface ISiparisYonetimiService
    {
        List<Siparisler> HepsiniListele();
        Siparisler GetById(int id);
        void Ekle(Siparisler siparis);
        void Guncelle(Siparisler siparis);
        void Sil(int id);
    }
}
