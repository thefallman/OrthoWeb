﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SOLRESULT", Schema = "TESTPROD")]
    [Index(nameof(Solnum0), Name = "SOLRESULT_SOR0")]
    [Index(nameof(Num0), Name = "SOLRESULT_SOR1")]
    [Index(nameof(Sss0), Name = "SOLRESULT_SOR2")]
    [Index(nameof(Solnum0), nameof(Sss0), nameof(Typ0), Name = "SOLRESULT_SOR3", IsUnique = true)]
    public partial class Solresult
    {
        [Required]
        [Column("SOLNUM_0")]
        [StringLength(20)]
        public string Solnum0 { get; set; }
        [Column("NUM_0")]
        public int Num0 { get; set; }
        [Required]
        [Column("SSS_0")]
        [StringLength(30)]
        public string Sss0 { get; set; }
        [Required]
        [Column("TYP_0")]
        [StringLength(10)]
        public string Typ0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("CREDATSOL_0", TypeName = "datetime")]
        public DateTime Credatsol0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("TTR_0")]
        [StringLength(80)]
        public string Ttr0 { get; set; }
        [Required]
        [Column("MORSOL_0")]
        [StringLength(2)]
        public string Morsol0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}