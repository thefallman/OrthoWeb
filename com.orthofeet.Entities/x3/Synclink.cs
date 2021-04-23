﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SYNCLINK", Schema = "TESTPROD")]
    [Index(nameof(Sylnum0), Name = "SYNCLINK_SYL0", IsUnique = true)]
    public partial class Synclink
    {
        [Required]
        [Column("SYLNUM_0")]
        [StringLength(20)]
        public string Sylnum0 { get; set; }
        [Required]
        [Column("SYLUSR_0")]
        [StringLength(5)]
        public string Sylusr0 { get; set; }
        [Required]
        [Column("SYLTYP_0")]
        [StringLength(3)]
        public string Syltyp0 { get; set; }
        [Required]
        [Column("SYLKEY_0")]
        [StringLength(20)]
        public string Sylkey0 { get; set; }
        [Required]
        [Column("SYLFIE_0")]
        [StringLength(12)]
        public string Sylfie0 { get; set; }
        [Required]
        [Column("SYLVALOTK_0")]
        [StringLength(250)]
        public string Sylvalotk0 { get; set; }
        [Required]
        [Column("SYLVALADX_0")]
        [StringLength(250)]
        public string Sylvaladx0 { get; set; }
        [Column("SYLFLGDPT_0")]
        public short Sylflgdpt0 { get; set; }
        [Column("SYLNIV_0")]
        public short Sylniv0 { get; set; }
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