﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GACCGRUPYM", Schema = "TESTPROD")]
    [Index(nameof(Pym0), nameof(Gru0), nameof(Lin0), Name = "GACCGRUPYM_GRY0", IsUnique = true)]
    [Index(nameof(Pym0), nameof(Lev0), nameof(Gru0), nameof(Lin0), Name = "GACCGRUPYM_GRY1", IsUnique = true)]
    [Index(nameof(Pym0), nameof(Sbbgru0), Name = "GACCGRUPYM_GRY2")]
    [Index(nameof(Pym0), nameof(Gru0), Name = "GACCGRUPYM_GRY4")]
    [Index(nameof(Pym0), nameof(Acc0), Name = "GACCGRUPYM_GRY5")]
    public partial class Gaccgrupym
    {
        [Required]
        [Column("PYM_0")]
        [StringLength(5)]
        public string Pym0 { get; set; }
        [Required]
        [Column("GRU_0")]
        [StringLength(10)]
        public string Gru0 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Column("LEV_0")]
        public short Lev0 { get; set; }
        [Column("PRNROW_0")]
        public short Prnrow0 { get; set; }
        [Required]
        [Column("CLSCOD_0")]
        [StringLength(10)]
        public string Clscod0 { get; set; }
        [Column("UOMDAC_0")]
        public byte Uomdac0 { get; set; }
        [Required]
        [Column("UOM_0")]
        [StringLength(3)]
        public string Uom0 { get; set; }
        [Column("DEFVAL_0", TypeName = "numeric(27, 13)")]
        public decimal Defval0 { get; set; }
        [Column("BUDTRK_0")]
        public byte Budtrk0 { get; set; }
        [Required]
        [Column("TIMDSP_0")]
        [StringLength(10)]
        public string Timdsp0 { get; set; }
        [Column("LIN_0")]
        public short Lin0 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("SBBGRU_0")]
        [StringLength(10)]
        public string Sbbgru0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}