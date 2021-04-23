﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("APROCESSUS", Schema = "TESTPROD")]
    [Index(nameof(Codpro0), Name = "APROCESSUS_APR0")]
    [Index(nameof(Codleg0), nameof(Codpro0), Name = "APROCESSUS_APR1", IsUnique = true)]
    [Index(nameof(Codpro0), nameof(Codleg0), Name = "APROCESSUS_APR2", IsUnique = true)]
    public partial class Aprocessu
    {
        [Required]
        [Column("CODPRO_0")]
        [StringLength(10)]
        public string Codpro0 { get; set; }
        [Required]
        [Column("CODLEG_0")]
        [StringLength(20)]
        public string Codleg0 { get; set; }
        [Required]
        [Column("LANGDESC_0")]
        [StringLength(3)]
        public string Langdesc0 { get; set; }
        [Required]
        [Column("DESCR_0")]
        [StringLength(200)]
        public string Descr0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Required]
        [Column("CODACC_0")]
        [StringLength(10)]
        public string Codacc0 { get; set; }
        [Column("TYPEP_0")]
        public byte Typep0 { get; set; }
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
        [Column("CLOB_0")]
        public string Clob0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}