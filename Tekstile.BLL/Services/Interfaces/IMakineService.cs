using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.Interfaces
{
    public interface IMakineService
    {
        List<Makineler> HepsiniGetir();
        Makineler GetById(int id);
        void Ekle(Makineler makine);
        void Guncelle(Makineler makine);
        void Sil(int id);
    }
}
