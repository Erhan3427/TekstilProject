using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.DAL.Repositories.Interfaces
{
    public interface IGiderRepo
    {
        List<Giderler> Listele();
        void Ekle(Giderler boya);
        void Sil(int id);
        void Guncelle(Giderler boya);
        Giderler GetById(int id);
    }
}
