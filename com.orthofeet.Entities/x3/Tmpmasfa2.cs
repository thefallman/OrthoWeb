﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TMPMASFA2", Schema = "TESTPROD")]
    [Index(nameof(Trtnum0), nameof(Objref0), Name = "TMPMASFA2_MF10", IsUnique = true)]
    [Index(nameof(Trtnum0), nameof(Cpy0), nameof(Objref0), Name = "TMPMASFA2_MF11", IsUnique = true)]
    public partial class Tmpmasfa2
    {
        [Column("TRTNUM_0")]
        public int Trtnum0 { get; set; }
        [Required]
        [Column("OBJREF_0")]
        [StringLength(20)]
        public string Objref0 { get; set; }
        [Required]
        [Column("OBJREFO_0")]
        [StringLength(20)]
        public string Objrefo0 { get; set; }
        [Required]
        [Column("OBJREFN_0")]
        [StringLength(20)]
        public string Objrefn0 { get; set; }
        [Column("FLGERR_0")]
        public byte Flgerr0 { get; set; }
        [Required]
        [Column("MSGERR_0")]
        [StringLength(100)]
        public string Msgerr0 { get; set; }
        [Column("FLGMOD_0")]
        public byte Flgmod0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("AASIND_0")]
        [StringLength(1)]
        public string Aasind0 { get; set; }
        [Column("RNWVAL_0", TypeName = "numeric(28, 8)")]
        public decimal Rnwval0 { get; set; }
        [Column("CCNTRFCUM_0", TypeName = "numeric(28, 8)")]
        public decimal Ccntrfcum0 { get; set; }
        [Column("CCNTRFCAD_0", TypeName = "numeric(28, 8)")]
        public decimal Ccntrfcad0 { get; set; }
        [Column("CCNTRFGRT_0", TypeName = "numeric(28, 8)")]
        public decimal Ccntrfgrt0 { get; set; }
        [Column("CCNTRFRPR_0", TypeName = "numeric(28, 8)")]
        public decimal Ccntrfrpr0 { get; set; }
        [Column("CCNINICUM_0", TypeName = "numeric(28, 8)")]
        public decimal Ccninicum0 { get; set; }
        [Column("CCNCADDEV_0", TypeName = "numeric(28, 8)")]
        public decimal Ccncaddev0 { get; set; }
        [Column("CCNCADEXC_0", TypeName = "numeric(28, 8)")]
        public decimal Ccncadexc0 { get; set; }
        [Column("RVERPRVAL_0", TypeName = "numeric(28, 8)")]
        public decimal Rverprval0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}