﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABCHANGE", Schema = "TESTPROD")]
    [Index(nameof(Chgtyp0), nameof(Curden0), nameof(Cur0), nameof(Chgstrdat0), Name = "TABCHANGE_TCH0", IsUnique = true)]
    [Index(nameof(Chgtyp0), nameof(Curden0), nameof(Chgstrdat0), nameof(Cur0), Name = "TABCHANGE_TCH1", IsUnique = true)]
    public partial class Tabchange
    {
        [Column("CHGTYP_0")]
        public byte Chgtyp0 { get; set; }
        [Required]
        [Column("CURDEN_0")]
        [StringLength(3)]
        public string Curden0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("CHGSTRDAT_0", TypeName = "datetime")]
        public DateTime Chgstrdat0 { get; set; }
        [Column("CHGRAT_0", TypeName = "numeric(21, 10)")]
        public decimal Chgrat0 { get; set; }
        [Column("REVCOURS_0", TypeName = "numeric(21, 10)")]
        public decimal Revcours0 { get; set; }
        [Column("CHGDIV_0", TypeName = "numeric(21, 10)")]
        public decimal Chgdiv0 { get; set; }
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