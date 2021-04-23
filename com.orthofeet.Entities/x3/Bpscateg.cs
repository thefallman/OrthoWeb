﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BPSCATEG", Schema = "TESTPROD")]
    [Index(nameof(Bsgcod0), Name = "BPSCATEG_BSG0", IsUnique = true)]
    public partial class Bpscateg
    {
        [Required]
        [Column("BSGCOD_0")]
        [StringLength(5)]
        public string Bsgcod0 { get; set; }
        [Required]
        [Column("BSGDES_0")]
        [StringLength(30)]
        public string Bsgdes0 { get; set; }
        [Required]
        [Column("BSGSHO_0")]
        [StringLength(10)]
        public string Bsgsho0 { get; set; }
        [Required]
        [Column("REFCOU_0")]
        [StringLength(5)]
        public string Refcou0 { get; set; }
        [Column("CREMOD_0")]
        public byte Cremod0 { get; set; }
        [Required]
        [Column("CRY_0")]
        [StringLength(3)]
        public string Cry0 { get; set; }
        [Required]
        [Column("LAN_0")]
        [StringLength(3)]
        public string Lan0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("BPSTYP_0")]
        public byte Bpstyp0 { get; set; }
        [Column("CHGTYP_0")]
        public byte Chgtyp0 { get; set; }
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
        [Column("OSTCTL_0")]
        public byte Ostctl0 { get; set; }
        [Column("OSTAUZAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Ostauzamt0 { get; set; }
        [Column("ABCCLS_0")]
        public byte Abccls0 { get; set; }
        [Column("ORDMINAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Ordminamt0 { get; set; }
        [Column("SEVLIN_0")]
        public byte Sevlin0 { get; set; }
        [Column("OCNFLG_0")]
        public byte Ocnflg0 { get; set; }
        [Column("FUPFLG_0")]
        public byte Fupflg0 { get; set; }
        [Required]
        [Column("PLISTC_0")]
        [StringLength(10)]
        public string Plistc0 { get; set; }
        [Required]
        [Column("UVYCOD_0")]
        [StringLength(5)]
        public string Uvycod0 { get; set; }
        [Required]
        [Column("BPTNUM_0")]
        [StringLength(15)]
        public string Bptnum0 { get; set; }
        [Required]
        [Column("MDL_0")]
        [StringLength(5)]
        public string Mdl0 { get; set; }
        [Required]
        [Column("EECICT_0")]
        [StringLength(20)]
        public string Eecict0 { get; set; }
        [Column("EECLOC_0")]
        public byte Eecloc0 { get; set; }
        [Column("EECINCRAT_0", TypeName = "numeric(8, 3)")]
        public decimal Eecincrat0 { get; set; }
        [Column("DUDCLC_0")]
        public byte Dudclc0 { get; set; }
        [Column("INVDTAAMT_0", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt0 { get; set; }
        [Column("INVDTAAMT_1", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt1 { get; set; }
        [Column("INVDTAAMT_2", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt2 { get; set; }
        [Column("INVDTAAMT_3", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt3 { get; set; }
        [Column("INVDTAAMT_4", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt4 { get; set; }
        [Column("INVDTAAMT_5", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt5 { get; set; }
        [Column("INVDTAAMT_6", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt6 { get; set; }
        [Column("INVDTAAMT_7", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt7 { get; set; }
        [Column("INVDTAAMT_8", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt8 { get; set; }
        [Column("INVDTAAMT_9", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt9 { get; set; }
        [Column("INVDTAAMT_10", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt10 { get; set; }
        [Column("INVDTAAMT_11", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt11 { get; set; }
        [Column("INVDTAAMT_12", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt12 { get; set; }
        [Column("INVDTAAMT_13", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt13 { get; set; }
        [Column("INVDTAAMT_14", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt14 { get; set; }
        [Column("INVDTAAMT_15", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt15 { get; set; }
        [Column("INVDTAAMT_16", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt16 { get; set; }
        [Column("INVDTAAMT_17", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt17 { get; set; }
        [Column("INVDTAAMT_18", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt18 { get; set; }
        [Column("INVDTAAMT_19", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt19 { get; set; }
        [Column("INVDTAAMT_20", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt20 { get; set; }
        [Column("INVDTAAMT_21", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt21 { get; set; }
        [Column("INVDTAAMT_22", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt22 { get; set; }
        [Column("INVDTAAMT_23", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt23 { get; set; }
        [Column("INVDTAAMT_24", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt24 { get; set; }
        [Column("INVDTAAMT_25", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt25 { get; set; }
        [Column("INVDTAAMT_26", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt26 { get; set; }
        [Column("INVDTAAMT_27", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt27 { get; set; }
        [Column("INVDTAAMT_28", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt28 { get; set; }
        [Column("INVDTAAMT_29", TypeName = "numeric(20, 5)")]
        public decimal Invdtaamt29 { get; set; }
        [Column("INVDTA_0")]
        public short Invdta0 { get; set; }
        [Column("INVDTA_1")]
        public short Invdta1 { get; set; }
        [Column("INVDTA_2")]
        public short Invdta2 { get; set; }
        [Column("INVDTA_3")]
        public short Invdta3 { get; set; }
        [Column("INVDTA_4")]
        public short Invdta4 { get; set; }
        [Column("INVDTA_5")]
        public short Invdta5 { get; set; }
        [Column("INVDTA_6")]
        public short Invdta6 { get; set; }
        [Column("INVDTA_7")]
        public short Invdta7 { get; set; }
        [Column("INVDTA_8")]
        public short Invdta8 { get; set; }
        [Column("INVDTA_9")]
        public short Invdta9 { get; set; }
        [Column("INVDTA_10")]
        public short Invdta10 { get; set; }
        [Column("INVDTA_11")]
        public short Invdta11 { get; set; }
        [Column("INVDTA_12")]
        public short Invdta12 { get; set; }
        [Column("INVDTA_13")]
        public short Invdta13 { get; set; }
        [Column("INVDTA_14")]
        public short Invdta14 { get; set; }
        [Column("INVDTA_15")]
        public short Invdta15 { get; set; }
        [Column("INVDTA_16")]
        public short Invdta16 { get; set; }
        [Column("INVDTA_17")]
        public short Invdta17 { get; set; }
        [Column("INVDTA_18")]
        public short Invdta18 { get; set; }
        [Column("INVDTA_19")]
        public short Invdta19 { get; set; }
        [Column("INVDTA_20")]
        public short Invdta20 { get; set; }
        [Column("INVDTA_21")]
        public short Invdta21 { get; set; }
        [Column("INVDTA_22")]
        public short Invdta22 { get; set; }
        [Column("INVDTA_23")]
        public short Invdta23 { get; set; }
        [Column("INVDTA_24")]
        public short Invdta24 { get; set; }
        [Column("INVDTA_25")]
        public short Invdta25 { get; set; }
        [Column("INVDTA_26")]
        public short Invdta26 { get; set; }
        [Column("INVDTA_27")]
        public short Invdta27 { get; set; }
        [Column("INVDTA_28")]
        public short Invdta28 { get; set; }
        [Column("INVDTA_29")]
        public short Invdta29 { get; set; }
        [Column("AMTCOD_0")]
        public byte Amtcod0 { get; set; }
        [Column("AMTCOD_1")]
        public byte Amtcod1 { get; set; }
        [Column("AMTCOD_2")]
        public byte Amtcod2 { get; set; }
        [Column("AMTCOD_3")]
        public byte Amtcod3 { get; set; }
        [Column("AMTCOD_4")]
        public byte Amtcod4 { get; set; }
        [Column("AMTCOD_5")]
        public byte Amtcod5 { get; set; }
        [Column("AMTCOD_6")]
        public byte Amtcod6 { get; set; }
        [Column("AMTCOD_7")]
        public byte Amtcod7 { get; set; }
        [Column("AMTCOD_8")]
        public byte Amtcod8 { get; set; }
        [Column("AMTCOD_9")]
        public byte Amtcod9 { get; set; }
        [Column("AMTCOD_10")]
        public byte Amtcod10 { get; set; }
        [Column("AMTCOD_11")]
        public byte Amtcod11 { get; set; }
        [Column("AMTCOD_12")]
        public byte Amtcod12 { get; set; }
        [Column("AMTCOD_13")]
        public byte Amtcod13 { get; set; }
        [Column("AMTCOD_14")]
        public byte Amtcod14 { get; set; }
        [Column("AMTCOD_15")]
        public byte Amtcod15 { get; set; }
        [Column("AMTCOD_16")]
        public byte Amtcod16 { get; set; }
        [Column("AMTCOD_17")]
        public byte Amtcod17 { get; set; }
        [Column("AMTCOD_18")]
        public byte Amtcod18 { get; set; }
        [Column("AMTCOD_19")]
        public byte Amtcod19 { get; set; }
        [Column("AMTCOD_20")]
        public byte Amtcod20 { get; set; }
        [Column("AMTCOD_21")]
        public byte Amtcod21 { get; set; }
        [Column("AMTCOD_22")]
        public byte Amtcod22 { get; set; }
        [Column("AMTCOD_23")]
        public byte Amtcod23 { get; set; }
        [Column("AMTCOD_24")]
        public byte Amtcod24 { get; set; }
        [Column("AMTCOD_25")]
        public byte Amtcod25 { get; set; }
        [Column("AMTCOD_26")]
        public byte Amtcod26 { get; set; }
        [Column("AMTCOD_27")]
        public byte Amtcod27 { get; set; }
        [Column("AMTCOD_28")]
        public byte Amtcod28 { get; set; }
        [Column("AMTCOD_29")]
        public byte Amtcod29 { get; set; }
        [Column("NORPRNFLG_0")]
        public byte Norprnflg0 { get; set; }
        [Column("NREPRNFLG_0")]
        public byte Nreprnflg0 { get; set; }
        [Column("NRTPRNFLG_0")]
        public byte Nrtprnflg0 { get; set; }
        [Required]
        [Column("ACCCOD_0")]
        [StringLength(10)]
        public string Acccod0 { get; set; }
        [Required]
        [Column("DIA_0")]
        [StringLength(10)]
        public string Dia0 { get; set; }
        [Required]
        [Column("VACBPR_0")]
        [StringLength(20)]
        public string Vacbpr0 { get; set; }
        [Column("DADFLG_0")]
        public byte Dadflg0 { get; set; }
        [Required]
        [Column("PTE_0")]
        [StringLength(15)]
        public string Pte0 { get; set; }
        [Required]
        [Column("DEP_0")]
        [StringLength(3)]
        public string Dep0 { get; set; }
        [Required]
        [Column("PAYBAN_0")]
        [StringLength(5)]
        public string Payban0 { get; set; }
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
        [Column("RITCOD_0")]
        [StringLength(1)]
        public string Ritcod0 { get; set; }
        [Column("RITNBR_0")]
        public short Ritnbr0 { get; set; }
        [Column("RITRAT_0", TypeName = "numeric(28, 8)")]
        public decimal Ritrat0 { get; set; }
        [Column("LTIMRKCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Ltimrkcoe0 { get; set; }
        [Column("PRIMRKCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Primrkcoe0 { get; set; }
        [Column("QLYMRKCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Qlymrkcoe0 { get; set; }
        [Column("QTYMRKCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Qtymrkcoe0 { get; set; }
        [Column("RSKMRKCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Rskmrkcoe0 { get; set; }
        [Required]
        [Column("EECICT2_0")]
        [StringLength(20)]
        public string Eecict20 { get; set; }
        [Required]
        [Column("FFWNUM_0")]
        [StringLength(15)]
        public string Ffwnum0 { get; set; }
        [Column("EECINCRAT2_0", TypeName = "numeric(8, 3)")]
        public decimal Eecincrat20 { get; set; }
        [Column("EECLOC2_0")]
        public byte Eecloc20 { get; set; }
        [Column("UVYDAY1_0")]
        public byte Uvyday10 { get; set; }
        [Column("UVYDAY2_0")]
        public byte Uvyday20 { get; set; }
        [Column("UVYDAY3_0")]
        public byte Uvyday30 { get; set; }
        [Column("UVYDAY4_0")]
        public byte Uvyday40 { get; set; }
        [Column("UVYDAY5_0")]
        public byte Uvyday50 { get; set; }
        [Column("UVYDAY6_0")]
        public byte Uvyday60 { get; set; }
        [Column("UVYDAY7_0")]
        public byte Uvyday70 { get; set; }
        [Required]
        [Column("UVYCOD2_0")]
        [StringLength(5)]
        public string Uvycod20 { get; set; }
        [Required]
        [Column("TPMCOD_0")]
        [StringLength(5)]
        public string Tpmcod0 { get; set; }
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
        [Column("MATTOL_0")]
        [StringLength(5)]
        public string Mattol0 { get; set; }
        [Column("FRM1099_0")]
        public byte Frm10990 { get; set; }
        [Required]
        [Column("BOX1099_0")]
        [StringLength(4)]
        public string Box10990 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}