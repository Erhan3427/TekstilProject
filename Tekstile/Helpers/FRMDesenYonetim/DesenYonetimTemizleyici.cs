using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekstile.Entities.Data;

namespace Tekstile.UI.Helpers.FRMDesenYonetim
{
    public class DesenYonetimTemizleyici
    {
        public static void Temizle(TextBox desenAdi, TextBox aciklama, NumericUpDown boyaSayisi, NumericUpDown gram, ComboBox Musteri, ComboBox Boyalar)
        {
            desenAdi.Clear();
            aciklama.Clear();
            boyaSayisi.Value = 0;
            gram.Value = 0;
            Musteri.SelectedIndex = -1;
            Boyalar.SelectedIndex = -1;
        }
    }
}