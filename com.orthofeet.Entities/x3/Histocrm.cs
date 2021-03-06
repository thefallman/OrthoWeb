// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("HISTOCRM", Schema = "TESTPROD")]
    [Index(nameof(Recnum0), nameof(Rectyp0), Name = "HISTOCRM_HST0")]
    [Index(nameof(Clsnum0), Name = "HISTOCRM_HST1")]
    [Index(nameof(Sss0), nameof(Clsnum0), Name = "HISTOCRM_HST2")]
    public partial class Histocrm
    {
        [Column("CLSNUM_0")]
        public int Clsnum0 { get; set; }
        [Column("DON_0")]
        public byte Don0 { get; set; }
        [Required]
        [Column("SSS_0")]
        [StringLength(30)]
        public string Sss0 { get; set; }
        [Required]
        [Column("RECNUM_0")]
        [StringLength(20)]
        public string Recnum0 { get; set; }
        [Required]
        [Column("RECTYP_0")]
        [StringLength(3)]
        public string Rectyp0 { get; set; }
        [Column("RECDAT_0", TypeName = "datetime")]
        public DateTime Recdat0 { get; set; }
        [Required]
        [Column("RECHOU_0")]
        [StringLength(5)]
        public string Rechou0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}