using System;
using System.Collections.Generic;

namespace Tekstile.Data;

public partial class Kumascinsleri
{
    public int Id { get; set; }

    public string KumasAdi { get; set; } = null!;

    public int? Gramaj { get; set; }

    public string? IplikTipi { get; set; }

    public virtual List<Siparisler> Siparislers { get; set; }
}
