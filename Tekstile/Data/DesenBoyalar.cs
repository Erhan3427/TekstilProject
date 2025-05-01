using System;
using System.Collections.Generic;

namespace Tekstile.Data;

public partial class DesenBoyalar
{
    public int Id { get; set; }

    public int DesenId { get; set; }

    public int BoyaId { get; set; }

    public decimal? GramMiktari { get; set; }

    public virtual Boyalar Boya { get; set; } = null!;

    public virtual Desenler Desen { get; set; } = null!;
}
