﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AVARLOC", Schema = "TESTPROD")]
    [Index(nameof(Typ0), nameof(Fct0), nameof(Cod0), Name = "AVARLOC_AVR0", IsUnique = true)]
    public partial class Avarloc
    {
        [Column("TYP_0")]
        public byte Typ0 { get; set; }
        [Required]
        [Column("FCT_0")]
        [StringLength(10)]
        public string Fct0 { get; set; }
        [Required]
        [Column("COD_0")]
        [StringLength(80)]
        public string Cod0 { get; set; }
        [Column("INTIT_0")]
        public int Intit0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
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