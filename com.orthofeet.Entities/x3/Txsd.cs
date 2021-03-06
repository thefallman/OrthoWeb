// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TXSD", Schema = "TESTPROD")]
    [Index(nameof(Txsnam0), nameof(Lig0), nameof(Col0), Name = "TXSD_TXD0", IsUnique = true)]
    [Index(nameof(Txsnam0), nameof(Col0), nameof(Lig0), Name = "TXSD_TXD1", IsUnique = true)]
    public partial class Txsd
    {
        [Required]
        [Column("TXSNAM_0")]
        [StringLength(10)]
        public string Txsnam0 { get; set; }
        [Column("LIG_0")]
        public short Lig0 { get; set; }
        [Column("COL_0")]
        public short Col0 { get; set; }
        [Required]
        [Column("FRM_0")]
        [StringLength(250)]
        public string Frm0 { get; set; }
        [Column("FMTPRN_0")]
        public byte Fmtprn0 { get; set; }
        [Column("EFFPRN_0")]
        public byte Effprn0 { get; set; }
        [Column("CEN_0")]
        public byte Cen0 { get; set; }
        [Column("DECCOL_0")]
        public short Deccol0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}