﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AVIEWD", Schema = "TESTPROD")]
    [Index(nameof(Codvue0), nameof(Numlig0), nameof(Fldvue0), Name = "AVIEWD_AVD0", IsUnique = true)]
    [Index(nameof(Codvue0), nameof(Fldvue0), Name = "AVIEWD_AVD1", IsUnique = true)]
    [Index(nameof(Codtyp0), nameof(Codvue0), nameof(Fldvue0), Name = "AVIEWD_AVD2", IsUnique = true)]
    public partial class Aviewd
    {
        [Required]
        [Column("CODVUE_0")]
        [StringLength(12)]
        public string Codvue0 { get; set; }
        [Required]
        [Column("FLDVUE_0")]
        [StringLength(12)]
        public string Fldvue0 { get; set; }
        [Column("FLDINT_0")]
        public int Fldint0 { get; set; }
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
        [Required]
        [Column("CODTYP_0")]
        [StringLength(3)]
        public string Codtyp0 { get; set; }
        [Column("LNG_0", TypeName = "numeric(6, 1)")]
        public decimal Lng0 { get; set; }
        [Column("NOLIB_0")]
        public short Nolib0 { get; set; }
        [Required]
        [Column("FLDACT_0")]
        [StringLength(5)]
        public string Fldact0 { get; set; }
        [Column("DIME_0")]
        public short Dime0 { get; set; }
        [Required]
        [Column("OPTION_0")]
        [StringLength(10)]
        public string Option0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}