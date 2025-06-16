using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Interfaces
{
    public interface IStokRepo
    {
        List<StokHareket> Listele();
        void Ekle(StokHareket hareket);

    }
}
