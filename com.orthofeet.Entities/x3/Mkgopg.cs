﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("MKGOPG", Schema = "TESTPROD")]
    [Index(nameof(Mkgqur0), nameof(Opgnum0), nameof(Tgr0), Name = "MKGOPG_MOG0", IsUnique = true)]
    [Index(nameof(Mkgqur0), nameof(Tgr0), Name = "MKGOPG_MOG1")]
    [Index(nameof(Opgnum0), nameof(Tgr0), Name = "MKGOPG_MOG2")]
    public partial class Mkgopg
    {
        [Required]
        [Column("MKGQUR_0")]
        [StringLength(20)]
        public string Mkgqur0 { get; set; }
        [Required]
        [Column("OPGNUM_0")]
        [StringLength(20)]
        public string Opgnum0 { get; set; }
        [Required]
        [Column("TGR_0")]
        [StringLength(10)]
        public string Tgr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}