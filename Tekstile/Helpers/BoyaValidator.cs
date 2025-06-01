using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstile.UI.Helpers
{
    public class BoyaValidator
    {
        public static bool BoyaVerisiGecerliMi(string boyaKodu, string renkAdi, string kovaAdet, string fiyat, object boyaTipi, object kovaDurum)
        {
            if (string.IsNullOrWhiteSpace(boyaKodu) ||
                string.IsNullOrWhiteSpace(renkAdi) ||
                string.IsNullOrWhiteSpace(kovaAdet) ||
                string.IsNullOrWhiteSpace(fiyat) ||
                boyaTipi == null ||
                kovaDurum == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return false;
            }

            return true;
        }
    }
}
