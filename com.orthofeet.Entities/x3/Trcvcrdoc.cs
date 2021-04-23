﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TRCVCRDOC", Schema = "TESTPROD")]
    [Index(nameof(Typnum0), nameof(Num0), nameof(Typvcr0), nameof(Numvcr0), Name = "TRCVCRDOC_TVD0", IsUnique = true)]
    [Index(nameof(Accnum0), nameof(Typvcr0), nameof(Numvcr0), Name = "TRCVCRDOC_TVD1", IsUnique = true)]
    [Index(nameof(Typvcr0), nameof(Numvcr0), Name = "TRCVCRDOC_TVD2", IsUnique = true)]
    public partial class Trcvcrdoc
    {
        [Column("TYPNUM_0")]
        public byte Typnum0 { get; set; }
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Column("ACCNUM_0")]
        public int Accnum0 { get; set; }
        [Required]
        [Column("TYPVCR_0")]
        [StringLength(5)]
        public string Typvcr0 { get; set; }
        [Required]
        [Column("NUMVCR_0")]
        [StringLength(20)]
        public string Numvcr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}