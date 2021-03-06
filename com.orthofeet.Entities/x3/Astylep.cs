// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ASTYLEP", Schema = "TESTPROD")]
    [Index(nameof(Cat0), nameof(Lig0), Name = "ASTYLEP_AYP0", IsUnique = true)]
    [Index(nameof(Cat0), nameof(Cod0), Name = "ASTYLEP_AYP1", IsUnique = true)]
    public partial class Astylep
    {
        [Required]
        [Column("CAT_0")]
        [StringLength(10)]
        public string Cat0 { get; set; }
        [Required]
        [Column("INTIT_0")]
        [StringLength(30)]
        public string Intit0 { get; set; }
        [Column("LIG_0")]
        public short Lig0 { get; set; }
        [Required]
        [Column("COD_0")]
        [StringLength(10)]
        public string Cod0 { get; set; }
        [Required]
        [Column("STY_0")]
        [StringLength(250)]
        public string Sty0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}