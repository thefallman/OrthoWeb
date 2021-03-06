// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("APORTVIG", Schema = "TESTPROD")]
    [Index(nameof(Codvi0), Name = "APORTVIG_AVP0", IsUnique = true)]
    [Index(nameof(Menur0), nameof(Rangr0), nameof(Codvi0), Name = "APORTVIG_AVP1", IsUnique = true)]
    public partial class Aportvig
    {
        [Required]
        [Column("CODVI_0")]
        [StringLength(10)]
        public string Codvi0 { get; set; }
        [Required]
        [Column("DESCR_0")]
        [StringLength(200)]
        public string Descr0 { get; set; }
        [Required]
        [Column("CODFA_0")]
        [StringLength(10)]
        public string Codfa0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Required]
        [Column("CODACC_0")]
        [StringLength(10)]
        public string Codacc0 { get; set; }
        [Required]
        [Column("ICONE_0")]
        [StringLength(100)]
        public string Icone0 { get; set; }
        [Required]
        [Column("MENUR_0")]
        [StringLength(10)]
        public string Menur0 { get; set; }
        [Column("RANGR_0")]
        public short Rangr0 { get; set; }
        [Column("NBPAR_0")]
        public short Nbpar0 { get; set; }
        [Required]
        [Column("PROPVAL_0")]
        [StringLength(250)]
        public string Propval0 { get; set; }
        [Required]
        [Column("PROPVAL_1")]
        [StringLength(250)]
        public string Propval1 { get; set; }
        [Required]
        [Column("PROPVAL_2")]
        [StringLength(250)]
        public string Propval2 { get; set; }
        [Required]
        [Column("PROPVAL_3")]
        [StringLength(250)]
        public string Propval3 { get; set; }
        [Required]
        [Column("PROPVAL_4")]
        [StringLength(250)]
        public string Propval4 { get; set; }
        [Required]
        [Column("PROPVAL_5")]
        [StringLength(250)]
        public string Propval5 { get; set; }
        [Required]
        [Column("PROPVAL_6")]
        [StringLength(250)]
        public string Propval6 { get; set; }
        [Required]
        [Column("PROPVAL_7")]
        [StringLength(250)]
        public string Propval7 { get; set; }
        [Required]
        [Column("PROPVAL_8")]
        [StringLength(250)]
        public string Propval8 { get; set; }
        [Required]
        [Column("PROPVAL_9")]
        [StringLength(250)]
        public string Propval9 { get; set; }
        [Column("MODVAL_0")]
        public byte Modval0 { get; set; }
        [Column("MODVAL_1")]
        public byte Modval1 { get; set; }
        [Column("MODVAL_2")]
        public byte Modval2 { get; set; }
        [Column("MODVAL_3")]
        public byte Modval3 { get; set; }
        [Column("MODVAL_4")]
        public byte Modval4 { get; set; }
        [Column("MODVAL_5")]
        public byte Modval5 { get; set; }
        [Column("MODVAL_6")]
        public byte Modval6 { get; set; }
        [Column("MODVAL_7")]
        public byte Modval7 { get; set; }
        [Column("MODVAL_8")]
        public byte Modval8 { get; set; }
        [Column("MODVAL_9")]
        public byte Modval9 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}