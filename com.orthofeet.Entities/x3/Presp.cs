﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PRESP", Schema = "TESTPROD")]
    [Index(nameof(Bpsnum0), nameof(Pqhnum0), nameof(Pqdlin0), Name = "PRESP_PPH0", IsUnique = true)]
    [Index(nameof(Itmref0), nameof(Bpsnum0), nameof(Pqhnum0), Name = "PRESP_PPH1")]
    [Index(nameof(Bpsnum0), nameof(Itmref0), nameof(Pqhnum0), Name = "PRESP_PPH2")]
    public partial class Presp
    {
        [Required]
        [Column("PQHNUM_0")]
        [StringLength(20)]
        public string Pqhnum0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("PQHFCY_0")]
        [StringLength(5)]
        public string Pqhfcy0 { get; set; }
        [Required]
        [Column("BPSNUM_0")]
        [StringLength(15)]
        public string Bpsnum0 { get; set; }
        [Column("PQDLIN_0")]
        public int Pqdlin0 { get; set; }
        [Column("RSPDAT_0", TypeName = "datetime")]
        public DateTime Rspdat0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("ITMREFBPS_0")]
        [StringLength(20)]
        public string Itmrefbps0 { get; set; }
        [Required]
        [Column("ITMDESBPS_0")]
        [StringLength(30)]
        public string Itmdesbps0 { get; set; }
        [Required]
        [Column("EANCODBPS_0")]
        [StringLength(20)]
        public string Eancodbps0 { get; set; }
        [Required]
        [Column("PLISTC_0")]
        [StringLength(10)]
        public string Plistc0 { get; set; }
        [Column("PRIFLG_0")]
        public byte Priflg0 { get; set; }
        [Column("PRNFLG_0")]
        public byte Prnflg0 { get; set; }
        [Column("PRILINNBR_0")]
        public short Prilinnbr0 { get; set; }
        [Column("LINNBR_0")]
        public short Linnbr0 { get; set; }
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