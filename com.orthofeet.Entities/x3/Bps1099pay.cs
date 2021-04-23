﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BPS1099PAY", Schema = "TESTPROD")]
    [Index(nameof(Yr10990), nameof(Cpy0), nameof(Bpsnum0), nameof(Paynum0), nameof(Paylin0), Name = "BPS1099PAY_B9P0", IsUnique = true)]
    [Index(nameof(Yr10990), nameof(Cpy0), nameof(Bpsnum0), nameof(Frm10990), nameof(Box10990), Name = "BPS1099PAY_B9P1")]
    public partial class Bps1099pay
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
        [Required]
        [Column("PAYNUM_0")]
        [StringLength(20)]
        public string Paynum0 { get; set; }
        [Column("PAYLIN_0")]
        public short Paylin0 { get; set; }
        [Required]
        [Column("INVNUM_0")]
        [StringLength(20)]
        public string Invnum0 { get; set; }
        [Column("FRM1099_0")]
        public byte Frm10990 { get; set; }
        [Required]
        [Column("BOX1099_0")]
        [StringLength(4)]
        public string Box10990 { get; set; }
        [Column("AMT1099_0", TypeName = "numeric(27, 13)")]
        public decimal Amt10990 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}