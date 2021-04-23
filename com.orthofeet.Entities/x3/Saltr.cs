﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SALTRS", Schema = "TESTPROD")]
    [Index(nameof(Strtyp0), nameof(Strnum0), Name = "SALTRS_SLT0", IsUnique = true)]
    [Index(nameof(Strnum0), nameof(Strtyp0), Name = "SALTRS_SLT1", IsUnique = true)]
    public partial class Saltr
    {
        [Column("STRTYP_0")]
        public byte Strtyp0 { get; set; }
        [Required]
        [Column("STRNUM_0")]
        [StringLength(5)]
        public string Strnum0 { get; set; }
        [Required]
        [Column("STRTYPCAR_0")]
        [StringLength(2)]
        public string Strtypcar0 { get; set; }
        [Required]
        [Column("STRDES_0")]
        [StringLength(35)]
        public string Strdes0 { get; set; }
        [Required]
        [Column("ACSCOD_0")]
        [StringLength(20)]
        public string Acscod0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Required]
        [Column("GFY_0")]
        [StringLength(5)]
        public string Gfy0 { get; set; }
        [Column("DOCFLG_0")]
        public byte Docflg0 { get; set; }
        [Required]
        [Column("DOCNAM_0")]
        [StringLength(15)]
        public string Docnam0 { get; set; }
        [Column("SNSFLG_0")]
        public byte Snsflg0 { get; set; }
        [Required]
        [Column("SNSNAM_0")]
        [StringLength(15)]
        public string Snsnam0 { get; set; }
        [Column("NPRFLG_0")]
        public byte Nprflg0 { get; set; }
        [Required]
        [Column("NPRNAM_0")]
        [StringLength(15)]
        public string Nprnam0 { get; set; }
        [Column("NTRFLG_0")]
        public byte Ntrflg0 { get; set; }
        [Required]
        [Column("NTRNAM_0")]
        [StringLength(15)]
        public string Ntrnam0 { get; set; }
        [Column("ORDCAT_0")]
        public byte Ordcat0 { get; set; }
        [Column("DLVTYP_0")]
        public byte Dlvtyp0 { get; set; }
        [Column("INVTYP_0")]
        public byte Invtyp0 { get; set; }
        [Column("STKFLG_0")]
        public byte Stkflg0 { get; set; }
        [Required]
        [Column("TRSCOD_0")]
        [StringLength(10)]
        public string Trscod0 { get; set; }
        [Required]
        [Column("TRSFAM_0")]
        [StringLength(10)]
        public string Trsfam0 { get; set; }
        [Required]
        [Column("ENTCOD_0")]
        [StringLength(10)]
        public string Entcod0 { get; set; }
        [Required]
        [Column("CCEDEF_0")]
        [StringLength(20)]
        public string Ccedef0 { get; set; }
        [Column("CURCOD_0")]
        public byte Curcod0 { get; set; }
        [Column("RATCURCOD_0")]
        public byte Ratcurcod0 { get; set; }
        [Column("CHGCOD_0")]
        public byte Chgcod0 { get; set; }
        [Column("VACBPRCOD_0")]
        public byte Vacbprcod0 { get; set; }
        [Column("PRITYPCOD_0")]
        public byte Pritypcod0 { get; set; }
        [Column("SQHTYPCOD_0")]
        public byte Sqhtypcod0 { get; set; }
        [Column("VLYDATCOD_0")]
        public byte Vlydatcod0 { get; set; }
        [Column("PBYPRCCOD_0")]
        public byte Pbyprccod0 { get; set; }
        [Column("PJTCOD_0")]
        public byte Pjtcod0 { get; set; }
        [Column("STOFCYCOD_0")]
        public byte Stofcycod0 { get; set; }
        [Column("DEMDLVCOD_0")]
        public byte Demdlvcod0 { get; set; }
        [Column("SHIDATCOD_0")]
        public byte Shidatcod0 { get; set; }
        [Column("EXTRTNCOD_0")]
        public byte Extrtncod0 { get; set; }
        [Column("ALLTYPCOD_0")]
        public byte Alltypcod0 { get; set; }
        [Column("ORDCLECOD_0")]
        public byte Ordclecod0 { get; set; }
        [Column("ODLCOD_0")]
        public byte Odlcod0 { get; set; }
        [Column("DMECOD_0")]
        public byte Dmecod0 { get; set; }
        [Column("BETCPYCOD_0")]
        public byte Betcpycod0 { get; set; }
        [Column("PTECOD_0")]
        public byte Ptecod0 { get; set; }
        [Column("DEPCOD_0")]
        public byte Depcod0 { get; set; }
        [Column("SVCDATCOD_0")]
        public byte Svcdatcod0 { get; set; }
        [Column("IMECOD_0")]
        public byte Imecod0 { get; set; }
        [Column("INVNUMCOD_0")]
        public byte Invnumcod0 { get; set; }
        [Column("SIHORICOD_0")]
        public byte Sihoricod0 { get; set; }
        [Column("PIHNUMCOD_0")]
        public byte Pihnumcod0 { get; set; }
        [Column("STOMVTCOD_0")]
        public byte Stomvtcod0 { get; set; }
        [Column("STACOD_0")]
        public byte Stacod0 { get; set; }
        [Column("BPRFCTCOD_0")]
        public byte Bprfctcod0 { get; set; }
        [Column("AMTCOD_0")]
        public byte Amtcod0 { get; set; }
        [Column("ITMDESCOD_0")]
        public byte Itmdescod0 { get; set; }
        [Column("ITMDESSCR_0")]
        public byte Itmdesscr0 { get; set; }
        [Column("ITMDESACOD_0")]
        public byte Itmdesacod0 { get; set; }
        [Column("ITMDES1COD_0")]
        public byte Itmdes1cod0 { get; set; }
        [Column("ITMDES1SCR_0")]
        public byte Itmdes1scr0 { get; set; }
        [Column("ITMDE1ACOD_0")]
        public byte Itmde1acod0 { get; set; }
        [Column("SAUCOD_0")]
        public byte Saucod0 { get; set; }
        [Column("SAUSCR_0")]
        public byte Sauscr0 { get; set; }
        [Column("SAUCOECOD_0")]
        public byte Saucoecod0 { get; set; }
        [Column("SAUCOESCR_0")]
        public byte Saucoescr0 { get; set; }
        [Column("GROPRICOD_0")]
        public byte Gropricod0 { get; set; }
        [Column("GROPRISCR_0")]
        public byte Gropriscr0 { get; set; }
        [Column("CPRPRICOD_0")]
        public byte Cprpricod0 { get; set; }
        [Column("CPRPRISCR_0")]
        public byte Cprpriscr0 { get; set; }
        [Column("VACITMCOD_0")]
        public byte Vacitmcod0 { get; set; }
        [Column("VACITMSCR_0")]
        public byte Vacitmscr0 { get; set; }
        [Column("AMTLINCOD_0")]
        public byte Amtlincod0 { get; set; }
        [Column("AMTLINSCR_0")]
        public byte Amtlinscr0 { get; set; }
        [Column("CNDNAMCOD_0")]
        public byte Cndnamcod0 { get; set; }
        [Column("CNDNAMSCR_0")]
        public byte Cndnamscr0 { get; set; }
        [Column("STOFCYCODD_0")]
        public byte Stofcycodd0 { get; set; }
        [Column("STOFCYSCRD_0")]
        public byte Stofcyscrd0 { get; set; }
        [Column("DEMDLVCODD_0")]
        public byte Demdlvcodd0 { get; set; }
        [Column("DEMDLVSCRD_0")]
        public byte Demdlvscrd0 { get; set; }
        [Column("SHIDATCODD_0")]
        public byte Shidatcodd0 { get; set; }
        [Column("SHIDATSCRD_0")]
        public byte Shidatscrd0 { get; set; }
        [Column("EXTDLVCOD_0")]
        public byte Extdlvcod0 { get; set; }
        [Column("EXTDLVSCR_0")]
        public byte Extdlvscr0 { get; set; }
        [Column("DLVDATCOD_0")]
        public byte Dlvdatcod0 { get; set; }
        [Column("LNDRTNCOD_0")]
        public byte Lndrtncod0 { get; set; }
        [Column("DEMSTACOD_0")]
        public byte Demstacod0 { get; set; }
        [Column("DEMSTASCR_0")]
        public byte Demstascr0 { get; set; }
        [Column("BPCORDCOD_0")]
        public byte Bpcordcod0 { get; set; }
        [Column("BPCINVCOD_0")]
        public byte Bpcinvcod0 { get; set; }
        [Column("BPCPYRCOD_0")]
        public byte Bpcpyrcod0 { get; set; }
        [Column("BPCGRUCOD_0")]
        public byte Bpcgrucod0 { get; set; }
        [Column("CNTNAMCOD_0")]
        public byte Cntnamcod0 { get; set; }
        [Column("CCECOD_0")]
        public byte Ccecod0 { get; set; }
        [Column("INVDTACOD_0")]
        public byte Invdtacod0 { get; set; }
        [Column("USEPLCCOD_0")]
        public byte Useplccod0 { get; set; }
        [Column("USEPLCSCR_0")]
        public byte Useplcscr0 { get; set; }
        [Column("PCKCOD_0")]
        public byte Pckcod0 { get; set; }
        [Column("PCKSCR_0")]
        public byte Pckscr0 { get; set; }
        [Column("EXTQTYCOD_0")]
        public byte Extqtycod0 { get; set; }
        [Column("EXTQTYSCR_0")]
        public byte Extqtyscr0 { get; set; }
        [Column("PLICOD_0")]
        public byte Plicod0 { get; set; }
        [Column("PLISCR_0")]
        public byte Pliscr0 { get; set; }
        [Column("VACBPRCODD_0")]
        public byte Vacbprcodd0 { get; set; }
        [Column("EXTAMTCOD_0")]
        public byte Extamtcod0 { get; set; }
        [Column("EXTAMTSCR_0")]
        public byte Extamtscr0 { get; set; }
        [Column("CPLAMTCOD_0")]
        public byte Cplamtcod0 { get; set; }
        [Column("CPLAMTSCR_0")]
        public byte Cplamtscr0 { get; set; }
        [Column("BPAADDCOD_0")]
        public byte Bpaaddcod0 { get; set; }
        [Column("REPCOD_0")]
        public byte Repcod0 { get; set; }
        [Column("DLVPIOCOD_0")]
        public byte Dlvpiocod0 { get; set; }
        [Column("DAYLTICOD_0")]
        public byte Daylticod0 { get; set; }
        [Column("MDLCOD_0")]
        public byte Mdlcod0 { get; set; }
        [Column("BPTNUMCOD_0")]
        public byte Bptnumcod0 { get; set; }
        [Column("BPAADDCODD_0")]
        public byte Bpaaddcodd0 { get; set; }
        [Column("BPAADDSCRD_0")]
        public byte Bpaaddscrd0 { get; set; }
        [Column("REPCODD_0")]
        public byte Repcodd0 { get; set; }
        [Column("REPSCRD_0")]
        public byte Repscrd0 { get; set; }
        [Column("DLVPIOCODD_0")]
        public byte Dlvpiocodd0 { get; set; }
        [Column("DLVPIOSCRD_0")]
        public byte Dlvpioscrd0 { get; set; }
        [Column("DAYLTICODD_0")]
        public byte Daylticodd0 { get; set; }
        [Column("DAYLTISCRD_0")]
        public byte Dayltiscrd0 { get; set; }
        [Column("DRNCODD_0")]
        public byte Drncodd0 { get; set; }
        [Column("DRNSCRD_0")]
        public byte Drnscrd0 { get; set; }
        [Column("MDLCODD_0")]
        public byte Mdlcodd0 { get; set; }
        [Column("MDLSCRD_0")]
        public byte Mdlscrd0 { get; set; }
        [Column("BPTNUMCODD_0")]
        public byte Bptnumcodd0 { get; set; }
        [Column("BPTNUMSCRD_0")]
        public byte Bptnumscrd0 { get; set; }
        [Column("PRECODCOD_0")]
        public byte Precodcod0 { get; set; }
        [Column("PRECODSCR_0")]
        public byte Precodscr0 { get; set; }
        [Column("CCECODD_0")]
        public byte Ccecodd0 { get; set; }
        [Column("CCECODD_1")]
        public byte Ccecodd1 { get; set; }
        [Column("CCECODD_2")]
        public byte Ccecodd2 { get; set; }
        [Column("CCECODD_3")]
        public byte Ccecodd3 { get; set; }
        [Column("CCECODD_4")]
        public byte Ccecodd4 { get; set; }
        [Column("CCECODD_5")]
        public byte Ccecodd5 { get; set; }
        [Column("CCECODD_6")]
        public byte Ccecodd6 { get; set; }
        [Column("CCECODD_7")]
        public byte Ccecodd7 { get; set; }
        [Column("CCECODD_8")]
        public byte Ccecodd8 { get; set; }
        [Column("CCECODD_9")]
        public byte Ccecodd9 { get; set; }
        [Column("CCECODD_10")]
        public byte Ccecodd10 { get; set; }
        [Column("CCECODD_11")]
        public byte Ccecodd11 { get; set; }
        [Column("CCECODD_12")]
        public byte Ccecodd12 { get; set; }
        [Column("CCECODD_13")]
        public byte Ccecodd13 { get; set; }
        [Column("CCECODD_14")]
        public byte Ccecodd14 { get; set; }
        [Column("CCECODD_15")]
        public byte Ccecodd15 { get; set; }
        [Column("CCECODD_16")]
        public byte Ccecodd16 { get; set; }
        [Column("CCECODD_17")]
        public byte Ccecodd17 { get; set; }
        [Column("CCECODD_18")]
        public byte Ccecodd18 { get; set; }
        [Column("CCECODD_19")]
        public byte Ccecodd19 { get; set; }
        [Column("CCESCRD_0")]
        public byte Ccescrd0 { get; set; }
        [Column("CCESCRD_1")]
        public byte Ccescrd1 { get; set; }
        [Column("CCESCRD_2")]
        public byte Ccescrd2 { get; set; }
        [Column("CCESCRD_3")]
        public byte Ccescrd3 { get; set; }
        [Column("CCESCRD_4")]
        public byte Ccescrd4 { get; set; }
        [Column("CCESCRD_5")]
        public byte Ccescrd5 { get; set; }
        [Column("CCESCRD_6")]
        public byte Ccescrd6 { get; set; }
        [Column("CCESCRD_7")]
        public byte Ccescrd7 { get; set; }
        [Column("CCESCRD_8")]
        public byte Ccescrd8 { get; set; }
        [Column("CCESCRD_9")]
        public byte Ccescrd9 { get; set; }
        [Column("CCESCRD_10")]
        public byte Ccescrd10 { get; set; }
        [Column("CCESCRD_11")]
        public byte Ccescrd11 { get; set; }
        [Column("CCESCRD_12")]
        public byte Ccescrd12 { get; set; }
        [Column("CCESCRD_13")]
        public byte Ccescrd13 { get; set; }
        [Column("CCESCRD_14")]
        public byte Ccescrd14 { get; set; }
        [Column("CCESCRD_15")]
        public byte Ccescrd15 { get; set; }
        [Column("CCESCRD_16")]
        public byte Ccescrd16 { get; set; }
        [Column("CCESCRD_17")]
        public byte Ccescrd17 { get; set; }
        [Column("CCESCRD_18")]
        public byte Ccescrd18 { get; set; }
        [Column("CCESCRD_19")]
        public byte Ccescrd19 { get; set; }
        [Column("SVCDATCODD_0")]
        public byte Svcdatcodd0 { get; set; }
        [Column("SVCDATSCRD_0")]
        public byte Svcdatscrd0 { get; set; }
        [Column("UNLCOD_0")]
        public byte Unlcod0 { get; set; }
        [Column("BPRSACCOD_0")]
        public byte Bprsaccod0 { get; set; }
        [Column("DUDDATCOD_0")]
        public byte Duddatcod0 { get; set; }
        [Column("DESCOD_0")]
        public byte Descod0 { get; set; }
        [Column("FMICOD_0")]
        public byte Fmicod0 { get; set; }
        [Column("FMISCR_0")]
        public byte Fmiscr0 { get; set; }
        [Column("DRNCOD_0")]
        public byte Drncod0 { get; set; }
        [Column("PACNBRCOD_0")]
        public byte Pacnbrcod0 { get; set; }
        [Column("WEICOD_0")]
        public byte Weicod0 { get; set; }
        [Column("WEICODD_0")]
        public byte Weicodd0 { get; set; }
        [Column("WEISCRD_0")]
        public byte Weiscrd0 { get; set; }
        [Column("VOLCOD_0")]
        public byte Volcod0 { get; set; }
        [Column("DISCRGCOD1_0")]
        public byte Discrgcod10 { get; set; }
        [Column("DISCRGSCR1_0")]
        public byte Discrgscr10 { get; set; }
        [Column("DISCRGCOD2_0")]
        public byte Discrgcod20 { get; set; }
        [Column("DISCRGSCR2_0")]
        public byte Discrgscr20 { get; set; }
        [Column("DISCRGCOD3_0")]
        public byte Discrgcod30 { get; set; }
        [Column("DISCRGSCR3_0")]
        public byte Discrgscr30 { get; set; }
        [Column("DISCRGCOD4_0")]
        public short Discrgcod40 { get; set; }
        [Column("DISCRGSCR4_0")]
        public short Discrgscr40 { get; set; }
        [Column("DISCRGCOD5_0")]
        public short Discrgcod50 { get; set; }
        [Column("DISCRGSCR5_0")]
        public short Discrgscr50 { get; set; }
        [Column("DISCRGCOD6_0")]
        public short Discrgcod60 { get; set; }
        [Column("DISCRGSCR6_0")]
        public short Discrgscr60 { get; set; }
        [Column("DISCRGCOD7_0")]
        public short Discrgcod70 { get; set; }
        [Column("DISCRGSCR7_0")]
        public short Discrgscr70 { get; set; }
        [Column("DISCRGCOD8_0")]
        public short Discrgcod80 { get; set; }
        [Column("DISCRGSCR8_0")]
        public short Discrgscr80 { get; set; }
        [Column("DISCRGCOD9_0")]
        public short Discrgcod90 { get; set; }
        [Column("DISCRGSCR9_0")]
        public short Discrgscr90 { get; set; }
        [Column("CNORENCOD_0")]
        public byte Cnorencod0 { get; set; }
        [Column("EXYDATCOD_0")]
        public byte Exydatcod0 { get; set; }
        [Column("AUZUSRCOD_0")]
        public byte Auzusrcod0 { get; set; }
        [Column("DATSELCOD_0")]
        public byte Datselcod0 { get; set; }
        [Column("ITMSELCOD_0")]
        public byte Itmselcod0 { get; set; }
        [Column("ORDUPDCOD_0")]
        public byte Ordupdcod0 { get; set; }
        [Column("ORDUPDSCR_0")]
        public byte Ordupdscr0 { get; set; }
        [Column("LASDLVCOD_0")]
        public byte Lasdlvcod0 { get; set; }
        [Column("BETFCYCOD_0")]
        public byte Betfcycod0 { get; set; }
        [Column("LASINVCOD_0")]
        public byte Lasinvcod0 { get; set; }
        [Column("ORDCOD_0")]
        public byte Ordcod0 { get; set; }
        [Column("ORDSCR_0")]
        public byte Ordscr0 { get; set; }
        [Column("STUCOD_0")]
        public byte Stucod0 { get; set; }
        [Column("STUSCR_0")]
        public byte Stuscr0 { get; set; }
        [Column("NETPRICOD_0")]
        public byte Netpricod0 { get; set; }
        [Column("NETPRISCR_0")]
        public byte Netpriscr0 { get; set; }
        [Column("LINAMTCOD_0")]
        public byte Linamtcod0 { get; set; }
        [Column("LINAMTSCR_0")]
        public byte Linamtscr0 { get; set; }
        [Column("ORDCODD_0")]
        public byte Ordcodd0 { get; set; }
        [Column("ORDSCRD_0")]
        public byte Ordscrd0 { get; set; }
        [Column("PRFNUMCOD_0")]
        public byte Prfnumcod0 { get; set; }
        [Column("LINTYPCOD_0")]
        public byte Lintypcod0 { get; set; }
        [Column("LINTYPSCR_0")]
        public byte Lintypscr0 { get; set; }
        [Column("FOCFLGCOD_0")]
        public byte Focflgcod0 { get; set; }
        [Column("FOCFLGSCR_0")]
        public byte Focflgscr0 { get; set; }
        [Column("CCLRENCOD_0")]
        public byte Cclrencod0 { get; set; }
        [Column("CCLRENCODD_0")]
        public byte Cclrencodd0 { get; set; }
        [Column("CCLRENSCRD_0")]
        public byte Cclrenscrd0 { get; set; }
        [Column("CFMFLGCOD_0")]
        public byte Cfmflgcod0 { get; set; }
        [Column("CFMFLGSCR_0")]
        public byte Cfmflgscr0 { get; set; }
        [Column("SQHNUMCOD_0")]
        public byte Sqhnumcod0 { get; set; }
        [Column("SQHNUMCODD_0")]
        public byte Sqhnumcodd0 { get; set; }
        [Column("SQHNUMSCRD_0")]
        public byte Sqhnumscrd0 { get; set; }
        [Column("POHNUMCOD_0")]
        public byte Pohnumcod0 { get; set; }
        [Column("POHNUMSCR_0")]
        public byte Pohnumscr0 { get; set; }
        [Column("FMINUMCOD_0")]
        public byte Fminumcod0 { get; set; }
        [Column("FMINUMSCR_0")]
        public byte Fminumscr0 { get; set; }
        [Column("MFGNUMCOD_0")]
        public byte Mfgnumcod0 { get; set; }
        [Column("MFGNUMSCR_0")]
        public byte Mfgnumscr0 { get; set; }
        [Column("VCRNUMOCOD_0")]
        public byte Vcrnumocod0 { get; set; }
        [Column("VCRNUMOSCR_0")]
        public byte Vcrnumoscr0 { get; set; }
        [Column("PFMCOD_0")]
        public byte Pfmcod0 { get; set; }
        [Column("PFMSCR_0")]
        public byte Pfmscr0 { get; set; }
        [Column("RTNQTYCOD_0")]
        public byte Rtnqtycod0 { get; set; }
        [Column("RTNQTYSCR_0")]
        public byte Rtnqtyscr0 { get; set; }
        [Column("DLVQTYCOD_0")]
        public byte Dlvqtycod0 { get; set; }
        [Column("DLVQTYSCR_0")]
        public byte Dlvqtyscr0 { get; set; }
        [Column("LNDQTYCOD_0")]
        public byte Lndqtycod0 { get; set; }
        [Column("LNDQTYSCR_0")]
        public byte Lndqtyscr0 { get; set; }
        [Column("RTNRENCOD_0")]
        public byte Rtnrencod0 { get; set; }
        [Column("RTNRENSCR_0")]
        public byte Rtnrenscr0 { get; set; }
        [Column("RTNDATCODD_0")]
        public byte Rtndatcodd0 { get; set; }
        [Column("RTNDATSCRD_0")]
        public byte Rtndatscrd0 { get; set; }
        [Column("EXTRTNCODD_0")]
        public byte Extrtncodd0 { get; set; }
        [Column("EXTRTNSCRD_0")]
        public byte Extrtnscrd0 { get; set; }
        [Column("INVUPDCOD_0")]
        public byte Invupdcod0 { get; set; }
        [Column("INVUPDSCR_0")]
        public byte Invupdscr0 { get; set; }
        [Column("CNOFLGCOD_0")]
        public byte Cnoflgcod0 { get; set; }
        [Column("CNOFLGSCR_0")]
        public byte Cnoflgscr0 { get; set; }
        [Column("CNONUMCOD_0")]
        public byte Cnonumcod0 { get; set; }
        [Column("CNONUMSCR_0")]
        public byte Cnonumscr0 { get; set; }
        [Column("DLVNUMCOD_0")]
        public byte Dlvnumcod0 { get; set; }
        [Column("DLVNUMSCR_0")]
        public byte Dlvnumscr0 { get; set; }
        [Column("PNHNUMCOD_0")]
        public byte Pnhnumcod0 { get; set; }
        [Column("PNHNUMSCR_0")]
        public byte Pnhnumscr0 { get; set; }
        [Column("AVASTOCOD_0")]
        public byte Avastocod0 { get; set; }
        [Column("ALLQTYCOD_0")]
        public byte Allqtycod0 { get; set; }
        [Column("ALLQTYSCR_0")]
        public byte Allqtyscr0 { get; set; }
        [Column("SHTQTYCOD_0")]
        public byte Shtqtycod0 { get; set; }
        [Column("SHTQTYSCR_0")]
        public byte Shtqtyscr0 { get; set; }
        [Column("WALLQTYCOD_0")]
        public byte Wallqtycod0 { get; set; }
        [Column("WALLQTYSCR_0")]
        public byte Wallqtyscr0 { get; set; }
        [Column("ALLTYPCODD_0")]
        public byte Alltypcodd0 { get; set; }
        [Column("ALLTYPSCRD_0")]
        public byte Alltypscrd0 { get; set; }
        [Column("LICPLATCOD_0")]
        public byte Licplatcod0 { get; set; }
        [Column("ETDCOD_0")]
        public byte Etdcod0 { get; set; }
        [Column("ETACOD_0")]
        public byte Etacod0 { get; set; }
        [Column("FLOPHYCODD_0")]
        public byte Flophycodd0 { get; set; }
        [Column("FLOPHYSCRD_0")]
        public byte Flophyscrd0 { get; set; }
        [Column("TRSFAMCOD_0")]
        public byte Trsfamcod0 { get; set; }
        [Column("BPCLOCCOD_0")]
        public byte Bpcloccod0 { get; set; }
        [Column("LOTCOD_0")]
        public byte Lotcod0 { get; set; }
        [Column("LOTSCR_0")]
        public byte Lotscr0 { get; set; }
        [Column("SLOCOD_0")]
        public byte Slocod0 { get; set; }
        [Column("SLOSCR_0")]
        public byte Sloscr0 { get; set; }
        [Column("AQRCOD_0")]
        public byte Aqrcod0 { get; set; }
        [Column("AQRSCR_0")]
        public byte Aqrscr0 { get; set; }
        [Column("LOCCOD_0")]
        public byte Loccod0 { get; set; }
        [Column("LOCSCR_0")]
        public byte Locscr0 { get; set; }
        [Column("SERCOD_0")]
        public byte Sercod0 { get; set; }
        [Column("SERSCR_0")]
        public byte Serscr0 { get; set; }
        [Column("SERECOD_0")]
        public byte Serecod0 { get; set; }
        [Column("SERESCR_0")]
        public byte Serescr0 { get; set; }
        [Column("IDECOD01_0")]
        public byte Idecod010 { get; set; }
        [Column("IDESCR01_0")]
        public byte Idescr010 { get; set; }
        [Column("IDECOD02_0")]
        public byte Idecod020 { get; set; }
        [Column("IDESCR02_0")]
        public byte Idescr020 { get; set; }
        [Column("MVTDESCOD_0")]
        public byte Mvtdescod0 { get; set; }
        [Column("MVTDESSCR_0")]
        public byte Mvtdesscr0 { get; set; }
        [Column("CCECODS_0")]
        public byte Ccecods0 { get; set; }
        [Column("SRGWAIFLG_0")]
        public byte Srgwaiflg0 { get; set; }
        [Column("UOMSAIFLG_0")]
        public byte Uomsaiflg0 { get; set; }
        [Column("BPSLOTCOD_0")]
        public byte Bpslotcod0 { get; set; }
        [Column("BPSLOTSCR_0")]
        public byte Bpslotscr0 { get; set; }
        [Column("NBSLOFLG_0")]
        public byte Nbsloflg0 { get; set; }
        [Column("MVTPRICOD_0")]
        public byte Mvtpricod0 { get; set; }
        [Column("MVTPRISCR_0")]
        public byte Mvtpriscr0 { get; set; }
        [Column("UOMSAIFLG1_0")]
        public byte Uomsaiflg10 { get; set; }
        [Column("BPSLOTCOD1_0")]
        public byte Bpslotcod10 { get; set; }
        [Column("BPSLOTSCR1_0")]
        public byte Bpslotscr10 { get; set; }
        [Column("IDECOD1_0")]
        public byte Idecod10 { get; set; }
        [Column("IDESCR1_0")]
        public byte Idescr10 { get; set; }
        [Column("IDECOD2_0")]
        public byte Idecod20 { get; set; }
        [Column("IDESCR2_0")]
        public byte Idescr20 { get; set; }
        [Column("PRNCOD1_0")]
        public byte Prncod10 { get; set; }
        [Column("PRNSCR1_0")]
        public byte Prnscr10 { get; set; }
        [Column("PRNNBFLG1_0")]
        public byte Prnnbflg10 { get; set; }
        [Column("PRNNBSCR1_0")]
        public byte Prnnbscr10 { get; set; }
        [Column("MVTPRICOD1_0")]
        public byte Mvtpricod10 { get; set; }
        [Column("SERECOD1_0")]
        public byte Serecod10 { get; set; }
        [Column("SERESCR1_0")]
        public byte Serescr10 { get; set; }
        [Column("MVTDESCOD1_0")]
        public byte Mvtdescod10 { get; set; }
        [Column("AVSTOCOD1_0")]
        public byte Avstocod10 { get; set; }
        [Column("AVSTOSCR1_0")]
        public byte Avstoscr10 { get; set; }
        [Column("SPERFLG_0")]
        public byte Sperflg0 { get; set; }
        [Column("SPOTFLG_0")]
        public byte Spotflg0 { get; set; }
        [Column("SRUB1FLG_0")]
        public byte Srub1flg0 { get; set; }
        [Column("SRUB2FLG_0")]
        public byte Srub2flg0 { get; set; }
        [Column("SRUB3FLG_0")]
        public byte Srub3flg0 { get; set; }
        [Column("SRUB4FLG_0")]
        public byte Srub4flg0 { get; set; }
        [Column("NBRCOL_0")]
        public short Nbrcol0 { get; set; }
        [Column("PKGTYP_0")]
        public byte Pkgtyp0 { get; set; }
        [Required]
        [Column("PKTNUM_0")]
        [StringLength(5)]
        public string Pktnum0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Column("OFFFLD_0")]
        public byte Offfld0 { get; set; }
        [Column("OFFTYP_0")]
        public byte Offtyp0 { get; set; }
        [Column("WRHCOD_0")]
        public byte Wrhcod0 { get; set; }
        [Column("WRHSCR_0")]
        public byte Wrhscr0 { get; set; }
        [Column("WRHOBY_0")]
        public byte Wrhoby0 { get; set; }
        [Column("WRHCOD1_0")]
        public byte Wrhcod10 { get; set; }
        [Column("WRHSCR1_0")]
        public byte Wrhscr10 { get; set; }
        [Column("EECICTCOD_0")]
        public byte Eecictcod0 { get; set; }
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