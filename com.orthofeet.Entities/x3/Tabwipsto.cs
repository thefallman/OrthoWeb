// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABWIPSTO", Schema = "TESTPROD")]
    [Index(nameof(Stocou0), nameof(Stoseq0), Name = "TABWIPSTO_TWS0", IsUnique = true)]
    [Index(nameof(Stofcy0), nameof(Itmref0), Name = "TABWIPSTO_TWS1")]
    [Index(nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vcrlin0), Name = "TABWIPSTO_TWS2")]
    public partial class Tabwipsto
    {
        [Column("STOCOU_0", TypeName = "numeric(11, 1)")]
        public decimal Stocou0 { get; set; }
        [Column("STOSEQ_0")]
        public short Stoseq0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Column("WIPQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Wipqty0 { get; set; }
        [Column("WIPQTA_0", TypeName = "numeric(28, 13)")]
        public decimal Wipqta0 { get; set; }
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