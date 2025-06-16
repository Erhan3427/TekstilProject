using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.BLL.Services.Interfaces
{
    public interface IDesenService
    {
        List<Desenler> HepsiniGetir();
        Desenler GetById(int id);
        void Ekle(Desenler desen);
        void Guncelle(Desenler desen);
        void Sil(int id);
    }
}
