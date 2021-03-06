// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("MFGWIP", Schema = "TESTPROD")]
    [Index(nameof(Vcrtyp0), nameof(Vcrnum0), Name = "MFGWIP_MWH0", IsUnique = true)]
    [Index(nameof(Trktyp0), nameof(Strdat0), Name = "MFGWIP_MWH1")]
    public partial class Mfgwip
    {
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Required]
        [Column("MFGFCY_0")]
        [StringLength(5)]
        public string Mfgfcy0 { get; set; }
        [Column("TRKTYP_0")]
        public byte Trktyp0 { get; set; }
        [Column("STRDAT_0", TypeName = "datetime")]
        public DateTime Strdat0 { get; set; }
        [Column("ENDDAT_0", TypeName = "datetime")]
        public DateTime Enddat0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Column("CPLQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Cplqty0 { get; set; }
        [Column("REJCPLQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Rejcplqty0 { get; set; }
        [Column("QUACPLQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Quacplqty0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("BOMALT_0")]
        public short Bomalt0 { get; set; }
        [Column("BOMALTTYP_0")]
        public byte Bomalttyp0 { get; set; }
        [Required]
        [Column("ROUNUM_0")]
        [StringLength(20)]
        public string Rounum0 { get; set; }
        [Column("ROUALT_0")]
        public short Roualt0 { get; set; }
        [Required]
        [Column("WST_0")]
        [StringLength(8)]
        public string Wst0 { get; set; }
        [Column("MFGTRKFLG_0")]
        public byte Mfgtrkflg0 { get; set; }
        [Column("TRKFIRST_0", TypeName = "datetime")]
        public DateTime Trkfirst0 { get; set; }
        [Column("TRKLAST_0", TypeName = "datetime")]
        public DateTime Trklast0 { get; set; }
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