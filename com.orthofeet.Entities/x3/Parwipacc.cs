﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PARWIPACC", Schema = "TESTPROD")]
    [Index(nameof(Leg0), nameof(Cpy0), nameof(Txntyp0), Name = "PARWIPACC_PWA0", IsUnique = true)]
    public partial class Parwipacc
    {
        [Column("TXNTYP_0")]
        public byte Txntyp0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("KEY1_0")]
        [StringLength(50)]
        public string Key10 { get; set; }
        [Required]
        [Column("KEY2_0")]
        [StringLength(50)]
        public string Key20 { get; set; }
        [Required]
        [Column("KEY3_0")]
        [StringLength(50)]
        public string Key30 { get; set; }
        [Required]
        [Column("KEY4_0")]
        [StringLength(50)]
        public string Key40 { get; set; }
        [Required]
        [Column("KEY5_0")]
        [StringLength(50)]
        public string Key50 { get; set; }
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