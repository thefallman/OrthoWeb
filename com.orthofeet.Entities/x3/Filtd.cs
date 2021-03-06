// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("FILTDS", Schema = "TESTPROD")]
    [Index(nameof(Grp0), nameof(Numrec0), Name = "FILTDS_FTD0", IsUnique = true)]
    [Index(nameof(Grp0), Name = "FILTDS_FTD1")]
    public partial class Filtd
    {
        [Required]
        [Column("GRP_0")]
        [StringLength(10)]
        public string Grp0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Required]
        [Column("FILREF_0")]
        [StringLength(4)]
        public string Filref0 { get; set; }
        [Required]
        [Column("NUMREC_0")]
        [StringLength(20)]
        public string Numrec0 { get; set; }
        [Required]
        [Column("DESREC_0")]
        [StringLength(200)]
        public string Desrec0 { get; set; }
        [Column("FLGREC_0")]
        public byte Flgrec0 { get; set; }
        [Column("TYPREC_0")]
        public byte Typrec0 { get; set; }
        [Column("LNGREC_0")]
        public short Lngrec0 { get; set; }
        [Required]
        [Column("XPSRES_0")]
        [StringLength(250)]
        public string Xpsres0 { get; set; }
        [Column("VALNUL_0")]
        public byte Valnul0 { get; set; }
        [Column("CTLLNG_0")]
        public byte Ctllng0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}