﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("STOPREW", Schema = "TESTPROD")]
    [Index(nameof(Pronum0), nameof(Wkey0), nameof(Orityp0), nameof(Ori10), nameof(Ori20), nameof(Ori30), Name = "STOPREW_PRW0", IsUnique = true)]
    [Index(nameof(Pronum0), nameof(Wkey0), nameof(Wkeyd0), Name = "STOPREW_PRW1")]
    public partial class Stoprew
    {
        [Column("PRONUM_0")]
        public int Pronum0 { get; set; }
        [Required]
        [Column("WKEY_0")]
        [StringLength(120)]
        public string Wkey0 { get; set; }
        [Column("ORITYP_0")]
        public byte Orityp0 { get; set; }
        [Required]
        [Column("ORI1_0")]
        [StringLength(30)]
        public string Ori10 { get; set; }
        [Required]
        [Column("ORI2_0")]
        [StringLength(10)]
        public string Ori20 { get; set; }
        [Column("ORI3_0")]
        public int Ori30 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("WDATA_0")]
        [StringLength(250)]
        public string Wdata0 { get; set; }
        [Column("WKEYD_0")]
        public int Wkeyd0 { get; set; }
        [Required]
        [Column("WDATA2_0")]
        [StringLength(250)]
        public string Wdata20 { get; set; }
        [Column("ODL_0")]
        public byte Odl0 { get; set; }
        [Column("IME_0")]
        public byte Ime0 { get; set; }
        [Required]
        [Column("MDL_0")]
        [StringLength(5)]
        public string Mdl0 { get; set; }
        [Required]
        [Column("BPCORD_0")]
        [StringLength(15)]
        public string Bpcord0 { get; set; }
        [Required]
        [Column("BPAADD_0")]
        [StringLength(7)]
        public string Bpaadd0 { get; set; }
        [Required]
        [Column("BPCINV_0")]
        [StringLength(15)]
        public string Bpcinv0 { get; set; }
        [Column("CHGTYP_0")]
        public byte Chgtyp0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("ITMDES1_0")]
        [StringLength(30)]
        public string Itmdes10 { get; set; }
        [Required]
        [Column("BPTNUM_0")]
        [StringLength(15)]
        public string Bptnum0 { get; set; }
        [Column("DRN_0")]
        public byte Drn0 { get; set; }
        [Required]
        [Column("PRECOD_0")]
        [StringLength(5)]
        public string Precod0 { get; set; }
        [Column("SHIDAT_0", TypeName = "datetime")]
        public DateTime Shidat0 { get; set; }
        [Column("DLVDAT_0", TypeName = "datetime")]
        public DateTime Dlvdat0 { get; set; }
        [Column("LINTYP_0")]
        public byte Lintyp0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Required]
        [Column("PCU_0")]
        [StringLength(3)]
        public string Pcu0 { get; set; }
        [Column("PCUSTUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Pcustucoe0 { get; set; }
        [Column("STOMGTCOD_0")]
        public byte Stomgtcod0 { get; set; }
        [Required]
        [Column("PREUSR_0")]
        [StringLength(5)]
        public string Preusr0 { get; set; }
        [Required]
        [Column("PRLNUM_0")]
        [StringLength(20)]
        public string Prlnum0 { get; set; }
        [Column("PRLSEQ_0")]
        public int Prlseq0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}