using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Context;

namespace Tekstile.UI.Helpers
{
    public  class BoyaListeHelper
    {
        public static void Listele(DataGridView dgv, MyDbContext context)
        {
            dgv.DataSource = context.Boyalar.ToList();
            dgv.Columns["ID"].Visible = false;
        }
    }
}
