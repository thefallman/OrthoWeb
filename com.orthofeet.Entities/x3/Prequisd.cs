﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PREQUISD", Schema = "TESTPROD")]
    [Index(nameof(Pshnum0), nameof(Psdlin0), Name = "PREQUISD_PSD0", IsUnique = true)]
    [Index(nameof(Linordflg0), nameof(Itmref0), nameof(Extrcpdat0), nameof(Pshnum0), nameof(Psdlin0), Name = "PREQUISD_PSD1")]
    [Index(nameof(Linordflg0), nameof(Linbuy0), nameof(Extorddat0), Name = "PREQUISD_PSD2")]
    public partial class Prequisd
    {
        [Required]
        [Column("PSHNUM_0")]
        [StringLength(20)]
        public string Pshnum0 { get; set; }
        [Column("PSDLIN_0")]
        public int Psdlin0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("PSHFCY_0")]
        [StringLength(5)]
        public string Pshfcy0 { get; set; }
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
        [Column("BPSNUM_0")]
        [StringLength(15)]
        public string Bpsnum0 { get; set; }
        [Column("QTYPUU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypuu0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Column("ORDQTYPUU_0", TypeName = "numeric(28, 13)")]
        public decimal Ordqtypuu0 { get; set; }
        [Column("ORDQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Ordqtystu0 { get; set; }
        [Required]
        [Column("PUU_0")]
        [StringLength(3)]
        public string Puu0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Required]
        [Column("VACBPR_0")]
        [StringLength(20)]
        public string Vacbpr0 { get; set; }
        [Column("VACTYP_0")]
        public short Vactyp0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("CHGTYP_0")]
        public byte Chgtyp0 { get; set; }
        [Column("CHGCOE_0", TypeName = "numeric(21, 10)")]
        public decimal Chgcoe0 { get; set; }
        [Column("GROPRI_0", TypeName = "numeric(19, 5)")]
        public decimal Gropri0 { get; set; }
        [Column("NETPRI_0", TypeName = "numeric(19, 5)")]
        public decimal Netpri0 { get; set; }
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
        [Column("PRIREN_0")]
        public short Priren0 { get; set; }
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
        [Column("LINAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Linamt0 { get; set; }
        [Column("EXTORDDAT_0", TypeName = "datetime")]
        public DateTime Extorddat0 { get; set; }
        [Column("EXTRCPDAT_0", TypeName = "datetime")]
        public DateTime Extrcpdat0 { get; set; }
        [Required]
        [Column("LINBUY_0")]
        [StringLength(5)]
        public string Linbuy0 { get; set; }
        [Column("LINPURTYP_0")]
        public byte Linpurtyp0 { get; set; }
        [Required]
        [Column("PJT_0")]
        [StringLength(20)]
        public string Pjt0 { get; set; }
        [Required]
        [Column("PRHFCY_0")]
        [StringLength(5)]
        public string Prhfcy0 { get; set; }
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
        [Column("LINATIAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Linatiamt0 { get; set; }
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
        [Required]
        [Column("LINTEX_0")]
        [StringLength(12)]
        public string Lintex0 { get; set; }
        [Column("LINCLEFLG_0")]
        public byte Lincleflg0 { get; set; }
        [Column("LINORDFLG_0")]
        public byte Linordflg0 { get; set; }
        [Column("LINAPPFLG_0")]
        public byte Linappflg0 { get; set; }
        [Column("CMMPRPTAX_0")]
        public byte Cmmprptax0 { get; set; }
        [Required]
        [Column("CMMPRPNUM_0")]
        [StringLength(20)]
        public string Cmmprpnum0 { get; set; }
        [Column("CMMPRPFLG_0")]
        public short Cmmprpflg0 { get; set; }
        [Column("FBUFLG_0")]
        public byte Fbuflg0 { get; set; }
        [Column("ORI_0")]
        public byte Ori0 { get; set; }
        [Required]
        [Column("PQHNUM_0")]
        [StringLength(20)]
        public string Pqhnum0 { get; set; }
        [Column("PPDLIN_0")]
        public int Ppdlin0 { get; set; }
        [Required]
        [Column("WIPNUM_0")]
        [StringLength(20)]
        public string Wipnum0 { get; set; }
        [Column("NBAOF_0")]
        public int Nbaof0 { get; set; }
        [Required]
        [Column("PSDNUMMMS_0")]
        [StringLength(15)]
        public string Psdnummms0 { get; set; }
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