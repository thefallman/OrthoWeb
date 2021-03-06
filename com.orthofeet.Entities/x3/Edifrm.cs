// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("EDIFRM", Schema = "TESTPROD")]
    [Index(nameof(Mes0), nameof(Ban0), nameof(Grp0), nameof(Occ0), nameof(Ordnum0), nameof(Seg0), nameof(Segocc0), nameof(Lig0), Name = "EDIFRM_EDM0", IsUnique = true)]
    public partial class Edifrm
    {
        [Required]
        [Column("MES_0")]
        [StringLength(10)]
        public string Mes0 { get; set; }
        [Required]
        [Column("BAN_0")]
        [StringLength(5)]
        public string Ban0 { get; set; }
        [Column("GRP_0")]
        public short Grp0 { get; set; }
        [Column("GRPSTA_0")]
        public byte Grpsta0 { get; set; }
        [Column("OCC_0")]
        public short Occ0 { get; set; }
        [Required]
        [Column("GRPCND_0")]
        [StringLength(40)]
        public string Grpcnd0 { get; set; }
        [Column("ORDNUM_0")]
        public short Ordnum0 { get; set; }
        [Required]
        [Column("SEG_0")]
        [StringLength(3)]
        public string Seg0 { get; set; }
        [Column("SEGSTA_0")]
        public byte Segsta0 { get; set; }
        [Column("SEGOCC_0")]
        public short Segocc0 { get; set; }
        [Required]
        [Column("SEGCND_0")]
        [StringLength(40)]
        public string Segcnd0 { get; set; }
        [Column("LIG_0")]
        public short Lig0 { get; set; }
        [Column("STA_0")]
        public byte Sta0 { get; set; }
        [Required]
        [Column("DATA_0")]
        [StringLength(4)]
        public string Data0 { get; set; }
        [Required]
        [Column("CPS_0")]
        [StringLength(4)]
        public string Cps0 { get; set; }
        [Column("LONG_0")]
        public short Long0 { get; set; }
        [Required]
        [Column("FRM_0")]
        [StringLength(80)]
        public string Frm0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}