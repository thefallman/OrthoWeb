﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("WIPTMP", Schema = "TESTPROD")]
    [Index(nameof(Entcod0), nameof(Cpy0), nameof(Key10), nameof(Key20), nameof(Key30), nameof(Key40), nameof(Key50), nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Wipseq0), Name = "WIPTMP_MWT0", IsUnique = true)]
    public partial class Wiptmp
    {
        [Required]
        [Column("ENTCOD_0")]
        [StringLength(5)]
        public string Entcod0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Column("TXNTYP_0")]
        public byte Txntyp0 { get; set; }
        [Column("PWIPCOST_0")]
        public int Pwipcost0 { get; set; }
        [Required]
        [Column("KEY1_0")]
        [StringLength(30)]
        public string Key10 { get; set; }
        [Required]
        [Column("KEY2_0")]
        [StringLength(30)]
        public string Key20 { get; set; }
        [Required]
        [Column("KEY3_0")]
        [StringLength(30)]
        public string Key30 { get; set; }
        [Required]
        [Column("KEY4_0")]
        [StringLength(30)]
        public string Key40 { get; set; }
        [Required]
        [Column("KEY5_0")]
        [StringLength(30)]
        public string Key50 { get; set; }
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("WIPSEQ_0")]
        public int Wipseq0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}