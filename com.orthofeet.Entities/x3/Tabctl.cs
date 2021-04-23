﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABCTL", Schema = "TESTPROD")]
    [Index(nameof(Tct0), nameof(Tctlin0), Name = "TABCTL_TCT0", IsUnique = true)]
    [Index(nameof(Tct0), nameof(Alpcod0), nameof(Numcod0), Name = "TABCTL_TCT1", IsUnique = true)]
    public partial class Tabctl
    {
        [Required]
        [Column("TCT_0")]
        [StringLength(3)]
        public string Tct0 { get; set; }
        [Required]
        [Column("TCTDES_0")]
        [StringLength(30)]
        public string Tctdes0 { get; set; }
        [Column("TCTLIN_0")]
        public short Tctlin0 { get; set; }
        [Required]
        [Column("ALPCOD_0")]
        [StringLength(20)]
        public string Alpcod0 { get; set; }
        [Column("NUMCOD_0", TypeName = "numeric(28, 8)")]
        public decimal Numcod0 { get; set; }
        [Column("TCTTYP_0")]
        public byte Tcttyp0 { get; set; }
        [Required]
        [Column("DESCOD_0")]
        [StringLength(100)]
        public string Descod0 { get; set; }
        [Required]
        [Column("DESCOD1_0")]
        [StringLength(1)]
        public string Descod10 { get; set; }
        [Required]
        [Column("DESCOD2_0")]
        [StringLength(1)]
        public string Descod20 { get; set; }
        [Required]
        [Column("DESCOD3_0")]
        [StringLength(1)]
        public string Descod30 { get; set; }
        [Required]
        [Column("DESCOD4_0")]
        [StringLength(1)]
        public string Descod40 { get; set; }
        [Required]
        [Column("DESCOD5_0")]
        [StringLength(1)]
        public string Descod50 { get; set; }
        [Required]
        [Column("DESCOD6_0")]
        [StringLength(1)]
        public string Descod60 { get; set; }
        [Required]
        [Column("DESCOD7_0")]
        [StringLength(1)]
        public string Descod70 { get; set; }
        [Required]
        [Column("DESCOD8_0")]
        [StringLength(1)]
        public string Descod80 { get; set; }
        [Required]
        [Column("DESCOD9_0")]
        [StringLength(1)]
        public string Descod90 { get; set; }
        [Column("LANNBR_0")]
        public short Lannbr0 { get; set; }
        [Required]
        [Column("LAN_0")]
        [StringLength(1)]
        public string Lan0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
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