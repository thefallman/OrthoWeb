﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SPRICCONF", Schema = "TESTPROD")]
    [Index(nameof(Pli0), Name = "SPRICCONF_SPC0", IsUnique = true)]
    [Index(nameof(Plienaflg0), nameof(Plityp0), nameof(Pio0), nameof(Pli0), Name = "SPRICCONF_SPC1", IsUnique = true)]
    public partial class Spricconf
    {
        [Required]
        [Column("PLI_0")]
        [StringLength(6)]
        public string Pli0 { get; set; }
        [Required]
        [Column("LANDESSHO_0")]
        [StringLength(60)]
        public string Landessho0 { get; set; }
        [Required]
        [Column("PLISTC_0")]
        [StringLength(10)]
        public string Plistc0 { get; set; }
        [Required]
        [Column("PLICPY_0")]
        [StringLength(5)]
        public string Plicpy0 { get; set; }
        [Column("PLISEA_0")]
        public short Plisea0 { get; set; }
        [Column("PIO_0")]
        public short Pio0 { get; set; }
        [Column("PLIENAFLG_0")]
        public byte Plienaflg0 { get; set; }
        [Column("PLIBPRCNR_0")]
        public byte Plibprcnr0 { get; set; }
        [Column("PLITYP_0")]
        public byte Plityp0 { get; set; }
        [Column("PRIREN_0")]
        public short Priren0 { get; set; }
        [Column("PRIPRO_0")]
        public byte Pripro0 { get; set; }
        [Required]
        [Column("PRIFLD_0")]
        [StringLength(250)]
        public string Prifld0 { get; set; }
        [Column("UPDNULPRI_0")]
        public byte Updnulpri0 { get; set; }
        [Column("PRIIND_0")]
        public short Priind0 { get; set; }
        [Column("PRITYP_0")]
        public byte Prityp0 { get; set; }
        [Column("ATICNVFLG_0")]
        public byte Aticnvflg0 { get; set; }
        [Column("PRIQTYFLG_0")]
        public byte Priqtyflg0 { get; set; }
        [Column("UOMCNVFLG_0")]
        public byte Uomcnvflg0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("CURCNVFLG_0")]
        public byte Curcnvflg0 { get; set; }
        [Column("FOCPRO_0")]
        public byte Focpro0 { get; set; }
        [Column("FOCTYP_0")]
        public byte Foctyp0 { get; set; }
        [Column("COMPRO_0")]
        public byte Compro0 { get; set; }
        [Column("DISCRGPRO_0")]
        public byte Discrgpro0 { get; set; }
        [Column("DISCRGPRO_1")]
        public byte Discrgpro1 { get; set; }
        [Column("DISCRGPRO_2")]
        public byte Discrgpro2 { get; set; }
        [Column("DISCRGPRO_3")]
        public byte Discrgpro3 { get; set; }
        [Column("DISCRGPRO_4")]
        public byte Discrgpro4 { get; set; }
        [Column("DISCRGPRO_5")]
        public byte Discrgpro5 { get; set; }
        [Column("DISCRGPRO_6")]
        public byte Discrgpro6 { get; set; }
        [Column("DISCRGPRO_7")]
        public byte Discrgpro7 { get; set; }
        [Column("DISCRGPRO_8")]
        public byte Discrgpro8 { get; set; }
        [Column("CRINBR_0")]
        public short Crinbr0 { get; set; }
        [Required]
        [Column("ABB_0")]
        [StringLength(3)]
        public string Abb0 { get; set; }
        [Required]
        [Column("ABB_1")]
        [StringLength(3)]
        public string Abb1 { get; set; }
        [Required]
        [Column("ABB_2")]
        [StringLength(3)]
        public string Abb2 { get; set; }
        [Required]
        [Column("ABB_3")]
        [StringLength(3)]
        public string Abb3 { get; set; }
        [Required]
        [Column("ABB_4")]
        [StringLength(3)]
        public string Abb4 { get; set; }
        [Required]
        [Column("FIL_0")]
        [StringLength(12)]
        public string Fil0 { get; set; }
        [Required]
        [Column("FIL_1")]
        [StringLength(12)]
        public string Fil1 { get; set; }
        [Required]
        [Column("FIL_2")]
        [StringLength(12)]
        public string Fil2 { get; set; }
        [Required]
        [Column("FIL_3")]
        [StringLength(12)]
        public string Fil3 { get; set; }
        [Required]
        [Column("FIL_4")]
        [StringLength(12)]
        public string Fil4 { get; set; }
        [Required]
        [Column("FLD_0")]
        [StringLength(12)]
        public string Fld0 { get; set; }
        [Required]
        [Column("FLD_1")]
        [StringLength(12)]
        public string Fld1 { get; set; }
        [Required]
        [Column("FLD_2")]
        [StringLength(12)]
        public string Fld2 { get; set; }
        [Required]
        [Column("FLD_3")]
        [StringLength(12)]
        public string Fld3 { get; set; }
        [Required]
        [Column("FLD_4")]
        [StringLength(12)]
        public string Fld4 { get; set; }
        [Required]
        [Column("FLDTYP_0")]
        [StringLength(3)]
        public string Fldtyp0 { get; set; }
        [Required]
        [Column("FLDTYP_1")]
        [StringLength(3)]
        public string Fldtyp1 { get; set; }
        [Required]
        [Column("FLDTYP_2")]
        [StringLength(3)]
        public string Fldtyp2 { get; set; }
        [Required]
        [Column("FLDTYP_3")]
        [StringLength(3)]
        public string Fldtyp3 { get; set; }
        [Required]
        [Column("FLDTYP_4")]
        [StringLength(3)]
        public string Fldtyp4 { get; set; }
        [Required]
        [Column("FLDTYPCPL_0")]
        [StringLength(10)]
        public string Fldtypcpl0 { get; set; }
        [Required]
        [Column("FLDTYPCPL_1")]
        [StringLength(10)]
        public string Fldtypcpl1 { get; set; }
        [Required]
        [Column("FLDTYPCPL_2")]
        [StringLength(10)]
        public string Fldtypcpl2 { get; set; }
        [Required]
        [Column("FLDTYPCPL_3")]
        [StringLength(10)]
        public string Fldtypcpl3 { get; set; }
        [Required]
        [Column("FLDTYPCPL_4")]
        [StringLength(10)]
        public string Fldtypcpl4 { get; set; }
        [Column("PPUMNU_0")]
        public short Ppumnu0 { get; set; }
        [Column("PPUMNU_1")]
        public short Ppumnu1 { get; set; }
        [Column("PPUMNU_2")]
        public short Ppumnu2 { get; set; }
        [Column("PPUMNU_3")]
        public short Ppumnu3 { get; set; }
        [Column("PPUMNU_4")]
        public short Ppumnu4 { get; set; }
        [Column("CRILEN_0", TypeName = "numeric(9, 4)")]
        public decimal Crilen0 { get; set; }
        [Column("CRILEN_1", TypeName = "numeric(9, 4)")]
        public decimal Crilen1 { get; set; }
        [Column("CRILEN_2", TypeName = "numeric(9, 4)")]
        public decimal Crilen2 { get; set; }
        [Column("CRILEN_3", TypeName = "numeric(9, 4)")]
        public decimal Crilen3 { get; set; }
        [Column("CRILEN_4", TypeName = "numeric(9, 4)")]
        public decimal Crilen4 { get; set; }
        [Required]
        [Column("CRIDIE_0")]
        [StringLength(3)]
        public string Cridie0 { get; set; }
        [Required]
        [Column("CRIDIE_1")]
        [StringLength(3)]
        public string Cridie1 { get; set; }
        [Required]
        [Column("CRIDIE_2")]
        [StringLength(3)]
        public string Cridie2 { get; set; }
        [Required]
        [Column("CRIDIE_3")]
        [StringLength(3)]
        public string Cridie3 { get; set; }
        [Required]
        [Column("CRIDIE_4")]
        [StringLength(3)]
        public string Cridie4 { get; set; }
        [Column("CRIIND_0")]
        public short Criind0 { get; set; }
        [Column("CRIIND_1")]
        public short Criind1 { get; set; }
        [Column("CRIIND_2")]
        public short Criind2 { get; set; }
        [Column("CRIIND_3")]
        public short Criind3 { get; set; }
        [Column("CRIIND_4")]
        public short Criind4 { get; set; }
        [Required]
        [Column("CRIDES_0")]
        [StringLength(30)]
        public string Crides0 { get; set; }
        [Required]
        [Column("CRIDES_1")]
        [StringLength(30)]
        public string Crides1 { get; set; }
        [Required]
        [Column("CRIDES_2")]
        [StringLength(30)]
        public string Crides2 { get; set; }
        [Required]
        [Column("CRIDES_3")]
        [StringLength(30)]
        public string Crides3 { get; set; }
        [Required]
        [Column("CRIDES_4")]
        [StringLength(30)]
        public string Crides4 { get; set; }
        [Column("LIEN_0")]
        public byte Lien0 { get; set; }
        [Column("LIEN_1")]
        public byte Lien1 { get; set; }
        [Column("LIEN_2")]
        public byte Lien2 { get; set; }
        [Column("LIEN_3")]
        public byte Lien3 { get; set; }
        [Column("LIEN_4")]
        public byte Lien4 { get; set; }
        [Column("CRICURNUM_0")]
        public short Cricurnum0 { get; set; }
        [Column("CRIUOMNUM_0")]
        public short Criuomnum0 { get; set; }
        [Column("CRIITMNUM_0")]
        public short Criitmnum0 { get; set; }
        [Column("CRIBPCNUM_0")]
        public short Cribpcnum0 { get; set; }
        [Column("CRIITM_0")]
        public short Criitm0 { get; set; }
        [Column("CRIBPR_0")]
        public short Cribpr0 { get; set; }
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