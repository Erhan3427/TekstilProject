using System;
using System.Collections.Generic;

namespace Tekstile.Data;

public partial class Desenler
{
    public int Id { get; set; }

    public string DesenAdi { get; set; } = null!;

    public string? FotoYolu { get; set; }

    public int? Boyasayisi { get; set; }

    public string? Aciklama { get; set; }

    public int? MusteriId { get; set; }

    public virtual List<DesenBoyalar> DesenBoyalars { get; set; } 

    public virtual Musteriler? Musteri { get; set; }

    public virtual List<Siparisler> Siparislers { get; set; } 
}
