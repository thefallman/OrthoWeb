﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ELOFCIM", Schema = "TESTPROD")]
    [Index(nameof(Ref0), nameof(Timstp0), Name = "ELOFCIM_EVE0", IsUnique = true)]
    [Index(nameof(Ref0), nameof(Timstpo0), nameof(Timstp0), Name = "ELOFCIM_EVE1", IsUnique = true)]
    [Index(nameof(Cptflg0), nameof(Dprpln0), nameof(Cpy0), nameof(Fcy0), nameof(Ref0), Name = "ELOFCIM_EVE2")]
    public partial class Elofcim
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
        [Column("REF_0")]
        [StringLength(20)]
        public string Ref0 { get; set; }
        [Column("LIN_0")]
        public short Lin0 { get; set; }
        [Column("DPRPLN_0")]
        public byte Dprpln0 { get; set; }
        [Column("CNX_0")]
        public byte Cnx0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(60)]
        public string Des0 { get; set; }
        [Required]
        [Column("ACCCOD_0")]
        [StringLength(10)]
        public string Acccod0 { get; set; }
        [Required]
        [Column("EVTINT_0")]
        [StringLength(10)]
        public string Evtint0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Required]
        [Column("TIMSTP_0")]
        [StringLength(20)]
        public string Timstp0 { get; set; }
        [Column("CREORI_0")]
        public byte Creori0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("EVTDAT_0", TypeName = "datetime")]
        public DateTime Evtdat0 { get; set; }
        [Column("CPTDATINT_0", TypeName = "datetime")]
        public DateTime Cptdatint0 { get; set; }
        [Column("CPTFLG_0")]
        public byte Cptflg0 { get; set; }
        [Column("CPTEVT_0")]
        public byte Cptevt0 { get; set; }
        [Column("SNSEVE_0")]
        public byte Snseve0 { get; set; }
        [Column("SNSCPT_0")]
        public short Snscpt0 { get; set; }
        [Required]
        [Column("CREUSRO_0")]
        [StringLength(5)]
        public string Creusro0 { get; set; }
        [Required]
        [Column("TIMSTPO_0")]
        [StringLength(20)]
        public string Timstpo0 { get; set; }
        [Column("CPTDATINTO_0", TypeName = "datetime")]
        public DateTime Cptdatinto0 { get; set; }
        [Required]
        [Column("USRFLDA1_0")]
        [StringLength(20)]
        public string Usrflda10 { get; set; }
        [Required]
        [Column("USRFLDA2_0")]
        [StringLength(20)]
        public string Usrflda20 { get; set; }
        [Required]
        [Column("USRFLDA3_0")]
        [StringLength(20)]
        public string Usrflda30 { get; set; }
        [Required]
        [Column("USRFLDA4_0")]
        [StringLength(20)]
        public string Usrflda40 { get; set; }
        [Required]
        [Column("USRFLDA5_0")]
        [StringLength(20)]
        public string Usrflda50 { get; set; }
        [Required]
        [Column("USRFLDA6_0")]
        [StringLength(20)]
        public string Usrflda60 { get; set; }
        [Required]
        [Column("USRFLDA7_0")]
        [StringLength(20)]
        public string Usrflda70 { get; set; }
        [Required]
        [Column("USRFLDA8_0")]
        [StringLength(20)]
        public string Usrflda80 { get; set; }
        [Required]
        [Column("USRFLDA9_0")]
        [StringLength(20)]
        public string Usrflda90 { get; set; }
        [Required]
        [Column("USRFLDA10_0")]
        [StringLength(20)]
        public string Usrflda100 { get; set; }
        [Column("USRFLDD1_0", TypeName = "datetime")]
        public DateTime Usrfldd10 { get; set; }
        [Column("USRFLDD2_0", TypeName = "datetime")]
        public DateTime Usrfldd20 { get; set; }
        [Column("USRFLDD3_0", TypeName = "datetime")]
        public DateTime Usrfldd30 { get; set; }
        [Column("USRFLDD4_0", TypeName = "datetime")]
        public DateTime Usrfldd40 { get; set; }
        [Column("USRFLDM1_0", TypeName = "numeric(27, 13)")]
        public decimal Usrfldm10 { get; set; }
        [Column("USRFLDM2_0", TypeName = "numeric(27, 13)")]
        public decimal Usrfldm20 { get; set; }
        [Column("USRFLDM3_0", TypeName = "numeric(27, 13)")]
        public decimal Usrfldm30 { get; set; }
        [Column("USRFLDM4_0", TypeName = "numeric(27, 13)")]
        public decimal Usrfldm40 { get; set; }
        [Column("USRFLDM5_0", TypeName = "numeric(27, 13)")]
        public decimal Usrfldm50 { get; set; }
        [Column("USRFLDM6_0", TypeName = "numeric(27, 13)")]
        public decimal Usrfldm60 { get; set; }
        [Column("USRFLDC1_0", TypeName = "numeric(18, 7)")]
        public decimal Usrfldc10 { get; set; }
        [Column("USRFLDC2_0", TypeName = "numeric(18, 7)")]
        public decimal Usrfldc20 { get; set; }
        [Required]
        [Column("GEOFCY_0")]
        [StringLength(5)]
        public string Geofcy0 { get; set; }
        [Required]
        [Column("ACGGRP_0")]
        [StringLength(20)]
        public string Acggrp0 { get; set; }
        [Required]
        [Column("ACT_0")]
        [StringLength(20)]
        public string Act0 { get; set; }
        [Required]
        [Column("DSP_0")]
        [StringLength(10)]
        public string Dsp0 { get; set; }
        [Required]
        [Column("DIE1_0")]
        [StringLength(3)]
        public string Die10 { get; set; }
        [Required]
        [Column("CCE1O_0")]
        [StringLength(15)]
        public string Cce1o0 { get; set; }
        [Required]
        [Column("CCE1D_0")]
        [StringLength(15)]
        public string Cce1d0 { get; set; }
        [Required]
        [Column("DIE2_0")]
        [StringLength(3)]
        public string Die20 { get; set; }
        [Required]
        [Column("CCE2O_0")]
        [StringLength(15)]
        public string Cce2o0 { get; set; }
        [Required]
        [Column("CCE2D_0")]
        [StringLength(15)]
        public string Cce2d0 { get; set; }
        [Required]
        [Column("DIE3_0")]
        [StringLength(3)]
        public string Die30 { get; set; }
        [Required]
        [Column("CCE3O_0")]
        [StringLength(15)]
        public string Cce3o0 { get; set; }
        [Required]
        [Column("CCE3D_0")]
        [StringLength(15)]
        public string Cce3d0 { get; set; }
        [Required]
        [Column("DIE4_0")]
        [StringLength(3)]
        public string Die40 { get; set; }
        [Required]
        [Column("CCE4O_0")]
        [StringLength(15)]
        public string Cce4o0 { get; set; }
        [Required]
        [Column("CCE4D_0")]
        [StringLength(15)]
        public string Cce4d0 { get; set; }
        [Required]
        [Column("DIE5_0")]
        [StringLength(3)]
        public string Die50 { get; set; }
        [Required]
        [Column("CCE5O_0")]
        [StringLength(15)]
        public string Cce5o0 { get; set; }
        [Required]
        [Column("CCE5D_0")]
        [StringLength(15)]
        public string Cce5d0 { get; set; }
        [Required]
        [Column("DIE6_0")]
        [StringLength(3)]
        public string Die60 { get; set; }
        [Required]
        [Column("CCE6O_0")]
        [StringLength(15)]
        public string Cce6o0 { get; set; }
        [Required]
        [Column("CCE6D_0")]
        [StringLength(15)]
        public string Cce6d0 { get; set; }
        [Required]
        [Column("DIE7_0")]
        [StringLength(3)]
        public string Die70 { get; set; }
        [Required]
        [Column("CCE7O_0")]
        [StringLength(15)]
        public string Cce7o0 { get; set; }
        [Required]
        [Column("CCE7D_0")]
        [StringLength(15)]
        public string Cce7d0 { get; set; }
        [Required]
        [Column("DIE8_0")]
        [StringLength(3)]
        public string Die80 { get; set; }
        [Required]
        [Column("CCE8O_0")]
        [StringLength(15)]
        public string Cce8o0 { get; set; }
        [Required]
        [Column("CCE8D_0")]
        [StringLength(15)]
        public string Cce8d0 { get; set; }
        [Required]
        [Column("DIE9_0")]
        [StringLength(3)]
        public string Die90 { get; set; }
        [Required]
        [Column("CCE9O_0")]
        [StringLength(15)]
        public string Cce9o0 { get; set; }
        [Required]
        [Column("CCE9D_0")]
        [StringLength(15)]
        public string Cce9d0 { get; set; }
        [Required]
        [Column("IASCGU_0")]
        [StringLength(1)]
        public string Iascgu0 { get; set; }
        [Required]
        [Column("ORDBUY_0")]
        [StringLength(20)]
        public string Ordbuy0 { get; set; }
        [Required]
        [Column("BPRVCR_0")]
        [StringLength(20)]
        public string Bprvcr0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(15)]
        public string Bpr0 { get; set; }
        [Required]
        [Column("UOM_0")]
        [StringLength(3)]
        public string Uom0 { get; set; }
        [Required]
        [Column("USRDEN_0")]
        [StringLength(5)]
        public string Usrden0 { get; set; }
        [Required]
        [Column("GACO_0")]
        [StringLength(15)]
        public string Gaco0 { get; set; }
        [Required]
        [Column("GACD_0")]
        [StringLength(15)]
        public string Gacd0 { get; set; }
        [Required]
        [Column("JOU_0")]
        [StringLength(5)]
        public string Jou0 { get; set; }
        [Column("AMTNOTCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Amtnotcur0 { get; set; }
        [Column("AMTNOTCPY_0", TypeName = "numeric(27, 13)")]
        public decimal Amtnotcpy0 { get; set; }
        [Column("AMTVATCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Amtvatcur0 { get; set; }
        [Column("AMTVATCPY_0", TypeName = "numeric(27, 13)")]
        public decimal Amtvatcpy0 { get; set; }
        [Column("AMTVATRCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Amtvatrcur0 { get; set; }
        [Column("AMTVATRCPY_0", TypeName = "numeric(27, 13)")]
        public decimal Amtvatrcpy0 { get; set; }
        [Column("QTY_0", TypeName = "numeric(28, 13)")]
        public decimal Qty0 { get; set; }
        [Column("DATVCR_0", TypeName = "datetime")]
        public DateTime Datvcr0 { get; set; }
        [Column("DATIMP_0", TypeName = "datetime")]
        public DateTime Datimp0 { get; set; }
        [Column("TYPVCR_0")]
        public byte Typvcr0 { get; set; }
        [Column("GACACNO_0")]
        public byte Gacacno0 { get; set; }
        [Column("GACACND_0")]
        public byte Gacacnd0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}