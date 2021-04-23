﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("WIPRESW", Schema = "TESTPROD")]
    [Index(nameof(Uid0), nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vcrlin0), nameof(Typcst0), nameof(Ovetypcst0), nameof(Brdcod0), Name = "WIPRESW_WRW0", IsUnique = true)]
    public partial class Wipresw
    {
        [Column("UID_0")]
        public int Uid0 { get; set; }
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Column("TYPCST_0")]
        public byte Typcst0 { get; set; }
        [Column("OVETYPCST_0")]
        public byte Ovetypcst0 { get; set; }
        [Column("BRDCOD_0")]
        public short Brdcod0 { get; set; }
        [Column("CPLAMT_0", TypeName = "numeric(20, 5)")]
        public decimal Cplamt0 { get; set; }
        [Column("EXTAMT_0", TypeName = "numeric(20, 5)")]
        public decimal Extamt0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}