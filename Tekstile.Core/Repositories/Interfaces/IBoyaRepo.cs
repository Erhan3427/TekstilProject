using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Interfaces
{

    public interface IBoyaRepo
    {
        List<Boyalar> Listele();
        void Ekle(Boyalar boya);
        void Sil(int id);
        void Guncelle(Boyalar boya);
        Boyalar GetById(int id);
    }

}
