﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("FXDMVT", Schema = "TESTPROD")]
    [Index(nameof(Idmvt0), Name = "FXDMVT_FXM0", IsUnique = true)]
    [Index(nameof(Objmvt0), nameof(Ref1mvt0), nameof(Ref2mvt0), nameof(Seqmvt0), nameof(Typmvt0), Name = "FXDMVT_FXM1", IsUnique = true)]
    [Index(nameof(Objmvt0), nameof(Typmvt0), nameof(Ref1mvt0), nameof(Ref2mvt0), nameof(Seqmvt0), Name = "FXDMVT_FXM2")]
    public partial class Fxdmvt
    {
        [Column("OBJMVT_0")]
        public byte Objmvt0 { get; set; }
        [Required]
        [Column("REF1MVT_0")]
        [StringLength(30)]
        public string Ref1mvt0 { get; set; }
        [Required]
        [Column("REF2MVT_0")]
        [StringLength(30)]
        public string Ref2mvt0 { get; set; }
        [Column("IDMVT_0")]
        public int Idmvt0 { get; set; }
        [Column("SEQMVT_0")]
        public int Seqmvt0 { get; set; }
        [Column("TYPMVT_0")]
        public byte Typmvt0 { get; set; }
        [Column("STATMVT_0")]
        public byte Statmvt0 { get; set; }
        [Required]
        [Column("DESRJTMVT_0")]
        [StringLength(250)]
        public string Desrjtmvt0 { get; set; }
        [Column("ORIMVT_0")]
        public byte Orimvt0 { get; set; }
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
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("TRACE_0")]
        [StringLength(50)]
        public string Trace0 { get; set; }
        [Column("DATINTMVT_0", TypeName = "datetime")]
        public DateTime Datintmvt0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}