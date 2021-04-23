﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BPSINVLIG", Schema = "TESTPROD")]
    [Index(nameof(Num0), nameof(Lig0), Name = "BPSINVLIG_PIL0", IsUnique = true)]
    public partial class Bpsinvlig
    {
        [Column("INVTYP_0")]
        public byte Invtyp0 { get; set; }
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Column("LIG_0")]
        public short Lig0 { get; set; }
        [Required]
        [Column("FCYLIN_0")]
        [StringLength(5)]
        public string Fcylin0 { get; set; }
        [Required]
        [Column("SAC_0")]
        [StringLength(4)]
        public string Sac0 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Required]
        [Column("COA_1")]
        [StringLength(3)]
        public string Coa1 { get; set; }
        [Required]
        [Column("COA_2")]
        [StringLength(3)]
        public string Coa2 { get; set; }
        [Required]
        [Column("COA_3")]
        [StringLength(3)]
        public string Coa3 { get; set; }
        [Required]
        [Column("COA_4")]
        [StringLength(3)]
        public string Coa4 { get; set; }
        [Required]
        [Column("COA_5")]
        [StringLength(3)]
        public string Coa5 { get; set; }
        [Required]
        [Column("COA_6")]
        [StringLength(3)]
        public string Coa6 { get; set; }
        [Required]
        [Column("COA_7")]
        [StringLength(3)]
        public string Coa7 { get; set; }
        [Required]
        [Column("COA_8")]
        [StringLength(3)]
        public string Coa8 { get; set; }
        [Required]
        [Column("COA_9")]
        [StringLength(3)]
        public string Coa9 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("ACC_1")]
        [StringLength(15)]
        public string Acc1 { get; set; }
        [Required]
        [Column("ACC_2")]
        [StringLength(15)]
        public string Acc2 { get; set; }
        [Required]
        [Column("ACC_3")]
        [StringLength(15)]
        public string Acc3 { get; set; }
        [Required]
        [Column("ACC_4")]
        [StringLength(15)]
        public string Acc4 { get; set; }
        [Required]
        [Column("ACC_5")]
        [StringLength(15)]
        public string Acc5 { get; set; }
        [Required]
        [Column("ACC_6")]
        [StringLength(15)]
        public string Acc6 { get; set; }
        [Required]
        [Column("ACC_7")]
        [StringLength(15)]
        public string Acc7 { get; set; }
        [Required]
        [Column("ACC_8")]
        [StringLength(15)]
        public string Acc8 { get; set; }
        [Required]
        [Column("ACC_9")]
        [StringLength(15)]
        public string Acc9 { get; set; }
        [Required]
        [Column("LED_0")]
        [StringLength(3)]
        public string Led0 { get; set; }
        [Required]
        [Column("LED_1")]
        [StringLength(3)]
        public string Led1 { get; set; }
        [Required]
        [Column("LED_2")]
        [StringLength(3)]
        public string Led2 { get; set; }
        [Required]
        [Column("LED_3")]
        [StringLength(3)]
        public string Led3 { get; set; }
        [Required]
        [Column("LED_4")]
        [StringLength(3)]
        public string Led4 { get; set; }
        [Required]
        [Column("LED_5")]
        [StringLength(3)]
        public string Led5 { get; set; }
        [Required]
        [Column("LED_6")]
        [StringLength(3)]
        public string Led6 { get; set; }
        [Required]
        [Column("LED_7")]
        [StringLength(3)]
        public string Led7 { get; set; }
        [Required]
        [Column("LED_8")]
        [StringLength(3)]
        public string Led8 { get; set; }
        [Required]
        [Column("LED_9")]
        [StringLength(3)]
        public string Led9 { get; set; }
        [Required]
        [Column("BPRLIN_0")]
        [StringLength(15)]
        public string Bprlin0 { get; set; }
        [Column("PURTYP_0")]
        public byte Purtyp0 { get; set; }
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
        [Column("TAXRCP_0")]
        [StringLength(1)]
        public string Taxrcp0 { get; set; }
        [Column("AMTTAXRCP_0", TypeName = "numeric(28, 8)")]
        public decimal Amttaxrcp0 { get; set; }
        [Column("DEDTAXRCP_0", TypeName = "numeric(28, 8)")]
        public decimal Dedtaxrcp0 { get; set; }
        [Required]
        [Column("TAXISS_0")]
        [StringLength(1)]
        public string Taxiss0 { get; set; }
        [Column("AMTTAXISS_0", TypeName = "numeric(28, 8)")]
        public decimal Amttaxiss0 { get; set; }
        [Column("DEDTAXISS_0", TypeName = "numeric(28, 8)")]
        public decimal Dedtaxiss0 { get; set; }
        [Required]
        [Column("TAXOTH1_0")]
        [StringLength(1)]
        public string Taxoth10 { get; set; }
        [Column("AMTTAXOTH1_0", TypeName = "numeric(28, 8)")]
        public decimal Amttaxoth10 { get; set; }
        [Column("DEDTAXOTH1_0", TypeName = "numeric(28, 8)")]
        public decimal Dedtaxoth10 { get; set; }
        [Required]
        [Column("TAXOTH2_0")]
        [StringLength(1)]
        public string Taxoth20 { get; set; }
        [Column("AMTTAXOTH2_0", TypeName = "numeric(28, 8)")]
        public decimal Amttaxoth20 { get; set; }
        [Column("DEDTAXOTH2_0", TypeName = "numeric(28, 8)")]
        public decimal Dedtaxoth20 { get; set; }
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
        [Column("RITCODSRC_0")]
        [StringLength(1)]
        public string Ritcodsrc0 { get; set; }
        [Column("FLG1099_0")]
        public short Flg10990 { get; set; }
        [Column("XB_DISAMT_0", TypeName = "numeric(27, 13)")]
        public decimal XbDisamt0 { get; set; }
        [Column("XB_MANREC_0")]
        public short XbManrec0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}