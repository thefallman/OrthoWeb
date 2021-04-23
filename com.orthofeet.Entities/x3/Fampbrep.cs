﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("FAMPBREP", Schema = "TESTPROD")]
    [Index(nameof(Grppblnum0), Name = "FAMPBREP_PBR0")]
    [Index(nameof(Repnum0), Name = "FAMPBREP_PBR1")]
    [Index(nameof(Grppblnum0), nameof(Repnum0), Name = "FAMPBREP_PBR2", IsUnique = true)]
    public partial class Fampbrep
    {
        [Required]
        [Column("GRPPBLNUM_0")]
        [StringLength(20)]
        public string Grppblnum0 { get; set; }
        [Required]
        [Column("REPNUM_0")]
        [StringLength(5)]
        public string Repnum0 { get; set; }
        [Required]
        [Column("REPNAM_0")]
        [StringLength(35)]
        public string Repnam0 { get; set; }
        [Column("SRECOU_0")]
        public short Srecou0 { get; set; }
        [Column("STTFLG_0")]
        public short Sttflg0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}