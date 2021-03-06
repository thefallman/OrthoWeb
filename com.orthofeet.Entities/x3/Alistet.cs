// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ALISTET", Schema = "TESTPROD")]
    [Index(nameof(Cod0), nameof(Tbl0), Name = "ALISTET_ALT0", IsUnique = true)]
    public partial class Alistet
    {
        [Required]
        [Column("COD_0")]
        [StringLength(8)]
        public string Cod0 { get; set; }
        [Required]
        [Column("TBL_0")]
        [StringLength(12)]
        public string Tbl0 { get; set; }
        [Column("X_0")]
        public short X0 { get; set; }
        [Column("Y_0")]
        public short Y0 { get; set; }
        [Column("HIG_0")]
        public short Hig0 { get; set; }
        [Column("LRG_0")]
        public short Lrg0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}