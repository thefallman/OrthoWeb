// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("STOREO", Schema = "TESTPROD")]
    [Index(nameof(Stofcy0), nameof(Loc0), nameof(Itmref0), Name = "STOREO_REO0", IsUnique = true)]
    [Index(nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vcrlin0), Name = "STOREO_REO1")]
    public partial class Storeo
    {
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("LOCCAT_0")]
        public byte Loccat0 { get; set; }
        [Required]
        [Column("LOC_0")]
        [StringLength(10)]
        public string Loc0 { get; set; }
        [Required]
        [Column("WRH_0")]
        [StringLength(1)]
        public string Wrh0 { get; set; }
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Required]
        [Column("PCU_0")]
        [StringLength(3)]
        public string Pcu0 { get; set; }
        [Column("QTYPCU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypcu0 { get; set; }
        [Column("DEFPOT_0", TypeName = "numeric(14, 5)")]
        public decimal Defpot0 { get; set; }
        [Column("PCUSTUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Pcustucoe0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Column("QTYSTUACT_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystuact0 { get; set; }
        [Column("BESDAT_0", TypeName = "datetime")]
        public DateTime Besdat0 { get; set; }
        [Column("STAFLG_0")]
        public byte Staflg0 { get; set; }
        [Required]
        [Column("BPRNUM_0")]
        [StringLength(15)]
        public string Bprnum0 { get; set; }
        [Required]
        [Column("BPAADD_0")]
        [StringLength(7)]
        public string Bpaadd0 { get; set; }
        [Column("QTYSTUORIA_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystuoria0 { get; set; }
        [Column("CLEFLG_0")]
        public byte Cleflg0 { get; set; }
        [Required]
        [Column("PROTIM_0")]
        [StringLength(5)]
        public string Protim0 { get; set; }
        [Required]
        [Column("PRECOD_0")]
        [StringLength(5)]
        public string Precod0 { get; set; }
        [Required]
        [Column("MVTDES_0")]
        [StringLength(30)]
        public string Mvtdes0 { get; set; }
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