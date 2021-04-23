﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BOMPRN", Schema = "TESTPROD")]
    [Index(nameof(Bopuid0), nameof(Bomalt0), nameof(Itmref0), nameof(Lig0), Name = "BOMPRN_BOP0", IsUnique = true)]
    public partial class Bomprn
    {
        [Column("BOPUID_0")]
        public int Bopuid0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("BOMALT_0")]
        public short Bomalt0 { get; set; }
        [Column("LIG_0")]
        public short Lig0 { get; set; }
        [Column("BOMSEQ_0")]
        public short Bomseq0 { get; set; }
        [Column("BOMSEQNUM_0")]
        public short Bomseqnum0 { get; set; }
        [Required]
        [Column("CPNITMREF_0")]
        [StringLength(20)]
        public string Cpnitmref0 { get; set; }
        [Column("CPNTYP_0")]
        public byte Cpntyp0 { get; set; }
        [Required]
        [Column("BOMSHO_0")]
        [StringLength(30)]
        public string Bomsho0 { get; set; }
        [Required]
        [Column("BOMSTRLOT_0")]
        [StringLength(15)]
        public string Bomstrlot0 { get; set; }
        [Required]
        [Column("BOMENDLOT_0")]
        [StringLength(15)]
        public string Bomendlot0 { get; set; }
        [Column("BOMSTRDAT_0", TypeName = "datetime")]
        public DateTime Bomstrdat0 { get; set; }
        [Column("BOMENDDAT_0", TypeName = "datetime")]
        public DateTime Bomenddat0 { get; set; }
        [Column("LIKQTYCOD_0")]
        public byte Likqtycod0 { get; set; }
        [Required]
        [Column("QTYRND_0")]
        [StringLength(10)]
        public string Qtyrnd0 { get; set; }
        [Column("BASQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Basqty0 { get; set; }
        [Column("LIKQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Likqty0 { get; set; }
        [Column("SCA_0", TypeName = "numeric(10, 4)")]
        public decimal Sca0 { get; set; }
        [Column("CPNOPE_0")]
        public short Cpnope0 { get; set; }
        [Column("OPENUMLEV_0")]
        public short Openumlev0 { get; set; }
        [Column("BOMOFS_0")]
        public short Bomofs0 { get; set; }
        [Column("PICPRN_0")]
        public byte Picprn0 { get; set; }
        [Column("OCNPRN_0")]
        public byte Ocnprn0 { get; set; }
        [Column("NDEPRN_0")]
        public byte Ndeprn0 { get; set; }
        [Column("INVPRN_0")]
        public byte Invprn0 { get; set; }
        [Required]
        [Column("LIKRLE_0")]
        [StringLength(10)]
        public string Likrle0 { get; set; }
        [Required]
        [Column("BOMTEXNUM_0")]
        [StringLength(12)]
        public string Bomtexnum0 { get; set; }
        [Column("BOMALTTYP_0")]
        public byte Bomalttyp0 { get; set; }
        [Column("GROQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Groqty0 { get; set; }
        [Column("NETQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Netqty0 { get; set; }
        [Column("NIV_0")]
        public short Niv0 { get; set; }
        [Column("PKC_0")]
        public short Pkc0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}