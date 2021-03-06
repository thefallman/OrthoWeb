// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ASTRLISTD", Schema = "TESTPROD")]
    [Index(nameof(Cod0), nameof(Numlig0), Name = "ASTRLISTD_ASI0", IsUnique = true)]
    public partial class Astrlistd
    {
        [Required]
        [Column("COD_0")]
        [StringLength(6)]
        public string Cod0 { get; set; }
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
        [Required]
        [Column("CLE_0")]
        [StringLength(80)]
        public string Cle0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}