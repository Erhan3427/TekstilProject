using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Interfaces
{
    public interface IMusteriService
    {
        List<Musteriler> MusteriListele();
        void MusteriEkle(Musteriler musteri);
        void MusteriSil(int id);


    }
}
