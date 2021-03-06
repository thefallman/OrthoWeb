// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("RUBASSVALP", Schema = "TESTPROD")]
    [Index(nameof(Numass0), nameof(Valdetaas0), nameof(Dprpln0), Name = "RUBASSVALP_RVP0", IsUnique = true)]
    [Index(nameof(Refobj0), nameof(Detaas0), nameof(Acm0), nameof(Cpy0), nameof(Valdetaas0), nameof(Dprpln0), Name = "RUBASSVALP_RVP1", IsUnique = true)]
    public partial class Rubassvalp
    {
        [Required]
        [Column("NUMASS_0")]
        [StringLength(10)]
        public string Numass0 { get; set; }
        [Column("REFOBJ_0")]
        public byte Refobj0 { get; set; }
        [Column("DETAAS_0")]
        public byte Detaas0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("ACM_0")]
        [StringLength(3)]
        public string Acm0 { get; set; }
        [Required]
        [Column("VALDETAAS_0")]
        [StringLength(30)]
        public string Valdetaas0 { get; set; }
        [Column("DPRPLN_0")]
        public byte Dprpln0 { get; set; }
        [Required]
        [Column("DPM_0")]
        [StringLength(2)]
        public string Dpm0 { get; set; }
        [Column("DPRDUR_0", TypeName = "numeric(13, 4)")]
        public decimal Dprdur0 { get; set; }
        [Column("DPRRAT_0", TypeName = "numeric(16, 7)")]
        public decimal Dprrat0 { get; set; }
        [Column("ALWCOD_0")]
        public byte Alwcod0 { get; set; }
        [Required]
        [Column("CRBVEHCOD_0")]
        [StringLength(20)]
        public string Crbvehcod0 { get; set; }
        [Column("DPRRAT2_0", TypeName = "numeric(16, 7)")]
        public decimal Dprrat20 { get; set; }
        [Column("PRATYP_0")]
        public byte Pratyp0 { get; set; }
        [Column("ACLCOE_0", TypeName = "numeric(16, 7)")]
        public decimal Aclcoe0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}