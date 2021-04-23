﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BPCINVVAT", Schema = "TESTPROD")]
    [Index(nameof(Num0), Name = "BPCINVVAT_SIT0", IsUnique = true)]
    public partial class Bpcinvvat
    {
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Required]
        [Column("CODE_0")]
        [StringLength(5)]
        public string Code0 { get; set; }
        [Required]
        [Column("CODE_1")]
        [StringLength(5)]
        public string Code1 { get; set; }
        [Required]
        [Column("CODE_2")]
        [StringLength(5)]
        public string Code2 { get; set; }
        [Required]
        [Column("CODE_3")]
        [StringLength(5)]
        public string Code3 { get; set; }
        [Required]
        [Column("CODE_4")]
        [StringLength(5)]
        public string Code4 { get; set; }
        [Required]
        [Column("CODE_5")]
        [StringLength(5)]
        public string Code5 { get; set; }
        [Required]
        [Column("CODE_6")]
        [StringLength(5)]
        public string Code6 { get; set; }
        [Required]
        [Column("CODE_7")]
        [StringLength(5)]
        public string Code7 { get; set; }
        [Required]
        [Column("CODE_8")]
        [StringLength(5)]
        public string Code8 { get; set; }
        [Required]
        [Column("CODE_9")]
        [StringLength(5)]
        public string Code9 { get; set; }
        [Column("TAUX_0", TypeName = "numeric(16, 7)")]
        public decimal Taux0 { get; set; }
        [Column("TAUX_1", TypeName = "numeric(16, 7)")]
        public decimal Taux1 { get; set; }
        [Column("TAUX_2", TypeName = "numeric(16, 7)")]
        public decimal Taux2 { get; set; }
        [Column("TAUX_3", TypeName = "numeric(16, 7)")]
        public decimal Taux3 { get; set; }
        [Column("TAUX_4", TypeName = "numeric(16, 7)")]
        public decimal Taux4 { get; set; }
        [Column("TAUX_5", TypeName = "numeric(16, 7)")]
        public decimal Taux5 { get; set; }
        [Column("TAUX_6", TypeName = "numeric(16, 7)")]
        public decimal Taux6 { get; set; }
        [Column("TAUX_7", TypeName = "numeric(16, 7)")]
        public decimal Taux7 { get; set; }
        [Column("TAUX_8", TypeName = "numeric(16, 7)")]
        public decimal Taux8 { get; set; }
        [Column("TAUX_9", TypeName = "numeric(16, 7)")]
        public decimal Taux9 { get; set; }
        [Column("DOC_0")]
        public short Doc0 { get; set; }
        [Required]
        [Column("TEX_0")]
        [StringLength(80)]
        public string Tex0 { get; set; }
        [Required]
        [Column("TEX_1")]
        [StringLength(80)]
        public string Tex1 { get; set; }
        [Required]
        [Column("TEX_2")]
        [StringLength(80)]
        public string Tex2 { get; set; }
        [Required]
        [Column("TEX_3")]
        [StringLength(80)]
        public string Tex3 { get; set; }
        [Required]
        [Column("TEX_4")]
        [StringLength(80)]
        public string Tex4 { get; set; }
        [Required]
        [Column("TEX_5")]
        [StringLength(80)]
        public string Tex5 { get; set; }
        [Required]
        [Column("TEX_6")]
        [StringLength(80)]
        public string Tex6 { get; set; }
        [Required]
        [Column("TEX_7")]
        [StringLength(80)]
        public string Tex7 { get; set; }
        [Required]
        [Column("TEX_8")]
        [StringLength(80)]
        public string Tex8 { get; set; }
        [Required]
        [Column("TEX_9")]
        [StringLength(80)]
        public string Tex9 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}