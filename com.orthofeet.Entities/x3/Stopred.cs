﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("STOPRED", Schema = "TESTPROD")]
    [Index(nameof(Prhnum0), nameof(Prelin0), Name = "STOPRED_PRE0", IsUnique = true)]
    public partial class Stopred
    {
        [Required]
        [Column("PRHNUM_0")]
        [StringLength(20)]
        public string Prhnum0 { get; set; }
        [Column("PRELIN_0")]
        public int Prelin0 { get; set; }
        [Column("ORITYP_0")]
        public byte Orityp0 { get; set; }
        [Required]
        [Column("ORINUM_0")]
        [StringLength(20)]
        public string Orinum0 { get; set; }
        [Column("ORILIN_0")]
        public int Orilin0 { get; set; }
        [Column("ORISEQ_0")]
        public int Oriseq0 { get; set; }
        [Column("LINTYP_0")]
        public byte Lintyp0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("ITMDES1_0")]
        [StringLength(30)]
        public string Itmdes10 { get; set; }
        [Required]
        [Column("REOLOC_0")]
        [StringLength(10)]
        public string Reoloc0 { get; set; }
        [Column("SEQ_0")]
        public int Seq0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Column("PACQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Pacqtystu0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Column("ALLQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Allqty0 { get; set; }
        [Column("SHTQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Shtqty0 { get; set; }
        [Column("ALLTYP_0")]
        public byte Alltyp0 { get; set; }
        [Column("OALQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Oalqtystu0 { get; set; }
        [Column("STOMGTCOD_0")]
        public byte Stomgtcod0 { get; set; }
        [Required]
        [Column("PCU_0")]
        [StringLength(3)]
        public string Pcu0 { get; set; }
        [Column("PCUSTUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Pcustucoe0 { get; set; }
        [Required]
        [Column("LOCDES_0")]
        [StringLength(10)]
        public string Locdes0 { get; set; }
        [Required]
        [Column("LOCTYPDES_0")]
        [StringLength(5)]
        public string Loctypdes0 { get; set; }
        [Required]
        [Column("PCK_0")]
        [StringLength(5)]
        public string Pck0 { get; set; }
        [Column("PCKCAP_0", TypeName = "numeric(18, 7)")]
        public decimal Pckcap0 { get; set; }
        [Required]
        [Column("PRPTEX_0")]
        [StringLength(12)]
        public string Prptex0 { get; set; }
        [Column("FLGVT_0")]
        public short Flgvt0 { get; set; }
        [Column("FLGANN_0")]
        public short Flgann0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}