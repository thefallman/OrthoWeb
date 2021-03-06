// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AOBJTXT", Schema = "TESTPROD")]
    [Index(nameof(Abrev0), nameof(Ident10), nameof(Ident20), nameof(Ident30), Name = "AOBJTXT_AOX0", IsUnique = true)]
    public partial class Aobjtxt
    {
        [Required]
        [Column("ABREV_0")]
        [StringLength(3)]
        public string Abrev0 { get; set; }
        [Required]
        [Column("IDENT1_0")]
        [StringLength(80)]
        public string Ident10 { get; set; }
        [Required]
        [Column("IDENT2_0")]
        [StringLength(80)]
        public string Ident20 { get; set; }
        [Required]
        [Column("IDENT3_0")]
        [StringLength(10)]
        public string Ident30 { get; set; }
        [Required]
        [Column("TYPDOC_0")]
        [StringLength(20)]
        public string Typdoc0 { get; set; }
        [Required]
        [Column("NAM_0")]
        [StringLength(250)]
        public string Nam0 { get; set; }
        [Required]
        [Column("MOTCLE_0")]
        [StringLength(10)]
        public string Motcle0 { get; set; }
        [Required]
        [Column("MOTCLE_1")]
        [StringLength(10)]
        public string Motcle1 { get; set; }
        [Required]
        [Column("MOTCLE_2")]
        [StringLength(10)]
        public string Motcle2 { get; set; }
        [Required]
        [Column("MOTCLE_3")]
        [StringLength(10)]
        public string Motcle3 { get; set; }
        [Required]
        [Column("MOTCLE_4")]
        [StringLength(10)]
        public string Motcle4 { get; set; }
        [Column("CAT_0")]
        public byte Cat0 { get; set; }
        [Required]
        [Column("IDTSTO_0")]
        [StringLength(1)]
        public string Idtsto0 { get; set; }
        [Required]
        [Column("VERSION_0")]
        [StringLength(1)]
        public string Version0 { get; set; }
        [Required]
        [Column("IDTCNT_0")]
        [StringLength(1)]
        public string Idtcnt0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}