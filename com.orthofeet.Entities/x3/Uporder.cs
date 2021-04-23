﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("UPORDER", Schema = "TESTPROD")]
    [Index(nameof(Pohnum0), nameof(Revnum0), Name = "UPORDER_POH0", IsUnique = true)]
    public partial class Uporder
    {
        [Required]
        [Column("POHNUM_0")]
        [StringLength(20)]
        public string Pohnum0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("POHFCY_0")]
        [StringLength(5)]
        public string Pohfcy0 { get; set; }
        [Column("POHTYP_0")]
        public byte Pohtyp0 { get; set; }
        [Column("PURTYP_0")]
        public byte Purtyp0 { get; set; }
        [Column("REVNUM_0")]
        public short Revnum0 { get; set; }
        [Required]
        [Column("REVCOD_0")]
        [StringLength(1)]
        public string Revcod0 { get; set; }
        [Column("ORDDAT_0", TypeName = "datetime")]
        public DateTime Orddat0 { get; set; }
        [Required]
        [Column("ORDREF_0")]
        [StringLength(20)]
        public string Ordref0 { get; set; }
        [Required]
        [Column("BPSNUM_0")]
        [StringLength(15)]
        public string Bpsnum0 { get; set; }
        [Required]
        [Column("BPAADD_0")]
        [StringLength(7)]
        public string Bpaadd0 { get; set; }
        [Required]
        [Column("BPRNAM_0")]
        [StringLength(35)]
        public string Bprnam0 { get; set; }
        [Required]
        [Column("BPRNAM_1")]
        [StringLength(35)]
        public string Bprnam1 { get; set; }
        [Required]
        [Column("BPAADDLIG_0")]
        [StringLength(40)]
        public string Bpaaddlig0 { get; set; }
        [Required]
        [Column("BPAADDLIG_1")]
        [StringLength(40)]
        public string Bpaaddlig1 { get; set; }
        [Required]
        [Column("BPAADDLIG_2")]
        [StringLength(40)]
        public string Bpaaddlig2 { get; set; }
        [Required]
        [Column("POSCOD_0")]
        [StringLength(10)]
        public string Poscod0 { get; set; }
        [Required]
        [Column("CTY_0")]
        [StringLength(40)]
        public string Cty0 { get; set; }
        [Required]
        [Column("SAT_0")]
        [StringLength(35)]
        public string Sat0 { get; set; }
        [Required]
        [Column("CRY_0")]
        [StringLength(3)]
        public string Cry0 { get; set; }
        [Required]
        [Column("CRYNAM_0")]
        [StringLength(40)]
        public string Crynam0 { get; set; }
        [Required]
        [Column("BPOADD_0")]
        [StringLength(7)]
        public string Bpoadd0 { get; set; }
        [Required]
        [Column("BPONAM_0")]
        [StringLength(35)]
        public string Bponam0 { get; set; }
        [Required]
        [Column("BPONAM_1")]
        [StringLength(35)]
        public string Bponam1 { get; set; }
        [Required]
        [Column("BPOADDLIG_0")]
        [StringLength(40)]
        public string Bpoaddlig0 { get; set; }
        [Required]
        [Column("BPOADDLIG_1")]
        [StringLength(40)]
        public string Bpoaddlig1 { get; set; }
        [Required]
        [Column("BPOADDLIG_2")]
        [StringLength(40)]
        public string Bpoaddlig2 { get; set; }
        [Required]
        [Column("BPOPOSCOD_0")]
        [StringLength(10)]
        public string Bpoposcod0 { get; set; }
        [Required]
        [Column("BPOCTY_0")]
        [StringLength(40)]
        public string Bpocty0 { get; set; }
        [Required]
        [Column("BPOSAT_0")]
        [StringLength(35)]
        public string Bposat0 { get; set; }
        [Required]
        [Column("BPOCRY_0")]
        [StringLength(3)]
        public string Bpocry0 { get; set; }
        [Required]
        [Column("BPOCRYNAM_0")]
        [StringLength(40)]
        public string Bpocrynam0 { get; set; }
        [Required]
        [Column("INVFCY_0")]
        [StringLength(5)]
        public string Invfcy0 { get; set; }
        [Required]
        [Column("RCPFCY_0")]
        [StringLength(5)]
        public string Rcpfcy0 { get; set; }
        [Column("EXTRCPDAT1_0", TypeName = "datetime")]
        public DateTime Extrcpdat10 { get; set; }
        [Required]
        [Column("TSSCOD_0")]
        [StringLength(20)]
        public string Tsscod0 { get; set; }
        [Required]
        [Column("TSSCOD_1")]
        [StringLength(20)]
        public string Tsscod1 { get; set; }
        [Required]
        [Column("TSSCOD_2")]
        [StringLength(20)]
        public string Tsscod2 { get; set; }
        [Required]
        [Column("TSSCOD_3")]
        [StringLength(20)]
        public string Tsscod3 { get; set; }
        [Required]
        [Column("TSSCOD_4")]
        [StringLength(20)]
        public string Tsscod4 { get; set; }
        [Required]
        [Column("PTE_0")]
        [StringLength(15)]
        public string Pte0 { get; set; }
        [Required]
        [Column("MDL_0")]
        [StringLength(5)]
        public string Mdl0 { get; set; }
        [Required]
        [Column("BPTNUM_0")]
        [StringLength(15)]
        public string Bptnum0 { get; set; }
        [Required]
        [Column("BPRPAY_0")]
        [StringLength(15)]
        public string Bprpay0 { get; set; }
        [Required]
        [Column("BPAPAY_0")]
        [StringLength(7)]
        public string Bpapay0 { get; set; }
        [Required]
        [Column("BPSINV_0")]
        [StringLength(15)]
        public string Bpsinv0 { get; set; }
        [Required]
        [Column("BPAINV_0")]
        [StringLength(7)]
        public string Bpainv0 { get; set; }
        [Required]
        [Column("EECICT_0")]
        [StringLength(20)]
        public string Eecict0 { get; set; }
        [Required]
        [Column("ICTCTY_0")]
        [StringLength(40)]
        public string Ictcty0 { get; set; }
        [Required]
        [Column("FFWNUM_0")]
        [StringLength(15)]
        public string Ffwnum0 { get; set; }
        [Required]
        [Column("FFWADD_0")]
        [StringLength(7)]
        public string Ffwadd0 { get; set; }
        [Column("EECLOC_0")]
        public short Eecloc0 { get; set; }
        [Required]
        [Column("EECNUM_0")]
        [StringLength(1)]
        public string Eecnum0 { get; set; }
        [Required]
        [Column("BUY_0")]
        [StringLength(5)]
        public string Buy0 { get; set; }
        [Required]
        [Column("DIE_0")]
        [StringLength(3)]
        public string Die0 { get; set; }
        [Required]
        [Column("DIE_1")]
        [StringLength(3)]
        public string Die1 { get; set; }
        [Required]
        [Column("DIE_2")]
        [StringLength(3)]
        public string Die2 { get; set; }
        [Required]
        [Column("DIE_3")]
        [StringLength(3)]
        public string Die3 { get; set; }
        [Required]
        [Column("DIE_4")]
        [StringLength(3)]
        public string Die4 { get; set; }
        [Required]
        [Column("DIE_5")]
        [StringLength(3)]
        public string Die5 { get; set; }
        [Required]
        [Column("DIE_6")]
        [StringLength(3)]
        public string Die6 { get; set; }
        [Required]
        [Column("DIE_7")]
        [StringLength(3)]
        public string Die7 { get; set; }
        [Required]
        [Column("DIE_8")]
        [StringLength(3)]
        public string Die8 { get; set; }
        [Required]
        [Column("DIE_9")]
        [StringLength(3)]
        public string Die9 { get; set; }
        [Required]
        [Column("DIE_10")]
        [StringLength(3)]
        public string Die10 { get; set; }
        [Required]
        [Column("DIE_11")]
        [StringLength(3)]
        public string Die11 { get; set; }
        [Required]
        [Column("DIE_12")]
        [StringLength(3)]
        public string Die12 { get; set; }
        [Required]
        [Column("DIE_13")]
        [StringLength(3)]
        public string Die13 { get; set; }
        [Required]
        [Column("DIE_14")]
        [StringLength(3)]
        public string Die14 { get; set; }
        [Required]
        [Column("DIE_15")]
        [StringLength(3)]
        public string Die15 { get; set; }
        [Required]
        [Column("DIE_16")]
        [StringLength(3)]
        public string Die16 { get; set; }
        [Required]
        [Column("DIE_17")]
        [StringLength(3)]
        public string Die17 { get; set; }
        [Required]
        [Column("DIE_18")]
        [StringLength(3)]
        public string Die18 { get; set; }
        [Required]
        [Column("DIE_19")]
        [StringLength(3)]
        public string Die19 { get; set; }
        [Required]
        [Column("CCE_0")]
        [StringLength(15)]
        public string Cce0 { get; set; }
        [Required]
        [Column("CCE_1")]
        [StringLength(15)]
        public string Cce1 { get; set; }
        [Required]
        [Column("CCE_2")]
        [StringLength(15)]
        public string Cce2 { get; set; }
        [Required]
        [Column("CCE_3")]
        [StringLength(15)]
        public string Cce3 { get; set; }
        [Required]
        [Column("CCE_4")]
        [StringLength(15)]
        public string Cce4 { get; set; }
        [Required]
        [Column("CCE_5")]
        [StringLength(15)]
        public string Cce5 { get; set; }
        [Required]
        [Column("CCE_6")]
        [StringLength(15)]
        public string Cce6 { get; set; }
        [Required]
        [Column("CCE_7")]
        [StringLength(15)]
        public string Cce7 { get; set; }
        [Required]
        [Column("CCE_8")]
        [StringLength(15)]
        public string Cce8 { get; set; }
        [Required]
        [Column("CCE_9")]
        [StringLength(15)]
        public string Cce9 { get; set; }
        [Required]
        [Column("CCE_10")]
        [StringLength(15)]
        public string Cce10 { get; set; }
        [Required]
        [Column("CCE_11")]
        [StringLength(15)]
        public string Cce11 { get; set; }
        [Required]
        [Column("CCE_12")]
        [StringLength(15)]
        public string Cce12 { get; set; }
        [Required]
        [Column("CCE_13")]
        [StringLength(15)]
        public string Cce13 { get; set; }
        [Required]
        [Column("CCE_14")]
        [StringLength(15)]
        public string Cce14 { get; set; }
        [Required]
        [Column("CCE_15")]
        [StringLength(15)]
        public string Cce15 { get; set; }
        [Required]
        [Column("CCE_16")]
        [StringLength(15)]
        public string Cce16 { get; set; }
        [Required]
        [Column("CCE_17")]
        [StringLength(15)]
        public string Cce17 { get; set; }
        [Required]
        [Column("CCE_18")]
        [StringLength(15)]
        public string Cce18 { get; set; }
        [Required]
        [Column("CCE_19")]
        [StringLength(15)]
        public string Cce19 { get; set; }
        [Required]
        [Column("LAN_0")]
        [StringLength(3)]
        public string Lan0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("CHGTYP_0")]
        public byte Chgtyp0 { get; set; }
        [Column("CHGCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Chgcoe0 { get; set; }
        [Required]
        [Column("VACBPR_0")]
        [StringLength(20)]
        public string Vacbpr0 { get; set; }
        [Column("VACTYP_0")]
        public short Vactyp0 { get; set; }
        [Column("DISCRGTYP_0")]
        public byte Discrgtyp0 { get; set; }
        [Column("DISCRGTYP_1")]
        public byte Discrgtyp1 { get; set; }
        [Column("DISCRGTYP_2")]
        public byte Discrgtyp2 { get; set; }
        [Column("DISCRGTYP_3")]
        public byte Discrgtyp3 { get; set; }
        [Column("DISCRGTYP_4")]
        public byte Discrgtyp4 { get; set; }
        [Column("DISCRGTYP_5")]
        public byte Discrgtyp5 { get; set; }
        [Column("DISCRGTYP_6")]
        public byte Discrgtyp6 { get; set; }
        [Column("DISCRGTYP_7")]
        public byte Discrgtyp7 { get; set; }
        [Column("DISCRGTYP_8")]
        public byte Discrgtyp8 { get; set; }
        [Column("LINNBR_0")]
        public short Linnbr0 { get; set; }
        [Column("FBULINNBR_0")]
        public short Fbulinnbr0 { get; set; }
        [Column("RCPLINNBR_0")]
        public short Rcplinnbr0 { get; set; }
        [Column("CLELINNBR_0")]
        public short Clelinnbr0 { get; set; }
        [Column("INVLINNBR_0")]
        public short Invlinnbr0 { get; set; }
        [Column("RCPNBR_0")]
        public int Rcpnbr0 { get; set; }
        [Column("INVNBR_0")]
        public int Invnbr0 { get; set; }
        [Column("APPFLG_0")]
        public byte Appflg0 { get; set; }
        [Column("CLEFLG_0")]
        public byte Cleflg0 { get; set; }
        [Column("RCPFLG_0")]
        public byte Rcpflg0 { get; set; }
        [Column("INVFLG_0")]
        public byte Invflg0 { get; set; }
        [Column("PRNFLG_0")]
        public byte Prnflg0 { get; set; }
        [Column("COPNBR_0")]
        public short Copnbr0 { get; set; }
        [Required]
        [Column("TEX1_0")]
        [StringLength(12)]
        public string Tex10 { get; set; }
        [Required]
        [Column("TEX2_0")]
        [StringLength(12)]
        public string Tex20 { get; set; }
        [Column("OCNDAT_0", TypeName = "datetime")]
        public DateTime Ocndat0 { get; set; }
        [Required]
        [Column("OCNNUM_0")]
        [StringLength(20)]
        public string Ocnnum0 { get; set; }
        [Required]
        [Column("OCNREM_0")]
        [StringLength(150)]
        public string Ocnrem0 { get; set; }
        [Column("OCNFLG_0")]
        public byte Ocnflg0 { get; set; }
        [Column("FUPFLG_0")]
        public byte Fupflg0 { get; set; }
        [Column("BETCPY_0")]
        public byte Betcpy0 { get; set; }
        [Column("BETFCY_0")]
        public byte Betfcy0 { get; set; }
        [Required]
        [Column("ORIFCY_0")]
        [StringLength(5)]
        public string Orifcy0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("SALFCY_0")]
        [StringLength(5)]
        public string Salfcy0 { get; set; }
        [Column("SOHCAT_0")]
        public byte Sohcat0 { get; set; }
        [Required]
        [Column("BPCORD_0")]
        [StringLength(15)]
        public string Bpcord0 { get; set; }
        [Column("DME_0")]
        public byte Dme0 { get; set; }
        [Required]
        [Column("DSPWEU_0")]
        [StringLength(3)]
        public string Dspweu0 { get; set; }
        [Required]
        [Column("DSPVOU_0")]
        [StringLength(3)]
        public string Dspvou0 { get; set; }
        [Column("TOTLINATI_0", TypeName = "numeric(27, 13)")]
        public decimal Totlinati0 { get; set; }
        [Column("TOTLINAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Totlinamt0 { get; set; }
        [Column("TOTLINQTY_0", TypeName = "numeric(24, 7)")]
        public decimal Totlinqty0 { get; set; }
        [Column("TOTLINWEU_0", TypeName = "numeric(28, 13)")]
        public decimal Totlinweu0 { get; set; }
        [Column("TOTLINVOU_0", TypeName = "numeric(28, 13)")]
        public decimal Totlinvou0 { get; set; }
        [Column("TOTTAXAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Tottaxamt0 { get; set; }
        [Column("INVDTALIN1_0")]
        public short Invdtalin10 { get; set; }
        [Column("INVDTALIN1_1")]
        public short Invdtalin11 { get; set; }
        [Column("INVDTALIN1_2")]
        public short Invdtalin12 { get; set; }
        [Column("INVDTALIN1_3")]
        public short Invdtalin13 { get; set; }
        [Column("INVDTALIN1_4")]
        public short Invdtalin14 { get; set; }
        [Column("INVDTALIN1_5")]
        public short Invdtalin15 { get; set; }
        [Column("INVDTALIN1_6")]
        public short Invdtalin16 { get; set; }
        [Column("INVDTALIN1_7")]
        public short Invdtalin17 { get; set; }
        [Column("INVDTALIN1_8")]
        public short Invdtalin18 { get; set; }
        [Required]
        [Column("INVDTAVAT1_0")]
        [StringLength(5)]
        public string Invdtavat10 { get; set; }
        [Required]
        [Column("INVDTAVAT1_1")]
        [StringLength(5)]
        public string Invdtavat11 { get; set; }
        [Required]
        [Column("INVDTAVAT1_2")]
        [StringLength(5)]
        public string Invdtavat12 { get; set; }
        [Required]
        [Column("INVDTAVAT1_3")]
        [StringLength(5)]
        public string Invdtavat13 { get; set; }
        [Required]
        [Column("INVDTAVAT1_4")]
        [StringLength(5)]
        public string Invdtavat14 { get; set; }
        [Required]
        [Column("INVDTAVAT1_5")]
        [StringLength(5)]
        public string Invdtavat15 { get; set; }
        [Required]
        [Column("INVDTAVAT1_6")]
        [StringLength(5)]
        public string Invdtavat16 { get; set; }
        [Required]
        [Column("INVDTAVAT1_7")]
        [StringLength(5)]
        public string Invdtavat17 { get; set; }
        [Required]
        [Column("INVDTAVAT1_8")]
        [StringLength(5)]
        public string Invdtavat18 { get; set; }
        [Column("INVDTALIN2_0")]
        public short Invdtalin20 { get; set; }
        [Column("INVDTALIN2_1")]
        public short Invdtalin21 { get; set; }
        [Column("INVDTALIN2_2")]
        public short Invdtalin22 { get; set; }
        [Column("INVDTALIN2_3")]
        public short Invdtalin23 { get; set; }
        [Column("INVDTALIN2_4")]
        public short Invdtalin24 { get; set; }
        [Column("INVDTALIN2_5")]
        public short Invdtalin25 { get; set; }
        [Column("INVDTALIN2_6")]
        public short Invdtalin26 { get; set; }
        [Column("INVDTALIN2_7")]
        public short Invdtalin27 { get; set; }
        [Column("INVDTALIN2_8")]
        public short Invdtalin28 { get; set; }
        [Required]
        [Column("INVDTAVAT2_0")]
        [StringLength(5)]
        public string Invdtavat20 { get; set; }
        [Required]
        [Column("INVDTAVAT2_1")]
        [StringLength(5)]
        public string Invdtavat21 { get; set; }
        [Required]
        [Column("INVDTAVAT2_2")]
        [StringLength(5)]
        public string Invdtavat22 { get; set; }
        [Required]
        [Column("INVDTAVAT2_3")]
        [StringLength(5)]
        public string Invdtavat23 { get; set; }
        [Required]
        [Column("INVDTAVAT2_4")]
        [StringLength(5)]
        public string Invdtavat24 { get; set; }
        [Required]
        [Column("INVDTAVAT2_5")]
        [StringLength(5)]
        public string Invdtavat25 { get; set; }
        [Required]
        [Column("INVDTAVAT2_6")]
        [StringLength(5)]
        public string Invdtavat26 { get; set; }
        [Required]
        [Column("INVDTAVAT2_7")]
        [StringLength(5)]
        public string Invdtavat27 { get; set; }
        [Required]
        [Column("INVDTAVAT2_8")]
        [StringLength(5)]
        public string Invdtavat28 { get; set; }
        [Column("TOTORD_0", TypeName = "numeric(27, 13)")]
        public decimal Totord0 { get; set; }
        [Column("TTVORD_0", TypeName = "numeric(27, 13)")]
        public decimal Ttvord0 { get; set; }
        [Column("TOTORDL_0", TypeName = "numeric(27, 13)")]
        public decimal Totordl0 { get; set; }
        [Column("TTVORDL_0", TypeName = "numeric(27, 13)")]
        public decimal Ttvordl0 { get; set; }
        [Column("TOTVLT_0", TypeName = "numeric(27, 13)")]
        public decimal Totvlt0 { get; set; }
        [Column("STRDAT_0", TypeName = "datetime")]
        public DateTime Strdat0 { get; set; }
        [Column("ENDDAT_0", TypeName = "datetime")]
        public DateTime Enddat0 { get; set; }
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
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}