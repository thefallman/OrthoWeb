﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("FACILITY", Schema = "TESTPROD")]
    [Index(nameof(Fcy0), Name = "FACILITY_FCY0", IsUnique = true)]
    [Index(nameof(Legcpy0), nameof(Fcy0), Name = "FACILITY_FCY1", IsUnique = true)]
    public partial class Facility
    {
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("FCYNAM_0")]
        [StringLength(35)]
        public string Fcynam0 { get; set; }
        [Required]
        [Column("FCYSHO_0")]
        [StringLength(10)]
        public string Fcysho0 { get; set; }
        [Required]
        [Column("CRY_0")]
        [StringLength(3)]
        public string Cry0 { get; set; }
        [Required]
        [Column("CRN_0")]
        [StringLength(20)]
        public string Crn0 { get; set; }
        [Required]
        [Column("NAF_0")]
        [StringLength(10)]
        public string Naf0 { get; set; }
        [Required]
        [Column("BPTNUM_0")]
        [StringLength(15)]
        public string Bptnum0 { get; set; }
        [Column("MFGFLG_0")]
        public byte Mfgflg0 { get; set; }
        [Column("SALFLG_0")]
        public byte Salflg0 { get; set; }
        [Column("PURFLG_0")]
        public byte Purflg0 { get; set; }
        [Column("WRHFLG_0")]
        public byte Wrhflg0 { get; set; }
        [Column("FINFLG_0")]
        public byte Finflg0 { get; set; }
        [Required]
        [Column("FINRSPFCY_0")]
        [StringLength(5)]
        public string Finrspfcy0 { get; set; }
        [Column("DADFLG_0")]
        public byte Dadflg0 { get; set; }
        [Required]
        [Column("DADFCY_0")]
        [StringLength(5)]
        public string Dadfcy0 { get; set; }
        [Required]
        [Column("PAYBAN_0")]
        [StringLength(5)]
        public string Payban0 { get; set; }
        [Required]
        [Column("ACCCOD_0")]
        [StringLength(10)]
        public string Acccod0 { get; set; }
        [Required]
        [Column("LEGCPY_0")]
        [StringLength(5)]
        public string Legcpy0 { get; set; }
        [Required]
        [Column("DIE_0")]
        [StringLength(10)]
        public string Die0 { get; set; }
        [Required]
        [Column("DIE_1")]
        [StringLength(10)]
        public string Die1 { get; set; }
        [Required]
        [Column("DIE_2")]
        [StringLength(10)]
        public string Die2 { get; set; }
        [Required]
        [Column("DIE_3")]
        [StringLength(10)]
        public string Die3 { get; set; }
        [Required]
        [Column("DIE_4")]
        [StringLength(10)]
        public string Die4 { get; set; }
        [Required]
        [Column("DIE_5")]
        [StringLength(10)]
        public string Die5 { get; set; }
        [Required]
        [Column("DIE_6")]
        [StringLength(10)]
        public string Die6 { get; set; }
        [Required]
        [Column("DIE_7")]
        [StringLength(10)]
        public string Die7 { get; set; }
        [Required]
        [Column("DIE_8")]
        [StringLength(10)]
        public string Die8 { get; set; }
        [Required]
        [Column("DIE_9")]
        [StringLength(10)]
        public string Die9 { get; set; }
        [Required]
        [Column("DIE_10")]
        [StringLength(10)]
        public string Die10 { get; set; }
        [Required]
        [Column("DIE_11")]
        [StringLength(10)]
        public string Die11 { get; set; }
        [Required]
        [Column("DIE_12")]
        [StringLength(10)]
        public string Die12 { get; set; }
        [Required]
        [Column("DIE_13")]
        [StringLength(10)]
        public string Die13 { get; set; }
        [Required]
        [Column("DIE_14")]
        [StringLength(10)]
        public string Die14 { get; set; }
        [Required]
        [Column("DIE_15")]
        [StringLength(10)]
        public string Die15 { get; set; }
        [Required]
        [Column("DIE_16")]
        [StringLength(10)]
        public string Die16 { get; set; }
        [Required]
        [Column("DIE_17")]
        [StringLength(10)]
        public string Die17 { get; set; }
        [Required]
        [Column("DIE_18")]
        [StringLength(10)]
        public string Die18 { get; set; }
        [Required]
        [Column("DIE_19")]
        [StringLength(10)]
        public string Die19 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Required]
        [Column("CCE_0")]
        [StringLength(15)]
        public string Cce0 { get; set; }
        [Required]
        [Column("CCE_1")]
        [StringLength(15)]
        public string Cce1 { get; set; }
        [Required]
        [Column("CCE_2")]
        [StringLength(15)]
        public string Cce2 { get; set; }
        [Required]
        [Column("CCE_3")]
        [StringLength(15)]
        public string Cce3 { get; set; }
        [Required]
        [Column("CCE_4")]
        [StringLength(15)]
        public string Cce4 { get; set; }
        [Required]
        [Column("CCE_5")]
        [StringLength(15)]
        public string Cce5 { get; set; }
        [Required]
        [Column("CCE_6")]
        [StringLength(15)]
        public string Cce6 { get; set; }
        [Required]
        [Column("CCE_7")]
        [StringLength(15)]
        public string Cce7 { get; set; }
        [Required]
        [Column("CCE_8")]
        [StringLength(15)]
        public string Cce8 { get; set; }
        [Required]
        [Column("CCE_9")]
        [StringLength(15)]
        public string Cce9 { get; set; }
        [Required]
        [Column("CCE_10")]
        [StringLength(15)]
        public string Cce10 { get; set; }
        [Required]
        [Column("CCE_11")]
        [StringLength(15)]
        public string Cce11 { get; set; }
        [Required]
        [Column("CCE_12")]
        [StringLength(15)]
        public string Cce12 { get; set; }
        [Required]
        [Column("CCE_13")]
        [StringLength(15)]
        public string Cce13 { get; set; }
        [Required]
        [Column("CCE_14")]
        [StringLength(15)]
        public string Cce14 { get; set; }
        [Required]
        [Column("CCE_15")]
        [StringLength(15)]
        public string Cce15 { get; set; }
        [Required]
        [Column("CCE_16")]
        [StringLength(15)]
        public string Cce16 { get; set; }
        [Required]
        [Column("CCE_17")]
        [StringLength(15)]
        public string Cce17 { get; set; }
        [Required]
        [Column("CCE_18")]
        [StringLength(15)]
        public string Cce18 { get; set; }
        [Required]
        [Column("CCE_19")]
        [StringLength(15)]
        public string Cce19 { get; set; }
        [Column("UVYDAY_0")]
        public byte Uvyday0 { get; set; }
        [Column("UVYDAY_1")]
        public byte Uvyday1 { get; set; }
        [Column("UVYDAY_2")]
        public byte Uvyday2 { get; set; }
        [Column("UVYDAY_3")]
        public byte Uvyday3 { get; set; }
        [Column("UVYDAY_4")]
        public byte Uvyday4 { get; set; }
        [Column("UVYDAY_5")]
        public byte Uvyday5 { get; set; }
        [Column("UVYDAY_6")]
        public byte Uvyday6 { get; set; }
        [Required]
        [Column("UVYCOD_0")]
        [StringLength(5)]
        public string Uvycod0 { get; set; }
        [Required]
        [Column("BPAADD_0")]
        [StringLength(7)]
        public string Bpaadd0 { get; set; }
        [Required]
        [Column("GEOCOD_0")]
        [StringLength(9)]
        public string Geocod0 { get; set; }
        [Required]
        [Column("INSCTYFLG_0")]
        [StringLength(1)]
        public string Insctyflg0 { get; set; }
        [Required]
        [Column("BIDNUM_0")]
        [StringLength(30)]
        public string Bidnum0 { get; set; }
        [Required]
        [Column("CNTNAM_0")]
        [StringLength(15)]
        public string Cntnam0 { get; set; }
        [Column("IVYFLG_0")]
        public short Ivyflg0 { get; set; }
        [Required]
        [Column("IVYFCY_0")]
        [StringLength(1)]
        public string Ivyfcy0 { get; set; }
        [Column("WRHGES_0")]
        public short Wrhges0 { get; set; }
        [Required]
        [Column("RCPWRH_0")]
        [StringLength(1)]
        public string Rcpwrh0 { get; set; }
        [Required]
        [Column("MFPWRH_0")]
        [StringLength(1)]
        public string Mfpwrh0 { get; set; }
        [Required]
        [Column("TRAWRH_0")]
        [StringLength(1)]
        public string Trawrh0 { get; set; }
        [Required]
        [Column("RTNWRH_0")]
        [StringLength(1)]
        public string Rtnwrh0 { get; set; }
        [Required]
        [Column("MFRWRH_0")]
        [StringLength(1)]
        public string Mfrwrh0 { get; set; }
        [Required]
        [Column("SHIWRH_0")]
        [StringLength(1)]
        public string Shiwrh0 { get; set; }
        [Required]
        [Column("MFGWRH_0")]
        [StringLength(1)]
        public string Mfgwrh0 { get; set; }
        [Required]
        [Column("TRFWRH_0")]
        [StringLength(1)]
        public string Trfwrh0 { get; set; }
        [Required]
        [Column("SCOWRH_0")]
        [StringLength(1)]
        public string Scowrh0 { get; set; }
        [Required]
        [Column("SCCWRH_0")]
        [StringLength(1)]
        public string Sccwrh0 { get; set; }
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
        [Column("XB_SHPINT_0")]
        public short XbShpint0 { get; set; }
        [Column("XB_UPSINT_0")]
        public short XbUpsint0 { get; set; }
        [Column("XB_FDXINT_0")]
        public short XbFdxint0 { get; set; }
        [Column("XA_SOFFSET_0")]
        public int XaSoffset0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}