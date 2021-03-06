// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XCPAYLKTMP", Schema = "TESTPROD")]
    [Index(nameof(Uid0), nameof(Accdatc0), nameof(Bpr0), nameof(Chqnum0), nameof(Seq0), nameof(Vcrnum0), Name = "XCPAYLKTMP_XCT0", IsUnique = true)]
    [Index(nameof(Uid0), nameof(Vcrnum0), nameof(Seq0), Name = "XCPAYLKTMP_XCT1", IsUnique = true)]
    [Index(nameof(Uid0), nameof(Paynum0), nameof(Rectyp0), nameof(Bpr0), nameof(Seq0), nameof(Vcrnum0), Name = "XCPAYLKTMP_XCT2", IsUnique = true)]
    public partial class Xcpaylktmp
    {
        [Column("UID_0")]
        public int Uid0 { get; set; }
        [Required]
        [Column("ACCDATC_0")]
        [StringLength(8)]
        public string Accdatc0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(15)]
        public string Bpr0 { get; set; }
        [Column("SEQ_0")]
        public int Seq0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Required]
        [Column("VCRTYP_0")]
        [StringLength(5)]
        public string Vcrtyp0 { get; set; }
        [Required]
        [Column("BPRLIN_0")]
        [StringLength(15)]
        public string Bprlin0 { get; set; }
        [Required]
        [Column("AMTLINC_0")]
        [StringLength(15)]
        public string Amtlinc0 { get; set; }
        [Required]
        [Column("CURLIN_0")]
        [StringLength(3)]
        public string Curlin0 { get; set; }
        [Column("PAYNUM_0")]
        public int Paynum0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("CHQNUM_0")]
        [StringLength(15)]
        public string Chqnum0 { get; set; }
        [Required]
        [Column("PAYLCKBAT_0")]
        [StringLength(20)]
        public string Paylckbat0 { get; set; }
        [Column("RECTYP_0")]
        public short Rectyp0 { get; set; }
        [Required]
        [Column("BPRINV_0")]
        [StringLength(15)]
        public string Bprinv0 { get; set; }
        [Required]
        [Column("BPRSACINV_0")]
        [StringLength(4)]
        public string Bprsacinv0 { get; set; }
        [Column("DUDNUM_0")]
        public int Dudnum0 { get; set; }
        [Column("DUDLIG_0")]
        public short Dudlig0 { get; set; }
        [Column("AMTLINDIS_0", TypeName = "numeric(27, 13)")]
        public decimal Amtlindis0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}