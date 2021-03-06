// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABCOSTMET", Schema = "TESTPROD")]
    [Index(nameof(Vltcod0), Name = "TABCOSTMET_TCM0", IsUnique = true)]
    public partial class Tabcostmet
    {
        [Required]
        [Column("VLTCOD_0")]
        [StringLength(3)]
        public string Vltcod0 { get; set; }
        [Required]
        [Column("TCMDES_0")]
        [StringLength(30)]
        public string Tcmdes0 { get; set; }
        [Required]
        [Column("TCMSHO_0")]
        [StringLength(10)]
        public string Tcmsho0 { get; set; }
        [Column("RCPVLTCOD_0")]
        public byte Rcpvltcod0 { get; set; }
        [Column("RCPVLTCOD_1")]
        public byte Rcpvltcod1 { get; set; }
        [Column("RCPVLT2_0")]
        public byte Rcpvlt20 { get; set; }
        [Column("RCPVLT2_1")]
        public byte Rcpvlt21 { get; set; }
        [Column("ISSVLTCOD_0")]
        public byte Issvltcod0 { get; set; }
        [Column("ISSVLTCOD_1")]
        public byte Issvltcod1 { get; set; }
        [Column("ISSVLT2_0")]
        public byte Issvlt20 { get; set; }
        [Column("ISSVLT2_1")]
        public byte Issvlt21 { get; set; }
        [Column("VLTINT_0")]
        public byte Vltint0 { get; set; }
        [Column("CUNPOS_0")]
        public byte Cunpos0 { get; set; }
        [Column("CUNPOS_1")]
        public byte Cunpos1 { get; set; }
        [Column("CUNPOS2_0")]
        public byte Cunpos20 { get; set; }
        [Column("CUNPOS2_1")]
        public byte Cunpos21 { get; set; }
        [Column("CUNNEG_0")]
        public byte Cunneg0 { get; set; }
        [Column("CUNNEG_1")]
        public byte Cunneg1 { get; set; }
        [Column("CUNNEG2_0")]
        public byte Cunneg20 { get; set; }
        [Column("CUNNEG2_1")]
        public byte Cunneg21 { get; set; }
        [Column("PRIREG_0")]
        public byte Prireg0 { get; set; }
        [Column("PRIREG_1")]
        public byte Prireg1 { get; set; }
        [Column("PRIREGS_0")]
        public byte Priregs0 { get; set; }
        [Column("NULPRI_0")]
        public byte Nulpri0 { get; set; }
        [Column("NULPRI_1")]
        public byte Nulpri1 { get; set; }
        [Column("AVCPER_0")]
        public byte Avcper0 { get; set; }
        [Column("PFMCLCBAS_0")]
        public byte Pfmclcbas0 { get; set; }
        [Column("PFMCLC2_0")]
        public byte Pfmclc20 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}