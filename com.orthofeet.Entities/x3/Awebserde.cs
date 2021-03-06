// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AWEBSERDES", Schema = "TESTPROD")]
    [Index(nameof(Publi0), nameof(Grp0), nameof(Chp0), Name = "AWEBSERDES_AWY1", IsUnique = true)]
    public partial class Awebserde
    {
        [Required]
        [Column("PUBLI_0")]
        [StringLength(10)]
        public string Publi0 { get; set; }
        [Column("SELECT_0")]
        public byte Select0 { get; set; }
        [Required]
        [Column("GROUPE_0")]
        [StringLength(40)]
        public string Groupe0 { get; set; }
        [Required]
        [Column("CHAMP_0")]
        [StringLength(40)]
        public string Champ0 { get; set; }
        [Column("LONCHP_0")]
        public short Lonchp0 { get; set; }
        [Required]
        [Column("GRP_0")]
        [StringLength(10)]
        public string Grp0 { get; set; }
        [Required]
        [Column("CHP_0")]
        [StringLength(30)]
        public string Chp0 { get; set; }
        [Required]
        [Column("USERP_0")]
        [StringLength(5)]
        public string Userp0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("AUTMIN_0")]
        public byte Autmin0 { get; set; }
        [Column("VALMIN_0")]
        public short Valmin0 { get; set; }
        [Column("MININCLU_0")]
        public byte Mininclu0 { get; set; }
        [Column("AUTMAX_0")]
        public byte Autmax0 { get; set; }
        [Column("VALMAX_0")]
        public int Valmax0 { get; set; }
        [Column("MAXINCLU_0")]
        public byte Maxinclu0 { get; set; }
        [Column("TOTALDIGIT_0")]
        public short Totaldigit0 { get; set; }
        [Column("FRACTIONDIG_0")]
        public short Fractiondig0 { get; set; }
        [Required]
        [Column("PATTERN_0")]
        [StringLength(30)]
        public string Pattern0 { get; set; }
        [Column("NOLIB_0")]
        public short Nolib0 { get; set; }
        [Column("IDX_0")]
        public short Idx0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}