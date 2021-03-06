// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PARSTALIG", Schema = "TESTPROD")]
    [Index(nameof(Cod0), nameof(Numlig0), Name = "PARSTALIG_PSL0", IsUnique = true)]
    public partial class Parstalig
    {
        [Required]
        [Column("COD_0")]
        [StringLength(5)]
        public string Cod0 { get; set; }
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
        [Required]
        [Column("VARNAM_0")]
        [StringLength(10)]
        public string Varnam0 { get; set; }
        [Required]
        [Column("AMTFOR_0")]
        [StringLength(200)]
        public string Amtfor0 { get; set; }
        [Column("CNV_0")]
        public byte Cnv0 { get; set; }
        [Required]
        [Column("DEVORG_0")]
        [StringLength(40)]
        public string Devorg0 { get; set; }
        [Required]
        [Column("DEVDES_0")]
        [StringLength(40)]
        public string Devdes0 { get; set; }
        [Column("FRTFLG_0")]
        public byte Frtflg0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}