using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.DAL.Repositories.Interfaces
{
    public interface IDesenRepo
    {
        List<Desenler> Listele();
        void Ekle(Desenler boya);
        void Sil(int id);
        void guncelle(Desenler boya);

    }
}
