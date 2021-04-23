﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("CADSP", Schema = "TESTPROD")]
    [Index(nameof(Dsp0), nameof(Nbrdsp0), Name = "CADSP_DSP0", IsUnique = true)]
    public partial class Cadsp
    {
        [Required]
        [Column("DSP_0")]
        [StringLength(10)]
        public string Dsp0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Required]
        [Column("DESSHO_0")]
        [StringLength(10)]
        public string Dessho0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("ACS_0")]
        [StringLength(10)]
        public string Acs0 { get; set; }
        [Column("VLYSTR_0", TypeName = "datetime")]
        public DateTime Vlystr0 { get; set; }
        [Column("VLYEND_0", TypeName = "datetime")]
        public DateTime Vlyend0 { get; set; }
        [Column("NBRDIE_0")]
        public short Nbrdie0 { get; set; }
        [Required]
        [Column("DIE_0")]
        [StringLength(3)]
        public string Die0 { get; set; }
        [Required]
        [Column("DIE_1")]
        [StringLength(3)]
        public string Die1 { get; set; }
        [Required]
        [Column("DIE_2")]
        [StringLength(3)]
        public string Die2 { get; set; }
        [Required]
        [Column("DIE_3")]
        [StringLength(3)]
        public string Die3 { get; set; }
        [Required]
        [Column("DIE_4")]
        [StringLength(3)]
        public string Die4 { get; set; }
        [Required]
        [Column("DIE_5")]
        [StringLength(3)]
        public string Die5 { get; set; }
        [Required]
        [Column("DIE_6")]
        [StringLength(3)]
        public string Die6 { get; set; }
        [Required]
        [Column("DIE_7")]
        [StringLength(3)]
        public string Die7 { get; set; }
        [Required]
        [Column("DIE_8")]
        [StringLength(3)]
        public string Die8 { get; set; }
        [Required]
        [Column("DIE_9")]
        [StringLength(3)]
        public string Die9 { get; set; }
        [Required]
        [Column("DIE_10")]
        [StringLength(3)]
        public string Die10 { get; set; }
        [Required]
        [Column("DIE_11")]
        [StringLength(3)]
        public string Die11 { get; set; }
        [Required]
        [Column("DIE_12")]
        [StringLength(3)]
        public string Die12 { get; set; }
        [Required]
        [Column("DIE_13")]
        [StringLength(3)]
        public string Die13 { get; set; }
        [Required]
        [Column("DIE_14")]
        [StringLength(3)]
        public string Die14 { get; set; }
        [Required]
        [Column("DIE_15")]
        [StringLength(3)]
        public string Die15 { get; set; }
        [Required]
        [Column("DIE_16")]
        [StringLength(3)]
        public string Die16 { get; set; }
        [Required]
        [Column("DIE_17")]
        [StringLength(3)]
        public string Die17 { get; set; }
        [Required]
        [Column("DIE_18")]
        [StringLength(3)]
        public string Die18 { get; set; }
        [Required]
        [Column("DIE_19")]
        [StringLength(3)]
        public string Die19 { get; set; }
        [Column("NBRDSP_0")]
        public short Nbrdsp0 { get; set; }
        [Column("COE_0", TypeName = "numeric(17, 8)")]
        public decimal Coe0 { get; set; }
        [Required]
        [Column("CCE1_0")]
        [StringLength(15)]
        public string Cce10 { get; set; }
        [Required]
        [Column("CCE2_0")]
        [StringLength(15)]
        public string Cce20 { get; set; }
        [Required]
        [Column("CCE3_0")]
        [StringLength(15)]
        public string Cce30 { get; set; }
        [Required]
        [Column("CCE4_0")]
        [StringLength(15)]
        public string Cce40 { get; set; }
        [Required]
        [Column("CCE5_0")]
        [StringLength(15)]
        public string Cce50 { get; set; }
        [Required]
        [Column("CCE6_0")]
        [StringLength(15)]
        public string Cce60 { get; set; }
        [Required]
        [Column("CCE7_0")]
        [StringLength(15)]
        public string Cce70 { get; set; }
        [Required]
        [Column("CCE8_0")]
        [StringLength(15)]
        public string Cce80 { get; set; }
        [Required]
        [Column("CCE9_0")]
        [StringLength(15)]
        public string Cce90 { get; set; }
        [Required]
        [Column("CCE10_0")]
        [StringLength(15)]
        public string Cce100 { get; set; }
        [Required]
        [Column("CCE11_0")]
        [StringLength(15)]
        public string Cce110 { get; set; }
        [Required]
        [Column("CCE12_0")]
        [StringLength(15)]
        public string Cce120 { get; set; }
        [Required]
        [Column("CCE13_0")]
        [StringLength(15)]
        public string Cce130 { get; set; }
        [Required]
        [Column("CCE14_0")]
        [StringLength(15)]
        public string Cce140 { get; set; }
        [Required]
        [Column("CCE15_0")]
        [StringLength(15)]
        public string Cce150 { get; set; }
        [Required]
        [Column("CCE16_0")]
        [StringLength(15)]
        public string Cce160 { get; set; }
        [Required]
        [Column("CCE17_0")]
        [StringLength(15)]
        public string Cce170 { get; set; }
        [Required]
        [Column("CCE18_0")]
        [StringLength(15)]
        public string Cce180 { get; set; }
        [Required]
        [Column("CCE19_0")]
        [StringLength(15)]
        public string Cce190 { get; set; }
        [Required]
        [Column("CCE20_0")]
        [StringLength(15)]
        public string Cce200 { get; set; }
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
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}