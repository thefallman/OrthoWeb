// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GACCPYMLIK", Schema = "TESTPROD")]
    [Index(nameof(Pym0), nameof(Lev0), nameof(Acc0), Name = "GACCPYMLIK_GYK0", IsUnique = true)]
    public partial class Gaccpymlik
    {
        [Required]
        [Column("PYM_0")]
        [StringLength(5)]
        public string Pym0 { get; set; }
        [Column("LEV_0")]
        public short Lev0 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("GRU_0")]
        [StringLength(10)]
        public string Gru0 { get; set; }
        [Column("PRNROW_0")]
        public short Prnrow0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}