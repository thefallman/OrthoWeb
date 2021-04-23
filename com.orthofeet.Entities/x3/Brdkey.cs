﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BRDKEY", Schema = "TESTPROD")]
    [Index(nameof(Cpy0), nameof(Brdref0), nameof(Dspkey0), Name = "BRDKEY_BRD0", IsUnique = true)]
    [Index(nameof(Cpy0), nameof(Brdref0), Name = "BRDKEY_BRD1", IsUnique = true)]
    public partial class Brdkey
    {
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("BRDREF_0")]
        [StringLength(20)]
        public string Brdref0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(60)]
        public string Des0 { get; set; }
        [Column("DSPKEY_0")]
        public byte Dspkey0 { get; set; }
        [Column("CHAMP1_0")]
        public byte Champ10 { get; set; }
        [Column("CHAMP2_0")]
        public byte Champ20 { get; set; }
        [Column("CHAMP3_0")]
        public byte Champ30 { get; set; }
        [Column("NBVAL_0")]
        public short Nbval0 { get; set; }
        [Required]
        [Column("VALKEY_0")]
        [StringLength(10)]
        public string Valkey0 { get; set; }
        [Required]
        [Column("VALKEY_1")]
        [StringLength(10)]
        public string Valkey1 { get; set; }
        [Required]
        [Column("VALKEY_2")]
        [StringLength(10)]
        public string Valkey2 { get; set; }
        [Required]
        [Column("VALKEY_3")]
        [StringLength(10)]
        public string Valkey3 { get; set; }
        [Required]
        [Column("VALKEY_4")]
        [StringLength(10)]
        public string Valkey4 { get; set; }
        [Required]
        [Column("VALKEY_5")]
        [StringLength(10)]
        public string Valkey5 { get; set; }
        [Required]
        [Column("VALKEY_6")]
        [StringLength(10)]
        public string Valkey6 { get; set; }
        [Required]
        [Column("VALKEY_7")]
        [StringLength(10)]
        public string Valkey7 { get; set; }
        [Required]
        [Column("VALKEY_8")]
        [StringLength(10)]
        public string Valkey8 { get; set; }
        [Required]
        [Column("VALKEY_9")]
        [StringLength(10)]
        public string Valkey9 { get; set; }
        [Required]
        [Column("VALKEY_10")]
        [StringLength(10)]
        public string Valkey10 { get; set; }
        [Required]
        [Column("VALKEY_11")]
        [StringLength(10)]
        public string Valkey11 { get; set; }
        [Required]
        [Column("VALKEY_12")]
        [StringLength(10)]
        public string Valkey12 { get; set; }
        [Required]
        [Column("VALKEY_13")]
        [StringLength(10)]
        public string Valkey13 { get; set; }
        [Required]
        [Column("VALKEY_14")]
        [StringLength(10)]
        public string Valkey14 { get; set; }
        [Required]
        [Column("VALKEY_15")]
        [StringLength(10)]
        public string Valkey15 { get; set; }
        [Required]
        [Column("VALKEY_16")]
        [StringLength(10)]
        public string Valkey16 { get; set; }
        [Required]
        [Column("VALKEY_17")]
        [StringLength(10)]
        public string Valkey17 { get; set; }
        [Required]
        [Column("VALKEY_18")]
        [StringLength(10)]
        public string Valkey18 { get; set; }
        [Required]
        [Column("VALKEY_19")]
        [StringLength(10)]
        public string Valkey19 { get; set; }
        [Required]
        [Column("VALKEY_20")]
        [StringLength(10)]
        public string Valkey20 { get; set; }
        [Required]
        [Column("VALKEY_21")]
        [StringLength(10)]
        public string Valkey21 { get; set; }
        [Required]
        [Column("VALKEY_22")]
        [StringLength(10)]
        public string Valkey22 { get; set; }
        [Required]
        [Column("VALKEY_23")]
        [StringLength(10)]
        public string Valkey23 { get; set; }
        [Required]
        [Column("VALKEY_24")]
        [StringLength(10)]
        public string Valkey24 { get; set; }
        [Required]
        [Column("VALKEY_25")]
        [StringLength(10)]
        public string Valkey25 { get; set; }
        [Required]
        [Column("VALKEY_26")]
        [StringLength(10)]
        public string Valkey26 { get; set; }
        [Required]
        [Column("VALKEY_27")]
        [StringLength(10)]
        public string Valkey27 { get; set; }
        [Required]
        [Column("VALKEY_28")]
        [StringLength(10)]
        public string Valkey28 { get; set; }
        [Required]
        [Column("VALKEY_29")]
        [StringLength(10)]
        public string Valkey29 { get; set; }
        [Column("BRDPRC_0", TypeName = "numeric(8, 3)")]
        public decimal Brdprc0 { get; set; }
        [Column("BRDPRC_1", TypeName = "numeric(8, 3)")]
        public decimal Brdprc1 { get; set; }
        [Column("BRDPRC_2", TypeName = "numeric(8, 3)")]
        public decimal Brdprc2 { get; set; }
        [Column("BRDPRC_3", TypeName = "numeric(8, 3)")]
        public decimal Brdprc3 { get; set; }
        [Column("BRDPRC_4", TypeName = "numeric(8, 3)")]
        public decimal Brdprc4 { get; set; }
        [Column("BRDPRC_5", TypeName = "numeric(8, 3)")]
        public decimal Brdprc5 { get; set; }
        [Column("BRDPRC_6", TypeName = "numeric(8, 3)")]
        public decimal Brdprc6 { get; set; }
        [Column("BRDPRC_7", TypeName = "numeric(8, 3)")]
        public decimal Brdprc7 { get; set; }
        [Column("BRDPRC_8", TypeName = "numeric(8, 3)")]
        public decimal Brdprc8 { get; set; }
        [Column("BRDPRC_9", TypeName = "numeric(8, 3)")]
        public decimal Brdprc9 { get; set; }
        [Column("BRDPRC_10", TypeName = "numeric(8, 3)")]
        public decimal Brdprc10 { get; set; }
        [Column("BRDPRC_11", TypeName = "numeric(8, 3)")]
        public decimal Brdprc11 { get; set; }
        [Column("BRDPRC_12", TypeName = "numeric(8, 3)")]
        public decimal Brdprc12 { get; set; }
        [Column("BRDPRC_13", TypeName = "numeric(8, 3)")]
        public decimal Brdprc13 { get; set; }
        [Column("BRDPRC_14", TypeName = "numeric(8, 3)")]
        public decimal Brdprc14 { get; set; }
        [Column("BRDPRC_15", TypeName = "numeric(8, 3)")]
        public decimal Brdprc15 { get; set; }
        [Column("BRDPRC_16", TypeName = "numeric(8, 3)")]
        public decimal Brdprc16 { get; set; }
        [Column("BRDPRC_17", TypeName = "numeric(8, 3)")]
        public decimal Brdprc17 { get; set; }
        [Column("BRDPRC_18", TypeName = "numeric(8, 3)")]
        public decimal Brdprc18 { get; set; }
        [Column("BRDPRC_19", TypeName = "numeric(8, 3)")]
        public decimal Brdprc19 { get; set; }
        [Column("BRDPRC_20", TypeName = "numeric(8, 3)")]
        public decimal Brdprc20 { get; set; }
        [Column("BRDPRC_21", TypeName = "numeric(8, 3)")]
        public decimal Brdprc21 { get; set; }
        [Column("BRDPRC_22", TypeName = "numeric(8, 3)")]
        public decimal Brdprc22 { get; set; }
        [Column("BRDPRC_23", TypeName = "numeric(8, 3)")]
        public decimal Brdprc23 { get; set; }
        [Column("BRDPRC_24", TypeName = "numeric(8, 3)")]
        public decimal Brdprc24 { get; set; }
        [Column("BRDPRC_25", TypeName = "numeric(8, 3)")]
        public decimal Brdprc25 { get; set; }
        [Column("BRDPRC_26", TypeName = "numeric(8, 3)")]
        public decimal Brdprc26 { get; set; }
        [Column("BRDPRC_27", TypeName = "numeric(8, 3)")]
        public decimal Brdprc27 { get; set; }
        [Column("BRDPRC_28", TypeName = "numeric(8, 3)")]
        public decimal Brdprc28 { get; set; }
        [Column("BRDPRC_29", TypeName = "numeric(8, 3)")]
        public decimal Brdprc29 { get; set; }
        [Required]
        [Column("VAL1_0")]
        [StringLength(30)]
        public string Val10 { get; set; }
        [Required]
        [Column("VAL1_1")]
        [StringLength(30)]
        public string Val11 { get; set; }
        [Required]
        [Column("VAL1_2")]
        [StringLength(30)]
        public string Val12 { get; set; }
        [Required]
        [Column("VAL1_3")]
        [StringLength(30)]
        public string Val13 { get; set; }
        [Required]
        [Column("VAL1_4")]
        [StringLength(30)]
        public string Val14 { get; set; }
        [Required]
        [Column("VAL1_5")]
        [StringLength(30)]
        public string Val15 { get; set; }
        [Required]
        [Column("VAL1_6")]
        [StringLength(30)]
        public string Val16 { get; set; }
        [Required]
        [Column("VAL1_7")]
        [StringLength(30)]
        public string Val17 { get; set; }
        [Required]
        [Column("VAL1_8")]
        [StringLength(30)]
        public string Val18 { get; set; }
        [Required]
        [Column("VAL1_9")]
        [StringLength(30)]
        public string Val19 { get; set; }
        [Required]
        [Column("VAL1_10")]
        [StringLength(30)]
        public string Val110 { get; set; }
        [Required]
        [Column("VAL1_11")]
        [StringLength(30)]
        public string Val111 { get; set; }
        [Required]
        [Column("VAL1_12")]
        [StringLength(30)]
        public string Val112 { get; set; }
        [Required]
        [Column("VAL1_13")]
        [StringLength(30)]
        public string Val113 { get; set; }
        [Required]
        [Column("VAL1_14")]
        [StringLength(30)]
        public string Val114 { get; set; }
        [Required]
        [Column("VAL1_15")]
        [StringLength(30)]
        public string Val115 { get; set; }
        [Required]
        [Column("VAL1_16")]
        [StringLength(30)]
        public string Val116 { get; set; }
        [Required]
        [Column("VAL1_17")]
        [StringLength(30)]
        public string Val117 { get; set; }
        [Required]
        [Column("VAL1_18")]
        [StringLength(30)]
        public string Val118 { get; set; }
        [Required]
        [Column("VAL1_19")]
        [StringLength(30)]
        public string Val119 { get; set; }
        [Required]
        [Column("VAL1_20")]
        [StringLength(30)]
        public string Val120 { get; set; }
        [Required]
        [Column("VAL1_21")]
        [StringLength(30)]
        public string Val121 { get; set; }
        [Required]
        [Column("VAL1_22")]
        [StringLength(30)]
        public string Val122 { get; set; }
        [Required]
        [Column("VAL1_23")]
        [StringLength(30)]
        public string Val123 { get; set; }
        [Required]
        [Column("VAL1_24")]
        [StringLength(30)]
        public string Val124 { get; set; }
        [Required]
        [Column("VAL1_25")]
        [StringLength(30)]
        public string Val125 { get; set; }
        [Required]
        [Column("VAL1_26")]
        [StringLength(30)]
        public string Val126 { get; set; }
        [Required]
        [Column("VAL1_27")]
        [StringLength(30)]
        public string Val127 { get; set; }
        [Required]
        [Column("VAL1_28")]
        [StringLength(30)]
        public string Val128 { get; set; }
        [Required]
        [Column("VAL1_29")]
        [StringLength(30)]
        public string Val129 { get; set; }
        [Required]
        [Column("VAL2_0")]
        [StringLength(30)]
        public string Val20 { get; set; }
        [Required]
        [Column("VAL2_1")]
        [StringLength(30)]
        public string Val21 { get; set; }
        [Required]
        [Column("VAL2_2")]
        [StringLength(30)]
        public string Val22 { get; set; }
        [Required]
        [Column("VAL2_3")]
        [StringLength(30)]
        public string Val23 { get; set; }
        [Required]
        [Column("VAL2_4")]
        [StringLength(30)]
        public string Val24 { get; set; }
        [Required]
        [Column("VAL2_5")]
        [StringLength(30)]
        public string Val25 { get; set; }
        [Required]
        [Column("VAL2_6")]
        [StringLength(30)]
        public string Val26 { get; set; }
        [Required]
        [Column("VAL2_7")]
        [StringLength(30)]
        public string Val27 { get; set; }
        [Required]
        [Column("VAL2_8")]
        [StringLength(30)]
        public string Val28 { get; set; }
        [Required]
        [Column("VAL2_9")]
        [StringLength(30)]
        public string Val29 { get; set; }
        [Required]
        [Column("VAL2_10")]
        [StringLength(30)]
        public string Val210 { get; set; }
        [Required]
        [Column("VAL2_11")]
        [StringLength(30)]
        public string Val211 { get; set; }
        [Required]
        [Column("VAL2_12")]
        [StringLength(30)]
        public string Val212 { get; set; }
        [Required]
        [Column("VAL2_13")]
        [StringLength(30)]
        public string Val213 { get; set; }
        [Required]
        [Column("VAL2_14")]
        [StringLength(30)]
        public string Val214 { get; set; }
        [Required]
        [Column("VAL2_15")]
        [StringLength(30)]
        public string Val215 { get; set; }
        [Required]
        [Column("VAL2_16")]
        [StringLength(30)]
        public string Val216 { get; set; }
        [Required]
        [Column("VAL2_17")]
        [StringLength(30)]
        public string Val217 { get; set; }
        [Required]
        [Column("VAL2_18")]
        [StringLength(30)]
        public string Val218 { get; set; }
        [Required]
        [Column("VAL2_19")]
        [StringLength(30)]
        public string Val219 { get; set; }
        [Required]
        [Column("VAL2_20")]
        [StringLength(30)]
        public string Val220 { get; set; }
        [Required]
        [Column("VAL2_21")]
        [StringLength(30)]
        public string Val221 { get; set; }
        [Required]
        [Column("VAL2_22")]
        [StringLength(30)]
        public string Val222 { get; set; }
        [Required]
        [Column("VAL2_23")]
        [StringLength(30)]
        public string Val223 { get; set; }
        [Required]
        [Column("VAL2_24")]
        [StringLength(30)]
        public string Val224 { get; set; }
        [Required]
        [Column("VAL2_25")]
        [StringLength(30)]
        public string Val225 { get; set; }
        [Required]
        [Column("VAL2_26")]
        [StringLength(30)]
        public string Val226 { get; set; }
        [Required]
        [Column("VAL2_27")]
        [StringLength(30)]
        public string Val227 { get; set; }
        [Required]
        [Column("VAL2_28")]
        [StringLength(30)]
        public string Val228 { get; set; }
        [Required]
        [Column("VAL2_29")]
        [StringLength(30)]
        public string Val229 { get; set; }
        [Required]
        [Column("VAL3_0")]
        [StringLength(30)]
        public string Val30 { get; set; }
        [Required]
        [Column("VAL3_1")]
        [StringLength(30)]
        public string Val31 { get; set; }
        [Required]
        [Column("VAL3_2")]
        [StringLength(30)]
        public string Val32 { get; set; }
        [Required]
        [Column("VAL3_3")]
        [StringLength(30)]
        public string Val33 { get; set; }
        [Required]
        [Column("VAL3_4")]
        [StringLength(30)]
        public string Val34 { get; set; }
        [Required]
        [Column("VAL3_5")]
        [StringLength(30)]
        public string Val35 { get; set; }
        [Required]
        [Column("VAL3_6")]
        [StringLength(30)]
        public string Val36 { get; set; }
        [Required]
        [Column("VAL3_7")]
        [StringLength(30)]
        public string Val37 { get; set; }
        [Required]
        [Column("VAL3_8")]
        [StringLength(30)]
        public string Val38 { get; set; }
        [Required]
        [Column("VAL3_9")]
        [StringLength(30)]
        public string Val39 { get; set; }
        [Required]
        [Column("VAL3_10")]
        [StringLength(30)]
        public string Val310 { get; set; }
        [Required]
        [Column("VAL3_11")]
        [StringLength(30)]
        public string Val311 { get; set; }
        [Required]
        [Column("VAL3_12")]
        [StringLength(30)]
        public string Val312 { get; set; }
        [Required]
        [Column("VAL3_13")]
        [StringLength(30)]
        public string Val313 { get; set; }
        [Required]
        [Column("VAL3_14")]
        [StringLength(30)]
        public string Val314 { get; set; }
        [Required]
        [Column("VAL3_15")]
        [StringLength(30)]
        public string Val315 { get; set; }
        [Required]
        [Column("VAL3_16")]
        [StringLength(30)]
        public string Val316 { get; set; }
        [Required]
        [Column("VAL3_17")]
        [StringLength(30)]
        public string Val317 { get; set; }
        [Required]
        [Column("VAL3_18")]
        [StringLength(30)]
        public string Val318 { get; set; }
        [Required]
        [Column("VAL3_19")]
        [StringLength(30)]
        public string Val319 { get; set; }
        [Required]
        [Column("VAL3_20")]
        [StringLength(30)]
        public string Val320 { get; set; }
        [Required]
        [Column("VAL3_21")]
        [StringLength(30)]
        public string Val321 { get; set; }
        [Required]
        [Column("VAL3_22")]
        [StringLength(30)]
        public string Val322 { get; set; }
        [Required]
        [Column("VAL3_23")]
        [StringLength(30)]
        public string Val323 { get; set; }
        [Required]
        [Column("VAL3_24")]
        [StringLength(30)]
        public string Val324 { get; set; }
        [Required]
        [Column("VAL3_25")]
        [StringLength(30)]
        public string Val325 { get; set; }
        [Required]
        [Column("VAL3_26")]
        [StringLength(30)]
        public string Val326 { get; set; }
        [Required]
        [Column("VAL3_27")]
        [StringLength(30)]
        public string Val327 { get; set; }
        [Required]
        [Column("VAL3_28")]
        [StringLength(30)]
        public string Val328 { get; set; }
        [Required]
        [Column("VAL3_29")]
        [StringLength(30)]
        public string Val329 { get; set; }
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