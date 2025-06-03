using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekstile.Context;

namespace Tekstile.UI.Helpers.FRMMakineYonetim
{
    public class MakineYonetimListele
    {
        public static void Listele(DataGridView dgv, MyDbContext db)
        {
            dgv.DataSource = db.Makineler.Select(m => new
            {
                m.Id,
                m.MakineAdi,
                m.Aciklama
            }).ToList();
        }
    }
} 