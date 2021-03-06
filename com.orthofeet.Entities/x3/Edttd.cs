// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("EDTTDS", Schema = "TESTPROD")]
    [Index(nameof(Siren0), nameof(Crn0), nameof(Rectyp0), nameof(Numlin0), nameof(Num0), Name = "EDTTDS_ETD0", IsUnique = true)]
    public partial class Edttd
    {
        [Required]
        [Column("SIREN_0")]
        [StringLength(9)]
        public string Siren0 { get; set; }
        [Required]
        [Column("CRN_0")]
        [StringLength(20)]
        public string Crn0 { get; set; }
        [Column("RECTYP_0")]
        public byte Rectyp0 { get; set; }
        [Column("NUMLIN_0")]
        public short Numlin0 { get; set; }
        [Column("NUM_0")]
        public short Num0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Required]
        [Column("VALTDS_0")]
        [StringLength(100)]
        public string Valtds0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}