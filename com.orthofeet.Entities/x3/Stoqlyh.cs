﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("STOQLYH", Schema = "TESTPROD")]
    [Index(nameof(Vcrtyp0), nameof(Vcrnum0), Name = "STOQLYH_QLH0", IsUnique = true)]
    [Index(nameof(Stofcy0), nameof(Itmref0), nameof(Vcrnum0), Name = "STOQLYH_QLH1", IsUnique = true)]
    [Index(nameof(Valflg0), nameof(Vcrtyp0), nameof(Vcrnum0), Name = "STOQLYH_QLH2", IsUnique = true)]
    [Index(nameof(Vcrtypori0), nameof(Vcrnumori0), nameof(Itmref0), Name = "STOQLYH_QLH3")]
    public partial class Stoqlyh
    {
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("VCRTYPORI_0")]
        public byte Vcrtypori0 { get; set; }
        [Required]
        [Column("VCRNUMORI_0")]
        [StringLength(20)]
        public string Vcrnumori0 { get; set; }
        [Required]
        [Column("TRSFAM_0")]
        [StringLength(20)]
        public string Trsfam0 { get; set; }
        [Required]
        [Column("PJT_0")]
        [StringLength(20)]
        public string Pjt0 { get; set; }
        [Required]
        [Column("TRSCOD_0")]
        [StringLength(20)]
        public string Trscod0 { get; set; }
        [Column("ENDCTLDAT_0", TypeName = "datetime")]
        public DateTime Endctldat0 { get; set; }
        [Required]
        [Column("QLYCRD_0")]
        [StringLength(8)]
        public string Qlycrd0 { get; set; }
        [Column("VALFLG_0")]
        public byte Valflg0 { get; set; }
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
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}