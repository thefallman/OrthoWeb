﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BOMRET", Schema = "TESTPROD")]
    [Index(nameof(Bmruid0), nameof(Itmref0), nameof(Niv0), Name = "BOMRET_BMR0", IsUnique = true)]
    public partial class Bomret
    {
        [Column("BMRUID_0")]
        public int Bmruid0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Column("DATREF_0", TypeName = "datetime")]
        public DateTime Datref0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("ITMSTA_0")]
        public byte Itmsta0 { get; set; }
        [Column("NIV_0")]
        public short Niv0 { get; set; }
        [Required]
        [Column("FLG_0")]
        [StringLength(1)]
        public string Flg0 { get; set; }
        [Column("BOMALT_0")]
        public short Bomalt0 { get; set; }
        [Column("BOMALTTYP_0")]
        public byte Bomalttyp0 { get; set; }
        [Required]
        [Column("ITMCMP_0")]
        [StringLength(20)]
        public string Itmcmp0 { get; set; }
        [Column("USESTA_0")]
        public byte Usesta0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Required]
        [Column("TCLCOD_0")]
        [StringLength(5)]
        public string Tclcod0 { get; set; }
        [Column("RETQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Retqty0 { get; set; }
        [Column("AVAQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Avaqty0 { get; set; }
        [Column("SHTQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Shtqty0 { get; set; }
        [Column("TRTCOD_0")]
        public short Trtcod0 { get; set; }
        [Column("IMULT_0")]
        public short Imult0 { get; set; }
        [Column("LTI_0", TypeName = "numeric(9, 4)")]
        public decimal Lti0 { get; set; }
        [Column("LTIUOM_0")]
        public byte Ltiuom0 { get; set; }
        [Column("PURFLG_0")]
        public byte Purflg0 { get; set; }
        [Column("MFGFLG_0")]
        public byte Mfgflg0 { get; set; }
        [Column("SCPFLG_0")]
        public byte Scpflg0 { get; set; }
        [Column("SCSFLG_0")]
        public byte Scsflg0 { get; set; }
        [Column("PHAFLG_0")]
        public byte Phaflg0 { get; set; }
        [Column("GENFLG_0")]
        public byte Genflg0 { get; set; }
        [Column("TOOFLG_0")]
        public byte Tooflg0 { get; set; }
        [Column("DLVFLG_0")]
        public byte Dlvflg0 { get; set; }
        [Column("SALFLG_0")]
        public byte Salflg0 { get; set; }
        [Column("INTFLG_0")]
        public byte Intflg0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}