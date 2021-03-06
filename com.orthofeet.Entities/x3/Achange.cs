// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ACHANGE", Schema = "TESTPROD")]
    [Index(nameof(Cod0), nameof(Lig0), Name = "ACHANGE_ACG0", IsUnique = true)]
    public partial class Achange
    {
        [Required]
        [Column("COD_0")]
        [StringLength(10)]
        public string Cod0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Column("LIG_0")]
        public short Lig0 { get; set; }
        [Required]
        [Column("OBJ_0")]
        [StringLength(3)]
        public string Obj0 { get; set; }
        [Required]
        [Column("CLE1_0")]
        [StringLength(80)]
        public string Cle10 { get; set; }
        [Required]
        [Column("CLE2_0")]
        [StringLength(80)]
        public string Cle20 { get; set; }
        [Required]
        [Column("NEWCOD_0")]
        [StringLength(80)]
        public string Newcod0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}