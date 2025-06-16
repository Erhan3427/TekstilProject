using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Interfaces
{
    public interface IMusteriRepo
    {
        List<Musteriler> Listele();
        void MusteriEkle(Musteriler musteri);
        void MusteriSil(int id);
        void guncelle(Musteriler musteri);


    }
}
