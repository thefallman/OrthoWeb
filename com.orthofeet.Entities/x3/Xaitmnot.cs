﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XAITMNOT", Schema = "TESTPROD")]
    [Index(nameof(Itmref0), nameof(Notenum0), Name = "XAITMNOT_XAQ0", IsUnique = true)]
    public partial class Xaitmnot
    {
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("NOTENUM_0")]
        public int Notenum0 { get; set; }
        [Required]
        [Column("FONC_0")]
        [StringLength(15)]
        public string Fonc0 { get; set; }
        [Column("EFFDAT_0", TypeName = "datetime")]
        public DateTime Effdat0 { get; set; }
        [Column("EXPDAT_0", TypeName = "datetime")]
        public DateTime Expdat0 { get; set; }
        [Required]
        [Column("NOTECAT_0")]
        [StringLength(20)]
        public string Notecat0 { get; set; }
        [Required]
        [Column("BRIEF_0")]
        [StringLength(40)]
        public string Brief0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}