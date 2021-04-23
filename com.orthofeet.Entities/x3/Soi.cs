﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SOI", Schema = "TESTPROD")]
    [Index(nameof(Soinum0), Name = "SOI_SOI0", IsUnique = true)]
    [Index(nameof(Fwdsoi0), Name = "SOI_SOI1")]
    [Index(nameof(Cpy0), nameof(Fcy0), nameof(Bpr0), nameof(Soidat0), nameof(Soinum0), Name = "SOI_SOI2", IsUnique = true)]
    [Index(nameof(Cpy0), nameof(Bpr0), nameof(Cur0), nameof(Soinum0), Name = "SOI_SOI3", IsUnique = true)]
    [Index(nameof(Typsoi0), nameof(Numsoi0), nameof(Soinum0), Name = "SOI_SOI4", IsUnique = true)]
    public partial class Soi
    {
        [Required]
        [Column("SOINUM_0")]
        [StringLength(20)]
        public string Soinum0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(15)]
        public string Bpr0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("SAC_0")]
        [StringLength(4)]
        public string Sac0 { get; set; }
        [Column("BPRTYP_0")]
        public byte Bprtyp0 { get; set; }
        [Column("AMTCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Amtcur0 { get; set; }
        [Column("TPYPAYCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Tpypaycur0 { get; set; }
        [Column("DUDNBR_0")]
        public short Dudnbr0 { get; set; }
        [Column("SOIDAT_0", TypeName = "datetime")]
        public DateTime Soidat0 { get; set; }
        [Column("DUDDAT_0", TypeName = "datetime")]
        public DateTime Duddat0 { get; set; }
        [Required]
        [Column("PAM_0")]
        [StringLength(20)]
        public string Pam0 { get; set; }
        [Required]
        [Column("SOICOD_0")]
        [StringLength(3)]
        public string Soicod0 { get; set; }
        [Column("FLGPST_0")]
        public byte Flgpst0 { get; set; }
        [Required]
        [Column("TYPSOI_0")]
        [StringLength(5)]
        public string Typsoi0 { get; set; }
        [Required]
        [Column("NUMSOI_0")]
        [StringLength(20)]
        public string Numsoi0 { get; set; }
        [Column("FLGFWD_0")]
        public byte Flgfwd0 { get; set; }
        [Required]
        [Column("FWDSOI_0")]
        [StringLength(20)]
        public string Fwdsoi0 { get; set; }
        [Column("FLGFWDSOI_0")]
        public byte Flgfwdsoi0 { get; set; }
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
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Column("FLGPAZ_0")]
        public byte Flgpaz0 { get; set; }
        [Column("FLGFUP_0")]
        public byte Flgfup0 { get; set; }
        [Column("OD_0")]
        public byte Od0 { get; set; }
        [Required]
        [Column("BILVCR_0")]
        [StringLength(20)]
        public string Bilvcr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}