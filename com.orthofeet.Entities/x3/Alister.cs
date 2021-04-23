﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ALISTER", Schema = "TESTPROD")]
    [Index(nameof(Cod0), nameof(Usr0), nameof(Niv0), nameof(Lig0), nameof(Col0), Name = "ALISTER_ALR0", IsUnique = true)]
    public partial class Alister
    {
        [Required]
        [Column("COD_0")]
        [StringLength(8)]
        public string Cod0 { get; set; }
        [Required]
        [Column("USR_0")]
        [StringLength(5)]
        public string Usr0 { get; set; }
        [Column("NIV_0")]
        public short Niv0 { get; set; }
        [Column("COL_0")]
        public short Col0 { get; set; }
        [Column("LIG_0")]
        public int Lig0 { get; set; }
        [Required]
        [Column("VLR_0")]
        [StringLength(200)]
        public string Vlr0 { get; set; }
        [Column("NUM_0", TypeName = "numeric(27, 13)")]
        public decimal Num0 { get; set; }
        [Column("DAT_0", TypeName = "datetime")]
        public DateTime Dat0 { get; set; }
        [Column("TYP_0")]
        public byte Typ0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CRETIM_0")]
        [StringLength(5)]
        public string Cretim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}