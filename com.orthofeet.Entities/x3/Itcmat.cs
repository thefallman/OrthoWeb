﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ITCMAT", Schema = "TESTPROD")]
    [Index(nameof(Stofcy0), nameof(Itmref0), nameof(Csttyp0), nameof(Itcseq0), nameof(Matref0), nameof(Cpntyp0), nameof(Uid0), Name = "ITCMAT_ICC0", IsUnique = true)]
    public partial class Itcmat
    {
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("ITCSEQ_0")]
        public int Itcseq0 { get; set; }
        [Column("CSTTYP_0")]
        public byte Csttyp0 { get; set; }
        [Column("YEA_0")]
        public short Yea0 { get; set; }
        [Column("CSTSEQ_0")]
        public short Cstseq0 { get; set; }
        [Required]
        [Column("MATREF_0")]
        [StringLength(20)]
        public string Matref0 { get; set; }
        [Column("CPNTYP_0")]
        public byte Cpntyp0 { get; set; }
        [Column("UID_0")]
        public int Uid0 { get; set; }
        [Column("SCOFLG_0")]
        public byte Scoflg0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Column("QTYTOP_0", TypeName = "numeric(28, 13)")]
        public decimal Qtytop0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Column("MATFLG_0")]
        public byte Matflg0 { get; set; }
        [Column("BRDCOD_0")]
        public byte Brdcod0 { get; set; }
        [Column("CSTCOD_0")]
        public byte Cstcod0 { get; set; }
        [Column("MATCST_0", TypeName = "numeric(19, 5)")]
        public decimal Matcst0 { get; set; }
        [Column("MATCST_1", TypeName = "numeric(19, 5)")]
        public decimal Matcst1 { get; set; }
        [Column("MATCST_2", TypeName = "numeric(19, 5)")]
        public decimal Matcst2 { get; set; }
        [Column("MATCST_3", TypeName = "numeric(19, 5)")]
        public decimal Matcst3 { get; set; }
        [Column("MATCST_4", TypeName = "numeric(19, 5)")]
        public decimal Matcst4 { get; set; }
        [Column("MATCST_5", TypeName = "numeric(19, 5)")]
        public decimal Matcst5 { get; set; }
        [Column("MATCST_6", TypeName = "numeric(19, 5)")]
        public decimal Matcst6 { get; set; }
        [Column("MATCST_7", TypeName = "numeric(19, 5)")]
        public decimal Matcst7 { get; set; }
        [Column("MATCST_8", TypeName = "numeric(19, 5)")]
        public decimal Matcst8 { get; set; }
        [Column("MATCST_9", TypeName = "numeric(19, 5)")]
        public decimal Matcst9 { get; set; }
        [Column("MATCST_10", TypeName = "numeric(19, 5)")]
        public decimal Matcst10 { get; set; }
        [Column("MATCST_11", TypeName = "numeric(19, 5)")]
        public decimal Matcst11 { get; set; }
        [Column("MATCST_12", TypeName = "numeric(19, 5)")]
        public decimal Matcst12 { get; set; }
        [Column("MATCST_13", TypeName = "numeric(19, 5)")]
        public decimal Matcst13 { get; set; }
        [Column("MATCST_14", TypeName = "numeric(19, 5)")]
        public decimal Matcst14 { get; set; }
        [Column("MATCST_15", TypeName = "numeric(19, 5)")]
        public decimal Matcst15 { get; set; }
        [Column("MATCST_16", TypeName = "numeric(19, 5)")]
        public decimal Matcst16 { get; set; }
        [Column("MATCST_17", TypeName = "numeric(19, 5)")]
        public decimal Matcst17 { get; set; }
        [Column("MATCST_18", TypeName = "numeric(19, 5)")]
        public decimal Matcst18 { get; set; }
        [Column("MATCST_19", TypeName = "numeric(19, 5)")]
        public decimal Matcst19 { get; set; }
        [Column("MACCST_0", TypeName = "numeric(19, 5)")]
        public decimal Maccst0 { get; set; }
        [Column("MACCST_1", TypeName = "numeric(19, 5)")]
        public decimal Maccst1 { get; set; }
        [Column("MACCST_2", TypeName = "numeric(19, 5)")]
        public decimal Maccst2 { get; set; }
        [Column("MACCST_3", TypeName = "numeric(19, 5)")]
        public decimal Maccst3 { get; set; }
        [Column("MACCST_4", TypeName = "numeric(19, 5)")]
        public decimal Maccst4 { get; set; }
        [Column("MACCST_5", TypeName = "numeric(19, 5)")]
        public decimal Maccst5 { get; set; }
        [Column("MACCST_6", TypeName = "numeric(19, 5)")]
        public decimal Maccst6 { get; set; }
        [Column("MACCST_7", TypeName = "numeric(19, 5)")]
        public decimal Maccst7 { get; set; }
        [Column("MACCST_8", TypeName = "numeric(19, 5)")]
        public decimal Maccst8 { get; set; }
        [Column("MACCST_9", TypeName = "numeric(19, 5)")]
        public decimal Maccst9 { get; set; }
        [Column("MACCST_10", TypeName = "numeric(19, 5)")]
        public decimal Maccst10 { get; set; }
        [Column("MACCST_11", TypeName = "numeric(19, 5)")]
        public decimal Maccst11 { get; set; }
        [Column("MACCST_12", TypeName = "numeric(19, 5)")]
        public decimal Maccst12 { get; set; }
        [Column("MACCST_13", TypeName = "numeric(19, 5)")]
        public decimal Maccst13 { get; set; }
        [Column("MACCST_14", TypeName = "numeric(19, 5)")]
        public decimal Maccst14 { get; set; }
        [Column("LABCST_0", TypeName = "numeric(19, 5)")]
        public decimal Labcst0 { get; set; }
        [Column("LABCST_1", TypeName = "numeric(19, 5)")]
        public decimal Labcst1 { get; set; }
        [Column("LABCST_2", TypeName = "numeric(19, 5)")]
        public decimal Labcst2 { get; set; }
        [Column("LABCST_3", TypeName = "numeric(19, 5)")]
        public decimal Labcst3 { get; set; }
        [Column("LABCST_4", TypeName = "numeric(19, 5)")]
        public decimal Labcst4 { get; set; }
        [Column("LABCST_5", TypeName = "numeric(19, 5)")]
        public decimal Labcst5 { get; set; }
        [Column("LABCST_6", TypeName = "numeric(19, 5)")]
        public decimal Labcst6 { get; set; }
        [Column("LABCST_7", TypeName = "numeric(19, 5)")]
        public decimal Labcst7 { get; set; }
        [Column("LABCST_8", TypeName = "numeric(19, 5)")]
        public decimal Labcst8 { get; set; }
        [Column("LABCST_9", TypeName = "numeric(19, 5)")]
        public decimal Labcst9 { get; set; }
        [Column("LABCST_10", TypeName = "numeric(19, 5)")]
        public decimal Labcst10 { get; set; }
        [Column("LABCST_11", TypeName = "numeric(19, 5)")]
        public decimal Labcst11 { get; set; }
        [Column("LABCST_12", TypeName = "numeric(19, 5)")]
        public decimal Labcst12 { get; set; }
        [Column("LABCST_13", TypeName = "numeric(19, 5)")]
        public decimal Labcst13 { get; set; }
        [Column("LABCST_14", TypeName = "numeric(19, 5)")]
        public decimal Labcst14 { get; set; }
        [Column("SCOCST_0", TypeName = "numeric(19, 5)")]
        public decimal Scocst0 { get; set; }
        [Column("INVDTACST_0", TypeName = "numeric(19, 5)")]
        public decimal Invdtacst0 { get; set; }
        [Column("OVEMATCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovematcst0 { get; set; }
        [Column("OVEMACCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovemaccst0 { get; set; }
        [Column("OVELABCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovelabcst0 { get; set; }
        [Column("OVESCOCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovescocst0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
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
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}