using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.Interfaces
{
    public interface IGiderService
    {
        List<Giderler> HepsiniGetir();
        Giderler GetById(int id);
        void Ekle(Giderler gider);
        void Guncelle(Giderler gider);
        void Sil(int id);
    }
}
