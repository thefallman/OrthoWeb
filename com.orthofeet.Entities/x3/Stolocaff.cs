// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("STOLOCAFF", Schema = "TESTPROD")]
    [Index(nameof(Stofcy0), nameof(Loc0), nameof(Itmref0), Name = "STOLOCAFF_STF0", IsUnique = true)]
    [Index(nameof(Stofcy0), nameof(Itmref0), nameof(Loc0), Name = "STOLOCAFF_STF1", IsUnique = true)]
    public partial class Stolocaff
    {
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("LOC_0")]
        [StringLength(10)]
        public string Loc0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("MAXSTO_0", TypeName = "numeric(28, 13)")]
        public decimal Maxsto0 { get; set; }
        [Column("REOTSD_0", TypeName = "numeric(28, 13)")]
        public decimal Reotsd0 { get; set; }
        [Required]
        [Column("PCU_0")]
        [StringLength(3)]
        public string Pcu0 { get; set; }
        [Column("QTYPCU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypcu0 { get; set; }
        [Column("PCUSTUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Pcustucoe0 { get; set; }
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