﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XBMISCINV", Schema = "TESTPROD")]
    [Index(nameof(Usr0), nameof(Editnum0), nameof(Num0), nameof(Lig0), Name = "XBMISCINV_XBI0", IsUnique = true)]
    [Index(nameof(Credat0), Name = "XBMISCINV_XBI1")]
    [Index(nameof(Usr0), nameof(Editnum0), nameof(Bpsnum0), nameof(Num0), nameof(Lig0), Name = "XBMISCINV_XBI2", IsUnique = true)]
    public partial class Xbmiscinv
    {
        [Column("INVTYP_0")]
        public byte Invtyp0 { get; set; }
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Column("LIG_0")]
        public int Lig0 { get; set; }
        [Required]
        [Column("FCYLIN_0")]
        [StringLength(5)]
        public string Fcylin0 { get; set; }
        [Required]
        [Column("SAC_0")]
        [StringLength(4)]
        public string Sac0 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("BPRLIN_0")]
        [StringLength(15)]
        public string Bprlin0 { get; set; }
        [Column("PURTYP_0")]
        public byte Purtyp0 { get; set; }
        [Required]
        [Column("CNA_0")]
        [StringLength(10)]
        public string Cna0 { get; set; }
        [Required]
        [Column("DSP_0")]
        [StringLength(10)]
        public string Dsp0 { get; set; }
        [Column("AMTNOTLIN_0", TypeName = "numeric(27, 13)")]
        public decimal Amtnotlin0 { get; set; }
        [Column("AMTATILIN_0", TypeName = "numeric(27, 13)")]
        public decimal Amtatilin0 { get; set; }
        [Column("QTY_0", TypeName = "numeric(28, 13)")]
        public decimal Qty0 { get; set; }
        [Required]
        [Column("UOM_0")]
        [StringLength(3)]
        public string Uom0 { get; set; }
        [Required]
        [Column("TAX1_0")]
        [StringLength(5)]
        public string Tax10 { get; set; }
        [Required]
        [Column("TAX2_0")]
        [StringLength(5)]
        public string Tax20 { get; set; }
        [Required]
        [Column("VAT_0")]
        [StringLength(5)]
        public string Vat0 { get; set; }
        [Column("AMTTAX1_0", TypeName = "numeric(27, 13)")]
        public decimal Amttax10 { get; set; }
        [Column("DEDTAX1_0", TypeName = "numeric(27, 13)")]
        public decimal Dedtax10 { get; set; }
        [Column("AMTTAX2_0", TypeName = "numeric(27, 13)")]
        public decimal Amttax20 { get; set; }
        [Column("DEDTAX2_0", TypeName = "numeric(27, 13)")]
        public decimal Dedtax20 { get; set; }
        [Column("AMTVAT_0", TypeName = "numeric(27, 13)")]
        public decimal Amtvat0 { get; set; }
        [Column("DEDVAT_0", TypeName = "numeric(27, 13)")]
        public decimal Dedvat0 { get; set; }
        [Required]
        [Column("STT1_0")]
        [StringLength(3)]
        public string Stt10 { get; set; }
        [Required]
        [Column("STT2_0")]
        [StringLength(3)]
        public string Stt20 { get; set; }
        [Required]
        [Column("STT3_0")]
        [StringLength(3)]
        public string Stt30 { get; set; }
        [Column("STRDAT_0", TypeName = "datetime")]
        public DateTime Strdat0 { get; set; }
        [Column("ENDDAT_0", TypeName = "datetime")]
        public DateTime Enddat0 { get; set; }
        [Column("PERNBR_0")]
        public short Pernbr0 { get; set; }
        [Column("PERTYP_0")]
        public byte Pertyp0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Required]
        [Column("FASREF_0")]
        [StringLength(30)]
        public string Fasref0 { get; set; }
        [Column("TXNDAT_0", TypeName = "datetime")]
        public DateTime Txndat0 { get; set; }
        [Column("LINTOT_0", TypeName = "numeric(26, 6)")]
        public decimal Lintot0 { get; set; }
        [Required]
        [Column("USR_0")]
        [StringLength(5)]
        public string Usr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("EDITNUM_0")]
        public int Editnum0 { get; set; }
        [Required]
        [Column("BPSNUM_0")]
        [StringLength(15)]
        public string Bpsnum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}