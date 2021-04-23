﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AENCHAINE", Schema = "TESTPROD")]
    [Index(nameof(Code0), nameof(Numlig0), Name = "AENCHAINE_CODE", IsUnique = true)]
    public partial class Aenchaine
    {
        [Required]
        [Column("CHEMIN_0")]
        [StringLength(250)]
        public string Chemin0 { get; set; }
        [Required]
        [Column("CODE_0")]
        [StringLength(10)]
        public string Code0 { get; set; }
        [Required]
        [Column("MODELE_0")]
        [StringLength(10)]
        public string Modele0 { get; set; }
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
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
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}