﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AENTREE", Schema = "TESTPROD")]
    [Index(nameof(Trtstd0), Name = "AENTREE_APE0", IsUnique = true)]
    public partial class Aentree
    {
        [Required]
        [Column("TRTSTD_0")]
        [StringLength(30)]
        public string Trtstd0 { get; set; }
        [Required]
        [Column("TRTSPE_0")]
        [StringLength(30)]
        public string Trtspe0 { get; set; }
        [Required]
        [Column("TRTPAR_0")]
        [StringLength(250)]
        public string Trtpar0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}