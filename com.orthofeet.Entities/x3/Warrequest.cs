﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("WARREQUEST", Schema = "TESTPROD")]
    [Index(nameof(Rqwnum0), Name = "WARREQUEST_RQW0", IsUnique = true)]
    public partial class Warrequest
    {
        [Required]
        [Column("RQWNUM_0")]
        [StringLength(20)]
        public string Rqwnum0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("BPC_0")]
        [StringLength(15)]
        public string Bpc0 { get; set; }
        [Required]
        [Column("BPAADD_0")]
        [StringLength(7)]
        public string Bpaadd0 { get; set; }
        [Required]
        [Column("CCN_0")]
        [StringLength(15)]
        public string Ccn0 { get; set; }
        [Column("RQWCFMFLG_0")]
        public byte Rqwcfmflg0 { get; set; }
        [Column("CFMDAT_0", TypeName = "datetime")]
        public DateTime Cfmdat0 { get; set; }
        [Required]
        [Column("CFMUSR_0")]
        [StringLength(5)]
        public string Cfmusr0 { get; set; }
        [Required]
        [Column("CFMHOU_0")]
        [StringLength(5)]
        public string Cfmhou0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("CREHOU_0")]
        [StringLength(5)]
        public string Crehou0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}