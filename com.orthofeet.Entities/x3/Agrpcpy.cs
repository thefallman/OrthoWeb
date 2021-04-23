﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AGRPCPY", Schema = "TESTPROD")]
    [Index(nameof(Grp0), nameof(Cpy0), Name = "AGRPCPY_AGC0", IsUnique = true)]
    [Index(nameof(Cpy0), nameof(Grp0), Name = "AGRPCPY_AGC1", IsUnique = true)]
    public partial class Agrpcpy
    {
        [Required]
        [Column("GRP_0")]
        [StringLength(5)]
        public string Grp0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}