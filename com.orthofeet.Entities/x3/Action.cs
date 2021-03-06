// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ACTION", Schema = "TESTPROD")]
    [Index(nameof(Action0), Name = "ACTION_ACTION", IsUnique = true)]
    public partial class Action
    {
        [Required]
        [Column("ACTION_0")]
        [StringLength(10)]
        public string Action0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Required]
        [Column("CODTRT_0")]
        [StringLength(30)]
        public string Codtrt0 { get; set; }
        [Required]
        [Column("SPETRT_0")]
        [StringLength(30)]
        public string Spetrt0 { get; set; }
        [Column("TYP_0")]
        public byte Typ0 { get; set; }
        [Column("TYPUTI_0")]
        public byte Typuti0 { get; set; }
        [Required]
        [Column("INSTRU_0")]
        [StringLength(200)]
        public string Instru0 { get; set; }
        [Column("INTITA_0")]
        public int Intita0 { get; set; }
        [Column("INTITC_0")]
        public int Intitc0 { get; set; }
        [Column("INTITL_0")]
        public int Intitl0 { get; set; }
        [Column("NBPAR_0")]
        public short Nbpar0 { get; set; }
        [Required]
        [Column("SUBPRG_0")]
        [StringLength(30)]
        public string Subprg0 { get; set; }
        [Column("TYPACT_0")]
        public byte Typact0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Required]
        [Column("PARAM1_0")]
        [StringLength(3)]
        public string Param10 { get; set; }
        [Required]
        [Column("PARAM2_0")]
        [StringLength(12)]
        public string Param20 { get; set; }
        [Column("PARAM3_0")]
        public byte Param30 { get; set; }
        [Required]
        [Column("PARAM4_0")]
        [StringLength(12)]
        public string Param40 { get; set; }
        [Required]
        [Column("PARAM5_0")]
        [StringLength(10)]
        public string Param50 { get; set; }
        [Column("PARAM6_0")]
        public byte Param60 { get; set; }
        [Required]
        [Column("ACTSUI_0")]
        [StringLength(10)]
        public string Actsui0 { get; set; }
        [Column("AMSFLG_0")]
        public byte Amsflg0 { get; set; }
        [Column("ABTFLG_0")]
        public byte Abtflg0 { get; set; }
        [Column("PUBFLG_0")]
        public byte Pubflg0 { get; set; }
        [Column("NOWEB_0")]
        public byte Noweb0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}