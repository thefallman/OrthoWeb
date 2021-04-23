﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("CONTACTCRM", Schema = "TESTPROD")]
    [Index(nameof(Cntnum0), Name = "CONTACTCRM_AIN0", IsUnique = true)]
    [Index(nameof(Cntfulnam0), Name = "CONTACTCRM_AIN1")]
    [Index(nameof(Cnttyp0), nameof(Cntnum0), Name = "CONTACTCRM_AIN2", IsUnique = true)]
    public partial class Contactcrm
    {
        [Required]
        [Column("CNTNUM_0")]
        [StringLength(15)]
        public string Cntnum0 { get; set; }
        [Required]
        [Column("CNTFULNAM_0")]
        [StringLength(60)]
        public string Cntfulnam0 { get; set; }
        [Column("CNTTTL_0")]
        public byte Cntttl0 { get; set; }
        [Column("CNTTYP_0")]
        public byte Cnttyp0 { get; set; }
        [Required]
        [Column("CNTLNA_0")]
        [StringLength(35)]
        public string Cntlna0 { get; set; }
        [Required]
        [Column("CNTFNA_0")]
        [StringLength(20)]
        public string Cntfna0 { get; set; }
        [Column("CNTBIR_0", TypeName = "datetime")]
        public DateTime Cntbir0 { get; set; }
        [Required]
        [Column("CNTLAN_0")]
        [StringLength(3)]
        public string Cntlan0 { get; set; }
        [Required]
        [Column("CNTCSP_0")]
        [StringLength(20)]
        public string Cntcsp0 { get; set; }
        [Required]
        [Column("CRY_0")]
        [StringLength(3)]
        public string Cry0 { get; set; }
        [Required]
        [Column("CRYNAM_0")]
        [StringLength(40)]
        public string Crynam0 { get; set; }
        [Required]
        [Column("ADD_0")]
        [StringLength(40)]
        public string Add0 { get; set; }
        [Required]
        [Column("ADD_1")]
        [StringLength(40)]
        public string Add1 { get; set; }
        [Required]
        [Column("ADD_2")]
        [StringLength(40)]
        public string Add2 { get; set; }
        [Required]
        [Column("ZIP_0")]
        [StringLength(10)]
        public string Zip0 { get; set; }
        [Required]
        [Column("CTY_0")]
        [StringLength(40)]
        public string Cty0 { get; set; }
        [Required]
        [Column("SAT_0")]
        [StringLength(35)]
        public string Sat0 { get; set; }
        [Required]
        [Column("CNTETS_0")]
        [StringLength(20)]
        public string Cntets0 { get; set; }
        [Required]
        [Column("CNTFAX_0")]
        [StringLength(20)]
        public string Cntfax0 { get; set; }
        [Required]
        [Column("CNTMOB_0")]
        [StringLength(20)]
        public string Cntmob0 { get; set; }
        [Required]
        [Column("CNTEMA_0")]
        [StringLength(80)]
        public string Cntema0 { get; set; }
        [Column("CNTFBDMAG_0")]
        public byte Cntfbdmag0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Required]
        [Column("CRESTP_0")]
        [StringLength(14)]
        public string Crestp0 { get; set; }
        [Required]
        [Column("UPDSTP_0")]
        [StringLength(14)]
        public string Updstp0 { get; set; }
        [Required]
        [Column("IDTSGL_0")]
        [StringLength(36)]
        public string Idtsgl0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}