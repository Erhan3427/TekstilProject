using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.DAL.Repositories.Interfaces
{
    public interface ISiparisYonetimiRepo
    {
        List<Siparisler> Listele();
        void Ekle(Siparisler boya);
        void Sil(int id);
        void guncelle(Siparisler boya);
    }
}
