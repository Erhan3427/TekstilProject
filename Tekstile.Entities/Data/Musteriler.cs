using System;
using System.Collections.Generic;
namespace Tekstile.Entities.Data;



public partial class Musteriler
{
    public int Id { get; set; }

    public string FirmaAdi { get; set; } = null!;

    public string? YetkiliAdSoyad { get; set; }

    public string? Telefon { get; set; }

    public string? Adres { get; set; }
    public string Kod { get; set; }

    public  List<Desenler> Desenlers { get; set; } 

    public  List<Siparisler> Siparislers { get; set; } 
}
