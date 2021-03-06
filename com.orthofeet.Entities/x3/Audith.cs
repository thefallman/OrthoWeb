// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AUDITH", Schema = "TESTPROD")]
    [Index(nameof(Seq0), Name = "AUDITH_AUD0", IsUnique = true)]
    [Index(nameof(Sta0), nameof(Seq0), Name = "AUDITH_AUD1", IsUnique = true)]
    [Index(nameof(Adousr0), Name = "AUDITH_AUD2")]
    [Index(nameof(Stabi0), nameof(Seq0), Name = "AUDITH_AUD3", IsUnique = true)]
    public partial class Audith
    {
        [Column("SEQ_0")]
        public int Seq0 { get; set; }
        [Required]
        [Column("TBL_0")]
        [StringLength(12)]
        public string Tbl0 { get; set; }
        [Column("DAT_0", TypeName = "datetime")]
        public DateTime Dat0 { get; set; }
        [Required]
        [Column("HOU_0")]
        [StringLength(8)]
        public string Hou0 { get; set; }
        [Required]
        [Column("EVT_0")]
        [StringLength(10)]
        public string Evt0 { get; set; }
        [Required]
        [Column("ID1_0")]
        [StringLength(80)]
        public string Id10 { get; set; }
        [Required]
        [Column("ID2_0")]
        [StringLength(80)]
        public string Id20 { get; set; }
        [Required]
        [Column("ADOUSR_0")]
        [StringLength(5)]
        public string Adousr0 { get; set; }
        [Required]
        [Column("SYSUSR_0")]
        [StringLength(20)]
        public string Sysusr0 { get; set; }
        [Required]
        [Column("ADRCLI_0")]
        [StringLength(30)]
        public string Adrcli0 { get; set; }
        [Column("STA_0")]
        public byte Sta0 { get; set; }
        [Column("STABI_0")]
        public byte Stabi0 { get; set; }
        [Column("NUM1_0", TypeName = "numeric(14, 3)")]
        public decimal Num10 { get; set; }
        [Column("NUM2_0", TypeName = "numeric(14, 3)")]
        public decimal Num20 { get; set; }
        [Column("NUM3_0", TypeName = "numeric(14, 3)")]
        public decimal Num30 { get; set; }
        [Column("NUM4_0", TypeName = "numeric(14, 3)")]
        public decimal Num40 { get; set; }
        [Column("NUM5_0", TypeName = "numeric(14, 3)")]
        public decimal Num50 { get; set; }
        [Column("NUM6_0", TypeName = "numeric(14, 3)")]
        public decimal Num60 { get; set; }
        [Column("NUM7_0", TypeName = "numeric(14, 3)")]
        public decimal Num70 { get; set; }
        [Column("NUM8_0", TypeName = "numeric(14, 3)")]
        public decimal Num80 { get; set; }
        [Column("NUM9_0", TypeName = "numeric(14, 3)")]
        public decimal Num90 { get; set; }
        [Required]
        [Column("CHAR1_0")]
        [StringLength(80)]
        public string Char10 { get; set; }
        [Required]
        [Column("CHAR2_0")]
        [StringLength(80)]
        public string Char20 { get; set; }
        [Required]
        [Column("CHAR3_0")]
        [StringLength(80)]
        public string Char30 { get; set; }
        [Required]
        [Column("CHAR4_0")]
        [StringLength(80)]
        public string Char40 { get; set; }
        [Required]
        [Column("CHAR5_0")]
        [StringLength(80)]
        public string Char50 { get; set; }
        [Required]
        [Column("CHAR6_0")]
        [StringLength(80)]
        public string Char60 { get; set; }
        [Required]
        [Column("CHAR7_0")]
        [StringLength(80)]
        public string Char70 { get; set; }
        [Required]
        [Column("CHAR8_0")]
        [StringLength(80)]
        public string Char80 { get; set; }
        [Required]
        [Column("CHAR9_0")]
        [StringLength(80)]
        public string Char90 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}