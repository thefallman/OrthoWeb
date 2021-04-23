﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AWRKUSR", Schema = "TESTPROD")]
    [Index(nameof(User0), nameof(Numdel0), Name = "AWRKUSR_AWU0", IsUnique = true)]
    public partial class Awrkusr
    {
        [Required]
        [Column("USER_0")]
        [StringLength(5)]
        public string User0 { get; set; }
        [Column("NUMDEL_0")]
        public short Numdel0 { get; set; }
        [Required]
        [Column("USRDEL_0")]
        [StringLength(5)]
        public string Usrdel0 { get; set; }
        [Required]
        [Column("NATURE_0")]
        [StringLength(20)]
        public string Nature0 { get; set; }
        [Column("TYPDEL_0")]
        public byte Typdel0 { get; set; }
        [Column("VLYSTR_0", TypeName = "datetime")]
        public DateTime Vlystr0 { get; set; }
        [Column("VLYEND_0", TypeName = "datetime")]
        public DateTime Vlyend0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}