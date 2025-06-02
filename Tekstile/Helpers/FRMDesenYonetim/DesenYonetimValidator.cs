using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tekstile.UI.Helpers.FRMDesenYonetim
{
    public class DesenYonetimValidator
    {
        public static bool DesenKontrol(string DesenAdi,string DesenAciklama,object Musteri,int boyaSayisi )
        {
            if (string.IsNullOrWhiteSpace(DesenAdi) ||
                string.IsNullOrWhiteSpace(DesenAciklama) ||
                Musteri == null ||
                boyaSayisi <= 0)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve boya sayısını 0'dan büyük bir değer olarak ayarlayın.");
                return false;
            }

            return true;
        }

        public static bool BoyaKontrol(object Boya, double Gram)
        {
            if (Boya == null || Gram <= 0)
            {
                MessageBox.Show("Lütfen boya seçin ve gram değerini 0'dan büyük bir değer olarak ayarlayın.");
                return false;
            }
            return true;
        }
    }
}
