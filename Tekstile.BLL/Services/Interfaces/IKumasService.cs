using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.Interfaces
{
    public interface IKumasService
    {
        List<Kumascinsleri> HepsiniGetir();
        Kumascinsleri GetById(int id);
        void Ekle(Kumascinsleri kumas);
        void Guncelle(Kumascinsleri kumas);
        void Sil(int id);
    }
}
