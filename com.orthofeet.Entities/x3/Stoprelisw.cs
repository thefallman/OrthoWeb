﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("STOPRELISW", Schema = "TESTPROD")]
    [Index(nameof(Pronum0), nameof(Wkey0), nameof(Orityp0), nameof(Ori10), nameof(Ori20), nameof(Ori30), Name = "STOPRELISW_PLW0", IsUnique = true)]
    public partial class Stoprelisw
    {
        [Column("PRONUM_0")]
        public int Pronum0 { get; set; }
        [Required]
        [Column("WKEY_0")]
        [StringLength(40)]
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
        [Column("BPCORD_0")]
        [StringLength(15)]
        public string Bpcord0 { get; set; }
        [Required]
        [Column("BPAADD_0")]
        [StringLength(7)]
        public string Bpaadd0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
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
        [Column("BESDAT_0", TypeName = "datetime")]
        public DateTime Besdat0 { get; set; }
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
        [Required]
        [Column("LOC_0")]
        [StringLength(10)]
        public string Loc0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}