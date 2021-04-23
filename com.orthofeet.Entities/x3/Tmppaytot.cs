﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TMPPAYTOT", Schema = "TESTPROD")]
    [Index(nameof(Trc0), nameof(Paytyp0), nameof(Fcy0), nameof(Cur0), nameof(Ban0), nameof(Duddat0), nameof(Sns0), Name = "TMPPAYTOT_PYT0", IsUnique = true)]
    public partial class Tmppaytot
    {
        [Required]
        [Column("TRC_0")]
        [StringLength(20)]
        public string Trc0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("PAYTYP_0")]
        [StringLength(5)]
        public string Paytyp0 { get; set; }
        [Column("DUDDAT_0", TypeName = "datetime")]
        public DateTime Duddat0 { get; set; }
        [Required]
        [Column("BAN_0")]
        [StringLength(5)]
        public string Ban0 { get; set; }
        [Column("SNS_0")]
        public byte Sns0 { get; set; }
        [Column("AMTCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Amtcur0 { get; set; }
        [Column("AMTLOC_0", TypeName = "numeric(27, 13)")]
        public decimal Amtloc0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}