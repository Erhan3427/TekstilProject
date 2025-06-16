using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.DAL.Repositories.Interfaces
{
    public interface IKumasRepo
    {
        List<Kumascinsleri> Listele();
        void Ekle(Kumascinsleri boya);
        void Sil(int id);
        void guncelle(Kumascinsleri boya);
    }
}
