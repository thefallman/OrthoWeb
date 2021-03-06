// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ALOGIN", Schema = "TESTPROD")]
    [Index(nameof(Bddid0), nameof(Flg0), Name = "ALOGIN_ALO0")]
    [Index(nameof(Seq0), Name = "ALOGIN_ALO1", IsUnique = true)]
    [Index(nameof(Adoid0), Name = "ALOGIN_ALO2")]
    public partial class Alogin
    {
        [Column("SEQ_0")]
        public int Seq0 { get; set; }
        [Required]
        [Column("ADOID_0")]
        [StringLength(10)]
        public string Adoid0 { get; set; }
        [Required]
        [Column("BDDID_0")]
        [StringLength(10)]
        public string Bddid0 { get; set; }
        [Required]
        [Column("ADOLOG_0")]
        [StringLength(20)]
        public string Adolog0 { get; set; }
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
        [Column("ADOTYP_0")]
        public byte Adotyp0 { get; set; }
        [Column("DATCNX_0", TypeName = "datetime")]
        public DateTime Datcnx0 { get; set; }
        [Required]
        [Column("HOUCNX_0")]
        [StringLength(8)]
        public string Houcnx0 { get; set; }
        [Column("DATDCX_0", TypeName = "datetime")]
        public DateTime Datdcx0 { get; set; }
        [Required]
        [Column("HOUDCX_0")]
        [StringLength(8)]
        public string Houdcx0 { get; set; }
        [Column("STA_0")]
        public short Sta0 { get; set; }
        [Required]
        [Column("MSG_0")]
        [StringLength(80)]
        public string Msg0 { get; set; }
        [Column("FLG_0")]
        public byte Flg0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}