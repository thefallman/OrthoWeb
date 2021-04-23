﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TXSW", Schema = "TESTPROD")]
    [Index(nameof(Lstgrp0), nameof(Txsnam0), nameof(Version0), Name = "TXSW_TXW0", IsUnique = true)]
    [Index(nameof(Txsnam0), nameof(Version0), Name = "TXSW_TXW1", IsUnique = true)]
    public partial class Txsw
    {
        [Required]
        [Column("LSTGRP_0")]
        [StringLength(8)]
        public string Lstgrp0 { get; set; }
        [Required]
        [Column("TXSNAM_0")]
        [StringLength(10)]
        public string Txsnam0 { get; set; }
        [Required]
        [Column("VERSION_0")]
        [StringLength(15)]
        public string Version0 { get; set; }
        [Required]
        [Column("ACS_0")]
        [StringLength(10)]
        public string Acs0 { get; set; }
        [Required]
        [Column("VERDES_0")]
        [StringLength(30)]
        public string Verdes0 { get; set; }
        [Column("GENDAT_0", TypeName = "datetime")]
        public DateTime Gendat0 { get; set; }
        [Required]
        [Column("GENTIM_0")]
        [StringLength(8)]
        public string Gentim0 { get; set; }
        [Column("NBVAR_0")]
        public short Nbvar0 { get; set; }
        [Column("DETACC_0")]
        public byte Detacc0 { get; set; }
        [Column("DETBPR_0")]
        public byte Detbpr0 { get; set; }
        [Column("DETCCE_0")]
        public byte Detcce0 { get; set; }
        [Column("CENDET_0")]
        public byte Cendet0 { get; set; }
        [Required]
        [Column("TL_0")]
        [StringLength(30)]
        public string Tl0 { get; set; }
        [Required]
        [Column("TL_1")]
        [StringLength(30)]
        public string Tl1 { get; set; }
        [Required]
        [Column("TL_2")]
        [StringLength(30)]
        public string Tl2 { get; set; }
        [Required]
        [Column("TC_0")]
        [StringLength(30)]
        public string Tc0 { get; set; }
        [Required]
        [Column("TC_1")]
        [StringLength(30)]
        public string Tc1 { get; set; }
        [Required]
        [Column("TC_2")]
        [StringLength(30)]
        public string Tc2 { get; set; }
        [Required]
        [Column("TR_0")]
        [StringLength(30)]
        public string Tr0 { get; set; }
        [Required]
        [Column("TR_1")]
        [StringLength(30)]
        public string Tr1 { get; set; }
        [Required]
        [Column("TR_2")]
        [StringLength(30)]
        public string Tr2 { get; set; }
        [Required]
        [Column("FL_0")]
        [StringLength(30)]
        public string Fl0 { get; set; }
        [Required]
        [Column("FL_1")]
        [StringLength(30)]
        public string Fl1 { get; set; }
        [Required]
        [Column("FL_2")]
        [StringLength(30)]
        public string Fl2 { get; set; }
        [Required]
        [Column("FC_0")]
        [StringLength(30)]
        public string Fc0 { get; set; }
        [Required]
        [Column("FC_1")]
        [StringLength(30)]
        public string Fc1 { get; set; }
        [Required]
        [Column("FC_2")]
        [StringLength(30)]
        public string Fc2 { get; set; }
        [Required]
        [Column("FR_0")]
        [StringLength(30)]
        public string Fr0 { get; set; }
        [Required]
        [Column("FR_1")]
        [StringLength(30)]
        public string Fr1 { get; set; }
        [Required]
        [Column("FR_2")]
        [StringLength(30)]
        public string Fr2 { get; set; }
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