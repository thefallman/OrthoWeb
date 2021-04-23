﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PREQUISA", Schema = "TESTPROD")]
    [Index(nameof(Pshnum0), nameof(Psdlin0), nameof(Pqhnum0), nameof(Pqdlin0), Name = "PREQUISA_PSA0", IsUnique = true)]
    [Index(nameof(Pqhnum0), nameof(Pqdlin0), nameof(Pshnum0), nameof(Psdlin0), Name = "PREQUISA_PSA1", IsUnique = true)]
    public partial class Prequisa
    {
        [Required]
        [Column("PSHNUM_0")]
        [StringLength(20)]
        public string Pshnum0 { get; set; }
        [Column("PSDLIN_0")]
        public int Psdlin0 { get; set; }
        [Required]
        [Column("PQHNUM_0")]
        [StringLength(20)]
        public string Pqhnum0 { get; set; }
        [Column("PQDLIN_0")]
        public int Pqdlin0 { get; set; }
        [Column("QTYPUU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypuu0 { get; set; }
        [Required]
        [Column("PUU_0")]
        [StringLength(3)]
        public string Puu0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}