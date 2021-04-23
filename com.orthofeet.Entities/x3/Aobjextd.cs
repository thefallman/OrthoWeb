﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AOBJEXTD", Schema = "TESTPROD")]
    [Index(nameof(Ext0), nameof(Numlig0), Name = "AOBJEXTD_AOD0", IsUnique = true)]
    public partial class Aobjextd
    {
        [Required]
        [Column("EXT_0")]
        [StringLength(10)]
        public string Ext0 { get; set; }
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
        [Column("SEL_0")]
        public byte Sel0 { get; set; }
        [Required]
        [Column("TYP_0")]
        [StringLength(20)]
        public string Typ0 { get; set; }
        [Required]
        [Column("BAL_0")]
        [StringLength(20)]
        public string Bal0 { get; set; }
        [Required]
        [Column("FIL_0")]
        [StringLength(12)]
        public string Fil0 { get; set; }
        [Required]
        [Column("FMT_0")]
        [StringLength(10)]
        public string Fmt0 { get; set; }
        [Column("LNG_0")]
        public short Lng0 { get; set; }
        [Column("LOC_0")]
        public short Loc0 { get; set; }
        [Required]
        [Column("FLD_0")]
        [StringLength(50)]
        public string Fld0 { get; set; }
        [Required]
        [Column("COM_0")]
        [StringLength(30)]
        public string Com0 { get; set; }
        [Required]
        [Column("PATTERN_0")]
        [StringLength(30)]
        public string Pattern0 { get; set; }
        [Column("OBL_0")]
        public byte Obl0 { get; set; }
        [Required]
        [Column("STRVAL_0")]
        [StringLength(30)]
        public string Strval0 { get; set; }
        [Required]
        [Column("ENDVAL_0")]
        [StringLength(30)]
        public string Endval0 { get; set; }
        [Column("NUMTAB_0")]
        public short Numtab0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}