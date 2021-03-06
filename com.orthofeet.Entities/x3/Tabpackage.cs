// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABPACKAGE", Schema = "TESTPROD")]
    [Index(nameof(Pck0), Name = "TABPACKAGE_TPA0", IsUnique = true)]
    public partial class Tabpackage
    {
        [Required]
        [Column("PCK_0")]
        [StringLength(5)]
        public string Pck0 { get; set; }
        [Required]
        [Column("LANDESSHO_0")]
        [StringLength(60)]
        public string Landessho0 { get; set; }
        [Column("PCKPRI_0", TypeName = "numeric(27, 13)")]
        public decimal Pckpri0 { get; set; }
        [Required]
        [Column("DIU_0")]
        [StringLength(3)]
        public string Diu0 { get; set; }
        [Required]
        [Column("WEU_0")]
        [StringLength(3)]
        public string Weu0 { get; set; }
        [Column("PCKWEI_0", TypeName = "numeric(13, 4)")]
        public decimal Pckwei0 { get; set; }
        [Column("PCKLEN_0", TypeName = "numeric(14, 5)")]
        public decimal Pcklen0 { get; set; }
        [Column("PCKWID_0", TypeName = "numeric(14, 5)")]
        public decimal Pckwid0 { get; set; }
        [Column("PCKHEI_0", TypeName = "numeric(14, 5)")]
        public decimal Pckhei0 { get; set; }
        [Required]
        [Column("VOU_0")]
        [StringLength(3)]
        public string Vou0 { get; set; }
        [Column("VOL_0", TypeName = "numeric(12, 4)")]
        public decimal Vol0 { get; set; }
        [Required]
        [Column("LBLFMT_0")]
        [StringLength(15)]
        public string Lblfmt0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}