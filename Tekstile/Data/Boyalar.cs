using System;
using System.Collections.Generic;

namespace Tekstile.Data;

public partial class Boyalar
{
    public int Id { get; set; }

    public string BoyaKodu { get; set; } = null!;

    public string? RenkAdi { get; set; }

    public string? BoyaTipi { get; set; }

    public int? KovaAdedi { get; set; }

    public decimal BoyaFiyat { get; set; }
    public decimal? ToplamFiyat { get; set; }

    public string? StokDurum { get; set; }

    public int? GelenAdet { get; set; }

    public int? BitenAdet { get; set; }

    public int? AcilanAdet { get; set; }
   


    public virtual List<DesenBoyalar> DesenBoyalars { get; set; }
    public override string ToString()
    {
        return RenkAdi;
    }
}
