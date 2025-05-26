using System;
using System.Collections.Generic;

namespace Tekstile.Data;

public partial class Siparisler
{
    public int Id { get; set; }

    public int MusteriId { get; set; }

    public int DesenId { get; set; }

    public int KumasId { get; set; }

    public int MakineId { get; set; }

    public int? Adet { get; set; }

    public decimal? BaskiFiyat { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public virtual Desenler Desen { get; set; } = null!;

    public virtual Kumascinsleri Kumas { get; set; } = null!;

    public virtual Makineler Makine { get; set; } = null!;

    public virtual Musteriler Musteri { get; set; } = null!;
}
