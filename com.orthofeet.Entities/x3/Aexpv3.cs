﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AEXPV3", Schema = "TESTPROD")]
    [Index(nameof(Code0), Name = "AEXPV3_AEV0", IsUnique = true)]
    public partial class Aexpv3
    {
        [Required]
        [Column("CODE_0")]
        [StringLength(10)]
        public string Code0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Required]
        [Column("MODELE_0")]
        [StringLength(10)]
        public string Modele0 { get; set; }
        [Column("TYPV3_0")]
        public byte Typv30 { get; set; }
        [Required]
        [Column("FILV3_0")]
        [StringLength(250)]
        public string Filv30 { get; set; }
        [Column("CODDBA_0")]
        public byte Coddba0 { get; set; }
        [Column("TYPX3_0")]
        public byte Typx30 { get; set; }
        [Required]
        [Column("FILX3_0")]
        [StringLength(250)]
        public string Filx30 { get; set; }
        [Required]
        [Column("FLGV3_0")]
        [StringLength(10)]
        public string Flgv30 { get; set; }
        [Required]
        [Column("FLGV3_1")]
        [StringLength(10)]
        public string Flgv31 { get; set; }
        [Required]
        [Column("FLGV3_2")]
        [StringLength(10)]
        public string Flgv32 { get; set; }
        [Required]
        [Column("FLGV3_3")]
        [StringLength(10)]
        public string Flgv33 { get; set; }
        [Required]
        [Column("FLGV3_4")]
        [StringLength(10)]
        public string Flgv34 { get; set; }
        [Required]
        [Column("FLGV3_5")]
        [StringLength(10)]
        public string Flgv35 { get; set; }
        [Required]
        [Column("FLGV3_6")]
        [StringLength(10)]
        public string Flgv36 { get; set; }
        [Required]
        [Column("FLGV3_7")]
        [StringLength(10)]
        public string Flgv37 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
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