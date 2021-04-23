﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SORDERP", Schema = "TESTPROD")]
    [Index(nameof(Sohnum0), nameof(Soplin0), nameof(Sopseq0), Name = "SORDERP_SOP0", IsUnique = true)]
    [Index(nameof(Bpcord0), nameof(Bpaadd0), nameof(Itmref0), nameof(Enddat0), Name = "SORDERP_SOP1")]
    [Index(nameof(Soqsta0), nameof(Sohcat0), nameof(Stofcy0), nameof(Bpcord0), nameof(Bpaadd0), Name = "SORDERP_SOP2")]
    [Index(nameof(Sohnum0), nameof(Soplin0), Name = "SORDERP_SOP3")]
    [Index(nameof(Soqsta0), nameof(Sohcat0), nameof(Salfcy0), nameof(Bpcinv0), Name = "SORDERP_SOP4")]
    public partial class Sorderp
    {
        [Required]
        [Column("SOHNUM_0")]
        [StringLength(20)]
        public string Sohnum0 { get; set; }
        [Column("SOPLIN_0")]
        public int Soplin0 { get; set; }
        [Column("SOPSEQ_0")]
        public int Sopseq0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Column("SOHCAT_0")]
        public byte Sohcat0 { get; set; }
        [Column("STRDAT_0", TypeName = "datetime")]
        public DateTime Strdat0 { get; set; }
        [Column("ENDDAT_0", TypeName = "datetime")]
        public DateTime Enddat0 { get; set; }
        [Required]
        [Column("BPCORD_0")]
        [StringLength(15)]
        public string Bpcord0 { get; set; }
        [Required]
        [Column("BPAADD_0")]
        [StringLength(7)]
        public string Bpaadd0 { get; set; }
        [Required]
        [Column("CNDNAM_0")]
        [StringLength(15)]
        public string Cndnam0 { get; set; }
        [Required]
        [Column("BPCINV_0")]
        [StringLength(15)]
        public string Bpcinv0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("SALFCY_0")]
        [StringLength(5)]
        public string Salfcy0 { get; set; }
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
        [Column("ITMREFBPC_0")]
        [StringLength(20)]
        public string Itmrefbpc0 { get; set; }
        [Required]
        [Column("VACITM_0")]
        [StringLength(20)]
        public string Vacitm0 { get; set; }
        [Required]
        [Column("VACITM_1")]
        [StringLength(20)]
        public string Vacitm1 { get; set; }
        [Required]
        [Column("VACITM_2")]
        [StringLength(20)]
        public string Vacitm2 { get; set; }
        [Required]
        [Column("REP1_0")]
        [StringLength(15)]
        public string Rep10 { get; set; }
        [Required]
        [Column("REP2_0")]
        [StringLength(15)]
        public string Rep20 { get; set; }
        [Column("REPRAT1_0", TypeName = "numeric(8, 3)")]
        public decimal Reprat10 { get; set; }
        [Column("REPRAT2_0", TypeName = "numeric(8, 3)")]
        public decimal Reprat20 { get; set; }
        [Column("REPCOE_0", TypeName = "numeric(6, 3)")]
        public decimal Repcoe0 { get; set; }
        [Column("GROPRI_0", TypeName = "numeric(19, 5)")]
        public decimal Gropri0 { get; set; }
        [Column("PRIREN_0")]
        public short Priren0 { get; set; }
        [Column("NETPRI_0", TypeName = "numeric(19, 5)")]
        public decimal Netpri0 { get; set; }
        [Column("NETPRINOT_0", TypeName = "numeric(19, 5)")]
        public decimal Netprinot0 { get; set; }
        [Column("NETPRIATI_0", TypeName = "numeric(19, 5)")]
        public decimal Netpriati0 { get; set; }
        [Column("PFM_0", TypeName = "numeric(27, 13)")]
        public decimal Pfm0 { get; set; }
        [Column("CPRPRI_0", TypeName = "numeric(19, 5)")]
        public decimal Cprpri0 { get; set; }
        [Column("DISCRGVAL1_0", TypeName = "numeric(19, 5)")]
        public decimal Discrgval10 { get; set; }
        [Column("DISCRGVAL2_0", TypeName = "numeric(19, 5)")]
        public decimal Discrgval20 { get; set; }
        [Column("DISCRGVAL3_0", TypeName = "numeric(19, 5)")]
        public decimal Discrgval30 { get; set; }
        [Column("DISCRGVAL4_0", TypeName = "numeric(28, 8)")]
        public decimal Discrgval40 { get; set; }
        [Column("DISCRGVAL5_0", TypeName = "numeric(28, 8)")]
        public decimal Discrgval50 { get; set; }
        [Column("DISCRGVAL6_0", TypeName = "numeric(28, 8)")]
        public decimal Discrgval60 { get; set; }
        [Column("DISCRGVAL7_0", TypeName = "numeric(28, 8)")]
        public decimal Discrgval70 { get; set; }
        [Column("DISCRGVAL8_0", TypeName = "numeric(28, 8)")]
        public decimal Discrgval80 { get; set; }
        [Column("DISCRGVAL9_0", TypeName = "numeric(28, 8)")]
        public decimal Discrgval90 { get; set; }
        [Column("DISCRGREN1_0")]
        public short Discrgren10 { get; set; }
        [Column("DISCRGREN2_0")]
        public short Discrgren20 { get; set; }
        [Column("DISCRGREN3_0")]
        public short Discrgren30 { get; set; }
        [Column("DISCRGREN4_0")]
        public short Discrgren40 { get; set; }
        [Column("DISCRGREN5_0")]
        public short Discrgren50 { get; set; }
        [Column("DISCRGREN6_0")]
        public short Discrgren60 { get; set; }
        [Column("DISCRGREN7_0")]
        public short Discrgren70 { get; set; }
        [Column("DISCRGREN8_0")]
        public short Discrgren80 { get; set; }
        [Column("DISCRGREN9_0")]
        public short Discrgren90 { get; set; }
        [Required]
        [Column("VAT_0")]
        [StringLength(5)]
        public string Vat0 { get; set; }
        [Required]
        [Column("VAT_1")]
        [StringLength(5)]
        public string Vat1 { get; set; }
        [Required]
        [Column("VAT_2")]
        [StringLength(5)]
        public string Vat2 { get; set; }
        [Column("CLCAMT1_0", TypeName = "numeric(27, 13)")]
        public decimal Clcamt10 { get; set; }
        [Column("CLCAMT2_0", TypeName = "numeric(27, 13)")]
        public decimal Clcamt20 { get; set; }
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
        [Required]
        [Column("TSICOD_0")]
        [StringLength(20)]
        public string Tsicod0 { get; set; }
        [Required]
        [Column("TSICOD_1")]
        [StringLength(20)]
        public string Tsicod1 { get; set; }
        [Required]
        [Column("TSICOD_2")]
        [StringLength(20)]
        public string Tsicod2 { get; set; }
        [Required]
        [Column("TSICOD_3")]
        [StringLength(20)]
        public string Tsicod3 { get; set; }
        [Required]
        [Column("TSICOD_4")]
        [StringLength(20)]
        public string Tsicod4 { get; set; }
        [Column("SOQSTA_0")]
        public byte Soqsta0 { get; set; }
        [Column("LINTYP_0")]
        public byte Lintyp0 { get; set; }
        [Column("FOCFLG_0")]
        public byte Focflg0 { get; set; }
        [Column("ORILIN_0")]
        public int Orilin0 { get; set; }
        [Required]
        [Column("SQHNUM_0")]
        [StringLength(20)]
        public string Sqhnum0 { get; set; }
        [Required]
        [Column("CONNUM_0")]
        [StringLength(20)]
        public string Connum0 { get; set; }
        [Column("SQDLIN_0")]
        public int Sqdlin0 { get; set; }
        [Column("LINREVNUM_0")]
        public short Linrevnum0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
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
        [Required]
        [Column("YPATIENT_0")]
        [StringLength(30)]
        public string Ypatient0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}