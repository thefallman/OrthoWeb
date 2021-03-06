// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("WORKSTATIO", Schema = "TESTPROD")]
    [Index(nameof(Wst0), nameof(Wcrfcy0), Name = "WORKSTATIO_WST0", IsUnique = true)]
    [Index(nameof(Wcr0), nameof(Wsttyp0), nameof(Wst0), Name = "WORKSTATIO_WST1")]
    [Index(nameof(Wstdes0), Name = "WORKSTATIO_WST2")]
    [Index(nameof(Wcr0), nameof(Wst0), Name = "WORKSTATIO_WST3")]
    [Index(nameof(Wcrfcy0), nameof(Wcr0), nameof(Wst0), Name = "WORKSTATIO_WST4", IsUnique = true)]
    [Index(nameof(Wcrfcy0), nameof(Wst0), Name = "WORKSTATIO_WST5", IsUnique = true)]
    public partial class Workstatio
    {
        [Required]
        [Column("WST_0")]
        [StringLength(8)]
        public string Wst0 { get; set; }
        [Required]
        [Column("WSTDES_0")]
        [StringLength(30)]
        public string Wstdes0 { get; set; }
        [Required]
        [Column("WSTSHO_0")]
        [StringLength(10)]
        public string Wstsho0 { get; set; }
        [Column("WSTTYP_0")]
        public byte Wsttyp0 { get; set; }
        [Required]
        [Column("WCR_0")]
        [StringLength(5)]
        public string Wcr0 { get; set; }
        [Required]
        [Column("WCRFCY_0")]
        [StringLength(5)]
        public string Wcrfcy0 { get; set; }
        [Required]
        [Column("VLTCCE_0")]
        [StringLength(20)]
        public string Vltcce0 { get; set; }
        [Required]
        [Column("STOLOC_0")]
        [StringLength(10)]
        public string Stoloc0 { get; set; }
        [Required]
        [Column("TWD_0")]
        [StringLength(3)]
        public string Twd0 { get; set; }
        [Column("EFF_0", TypeName = "numeric(10, 4)")]
        public decimal Eff0 { get; set; }
        [Column("USE_0", TypeName = "numeric(10, 4)")]
        public decimal Use0 { get; set; }
        [Column("SHR_0", TypeName = "numeric(10, 4)")]
        public decimal Shr0 { get; set; }
        [Column("WSTNBR_0")]
        public short Wstnbr0 { get; set; }
        [Column("CLEPCTAUT_0", TypeName = "numeric(10, 4)")]
        public decimal Clepctaut0 { get; set; }
        [Required]
        [Column("QLFLEV_0")]
        [StringLength(10)]
        public string Qlflev0 { get; set; }
        [Column("EXTHOUTIM_0", TypeName = "numeric(13, 5)")]
        public decimal Exthoutim0 { get; set; }
        [Column("CPLHOUTIM_0", TypeName = "numeric(13, 5)")]
        public decimal Cplhoutim0 { get; set; }
        [Column("DSPLEV_0")]
        public byte Dsplev0 { get; set; }
        [Column("CONSTRAINT_0")]
        public byte Constraint0 { get; set; }
        [Column("RCCP_0")]
        public byte Rccp0 { get; set; }
        [Column("GRPFLG_0")]
        public byte Grpflg0 { get; set; }
        [Column("GRPHOR_0")]
        public short Grphor0 { get; set; }
        [Column("RPLAUTO_0")]
        public byte Rplauto0 { get; set; }
        [Column("SBBFLG_0")]
        public byte Sbbflg0 { get; set; }
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
        [Column("XA_MNTINT_0", TypeName = "numeric(13, 5)")]
        public decimal XaMntint0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}