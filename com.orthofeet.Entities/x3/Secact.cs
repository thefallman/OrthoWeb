﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SECACT", Schema = "TESTPROD")]
    [Index(nameof(Cpy0), nameof(Sac0), Name = "SECACT_SEA0", IsUnique = true)]
    public partial class Secact
    {
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("SAC_0")]
        [StringLength(20)]
        public string Sac0 { get; set; }
        [Required]
        [Column("SACDES_0")]
        [StringLength(30)]
        public string Sacdes0 { get; set; }
        [Column("TAXCOEINI_0", TypeName = "numeric(8, 3)")]
        public decimal Taxcoeini0 { get; set; }
        [Column("TAXCOEDEF_0", TypeName = "numeric(8, 3)")]
        public decimal Taxcoedef0 { get; set; }
        [Column("TAXCOEFLG_0")]
        public byte Taxcoeflg0 { get; set; }
        [Column("ASJCOE_0", TypeName = "numeric(8, 3)")]
        public decimal Asjcoe0 { get; set; }
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
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}