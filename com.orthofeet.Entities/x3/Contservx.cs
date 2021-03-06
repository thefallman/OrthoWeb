// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("CONTSERVX", Schema = "TESTPROD")]
    [Index(nameof(Connum0), Name = "CONTSERVX_COX0", IsUnique = true)]
    public partial class Contservx
    {
        [Required]
        [Column("CONNUM_0")]
        [StringLength(20)]
        public string Connum0 { get; set; }
        [Column("PRONUM_0")]
        public int Pronum0 { get; set; }
        [Required]
        [Column("CONNAM_0")]
        [StringLength(85)]
        public string Connam0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("SALFCY_0")]
        [StringLength(5)]
        public string Salfcy0 { get; set; }
        [Required]
        [Column("CONBPC_0")]
        [StringLength(15)]
        public string Conbpc0 { get; set; }
        [Required]
        [Column("CONBPCINV_0")]
        [StringLength(15)]
        public string Conbpcinv0 { get; set; }
        [Required]
        [Column("CONBPCPYR_0")]
        [StringLength(15)]
        public string Conbpcpyr0 { get; set; }
        [Required]
        [Column("CONBPCGRU_0")]
        [StringLength(15)]
        public string Conbpcgru0 { get; set; }
        [Required]
        [Column("CONCCN_0")]
        [StringLength(15)]
        public string Conccn0 { get; set; }
        [Required]
        [Column("CONPJT_0")]
        [StringLength(20)]
        public string Conpjt0 { get; set; }
        [Required]
        [Column("CONTYP_0")]
        [StringLength(20)]
        public string Contyp0 { get; set; }
        [Required]
        [Column("CONTYP_1")]
        [StringLength(20)]
        public string Contyp1 { get; set; }
        [Required]
        [Column("CONTYP_2")]
        [StringLength(20)]
        public string Contyp2 { get; set; }
        [Required]
        [Column("CONTYP_3")]
        [StringLength(20)]
        public string Contyp3 { get; set; }
        [Required]
        [Column("CONTYP_4")]
        [StringLength(20)]
        public string Contyp4 { get; set; }
        [Required]
        [Column("CONTYPCLA_0")]
        [StringLength(30)]
        public string Contypcla0 { get; set; }
        [Column("GUA_0")]
        public byte Gua0 { get; set; }
        [Column("CONCAT_0")]
        public byte Concat0 { get; set; }
        [Column("SIUDAT_0", TypeName = "datetime")]
        public DateTime Siudat0 { get; set; }
        [Column("CONSTRDAT_0", TypeName = "datetime")]
        public DateTime Constrdat0 { get; set; }
        [Column("OCONSTRDAT_0", TypeName = "datetime")]
        public DateTime Oconstrdat0 { get; set; }
        [Column("CONENDDAT_0", TypeName = "datetime")]
        public DateTime Conenddat0 { get; set; }
        [Column("OCONENDDAT_0", TypeName = "datetime")]
        public DateTime Oconenddat0 { get; set; }
        [Column("REWFRY_0")]
        public short Rewfry0 { get; set; }
        [Column("REWFRYBAS_0")]
        public byte Rewfrybas0 { get; set; }
        [Column("INVFRY_0")]
        public short Invfry0 { get; set; }
        [Column("INVFRYBAS_0")]
        public byte Invfrybas0 { get; set; }
        [Column("INVMET_0")]
        public byte Invmet0 { get; set; }
        [Column("INVFRYCOE_0", TypeName = "numeric(8, 3)")]
        public decimal Invfrycoe0 { get; set; }
        [Column("INVLTI_0")]
        public short Invlti0 { get; set; }
        [Column("INVLTIBAS_0")]
        public byte Invltibas0 { get; set; }
        [Column("LASINVDAT_0", TypeName = "datetime")]
        public DateTime Lasinvdat0 { get; set; }
        [Column("OLASINVDAT_0", TypeName = "datetime")]
        public DateTime Olasinvdat0 { get; set; }
        [Column("ONEXINVDAT_0", TypeName = "datetime")]
        public DateTime Onexinvdat0 { get; set; }
        [Column("NEXINVDAT_0", TypeName = "datetime")]
        public DateTime Nexinvdat0 { get; set; }
        [Column("ONEXINVAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Onexinvamt0 { get; set; }
        [Column("NEXINVAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Nexinvamt0 { get; set; }
        [Column("ONEXSHIINV_0", TypeName = "datetime")]
        public DateTime Onexshiinv0 { get; set; }
        [Column("NEXSHIINV_0", TypeName = "datetime")]
        public DateTime Nexshiinv0 { get; set; }
        [Required]
        [Column("PTE_0")]
        [StringLength(15)]
        public string Pte0 { get; set; }
        [Column("CONCHGTYP_0")]
        public byte Conchgtyp0 { get; set; }
        [Column("CONPRITYP_0")]
        public byte Conprityp0 { get; set; }
        [Required]
        [Column("CONVACBPR_0")]
        [StringLength(20)]
        public string Convacbpr0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("RVAFRY_0")]
        public short Rvafry0 { get; set; }
        [Column("RVAFRYBAS_0")]
        public byte Rvafrybas0 { get; set; }
        [Column("RVAMET_0")]
        public byte Rvamet0 { get; set; }
        [Column("RVASSP_0")]
        public byte Rvassp0 { get; set; }
        [Column("RVADAT_0", TypeName = "datetime")]
        public DateTime Rvadat0 { get; set; }
        [Column("ORVADAT_0", TypeName = "datetime")]
        public DateTime Orvadat0 { get; set; }
        [Column("CONAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Conamt0 { get; set; }
        [Column("OCONAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Oconamt0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("PITCDT_0")]
        public int Pitcdt0 { get; set; }
        [Column("PITRER_0")]
        public int Pitrer0 { get; set; }
        [Column("PITCSM_0")]
        public int Pitcsm0 { get; set; }
        [Column("PITBLC_0")]
        public int Pitblc0 { get; set; }
        [Column("PITTOL_0")]
        public short Pittol0 { get; set; }
        [Required]
        [Column("SALREP_0")]
        [StringLength(15)]
        public string Salrep0 { get; set; }
        [Required]
        [Column("SALREP_1")]
        [StringLength(15)]
        public string Salrep1 { get; set; }
        [Required]
        [Column("CONBASIDX_0")]
        [StringLength(20)]
        public string Conbasidx0 { get; set; }
        [Required]
        [Column("CONBASFOR_0")]
        [StringLength(20)]
        public string Conbasfor0 { get; set; }
        [Column("LASVALIDX_0", TypeName = "numeric(27, 13)")]
        public decimal Lasvalidx0 { get; set; }
        [Column("OLASVALIDX_0", TypeName = "numeric(27, 13)")]
        public decimal Olasvalidx0 { get; set; }
        [Column("LASIDXDAT_0", TypeName = "datetime")]
        public DateTime Lasidxdat0 { get; set; }
        [Column("OLASIDXDAT_0", TypeName = "datetime")]
        public DateTime Olasidxdat0 { get; set; }
        [Column("CONREW_0")]
        public byte Conrew0 { get; set; }
        [Column("MANREWFLG_0")]
        public byte Manrewflg0 { get; set; }
        [Column("MANREWAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Manrewamt0 { get; set; }
        [Column("RSILTI_0")]
        public short Rsilti0 { get; set; }
        [Column("RSILTIBAS_0")]
        public byte Rsiltibas0 { get; set; }
        [Column("EVRPBL_0")]
        public byte Evrpbl0 { get; set; }
        [Column("EVRMAC_0")]
        public byte Evrmac0 { get; set; }
        [Column("CRSCOVSAM_0")]
        public byte Crscovsam0 { get; set; }
        [Column("ITTFCY_0")]
        public byte Ittfcy0 { get; set; }
        [Column("ITTDUR_0")]
        public short Ittdur0 { get; set; }
        [Column("ITTDURBAS_0")]
        public byte Ittdurbas0 { get; set; }
        [Column("ITTDATEND_0", TypeName = "datetime")]
        public DateTime Ittdatend0 { get; set; }
        [Column("ITTLTIMAX_0")]
        public short Ittltimax0 { get; set; }
        [Column("BASEXXITT_0")]
        public byte Basexxitt0 { get; set; }
        [Column("SOLLTIMAX_0")]
        public short Solltimax0 { get; set; }
        [Column("BASEXXSOL_0")]
        public byte Basexxsol0 { get; set; }
        [Column("AMTPLY_0", TypeName = "numeric(27, 13)")]
        public decimal Amtply0 { get; set; }
        [Column("BASEXXAMT_0")]
        public byte Basexxamt0 { get; set; }
        [Required]
        [Column("OTHCNI_0")]
        [StringLength(250)]
        public string Othcni0 { get; set; }
        [Column("ITTFCYX_0")]
        public byte Ittfcyx0 { get; set; }
        [Column("ITTDURX_0")]
        public short Ittdurx0 { get; set; }
        [Column("ITTDURBASX_0")]
        public byte Ittdurbasx0 { get; set; }
        [Column("ITTDATENDX_0", TypeName = "datetime")]
        public DateTime Ittdatendx0 { get; set; }
        [Column("ITTLTIMAXX_0")]
        public short Ittltimaxx0 { get; set; }
        [Column("BASEXXITTX_0")]
        public byte Basexxittx0 { get; set; }
        [Column("SOLLTIMAXX_0")]
        public short Solltimaxx0 { get; set; }
        [Column("BASEXXSOLX_0")]
        public byte Basexxsolx0 { get; set; }
        [Column("AMTPLYX_0", TypeName = "numeric(27, 13)")]
        public decimal Amtplyx0 { get; set; }
        [Column("BASEXXAMTX_0")]
        public byte Basexxamtx0 { get; set; }
        [Column("RSIFLG_0")]
        public byte Rsiflg0 { get; set; }
        [Column("RSIDAT_0", TypeName = "datetime")]
        public DateTime Rsidat0 { get; set; }
        [Required]
        [Column("RSIREN_0")]
        [StringLength(20)]
        public string Rsiren0 { get; set; }
        [Column("FDDFLG_0")]
        public byte Fddflg0 { get; set; }
        [Required]
        [Column("FDDUSR_0")]
        [StringLength(5)]
        public string Fddusr0 { get; set; }
        [Required]
        [Column("ORDNUM_0")]
        [StringLength(20)]
        public string Ordnum0 { get; set; }
        [Column("ORDLINNUM_0")]
        public int Ordlinnum0 { get; set; }
        [Column("ORDUPDFLG_0")]
        public byte Ordupdflg0 { get; set; }
        [Required]
        [Column("ACPDPTCOD_0")]
        [StringLength(20)]
        public string Acpdptcod0 { get; set; }
        [Required]
        [Column("ACPDPTCOD_1")]
        [StringLength(20)]
        public string Acpdptcod1 { get; set; }
        [Required]
        [Column("ACPDPTCOD_2")]
        [StringLength(20)]
        public string Acpdptcod2 { get; set; }
        [Required]
        [Column("ACPDPTCOD_3")]
        [StringLength(20)]
        public string Acpdptcod3 { get; set; }
        [Required]
        [Column("ACPDPTCOD_4")]
        [StringLength(20)]
        public string Acpdptcod4 { get; set; }
        [Required]
        [Column("ACPDPTCOD_5")]
        [StringLength(20)]
        public string Acpdptcod5 { get; set; }
        [Required]
        [Column("ACPDPTCOD_6")]
        [StringLength(20)]
        public string Acpdptcod6 { get; set; }
        [Required]
        [Column("ACPDPTCOD_7")]
        [StringLength(20)]
        public string Acpdptcod7 { get; set; }
        [Required]
        [Column("ACPDPTCOD_8")]
        [StringLength(20)]
        public string Acpdptcod8 { get; set; }
        [Required]
        [Column("ACPDPTCOD_9")]
        [StringLength(20)]
        public string Acpdptcod9 { get; set; }
        [Required]
        [Column("ACPDPTCOD_10")]
        [StringLength(20)]
        public string Acpdptcod10 { get; set; }
        [Required]
        [Column("ACPDPTCOD_11")]
        [StringLength(20)]
        public string Acpdptcod11 { get; set; }
        [Required]
        [Column("ACPDPTCOD_12")]
        [StringLength(20)]
        public string Acpdptcod12 { get; set; }
        [Required]
        [Column("ACPDPTCOD_13")]
        [StringLength(20)]
        public string Acpdptcod13 { get; set; }
        [Required]
        [Column("ACPDPTCOD_14")]
        [StringLength(20)]
        public string Acpdptcod14 { get; set; }
        [Required]
        [Column("ACPDPTCOD_15")]
        [StringLength(20)]
        public string Acpdptcod15 { get; set; }
        [Required]
        [Column("ACPDPTCOD_16")]
        [StringLength(20)]
        public string Acpdptcod16 { get; set; }
        [Required]
        [Column("ACPDPTCOD_17")]
        [StringLength(20)]
        public string Acpdptcod17 { get; set; }
        [Required]
        [Column("ACPDPTCOD_18")]
        [StringLength(20)]
        public string Acpdptcod18 { get; set; }
        [Required]
        [Column("ACPDPTCOD_19")]
        [StringLength(20)]
        public string Acpdptcod19 { get; set; }
        [Required]
        [Column("ACPDPTCOD_20")]
        [StringLength(20)]
        public string Acpdptcod20 { get; set; }
        [Required]
        [Column("ACPDPTCOD_21")]
        [StringLength(20)]
        public string Acpdptcod21 { get; set; }
        [Required]
        [Column("ACPDPTCOD_22")]
        [StringLength(20)]
        public string Acpdptcod22 { get; set; }
        [Required]
        [Column("ACPDPTCOD_23")]
        [StringLength(20)]
        public string Acpdptcod23 { get; set; }
        [Required]
        [Column("ACPDPTCOD_24")]
        [StringLength(20)]
        public string Acpdptcod24 { get; set; }
        [Required]
        [Column("OINV_0")]
        [StringLength(20)]
        public string Oinv0 { get; set; }
        [Required]
        [Column("OREWINV_0")]
        [StringLength(20)]
        public string Orewinv0 { get; set; }
        [Required]
        [Column("ORVAINV_0")]
        [StringLength(20)]
        public string Orvainv0 { get; set; }
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
        [Column("INVDTATYP_0")]
        public byte Invdtatyp0 { get; set; }
        [Column("INVDTATYP_1")]
        public byte Invdtatyp1 { get; set; }
        [Column("INVDTATYP_2")]
        public byte Invdtatyp2 { get; set; }
        [Column("INVDTATYP_3")]
        public byte Invdtatyp3 { get; set; }
        [Column("INVDTATYP_4")]
        public byte Invdtatyp4 { get; set; }
        [Column("INVDTATYP_5")]
        public byte Invdtatyp5 { get; set; }
        [Column("INVDTATYP_6")]
        public byte Invdtatyp6 { get; set; }
        [Column("INVDTATYP_7")]
        public byte Invdtatyp7 { get; set; }
        [Column("INVDTATYP_8")]
        public byte Invdtatyp8 { get; set; }
        [Column("INVDTATYP_9")]
        public byte Invdtatyp9 { get; set; }
        [Column("INVDTATYP_10")]
        public byte Invdtatyp10 { get; set; }
        [Column("INVDTATYP_11")]
        public byte Invdtatyp11 { get; set; }
        [Column("INVDTATYP_12")]
        public byte Invdtatyp12 { get; set; }
        [Column("INVDTATYP_13")]
        public byte Invdtatyp13 { get; set; }
        [Column("INVDTATYP_14")]
        public byte Invdtatyp14 { get; set; }
        [Column("INVDTATYP_15")]
        public byte Invdtatyp15 { get; set; }
        [Column("INVDTATYP_16")]
        public byte Invdtatyp16 { get; set; }
        [Column("INVDTATYP_17")]
        public byte Invdtatyp17 { get; set; }
        [Column("INVDTATYP_18")]
        public byte Invdtatyp18 { get; set; }
        [Column("INVDTATYP_19")]
        public byte Invdtatyp19 { get; set; }
        [Column("INVDTATYP_20")]
        public byte Invdtatyp20 { get; set; }
        [Column("INVDTATYP_21")]
        public byte Invdtatyp21 { get; set; }
        [Column("INVDTATYP_22")]
        public byte Invdtatyp22 { get; set; }
        [Column("INVDTATYP_23")]
        public byte Invdtatyp23 { get; set; }
        [Column("INVDTATYP_24")]
        public byte Invdtatyp24 { get; set; }
        [Column("INVDTATYP_25")]
        public byte Invdtatyp25 { get; set; }
        [Column("INVDTATYP_26")]
        public byte Invdtatyp26 { get; set; }
        [Column("INVDTATYP_27")]
        public byte Invdtatyp27 { get; set; }
        [Column("INVDTATYP_28")]
        public byte Invdtatyp28 { get; set; }
        [Column("INVDTATYP_29")]
        public byte Invdtatyp29 { get; set; }
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
        [Column("CONORI_0")]
        public byte Conori0 { get; set; }
        [Required]
        [Column("CONORIVCR_0")]
        [StringLength(20)]
        public string Conorivcr0 { get; set; }
        [Column("CONORIVCRL_0")]
        public int Conorivcrl0 { get; set; }
        [Required]
        [Column("CONCOT_0")]
        [StringLength(20)]
        public string Concot0 { get; set; }
        [Column("DSYWND_0")]
        public short Dsywnd0 { get; set; }
        [Column("ODSYWND_0")]
        public short Odsywnd0 { get; set; }
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