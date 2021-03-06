// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TMPMASPHY", Schema = "TESTPROD")]
    [Index(nameof(Trtnum0), nameof(Objref0), Name = "TMPMASPHY_MFS0", IsUnique = true)]
    [Index(nameof(Trtnum0), nameof(Cpy0), nameof(Objref0), Name = "TMPMASPHY_MFS1", IsUnique = true)]
    public partial class Tmpmasphy
    {
        [Column("TRTNUM_0")]
        public int Trtnum0 { get; set; }
        [Required]
        [Column("OBJREF_0")]
        [StringLength(20)]
        public string Objref0 { get; set; }
        [Column("FLGERR_0")]
        public byte Flgerr0 { get; set; }
        [Required]
        [Column("MSGERR_0")]
        [StringLength(100)]
        public string Msgerr0 { get; set; }
        [Column("FLGMOD_0")]
        public byte Flgmod0 { get; set; }
        [Required]
        [Column("PHYDESO_0")]
        [StringLength(60)]
        public string Phydeso0 { get; set; }
        [Required]
        [Column("PHYDES1_0")]
        [StringLength(60)]
        public string Phydes10 { get; set; }
        [Required]
        [Column("PHYDES1N_0")]
        [StringLength(60)]
        public string Phydes1n0 { get; set; }
        [Required]
        [Column("PHYDES2_0")]
        [StringLength(60)]
        public string Phydes20 { get; set; }
        [Required]
        [Column("PHYDES2N_0")]
        [StringLength(60)]
        public string Phydes2n0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCYO_0")]
        [StringLength(5)]
        public string Fcyo0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Column("CMPSTA_0")]
        public byte Cmpsta0 { get; set; }
        [Column("CCLTRF_0")]
        public byte Ccltrf0 { get; set; }
        [Required]
        [Column("RENTRF_0")]
        [StringLength(20)]
        public string Rentrf0 { get; set; }
        [Column("MVTDAT_0", TypeName = "datetime")]
        public DateTime Mvtdat0 { get; set; }
        [Required]
        [Column("GEOFCYO_0")]
        [StringLength(5)]
        public string Geofcyo0 { get; set; }
        [Required]
        [Column("GEOFCY_0")]
        [StringLength(5)]
        public string Geofcy0 { get; set; }
        [Required]
        [Column("LOCO_0")]
        [StringLength(38)]
        public string Loco0 { get; set; }
        [Required]
        [Column("LOC_0")]
        [StringLength(38)]
        public string Loc0 { get; set; }
        [Required]
        [Column("IASCGUO_0")]
        [StringLength(20)]
        public string Iascguo0 { get; set; }
        [Required]
        [Column("IASCGU_0")]
        [StringLength(20)]
        public string Iascgu0 { get; set; }
        [Column("ITSDAT_0", TypeName = "datetime")]
        public DateTime Itsdat0 { get; set; }
        [Required]
        [Column("RVAAPR_0")]
        [StringLength(15)]
        public string Rvaapr0 { get; set; }
        [Required]
        [Column("RVACMT_0")]
        [StringLength(60)]
        public string Rvacmt0 { get; set; }
        [Column("UNLINK_0")]
        public byte Unlink0 { get; set; }
        [Column("ISSTYP_0")]
        public byte Isstyp0 { get; set; }
        [Column("ISSDATRUL_0")]
        public byte Issdatrul0 { get; set; }
        [Column("ISSDAT_0", TypeName = "datetime")]
        public DateTime Issdat0 { get; set; }
        [Column("ISSAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Issamt0 { get; set; }
        [Column("ISSAMT_1", TypeName = "numeric(27, 13)")]
        public decimal Issamt1 { get; set; }
        [Column("ISSAMT_2", TypeName = "numeric(27, 13)")]
        public decimal Issamt2 { get; set; }
        [Column("ISSAMT_3", TypeName = "numeric(27, 13)")]
        public decimal Issamt3 { get; set; }
        [Column("ISSAMT_4", TypeName = "numeric(27, 13)")]
        public decimal Issamt4 { get; set; }
        [Column("ISSAMT_5", TypeName = "numeric(27, 13)")]
        public decimal Issamt5 { get; set; }
        [Column("ISSAMT_6", TypeName = "numeric(27, 13)")]
        public decimal Issamt6 { get; set; }
        [Column("ISSAMT_7", TypeName = "numeric(27, 13)")]
        public decimal Issamt7 { get; set; }
        [Column("ISSAMT_8", TypeName = "numeric(27, 13)")]
        public decimal Issamt8 { get; set; }
        [Column("ISSAMT_9", TypeName = "numeric(27, 13)")]
        public decimal Issamt9 { get; set; }
        [Column("ISSAMT_10", TypeName = "numeric(27, 13)")]
        public decimal Issamt10 { get; set; }
        [Column("ISSAMT_11", TypeName = "numeric(27, 13)")]
        public decimal Issamt11 { get; set; }
        [Column("ISSAMT_12", TypeName = "numeric(27, 13)")]
        public decimal Issamt12 { get; set; }
        [Column("ISSAMT_13", TypeName = "numeric(27, 13)")]
        public decimal Issamt13 { get; set; }
        [Column("ISSAMT_14", TypeName = "numeric(27, 13)")]
        public decimal Issamt14 { get; set; }
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
        [Required]
        [Column("AASREF_0")]
        [StringLength(20)]
        public string Aasref0 { get; set; }
        [Column("MVT_0")]
        public byte Mvt0 { get; set; }
        [Column("MVT_1")]
        public byte Mvt1 { get; set; }
        [Column("MVT_2")]
        public byte Mvt2 { get; set; }
        [Column("MVT_3")]
        public byte Mvt3 { get; set; }
        [Required]
        [Column("MVTLOC_0")]
        [StringLength(38)]
        public string Mvtloc0 { get; set; }
        [Required]
        [Column("MVTLOC_1")]
        [StringLength(38)]
        public string Mvtloc1 { get; set; }
        [Required]
        [Column("MVTLOC_2")]
        [StringLength(38)]
        public string Mvtloc2 { get; set; }
        [Required]
        [Column("MVTLOC_3")]
        [StringLength(38)]
        public string Mvtloc3 { get; set; }
        [Required]
        [Column("MVTGEO_0")]
        [StringLength(5)]
        public string Mvtgeo0 { get; set; }
        [Required]
        [Column("MVTGEO_1")]
        [StringLength(5)]
        public string Mvtgeo1 { get; set; }
        [Required]
        [Column("MVTGEO_2")]
        [StringLength(5)]
        public string Mvtgeo2 { get; set; }
        [Required]
        [Column("MVTGEO_3")]
        [StringLength(5)]
        public string Mvtgeo3 { get; set; }
        [Column("DNUMRECEP_0", TypeName = "datetime")]
        public DateTime Dnumrecep0 { get; set; }
        [Column("TRFDAT_0", TypeName = "datetime")]
        public DateTime Trfdat0 { get; set; }
        [Required]
        [Column("MVTFCY_0")]
        [StringLength(5)]
        public string Mvtfcy0 { get; set; }
        [Required]
        [Column("MVTFCY_1")]
        [StringLength(5)]
        public string Mvtfcy1 { get; set; }
        [Required]
        [Column("MVTFCY_2")]
        [StringLength(5)]
        public string Mvtfcy2 { get; set; }
        [Required]
        [Column("MVTFCY_3")]
        [StringLength(5)]
        public string Mvtfcy3 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}