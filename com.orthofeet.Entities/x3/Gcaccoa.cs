// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GCACCOA", Schema = "TESTPROD")]
    [Index(nameof(Cod0), Name = "GCACCOA_GCO0", IsUnique = true)]
    public partial class Gcaccoa
    {
        [Required]
        [Column("COD_0")]
        [StringLength(5)]
        public string Cod0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Column("NBRCOA_0")]
        public short Nbrcoa0 { get; set; }
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
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}