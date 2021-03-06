// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABSTASTO", Schema = "TESTPROD")]
    [Index(nameof(Stasto0), Name = "TABSTASTO_TST0", IsUnique = true)]
    public partial class Tabstasto
    {
        [Required]
        [Column("STASTO_0")]
        [StringLength(3)]
        public string Stasto0 { get; set; }
        [Required]
        [Column("STADES_0")]
        [StringLength(30)]
        public string Stades0 { get; set; }
        [Required]
        [Column("STASHO_0")]
        [StringLength(10)]
        public string Stasho0 { get; set; }
        [Required]
        [Column("EXYQQQSTA_0")]
        [StringLength(3)]
        public string Exyqqqsta0 { get; set; }
        [Required]
        [Column("EXYRRRSTA_0")]
        [StringLength(3)]
        public string Exyrrrsta0 { get; set; }
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