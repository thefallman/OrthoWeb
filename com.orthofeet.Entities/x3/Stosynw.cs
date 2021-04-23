﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("STOSYNW", Schema = "TESTPROD")]
    [Index(nameof(Cunlisnum0), nameof(Stofcy0), nameof(Itmref0), nameof(Seq0), Name = "STOSYNW_SYW0", IsUnique = true)]
    [Index(nameof(Stofcy0), nameof(Itmref0), nameof(Lot0), nameof(Slo0), nameof(Loc0), nameof(Sta0), Name = "STOSYNW_SYW1")]
    [Index(nameof(Stofcy0), nameof(Itmref0), nameof(Sernum0), Name = "STOSYNW_SYW2")]
    public partial class Stosynw
    {
        [Required]
        [Column("CUNLISNUM_0")]
        [StringLength(20)]
        public string Cunlisnum0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("SEQ_0")]
        public int Seq0 { get; set; }
        [Required]
        [Column("LOT_0")]
        [StringLength(15)]
        public string Lot0 { get; set; }
        [Required]
        [Column("SLO_0")]
        [StringLength(5)]
        public string Slo0 { get; set; }
        [Required]
        [Column("LOC_0")]
        [StringLength(10)]
        public string Loc0 { get; set; }
        [Required]
        [Column("STA_0")]
        [StringLength(3)]
        public string Sta0 { get; set; }
        [Required]
        [Column("SERNUM_0")]
        [StringLength(20)]
        public string Sernum0 { get; set; }
        [Required]
        [Column("PALNUM_0")]
        [StringLength(10)]
        public string Palnum0 { get; set; }
        [Required]
        [Column("CTRNUM_0")]
        [StringLength(10)]
        public string Ctrnum0 { get; set; }
        [Required]
        [Column("QLYCTLDEM_0")]
        [StringLength(20)]
        public string Qlyctldem0 { get; set; }
        [Required]
        [Column("OWNER_0")]
        [StringLength(15)]
        public string Owner0 { get; set; }
        [Required]
        [Column("PCU_0")]
        [StringLength(3)]
        public string Pcu0 { get; set; }
        [Column("QTYPCUNEW_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypcunew0 { get; set; }
        [Column("PCUSTUCOE_0", TypeName = "numeric(18, 7)")]
        public decimal Pcustucoe0 { get; set; }
        [Column("QTYSTUNEW_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystunew0 { get; set; }
        [Required]
        [Column("BPSLOT_0")]
        [StringLength(15)]
        public string Bpslot0 { get; set; }
        [Required]
        [Column("USRFLD1_0")]
        [StringLength(20)]
        public string Usrfld10 { get; set; }
        [Required]
        [Column("USRFLD2_0")]
        [StringLength(10)]
        public string Usrfld20 { get; set; }
        [Column("USRFLD3_0", TypeName = "numeric(11, 1)")]
        public decimal Usrfld30 { get; set; }
        [Column("USRFLD4_0", TypeName = "datetime")]
        public DateTime Usrfld40 { get; set; }
        [Column("POT_0", TypeName = "numeric(14, 5)")]
        public decimal Pot0 { get; set; }
        [Column("ACT_0", TypeName = "numeric(14, 5)")]
        public decimal Act0 { get; set; }
        [Column("SHLDAT_0", TypeName = "datetime")]
        public DateTime Shldat0 { get; set; }
        [Required]
        [Column("BPRNUM_0")]
        [StringLength(15)]
        public string Bprnum0 { get; set; }
        [Column("STOCOU_0", TypeName = "numeric(11, 1)")]
        public decimal Stocou0 { get; set; }
        [Column("QTYSTUSTO_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystusto0 { get; set; }
        [Column("QTYPCUSTO_0", TypeName = "numeric(28, 13)")]
        public decimal Qtypcusto0 { get; set; }
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