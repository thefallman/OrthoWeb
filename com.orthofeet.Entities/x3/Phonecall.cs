﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PHONECALL", Schema = "TESTPROD")]
    [Index(nameof(Cllnum0), Name = "PHONECALL_CLL0", IsUnique = true)]
    [Index(nameof(Clldatx0), Name = "PHONECALL_CLL1")]
    [Index(nameof(Cllcmp0), Name = "PHONECALL_CLL2")]
    [Index(nameof(Cllccn0), Name = "PHONECALL_CLL3")]
    [Index(nameof(Cllrep0), nameof(Clldatx0), Name = "PHONECALL_CLL4")]
    [Index(nameof(Cllcmgnum0), Name = "PHONECALL_CLL5")]
    [Index(nameof(Cllopgtyp0), nameof(Cllopgnum0), Name = "PHONECALL_CLL6")]
    [Index(nameof(Cllori0), nameof(Cllorivcr0), nameof(Cllorivcrl0), Name = "PHONECALL_CLL7")]
    public partial class Phonecall
    {
        [Required]
        [Column("CLLNUM_0")]
        [StringLength(20)]
        public string Cllnum0 { get; set; }
        [Required]
        [Column("SALFCY_0")]
        [StringLength(5)]
        public string Salfcy0 { get; set; }
        [Required]
        [Column("CLLCMP_0")]
        [StringLength(15)]
        public string Cllcmp0 { get; set; }
        [Required]
        [Column("CLLOPP_0")]
        [StringLength(20)]
        public string Cllopp0 { get; set; }
        [Column("CLLDAT_0", TypeName = "datetime")]
        public DateTime Clldat0 { get; set; }
        [Required]
        [Column("CLLHOU_0")]
        [StringLength(5)]
        public string Cllhou0 { get; set; }
        [Column("CLLWEE_0")]
        public short Cllwee0 { get; set; }
        [Column("CLLDATX_0", TypeName = "datetime")]
        public DateTime Clldatx0 { get; set; }
        [Required]
        [Column("CLLCAT_0")]
        [StringLength(20)]
        public string Cllcat0 { get; set; }
        [Column("CLLTYP_0")]
        public byte Clltyp0 { get; set; }
        [Required]
        [Column("CLLCCN_0")]
        [StringLength(15)]
        public string Cllccn0 { get; set; }
        [Required]
        [Column("CLLCOR_0")]
        [StringLength(20)]
        public string Cllcor0 { get; set; }
        [Required]
        [Column("CLLCCNCRY_0")]
        [StringLength(3)]
        public string Cllccncry0 { get; set; }
        [Required]
        [Column("CLLETS_0")]
        [StringLength(20)]
        public string Cllets0 { get; set; }
        [Required]
        [Column("CLLMOB_0")]
        [StringLength(20)]
        public string Cllmob0 { get; set; }
        [Required]
        [Column("CLLOBJ_0")]
        [StringLength(250)]
        public string Cllobj0 { get; set; }
        [Required]
        [Column("TYPFULOBJ_0")]
        [StringLength(10)]
        public string Typfulobj0 { get; set; }
        [Required]
        [Column("NUMFULOBJ_0")]
        [StringLength(30)]
        public string Numfulobj0 { get; set; }
        [Column("OBJFLG_0")]
        public short Objflg0 { get; set; }
        [Column("CLLTNTPRE_0")]
        public short Clltntpre0 { get; set; }
        [Column("CLLDUR_0")]
        public short Clldur0 { get; set; }
        [Required]
        [Column("CLLREP_0")]
        [StringLength(15)]
        public string Cllrep0 { get; set; }
        [Required]
        [Column("CLLPIOLEV_0")]
        [StringLength(20)]
        public string Cllpiolev0 { get; set; }
        [Required]
        [Column("CLLCMGNUM_0")]
        [StringLength(20)]
        public string Cllcmgnum0 { get; set; }
        [Required]
        [Column("CLLOPGNUM_0")]
        [StringLength(20)]
        public string Cllopgnum0 { get; set; }
        [Required]
        [Column("CLLOPGTYP_0")]
        [StringLength(3)]
        public string Cllopgtyp0 { get; set; }
        [Column("CLLCMGFLG_0")]
        public short Cllcmgflg0 { get; set; }
        [Column("CLLDON_0")]
        public byte Clldon0 { get; set; }
        [Required]
        [Column("CLLRPO_0")]
        [StringLength(250)]
        public string Cllrpo0 { get; set; }
        [Required]
        [Column("TYPFULRPO_0")]
        [StringLength(10)]
        public string Typfulrpo0 { get; set; }
        [Required]
        [Column("NUMFULRPO_0")]
        [StringLength(30)]
        public string Numfulrpo0 { get; set; }
        [Column("RPOFLG_0")]
        public short Rpoflg0 { get; set; }
        [Required]
        [Column("CLLSAO_0")]
        [StringLength(20)]
        public string Cllsao0 { get; set; }
        [Column("CLLORI_0")]
        public byte Cllori0 { get; set; }
        [Required]
        [Column("CLLORIADI_0")]
        [StringLength(20)]
        public string Clloriadi0 { get; set; }
        [Required]
        [Column("CLLORIAOB_0")]
        [StringLength(3)]
        public string Clloriaob0 { get; set; }
        [Required]
        [Column("CLLORIVCR_0")]
        [StringLength(20)]
        public string Cllorivcr0 { get; set; }
        [Column("CLLORIVCRL_0")]
        public int Cllorivcrl0 { get; set; }
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
        [Column("CLLORITYP_0")]
        public byte Cllorityp0 { get; set; }
        [Required]
        [Column("CLLEML_0")]
        [StringLength(80)]
        public string Clleml0 { get; set; }
        [Required]
        [Column("CLLSCP_0")]
        [StringLength(20)]
        public string Cllscp0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}