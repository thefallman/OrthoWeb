﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SRESAT", Schema = "TESTPROD")]
    [Index(nameof(Srenum0), Name = "SRESAT_SRS0")]
    public partial class Sresat
    {
        [Required]
        [Column("SRENUM_0")]
        [StringLength(20)]
        public string Srenum0 { get; set; }
        [Column("SATDAT_0", TypeName = "datetime")]
        public DateTime Satdat0 { get; set; }
        [Required]
        [Column("SATHOU_0")]
        [StringLength(5)]
        public string Sathou0 { get; set; }
        [Required]
        [Column("SAT_0")]
        [StringLength(30)]
        public string Sat0 { get; set; }
        [Required]
        [Column("DET_0")]
        [StringLength(15)]
        public string Det0 { get; set; }
        [Column("ASS_0")]
        public byte Ass0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}