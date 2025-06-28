using System;
using System.Collections.Generic;
namespace Tekstile.Entities.Data;



public partial class Siparisler
{
    public int Id { get; set; }

    public int MusteriId { get; set; }

    public int DesenId { get; set; }

    public int KumasId { get; set; }

    public int MakineId { get; set; }

    public int? Adet { get; set; }

    public decimal? BaskiFiyat { get; set; }
    public decimal? ToplamFiyat { get; set; }
    public string? Durum { get; set; }


    public DateTime? SiparisTarihi { get; set; }

    public  Desenler Desen { get; set; } = null!;

    public Kumascinsleri Kumas { get; set; } = null!;

    public  Makineler Makine { get; set; } = null!;

    public  Musteriler Musteri { get; set; } = null!;
}
