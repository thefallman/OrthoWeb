// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XAITMLBL", Schema = "TESTPROD")]
    [Index(nameof(Apid0), nameof(Seq0), Name = "XAITMLBL_XAI0", IsUnique = true)]
    public partial class Xaitmlbl
    {
        [Required]
        [Column("APID_0")]
        [StringLength(30)]
        public string Apid0 { get; set; }
        [Column("SEQ_0")]
        public int Seq0 { get; set; }
        [Required]
        [Column("POHNUM_0")]
        [StringLength(20)]
        public string Pohnum0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("LOT_0")]
        [StringLength(15)]
        public string Lot0 { get; set; }
        [Required]
        [Column("SLO_0")]
        [StringLength(5)]
        public string Slo0 { get; set; }
        [Column("QTY_0", TypeName = "numeric(28, 13)")]
        public decimal Qty0 { get; set; }
        [Column("RCPDAT_0", TypeName = "datetime")]
        public DateTime Rcpdat0 { get; set; }
        [Required]
        [Column("BPSLOT_0")]
        [StringLength(15)]
        public string Bpslot0 { get; set; }
        [Required]
        [Column("PALNUM_0")]
        [StringLength(10)]
        public string Palnum0 { get; set; }
        [Required]
        [Column("CTRNUM_0")]
        [StringLength(10)]
        public string Ctrnum0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("UOM_0")]
        [StringLength(3)]
        public string Uom0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}