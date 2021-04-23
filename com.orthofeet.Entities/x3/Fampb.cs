﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("FAMPB", Schema = "TESTPROD")]
    [Index(nameof(Num0), Name = "FAMPB_PBL0", IsUnique = true)]
    [Index(nameof(Num0), nameof(Paegrpnum0), Name = "FAMPB_PBL1", IsUnique = true)]
    [Index(nameof(Sut0), Name = "FAMPB_PBL2")]
    public partial class Fampb
    {
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Required]
        [Column("GRPPBLDES_0")]
        [StringLength(60)]
        public string Grppbldes0 { get; set; }
        [Required]
        [Column("PAEGRPNUM_0")]
        [StringLength(20)]
        public string Paegrpnum0 { get; set; }
        [Required]
        [Column("PBLBPC_0")]
        [StringLength(15)]
        public string Pblbpc0 { get; set; }
        [Required]
        [Column("SUT_0")]
        [StringLength(10)]
        public string Sut0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}