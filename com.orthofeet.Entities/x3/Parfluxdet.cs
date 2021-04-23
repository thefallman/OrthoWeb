﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PARFLUXDET", Schema = "TESTPROD")]
    [Index(nameof(Codtxs0), nameof(Coa0), nameof(Postxs0), nameof(Gac0), Name = "PARFLUXDET_PFD0", IsUnique = true)]
    [Index(nameof(Codtxs0), nameof(Coa0), nameof(Gac0), Name = "PARFLUXDET_PFD1", IsUnique = true)]
    public partial class Parfluxdet
    {
        [Required]
        [Column("CODTXS_0")]
        [StringLength(5)]
        public string Codtxs0 { get; set; }
        [Column("POSTXS_0")]
        public short Postxs0 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Required]
        [Column("GAC_0")]
        [StringLength(15)]
        public string Gac0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}