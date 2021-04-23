﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BLAQTY", Schema = "TESTPROD")]
    [Index(nameof(Ledtyp0), nameof(Cpy0), nameof(Fcy0), nameof(Fiy0), nameof(Acc0), nameof(Bpr0), nameof(Cce10), nameof(Cce20), nameof(Cce30), nameof(Cce40), nameof(Cce50), nameof(Cce60), nameof(Cce70), nameof(Cce80), nameof(Cce90), nameof(Cur0), Name = "BLAQTY_BLQ0", IsUnique = true)]
    [Index(nameof(Accnum0), Name = "BLAQTY_BLQ1", IsUnique = true)]
    [Index(nameof(Ledtyp0), nameof(Cur0), nameof(Fcy0), nameof(Fiy0), nameof(Acc0), nameof(Cce10), nameof(Cce20), nameof(Cce30), nameof(Cce40), nameof(Cce50), nameof(Cce60), nameof(Cce70), nameof(Cce80), nameof(Cce90), nameof(Bpr0), nameof(Cpy0), Name = "BLAQTY_BLQ3", IsUnique = true)]
    public partial class Blaqty
    {
        [Column("LEDTYP_0")]
        public byte Ledtyp0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Column("FIY_0")]
        public short Fiy0 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(15)]
        public string Bpr0 { get; set; }
        [Required]
        [Column("CCE1_0")]
        [StringLength(15)]
        public string Cce10 { get; set; }
        [Required]
        [Column("CCE2_0")]
        [StringLength(15)]
        public string Cce20 { get; set; }
        [Required]
        [Column("CCE3_0")]
        [StringLength(15)]
        public string Cce30 { get; set; }
        [Required]
        [Column("CCE4_0")]
        [StringLength(15)]
        public string Cce40 { get; set; }
        [Required]
        [Column("CCE5_0")]
        [StringLength(15)]
        public string Cce50 { get; set; }
        [Required]
        [Column("CCE6_0")]
        [StringLength(15)]
        public string Cce60 { get; set; }
        [Required]
        [Column("CCE7_0")]
        [StringLength(15)]
        public string Cce70 { get; set; }
        [Required]
        [Column("CCE8_0")]
        [StringLength(15)]
        public string Cce80 { get; set; }
        [Required]
        [Column("CCE9_0")]
        [StringLength(15)]
        public string Cce90 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("ACCNUM_0")]
        public int Accnum0 { get; set; }
        [Required]
        [Column("LED_0")]
        [StringLength(3)]
        public string Led0 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
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
        [Column("UOM_0")]
        [StringLength(3)]
        public string Uom0 { get; set; }
        [Column("QTY_0", TypeName = "numeric(28, 13)")]
        public decimal Qty0 { get; set; }
        [Column("QTY_1", TypeName = "numeric(28, 13)")]
        public decimal Qty1 { get; set; }
        [Column("QTY_2", TypeName = "numeric(28, 13)")]
        public decimal Qty2 { get; set; }
        [Column("QTY_3", TypeName = "numeric(28, 13)")]
        public decimal Qty3 { get; set; }
        [Column("QTY_4", TypeName = "numeric(28, 13)")]
        public decimal Qty4 { get; set; }
        [Column("QTY_5", TypeName = "numeric(28, 13)")]
        public decimal Qty5 { get; set; }
        [Column("QTY_6", TypeName = "numeric(28, 13)")]
        public decimal Qty6 { get; set; }
        [Column("QTY_7", TypeName = "numeric(28, 13)")]
        public decimal Qty7 { get; set; }
        [Column("QTY_8", TypeName = "numeric(28, 13)")]
        public decimal Qty8 { get; set; }
        [Column("QTY_9", TypeName = "numeric(28, 13)")]
        public decimal Qty9 { get; set; }
        [Column("QTY_10", TypeName = "numeric(28, 13)")]
        public decimal Qty10 { get; set; }
        [Column("QTY_11", TypeName = "numeric(28, 13)")]
        public decimal Qty11 { get; set; }
        [Column("QTY_12", TypeName = "numeric(28, 13)")]
        public decimal Qty12 { get; set; }
        [Column("QTY_13", TypeName = "numeric(28, 13)")]
        public decimal Qty13 { get; set; }
        [Column("QTY_14", TypeName = "numeric(28, 13)")]
        public decimal Qty14 { get; set; }
        [Column("QTY_15", TypeName = "numeric(28, 13)")]
        public decimal Qty15 { get; set; }
        [Column("QTY_16", TypeName = "numeric(28, 13)")]
        public decimal Qty16 { get; set; }
        [Column("QTY_17", TypeName = "numeric(28, 13)")]
        public decimal Qty17 { get; set; }
        [Column("QTY_18", TypeName = "numeric(28, 13)")]
        public decimal Qty18 { get; set; }
        [Column("QTY_19", TypeName = "numeric(28, 13)")]
        public decimal Qty19 { get; set; }
        [Column("QTY_20", TypeName = "numeric(28, 13)")]
        public decimal Qty20 { get; set; }
        [Column("QTY_21", TypeName = "numeric(28, 13)")]
        public decimal Qty21 { get; set; }
        [Column("QTY_22", TypeName = "numeric(28, 13)")]
        public decimal Qty22 { get; set; }
        [Column("QTY_23", TypeName = "numeric(28, 13)")]
        public decimal Qty23 { get; set; }
        [Column("QTY_24", TypeName = "numeric(28, 13)")]
        public decimal Qty24 { get; set; }
        [Column("QTY_25", TypeName = "numeric(28, 13)")]
        public decimal Qty25 { get; set; }
        [Column("QTY_26", TypeName = "numeric(28, 13)")]
        public decimal Qty26 { get; set; }
        [Column("QTY_27", TypeName = "numeric(28, 13)")]
        public decimal Qty27 { get; set; }
        [Column("QTYCMM_0", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm0 { get; set; }
        [Column("QTYCMM_1", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm1 { get; set; }
        [Column("QTYCMM_2", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm2 { get; set; }
        [Column("QTYCMM_3", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm3 { get; set; }
        [Column("QTYCMM_4", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm4 { get; set; }
        [Column("QTYCMM_5", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm5 { get; set; }
        [Column("QTYCMM_6", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm6 { get; set; }
        [Column("QTYCMM_7", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm7 { get; set; }
        [Column("QTYCMM_8", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm8 { get; set; }
        [Column("QTYCMM_9", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm9 { get; set; }
        [Column("QTYCMM_10", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm10 { get; set; }
        [Column("QTYCMM_11", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm11 { get; set; }
        [Column("QTYCMM_12", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm12 { get; set; }
        [Column("QTYCMM_13", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm13 { get; set; }
        [Column("QTYCMM_14", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm14 { get; set; }
        [Column("QTYCMM_15", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm15 { get; set; }
        [Column("QTYCMM_16", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm16 { get; set; }
        [Column("QTYCMM_17", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm17 { get; set; }
        [Column("QTYCMM_18", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm18 { get; set; }
        [Column("QTYCMM_19", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm19 { get; set; }
        [Column("QTYCMM_20", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm20 { get; set; }
        [Column("QTYCMM_21", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm21 { get; set; }
        [Column("QTYCMM_22", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm22 { get; set; }
        [Column("QTYCMM_23", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm23 { get; set; }
        [Column("QTYCMM_24", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm24 { get; set; }
        [Column("QTYCMM_25", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm25 { get; set; }
        [Column("QTYCMM_26", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm26 { get; set; }
        [Column("QTYCMM_27", TypeName = "numeric(28, 13)")]
        public decimal Qtycmm27 { get; set; }
        [Column("QTYPRP_0", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp0 { get; set; }
        [Column("QTYPRP_1", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp1 { get; set; }
        [Column("QTYPRP_2", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp2 { get; set; }
        [Column("QTYPRP_3", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp3 { get; set; }
        [Column("QTYPRP_4", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp4 { get; set; }
        [Column("QTYPRP_5", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp5 { get; set; }
        [Column("QTYPRP_6", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp6 { get; set; }
        [Column("QTYPRP_7", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp7 { get; set; }
        [Column("QTYPRP_8", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp8 { get; set; }
        [Column("QTYPRP_9", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp9 { get; set; }
        [Column("QTYPRP_10", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp10 { get; set; }
        [Column("QTYPRP_11", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp11 { get; set; }
        [Column("QTYPRP_12", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp12 { get; set; }
        [Column("QTYPRP_13", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp13 { get; set; }
        [Column("QTYPRP_14", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp14 { get; set; }
        [Column("QTYPRP_15", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp15 { get; set; }
        [Column("QTYPRP_16", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp16 { get; set; }
        [Column("QTYPRP_17", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp17 { get; set; }
        [Column("QTYPRP_18", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp18 { get; set; }
        [Column("QTYPRP_19", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp19 { get; set; }
        [Column("QTYPRP_20", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp20 { get; set; }
        [Column("QTYPRP_21", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp21 { get; set; }
        [Column("QTYPRP_22", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp22 { get; set; }
        [Column("QTYPRP_23", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp23 { get; set; }
        [Column("QTYPRP_24", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp24 { get; set; }
        [Column("QTYPRP_25", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp25 { get; set; }
        [Column("QTYPRP_26", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp26 { get; set; }
        [Column("QTYPRP_27", TypeName = "numeric(28, 13)")]
        public decimal Qtyprp27 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}