// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABROUND", Schema = "TESTPROD")]
    [Index(nameof(Rndcod0), Name = "TABROUND_TRD0", IsUnique = true)]
    public partial class Tabround
    {
        [Required]
        [Column("RNDCOD_0")]
        [StringLength(3)]
        public string Rndcod0 { get; set; }
        [Required]
        [Column("RNDDES_0")]
        [StringLength(30)]
        public string Rnddes0 { get; set; }
        [Required]
        [Column("RNDSHO_0")]
        [StringLength(10)]
        public string Rndsho0 { get; set; }
        [Column("RNDTYP_0")]
        public byte Rndtyp0 { get; set; }
        [Column("RNDDEC_0", TypeName = "numeric(7, 3)")]
        public decimal Rnddec0 { get; set; }
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