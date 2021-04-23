﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AREFAML", Schema = "TESTPROD")]
    [Index(nameof(Nolib0), nameof(Num0), Name = "AREFAML_ARN0", IsUnique = true)]
    public partial class Arefaml
    {
        [Column("NOLIB_0")]
        public short Nolib0 { get; set; }
        [Column("NUM_0")]
        public int Num0 { get; set; }
        [Required]
        [Column("CODMSK_0")]
        [StringLength(12)]
        public string Codmsk0 { get; set; }
        [Required]
        [Column("CODZON_0")]
        [StringLength(12)]
        public string Codzon0 { get; set; }
        [Required]
        [Column("CLES_0")]
        [StringLength(50)]
        public string Cles0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}