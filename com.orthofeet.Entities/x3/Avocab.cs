﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AVOCAB", Schema = "TESTPROD")]
    [Index(nameof(Lan0), nameof(Ver0), nameof(Typ0), nameof(Chp0), nameof(Num0), Name = "AVOCAB_AVO0", IsUnique = true)]
    public partial class Avocab
    {
        [Required]
        [Column("LAN_0")]
        [StringLength(3)]
        public string Lan0 { get; set; }
        [Column("VER_0")]
        public byte Ver0 { get; set; }
        [Column("TYP_0")]
        public byte Typ0 { get; set; }
        [Column("CHP_0")]
        public short Chp0 { get; set; }
        [Column("NUM_0")]
        public int Num0 { get; set; }
        [Required]
        [Column("TXT_0")]
        [StringLength(123)]
        public string Txt0 { get; set; }
        [Column("CUR_0")]
        public byte Cur0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}