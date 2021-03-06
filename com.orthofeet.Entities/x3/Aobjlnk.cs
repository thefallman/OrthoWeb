// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AOBJLNK", Schema = "TESTPROD")]
    [Index(nameof(Srcobj0), nameof(Lin0), Name = "AOBJLNK_AOK0", IsUnique = true)]
    public partial class Aobjlnk
    {
        [Required]
        [Column("SRCOBJ_0")]
        [StringLength(3)]
        public string Srcobj0 { get; set; }
        [Column("LIN_0")]
        public short Lin0 { get; set; }
        [Required]
        [Column("DSTOBJ_0")]
        [StringLength(3)]
        public string Dstobj0 { get; set; }
        [Required]
        [Column("EXPLIEN_0")]
        [StringLength(50)]
        public string Explien0 { get; set; }
        [Required]
        [Column("LNK_0")]
        [StringLength(20)]
        public string Lnk0 { get; set; }
        [Required]
        [Column("ABRFIC_0")]
        [StringLength(4)]
        public string Abrfic0 { get; set; }
        [Required]
        [Column("BASPAG_0")]
        [StringLength(30)]
        public string Baspag0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}