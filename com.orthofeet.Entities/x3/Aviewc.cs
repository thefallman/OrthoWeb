﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AVIEWC", Schema = "TESTPROD")]
    [Index(nameof(Codvue0), nameof(Codcle0), Name = "AVIEWC_AVC0", IsUnique = true)]
    [Index(nameof(Codvue0), nameof(Numlig0), nameof(Codcle0), Name = "AVIEWC_AVC1", IsUnique = true)]
    public partial class Aviewc
    {
        [Required]
        [Column("CLEACT_0")]
        [StringLength(5)]
        public string Cleact0 { get; set; }
        [Required]
        [Column("CODVUE_0")]
        [StringLength(12)]
        public string Codvue0 { get; set; }
        [Required]
        [Column("CODCLE_0")]
        [StringLength(10)]
        public string Codcle0 { get; set; }
        [Required]
        [Column("DESCLE_0")]
        [StringLength(120)]
        public string Descle0 { get; set; }
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
        [Column("KEYDUP_0")]
        public byte Keydup0 { get; set; }
        [Required]
        [Column("CRESTP_0")]
        [StringLength(14)]
        public string Crestp0 { get; set; }
        [Required]
        [Column("UPDSTP_0")]
        [StringLength(14)]
        public string Updstp0 { get; set; }
        [Required]
        [Column("IDTSGL_0")]
        [StringLength(36)]
        public string Idtsgl0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}