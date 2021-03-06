// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PINVOICED", Schema = "TESTPROD")]
    [Index(nameof(Num0), nameof(Pidlin0), Name = "PINVOICED_PID0", IsUnique = true)]
    [Index(nameof(Typori0), nameof(Numori0), nameof(Linori0), nameof(Seqori0), nameof(Num0), nameof(Pidlin0), Name = "PINVOICED_PID1", IsUnique = true)]
    [Index(nameof(Itmref0), nameof(Num0), nameof(Pidlin0), Name = "PINVOICED_PID2", IsUnique = true)]
    [Index(nameof(Bpr0), nameof(Invtyp0), nameof(Itmref0), nameof(Num0), nameof(Pidlin0), Name = "PINVOICED_PID3", IsUnique = true)]
    [Index(nameof(Pohnum0), nameof(Poplin0), nameof(Poqseq0), Name = "PINVOICED_PID4")]
    public partial class Pinvoiced
    {
        [Column("INVTYP_0")]
        public byte Invtyp0 { get; set; }
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Column("PIDLIN_0")]
        public int Pidlin0 { get; set; }
        [Required]
        [Column("PIVTYP_0")]
        [StringLength(5)]
        public string Pivtyp0 { get; set; }
        [Column("PIHTYP_0")]
        public byte Pihtyp0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Column("ACCDAT_0", TypeName = "datetime")]
        public DateTime Accdat0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(15)]
        public string Bpr0 { get; set; }
        [Required]
        [Column("FCYLIN_0")]
        [StringLength(5)]
        public string Fcylin0 { get; set; }
        [Column("TYPORI_0")]
        public byte Typori0 { get; set; }
        [Required]
        [Column("NUMORI_0")]
        [StringLength(20)]
        public string Numori0 { get; set; }
        [Column("LINORI_0")]
        public int Linori0 { get; set; }
        [Column("SEQORI_0")]
        public int Seqori0 { get; set; }
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
        [Column("UOM_0")]
        [StringLength(3)]
        public string Uom0 { get; set; }
        [Required]
        [Column("PUU_0")]
        [StringLength(3)]
        public string Puu0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Column("UOMPUUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Uompuucoe0 { get; set; }
        [Column("QTYUOM_0", TypeName = "numeric(28, 13)")]
        public decimal Qtyuom0 { get; set; }
        [Column("QTYPUU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypuu0 { get; set; }
        [Column("ORIQTYPUU_0", TypeName = "numeric(28, 13)")]
        public decimal Oriqtypuu0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Column("QTYWEU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtyweu0 { get; set; }
        [Column("ORIQTYWEU_0", TypeName = "numeric(28, 13)")]
        public decimal Oriqtyweu0 { get; set; }
        [Column("QTYVOU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtyvou0 { get; set; }
        [Column("ORIQTYVOU_0", TypeName = "numeric(28, 13)")]
        public decimal Oriqtyvou0 { get; set; }
        [Column("GROPRI_0", TypeName = "numeric(19, 5)")]
        public decimal Gropri0 { get; set; }
        [Column("PRIREN_0")]
        public short Priren0 { get; set; }
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
        [Column("NETPRI_0", TypeName = "numeric(19, 5)")]
        public decimal Netpri0 { get; set; }
        [Column("ORINETPRI_0", TypeName = "numeric(19, 5)")]
        public decimal Orinetpri0 { get; set; }
        [Column("LINPURTYP_0")]
        public byte Linpurtyp0 { get; set; }
        [Column("DISCRGAMT1_0", TypeName = "numeric(27, 13)")]
        public decimal Discrgamt10 { get; set; }
        [Column("DISCRGAMT2_0", TypeName = "numeric(27, 13)")]
        public decimal Discrgamt20 { get; set; }
        [Column("DISCRGAMT3_0", TypeName = "numeric(27, 13)")]
        public decimal Discrgamt30 { get; set; }
        [Column("DISCRGAMT4_0", TypeName = "numeric(27, 13)")]
        public decimal Discrgamt40 { get; set; }
        [Column("DISCRGAMT5_0", TypeName = "numeric(27, 13)")]
        public decimal Discrgamt50 { get; set; }
        [Column("DISCRGAMT6_0", TypeName = "numeric(27, 13)")]
        public decimal Discrgamt60 { get; set; }
        [Column("DISCRGAMT7_0", TypeName = "numeric(27, 13)")]
        public decimal Discrgamt70 { get; set; }
        [Column("DISCRGAMT8_0", TypeName = "numeric(27, 13)")]
        public decimal Discrgamt80 { get; set; }
        [Column("DISCRGAMT9_0", TypeName = "numeric(27, 13)")]
        public decimal Discrgamt90 { get; set; }
        [Required]
        [Column("POHNUM_0")]
        [StringLength(20)]
        public string Pohnum0 { get; set; }
        [Column("POPLIN_0")]
        public int Poplin0 { get; set; }
        [Column("POQSEQ_0")]
        public int Poqseq0 { get; set; }
        [Required]
        [Column("PTHNUM_0")]
        [StringLength(20)]
        public string Pthnum0 { get; set; }
        [Column("PTDLIN_0")]
        public int Ptdlin0 { get; set; }
        [Required]
        [Column("PNHNUM_0")]
        [StringLength(20)]
        public string Pnhnum0 { get; set; }
        [Column("PNDLIN_0")]
        public int Pndlin0 { get; set; }
        [Required]
        [Column("INVNUM_0")]
        [StringLength(20)]
        public string Invnum0 { get; set; }
        [Column("INVLIN_0")]
        public int Invlin0 { get; set; }
        [Column("SIDLIN_0")]
        public int Sidlin0 { get; set; }
        [Required]
        [Column("BPSNUM_0")]
        [StringLength(15)]
        public string Bpsnum0 { get; set; }
        [Column("RCPDAT_0", TypeName = "datetime")]
        public DateTime Rcpdat0 { get; set; }
        [Required]
        [Column("PJT_0")]
        [StringLength(20)]
        public string Pjt0 { get; set; }
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
        [Column("SATISS_0")]
        [StringLength(1)]
        public string Satiss0 { get; set; }
        [Required]
        [Column("SATRCP_0")]
        [StringLength(1)]
        public string Satrcp0 { get; set; }
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
        [Required]
        [Column("TAXRCP_0")]
        [StringLength(1)]
        public string Taxrcp0 { get; set; }
        [Required]
        [Column("TAXISS_0")]
        [StringLength(1)]
        public string Taxiss0 { get; set; }
        [Required]
        [Column("TAXOTH1_0")]
        [StringLength(1)]
        public string Taxoth10 { get; set; }
        [Required]
        [Column("TAXOTH2_0")]
        [StringLength(1)]
        public string Taxoth20 { get; set; }
        [Column("AMTNOTLIN_0", TypeName = "numeric(27, 13)")]
        public decimal Amtnotlin0 { get; set; }
        [Column("AMTATILIN_0", TypeName = "numeric(27, 13)")]
        public decimal Amtatilin0 { get; set; }
        [Column("QTYBUDLIN_0", TypeName = "numeric(28, 13)")]
        public decimal Qtybudlin0 { get; set; }
        [Column("QTYGLU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtyglu0 { get; set; }
        [Required]
        [Column("GLU_0")]
        [StringLength(3)]
        public string Glu0 { get; set; }
        [Column("CLCAMT1_0", TypeName = "numeric(27, 13)")]
        public decimal Clcamt10 { get; set; }
        [Column("CLCAMT2_0", TypeName = "numeric(27, 13)")]
        public decimal Clcamt20 { get; set; }
        [Column("CLCAMT3_0", TypeName = "numeric(27, 13)")]
        public decimal Clcamt30 { get; set; }
        [Column("CLCAMT4_0", TypeName = "numeric(28, 8)")]
        public decimal Clcamt40 { get; set; }
        [Column("CLCAMT5_0", TypeName = "numeric(28, 8)")]
        public decimal Clcamt50 { get; set; }
        [Column("CLCAMT6_0", TypeName = "numeric(28, 8)")]
        public decimal Clcamt60 { get; set; }
        [Column("CLCAMT7_0", TypeName = "numeric(28, 8)")]
        public decimal Clcamt70 { get; set; }
        [Column("DISBASLIN1_0", TypeName = "numeric(28, 8)")]
        public decimal Disbaslin10 { get; set; }
        [Column("BASTAXLIN1_0", TypeName = "numeric(27, 13)")]
        public decimal Bastaxlin10 { get; set; }
        [Column("AMTTAXLIN1_0", TypeName = "numeric(27, 13)")]
        public decimal Amttaxlin10 { get; set; }
        [Column("AMTTAXLIN2_0", TypeName = "numeric(27, 13)")]
        public decimal Amttaxlin20 { get; set; }
        [Column("AMTTAXLIN3_0", TypeName = "numeric(27, 13)")]
        public decimal Amttaxlin30 { get; set; }
        [Column("AMTTAXRCP_0", TypeName = "numeric(28, 8)")]
        public decimal Amttaxrcp0 { get; set; }
        [Column("AMTTAXISS_0", TypeName = "numeric(28, 8)")]
        public decimal Amttaxiss0 { get; set; }
        [Column("AMTTAXOTH1_0", TypeName = "numeric(28, 8)")]
        public decimal Amttaxoth10 { get; set; }
        [Column("AMTTAXOTH2_0", TypeName = "numeric(28, 8)")]
        public decimal Amttaxoth20 { get; set; }
        [Column("DEDTAXLIN1_0", TypeName = "numeric(27, 13)")]
        public decimal Dedtaxlin10 { get; set; }
        [Column("DEDTAXLIN2_0", TypeName = "numeric(27, 13)")]
        public decimal Dedtaxlin20 { get; set; }
        [Column("DEDTAXLIN3_0", TypeName = "numeric(27, 13)")]
        public decimal Dedtaxlin30 { get; set; }
        [Column("DEDTAXRCP_0", TypeName = "numeric(28, 8)")]
        public decimal Dedtaxrcp0 { get; set; }
        [Column("DEDTAXISS_0", TypeName = "numeric(28, 8)")]
        public decimal Dedtaxiss0 { get; set; }
        [Column("DEDTAXOTH1_0", TypeName = "numeric(28, 8)")]
        public decimal Dedtaxoth10 { get; set; }
        [Column("DEDTAXOTH2_0", TypeName = "numeric(28, 8)")]
        public decimal Dedtaxoth20 { get; set; }
        [Column("CPR_0", TypeName = "numeric(27, 9)")]
        public decimal Cpr0 { get; set; }
        [Required]
        [Column("CPRCUR_0")]
        [StringLength(3)]
        public string Cprcur0 { get; set; }
        [Column("PRTFLG_0")]
        public byte Prtflg0 { get; set; }
        [Required]
        [Column("LINTEX_0")]
        [StringLength(12)]
        public string Lintex0 { get; set; }
        [Column("LINEECFLG_0")]
        public byte Lineecflg0 { get; set; }
        [Column("EECFLOPHY_0")]
        public byte Eecflophy0 { get; set; }
        [Column("STRDAT_0", TypeName = "datetime")]
        public DateTime Strdat0 { get; set; }
        [Column("ENDDAT_0", TypeName = "datetime")]
        public DateTime Enddat0 { get; set; }
        [Column("PERNBR_0")]
        public short Pernbr0 { get; set; }
        [Column("PERTYP_0")]
        public byte Pertyp0 { get; set; }
        [Required]
        [Column("FASREF_0")]
        [StringLength(30)]
        public string Fasref0 { get; set; }
        [Column("LINTYP_0")]
        public byte Lintyp0 { get; set; }
        [Column("LIKQTYCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Likqtycoe0 { get; set; }
        [Column("XCHRGTYP_0")]
        public short Xchrgtyp0 { get; set; }
        [Required]
        [Column("CMMNUM_0")]
        [StringLength(20)]
        public string Cmmnum0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("XBOLNUM_0")]
        [StringLength(1)]
        public string Xbolnum0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("XB_MANREC_0")]
        public short XbManrec0 { get; set; }
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
        [Column("TWMSTA_0")]
        public byte Twmsta0 { get; set; }
        [Column("FLG1099_0")]
        public byte Flg10990 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}