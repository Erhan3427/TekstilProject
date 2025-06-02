using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Interfaces
{
    public interface IStokService
    {
        List<StokHareket> StokListele();
        void Ekle(StokHareket hareket);

    }
}
