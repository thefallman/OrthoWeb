﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GDIAACCD", Schema = "TESTPROD")]
    [Index(nameof(Dia0), nameof(Linnum0), Name = "GDIAACCD_GDC0", IsUnique = true)]
    public partial class Gdiaaccd
    {
        [Required]
        [Column("DIA_0")]
        [StringLength(10)]
        public string Dia0 { get; set; }
        [Column("LINNUM_0")]
        public short Linnum0 { get; set; }
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
        [Required]
        [Column("DSP_0")]
        [StringLength(10)]
        public string Dsp0 { get; set; }
        [Required]
        [Column("VAT_0")]
        [StringLength(5)]
        public string Vat0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(15)]
        public string Bpr0 { get; set; }
        [Column("COE_0", TypeName = "numeric(17, 8)")]
        public decimal Coe0 { get; set; }
        [Required]
        [Column("LIGDES_0")]
        [StringLength(250)]
        public string Ligdes0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}