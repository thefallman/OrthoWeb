﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GACCENTRYA", Schema = "TESTPROD")]
    [Index(nameof(Typ0), nameof(Num0), nameof(Lin0), nameof(Ledtyp0), nameof(Analin0), Name = "GACCENTRYA_DAA0", IsUnique = true)]
    [Index(nameof(Cpy0), nameof(Fcylin0), nameof(Coa0), nameof(Acc0), nameof(Bpr0), nameof(Accdat0), nameof(Accnum0), nameof(Analin0), Name = "GACCENTRYA_DAA1", IsUnique = true)]
    [Index(nameof(Typ0), nameof(Num0), nameof(Lin0), nameof(Analin0), nameof(Ledtyp0), Name = "GACCENTRYA_DAA2", IsUnique = true)]
    public partial class Gaccentrya
    {
        [Required]
        [Column("TYP_0")]
        [StringLength(5)]
        public string Typ0 { get; set; }
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Column("LIN_0")]
        public short Lin0 { get; set; }
        [Column("LEDTYP_0")]
        public byte Ledtyp0 { get; set; }
        [Column("ANALIN_0")]
        public short Analin0 { get; set; }
        [Required]
        [Column("IDTLIN_0")]
        [StringLength(5)]
        public string Idtlin0 { get; set; }
        [Required]
        [Column("LED_0")]
        [StringLength(3)]
        public string Led0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCYLIN_0")]
        [StringLength(5)]
        public string Fcylin0 { get; set; }
        [Column("ACCDAT_0", TypeName = "datetime")]
        public DateTime Accdat0 { get; set; }
        [Column("ACCNUM_0")]
        public int Accnum0 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(15)]
        public string Bpr0 { get; set; }
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
        [Column("SNS_0")]
        public short Sns0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("AMTCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Amtcur0 { get; set; }
        [Required]
        [Column("CURLED_0")]
        [StringLength(3)]
        public string Curled0 { get; set; }
        [Column("AMTLED_0", TypeName = "numeric(27, 13)")]
        public decimal Amtled0 { get; set; }
        [Required]
        [Column("UOM_0")]
        [StringLength(3)]
        public string Uom0 { get; set; }
        [Column("QTY_0", TypeName = "numeric(28, 13)")]
        public decimal Qty0 { get; set; }
        [Column("ACCNUMDOE_0")]
        public int Accnumdoe0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}