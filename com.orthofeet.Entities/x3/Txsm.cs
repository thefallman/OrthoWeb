// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TXSM", Schema = "TESTPROD")]
    [Index(nameof(Txsnam0), nameof(Version0), nameof(Lig0), nameof(Col0), nameof(Ind0), Name = "TXSM_TXM0", IsUnique = true)]
    public partial class Txsm
    {
        [Required]
        [Column("TXSNAM_0")]
        [StringLength(10)]
        public string Txsnam0 { get; set; }
        [Required]
        [Column("VERSION_0")]
        [StringLength(15)]
        public string Version0 { get; set; }
        [Column("LIG_0")]
        public short Lig0 { get; set; }
        [Column("COL_0")]
        public short Col0 { get; set; }
        [Column("IND_0")]
        public int Ind0 { get; set; }
        [Required]
        [Column("AMTVAL_0")]
        [StringLength(50)]
        public string Amtval0 { get; set; }
        [Required]
        [Column("AMTDEB_0")]
        [StringLength(25)]
        public string Amtdeb0 { get; set; }
        [Required]
        [Column("AMTCDT_0")]
        [StringLength(25)]
        public string Amtcdt0 { get; set; }
        [Required]
        [Column("UPDVAL_0")]
        [StringLength(30)]
        public string Updval0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(15)]
        public string Bpr0 { get; set; }
        [Required]
        [Column("DIE1_0")]
        [StringLength(3)]
        public string Die10 { get; set; }
        [Required]
        [Column("DIE2_0")]
        [StringLength(3)]
        public string Die20 { get; set; }
        [Required]
        [Column("DIE3_0")]
        [StringLength(3)]
        public string Die30 { get; set; }
        [Required]
        [Column("DIE4_0")]
        [StringLength(3)]
        public string Die40 { get; set; }
        [Required]
        [Column("DIE5_0")]
        [StringLength(3)]
        public string Die50 { get; set; }
        [Required]
        [Column("DIE6_0")]
        [StringLength(3)]
        public string Die60 { get; set; }
        [Required]
        [Column("DIE7_0")]
        [StringLength(3)]
        public string Die70 { get; set; }
        [Required]
        [Column("DIE8_0")]
        [StringLength(3)]
        public string Die80 { get; set; }
        [Required]
        [Column("DIE9_0")]
        [StringLength(3)]
        public string Die90 { get; set; }
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
        [Column("FCYINF_0")]
        [StringLength(30)]
        public string Fcyinf0 { get; set; }
        [Required]
        [Column("ACCINF_0")]
        [StringLength(30)]
        public string Accinf0 { get; set; }
        [Required]
        [Column("BPRINF_0")]
        [StringLength(30)]
        public string Bprinf0 { get; set; }
        [Required]
        [Column("CCEINF_0")]
        [StringLength(30)]
        public string Cceinf0 { get; set; }
        [Column("TYPAMT_0")]
        public short Typamt0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}