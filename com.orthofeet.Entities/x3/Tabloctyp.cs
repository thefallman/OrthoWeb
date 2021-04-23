﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABLOCTYP", Schema = "TESTPROD")]
    [Index(nameof(Stofcy0), nameof(Loctyp0), Name = "TABLOCTYP_TLO0", IsUnique = true)]
    [Index(nameof(Stofcy0), nameof(Loccat0), nameof(Loctyp0), Name = "TABLOCTYP_TLO1", IsUnique = true)]
    public partial class Tabloctyp
    {
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("LOCTYP_0")]
        [StringLength(5)]
        public string Loctyp0 { get; set; }
        [Required]
        [Column("TYPSHO_0")]
        [StringLength(10)]
        public string Typsho0 { get; set; }
        [Required]
        [Column("TYPDES_0")]
        [StringLength(30)]
        public string Typdes0 { get; set; }
        [Column("LOCCAT_0")]
        public byte Loccat0 { get; set; }
        [Required]
        [Column("LOCNUMFMT_0")]
        [StringLength(10)]
        public string Locnumfmt0 { get; set; }
        [Required]
        [Column("PPSSEQ_0")]
        [StringLength(10)]
        public string Ppsseq0 { get; set; }
        [Column("FRGMGTMOD_0")]
        public byte Frgmgtmod0 { get; set; }
        [Column("TEMLTI_0")]
        public short Temlti0 { get; set; }
        [Column("REAFLG_0")]
        public byte Reaflg0 { get; set; }
        [Column("DEDFLG_0")]
        public byte Dedflg0 { get; set; }
        [Column("MONITMFLG_0")]
        public byte Monitmflg0 { get; set; }
        [Column("FILMGTFLG_0")]
        public byte Filmgtflg0 { get; set; }
        [Required]
        [Column("PCU_0")]
        [StringLength(3)]
        public string Pcu0 { get; set; }
        [Required]
        [Column("PCU_1")]
        [StringLength(3)]
        public string Pcu1 { get; set; }
        [Required]
        [Column("PCU_2")]
        [StringLength(3)]
        public string Pcu2 { get; set; }
        [Required]
        [Column("PCU_3")]
        [StringLength(3)]
        public string Pcu3 { get; set; }
        [Required]
        [Column("PCU_4")]
        [StringLength(3)]
        public string Pcu4 { get; set; }
        [Required]
        [Column("PCU_5")]
        [StringLength(3)]
        public string Pcu5 { get; set; }
        [Required]
        [Column("PCU_6")]
        [StringLength(3)]
        public string Pcu6 { get; set; }
        [Required]
        [Column("PCU_7")]
        [StringLength(3)]
        public string Pcu7 { get; set; }
        [Required]
        [Column("PCU_8")]
        [StringLength(3)]
        public string Pcu8 { get; set; }
        [Column("MAXQTYPCU_0", TypeName = "numeric(28, 13)")]
        public decimal Maxqtypcu0 { get; set; }
        [Column("MAXQTYPCU_1", TypeName = "numeric(28, 13)")]
        public decimal Maxqtypcu1 { get; set; }
        [Column("MAXQTYPCU_2", TypeName = "numeric(28, 13)")]
        public decimal Maxqtypcu2 { get; set; }
        [Column("MAXQTYPCU_3", TypeName = "numeric(28, 13)")]
        public decimal Maxqtypcu3 { get; set; }
        [Column("MAXQTYPCU_4", TypeName = "numeric(28, 13)")]
        public decimal Maxqtypcu4 { get; set; }
        [Column("MAXQTYPCU_5", TypeName = "numeric(28, 13)")]
        public decimal Maxqtypcu5 { get; set; }
        [Column("MAXQTYPCU_6", TypeName = "numeric(28, 13)")]
        public decimal Maxqtypcu6 { get; set; }
        [Column("MAXQTYPCU_7", TypeName = "numeric(28, 13)")]
        public decimal Maxqtypcu7 { get; set; }
        [Column("MAXQTYPCU_8", TypeName = "numeric(28, 13)")]
        public decimal Maxqtypcu8 { get; set; }
        [Column("PCUNBR_0")]
        public short Pcunbr0 { get; set; }
        [Required]
        [Column("AUZSST_0")]
        [StringLength(20)]
        public string Auzsst0 { get; set; }
        [Column("MAXAUZWEI_0", TypeName = "numeric(13, 4)")]
        public decimal Maxauzwei0 { get; set; }
        [Column("WID_0")]
        public short Wid0 { get; set; }
        [Column("HEI_0")]
        public short Hei0 { get; set; }
        [Column("DTH_0")]
        public short Dth0 { get; set; }
        [Required]
        [Column("RPLLOCTYP_0")]
        [StringLength(5)]
        public string Rplloctyp0 { get; set; }
        [Required]
        [Column("RPLLOCTYP_1")]
        [StringLength(5)]
        public string Rplloctyp1 { get; set; }
        [Required]
        [Column("RPLLOCTYP_2")]
        [StringLength(5)]
        public string Rplloctyp2 { get; set; }
        [Required]
        [Column("RPLLOCTYP_3")]
        [StringLength(5)]
        public string Rplloctyp3 { get; set; }
        [Required]
        [Column("RPLLOCTYP_4")]
        [StringLength(5)]
        public string Rplloctyp4 { get; set; }
        [Required]
        [Column("RPLLOCTYP_5")]
        [StringLength(5)]
        public string Rplloctyp5 { get; set; }
        [Required]
        [Column("RPLLOCTYP_6")]
        [StringLength(5)]
        public string Rplloctyp6 { get; set; }
        [Required]
        [Column("RPLLOCTYP_7")]
        [StringLength(5)]
        public string Rplloctyp7 { get; set; }
        [Required]
        [Column("RPLLOCTYP_8")]
        [StringLength(5)]
        public string Rplloctyp8 { get; set; }
        [Column("RPLNBR_0")]
        public short Rplnbr0 { get; set; }
        [Column("ANYDAT_0", TypeName = "datetime")]
        public DateTime Anydat0 { get; set; }
        [Required]
        [Column("ANYTIM_0")]
        [StringLength(5)]
        public string Anytim0 { get; set; }
        [Column("OCPLOC_0")]
        public int Ocploc0 { get; set; }
        [Column("FRGLOC_0")]
        public int Frgloc0 { get; set; }
        [Column("FULLOC_0")]
        public int Fulloc0 { get; set; }
        [Column("LOKLOC_0")]
        public int Lokloc0 { get; set; }
        [Column("PERLOA_0", TypeName = "numeric(8, 3)")]
        public decimal Perloa0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
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
        [Required]
        [Column("XA_WEIUOM_0")]
        [StringLength(3)]
        public string XaWeiuom0 { get; set; }
        [Required]
        [Column("XA_VOLUOM_0")]
        [StringLength(3)]
        public string XaVoluom0 { get; set; }
        [Required]
        [Column("XA_ZONE_0")]
        [StringLength(2)]
        public string XaZone0 { get; set; }
        [Column("XA_MOVFLG_0")]
        public byte XaMovflg0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}