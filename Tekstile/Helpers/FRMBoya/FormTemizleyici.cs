using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstile.UI.Helpers.FRMBoya
{
    public class FormTemizleyici
    {
        public static void Temizle(TextBox boyaKodu, TextBox renkAdi, NumericUpDown kovaAdet, NumericUpDown fiyat, ComboBox boyaTipi, ComboBox kovaDurum)
        {
            boyaKodu.Clear();
            renkAdi.Clear();
            kovaAdet.Value = 0;
            fiyat.Value = 0;
            boyaTipi.SelectedIndex = -1;
            kovaDurum.SelectedIndex = -1;
        }
    }
}
