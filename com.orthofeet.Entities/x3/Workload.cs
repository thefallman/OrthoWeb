﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("WORKLOAD", Schema = "TESTPROD")]
    [Index(nameof(Mfgfcy0), nameof(Wst0), nameof(Perend0), Name = "WORKLOAD_WKL0", IsUnique = true)]
    [Index(nameof(Mfgfcy0), nameof(Wcr0), nameof(Wst0), nameof(Perend0), Name = "WORKLOAD_WKL1", IsUnique = true)]
    public partial class Workload
    {
        [Required]
        [Column("MFGFCY_0")]
        [StringLength(5)]
        public string Mfgfcy0 { get; set; }
        [Required]
        [Column("WCR_0")]
        [StringLength(5)]
        public string Wcr0 { get; set; }
        [Required]
        [Column("WST_0")]
        [StringLength(8)]
        public string Wst0 { get; set; }
        [Column("PERNUM_0")]
        public short Pernum0 { get; set; }
        [Column("PERDAYNBR_0")]
        public short Perdaynbr0 { get; set; }
        [Column("PERWRKNBR_0")]
        public short Perwrknbr0 { get; set; }
        [Column("PERSTR_0", TypeName = "datetime")]
        public DateTime Perstr0 { get; set; }
        [Column("PEREND_0", TypeName = "datetime")]
        public DateTime Perend0 { get; set; }
        [Column("PERTHEAVA_0", TypeName = "numeric(14, 3)")]
        public decimal Pertheava0 { get; set; }
        [Column("PERAVA_0", TypeName = "numeric(14, 3)")]
        public decimal Perava0 { get; set; }
        [Column("PERLOD_0", TypeName = "numeric(14, 3)")]
        public decimal Perlod0 { get; set; }
        [Column("OWFLOD_0", TypeName = "numeric(14, 3)")]
        public decimal Owflod0 { get; set; }
        [Column("OWPLOD_0", TypeName = "numeric(14, 3)")]
        public decimal Owplod0 { get; set; }
        [Column("OWSLOD_0", TypeName = "numeric(14, 3)")]
        public decimal Owslod0 { get; set; }
        [Column("ORSLOD_0", TypeName = "numeric(14, 3)")]
        public decimal Orslod0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}