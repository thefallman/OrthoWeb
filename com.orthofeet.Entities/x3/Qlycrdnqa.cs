// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("QLYCRDNQA", Schema = "TESTPROD")]
    [Index(nameof(Cod0), nameof(Nqa0), nameof(Codsmp0), Name = "QLYCRDNQA_NQA0", IsUnique = true)]
    public partial class Qlycrdnqa
    {
        [Column("COD_0")]
        public short Cod0 { get; set; }
        [Column("NQA_0")]
        public byte Nqa0 { get; set; }
        [Required]
        [Column("CODSMP_0")]
        [StringLength(3)]
        public string Codsmp0 { get; set; }
        [Column("QTYACP_0")]
        public int Qtyacp0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}