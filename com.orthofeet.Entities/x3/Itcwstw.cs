﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ITCWSTW", Schema = "TESTPROD")]
    [Index(nameof(Uid0), nameof(Stofcy0), nameof(Itmref0), nameof(Csttyp0), nameof(Yea0), nameof(Wst0), Name = "ITCWSTW_IWW0", IsUnique = true)]
    public partial class Itcwstw
    {
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("CSTTYP_0")]
        public byte Csttyp0 { get; set; }
        [Column("YEA_0")]
        public short Yea0 { get; set; }
        [Column("UID_0")]
        public int Uid0 { get; set; }
        [Required]
        [Column("WST_0")]
        [StringLength(8)]
        public string Wst0 { get; set; }
        [Column("WSTTYP_0")]
        public byte Wsttyp0 { get; set; }
        [Column("BRDCOD_0")]
        public byte Brdcod0 { get; set; }
        [Column("WCSTTYP_0")]
        public byte Wcsttyp0 { get; set; }
        [Column("RATCOD_0")]
        public byte Ratcod0 { get; set; }
        [Column("SETCST_0", TypeName = "numeric(14, 3)")]
        public decimal Setcst0 { get; set; }
        [Column("SETTIM_0", TypeName = "numeric(13, 5)")]
        public decimal Settim0 { get; set; }
        [Column("OPECST_0", TypeName = "numeric(14, 3)")]
        public decimal Opecst0 { get; set; }
        [Column("OPETIM_0", TypeName = "numeric(13, 5)")]
        public decimal Opetim0 { get; set; }
        [Column("SETAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Setamt0 { get; set; }
        [Column("OPEAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Opeamt0 { get; set; }
        [Required]
        [Column("SCOITMREF_0")]
        [StringLength(20)]
        public string Scoitmref0 { get; set; }
        [Column("CSTCOD_0")]
        public byte Cstcod0 { get; set; }
        [Column("PRISCO_0", TypeName = "numeric(19, 5)")]
        public decimal Prisco0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
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