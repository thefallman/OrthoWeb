// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("QLYCRDQST", Schema = "TESTPROD")]
    [Index(nameof(Qstnum0), Name = "QLYCRDQST_QLQ0", IsUnique = true)]
    public partial class Qlycrdqst
    {
        [Required]
        [Column("QSTNUM_0")]
        [StringLength(8)]
        public string Qstnum0 { get; set; }
        [Required]
        [Column("QSTDES_0")]
        [StringLength(30)]
        public string Qstdes0 { get; set; }
        [Required]
        [Column("QSTSHO_0")]
        [StringLength(10)]
        public string Qstsho0 { get; set; }
        [Column("DEMASWTYP_0")]
        public byte Demaswtyp0 { get; set; }
        [Column("DEMCTLTYP_0")]
        public byte Demctltyp0 { get; set; }
        [Required]
        [Column("TCT_0")]
        [StringLength(3)]
        public string Tct0 { get; set; }
        [Required]
        [Column("ALPSTRVAL_0")]
        [StringLength(20)]
        public string Alpstrval0 { get; set; }
        [Required]
        [Column("ALPENDVAL_0")]
        [StringLength(20)]
        public string Alpendval0 { get; set; }
        [Column("NUMSTRVAL_0", TypeName = "numeric(25, 12)")]
        public decimal Numstrval0 { get; set; }
        [Column("NUMENDVAL_0", TypeName = "numeric(25, 12)")]
        public decimal Numendval0 { get; set; }
        [Column("OSDASW_0")]
        public byte Osdasw0 { get; set; }
        [Column("LOKTYP_0")]
        public byte Loktyp0 { get; set; }
        [Required]
        [Column("ALPDEFASW_0")]
        [StringLength(20)]
        public string Alpdefasw0 { get; set; }
        [Column("NUMDEFASW_0", TypeName = "numeric(25, 12)")]
        public decimal Numdefasw0 { get; set; }
        [Required]
        [Column("UOM_0")]
        [StringLength(3)]
        public string Uom0 { get; set; }
        [Column("UOMDEC_0")]
        public short Uomdec0 { get; set; }
        [Required]
        [Column("STRVALFOR_0")]
        [StringLength(3)]
        public string Strvalfor0 { get; set; }
        [Required]
        [Column("ENDVALFOR_0")]
        [StringLength(3)]
        public string Endvalfor0 { get; set; }
        [Required]
        [Column("GPG_0")]
        [StringLength(20)]
        public string Gpg0 { get; set; }
        [Column("PRNCOD_0")]
        public byte Prncod0 { get; set; }
        [Column("NUMNMNVAL_0", TypeName = "numeric(25, 12)")]
        public decimal Numnmnval0 { get; set; }
        [Required]
        [Column("ALPNMNVAL_0")]
        [StringLength(20)]
        public string Alpnmnval0 { get; set; }
        [Required]
        [Column("RPLQLYCRD_0")]
        [StringLength(8)]
        public string Rplqlycrd0 { get; set; }
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