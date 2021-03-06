// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABSIVTYP", Schema = "TESTPROD")]
    [Index(nameof(Sivtyp0), Name = "TABSIVTYP_TSV0", IsUnique = true)]
    public partial class Tabsivtyp
    {
        [Required]
        [Column("SIVTYP_0")]
        [StringLength(5)]
        public string Sivtyp0 { get; set; }
        [Required]
        [Column("LANDESSHO_0")]
        [StringLength(60)]
        public string Landessho0 { get; set; }
        [Required]
        [Column("TSVDES_0")]
        [StringLength(30)]
        public string Tsvdes0 { get; set; }
        [Required]
        [Column("TSVSHO_0")]
        [StringLength(10)]
        public string Tsvsho0 { get; set; }
        [Column("INVTYP_0")]
        public byte Invtyp0 { get; set; }
        [Column("MANCOU_0")]
        public byte Mancou0 { get; set; }
        [Required]
        [Column("CODNUM_0")]
        [StringLength(5)]
        public string Codnum0 { get; set; }
        [Required]
        [Column("COD_0")]
        [StringLength(5)]
        public string Cod0 { get; set; }
        [Required]
        [Column("COD2_0")]
        [StringLength(5)]
        public string Cod20 { get; set; }
        [Required]
        [Column("JOU_0")]
        [StringLength(5)]
        public string Jou0 { get; set; }
        [Required]
        [Column("GTE_0")]
        [StringLength(5)]
        public string Gte0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Required]
        [Column("GFY_0")]
        [StringLength(5)]
        public string Gfy0 { get; set; }
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