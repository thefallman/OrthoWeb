﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AMENUSER", Schema = "TESTPROD")]
    [Index(nameof(Codprf0), nameof(Numlig0), Name = "AMENUSER_CODMEN", IsUnique = true)]
    [Index(nameof(Codprf0), nameof(Menu0), nameof(Numlig0), Name = "AMENUSER_MENCOD", IsUnique = true)]
    [Index(nameof(Codprf0), nameof(Fonction0), Name = "AMENUSER_MENFCT")]
    public partial class Amenuser
    {
        [Required]
        [Column("CODMEN_0")]
        [StringLength(15)]
        public string Codmen0 { get; set; }
        [Required]
        [Column("FONCTION_0")]
        [StringLength(10)]
        public string Fonction0 { get; set; }
        [Column("LIBMENU_0")]
        public int Libmenu0 { get; set; }
        [Required]
        [Column("INTIT_0")]
        [StringLength(35)]
        public string Intit0 { get; set; }
        [Required]
        [Column("MENU_0")]
        [StringLength(5)]
        public string Menu0 { get; set; }
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
        [Required]
        [Column("ORDSYS_0")]
        [StringLength(40)]
        public string Ordsys0 { get; set; }
        [Column("TYPFCT_0")]
        public short Typfct0 { get; set; }
        [Required]
        [Column("CODPRF_0")]
        [StringLength(5)]
        public string Codprf0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}