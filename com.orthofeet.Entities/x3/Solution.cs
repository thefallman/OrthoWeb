﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SOLUTION", Schema = "TESTPROD")]
    [Index(nameof(Num0), Name = "SOLUTION_SOL0", IsUnique = true)]
    [Index(nameof(Srenum0), Name = "SOLUTION_SOL1")]
    public partial class Solution
    {
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Required]
        [Column("SRENUM_0")]
        [StringLength(20)]
        public string Srenum0 { get; set; }
        [Required]
        [Column("CAT_0")]
        [StringLength(20)]
        public string Cat0 { get; set; }
        [Required]
        [Column("PBLGRP_0")]
        [StringLength(20)]
        public string Pblgrp0 { get; set; }
        [Required]
        [Column("TTR_0")]
        [StringLength(80)]
        public string Ttr0 { get; set; }
        [Required]
        [Column("PBLDES_0")]
        [StringLength(250)]
        public string Pbldes0 { get; set; }
        [Column("PBLDESFLG_0")]
        public short Pbldesflg0 { get; set; }
        [Required]
        [Column("TYPPBLDES_0")]
        [StringLength(10)]
        public string Typpbldes0 { get; set; }
        [Required]
        [Column("NUMPBLDES_0")]
        [StringLength(30)]
        public string Numpbldes0 { get; set; }
        [Required]
        [Column("SOLDES_0")]
        [StringLength(250)]
        public string Soldes0 { get; set; }
        [Column("SOLDESFLG_0")]
        public short Soldesflg0 { get; set; }
        [Required]
        [Column("TYPSOLDES_0")]
        [StringLength(10)]
        public string Typsoldes0 { get; set; }
        [Required]
        [Column("NUMSOLDES_0")]
        [StringLength(30)]
        public string Numsoldes0 { get; set; }
        [Required]
        [Column("KEYWRD_0")]
        [StringLength(35)]
        public string Keywrd0 { get; set; }
        [Required]
        [Column("KEYWRD_1")]
        [StringLength(35)]
        public string Keywrd1 { get; set; }
        [Required]
        [Column("KEYWRD_2")]
        [StringLength(35)]
        public string Keywrd2 { get; set; }
        [Required]
        [Column("KEYWRD_3")]
        [StringLength(35)]
        public string Keywrd3 { get; set; }
        [Required]
        [Column("KEYWRD_4")]
        [StringLength(35)]
        public string Keywrd4 { get; set; }
        [Required]
        [Column("KEYWRD_5")]
        [StringLength(35)]
        public string Keywrd5 { get; set; }
        [Required]
        [Column("KEYWRD_6")]
        [StringLength(35)]
        public string Keywrd6 { get; set; }
        [Required]
        [Column("KEYWRD_7")]
        [StringLength(35)]
        public string Keywrd7 { get; set; }
        [Required]
        [Column("KEYWRD_8")]
        [StringLength(35)]
        public string Keywrd8 { get; set; }
        [Required]
        [Column("KEYWRD_9")]
        [StringLength(35)]
        public string Keywrd9 { get; set; }
        [Required]
        [Column("KEYWRD_10")]
        [StringLength(35)]
        public string Keywrd10 { get; set; }
        [Required]
        [Column("KEYWRD_11")]
        [StringLength(35)]
        public string Keywrd11 { get; set; }
        [Required]
        [Column("KEYWRD_12")]
        [StringLength(35)]
        public string Keywrd12 { get; set; }
        [Required]
        [Column("KEYWRD_13")]
        [StringLength(35)]
        public string Keywrd13 { get; set; }
        [Required]
        [Column("KEYWRD_14")]
        [StringLength(35)]
        public string Keywrd14 { get; set; }
        [Required]
        [Column("KEYWRD_15")]
        [StringLength(35)]
        public string Keywrd15 { get; set; }
        [Required]
        [Column("KEYWRD_16")]
        [StringLength(35)]
        public string Keywrd16 { get; set; }
        [Required]
        [Column("KEYWRD_17")]
        [StringLength(35)]
        public string Keywrd17 { get; set; }
        [Required]
        [Column("KEYWRD_18")]
        [StringLength(35)]
        public string Keywrd18 { get; set; }
        [Required]
        [Column("KEYWRD_19")]
        [StringLength(35)]
        public string Keywrd19 { get; set; }
        [Required]
        [Column("KEYWRD_20")]
        [StringLength(35)]
        public string Keywrd20 { get; set; }
        [Required]
        [Column("KEYWRD_21")]
        [StringLength(35)]
        public string Keywrd21 { get; set; }
        [Required]
        [Column("KEYWRD_22")]
        [StringLength(35)]
        public string Keywrd22 { get; set; }
        [Required]
        [Column("KEYWRD_23")]
        [StringLength(35)]
        public string Keywrd23 { get; set; }
        [Required]
        [Column("KEYWRD_24")]
        [StringLength(35)]
        public string Keywrd24 { get; set; }
        [Required]
        [Column("CODSOL_0")]
        [StringLength(20)]
        public string Codsol0 { get; set; }
        [Required]
        [Column("CODSOL_1")]
        [StringLength(20)]
        public string Codsol1 { get; set; }
        [Required]
        [Column("CODSOL_2")]
        [StringLength(20)]
        public string Codsol2 { get; set; }
        [Required]
        [Column("CODSOL_3")]
        [StringLength(20)]
        public string Codsol3 { get; set; }
        [Required]
        [Column("CODSOL_4")]
        [StringLength(20)]
        public string Codsol4 { get; set; }
        [Required]
        [Column("CODSOL_5")]
        [StringLength(20)]
        public string Codsol5 { get; set; }
        [Required]
        [Column("CODSOL_6")]
        [StringLength(20)]
        public string Codsol6 { get; set; }
        [Required]
        [Column("CODSOL_7")]
        [StringLength(20)]
        public string Codsol7 { get; set; }
        [Required]
        [Column("CODSOL_8")]
        [StringLength(20)]
        public string Codsol8 { get; set; }
        [Required]
        [Column("CODSOL_9")]
        [StringLength(20)]
        public string Codsol9 { get; set; }
        [Required]
        [Column("CODSOL_10")]
        [StringLength(20)]
        public string Codsol10 { get; set; }
        [Required]
        [Column("CODSOL_11")]
        [StringLength(20)]
        public string Codsol11 { get; set; }
        [Required]
        [Column("CODSOL_12")]
        [StringLength(20)]
        public string Codsol12 { get; set; }
        [Required]
        [Column("CODSOL_13")]
        [StringLength(20)]
        public string Codsol13 { get; set; }
        [Required]
        [Column("CODSOL_14")]
        [StringLength(20)]
        public string Codsol14 { get; set; }
        [Required]
        [Column("CODSOL_15")]
        [StringLength(20)]
        public string Codsol15 { get; set; }
        [Required]
        [Column("CODSOL_16")]
        [StringLength(20)]
        public string Codsol16 { get; set; }
        [Required]
        [Column("CODSOL_17")]
        [StringLength(20)]
        public string Codsol17 { get; set; }
        [Required]
        [Column("CODSOL_18")]
        [StringLength(20)]
        public string Codsol18 { get; set; }
        [Required]
        [Column("CODSOL_19")]
        [StringLength(20)]
        public string Codsol19 { get; set; }
        [Required]
        [Column("CODSOL_20")]
        [StringLength(20)]
        public string Codsol20 { get; set; }
        [Required]
        [Column("CODSOL_21")]
        [StringLength(20)]
        public string Codsol21 { get; set; }
        [Required]
        [Column("CODSOL_22")]
        [StringLength(20)]
        public string Codsol22 { get; set; }
        [Required]
        [Column("CODSOL_23")]
        [StringLength(20)]
        public string Codsol23 { get; set; }
        [Required]
        [Column("CODSOL_24")]
        [StringLength(20)]
        public string Codsol24 { get; set; }
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
        [Required]
        [Column("UPDHOU_0")]
        [StringLength(5)]
        public string Updhou0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}