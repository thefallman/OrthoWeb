﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABROUALT", Schema = "TESTPROD")]
    [Index(nameof(Roualt0), Name = "TABROUALT_TRO0", IsUnique = true)]
    [Index(nameof(Fcy0), nameof(Roualt0), Name = "TABROUALT_TRO1", IsUnique = true)]
    public partial class Tabroualt
    {
        [Column("ROUALT_0")]
        public short Roualt0 { get; set; }
        [Required]
        [Column("TRODES_0")]
        [StringLength(30)]
        public string Trodes0 { get; set; }
        [Required]
        [Column("TROSHO_0")]
        [StringLength(10)]
        public string Trosho0 { get; set; }
        [Required]
        [Column("ACSCOD_0")]
        [StringLength(10)]
        public string Acscod0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Column("MFGUSE_0")]
        public byte Mfguse0 { get; set; }
        [Column("CSTUSE_0")]
        public byte Cstuse0 { get; set; }
        [Column("RCCUSE_0")]
        public byte Rccuse0 { get; set; }
        [Column("BOMALT1_0")]
        public short Bomalt10 { get; set; }
        [Column("BOMALT2_0")]
        public short Bomalt20 { get; set; }
        [Column("BOMALT3_0")]
        public short Bomalt30 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}