// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GTMPMTC", Schema = "TESTPROD")]
    [Index(nameof(Id0), nameof(Acc0), nameof(Bpr0), nameof(Fcy0), nameof(Mtc0), nameof(Accnum0), nameof(Dudlig0), Name = "GTMPMTC_GMT0", IsUnique = true)]
    public partial class Gtmpmtc
    {
        [Required]
        [Column("ID_0")]
        [StringLength(10)]
        public string Id0 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(15)]
        public string Bpr0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("MTC_0")]
        [StringLength(5)]
        public string Mtc0 { get; set; }
        [Column("ACCNUM_0")]
        public int Accnum0 { get; set; }
        [Column("AMTIPT_0", TypeName = "numeric(27, 13)")]
        public decimal Amtipt0 { get; set; }
        [Column("DUDLIG_0")]
        public short Dudlig0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}