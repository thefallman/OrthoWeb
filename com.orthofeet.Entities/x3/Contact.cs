﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("CONTACT", Schema = "TESTPROD")]
    [Index(nameof(Bpatyp0), nameof(Bpanum0), nameof(Ccncrm0), Name = "CONTACT_CNT0", IsUnique = true)]
    [Index(nameof(Ccncrm0), nameof(Bpatyp0), nameof(Bpanum0), Name = "CONTACT_CNT1", IsUnique = true)]
    [Index(nameof(Ccncrm0), Name = "CONTACT_CNT2")]
    public partial class Contact
    {
        [Column("BPATYP_0")]
        public byte Bpatyp0 { get; set; }
        [Required]
        [Column("BPANUM_0")]
        [StringLength(15)]
        public string Bpanum0 { get; set; }
        [Required]
        [Column("CCNCRM_0")]
        [StringLength(15)]
        public string Ccncrm0 { get; set; }
        [Column("CNTFNC_0")]
        public byte Cntfnc0 { get; set; }
        [Required]
        [Column("CNTSRV_0")]
        [StringLength(30)]
        public string Cntsrv0 { get; set; }
        [Required]
        [Column("CNTMSS_0")]
        [StringLength(20)]
        public string Cntmss0 { get; set; }
        [Required]
        [Column("BPAADD_0")]
        [StringLength(7)]
        public string Bpaadd0 { get; set; }
        [Required]
        [Column("TEL_0")]
        [StringLength(20)]
        public string Tel0 { get; set; }
        [Required]
        [Column("FAX_0")]
        [StringLength(20)]
        public string Fax0 { get; set; }
        [Required]
        [Column("WEB_0")]
        [StringLength(80)]
        public string Web0 { get; set; }
        [Required]
        [Column("MOB_0")]
        [StringLength(20)]
        public string Mob0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
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