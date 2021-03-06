// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AOBJBURMOD", Schema = "TESTPROD")]
    [Index(nameof(Abrev0), nameof(Trn0), nameof(Cpy0), nameof(Modele0), Name = "AOBJBURMOD_AON0", IsUnique = true)]
    public partial class Aobjburmod
    {
        [Required]
        [Column("ABREV_0")]
        [StringLength(3)]
        public string Abrev0 { get; set; }
        [Required]
        [Column("TRN_0")]
        [StringLength(10)]
        public string Trn0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("MODELE_0")]
        [StringLength(10)]
        public string Modele0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Required]
        [Column("TRNCPYMOD_0")]
        [StringLength(30)]
        public string Trncpymod0 { get; set; }
        [Column("TYP_0")]
        public byte Typ0 { get; set; }
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
        [Required]
        [Column("BLOB_0")]
        public byte[] Blob0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}