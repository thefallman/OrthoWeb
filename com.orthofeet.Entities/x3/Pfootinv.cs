﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PFOOTINV", Schema = "TESTPROD")]
    [Index(nameof(Pfinum0), Name = "PFOOTINV_PFI0", IsUnique = true)]
    public partial class Pfootinv
    {
        [Column("PFINUM_0")]
        public short Pfinum0 { get; set; }
        [Required]
        [Column("PFINUMCAR_0")]
        [StringLength(3)]
        public string Pfinumcar0 { get; set; }
        [Required]
        [Column("LANDESSHO_0")]
        [StringLength(50)]
        public string Landessho0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Column("DISVATFLG_0")]
        public short Disvatflg0 { get; set; }
        [Column("AMTCOD_0")]
        public byte Amtcod0 { get; set; }
        [Column("INCDCR_0")]
        public byte Incdcr0 { get; set; }
        [Column("DACLIN_0")]
        public byte Daclin0 { get; set; }
        [Column("DACORD_0")]
        public byte Dacord0 { get; set; }
        [Column("BPSORI_0")]
        public byte Bpsori0 { get; set; }
        [Column("DEFVAL_0", TypeName = "numeric(20, 5)")]
        public decimal Defval0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("TRFINV_0")]
        public byte Trfinv0 { get; set; }
        [Column("DSPLIN_0")]
        public byte Dsplin0 { get; set; }
        [Column("NPRVLT_0")]
        public byte Nprvlt0 { get; set; }
        [Column("CLCBAS_0")]
        public byte Clcbas0 { get; set; }
        [Required]
        [Column("ACTCLCBAS_0")]
        [StringLength(10)]
        public string Actclcbas0 { get; set; }
        [Required]
        [Column("PRGCLCBAS_0")]
        [StringLength(10)]
        public string Prgclcbas0 { get; set; }
        [Column("CLCORD_0")]
        public short Clcord0 { get; set; }
        [Column("CLCDEB_0")]
        public short Clcdeb0 { get; set; }
        [Column("VATRUL_0")]
        public byte Vatrul0 { get; set; }
        [Required]
        [Column("VACITM_0")]
        [StringLength(20)]
        public string Vacitm0 { get; set; }
        [Required]
        [Column("ACCCOD_0")]
        [StringLength(10)]
        public string Acccod0 { get; set; }
        [Required]
        [Column("DSP_0")]
        [StringLength(10)]
        public string Dsp0 { get; set; }
        [Required]
        [Column("DIE_0")]
        [StringLength(3)]
        public string Die0 { get; set; }
        [Required]
        [Column("DIE_1")]
        [StringLength(3)]
        public string Die1 { get; set; }
        [Required]
        [Column("DIE_2")]
        [StringLength(3)]
        public string Die2 { get; set; }
        [Required]
        [Column("DIE_3")]
        [StringLength(3)]
        public string Die3 { get; set; }
        [Required]
        [Column("DIE_4")]
        [StringLength(3)]
        public string Die4 { get; set; }
        [Required]
        [Column("DIE_5")]
        [StringLength(3)]
        public string Die5 { get; set; }
        [Required]
        [Column("DIE_6")]
        [StringLength(3)]
        public string Die6 { get; set; }
        [Required]
        [Column("DIE_7")]
        [StringLength(3)]
        public string Die7 { get; set; }
        [Required]
        [Column("DIE_8")]
        [StringLength(3)]
        public string Die8 { get; set; }
        [Required]
        [Column("DIE_9")]
        [StringLength(3)]
        public string Die9 { get; set; }
        [Required]
        [Column("DIE_10")]
        [StringLength(3)]
        public string Die10 { get; set; }
        [Required]
        [Column("DIE_11")]
        [StringLength(3)]
        public string Die11 { get; set; }
        [Required]
        [Column("DIE_12")]
        [StringLength(3)]
        public string Die12 { get; set; }
        [Required]
        [Column("DIE_13")]
        [StringLength(3)]
        public string Die13 { get; set; }
        [Required]
        [Column("DIE_14")]
        [StringLength(3)]
        public string Die14 { get; set; }
        [Required]
        [Column("DIE_15")]
        [StringLength(3)]
        public string Die15 { get; set; }
        [Required]
        [Column("DIE_16")]
        [StringLength(3)]
        public string Die16 { get; set; }
        [Required]
        [Column("DIE_17")]
        [StringLength(3)]
        public string Die17 { get; set; }
        [Required]
        [Column("DIE_18")]
        [StringLength(3)]
        public string Die18 { get; set; }
        [Required]
        [Column("DIE_19")]
        [StringLength(3)]
        public string Die19 { get; set; }
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