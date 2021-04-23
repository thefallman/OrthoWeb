﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PARTAXUSA", Schema = "TESTPROD")]
    [Index(nameof(Cod0), Name = "PARTAXUSA_PTU0", IsUnique = true)]
    public partial class Partaxusa
    {
        [Required]
        [Column("COD_0")]
        [StringLength(10)]
        public string Cod0 { get; set; }
        [Required]
        [Column("DIRECTORY_0")]
        [StringLength(250)]
        public string Directory0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}