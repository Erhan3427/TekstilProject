using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstile.UI.Helpers.FRMMakineYonetim
{
    public class MakineYonetimValidator
    {
        public static bool MakineKontrol(string makineAdi, string Musteri, string Desen)
        {
            if (string.IsNullOrEmpty(makineAdi))
            {
                MessageBox.Show("Lütfen makine adını seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

          

            if (string.IsNullOrEmpty(Musteri))
            {
                MessageBox.Show("Lütfen Musteri  seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(Desen))
            {
                MessageBox.Show("Lütfen makine desenini seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
} 