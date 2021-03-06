// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("EFASCRT", Schema = "TESTPROD")]
    [Index(nameof(Ref0), nameof(Timstp0), Name = "EFASCRT_EVE0", IsUnique = true)]
    [Index(nameof(Ref0), nameof(Timstpo0), nameof(Timstp0), Name = "EFASCRT_EVE1", IsUnique = true)]
    [Index(nameof(Cptflg0), nameof(Dprpln0), nameof(Cpy0), nameof(Fcy0), nameof(Ref0), Name = "EFASCRT_EVE2")]
    public partial class Efascrt
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
        [Column("AASBUS_0")]
        [StringLength(20)]
        public string Aasbus0 { get; set; }
        [Required]
        [Column("DSP_0")]
        [StringLength(10)]
        public string Dsp0 { get; set; }
        [Required]
        [Column("DIE1_0")]
        [StringLength(3)]
        public string Die10 { get; set; }
        [Required]
        [Column("CCE1_0")]
        [StringLength(15)]
        public string Cce10 { get; set; }
        [Required]
        [Column("DIE2_0")]
        [StringLength(3)]
        public string Die20 { get; set; }
        [Required]
        [Column("CCE2_0")]
        [StringLength(15)]
        public string Cce20 { get; set; }
        [Required]
        [Column("DIE3_0")]
        [StringLength(3)]
        public string Die30 { get; set; }
        [Required]
        [Column("CCE3_0")]
        [StringLength(15)]
        public string Cce30 { get; set; }
        [Required]
        [Column("DIE4_0")]
        [StringLength(3)]
        public string Die40 { get; set; }
        [Required]
        [Column("CCE4_0")]
        [StringLength(15)]
        public string Cce40 { get; set; }
        [Required]
        [Column("DIE5_0")]
        [StringLength(3)]
        public string Die50 { get; set; }
        [Required]
        [Column("CCE5_0")]
        [StringLength(15)]
        public string Cce50 { get; set; }
        [Required]
        [Column("DIE6_0")]
        [StringLength(3)]
        public string Die60 { get; set; }
        [Required]
        [Column("CCE6_0")]
        [StringLength(15)]
        public string Cce60 { get; set; }
        [Required]
        [Column("DIE7_0")]
        [StringLength(3)]
        public string Die70 { get; set; }
        [Required]
        [Column("CCE7_0")]
        [StringLength(15)]
        public string Cce70 { get; set; }
        [Required]
        [Column("DIE8_0")]
        [StringLength(3)]
        public string Die80 { get; set; }
        [Required]
        [Column("CCE8_0")]
        [StringLength(15)]
        public string Cce80 { get; set; }
        [Required]
        [Column("DIE9_0")]
        [StringLength(3)]
        public string Die90 { get; set; }
        [Required]
        [Column("CCE9_0")]
        [StringLength(15)]
        public string Cce90 { get; set; }
        [Required]
        [Column("IASCGU_0")]
        [StringLength(1)]
        public string Iascgu0 { get; set; }
        [Required]
        [Column("GAC_0")]
        [StringLength(15)]
        public string Gac0 { get; set; }
        [Required]
        [Column("ACCCODLEA_0")]
        [StringLength(1)]
        public string Acccodlea0 { get; set; }
        [Column("ETRNOT_0", TypeName = "numeric(27, 13)")]
        public decimal Etrnot0 { get; set; }
        [Column("IVCVATAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Ivcvatamt0 { get; set; }
        [Column("DEDVATAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Dedvatamt0 { get; set; }
        [Column("RATCUR_0", TypeName = "numeric(21, 10)")]
        public decimal Ratcur0 { get; set; }
        [Column("PURDAT_0", TypeName = "datetime")]
        public DateTime Purdat0 { get; set; }
        [Column("ITSDAT_0", TypeName = "datetime")]
        public DateTime Itsdat0 { get; set; }
        [Column("AASIPTDAT_0", TypeName = "datetime")]
        public DateTime Aasiptdat0 { get; set; }
        [Column("OWNTYP_0")]
        public byte Owntyp0 { get; set; }
        [Column("ETRNAT_0")]
        public byte Etrnat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}