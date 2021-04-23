﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ADOVALAUS", Schema = "TESTPROD")]
    [Index(nameof(Codusr0), nameof(Param0), Name = "ADOVALAUS_ADU0", IsUnique = true)]
    [Index(nameof(Param0), nameof(Codusr0), Name = "ADOVALAUS_ADU1", IsUnique = true)]
    public partial class Adovalau
    {
        [Required]
        [Column("CODUSR_0")]
        [StringLength(5)]
        public string Codusr0 { get; set; }
        [Required]
        [Column("PARAM_0")]
        [StringLength(10)]
        public string Param0 { get; set; }
        [Required]
        [Column("VALEUR_0")]
        [StringLength(250)]
        public string Valeur0 { get; set; }
        [Required]
        [Column("JEU_0")]
        [StringLength(20)]
        public string Jeu0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}