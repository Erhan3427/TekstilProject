using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tekstile.UI.Helpers.FRMMakineYonetim
{
    public class MakineYonetimTemizleyici
    {
        public static void Temizle( ComboBox makineAdi,ComboBox musteri, ComboBox desen)
        {
            
            makineAdi.SelectedIndex = -1;
            musteri.SelectedIndex = -1;
            desen.SelectedIndex = -1;
        }
    }
} 