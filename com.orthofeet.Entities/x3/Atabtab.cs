﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ATABTAB", Schema = "TESTPROD")]
    [Index(nameof(Numtab0), Name = "ATABTAB_CODE", IsUnique = true)]
    public partial class Atabtab
    {
        [Column("NUMTAB_0")]
        public short Numtab0 { get; set; }
        [Required]
        [Column("NUMCAR_0")]
        [StringLength(4)]
        public string Numcar0 { get; set; }
        [Required]
        [Column("CODTYP1_0")]
        [StringLength(3)]
        public string Codtyp10 { get; set; }
        [Required]
        [Column("SUP1_0")]
        [StringLength(10)]
        public string Sup10 { get; set; }
        [Required]
        [Column("CODTYP2_0")]
        [StringLength(3)]
        public string Codtyp20 { get; set; }
        [Required]
        [Column("SUP2_0")]
        [StringLength(10)]
        public string Sup20 { get; set; }
        [Required]
        [Column("CODTYP3_0")]
        [StringLength(3)]
        public string Codtyp30 { get; set; }
        [Required]
        [Column("SUP3_0")]
        [StringLength(10)]
        public string Sup30 { get; set; }
        [Required]
        [Column("CODTYP4_0")]
        [StringLength(3)]
        public string Codtyp40 { get; set; }
        [Required]
        [Column("SUP4_0")]
        [StringLength(10)]
        public string Sup40 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Required]
        [Column("ACS_0")]
        [StringLength(10)]
        public string Acs0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Column("DEPNUM_0")]
        public short Depnum0 { get; set; }
        [Column("UPDFLG_0")]
        public byte Updflg0 { get; set; }
        [Column("LNGFLG_0")]
        public byte Lngflg0 { get; set; }
        [Column("LNG_0")]
        public short Lng0 { get; set; }
        [Column("FLGSOC_0")]
        public byte Flgsoc0 { get; set; }
        [Column("FLGLEG_0")]
        public byte Flgleg0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}