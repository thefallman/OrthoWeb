// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XAPCKEXCEP", Schema = "TESTPROD")]
    [Index(nameof(Batch0), nameof(Batchseq0), Name = "XAPCKEXCEP_XA60", IsUnique = true)]
    [Index(nameof(Vcrnum0), nameof(Vcrlin0), nameof(Vcrseq0), nameof(Loc0), nameof(Lot0), nameof(Slo0), Name = "XAPCKEXCEP_XA61")]
    public partial class Xapckexcep
    {
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("ADCUSER_0")]
        [StringLength(10)]
        public string Adcuser0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Column("VCRSEQ_0")]
        public int Vcrseq0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Required]
        [Column("LOC_0")]
        [StringLength(10)]
        public string Loc0 { get; set; }
        [Required]
        [Column("ZONE_0")]
        [StringLength(10)]
        public string Zone0 { get; set; }
        [Required]
        [Column("STA_0")]
        [StringLength(3)]
        public string Sta0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("QTYEXP_0", TypeName = "numeric(28, 13)")]
        public decimal Qtyexp0 { get; set; }
        [Column("QTYPCK_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypck0 { get; set; }
        [Required]
        [Column("SAU_0")]
        [StringLength(3)]
        public string Sau0 { get; set; }
        [Required]
        [Column("BATCH_0")]
        [StringLength(20)]
        public string Batch0 { get; set; }
        [Column("BATCHSEQ_0")]
        public int Batchseq0 { get; set; }
        [Required]
        [Column("LOT_0")]
        [StringLength(15)]
        public string Lot0 { get; set; }
        [Required]
        [Column("SLO_0")]
        [StringLength(5)]
        public string Slo0 { get; set; }
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}