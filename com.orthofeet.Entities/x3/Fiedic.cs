﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("FIEDIC", Schema = "TESTPROD")]
    [Index(nameof(Critab0), nameof(Cat0), Name = "FIEDIC_FID0", IsUnique = true)]
    public partial class Fiedic
    {
        [Required]
        [Column("CRITAB_0")]
        [StringLength(12)]
        public string Critab0 { get; set; }
        [Column("STD_0")]
        public short Std0 { get; set; }
        [Required]
        [Column("CAT_0")]
        [StringLength(20)]
        public string Cat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}