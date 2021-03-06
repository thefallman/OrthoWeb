// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABPAYTERM", Schema = "TESTPROD")]
    [Index(nameof(Pte0), nameof(Ptelin0), Name = "TABPAYTERM_TPT0", IsUnique = true)]
    public partial class Tabpayterm
    {
        [Required]
        [Column("PTE_0")]
        [StringLength(15)]
        public string Pte0 { get; set; }
        [Column("PTELIN_0")]
        public short Ptelin0 { get; set; }
        [Required]
        [Column("LANDESSHO_0")]
        [StringLength(60)]
        public string Landessho0 { get; set; }
        [Required]
        [Column("PAM_0")]
        [StringLength(20)]
        public string Pam0 { get; set; }
        [Column("PAMTYP_0")]
        public byte Pamtyp0 { get; set; }
        [Column("DUDPRC_0", TypeName = "numeric(8, 3)")]
        public decimal Dudprc0 { get; set; }
        [Column("VATPRC_0", TypeName = "numeric(8, 3)")]
        public decimal Vatprc0 { get; set; }
        [Column("NBRMON_0")]
        public short Nbrmon0 { get; set; }
        [Column("NBRDAY_0")]
        public short Nbrday0 { get; set; }
        [Column("ENDMONFLG_0")]
        public byte Endmonflg0 { get; set; }
        [Column("DAYMON_0")]
        public short Daymon0 { get; set; }
        [Column("DAYMON_1")]
        public short Daymon1 { get; set; }
        [Column("DAYMON_2")]
        public short Daymon2 { get; set; }
        [Column("DAYMON_3")]
        public short Daymon3 { get; set; }
        [Column("DAYMON_4")]
        public short Daymon4 { get; set; }
        [Column("DAYMON_5")]
        public short Daymon5 { get; set; }
        [Column("DUDMINAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Dudminamt0 { get; set; }
        [Column("FBDDAYFLG_0")]
        public byte Fbddayflg0 { get; set; }
        [Column("FBDDAYFLG_1")]
        public byte Fbddayflg1 { get; set; }
        [Column("FBDDAYFLG_2")]
        public byte Fbddayflg2 { get; set; }
        [Column("FBDDAYFLG_3")]
        public byte Fbddayflg3 { get; set; }
        [Column("FBDDAYFLG_4")]
        public byte Fbddayflg4 { get; set; }
        [Column("FBDDAYFLG_5")]
        public byte Fbddayflg5 { get; set; }
        [Column("FBDDAYFLG_6")]
        public byte Fbddayflg6 { get; set; }
        [Column("FBDHLYFLG_0")]
        public byte Fbdhlyflg0 { get; set; }
        [Column("SOIFLG_0")]
        public byte Soiflg0 { get; set; }
        [Required]
        [Column("RPLPTE_0")]
        [StringLength(15)]
        public string Rplpte0 { get; set; }
        [Column("PTEMINAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Pteminamt0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Required]
        [Column("GFY_0")]
        [StringLength(5)]
        public string Gfy0 { get; set; }
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