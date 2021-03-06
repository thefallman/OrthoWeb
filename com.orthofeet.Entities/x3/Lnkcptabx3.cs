// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("LNKCPTABX3", Schema = "TESTPROD")]
    [Index(nameof(Cpy0), nameof(Fcy0), nameof(Typ0), nameof(Accdat0), nameof(Num0), Name = "LNKCPTABX3_LCA0", IsUnique = true)]
    [Index(nameof(Cptref0), Name = "LNKCPTABX3_LCA1")]
    [Index(nameof(Typ0), nameof(Num0), Name = "LNKCPTABX3_LCA2", IsUnique = true)]
    [Index(nameof(Cpy0), nameof(Fcy0), nameof(Acetyp0), nameof(Typ0), nameof(Num0), Name = "LNKCPTABX3_LCA3", IsUnique = true)]
    public partial class Lnkcptabx3
    {
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("TYP_0")]
        [StringLength(5)]
        public string Typ0 { get; set; }
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Column("FIY_0")]
        public short Fiy0 { get; set; }
        [Column("PER_0")]
        public short Per0 { get; set; }
        [Column("CAT_0")]
        public byte Cat0 { get; set; }
        [Required]
        [Column("ACETYP_0")]
        [StringLength(10)]
        public string Acetyp0 { get; set; }
        [Column("LNKDAT_0", TypeName = "datetime")]
        public DateTime Lnkdat0 { get; set; }
        [Column("LNKSRC_0")]
        public byte Lnksrc0 { get; set; }
        [Column("CPTREF_0")]
        public byte Cptref0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Column("ACCDAT_0", TypeName = "datetime")]
        public DateTime Accdat0 { get; set; }
        [Column("ACCDATRUL_0")]
        public byte Accdatrul0 { get; set; }
        [Column("ACCDATFIX_0", TypeName = "datetime")]
        public DateTime Accdatfix0 { get; set; }
        [Required]
        [Column("TRACE_0")]
        [StringLength(250)]
        public string Trace0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}