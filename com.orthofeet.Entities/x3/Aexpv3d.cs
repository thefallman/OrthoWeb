// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AEXPV3D", Schema = "TESTPROD")]
    [Index(nameof(Code0), nameof(Lig0), Name = "AEXPV3D_AED0", IsUnique = true)]
    public partial class Aexpv3d
    {
        [Required]
        [Column("CODE_0")]
        [StringLength(10)]
        public string Code0 { get; set; }
        [Column("LIG_0")]
        public short Lig0 { get; set; }
        [Required]
        [Column("ZON_0")]
        [StringLength(10)]
        public string Zon0 { get; set; }
        [Required]
        [Column("COND_0")]
        [StringLength(80)]
        public string Cond0 { get; set; }
        [Required]
        [Column("INIT_0")]
        [StringLength(80)]
        public string Init0 { get; set; }
        [Column("OBLIG_0")]
        public byte Oblig0 { get; set; }
        [Column("NUMTAB_0")]
        public short Numtab0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}