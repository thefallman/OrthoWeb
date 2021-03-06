// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("EPHYAFFGEO", Schema = "TESTPROD")]
    [Index(nameof(Ref0), nameof(Timstp0), Name = "EPHYAFFGEO_EVE0", IsUnique = true)]
    [Index(nameof(Ref0), nameof(Timstpo0), nameof(Timstp0), Name = "EPHYAFFGEO_EVE1", IsUnique = true)]
    [Index(nameof(Cptflg0), nameof(Dprpln0), nameof(Cpy0), nameof(Fcy0), nameof(Ref0), Name = "EPHYAFFGEO_EVE2")]
    [Index(nameof(Ref0), nameof(Evtdat0), Name = "EPHYAFFGEO_EVE3")]
    public partial class Ephyaffgeo
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
        [Column("EVEANN_0")]
        public byte Eveann0 { get; set; }
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
        [Column("GEOFCYO_0")]
        [StringLength(5)]
        public string Geofcyo0 { get; set; }
        [Required]
        [Column("GEOFCYD_0")]
        [StringLength(5)]
        public string Geofcyd0 { get; set; }
        [Required]
        [Column("LOCO_0")]
        [StringLength(38)]
        public string Loco0 { get; set; }
        [Required]
        [Column("LOCD_0")]
        [StringLength(38)]
        public string Locd0 { get; set; }
        [Column("MVTDAT_0", TypeName = "datetime")]
        public DateTime Mvtdat0 { get; set; }
        [Required]
        [Column("REN_0")]
        [StringLength(20)]
        public string Ren0 { get; set; }
        [Column("LASTDATTRF_0", TypeName = "datetime")]
        public DateTime Lastdattrf0 { get; set; }
        [Column("REFTAB1_0")]
        public short Reftab10 { get; set; }
        [Column("REFTAB2_0")]
        public short Reftab20 { get; set; }
        [Column("REFTAB3_0")]
        public short Reftab30 { get; set; }
        [Column("REFTAB4_0")]
        public short Reftab40 { get; set; }
        [Column("REFTAB5_0")]
        public short Reftab50 { get; set; }
        [Column("REFTAB6_0")]
        public short Reftab60 { get; set; }
        [Column("REFTAB7_0")]
        public short Reftab70 { get; set; }
        [Column("REFTAB8_0")]
        public short Reftab80 { get; set; }
        [Column("REFTAB9_0")]
        public short Reftab90 { get; set; }
        [Column("REFTAB10_0")]
        public short Reftab100 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Required]
        [Column("FCYD_0")]
        [StringLength(5)]
        public string Fcyd0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}