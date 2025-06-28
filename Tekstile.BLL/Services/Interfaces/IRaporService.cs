using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.Interfaces
{
    public interface IRaporService
    {
        decimal ToplamGelir();
        decimal ToplamGider();
        decimal Bakiye();
        decimal ToplamGelir(DateTime baslangic, DateTime bitis);
        decimal ToplamGider(DateTime baslangic, DateTime bitis);
        decimal Bakiye(DateTime baslangic, DateTime bitis);
        List<Giderler> RaporGetir(string tur, DateTime? baslangic, DateTime? bitis);
    }
}
