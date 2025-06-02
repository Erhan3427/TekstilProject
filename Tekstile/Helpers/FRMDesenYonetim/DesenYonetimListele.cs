using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Context;

namespace Tekstile.UI.Helpers.FRMDesenYonetim
{
    public class DesenYonetimListele
    {
        public static void Listele(DataGridView dgv, MyDbContext context)
        {
            dgv.DataSource = context.DesenBoyalari.Select(s=> new
            { 
                s.Id,
                s.Desen.DesenAdi,
                s.Musteri.FirmaAdi,
                s.Boya,
                s.BoyaSayisi,
                s.Gram

            }
            ).ToList();
           
        }


    }
}
