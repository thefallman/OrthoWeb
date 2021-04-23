﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ATEXTRA", Schema = "TESTPROD")]
    [Index(nameof(Codfic0), nameof(Zone0), nameof(Langue0), nameof(Ident10), nameof(Ident20), Name = "ATEXTRA_AXX0", IsUnique = true)]
    [Index(nameof(Langue0), nameof(Codfic0), nameof(Zone0), Name = "ATEXTRA_AXX1")]
    public partial class Atextra
    {
        [Required]
        [Column("CODFIC_0")]
        [StringLength(12)]
        public string Codfic0 { get; set; }
        [Required]
        [Column("ZONE_0")]
        [StringLength(12)]
        public string Zone0 { get; set; }
        [Required]
        [Column("LANGUE_0")]
        [StringLength(3)]
        public string Langue0 { get; set; }
        [Required]
        [Column("IDENT1_0")]
        [StringLength(80)]
        public string Ident10 { get; set; }
        [Required]
        [Column("IDENT2_0")]
        [StringLength(80)]
        public string Ident20 { get; set; }
        [Required]
        [Column("TEXTE_0")]
        [StringLength(80)]
        public string Texte0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}