﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TXSP", Schema = "TESTPROD")]
    [Index(nameof(Txsnam0), nameof(Version0), nameof(Col0), Name = "TXSP_TXP0", IsUnique = true)]
    public partial class Txsp
    {
        [Required]
        [Column("TXSNAM_0")]
        [StringLength(10)]
        public string Txsnam0 { get; set; }
        [Required]
        [Column("VERSION_0")]
        [StringLength(15)]
        public string Version0 { get; set; }
        [Column("COL_0")]
        public short Col0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Column("STRDAT_0", TypeName = "datetime")]
        public DateTime Strdat0 { get; set; }
        [Column("ENDDAT_0", TypeName = "datetime")]
        public DateTime Enddat0 { get; set; }
        [Required]
        [Column("CURSEL_0")]
        [StringLength(3)]
        public string Cursel0 { get; set; }
        [Required]
        [Column("CURPRN_0")]
        [StringLength(3)]
        public string Curprn0 { get; set; }
        [Column("TYPRAT_0")]
        public byte Typrat0 { get; set; }
        [Column("TYPMNT_0")]
        public byte Typmnt0 { get; set; }
        [Required]
        [Column("NAMCOL_0")]
        [StringLength(30)]
        public string Namcol0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}