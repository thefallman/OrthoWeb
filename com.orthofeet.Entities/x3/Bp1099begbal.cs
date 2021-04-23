﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BP1099BEGBAL", Schema = "TESTPROD")]
    [Index(nameof(Yr10990), nameof(Cpy0), nameof(Bpsnum0), nameof(Seq0), Name = "BP1099BEGBAL_B9B0")]
    [Index(nameof(Yr10990), nameof(Cpy0), nameof(Bpsnum0), nameof(Frm10990), nameof(Box10990), Name = "BP1099BEGBAL_B9B1", IsUnique = true)]
    public partial class Bp1099begbal
    {
        [Column("YR1099_0")]
        public short Yr10990 { get; set; }
        [Required]
        [Column("BPSNUM_0")]
        [StringLength(15)]
        public string Bpsnum0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Column("SEQ_0")]
        public int Seq0 { get; set; }
        [Column("FRM1099_0")]
        public byte Frm10990 { get; set; }
        [Required]
        [Column("BOX1099_0")]
        [StringLength(4)]
        public string Box10990 { get; set; }
        [Column("BEGBAL_0", TypeName = "numeric(27, 13)")]
        public decimal Begbal0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}