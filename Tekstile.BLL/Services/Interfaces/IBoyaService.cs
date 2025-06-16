using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.Interfaces
{
    public interface IBoyaService
    {
        List<Boyalar> HepsiniGetir();
        Boyalar GetById(int id);
        void Ekle(Boyalar boya);
        void Guncelle(Boyalar boya);
        void Sil(int id);
    }
}
