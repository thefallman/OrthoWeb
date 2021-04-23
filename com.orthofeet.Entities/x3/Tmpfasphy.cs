﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TMPFASPHY", Schema = "TESTPROD")]
    [Index(nameof(Numlig0), Name = "TMPFASPHY_TPH0", IsUnique = true)]
    public partial class Tmpfasphy
    {
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
        [Required]
        [Column("AASREF_0")]
        [StringLength(20)]
        public string Aasref0 { get; set; }
        [Column("MNT_0", TypeName = "numeric(27, 13)")]
        public decimal Mnt0 { get; set; }
        [Required]
        [Column("CODLOF_0")]
        [StringLength(20)]
        public string Codlof0 { get; set; }
        [Column("AASQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Aasqty0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}