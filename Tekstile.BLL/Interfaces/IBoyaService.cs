using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Interfaces
{

    public interface IBoyaService
    {
        List<Boyalar> BoyaListele();
        void Ekle(Boyalar boya);
        void Sil(int id);
    }

}
