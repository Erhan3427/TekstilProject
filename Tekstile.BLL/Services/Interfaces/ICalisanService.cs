using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.Interfaces
{
    public interface ICalisanService
    {
        List<Calisan> HepsiniGetir();
        Calisan? IdyeGoreGetir(int id);
        void Ekle(Calisan calisan);
        void Guncelle(Calisan calisan);
        void Sil(int id);
    }

}
