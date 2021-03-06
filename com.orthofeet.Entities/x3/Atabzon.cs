// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ATABZON", Schema = "TESTPROD")]
    [Index(nameof(Codtyp0), nameof(Codfic0), nameof(Codzone0), Name = "ATABZON_CODTYP", IsUnique = true)]
    [Index(nameof(Codfic0), nameof(Codzone0), Name = "ATABZON_CODZONE", IsUnique = true)]
    [Index(nameof(Codzone0), Name = "ATABZON_DICO")]
    [Index(nameof(Lien0), nameof(Codfic0), nameof(Codzone0), Name = "ATABZON_LIEN", IsUnique = true)]
    [Index(nameof(Codfic0), nameof(Numlig0), nameof(Codzone0), Name = "ATABZON_NUMLIG", IsUnique = true)]
    public partial class Atabzon
    {
        [Column("ANNUL_0")]
        public byte Annul0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Required]
        [Column("CODFIC_0")]
        [StringLength(12)]
        public string Codfic0 { get; set; }
        [Required]
        [Column("CODTYP_0")]
        [StringLength(3)]
        public string Codtyp0 { get; set; }
        [Required]
        [Column("CODZONE_0")]
        [StringLength(12)]
        public string Codzone0 { get; set; }
        [Column("DIME_0")]
        public short Dime0 { get; set; }
        [Required]
        [Column("EXPLIEN_0")]
        [StringLength(100)]
        public string Explien0 { get; set; }
        [Required]
        [Column("LIEN_0")]
        [StringLength(12)]
        public string Lien0 { get; set; }
        [Column("LONG_0", TypeName = "numeric(9, 4)")]
        public decimal Long0 { get; set; }
        [Column("NOABREG_0")]
        public int Noabreg0 { get; set; }
        [Column("NOCOURT_0")]
        public int Nocourt0 { get; set; }
        [Column("NOLIB_0")]
        public short Nolib0 { get; set; }
        [Column("NOLONG_0")]
        public int Nolong0 { get; set; }
        [Column("NUMLIG_0")]
        public short Numlig0 { get; set; }
        [Column("OBLIG_0")]
        public byte Oblig0 { get; set; }
        [Required]
        [Column("OPTION_0")]
        [StringLength(10)]
        public string Option0 { get; set; }
        [Required]
        [Column("MOTCLE_0")]
        [StringLength(10)]
        public string Motcle0 { get; set; }
        [Column("ZERO_0")]
        public byte Zero0 { get; set; }
        [Column("VERIF_0")]
        public byte Verif0 { get; set; }
        [Column("CHPLEG_0")]
        public short Chpleg0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}