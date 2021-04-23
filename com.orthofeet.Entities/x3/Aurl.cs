﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AURL", Schema = "TESTPROD")]
    [Index(nameof(Codurl0), Name = "AURL_AUR0", IsUnique = true)]
    public partial class Aurl
    {
        [Required]
        [Column("CODURL_0")]
        [StringLength(10)]
        public string Codurl0 { get; set; }
        [Column("INTIT_0")]
        public int Intit0 { get; set; }
        [Required]
        [Column("INTEVAL_0")]
        [StringLength(60)]
        public string Inteval0 { get; set; }
        [Required]
        [Column("URL_0")]
        [StringLength(250)]
        public string Url0 { get; set; }
        [Column("TYPURL_0")]
        public byte Typurl0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Required]
        [Column("UCOD_0")]
        [StringLength(6)]
        public string Ucod0 { get; set; }
        [Required]
        [Column("UCOD_1")]
        [StringLength(6)]
        public string Ucod1 { get; set; }
        [Required]
        [Column("UCOD_2")]
        [StringLength(6)]
        public string Ucod2 { get; set; }
        [Required]
        [Column("UCOD_3")]
        [StringLength(6)]
        public string Ucod3 { get; set; }
        [Required]
        [Column("UCOD_4")]
        [StringLength(6)]
        public string Ucod4 { get; set; }
        [Column("UMEN_0")]
        public short Umen0 { get; set; }
        [Column("UMEN_1")]
        public short Umen1 { get; set; }
        [Column("UMEN_2")]
        public short Umen2 { get; set; }
        [Column("UMEN_3")]
        public short Umen3 { get; set; }
        [Column("UMEN_4")]
        public short Umen4 { get; set; }
        [Required]
        [Column("UPRG_0")]
        [StringLength(30)]
        public string Uprg0 { get; set; }
        [Required]
        [Column("UPRG_1")]
        [StringLength(30)]
        public string Uprg1 { get; set; }
        [Required]
        [Column("UPRG_2")]
        [StringLength(30)]
        public string Uprg2 { get; set; }
        [Required]
        [Column("USPRG_0")]
        [StringLength(30)]
        public string Usprg0 { get; set; }
        [Required]
        [Column("USPRG_1")]
        [StringLength(30)]
        public string Usprg1 { get; set; }
        [Required]
        [Column("USPRG_2")]
        [StringLength(30)]
        public string Usprg2 { get; set; }
        [Required]
        [Column("UPARCOD_0")]
        [StringLength(6)]
        public string Uparcod0 { get; set; }
        [Required]
        [Column("UPARCOD_1")]
        [StringLength(6)]
        public string Uparcod1 { get; set; }
        [Required]
        [Column("UPARCOD_2")]
        [StringLength(6)]
        public string Uparcod2 { get; set; }
        [Required]
        [Column("UPARCOD_3")]
        [StringLength(6)]
        public string Uparcod3 { get; set; }
        [Required]
        [Column("UPARCOD_4")]
        [StringLength(6)]
        public string Uparcod4 { get; set; }
        [Required]
        [Column("UPARLIB_0")]
        [StringLength(30)]
        public string Uparlib0 { get; set; }
        [Required]
        [Column("UPARLIB_1")]
        [StringLength(30)]
        public string Uparlib1 { get; set; }
        [Required]
        [Column("UPARLIB_2")]
        [StringLength(30)]
        public string Uparlib2 { get; set; }
        [Required]
        [Column("UPARLIB_3")]
        [StringLength(30)]
        public string Uparlib3 { get; set; }
        [Required]
        [Column("UPARLIB_4")]
        [StringLength(30)]
        public string Uparlib4 { get; set; }
        [Required]
        [Column("UPARDEF_0")]
        [StringLength(10)]
        public string Upardef0 { get; set; }
        [Required]
        [Column("UPARDEF_1")]
        [StringLength(10)]
        public string Upardef1 { get; set; }
        [Required]
        [Column("UPARDEF_2")]
        [StringLength(10)]
        public string Upardef2 { get; set; }
        [Required]
        [Column("UPARDEF_3")]
        [StringLength(10)]
        public string Upardef3 { get; set; }
        [Required]
        [Column("UPARDEF_4")]
        [StringLength(10)]
        public string Upardef4 { get; set; }
        [Column("TYPXSL_0")]
        public byte Typxsl0 { get; set; }
        [Column("UPARMEN_0")]
        public byte Uparmen0 { get; set; }
        [Column("UPARMEN_1")]
        public byte Uparmen1 { get; set; }
        [Column("UPARMEN_2")]
        public byte Uparmen2 { get; set; }
        [Column("UPARMEN_3")]
        public byte Uparmen3 { get; set; }
        [Column("UPARMEN_4")]
        public byte Uparmen4 { get; set; }
        [Required]
        [Column("PARXSL_0")]
        [StringLength(10)]
        public string Parxsl0 { get; set; }
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
        [Required]
        [Column("XSLCLOB_0")]
        public string Xslclob0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}