﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("HDKTASK", Schema = "TESTPROD")]
    [Index(nameof(Hdtnum0), Name = "HDKTASK_HDT0", IsUnique = true)]
    [Index(nameof(Srenum0), nameof(Tpl0), Name = "HDKTASK_HDT1")]
    [Index(nameof(Itnnum0), nameof(Tpl0), Name = "HDKTASK_HDT2")]
    public partial class Hdktask
    {
        [Required]
        [Column("HDTNUM_0")]
        [StringLength(20)]
        public string Hdtnum0 { get; set; }
        [Required]
        [Column("SRENUM_0")]
        [StringLength(20)]
        public string Srenum0 { get; set; }
        [Required]
        [Column("ITNNUM_0")]
        [StringLength(20)]
        public string Itnnum0 { get; set; }
        [Column("TPL_0")]
        public byte Tpl0 { get; set; }
        [Required]
        [Column("HDTMACSRE_0")]
        [StringLength(20)]
        public string Hdtmacsre0 { get; set; }
        [Required]
        [Column("HDTMACSET_0")]
        [StringLength(20)]
        public string Hdtmacset0 { get; set; }
        [Required]
        [Column("HDTCPN_0")]
        [StringLength(20)]
        public string Hdtcpn0 { get; set; }
        [Column("HDTTYP_0")]
        public byte Hdttyp0 { get; set; }
        [Required]
        [Column("HDTITM_0")]
        [StringLength(20)]
        public string Hdtitm0 { get; set; }
        [Column("HDTQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Hdtqty0 { get; set; }
        [Required]
        [Column("HDTUOM_0")]
        [StringLength(3)]
        public string Hdtuom0 { get; set; }
        [Required]
        [Column("HDTSTOFCY_0")]
        [StringLength(5)]
        public string Hdtstofcy0 { get; set; }
        [Column("HDTAVA_0", TypeName = "numeric(28, 13)")]
        public decimal Hdtava0 { get; set; }
        [Required]
        [Column("HDTAVAUOM_0")]
        [StringLength(3)]
        public string Hdtavauom0 { get; set; }
        [Column("HDTAUSTYP_0")]
        public byte Hdtaustyp0 { get; set; }
        [Required]
        [Column("HDTAUS_0")]
        [StringLength(15)]
        public string Hdtaus0 { get; set; }
        [Column("HDTPLNDAT_0", TypeName = "datetime")]
        public DateTime Hdtplndat0 { get; set; }
        [Column("HDTDONDAT_0", TypeName = "datetime")]
        public DateTime Hdtdondat0 { get; set; }
        [Column("HDTDONHOU_0")]
        public int Hdtdonhou0 { get; set; }
        [Column("SPGTIMHOU_0")]
        public int Spgtimhou0 { get; set; }
        [Column("SPGTIMMNT_0")]
        public short Spgtimmnt0 { get; set; }
        [Column("HDTTYPRUU_0")]
        public byte Hdttypruu0 { get; set; }
        [Column("HDTSTOISS_0")]
        public byte Hdtstoiss0 { get; set; }
        [Column("HDTISSQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Hdtissqty0 { get; set; }
        [Column("HDTISSISS_0", TypeName = "numeric(28, 13)")]
        public decimal Hdtississ0 { get; set; }
        [Column("HDTINV_0")]
        public byte Hdtinv0 { get; set; }
        [Required]
        [Column("HDTTEX_0")]
        [StringLength(250)]
        public string Hdttex0 { get; set; }
        [Required]
        [Column("HDTSALTEX_0")]
        [StringLength(12)]
        public string Hdtsaltex0 { get; set; }
        [Column("HDTAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Hdtamt0 { get; set; }
        [Column("HDTAMTINV_0", TypeName = "numeric(27, 13)")]
        public decimal Hdtamtinv0 { get; set; }
        [Required]
        [Column("HDTCUR_0")]
        [StringLength(3)]
        public string Hdtcur0 { get; set; }
        [Column("INVPITFLG_0")]
        public short Invpitflg0 { get; set; }
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
        [Column("PRIREN_0")]
        public short Priren0 { get; set; }
        [Column("MANAMTFLG_0")]
        public byte Manamtflg0 { get; set; }
        [Column("SAUSTUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Saustucoe0 { get; set; }
        [Column("HDTSTUQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Hdtstuqty0 { get; set; }
        [Column("HDTINVMOD_0")]
        public byte Hdtinvmod0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}