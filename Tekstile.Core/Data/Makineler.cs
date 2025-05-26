using System;
using System.Collections.Generic;

namespace Tekstile.Data;

public partial class Makineler
{
    public int Id { get; set; }

    public string MakineAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public virtual List<Siparisler> Siparislers { get; set; } 
}
