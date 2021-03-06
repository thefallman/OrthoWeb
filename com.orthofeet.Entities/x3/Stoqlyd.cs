// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("STOQLYD", Schema = "TESTPROD")]
    [Index(nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vcrlin0), Name = "STOQLYD_QLD0", IsUnique = true)]
    [Index(nameof(Itmref0), nameof(Stofcy0), nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vcrlin0), Name = "STOQLYD_QLD1", IsUnique = true)]
    [Index(nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Lot0), nameof(Slo0), nameof(Sernum0), Name = "STOQLYD_QLD2")]
    [Index(nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vcrlinori0), nameof(Sernum0), Name = "STOQLYD_QLD3")]
    public partial class Stoqlyd
    {
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Column("CRDSEQ_0")]
        public int Crdseq0 { get; set; }
        [Column("CRDFLG_0")]
        public byte Crdflg0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("OWNER_0")]
        [StringLength(15)]
        public string Owner0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("VCRLINORI_0")]
        public int Vcrlinori0 { get; set; }
        [Required]
        [Column("LOT_0")]
        [StringLength(15)]
        public string Lot0 { get; set; }
        [Required]
        [Column("SLO_0")]
        [StringLength(5)]
        public string Slo0 { get; set; }
        [Required]
        [Column("PCU_0")]
        [StringLength(3)]
        public string Pcu0 { get; set; }
        [Column("PCUSTUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Pcustucoe0 { get; set; }
        [Column("QTYPCU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypcu0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Required]
        [Column("STA_0")]
        [StringLength(3)]
        public string Sta0 { get; set; }
        [Required]
        [Column("SERNUM_0")]
        [StringLength(20)]
        public string Sernum0 { get; set; }
        [Required]
        [Column("LOCTYP_0")]
        [StringLength(5)]
        public string Loctyp0 { get; set; }
        [Required]
        [Column("LOC_0")]
        [StringLength(10)]
        public string Loc0 { get; set; }
        [Required]
        [Column("QLYCRD_0")]
        [StringLength(8)]
        public string Qlycrd0 { get; set; }
        [Required]
        [Column("PALNUM_0")]
        [StringLength(10)]
        public string Palnum0 { get; set; }
        [Required]
        [Column("CTRNUM_0")]
        [StringLength(10)]
        public string Ctrnum0 { get; set; }
        [Required]
        [Column("WRH_0")]
        [StringLength(1)]
        public string Wrh0 { get; set; }
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