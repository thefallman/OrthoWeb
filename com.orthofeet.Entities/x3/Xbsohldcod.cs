﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XBSOHLDCOD", Schema = "TESTPROD")]
    [Index(nameof(Hldcod0), Name = "XBSOHLDCOD_XBO0", IsUnique = true)]
    public partial class Xbsohldcod
    {
        [Required]
        [Column("HLDCOD_0")]
        [StringLength(10)]
        public string Hldcod0 { get; set; }
        [Required]
        [Column("CODDES_0")]
        [StringLength(30)]
        public string Coddes0 { get; set; }
        [Required]
        [Column("CODSHO_0")]
        [StringLength(10)]
        public string Codsho0 { get; set; }
        [Required]
        [Column("CODACC_0")]
        [StringLength(10)]
        public string Codacc0 { get; set; }
        [Column("HLDTYP_0")]
        public byte Hldtyp0 { get; set; }
        [Column("ALLOWALC_0")]
        public byte Allowalc0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}