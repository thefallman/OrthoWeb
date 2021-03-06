// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BPS1099MNT", Schema = "TESTPROD")]
    [Index(nameof(Yr10990), nameof(Cpy0), nameof(Bpsnum0), nameof(Frm10990), nameof(Box10990), Name = "BPS1099MNT_B9M0", IsUnique = true)]
    public partial class Bps1099mnt
    {
        [Column("YR1099_0")]
        public short Yr10990 { get; set; }
        [Required]
        [Column("BPSNUM_0")]
        [StringLength(15)]
        public string Bpsnum0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Column("FRM1099_0")]
        public byte Frm10990 { get; set; }
        [Required]
        [Column("BOX1099_0")]
        [StringLength(4)]
        public string Box10990 { get; set; }
        [Required]
        [Column("TXTFLD_0")]
        [StringLength(20)]
        public string Txtfld0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}