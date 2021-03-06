// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SDELIVERYD", Schema = "TESTPROD")]
    [Index(nameof(Sdhnum0), nameof(Sddlin0), Name = "SDELIVERYD_SDD0", IsUnique = true)]
    [Index(nameof(Sohnum0), nameof(Soplin0), nameof(Soqseq0), Name = "SDELIVERYD_SDD1")]
    [Index(nameof(Itmref0), nameof(Shidat0), nameof(Sdhnum0), Name = "SDELIVERYD_SDD2")]
    [Index(nameof(Bpcord0), nameof(Bpaadd0), nameof(Itmref0), Name = "SDELIVERYD_SDD3")]
    public partial class Sdeliveryd
    {
        [Required]
        [Column("SDHNUM_0")]
        [StringLength(20)]
        public string Sdhnum0 { get; set; }
        [Column("SDDLIN_0")]
        public int Sddlin0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Column("SOHCAT_0")]
        public byte Sohcat0 { get; set; }
        [Required]
        [Column("SOHNUM_0")]
        [StringLength(20)]
        public string Sohnum0 { get; set; }
        [Column("SOPLIN_0")]
        public int Soplin0 { get; set; }
        [Column("SOQSEQ_0")]
        public int Soqseq0 { get; set; }
        [Required]
        [Column("PRHNUM_0")]
        [StringLength(20)]
        public string Prhnum0 { get; set; }
        [Column("PRELIN_0")]
        public int Prelin0 { get; set; }
        [Required]
        [Column("BPCORD_0")]
        [StringLength(15)]
        public string Bpcord0 { get; set; }
        [Required]
        [Column("BPAADD_0")]
        [StringLength(7)]
        public string Bpaadd0 { get; set; }
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
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("USEPLC_0")]
        [StringLength(30)]
        public string Useplc0 { get; set; }
        [Column("SHIDAT_0", TypeName = "datetime")]
        public DateTime Shidat0 { get; set; }
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
        [Column("DSPLINFLG_0")]
        public byte Dsplinflg0 { get; set; }
        [Column("DDTANUM_0")]
        public short Ddtanum0 { get; set; }
        [Column("DDTANUM_1")]
        public short Ddtanum1 { get; set; }
        [Column("DDTANUM_2")]
        public short Ddtanum2 { get; set; }
        [Column("DDTANUM_3")]
        public short Ddtanum3 { get; set; }
        [Column("DDTANUM_4")]
        public short Ddtanum4 { get; set; }
        [Column("DDTANUM_5")]
        public short Ddtanum5 { get; set; }
        [Column("DDTANUM_6")]
        public short Ddtanum6 { get; set; }
        [Column("DDTANUM_7")]
        public short Ddtanum7 { get; set; }
        [Column("DDTANUM_8")]
        public short Ddtanum8 { get; set; }
        [Column("DDTANOT_0", TypeName = "numeric(27, 13)")]
        public decimal Ddtanot0 { get; set; }
        [Column("DDTANOT_1", TypeName = "numeric(27, 13)")]
        public decimal Ddtanot1 { get; set; }
        [Column("DDTANOT_2", TypeName = "numeric(27, 13)")]
        public decimal Ddtanot2 { get; set; }
        [Column("DDTANOT_3", TypeName = "numeric(27, 13)")]
        public decimal Ddtanot3 { get; set; }
        [Column("DDTANOT_4", TypeName = "numeric(27, 13)")]
        public decimal Ddtanot4 { get; set; }
        [Column("DDTANOT_5", TypeName = "numeric(27, 13)")]
        public decimal Ddtanot5 { get; set; }
        [Column("DDTANOT_6", TypeName = "numeric(27, 13)")]
        public decimal Ddtanot6 { get; set; }
        [Column("DDTANOT_7", TypeName = "numeric(27, 13)")]
        public decimal Ddtanot7 { get; set; }
        [Column("DDTANOT_8", TypeName = "numeric(27, 13)")]
        public decimal Ddtanot8 { get; set; }
        [Column("QTY_0", TypeName = "numeric(28, 13)")]
        public decimal Qty0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Column("RTNQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Rtnqty0 { get; set; }
        [Column("RTNQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Rtnqtystu0 { get; set; }
        [Column("WRTQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Wrtqty0 { get; set; }
        [Column("WRTQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Wrtqtystu0 { get; set; }
        [Column("OALQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Oalqtystu0 { get; set; }
        [Column("PACQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Pacqtystu0 { get; set; }
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
        [Required]
        [Column("PCK_0")]
        [StringLength(5)]
        public string Pck0 { get; set; }
        [Column("PCKCAP_0", TypeName = "numeric(18, 7)")]
        public decimal Pckcap0 { get; set; }
        [Column("LINTYP_0")]
        public byte Lintyp0 { get; set; }
        [Column("FOCFLG_0")]
        public byte Focflg0 { get; set; }
        [Column("ORILIN_0")]
        public int Orilin0 { get; set; }
        [Column("STOMGTCOD_0")]
        public byte Stomgtcod0 { get; set; }
        [Required]
        [Column("LOT_0")]
        [StringLength(15)]
        public string Lot0 { get; set; }
        [Required]
        [Column("STA_0")]
        [StringLength(12)]
        public string Sta0 { get; set; }
        [Required]
        [Column("LOC_0")]
        [StringLength(10)]
        public string Loc0 { get; set; }
        [Required]
        [Column("WEU_0")]
        [StringLength(3)]
        public string Weu0 { get; set; }
        [Column("UNTWEI_0", TypeName = "numeric(13, 4)")]
        public decimal Untwei0 { get; set; }
        [Required]
        [Column("SDDTEX_0")]
        [StringLength(12)]
        public string Sddtex0 { get; set; }
        [Required]
        [Column("PRPTEX_0")]
        [StringLength(12)]
        public string Prptex0 { get; set; }
        [Required]
        [Column("GEOCOD_0")]
        [StringLength(9)]
        public string Geocod0 { get; set; }
        [Required]
        [Column("INSCTYFLG_0")]
        [StringLength(1)]
        public string Insctyflg0 { get; set; }
        [Required]
        [Column("VTS_0")]
        [StringLength(1)]
        public string Vts0 { get; set; }
        [Required]
        [Column("VTC_0")]
        [StringLength(1)]
        public string Vtc0 { get; set; }
        [Required]
        [Column("TAXGEOFLG_0")]
        [StringLength(1)]
        public string Taxgeoflg0 { get; set; }
        [Column("TAXFLG_0")]
        public byte Taxflg0 { get; set; }
        [Column("TAXREGFLG_0")]
        public byte Taxregflg0 { get; set; }
        [Column("RATTAXLIN_0", TypeName = "numeric(8, 3)")]
        public decimal Rattaxlin0 { get; set; }
        [Column("BASTAXLIN_0", TypeName = "numeric(27, 13)")]
        public decimal Bastaxlin0 { get; set; }
        [Column("NDEPRNBOM_0")]
        public byte Ndeprnbom0 { get; set; }
        [Column("INVPRNBOM_0")]
        public byte Invprnbom0 { get; set; }
        [Column("RCPFLG_0")]
        public short Rcpflg0 { get; set; }
        [Column("RCPQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Rcpqtystu0 { get; set; }
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
        [Column("DSPLINWEI_0", TypeName = "numeric(28, 13)")]
        public decimal Dsplinwei0 { get; set; }
        [Column("DSPLINVOL_0", TypeName = "numeric(28, 13)")]
        public decimal Dsplinvol0 { get; set; }
        [Required]
        [Column("DSPWEU_0")]
        [StringLength(3)]
        public string Dspweu0 { get; set; }
        [Required]
        [Column("DSPVOU_0")]
        [StringLength(3)]
        public string Dspvou0 { get; set; }
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
        [Column("XA_PCKSTS_0")]
        public byte XaPcksts0 { get; set; }
        [Column("XA_PCKQTY_0", TypeName = "numeric(28, 13)")]
        public decimal XaPckqty0 { get; set; }
        [Column("XA_EXPQTY_0", TypeName = "numeric(28, 13)")]
        public decimal XaExpqty0 { get; set; }
        [Required]
        [Column("XB_BOLNUM_0")]
        [StringLength(20)]
        public string XbBolnum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}