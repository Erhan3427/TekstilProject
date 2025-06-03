using System;
using System.Collections.Generic;

namespace Tekstile.Entities.Data;



public partial class Kumascinsleri
{
    public int Id { get; set; }

    public string KumasAdi { get; set; } = null!;

    public double? Gramaj { get; set; }

    public string? IplikTipi { get; set; }

    public virtual List<Siparisler> Siparislers { get; set; }
}
