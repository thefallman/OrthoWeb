﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("APTLPAGE", Schema = "TESTPROD")]
    [Index(nameof(Apspag0), Name = "APTLPAGE_APS0", IsUnique = true)]
    public partial class Aptlpage
    {
        [Required]
        [Column("APSPAG_0")]
        [StringLength(10)]
        public string Apspag0 { get; set; }
        [Column("APSPRE_0")]
        public byte Apspre0 { get; set; }
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
        [Column("APSNBCAD_0")]
        public short Apsnbcad0 { get; set; }
        [Required]
        [Column("APSVW_0")]
        [StringLength(10)]
        public string Apsvw0 { get; set; }
        [Required]
        [Column("APSVW_1")]
        [StringLength(10)]
        public string Apsvw1 { get; set; }
        [Required]
        [Column("APSVW_2")]
        [StringLength(10)]
        public string Apsvw2 { get; set; }
        [Required]
        [Column("APSVW_3")]
        [StringLength(10)]
        public string Apsvw3 { get; set; }
        [Required]
        [Column("APSVW_4")]
        [StringLength(10)]
        public string Apsvw4 { get; set; }
        [Required]
        [Column("APSVW_5")]
        [StringLength(10)]
        public string Apsvw5 { get; set; }
        [Required]
        [Column("APSVW_6")]
        [StringLength(10)]
        public string Apsvw6 { get; set; }
        [Required]
        [Column("APSVW_7")]
        [StringLength(10)]
        public string Apsvw7 { get; set; }
        [Required]
        [Column("APSVW_8")]
        [StringLength(10)]
        public string Apsvw8 { get; set; }
        [Required]
        [Column("APSURL_0")]
        [StringLength(200)]
        public string Apsurl0 { get; set; }
        [Required]
        [Column("APSURL_1")]
        [StringLength(200)]
        public string Apsurl1 { get; set; }
        [Required]
        [Column("APSURL_2")]
        [StringLength(200)]
        public string Apsurl2 { get; set; }
        [Required]
        [Column("APSURL_3")]
        [StringLength(200)]
        public string Apsurl3 { get; set; }
        [Required]
        [Column("APSURL_4")]
        [StringLength(200)]
        public string Apsurl4 { get; set; }
        [Required]
        [Column("APSURL_5")]
        [StringLength(200)]
        public string Apsurl5 { get; set; }
        [Required]
        [Column("APSURL_6")]
        [StringLength(200)]
        public string Apsurl6 { get; set; }
        [Required]
        [Column("APSURL_7")]
        [StringLength(200)]
        public string Apsurl7 { get; set; }
        [Required]
        [Column("APSURL_8")]
        [StringLength(200)]
        public string Apsurl8 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}