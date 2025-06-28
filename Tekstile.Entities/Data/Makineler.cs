using System;
using System.Collections.Generic;
namespace Tekstile.Entities.Data;



public partial class Makineler
{
    public int Id { get; set; }

    public string MakineAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public  List<Siparisler> Siparislers { get; set; } 
}
