﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SECPST", Schema = "TESTPROD")]
    [Index(nameof(Sptnum0), Name = "SECPST_SPT0", IsUnique = true)]
    public partial class Secpst
    {
        [Required]
        [Column("SPTNUM_0")]
        [StringLength(20)]
        public string Sptnum0 { get; set; }
        [Required]
        [Column("SPTREP_0")]
        [StringLength(15)]
        public string Sptrep0 { get; set; }
        [Required]
        [Column("SPTRES_0")]
        [StringLength(100)]
        public string Sptres0 { get; set; }
        [Column("SPTENA_0")]
        public byte Sptena0 { get; set; }
        [Column("SPTORD_0")]
        public short Sptord0 { get; set; }
        [Required]
        [Column("SPTFOR_0")]
        [StringLength(250)]
        public string Sptfor0 { get; set; }
        [Column("SPTFOROPD_0")]
        public byte Sptforopd0 { get; set; }
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
        [Column("SPTCRI_0")]
        public byte Sptcri0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}