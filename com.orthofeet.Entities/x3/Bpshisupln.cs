﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BPSHISUPLN", Schema = "TESTPROD")]
    [Index(nameof(Bpsnum0), nameof(Cpy0), nameof(Bpsshi0), nameof(Bpsadd0), Name = "BPSHISUPLN_BSL0", IsUnique = true)]
    [Index(nameof(Bpsshi0), nameof(Bpsadd0), Name = "BPSHISUPLN_BSL1")]
    public partial class Bpshisupln
    {
        [Required]
        [Column("BPSNUM_0")]
        [StringLength(15)]
        public string Bpsnum0 { get; set; }
        [Required]
        [Column("BPSSHI_0")]
        [StringLength(15)]
        public string Bpsshi0 { get; set; }
        [Required]
        [Column("BPSADD_0")]
        [StringLength(3)]
        public string Bpsadd0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}