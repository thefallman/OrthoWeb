﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("INVPRB", Schema = "TESTPROD")]
    [Index(nameof(Iparef0), nameof(Ipblin0), Name = "INVPRB_IPB0", IsUnique = true)]
    [Index(nameof(Iparef0), nameof(Ipbfldcoc0), Name = "INVPRB_IPB1", IsUnique = true)]
    public partial class Invprb
    {
        [Required]
        [Column("IPAREF_0")]
        [StringLength(10)]
        public string Iparef0 { get; set; }
        [Column("IPBLIN_0")]
        public short Ipblin0 { get; set; }
        [Required]
        [Column("IPBZONREF_0")]
        [StringLength(12)]
        public string Ipbzonref0 { get; set; }
        [Required]
        [Column("IPBFLDCOC_0")]
        [StringLength(14)]
        public string Ipbfldcoc0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}