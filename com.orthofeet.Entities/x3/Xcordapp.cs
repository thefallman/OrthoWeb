﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XCORDAPP", Schema = "TESTPROD")]
    [Index(nameof(Vcrnum0), nameof(Seq0), Name = "XCORDAPP_XCC0", IsUnique = true)]
    [Index(nameof(Uuid0), nameof(Vcrnum0), nameof(Seq0), Name = "XCORDAPP_XCC1", IsUnique = true)]
    public partial class Xcordapp
    {
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("CCL4D_0")]
        [StringLength(4)]
        public string Ccl4d0 { get; set; }
        [Column("STAFLG_0")]
        public byte Staflg0 { get; set; }
        [Column("AUTDAT_0", TypeName = "datetime")]
        public DateTime Autdat0 { get; set; }
        [Required]
        [Column("AUTID_0")]
        [StringLength(15)]
        public string Autid0 { get; set; }
        [Column("AUTAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Autamt0 { get; set; }
        [Required]
        [Column("CCTYPE_0")]
        [StringLength(20)]
        public string Cctype0 { get; set; }
        [Column("VALTO_0", TypeName = "datetime")]
        public DateTime Valto0 { get; set; }
        [Required]
        [Column("CSC_0")]
        [StringLength(4)]
        public string Csc0 { get; set; }
        [Required]
        [Column("AVSADD_0")]
        [StringLength(20)]
        public string Avsadd0 { get; set; }
        [Required]
        [Column("AVSPOSCOD_0")]
        [StringLength(9)]
        public string Avsposcod0 { get; set; }
        [Column("REFREQ_0")]
        public byte Refreq0 { get; set; }
        [Column("SEQ_0")]
        public int Seq0 { get; set; }
        [Required]
        [Column("VCRNUMORI_0")]
        [StringLength(20)]
        public string Vcrnumori0 { get; set; }
        [Column("CREPMT_0")]
        public byte Crepmt0 { get; set; }
        [Column("MANAUT_0")]
        public byte Manaut0 { get; set; }
        [Required]
        [Column("BPCORD_0")]
        [StringLength(15)]
        public string Bpcord0 { get; set; }
        [Required]
        [Column("ORIGID_0")]
        [StringLength(15)]
        public string Origid0 { get; set; }
        [Required]
        [Column("PAYID_0")]
        [StringLength(15)]
        public string Payid0 { get; set; }
        [Column("PAYAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Payamt0 { get; set; }
        [Column("PAYDAT_0", TypeName = "datetime")]
        public DateTime Paydat0 { get; set; }
        [Required]
        [Column("UUID_0")]
        [StringLength(50)]
        public string Uuid0 { get; set; }
        [Required]
        [Column("VANREF_0")]
        [StringLength(20)]
        public string Vanref0 { get; set; }
        [Required]
        [Column("BPCPYR_0")]
        [StringLength(10)]
        public string Bpcpyr0 { get; set; }
        [Column("SPSCNTID_0")]
        public int Spscntid0 { get; set; }
        [Column("ORIGAUTH_0", TypeName = "numeric(27, 13)")]
        public decimal Origauth0 { get; set; }
        [Column("CPROCESSOR_0")]
        public byte Cprocessor0 { get; set; }
        [Column("SPSREJ_0")]
        public byte Spsrej0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}