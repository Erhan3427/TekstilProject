using System;
using System.Collections.Generic;

namespace Tekstile.Entities.Data;



public partial class DesenBoyalar
{
    public int Id { get; set; }

    public int DesenId { get; set; }

    public int BoyaId { get; set; }
    public int MusteriId { get; set; }

    public double Gram { get; set; }
    public int BoyaSayisi { get; set; }
    public Boyalar Boya { get; set; } = null!;

    public  Desenler Desen { get; set; } = null!;
    public Musteriler Musteri { get; set; } = null!;
}
