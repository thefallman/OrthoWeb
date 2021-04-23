﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AOBJTAB", Schema = "TESTPROD")]
    [Index(nameof(Abrev0), nameof(Numlig0), Name = "AOBJTAB_ABREV", IsUnique = true)]
    [Index(nameof(Abrev0), nameof(Tabfic0), nameof(Tababr0), Name = "AOBJTAB_TABFIC", IsUnique = true)]
    public partial class Aobjtab
    {
        [Required]
        [Column("ABREV_0")]
        [StringLength(3)]
        public string Abrev0 { get; set; }
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
        [Required]
        [Column("TABFIC_0")]
        [StringLength(12)]
        public string Tabfic0 { get; set; }
        [Required]
        [Column("TABCLE_0")]
        [StringLength(10)]
        public string Tabcle0 { get; set; }
        [Required]
        [Column("TABLIEN_0")]
        [StringLength(200)]
        public string Tablien0 { get; set; }
        [Required]
        [Column("TABABR_0")]
        [StringLength(4)]
        public string Tababr0 { get; set; }
        [Required]
        [Column("TABACT_0")]
        [StringLength(5)]
        public string Tabact0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}