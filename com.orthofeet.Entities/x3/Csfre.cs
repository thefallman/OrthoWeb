﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("CSFRES", Schema = "TESTPROD")]
    [Index(nameof(Numrpt0), nameof(Codany0), nameof(Lig0), nameof(Cpy0), nameof(Fcy0), Name = "CSFRES_CWR0", IsUnique = true)]
    public partial class Csfre
    {
        [Column("NUMRPT_0")]
        public int Numrpt0 { get; set; }
        [Required]
        [Column("CODANY_0")]
        [StringLength(10)]
        public string Codany0 { get; set; }
        [Column("LIG_0")]
        public short Lig0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Column("DATDEB_0", TypeName = "datetime")]
        public DateTime Datdeb0 { get; set; }
        [Column("DATFIN_0", TypeName = "datetime")]
        public DateTime Datfin0 { get; set; }
        [Required]
        [Column("COD1_0")]
        [StringLength(10)]
        public string Cod10 { get; set; }
        [Required]
        [Column("COD2_0")]
        [StringLength(10)]
        public string Cod20 { get; set; }
        [Required]
        [Column("LIBEL_0")]
        [StringLength(50)]
        public string Libel0 { get; set; }
        [Required]
        [Column("CURLED_0")]
        [StringLength(3)]
        public string Curled0 { get; set; }
        [Column("AMTLED_0", TypeName = "numeric(27, 13)")]
        public decimal Amtled0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CRETIM_0")]
        [StringLength(8)]
        public string Cretim0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}