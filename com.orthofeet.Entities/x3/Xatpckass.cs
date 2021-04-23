﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XATPCKASS", Schema = "TESTPROD")]
    [Index(nameof(Stofcy0), nameof(Vcrnum0), nameof(Vcrlin0), nameof(Vcrseq0), nameof(Loc0), nameof(Lot0), nameof(Slo0), nameof(Sta0), nameof(Itmref0), Name = "XATPCKASS_XA40", IsUnique = true)]
    [Index(nameof(Stofcy0), nameof(Pcksts0), Name = "XATPCKASS_XA41")]
    public partial class Xatpckass
    {
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("ADCUSER_0")]
        [StringLength(10)]
        public string Adcuser0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Required]
        [Column("LOC_0")]
        [StringLength(10)]
        public string Loc0 { get; set; }
        [Required]
        [Column("ZONE_0")]
        [StringLength(10)]
        public string Zone0 { get; set; }
        [Required]
        [Column("STA_0")]
        [StringLength(3)]
        public string Sta0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("PCKSTS_0")]
        public byte Pcksts0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Column("QTYSAL_0", TypeName = "numeric(28, 13)")]
        public decimal Qtysal0 { get; set; }
        [Required]
        [Column("SAU_0")]
        [StringLength(3)]
        public string Sau0 { get; set; }
        [Required]
        [Column("PCKUSRLIST_0")]
        [StringLength(128)]
        public string Pckusrlist0 { get; set; }
        [Column("INSTFLG_0")]
        public byte Instflg0 { get; set; }
        [Required]
        [Column("BATCH_0")]
        [StringLength(20)]
        public string Batch0 { get; set; }
        [Required]
        [Column("XSERPSEQ_0")]
        [StringLength(12)]
        public string Xserpseq0 { get; set; }
        [Required]
        [Column("LOT_0")]
        [StringLength(15)]
        public string Lot0 { get; set; }
        [Required]
        [Column("SLO_0")]
        [StringLength(5)]
        public string Slo0 { get; set; }
        [Column("VCRSEQ_0")]
        public int Vcrseq0 { get; set; }
        [Required]
        [Column("STGLOC_0")]
        [StringLength(10)]
        public string Stgloc0 { get; set; }
        [Column("SAUSTUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Saustucoe0 { get; set; }
        [Column("BOMOPE_0")]
        public short Bomope0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}