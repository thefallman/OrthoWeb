﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SCRIPT", Schema = "TESTPROD")]
    [Index(nameof(Scpnum0), Name = "SCRIPT_SCP0", IsUnique = true)]
    public partial class Script
    {
        [Required]
        [Column("SCPNUM_0")]
        [StringLength(20)]
        public string Scpnum0 { get; set; }
        [Required]
        [Column("SCPNAM_0")]
        [StringLength(60)]
        public string Scpnam0 { get; set; }
        [Required]
        [Column("SALFCY_0")]
        [StringLength(5)]
        public string Salfcy0 { get; set; }
        [Column("SCPFLG_0")]
        public byte Scpflg0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}