// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PARESC", Schema = "TESTPROD")]
    [Index(nameof(Escnum0), Name = "PARESC_PEC0", IsUnique = true)]
    [Index(nameof(Enaflg0), nameof(Esccat0), Name = "PARESC_PEC1")]
    public partial class Paresc
    {
        [Required]
        [Column("ESCNUM_0")]
        [StringLength(20)]
        public string Escnum0 { get; set; }
        [Required]
        [Column("ESCNAM_0")]
        [StringLength(100)]
        public string Escnam0 { get; set; }
        [Required]
        [Column("ESCCAT_0")]
        [StringLength(20)]
        public string Esccat0 { get; set; }
        [Column("ESCTYP_0")]
        public byte Esctyp0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Required]
        [Column("ESCCND_0")]
        [StringLength(20)]
        public string Esccnd0 { get; set; }
        [Required]
        [Column("ESCACTNUM_0")]
        [StringLength(20)]
        public string Escactnum0 { get; set; }
        [Required]
        [Column("ESCACTNUM_1")]
        [StringLength(20)]
        public string Escactnum1 { get; set; }
        [Required]
        [Column("ESCACTNUM_2")]
        [StringLength(20)]
        public string Escactnum2 { get; set; }
        [Required]
        [Column("ESCACTNUM_3")]
        [StringLength(20)]
        public string Escactnum3 { get; set; }
        [Required]
        [Column("ESCACTNUM_4")]
        [StringLength(20)]
        public string Escactnum4 { get; set; }
        [Required]
        [Column("ESCACTNUM_5")]
        [StringLength(20)]
        public string Escactnum5 { get; set; }
        [Required]
        [Column("ESCACTNUM_6")]
        [StringLength(20)]
        public string Escactnum6 { get; set; }
        [Required]
        [Column("ESCACTNUM_7")]
        [StringLength(20)]
        public string Escactnum7 { get; set; }
        [Required]
        [Column("ESCACTNUM_8")]
        [StringLength(20)]
        public string Escactnum8 { get; set; }
        [Required]
        [Column("ESCACTNUM_9")]
        [StringLength(20)]
        public string Escactnum9 { get; set; }
        [Required]
        [Column("ESCACTNAM_0")]
        [StringLength(100)]
        public string Escactnam0 { get; set; }
        [Required]
        [Column("ESCACTNAM_1")]
        [StringLength(100)]
        public string Escactnam1 { get; set; }
        [Required]
        [Column("ESCACTNAM_2")]
        [StringLength(100)]
        public string Escactnam2 { get; set; }
        [Required]
        [Column("ESCACTNAM_3")]
        [StringLength(100)]
        public string Escactnam3 { get; set; }
        [Required]
        [Column("ESCACTNAM_4")]
        [StringLength(100)]
        public string Escactnam4 { get; set; }
        [Required]
        [Column("ESCACTNAM_5")]
        [StringLength(100)]
        public string Escactnam5 { get; set; }
        [Required]
        [Column("ESCACTNAM_6")]
        [StringLength(100)]
        public string Escactnam6 { get; set; }
        [Required]
        [Column("ESCACTNAM_7")]
        [StringLength(100)]
        public string Escactnam7 { get; set; }
        [Required]
        [Column("ESCACTNAM_8")]
        [StringLength(100)]
        public string Escactnam8 { get; set; }
        [Required]
        [Column("ESCACTNAM_9")]
        [StringLength(100)]
        public string Escactnam9 { get; set; }
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