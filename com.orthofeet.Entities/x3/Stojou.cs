﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("STOJOU", Schema = "TESTPROD")]
    [Index(nameof(Stofcy0), nameof(Updcod0), nameof(Itmref0), nameof(Iptdat0), nameof(Mvtseq0), nameof(Mvtind0), Name = "STOJOU_STJ0", IsUnique = true)]
    [Index(nameof(Stofcy0), nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vcrlin0), Name = "STOJOU_STJ1")]
    [Index(nameof(Updcod0), nameof(Itmref0), nameof(Iptdat0), nameof(Mvtseq0), nameof(Mvtind0), Name = "STOJOU_STJ2")]
    [Index(nameof(Updcod0), nameof(Credat0), nameof(Cretim0), nameof(Itmref0), Name = "STOJOU_STJ3")]
    [Index(nameof(Itmref0), nameof(Iptdat0), nameof(Cremvtdat0), nameof(Cremvttim0), nameof(Cremvtseq0), Name = "STOJOU_STJ4")]
    public partial class Stojou
    {
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Column("UPDCOD_0")]
        public byte Updcod0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("IPTDAT_0", TypeName = "datetime")]
        public DateTime Iptdat0 { get; set; }
        [Column("MVTSEQ_0")]
        public int Mvtseq0 { get; set; }
        [Column("MVTIND_0")]
        public int Mvtind0 { get; set; }
        [Column("CSTDAT_0", TypeName = "datetime")]
        public DateTime Cstdat0 { get; set; }
        [Required]
        [Column("CSTTIM_0")]
        [StringLength(8)]
        public string Csttim0 { get; set; }
        [Column("CSTCOU_0", TypeName = "numeric(11, 1)")]
        public decimal Cstcou0 { get; set; }
        [Required]
        [Column("OWNER_0")]
        [StringLength(15)]
        public string Owner0 { get; set; }
        [Required]
        [Column("LOT_0")]
        [StringLength(15)]
        public string Lot0 { get; set; }
        [Required]
        [Column("SLO_0")]
        [StringLength(5)]
        public string Slo0 { get; set; }
        [Required]
        [Column("BPSLOT_0")]
        [StringLength(15)]
        public string Bpslot0 { get; set; }
        [Required]
        [Column("LOC_0")]
        [StringLength(10)]
        public string Loc0 { get; set; }
        [Required]
        [Column("WRH_0")]
        [StringLength(1)]
        public string Wrh0 { get; set; }
        [Required]
        [Column("SERNUM_0")]
        [StringLength(20)]
        public string Sernum0 { get; set; }
        [Column("TRSTYP_0")]
        public byte Trstyp0 { get; set; }
        [Required]
        [Column("TRSFAM_0")]
        [StringLength(20)]
        public string Trsfam0 { get; set; }
        [Required]
        [Column("MVTDES_0")]
        [StringLength(30)]
        public string Mvtdes0 { get; set; }
        [Required]
        [Column("PJT_0")]
        [StringLength(20)]
        public string Pjt0 { get; set; }
        [Required]
        [Column("BPRNUM_0")]
        [StringLength(15)]
        public string Bprnum0 { get; set; }
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Column("VCRTYPORI_0")]
        public byte Vcrtypori0 { get; set; }
        [Required]
        [Column("VCRNUMORI_0")]
        [StringLength(20)]
        public string Vcrnumori0 { get; set; }
        [Column("VCRLINORI_0")]
        public int Vcrlinori0 { get; set; }
        [Column("VCRSEQORI_0")]
        public int Vcrseqori0 { get; set; }
        [Column("VCRTYPREG_0")]
        public byte Vcrtypreg0 { get; set; }
        [Required]
        [Column("VCRNUMREG_0")]
        [StringLength(20)]
        public string Vcrnumreg0 { get; set; }
        [Column("VCRLINREG_0")]
        public int Vcrlinreg0 { get; set; }
        [Required]
        [Column("USRFLD1_0")]
        [StringLength(20)]
        public string Usrfld10 { get; set; }
        [Required]
        [Column("USRFLD2_0")]
        [StringLength(10)]
        public string Usrfld20 { get; set; }
        [Column("USRFLD3_0", TypeName = "numeric(11, 1)")]
        public decimal Usrfld30 { get; set; }
        [Column("USRFLD4_0", TypeName = "datetime")]
        public DateTime Usrfld40 { get; set; }
        [Required]
        [Column("PCU_0")]
        [StringLength(3)]
        public string Pcu0 { get; set; }
        [Column("QTYPCU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypcu0 { get; set; }
        [Column("PCUSTUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Pcustucoe0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Required]
        [Column("PCUORI_0")]
        [StringLength(3)]
        public string Pcuori0 { get; set; }
        [Column("PCUSTUORI_0", TypeName = "numeric(18, 7)")]
        public decimal Pcustuori0 { get; set; }
        [Column("AMTORD_0", TypeName = "numeric(27, 13)")]
        public decimal Amtord0 { get; set; }
        [Column("AMTVAL_0", TypeName = "numeric(27, 13)")]
        public decimal Amtval0 { get; set; }
        [Column("VARORD_0", TypeName = "numeric(27, 13)")]
        public decimal Varord0 { get; set; }
        [Column("VARVAL_0", TypeName = "numeric(27, 13)")]
        public decimal Varval0 { get; set; }
        [Column("PRIORD_0", TypeName = "numeric(27, 13)")]
        public decimal Priord0 { get; set; }
        [Column("PRIVAL_0", TypeName = "numeric(27, 13)")]
        public decimal Prival0 { get; set; }
        [Column("PRINAT_0")]
        public byte Prinat0 { get; set; }
        [Column("AMTVAL2_0", TypeName = "numeric(28, 8)")]
        public decimal Amtval20 { get; set; }
        [Column("VARVAL2_0", TypeName = "numeric(28, 8)")]
        public decimal Varval20 { get; set; }
        [Column("PRIVAL2_0", TypeName = "numeric(28, 8)")]
        public decimal Prival20 { get; set; }
        [Column("PRINAT2_0")]
        public short Prinat20 { get; set; }
        [Column("PRIREGFLG_0")]
        public byte Priregflg0 { get; set; }
        [Column("AMTDEV_0", TypeName = "numeric(27, 13)")]
        public decimal Amtdev0 { get; set; }
        [Column("AMTDEV2_0", TypeName = "numeric(28, 8)")]
        public decimal Amtdev20 { get; set; }
        [Column("SHLDAT_0", TypeName = "datetime")]
        public DateTime Shldat0 { get; set; }
        [Required]
        [Column("STA_0")]
        [StringLength(3)]
        public string Sta0 { get; set; }
        [Column("POT_0", TypeName = "numeric(14, 5)")]
        public decimal Pot0 { get; set; }
        [Column("ACT_0", TypeName = "numeric(14, 5)")]
        public decimal Act0 { get; set; }
        [Column("ACTQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Actqty0 { get; set; }
        [Required]
        [Column("QLYCTLDEM_0")]
        [StringLength(20)]
        public string Qlyctldem0 { get; set; }
        [Column("PRNFLG_0")]
        public byte Prnflg0 { get; set; }
        [Column("REGFLG_0")]
        public byte Regflg0 { get; set; }
        [Required]
        [Column("LBEFMT_0")]
        [StringLength(15)]
        public string Lbefmt0 { get; set; }
        [Column("LBENBR_0")]
        public short Lbenbr0 { get; set; }
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
        [Column("ENTCOD_0")]
        [StringLength(5)]
        public string Entcod0 { get; set; }
        [Required]
        [Column("FINRSPFCY_0")]
        [StringLength(5)]
        public string Finrspfcy0 { get; set; }
        [Column("AGGIFAFLG_0")]
        public byte Aggifaflg0 { get; set; }
        [Required]
        [Column("GTE_0")]
        [StringLength(5)]
        public string Gte0 { get; set; }
        [Required]
        [Column("NUMVCR_0")]
        [StringLength(20)]
        public string Numvcr0 { get; set; }
        [Required]
        [Column("PALNUM_0")]
        [StringLength(10)]
        public string Palnum0 { get; set; }
        [Required]
        [Column("CTRNUM_0")]
        [StringLength(10)]
        public string Ctrnum0 { get; set; }
        [Column("BETCPY_0")]
        public byte Betcpy0 { get; set; }
        [Column("DLUDAT_0", TypeName = "datetime")]
        public DateTime Dludat0 { get; set; }
        [Column("NEWLTIDAT_0", TypeName = "datetime")]
        public DateTime Newltidat0 { get; set; }
        [Column("CREMVTDAT_0", TypeName = "datetime")]
        public DateTime Cremvtdat0 { get; set; }
        [Required]
        [Column("CREMVTTIM_0")]
        [StringLength(8)]
        public string Cremvttim0 { get; set; }
        [Column("CREMVTSEQ_0")]
        public int Cremvtseq0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Column("PRONUM_0")]
        public int Pronum0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CRETIM_0")]
        [StringLength(5)]
        public string Cretim0 { get; set; }
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
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}