﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("HD8CLOB", Schema = "TESTPROD")]
    [Index(nameof(Num0), nameof(Typ0), Name = "HD8CLOB_HD80", IsUnique = true)]
    public partial class Hd8clob
    {
        [Required]
        [Column("NUM_0")]
        [StringLength(30)]
        public string Num0 { get; set; }
        [Required]
        [Column("TYP_0")]
        [StringLength(10)]
        public string Typ0 { get; set; }
        [Required]
        [Column("CLOB_0")]
        public string Clob0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}