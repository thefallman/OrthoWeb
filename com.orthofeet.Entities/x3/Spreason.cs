﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SPREASON", Schema = "TESTPROD")]
    [Index(nameof(Priren0), Name = "SPREASON_SPR0", IsUnique = true)]
    public partial class Spreason
    {
        [Column("PRIREN_0")]
        public short Priren0 { get; set; }
        [Required]
        [Column("PRIRENCAR_0")]
        [StringLength(3)]
        public string Prirencar0 { get; set; }
        [Required]
        [Column("LANDESSHO_0")]
        [StringLength(60)]
        public string Landessho0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Column("DACMAN_0")]
        public byte Dacman0 { get; set; }
        [Column("UPDPRI_0")]
        public byte Updpri0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
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