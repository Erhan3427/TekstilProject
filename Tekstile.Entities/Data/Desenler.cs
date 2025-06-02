using System;
using System.Collections.Generic;

namespace Tekstile.Entities.Data;



public partial class Desenler
{
    public int Id { get; set; }

    public string DesenAdi { get; set; } = null!;

    public string? FotoYolu { get; set; }


    public string? Aciklama { get; set; }

    public virtual List<DesenBoyalar> DesenBoyalars { get; set; } 


    public virtual List<Siparisler> Siparislers { get; set; } 
}
