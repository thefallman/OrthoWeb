﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("STOTRK", Schema = "TESTPROD")]
    [Index(nameof(Itmref0), nameof(Lot0), nameof(Slo0), nameof(Iptdat0), nameof(Mvtseq0), nameof(Stofcy0), Name = "STOTRK_STR0", IsUnique = true)]
    [Index(nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vcrlin0), Name = "STOTRK_STR1")]
    [Index(nameof(Itmref0), nameof(Sernum0), nameof(Iptdat0), nameof(Mvtseq0), nameof(Stofcy0), Name = "STOTRK_STR2")]
    public partial class Stotrk
    {
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("LOT_0")]
        [StringLength(15)]
        public string Lot0 { get; set; }
        [Required]
        [Column("SLO_0")]
        [StringLength(5)]
        public string Slo0 { get; set; }
        [Required]
        [Column("SERNUM_0")]
        [StringLength(20)]
        public string Sernum0 { get; set; }
        [Column("TRSTYP_0")]
        public byte Trstyp0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Column("IPTDAT_0", TypeName = "datetime")]
        public DateTime Iptdat0 { get; set; }
        [Column("MVTSEQ_0")]
        public int Mvtseq0 { get; set; }
        [Column("MVTIND_0")]
        public int Mvtind0 { get; set; }
        [Required]
        [Column("STA_0")]
        [StringLength(3)]
        public string Sta0 { get; set; }
        [Required]
        [Column("QLYCTLDEM_0")]
        [StringLength(20)]
        public string Qlyctldem0 { get; set; }
        [Column("POT_0", TypeName = "numeric(14, 5)")]
        public decimal Pot0 { get; set; }
        [Column("ACT_0", TypeName = "numeric(14, 5)")]
        public decimal Act0 { get; set; }
        [Column("SHLDAT_0", TypeName = "datetime")]
        public DateTime Shldat0 { get; set; }
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Column("VCRTYPORI_0")]
        public byte Vcrtypori0 { get; set; }
        [Required]
        [Column("VCRNUMORI_0")]
        [StringLength(20)]
        public string Vcrnumori0 { get; set; }
        [Column("VCRLINORI_0")]
        public int Vcrlinori0 { get; set; }
        [Required]
        [Column("BPRNUM_0")]
        [StringLength(15)]
        public string Bprnum0 { get; set; }
        [Required]
        [Column("PALNUM_0")]
        [StringLength(10)]
        public string Palnum0 { get; set; }
        [Required]
        [Column("CTRNUM_0")]
        [StringLength(10)]
        public string Ctrnum0 { get; set; }
        [Column("REGFLG_0")]
        public byte Regflg0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}