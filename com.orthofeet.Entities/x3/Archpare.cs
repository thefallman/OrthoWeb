﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ARCHPARE", Schema = "TESTPROD")]
    [Index(nameof(Typdoc0), nameof(Idtvol0), nameof(Numlig0), Name = "ARCHPARE_ARE0", IsUnique = true)]
    public partial class Archpare
    {
        [Required]
        [Column("TYPDOC_0")]
        [StringLength(20)]
        public string Typdoc0 { get; set; }
        [Required]
        [Column("IDTVOL_0")]
        [StringLength(20)]
        public string Idtvol0 { get; set; }
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
        [Required]
        [Column("CODPAR_0")]
        [StringLength(50)]
        public string Codpar0 { get; set; }
        [Column("TYPPAR_0")]
        public byte Typpar0 { get; set; }
        [Column("ADRPAR_0")]
        public byte Adrpar0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}