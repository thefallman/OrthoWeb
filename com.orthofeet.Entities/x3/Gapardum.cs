﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GAPARDUM", Schema = "TESTPROD")]
    [Index(nameof(Coa0), nameof(Cod0), nameof(Numlin0), Name = "GAPARDUM_PDM0", IsUnique = true)]
    [Index(nameof(Coa0), nameof(Cod0), Name = "GAPARDUM_PDM1")]
    public partial class Gapardum
    {
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Required]
        [Column("COD_0")]
        [StringLength(5)]
        public string Cod0 { get; set; }
        [Column("NUMLIN_0")]
        public short Numlin0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Required]
        [Column("DESSHO_0")]
        [StringLength(10)]
        public string Dessho0 { get; set; }
        [Required]
        [Column("ACCSTR_0")]
        [StringLength(15)]
        public string Accstr0 { get; set; }
        [Required]
        [Column("ACCDEB_0")]
        [StringLength(15)]
        public string Accdeb0 { get; set; }
        [Required]
        [Column("ACCCDT_0")]
        [StringLength(15)]
        public string Acccdt0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}