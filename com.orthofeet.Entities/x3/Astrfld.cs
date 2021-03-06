// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ASTRFLD", Schema = "TESTPROD")]
    [Index(nameof(Codstr0), nameof(Numlig0), nameof(Fldstr0), Name = "ASTRFLD_ASF0", IsUnique = true)]
    [Index(nameof(Codstr0), nameof(Fldstr0), Name = "ASTRFLD_ASF1", IsUnique = true)]
    [Index(nameof(Codstr0), nameof(Numfld0), nameof(Numlig0), nameof(Fldstr0), Name = "ASTRFLD_ASF2", IsUnique = true)]
    public partial class Astrfld
    {
        [Required]
        [Column("CODSTR_0")]
        [StringLength(10)]
        public string Codstr0 { get; set; }
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
        [Required]
        [Column("FLDSTR_0")]
        [StringLength(12)]
        public string Fldstr0 { get; set; }
        [Column("NUMFLD_0", TypeName = "numeric(8, 3)")]
        public decimal Numfld0 { get; set; }
        [Column("INTFLD_0")]
        public int Intfld0 { get; set; }
        [Required]
        [Column("ACTFLD_0")]
        [StringLength(5)]
        public string Actfld0 { get; set; }
        [Required]
        [Column("CODTYP_0")]
        [StringLength(3)]
        public string Codtyp0 { get; set; }
        [Required]
        [Column("STRSTR_0")]
        [StringLength(10)]
        public string Strstr0 { get; set; }
        [Column("LONG_0", TypeName = "numeric(7, 3)")]
        public decimal Long0 { get; set; }
        [Column("NOLIB_0")]
        public short Nolib0 { get; set; }
        [Column("OBLIG_0")]
        public byte Oblig0 { get; set; }
        [Required]
        [Column("OPTOBJ_0")]
        [StringLength(10)]
        public string Optobj0 { get; set; }
        [Column("DIME_0")]
        public int Dime0 { get; set; }
        [Column("CTLON_0")]
        public byte Ctlon0 { get; set; }
        [Required]
        [Column("CODCTL_0")]
        [StringLength(10)]
        public string Codctl0 { get; set; }
        [Required]
        [Column("TAGXML_0")]
        [StringLength(250)]
        public string Tagxml0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}