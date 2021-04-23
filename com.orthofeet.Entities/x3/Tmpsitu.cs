﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TMPSITU", Schema = "TESTPROD")]
    [Index(nameof(Edtnum0), nameof(Cpy0), nameof(Fcy0), nameof(Aasref0), Name = "TMPSITU_TDE0", IsUnique = true)]
    [Index(nameof(Edtnum0), nameof(Aasref0), Name = "TMPSITU_TDE1", IsUnique = true)]
    public partial class Tmpsitu
    {
        [Column("EDTNUM_0")]
        public int Edtnum0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("ACCCOD_0")]
        [StringLength(10)]
        public string Acccod0 { get; set; }
        [Required]
        [Column("GAC_0")]
        [StringLength(15)]
        public string Gac0 { get; set; }
        [Column("GACACN_0")]
        public byte Gacacn0 { get; set; }
        [Required]
        [Column("IASACC_0")]
        [StringLength(15)]
        public string Iasacc0 { get; set; }
        [Column("IASACN_0")]
        public byte Iasacn0 { get; set; }
        [Required]
        [Column("ACGGRP_0")]
        [StringLength(20)]
        public string Acggrp0 { get; set; }
        [Required]
        [Column("DSP_0")]
        [StringLength(10)]
        public string Dsp0 { get; set; }
        [Required]
        [Column("GEOFCY_0")]
        [StringLength(5)]
        public string Geofcy0 { get; set; }
        [Column("OWNTYP_0")]
        public byte Owntyp0 { get; set; }
        [Column("EXTISSFLG_0")]
        public byte Extissflg0 { get; set; }
        [Required]
        [Column("AASREF_0")]
        [StringLength(20)]
        public string Aasref0 { get; set; }
        [Column("ISSDAT_0", TypeName = "datetime")]
        public DateTime Issdat0 { get; set; }
        [Column("DPRPLN_0")]
        public byte Dprpln0 { get; set; }
        [Column("CNX_0")]
        public byte Cnx0 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Column("STRDPRDAT_0", TypeName = "datetime")]
        public DateTime Strdprdat0 { get; set; }
        [Column("FIYSTRDAT_0", TypeName = "datetime")]
        public DateTime Fiystrdat0 { get; set; }
        [Column("FIYENDDAT_0", TypeName = "datetime")]
        public DateTime Fiyenddat0 { get; set; }
        [Column("ENDDPRDAT_0", TypeName = "datetime")]
        public DateTime Enddprdat0 { get; set; }
        [Column("DPRBAS_0", TypeName = "numeric(27, 13)")]
        public decimal Dprbas0 { get; set; }
        [Column("RSDVAL_0", TypeName = "numeric(27, 13)")]
        public decimal Rsdval0 { get; set; }
        [Column("DPRCUM_0", TypeName = "numeric(27, 13)")]
        public decimal Dprcum0 { get; set; }
        [Column("PERCLOCUM_0", TypeName = "numeric(27, 13)")]
        public decimal Perclocum0 { get; set; }
        [Column("PERCLOEXC_0", TypeName = "numeric(27, 13)")]
        public decimal Percloexc0 { get; set; }
        [Column("ENDDPE_0", TypeName = "numeric(27, 13)")]
        public decimal Enddpe0 { get; set; }
        [Column("EXCDPR_0", TypeName = "numeric(27, 13)")]
        public decimal Excdpr0 { get; set; }
        [Column("PERENDDPE_0", TypeName = "numeric(27, 13)")]
        public decimal Perenddpe0 { get; set; }
        [Column("PEREXCDPR_0", TypeName = "numeric(27, 13)")]
        public decimal Perexcdpr0 { get; set; }
        [Column("FLGUPDISS_0")]
        public byte Flgupdiss0 { get; set; }
        [Column("DATISSPST_0", TypeName = "datetime")]
        public DateTime Datisspst0 { get; set; }
        [Required]
        [Column("DPM_0")]
        [StringLength(2)]
        public string Dpm0 { get; set; }
        [Column("DPRDUR_0", TypeName = "numeric(13, 4)")]
        public decimal Dprdur0 { get; set; }
        [Column("DPRRAT_0", TypeName = "numeric(16, 7)")]
        public decimal Dprrat0 { get; set; }
        [Column("NBV_0", TypeName = "numeric(27, 13)")]
        public decimal Nbv0 { get; set; }
        [Column("IML_0", TypeName = "numeric(27, 13)")]
        public decimal Iml0 { get; set; }
        [Column("IMLRVE_0", TypeName = "numeric(27, 13)")]
        public decimal Imlrve0 { get; set; }
        [Column("IMLRVETRF_0", TypeName = "numeric(27, 13)")]
        public decimal Imlrvetrf0 { get; set; }
        [Column("PERIMLCUM_0", TypeName = "numeric(27, 13)")]
        public decimal Perimlcum0 { get; set; }
        [Column("PERRVECUM_0", TypeName = "numeric(27, 13)")]
        public decimal Perrvecum0 { get; set; }
        [Column("PERTRFCUM_0", TypeName = "numeric(27, 13)")]
        public decimal Pertrfcum0 { get; set; }
        [Column("EXEIMLCUM_0", TypeName = "numeric(27, 13)")]
        public decimal Exeimlcum0 { get; set; }
        [Column("EXETRFCUM_0", TypeName = "numeric(27, 13)")]
        public decimal Exetrfcum0 { get; set; }
        [Column("IMLBLC_0", TypeName = "numeric(27, 13)")]
        public decimal Imlblc0 { get; set; }
        [Column("TCUMSTREXE_0", TypeName = "numeric(27, 13)")]
        public decimal Tcumstrexe0 { get; set; }
        [Column("TCUMSTRPER_0", TypeName = "numeric(27, 13)")]
        public decimal Tcumstrper0 { get; set; }
        [Column("TCUMENDEXE_0", TypeName = "numeric(27, 13)")]
        public decimal Tcumendexe0 { get; set; }
        [Column("TCUMENDPER_0", TypeName = "numeric(27, 13)")]
        public decimal Tcumendper0 { get; set; }
        [Column("TDPEEXE_0", TypeName = "numeric(27, 13)")]
        public decimal Tdpeexe0 { get; set; }
        [Column("TDPEPER_0", TypeName = "numeric(27, 13)")]
        public decimal Tdpeper0 { get; set; }
        [Column("TDPEEXCEXE_0", TypeName = "numeric(27, 13)")]
        public decimal Tdpeexcexe0 { get; set; }
        [Column("TDPEEXCPER_0", TypeName = "numeric(27, 13)")]
        public decimal Tdpeexcper0 { get; set; }
        [Column("TIMLEXE_0", TypeName = "numeric(27, 13)")]
        public decimal Timlexe0 { get; set; }
        [Column("TIMLPER_0", TypeName = "numeric(27, 13)")]
        public decimal Timlper0 { get; set; }
        [Column("TIMLRVEEXE_0", TypeName = "numeric(27, 13)")]
        public decimal Timlrveexe0 { get; set; }
        [Column("TIMLRVEPER_0", TypeName = "numeric(27, 13)")]
        public decimal Timlrveper0 { get; set; }
        [Column("TIMLRVEISS_0", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss0 { get; set; }
        [Column("TIMLRVEISS_1", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss1 { get; set; }
        [Column("TIMLRVEISS_2", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss2 { get; set; }
        [Column("TIMLRVEISS_3", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss3 { get; set; }
        [Column("TIMLRVEISS_4", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss4 { get; set; }
        [Column("TIMLRVEISS_5", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss5 { get; set; }
        [Column("TIMLRVEISS_6", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss6 { get; set; }
        [Column("TIMLRVEISS_7", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss7 { get; set; }
        [Column("TIMLRVEISS_8", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss8 { get; set; }
        [Column("TIMLRVEISS_9", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss9 { get; set; }
        [Column("TIMLRVEISS_10", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss10 { get; set; }
        [Column("TIMLRVEISS_11", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss11 { get; set; }
        [Column("TIMLRVEISS_12", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss12 { get; set; }
        [Column("TIMLRVEISS_13", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss13 { get; set; }
        [Column("TIMLRVEISS_14", TypeName = "numeric(27, 13)")]
        public decimal Timlrveiss14 { get; set; }
        [Column("TIMLBLCEXE_0", TypeName = "numeric(27, 13)")]
        public decimal Timlblcexe0 { get; set; }
        [Column("TIMLBLCPER_0", TypeName = "numeric(27, 13)")]
        public decimal Timlblcper0 { get; set; }
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