﻿using Market.Models.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    [Table("Satislar")]
    public class Satis : BaseEntity<int>
    {
        public int SatisAdeti { get; set; }

        public decimal AltToplam { get; set; } = 0;

        public int UrunId { get; set; }

        [Required]
        public int FisId { get; set; }

        [ForeignKey("FisId")]
        public Fis Fis { get; set; }

        [ForeignKey("UrunId")]
        public Urun Urun { get; set; }

        public override string ToString() => $"{Urun.UrunAdi} {SatisAdeti} {Urun.Kdv} {AltToplam}";
    }
}
