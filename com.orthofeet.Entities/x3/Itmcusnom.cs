﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ITMCUSNOM", Schema = "TESTPROD")]
    [Index(nameof(Itmnom0), Name = "ITMCUSNOM_INO0", IsUnique = true)]
    [Index(nameof(Itmcussho0), Name = "ITMCUSNOM_INO1")]
    public partial class Itmcusnom
    {
        [Required]
        [Column("ITMNOM_0")]
        [StringLength(12)]
        public string Itmnom0 { get; set; }
        [Required]
        [Column("ITMCUSDES_0")]
        [StringLength(250)]
        public string Itmcusdes0 { get; set; }
        [Required]
        [Column("ITMCUSUOM_0")]
        [StringLength(12)]
        public string Itmcusuom0 { get; set; }
        [Required]
        [Column("ITMCUSSHO_0")]
        [StringLength(30)]
        public string Itmcussho0 { get; set; }
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
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}