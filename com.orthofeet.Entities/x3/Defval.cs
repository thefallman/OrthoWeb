﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("DEFVAL", Schema = "TESTPROD")]
    [Index(nameof(Obc0), nameof(Param0), Name = "DEFVAL_DVA0", IsUnique = true)]
    public partial class Defval
    {
        [Required]
        [Column("OBC_0")]
        [StringLength(3)]
        public string Obc0 { get; set; }
        [Required]
        [Column("PARAM_0")]
        [StringLength(100)]
        public string Param0 { get; set; }
        [Required]
        [Column("ALHX_0")]
        [StringLength(100)]
        public string Alhx0 { get; set; }
        [Required]
        [Column("ALHX_1")]
        [StringLength(100)]
        public string Alhx1 { get; set; }
        [Required]
        [Column("ALHX_2")]
        [StringLength(100)]
        public string Alhx2 { get; set; }
        [Required]
        [Column("ALHX_3")]
        [StringLength(100)]
        public string Alhx3 { get; set; }
        [Required]
        [Column("ALHX_4")]
        [StringLength(100)]
        public string Alhx4 { get; set; }
        [Required]
        [Column("ALHX_5")]
        [StringLength(100)]
        public string Alhx5 { get; set; }
        [Required]
        [Column("ALHX_6")]
        [StringLength(100)]
        public string Alhx6 { get; set; }
        [Required]
        [Column("ALHX_7")]
        [StringLength(100)]
        public string Alhx7 { get; set; }
        [Required]
        [Column("ALHX_8")]
        [StringLength(100)]
        public string Alhx8 { get; set; }
        [Required]
        [Column("ALHX_9")]
        [StringLength(100)]
        public string Alhx9 { get; set; }
        [Required]
        [Column("ALHX_10")]
        [StringLength(100)]
        public string Alhx10 { get; set; }
        [Required]
        [Column("ALHX_11")]
        [StringLength(100)]
        public string Alhx11 { get; set; }
        [Required]
        [Column("ALHX_12")]
        [StringLength(100)]
        public string Alhx12 { get; set; }
        [Required]
        [Column("ALHX_13")]
        [StringLength(100)]
        public string Alhx13 { get; set; }
        [Required]
        [Column("ALHX_14")]
        [StringLength(100)]
        public string Alhx14 { get; set; }
        [Required]
        [Column("ALHX_15")]
        [StringLength(100)]
        public string Alhx15 { get; set; }
        [Required]
        [Column("ALHX_16")]
        [StringLength(100)]
        public string Alhx16 { get; set; }
        [Required]
        [Column("ALHX_17")]
        [StringLength(100)]
        public string Alhx17 { get; set; }
        [Required]
        [Column("ALHX_18")]
        [StringLength(100)]
        public string Alhx18 { get; set; }
        [Required]
        [Column("ALHX_19")]
        [StringLength(100)]
        public string Alhx19 { get; set; }
        [Column("DATX_0", TypeName = "datetime")]
        public DateTime Datx0 { get; set; }
        [Column("DATX_1", TypeName = "datetime")]
        public DateTime Datx1 { get; set; }
        [Column("DATX_2", TypeName = "datetime")]
        public DateTime Datx2 { get; set; }
        [Column("DATX_3", TypeName = "datetime")]
        public DateTime Datx3 { get; set; }
        [Column("DATX_4", TypeName = "datetime")]
        public DateTime Datx4 { get; set; }
        [Column("DATX_5", TypeName = "datetime")]
        public DateTime Datx5 { get; set; }
        [Column("DATX_6", TypeName = "datetime")]
        public DateTime Datx6 { get; set; }
        [Column("DATX_7", TypeName = "datetime")]
        public DateTime Datx7 { get; set; }
        [Column("DATX_8", TypeName = "datetime")]
        public DateTime Datx8 { get; set; }
        [Column("DATX_9", TypeName = "datetime")]
        public DateTime Datx9 { get; set; }
        [Column("DATX_10", TypeName = "datetime")]
        public DateTime Datx10 { get; set; }
        [Column("DATX_11", TypeName = "datetime")]
        public DateTime Datx11 { get; set; }
        [Column("DATX_12", TypeName = "datetime")]
        public DateTime Datx12 { get; set; }
        [Column("DATX_13", TypeName = "datetime")]
        public DateTime Datx13 { get; set; }
        [Column("DATX_14", TypeName = "datetime")]
        public DateTime Datx14 { get; set; }
        [Column("DATX_15", TypeName = "datetime")]
        public DateTime Datx15 { get; set; }
        [Column("DATX_16", TypeName = "datetime")]
        public DateTime Datx16 { get; set; }
        [Column("DATX_17", TypeName = "datetime")]
        public DateTime Datx17 { get; set; }
        [Column("DATX_18", TypeName = "datetime")]
        public DateTime Datx18 { get; set; }
        [Column("DATX_19", TypeName = "datetime")]
        public DateTime Datx19 { get; set; }
        [Column("INTX_0")]
        public int Intx0 { get; set; }
        [Column("INTX_1")]
        public int Intx1 { get; set; }
        [Column("INTX_2")]
        public int Intx2 { get; set; }
        [Column("INTX_3")]
        public int Intx3 { get; set; }
        [Column("INTX_4")]
        public int Intx4 { get; set; }
        [Column("INTX_5")]
        public int Intx5 { get; set; }
        [Column("INTX_6")]
        public int Intx6 { get; set; }
        [Column("INTX_7")]
        public int Intx7 { get; set; }
        [Column("INTX_8")]
        public int Intx8 { get; set; }
        [Column("INTX_9")]
        public int Intx9 { get; set; }
        [Column("INTX_10")]
        public int Intx10 { get; set; }
        [Column("INTX_11")]
        public int Intx11 { get; set; }
        [Column("INTX_12")]
        public int Intx12 { get; set; }
        [Column("INTX_13")]
        public int Intx13 { get; set; }
        [Column("INTX_14")]
        public int Intx14 { get; set; }
        [Column("INTX_15")]
        public int Intx15 { get; set; }
        [Column("INTX_16")]
        public int Intx16 { get; set; }
        [Column("INTX_17")]
        public int Intx17 { get; set; }
        [Column("INTX_18")]
        public int Intx18 { get; set; }
        [Column("INTX_19")]
        public int Intx19 { get; set; }
        [Column("INTX_20")]
        public int Intx20 { get; set; }
        [Column("INTX_21")]
        public int Intx21 { get; set; }
        [Column("INTX_22")]
        public int Intx22 { get; set; }
        [Column("INTX_23")]
        public int Intx23 { get; set; }
        [Column("INTX_24")]
        public int Intx24 { get; set; }
        [Column("INTX_25")]
        public int Intx25 { get; set; }
        [Column("INTX_26")]
        public int Intx26 { get; set; }
        [Column("INTX_27")]
        public int Intx27 { get; set; }
        [Column("INTX_28")]
        public int Intx28 { get; set; }
        [Column("INTX_29")]
        public int Intx29 { get; set; }
        [Column("INTX_30")]
        public int Intx30 { get; set; }
        [Column("INTX_31")]
        public int Intx31 { get; set; }
        [Column("INTX_32")]
        public int Intx32 { get; set; }
        [Column("INTX_33")]
        public int Intx33 { get; set; }
        [Column("INTX_34")]
        public int Intx34 { get; set; }
        [Column("INTX_35")]
        public int Intx35 { get; set; }
        [Column("INTX_36")]
        public int Intx36 { get; set; }
        [Column("INTX_37")]
        public int Intx37 { get; set; }
        [Column("INTX_38")]
        public int Intx38 { get; set; }
        [Column("INTX_39")]
        public int Intx39 { get; set; }
        [Column("INTX_40")]
        public int Intx40 { get; set; }
        [Column("INTX_41")]
        public int Intx41 { get; set; }
        [Column("INTX_42")]
        public int Intx42 { get; set; }
        [Column("INTX_43")]
        public int Intx43 { get; set; }
        [Column("INTX_44")]
        public int Intx44 { get; set; }
        [Column("INTX_45")]
        public int Intx45 { get; set; }
        [Column("INTX_46")]
        public int Intx46 { get; set; }
        [Column("INTX_47")]
        public int Intx47 { get; set; }
        [Column("INTX_48")]
        public int Intx48 { get; set; }
        [Column("INTX_49")]
        public int Intx49 { get; set; }
        [Column("DCBX_0", TypeName = "numeric(14, 3)")]
        public decimal Dcbx0 { get; set; }
        [Column("DCBX_1", TypeName = "numeric(14, 3)")]
        public decimal Dcbx1 { get; set; }
        [Column("DCBX_2", TypeName = "numeric(14, 3)")]
        public decimal Dcbx2 { get; set; }
        [Column("DCBX_3", TypeName = "numeric(14, 3)")]
        public decimal Dcbx3 { get; set; }
        [Column("DCBX_4", TypeName = "numeric(14, 3)")]
        public decimal Dcbx4 { get; set; }
        [Column("DCBX_5", TypeName = "numeric(14, 3)")]
        public decimal Dcbx5 { get; set; }
        [Column("DCBX_6", TypeName = "numeric(14, 3)")]
        public decimal Dcbx6 { get; set; }
        [Column("DCBX_7", TypeName = "numeric(14, 3)")]
        public decimal Dcbx7 { get; set; }
        [Column("DCBX_8", TypeName = "numeric(14, 3)")]
        public decimal Dcbx8 { get; set; }
        [Column("DCBX_9", TypeName = "numeric(14, 3)")]
        public decimal Dcbx9 { get; set; }
        [Column("DCBX_10", TypeName = "numeric(14, 3)")]
        public decimal Dcbx10 { get; set; }
        [Column("DCBX_11", TypeName = "numeric(14, 3)")]
        public decimal Dcbx11 { get; set; }
        [Column("DCBX_12", TypeName = "numeric(14, 3)")]
        public decimal Dcbx12 { get; set; }
        [Column("DCBX_13", TypeName = "numeric(14, 3)")]
        public decimal Dcbx13 { get; set; }
        [Column("DCBX_14", TypeName = "numeric(14, 3)")]
        public decimal Dcbx14 { get; set; }
        [Column("DCBX_15", TypeName = "numeric(14, 3)")]
        public decimal Dcbx15 { get; set; }
        [Column("DCBX_16", TypeName = "numeric(14, 3)")]
        public decimal Dcbx16 { get; set; }
        [Column("DCBX_17", TypeName = "numeric(14, 3)")]
        public decimal Dcbx17 { get; set; }
        [Column("DCBX_18", TypeName = "numeric(14, 3)")]
        public decimal Dcbx18 { get; set; }
        [Column("DCBX_19", TypeName = "numeric(14, 3)")]
        public decimal Dcbx19 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}