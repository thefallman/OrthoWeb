﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ADOCFNC", Schema = "TESTPROD")]
    [Index(nameof(Typ0), nameof(Cod0), nameof(Num0), Name = "ADOCFNC_ADF0", IsUnique = true)]
    public partial class Adocfnc
    {
        [Required]
        [Column("TYP_0")]
        [StringLength(20)]
        public string Typ0 { get; set; }
        [Required]
        [Column("COD_0")]
        [StringLength(30)]
        public string Cod0 { get; set; }
        [Column("NUM_0")]
        public short Num0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Required]
        [Column("TYPLNK_0")]
        [StringLength(20)]
        public string Typlnk0 { get; set; }
        [Required]
        [Column("CLELNK_0")]
        [StringLength(30)]
        public string Clelnk0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
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