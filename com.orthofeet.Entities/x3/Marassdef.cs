﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("MARASSDEF", Schema = "TESTPROD")]
    [Index(nameof(Recordnum0), nameof(Recordadd0), nameof(Recordtyp0), Name = "MARASSDEF_MAD0", IsUnique = true)]
    [Index(nameof(Recordnum0), nameof(Recordtyp0), Name = "MARASSDEF_MAD1")]
    public partial class Marassdef
    {
        [Required]
        [Column("RECORDNUM_0")]
        [StringLength(20)]
        public string Recordnum0 { get; set; }
        [Required]
        [Column("RECORDADD_0")]
        [StringLength(7)]
        public string Recordadd0 { get; set; }
        [Required]
        [Column("RECORDTYP_0")]
        [StringLength(4)]
        public string Recordtyp0 { get; set; }
        [Required]
        [Column("MARSCTNUM_0")]
        [StringLength(20)]
        public string Marsctnum0 { get; set; }
        [Column("MANASS_0")]
        public short Manass0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}