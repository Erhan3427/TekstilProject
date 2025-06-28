using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.DAL.Repositories.Interfaces
{
    public interface IDesenYonetimiRepo
    {
        List<DesenBoyalar> Listele();
        void Ekle(DesenBoyalar boya);
        void Sil(int id);
        void Guncelle(DesenBoyalar boya);
        DesenBoyalar GetById(int id);
    }
}
