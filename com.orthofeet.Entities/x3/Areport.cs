﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AREPORT", Schema = "TESTPROD")]
    [Index(nameof(Rptcod0), Name = "AREPORT_ARP0", IsUnique = true)]
    [Index(nameof(Grp0), nameof(Rptcod0), Name = "AREPORT_ARP1", IsUnique = true)]
    public partial class Areport
    {
        [Required]
        [Column("RPTCOD_0")]
        [StringLength(15)]
        public string Rptcod0 { get; set; }
        [Column("GRP_0")]
        public byte Grp0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Required]
        [Column("LAN_0")]
        [StringLength(3)]
        public string Lan0 { get; set; }
        [Column("MULLAN_0")]
        public byte Mullan0 { get; set; }
        [Column("RPTDES_0")]
        public int Rptdes0 { get; set; }
        [Column("RPTSHO_0")]
        public int Rptsho0 { get; set; }
        [Column("ORIENT_0")]
        public byte Orient0 { get; set; }
        [Column("ORIENT_1")]
        public byte Orient1 { get; set; }
        [Column("ORIENT_2")]
        public byte Orient2 { get; set; }
        [Column("ORIENT_3")]
        public byte Orient3 { get; set; }
        [Column("ORIENT_4")]
        public byte Orient4 { get; set; }
        [Required]
        [Column("CRYCOD_0")]
        [StringLength(20)]
        public string Crycod0 { get; set; }
        [Required]
        [Column("CRYCOD_1")]
        [StringLength(20)]
        public string Crycod1 { get; set; }
        [Required]
        [Column("CRYCOD_2")]
        [StringLength(20)]
        public string Crycod2 { get; set; }
        [Required]
        [Column("CRYCOD_3")]
        [StringLength(20)]
        public string Crycod3 { get; set; }
        [Required]
        [Column("CRYCOD_4")]
        [StringLength(20)]
        public string Crycod4 { get; set; }
        [Column("FORETA_0")]
        public byte Foreta0 { get; set; }
        [Column("FORETA_1")]
        public byte Foreta1 { get; set; }
        [Column("FORETA_2")]
        public byte Foreta2 { get; set; }
        [Column("FORETA_3")]
        public byte Foreta3 { get; set; }
        [Column("FORETA_4")]
        public byte Foreta4 { get; set; }
        [Required]
        [Column("TRTINI_0")]
        [StringLength(30)]
        public string Trtini0 { get; set; }
        [Required]
        [Column("TRTSPE_0")]
        [StringLength(30)]
        public string Trtspe0 { get; set; }
        [Column("EXEFLG_0")]
        public byte Exeflg0 { get; set; }
        [Required]
        [Column("FNC_0")]
        [StringLength(10)]
        public string Fnc0 { get; set; }
        [Column("AUZFCY_0")]
        public byte Auzfcy0 { get; set; }
        [Required]
        [Column("ACS_0")]
        [StringLength(10)]
        public string Acs0 { get; set; }
        [Required]
        [Column("PRTSRV_0")]
        [StringLength(30)]
        public string Prtsrv0 { get; set; }
        [Required]
        [Column("PRTNAM_0")]
        [StringLength(50)]
        public string Prtnam0 { get; set; }
        [Column("PRTOBL_0")]
        public byte Prtobl0 { get; set; }
        [Required]
        [Column("PRTDRV_0")]
        [StringLength(30)]
        public string Prtdrv0 { get; set; }
        [Required]
        [Column("PRTPOR_0")]
        [StringLength(30)]
        public string Prtpor0 { get; set; }
        [Required]
        [Column("PRTDES_0")]
        [StringLength(250)]
        public string Prtdes0 { get; set; }
        [Required]
        [Column("PRTDES_1")]
        [StringLength(250)]
        public string Prtdes1 { get; set; }
        [Required]
        [Column("PARSEG_0")]
        [StringLength(15)]
        public string Parseg0 { get; set; }
        [Column("PRTNAT_0")]
        public byte Prtnat0 { get; set; }
        [Required]
        [Column("PRTDEF_0")]
        [StringLength(10)]
        public string Prtdef0 { get; set; }
        [Required]
        [Column("PRTFRM_0")]
        [StringLength(250)]
        public string Prtfrm0 { get; set; }
        [Column("EXEBAT_0")]
        public byte Exebat0 { get; set; }
        [Required]
        [Column("HOR_0")]
        [StringLength(5)]
        public string Hor0 { get; set; }
        [Column("IMPLIE_0")]
        public byte Implie0 { get; set; }
        [Column("GESZPL_0")]
        public byte Geszpl0 { get; set; }
        [Required]
        [Column("CODZPL_0")]
        [StringLength(10)]
        public string Codzpl0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}