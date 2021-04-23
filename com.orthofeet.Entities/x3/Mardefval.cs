﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("MARDEFVAL", Schema = "TESTPROD")]
    [Index(nameof(Marsctnum0), nameof(Crinum0), Name = "MARDEFVAL_MDV0")]
    [Index(nameof(Marsctnum0), nameof(Crinum0), nameof(Sctvalnum0), Name = "MARDEFVAL_MDV1", IsUnique = true)]
    public partial class Mardefval
    {
        [Required]
        [Column("MARSCTNUM_0")]
        [StringLength(20)]
        public string Marsctnum0 { get; set; }
        [Column("CRINUM_0")]
        public int Crinum0 { get; set; }
        [Required]
        [Column("MARSCTVAL_0")]
        [StringLength(35)]
        public string Marsctval0 { get; set; }
        [Column("SCTVALNUM_0")]
        public short Sctvalnum0 { get; set; }
        [Column("MARVALDAT_0", TypeName = "datetime")]
        public DateTime Marvaldat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}