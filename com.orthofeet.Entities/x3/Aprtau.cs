// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("APRTAUS", Schema = "TESTPROD")]
    [Index(nameof(Usr0), nameof(Rptcod0), nameof(Cmp0), Name = "APRTAUS_AIA0", IsUnique = true)]
    public partial class Aprtau
    {
        [Required]
        [Column("USR_0")]
        [StringLength(5)]
        public string Usr0 { get; set; }
        [Required]
        [Column("RPTCOD_0")]
        [StringLength(15)]
        public string Rptcod0 { get; set; }
        [Required]
        [Column("CMP_0")]
        [StringLength(10)]
        public string Cmp0 { get; set; }
        [Required]
        [Column("PRT_0")]
        [StringLength(10)]
        public string Prt0 { get; set; }
        [Column("OBL_0")]
        public byte Obl0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}