using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Context;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Interfaces
{
    public interface IMakineRepo
    {
        List<Makineler> Listele();
        void Ekle(Makineler makine);
        void Sil(int id);
        void Guncelle(Makineler makine);
    }
}

