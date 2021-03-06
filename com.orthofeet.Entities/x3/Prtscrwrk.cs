// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PRTSCRWRK", Schema = "TESTPROD")]
    [Index(nameof(Creusr0), nameof(Pronum0), nameof(Pronumseq0), nameof(Reccod0), nameof(Recseq0), Name = "PRTSCRWRK_PSW0", IsUnique = true)]
    public partial class Prtscrwrk
    {
        [Required]
        [Column("PRONUM_0")]
        [StringLength(10)]
        public string Pronum0 { get; set; }
        [Column("PRONUMSEQ_0")]
        public int Pronumseq0 { get; set; }
        [Column("RECCOD_0")]
        public int Reccod0 { get; set; }
        [Column("RECSEQ_0")]
        public int Recseq0 { get; set; }
        [Required]
        [Column("LIN_0")]
        [StringLength(250)]
        public string Lin0 { get; set; }
        [Column("PRTFLG_0")]
        public byte Prtflg0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}