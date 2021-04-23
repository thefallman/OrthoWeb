﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABSOHTYP", Schema = "TESTPROD")]
    [Index(nameof(Sohtyp0), Name = "TABSOHTYP_TSO0", IsUnique = true)]
    public partial class Tabsohtyp
    {
        [Required]
        [Column("SOHTYP_0")]
        [StringLength(5)]
        public string Sohtyp0 { get; set; }
        [Required]
        [Column("LANDESSHO_0")]
        [StringLength(60)]
        public string Landessho0 { get; set; }
        [Required]
        [Column("TSODES_0")]
        [StringLength(30)]
        public string Tsodes0 { get; set; }
        [Required]
        [Column("TSOSOH_0")]
        [StringLength(10)]
        public string Tsosoh0 { get; set; }
        [Column("SOHCAT_0")]
        public byte Sohcat0 { get; set; }
        [Column("MANCOU_0")]
        public byte Mancou0 { get; set; }
        [Required]
        [Column("CODNUM_0")]
        [StringLength(5)]
        public string Codnum0 { get; set; }
        [Required]
        [Column("GFY_0")]
        [StringLength(5)]
        public string Gfy0 { get; set; }
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