﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SRETURND", Schema = "TESTPROD")]
    [Index(nameof(Srhnum0), nameof(Srdlin0), Name = "SRETURND_SRD0", IsUnique = true)]
    [Index(nameof(Sdhnum0), nameof(Sddlin0), Name = "SRETURND_SRD1")]
    [Index(nameof(Sihnum0), nameof(Rtncnoflg0), Name = "SRETURND_SRD2")]
    public partial class Sreturnd
    {
        [Required]
        [Column("SRHNUM_0")]
        [StringLength(20)]
        public string Srhnum0 { get; set; }
        [Column("SRDLIN_0")]
        public int Srdlin0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("ITMDES1_0")]
        [StringLength(30)]
        public string Itmdes10 { get; set; }
        [Required]
        [Column("ITMDES_0")]
        [StringLength(30)]
        public string Itmdes0 { get; set; }
        [Required]
        [Column("SDHNUM_0")]
        [StringLength(20)]
        public string Sdhnum0 { get; set; }
        [Column("SDDLIN_0")]
        public int Sddlin0 { get; set; }
        [Column("DLVQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Dlvqty0 { get; set; }
        [Column("EXTQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Extqty0 { get; set; }
        [Column("EXTQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Extqtystu0 { get; set; }
        [Column("QTY_0", TypeName = "numeric(28, 13)")]
        public decimal Qty0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Required]
        [Column("SAU_0")]
        [StringLength(3)]
        public string Sau0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Column("SAUSTUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Saustucoe0 { get; set; }
        [Column("NETPRI_0", TypeName = "numeric(19, 5)")]
        public decimal Netpri0 { get; set; }
        [Column("NETPRINOT_0", TypeName = "numeric(19, 5)")]
        public decimal Netprinot0 { get; set; }
        [Column("NETPRIATI_0", TypeName = "numeric(19, 5)")]
        public decimal Netpriati0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Required]
        [Column("RTNREN_0")]
        [StringLength(20)]
        public string Rtnren0 { get; set; }
        [Column("RTNDAT_0", TypeName = "datetime")]
        public DateTime Rtndat0 { get; set; }
        [Column("RTNSTOUPD_0")]
        public byte Rtnstoupd0 { get; set; }
        [Column("RTNINVUPD_0")]
        public byte Rtninvupd0 { get; set; }
        [Column("RTNCNOFLG_0")]
        public byte Rtncnoflg0 { get; set; }
        [Column("ORDUPD_0")]
        public byte Ordupd0 { get; set; }
        [Required]
        [Column("SIHNUM_0")]
        [StringLength(20)]
        public string Sihnum0 { get; set; }
        [Column("SIDLIN_0")]
        public int Sidlin0 { get; set; }
        [Required]
        [Column("SCSNUM_0")]
        [StringLength(20)]
        public string Scsnum0 { get; set; }
        [Column("SCSLIN_0")]
        public int Scslin0 { get; set; }
        [Column("SCSDAT_0", TypeName = "datetime")]
        public DateTime Scsdat0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("SRDTEX_0")]
        [StringLength(12)]
        public string Srdtex0 { get; set; }
        [Column("PRIORD_0", TypeName = "numeric(27, 13)")]
        public decimal Priord0 { get; set; }
        [Required]
        [Column("PNHNUM_0")]
        [StringLength(20)]
        public string Pnhnum0 { get; set; }
        [Column("PNDLIN_0")]
        public int Pndlin0 { get; set; }
        [Required]
        [Column("WRH_0")]
        [StringLength(1)]
        public string Wrh0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Column("IMPNUMLIG_0")]
        public int Impnumlig0 { get; set; }
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