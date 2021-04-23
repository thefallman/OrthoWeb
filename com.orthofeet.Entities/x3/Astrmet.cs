﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ASTRMET", Schema = "TESTPROD")]
    [Index(nameof(Codstr0), nameof(Nomet0), nameof(Codmet0), Name = "ASTRMET_ASM0", IsUnique = true)]
    [Index(nameof(Codstr0), nameof(Codmet0), Name = "ASTRMET_ASM1", IsUnique = true)]
    public partial class Astrmet
    {
        [Required]
        [Column("CODSTR_0")]
        [StringLength(10)]
        public string Codstr0 { get; set; }
        [Column("NOMET_0")]
        public short Nomet0 { get; set; }
        [Required]
        [Column("CODMET_0")]
        [StringLength(12)]
        public string Codmet0 { get; set; }
        [Column("DONMET_0")]
        public byte Donmet0 { get; set; }
        [Required]
        [Column("ACTMET_0")]
        [StringLength(5)]
        public string Actmet0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}