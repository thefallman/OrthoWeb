// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SCHGD", Schema = "TESTPROD")]
    [Index(nameof(Vcrnum0), nameof(Vcrlin0), Name = "SCHGD_SGD0", IsUnique = true)]
    public partial class Schgd
    {
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("ITMDES1_0")]
        [StringLength(30)]
        public string Itmdes10 { get; set; }
        [Required]
        [Column("OWNER_0")]
        [StringLength(15)]
        public string Owner0 { get; set; }
        [Required]
        [Column("PCU_0")]
        [StringLength(3)]
        public string Pcu0 { get; set; }
        [Column("QTYPCU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypcu0 { get; set; }
        [Column("PCUSTUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Pcustucoe0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Column("PRI_0", TypeName = "numeric(19, 5)")]
        public decimal Pri0 { get; set; }
        [Required]
        [Column("STA_0")]
        [StringLength(3)]
        public string Sta0 { get; set; }
        [Required]
        [Column("LOCTYP_0")]
        [StringLength(5)]
        public string Loctyp0 { get; set; }
        [Required]
        [Column("LOC_0")]
        [StringLength(10)]
        public string Loc0 { get; set; }
        [Required]
        [Column("LOT_0")]
        [StringLength(15)]
        public string Lot0 { get; set; }
        [Required]
        [Column("SLO_0")]
        [StringLength(5)]
        public string Slo0 { get; set; }
        [Required]
        [Column("SERNUM_0")]
        [StringLength(20)]
        public string Sernum0 { get; set; }
        [Required]
        [Column("SERNUMF_0")]
        [StringLength(20)]
        public string Sernumf0 { get; set; }
        [Required]
        [Column("PALNUM_0")]
        [StringLength(10)]
        public string Palnum0 { get; set; }
        [Required]
        [Column("CTRNUM_0")]
        [StringLength(10)]
        public string Ctrnum0 { get; set; }
        [Required]
        [Column("QLYCTLDEM_0")]
        [StringLength(20)]
        public string Qlyctldem0 { get; set; }
        [Required]
        [Column("PCUDES_0")]
        [StringLength(5)]
        public string Pcudes0 { get; set; }
        [Column("QTYPCUDES_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypcudes0 { get; set; }
        [Column("COEDES_0", TypeName = "numeric(18, 7)")]
        public decimal Coedes0 { get; set; }
        [Column("QTYSTUDES_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystudes0 { get; set; }
        [Column("QLYCTLFLG_0")]
        public byte Qlyctlflg0 { get; set; }
        [Required]
        [Column("WRH_0")]
        [StringLength(1)]
        public string Wrh0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Column("IMPNUMLIG_0")]
        public int Impnumlig0 { get; set; }
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