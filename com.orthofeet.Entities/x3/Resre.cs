﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("RESRES", Schema = "TESTPROD")]
    [Index(nameof(Num0), Name = "RESRES_RRS0", IsUnique = true)]
    [Index(nameof(Rrsori0), nameof(Rrsorivcr0), Name = "RESRES_RRS1")]
    public partial class Resre
    {
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Required]
        [Column("RSSNUM_0")]
        [StringLength(20)]
        public string Rssnum0 { get; set; }
        [Required]
        [Column("SALFCY_0")]
        [StringLength(5)]
        public string Salfcy0 { get; set; }
        [Column("RERDAT_0", TypeName = "datetime")]
        public DateTime Rerdat0 { get; set; }
        [Required]
        [Column("HOUSTR_0")]
        [StringLength(5)]
        public string Houstr0 { get; set; }
        [Column("RERDATEND_0", TypeName = "datetime")]
        public DateTime Rerdatend0 { get; set; }
        [Required]
        [Column("HOUEND_0")]
        [StringLength(5)]
        public string Houend0 { get; set; }
        [Required]
        [Column("RERREP_0")]
        [StringLength(15)]
        public string Rerrep0 { get; set; }
        [Column("CRESNC_0", TypeName = "datetime")]
        public DateTime Cresnc0 { get; set; }
        [Column("RRSORI_0")]
        public byte Rrsori0 { get; set; }
        [Required]
        [Column("RRSORIVCR_0")]
        [StringLength(20)]
        public string Rrsorivcr0 { get; set; }
        [Column("RRSORIVCRL_0")]
        public int Rrsorivcrl0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREHOU_0")]
        [StringLength(5)]
        public string Crehou0 { get; set; }
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