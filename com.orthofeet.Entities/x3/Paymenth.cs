﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PAYMENTH", Schema = "TESTPROD")]
    [Index(nameof(Num0), Name = "PAYMENTH_PYH0", IsUnique = true)]
    [Index(nameof(Frmflg0), nameof(Frmnum0), nameof(Frmlin0), Name = "PAYMENTH_PYH1")]
    [Index(nameof(Paylot0), nameof(Paylotlig0), nameof(Num0), Name = "PAYMENTH_PYH2", IsUnique = true)]
    [Index(nameof(Paytyp0), nameof(Num0), Name = "PAYMENTH_PYH3", IsUnique = true)]
    [Index(nameof(Duddat0), nameof(Num0), Name = "PAYMENTH_PYH4", IsUnique = true)]
    public partial class Paymenth
    {
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Column("FRMFLG_0")]
        public byte Frmflg0 { get; set; }
        [Required]
        [Column("FRMNUM_0")]
        [StringLength(20)]
        public string Frmnum0 { get; set; }
        [Column("FRMLIN_0")]
        public short Frmlin0 { get; set; }
        [Required]
        [Column("FRMREF_0")]
        [StringLength(10)]
        public string Frmref0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(15)]
        public string Bpr0 { get; set; }
        [Required]
        [Column("BPRSAC_0")]
        [StringLength(4)]
        public string Bprsac0 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("PAYTYP_0")]
        [StringLength(5)]
        public string Paytyp0 { get; set; }
        [Required]
        [Column("PAM_0")]
        [StringLength(20)]
        public string Pam0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("BAN_0")]
        [StringLength(5)]
        public string Ban0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Column("SNS_0")]
        public byte Sns0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("AMTCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Amtcur0 { get; set; }
        [Column("AMTBAN_0", TypeName = "numeric(27, 13)")]
        public decimal Amtban0 { get; set; }
        [Column("BANPAYTPY_0", TypeName = "numeric(27, 13)")]
        public decimal Banpaytpy0 { get; set; }
        [Column("AMTNYTBIL_0", TypeName = "numeric(27, 13)")]
        public decimal Amtnytbil0 { get; set; }
        [Column("BPRTYP_0")]
        public byte Bprtyp0 { get; set; }
        [Column("PABAMTPRT_0", TypeName = "numeric(27, 13)")]
        public decimal Pabamtprt0 { get; set; }
        [Column("PABFLG_0")]
        public byte Pabflg0 { get; set; }
        [Required]
        [Column("PABREN_0")]
        [StringLength(20)]
        public string Pabren0 { get; set; }
        [Column("STA_0")]
        public byte Sta0 { get; set; }
        [Column("STAFLG_0")]
        public byte Staflg0 { get; set; }
        [Column("STAFLG_1")]
        public byte Staflg1 { get; set; }
        [Column("STAFLG_2")]
        public byte Staflg2 { get; set; }
        [Column("STAFLG_3")]
        public byte Staflg3 { get; set; }
        [Column("STAFLG_4")]
        public byte Staflg4 { get; set; }
        [Column("STAFLG_5")]
        public byte Staflg5 { get; set; }
        [Column("STAFLG_6")]
        public byte Staflg6 { get; set; }
        [Column("STAFLG_7")]
        public byte Staflg7 { get; set; }
        [Column("STAFLG_8")]
        public byte Staflg8 { get; set; }
        [Column("STAFLG_9")]
        public byte Staflg9 { get; set; }
        [Column("STAFLG_10")]
        public byte Staflg10 { get; set; }
        [Column("ACCNUMTRE_0")]
        public int Accnumtre0 { get; set; }
        [Column("ACCNUMTRE_1")]
        public int Accnumtre1 { get; set; }
        [Column("ACCNUMTRE_2")]
        public int Accnumtre2 { get; set; }
        [Column("ACCNUMTRE_3")]
        public int Accnumtre3 { get; set; }
        [Column("ACCNUMTRE_4")]
        public int Accnumtre4 { get; set; }
        [Column("ACCNUMTRE_5")]
        public int Accnumtre5 { get; set; }
        [Column("ACCNUMTRE_6")]
        public int Accnumtre6 { get; set; }
        [Column("ACCNUMTRE_7")]
        public int Accnumtre7 { get; set; }
        [Column("ACCNUMTRE_8")]
        public int Accnumtre8 { get; set; }
        [Column("ACCNUMTRE_9")]
        public int Accnumtre9 { get; set; }
        [Column("ACCNUMTRE_10")]
        public int Accnumtre10 { get; set; }
        [Required]
        [Column("NUMORD_0")]
        [StringLength(1)]
        public string Numord0 { get; set; }
        [Required]
        [Column("PAYNUMEND_0")]
        [StringLength(1)]
        public string Paynumend0 { get; set; }
        [Required]
        [Column("SENBPR_0")]
        [StringLength(1)]
        public string Senbpr0 { get; set; }
        [Required]
        [Column("SENCRN_0")]
        [StringLength(1)]
        public string Sencrn0 { get; set; }
        [Required]
        [Column("SENORI_0")]
        [StringLength(1)]
        public string Senori0 { get; set; }
        [Column("FLGEND_0")]
        public short Flgend0 { get; set; }
        [Required]
        [Column("RENNOTPAY_0")]
        [StringLength(20)]
        public string Rennotpay0 { get; set; }
        [Column("ACCDAT_0", TypeName = "datetime")]
        public DateTime Accdat0 { get; set; }
        [Required]
        [Column("REF_0")]
        [StringLength(30)]
        public string Ref0 { get; set; }
        [Column("ORIDAT_0", TypeName = "datetime")]
        public DateTime Oridat0 { get; set; }
        [Column("DUDDAT_0", TypeName = "datetime")]
        public DateTime Duddat0 { get; set; }
        [Column("BANDAT_0", TypeName = "datetime")]
        public DateTime Bandat0 { get; set; }
        [Column("VALDAT_0", TypeName = "datetime")]
        public DateTime Valdat0 { get; set; }
        [Column("BILDAT_0", TypeName = "datetime")]
        public DateTime Bildat0 { get; set; }
        [Required]
        [Column("BIDCRY_0")]
        [StringLength(3)]
        public string Bidcry0 { get; set; }
        [Required]
        [Column("BID_0")]
        [StringLength(30)]
        public string Bid0 { get; set; }
        [Required]
        [Column("PAB1_0")]
        [StringLength(35)]
        public string Pab10 { get; set; }
        [Required]
        [Column("PAB2_0")]
        [StringLength(35)]
        public string Pab20 { get; set; }
        [Required]
        [Column("PAB3_0")]
        [StringLength(1)]
        public string Pab30 { get; set; }
        [Required]
        [Column("PAB4_0")]
        [StringLength(1)]
        public string Pab40 { get; set; }
        [Required]
        [Column("BICCOD_0")]
        [StringLength(1)]
        public string Biccod0 { get; set; }
        [Required]
        [Column("MIDPAB1_0")]
        [StringLength(1)]
        public string Midpab10 { get; set; }
        [Required]
        [Column("MIDPAB2_0")]
        [StringLength(1)]
        public string Midpab20 { get; set; }
        [Required]
        [Column("MIDPAB3_0")]
        [StringLength(1)]
        public string Midpab30 { get; set; }
        [Required]
        [Column("MIDPAB4_0")]
        [StringLength(1)]
        public string Midpab40 { get; set; }
        [Required]
        [Column("MIDBICCOD_0")]
        [StringLength(1)]
        public string Midbiccod0 { get; set; }
        [Required]
        [Column("MIDCRY_0")]
        [StringLength(1)]
        public string Midcry0 { get; set; }
        [Required]
        [Column("BPRREF_0")]
        [StringLength(10)]
        public string Bprref0 { get; set; }
        [Column("CHQTYP_0")]
        public byte Chqtyp0 { get; set; }
        [Required]
        [Column("CHQBAN_0")]
        [StringLength(10)]
        public string Chqban0 { get; set; }
        [Required]
        [Column("CHQNUM_0")]
        [StringLength(15)]
        public string Chqnum0 { get; set; }
        [Required]
        [Column("CRDNUM_0")]
        [StringLength(16)]
        public string Crdnum0 { get; set; }
        [Column("CRDEXYDAT_0", TypeName = "datetime")]
        public DateTime Crdexydat0 { get; set; }
        [Required]
        [Column("CRDTYP_0")]
        [StringLength(20)]
        public string Crdtyp0 { get; set; }
        [Required]
        [Column("CRDAUZ_0")]
        [StringLength(15)]
        public string Crdauz0 { get; set; }
        [Column("FRMTYP_0")]
        public byte Frmtyp0 { get; set; }
        [Column("PURTYP_0")]
        public byte Purtyp0 { get; set; }
        [Required]
        [Column("SUP1_0")]
        [StringLength(20)]
        public string Sup10 { get; set; }
        [Required]
        [Column("SUP2_0")]
        [StringLength(20)]
        public string Sup20 { get; set; }
        [Required]
        [Column("SUP3_0")]
        [StringLength(20)]
        public string Sup30 { get; set; }
        [Required]
        [Column("BDFMVTCOD_0")]
        [StringLength(20)]
        public string Bdfmvtcod0 { get; set; }
        [Required]
        [Column("BDFPAYCOD_0")]
        [StringLength(20)]
        public string Bdfpaycod0 { get; set; }
        [Required]
        [Column("BDFECOCOD_0")]
        [StringLength(20)]
        public string Bdfecocod0 { get; set; }
        [Column("PST_0")]
        public short Pst0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Required]
        [Column("FRMUSR_0")]
        [StringLength(5)]
        public string Frmusr0 { get; set; }
        [Column("FRMDAT_0", TypeName = "datetime")]
        public DateTime Frmdat0 { get; set; }
        [Required]
        [Column("FRMFCY_0")]
        [StringLength(5)]
        public string Frmfcy0 { get; set; }
        [Column("FIY_0")]
        public short Fiy0 { get; set; }
        [Column("PER_0")]
        public short Per0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Column("EDTNUM_0")]
        public int Edtnum0 { get; set; }
        [Column("TFBDAT_0", TypeName = "datetime")]
        public DateTime Tfbdat0 { get; set; }
        [Required]
        [Column("TFBFIL_0")]
        [StringLength(15)]
        public string Tfbfil0 { get; set; }
        [Required]
        [Column("PAYLOT_0")]
        [StringLength(20)]
        public string Paylot0 { get; set; }
        [Column("PAYLOTLIG_0")]
        public short Paylotlig0 { get; set; }
        [Required]
        [Column("BILVCR_0")]
        [StringLength(20)]
        public string Bilvcr0 { get; set; }
        [Required]
        [Column("BPAINV_0")]
        [StringLength(7)]
        public string Bpainv0 { get; set; }
        [Required]
        [Column("BPANAM_0")]
        [StringLength(35)]
        public string Bpanam0 { get; set; }
        [Required]
        [Column("BPAADDLIG_0")]
        [StringLength(35)]
        public string Bpaaddlig0 { get; set; }
        [Required]
        [Column("BPAADDLIG_1")]
        [StringLength(35)]
        public string Bpaaddlig1 { get; set; }
        [Required]
        [Column("BPAADDLIG_2")]
        [StringLength(35)]
        public string Bpaaddlig2 { get; set; }
        [Required]
        [Column("POSCOD_0")]
        [StringLength(10)]
        public string Poscod0 { get; set; }
        [Required]
        [Column("CTY_0")]
        [StringLength(30)]
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
        [StringLength(30)]
        public string Crynam0 { get; set; }
        [Required]
        [Column("ACS_0")]
        [StringLength(10)]
        public string Acs0 { get; set; }
        [Required]
        [Column("EPANATPAY_0")]
        [StringLength(1)]
        public string Epanatpay0 { get; set; }
        [Required]
        [Column("EPARENPAY_0")]
        [StringLength(1)]
        public string Eparenpay0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}