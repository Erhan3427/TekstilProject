using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.DAL.Repositories.Interfaces
{
    public interface ICalisanRepo
    {
        List<Calisan> HepsiniGetir();
        Calisan? IdyeGoreGetir(int id);
        void Ekle(Calisan calisan);
        void Guncelle(Calisan calisan);
        void Sil(int id);
        void Kaydet();
    }

}
