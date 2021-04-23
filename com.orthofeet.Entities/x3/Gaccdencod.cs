﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GACCDENCOD", Schema = "TESTPROD")]
    [Index(nameof(Cod0), Name = "GACCDENCOD_CDA0", IsUnique = true)]
    public partial class Gaccdencod
    {
        [Required]
        [Column("COD_0")]
        [StringLength(5)]
        public string Cod0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Required]
        [Column("DESSHO_0")]
        [StringLength(10)]
        public string Dessho0 { get; set; }
        [Column("ACCTYP_0")]
        public byte Acctyp0 { get; set; }
        [Column("ACCVCRFLG_0")]
        public byte Accvcrflg0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Required]
        [Column("GFY_0")]
        [StringLength(5)]
        public string Gfy0 { get; set; }
        [Required]
        [Column("CIB_0")]
        [StringLength(20)]
        public string Cib0 { get; set; }
        [Required]
        [Column("ACCBPR_0")]
        [StringLength(10)]
        public string Accbpr0 { get; set; }
        [Required]
        [Column("ACCCOD_0")]
        [StringLength(10)]
        public string Acccod0 { get; set; }
        [Column("ACCSNS_0")]
        public byte Accsns0 { get; set; }
        [Column("IPTDAC_0")]
        public byte Iptdac0 { get; set; }
        [Required]
        [Column("IPTCOD_0")]
        [StringLength(5)]
        public string Iptcod0 { get; set; }
        [Column("IPTTYP_0")]
        public byte Ipttyp0 { get; set; }
        [Column("IPTDEP_0")]
        public byte Iptdep0 { get; set; }
        [Required]
        [Column("BPSPIVTYP_0")]
        [StringLength(1)]
        public string Bpspivtyp0 { get; set; }
        [Required]
        [Column("BPCPIVTYP_0")]
        [StringLength(1)]
        public string Bpcpivtyp0 { get; set; }
        [Column("RPCVAT_0")]
        public byte Rpcvat0 { get; set; }
        [Column("AMTMAX_0", TypeName = "numeric(27, 13)")]
        public decimal Amtmax0 { get; set; }
        [Column("PRCMAX_0", TypeName = "numeric(7, 3)")]
        public decimal Prcmax0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Required]
        [Column("ACS_0")]
        [StringLength(10)]
        public string Acs0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}