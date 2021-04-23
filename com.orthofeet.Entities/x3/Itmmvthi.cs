﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ITMMVTHIS", Schema = "TESTPROD")]
    [Index(nameof(Itmref0), nameof(Stofcy0), nameof(Perstr0), Name = "ITMMVTHIS_ITH0", IsUnique = true)]
    [Index(nameof(Stofcy0), nameof(Itmref0), nameof(Perstr0), Name = "ITMMVTHIS_ITH1", IsUnique = true)]
    public partial class Itmmvthi
    {
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Column("PERSTR_0", TypeName = "datetime")]
        public DateTime Perstr0 { get; set; }
        [Column("PEREND_0", TypeName = "datetime")]
        public DateTime Perend0 { get; set; }
        [Column("FIYNUM_0")]
        public short Fiynum0 { get; set; }
        [Column("PERNUM_0")]
        public short Pernum0 { get; set; }
        [Column("LASREODAT_0", TypeName = "datetime")]
        public DateTime Lasreodat0 { get; set; }
        [Column("LASPURPRI_0", TypeName = "numeric(18, 5)")]
        public decimal Laspurpri0 { get; set; }
        [Column("LASPURDAT_0", TypeName = "datetime")]
        public DateTime Laspurdat0 { get; set; }
        [Column("LASRCPPRI_0", TypeName = "numeric(19, 5)")]
        public decimal Lasrcppri0 { get; set; }
        [Column("LASRCPDAT_0", TypeName = "datetime")]
        public DateTime Lasrcpdat0 { get; set; }
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Column("MONRCPQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Monrcpqty0 { get; set; }
        [Column("YEARCPQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Yearcpqty0 { get; set; }
        [Column("MONRCPAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Monrcpamt0 { get; set; }
        [Column("YEARCPAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Yearcpamt0 { get; set; }
        [Column("MONRCPMVT_0")]
        public int Monrcpmvt0 { get; set; }
        [Column("YEARCPMVT_0")]
        public int Yearcpmvt0 { get; set; }
        [Column("LASISSDAT_0", TypeName = "datetime")]
        public DateTime Lasissdat0 { get; set; }
        [Column("MONISSQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Monissqty0 { get; set; }
        [Column("YEAISSQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Yeaissqty0 { get; set; }
        [Column("MONISSAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Monissamt0 { get; set; }
        [Column("YEAISSAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Yeaissamt0 { get; set; }
        [Column("MONISSMVT_0")]
        public int Monissmvt0 { get; set; }
        [Column("YEAISSMVT_0")]
        public int Yeaissmvt0 { get; set; }
        [Column("AMTDEV_0", TypeName = "numeric(27, 13)")]
        public decimal Amtdev0 { get; set; }
        [Column("AMTDEV2_0", TypeName = "numeric(28, 8)")]
        public decimal Amtdev20 { get; set; }
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