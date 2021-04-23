﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XCTXNLOG", Schema = "TESTPROD")]
    [Index(nameof(Txnid0), nameof(Credat0), nameof(Cretim0), Name = "XCTXNLOG_XCR0")]
    [Index(nameof(Ref10), nameof(Credat0), nameof(Cretim0), Name = "XCTXNLOG_XCR1")]
    [Index(nameof(Ref20), nameof(Credat0), nameof(Cretim0), Name = "XCTXNLOG_XCR2")]
    [Index(nameof(Vanref0), nameof(Credat0), nameof(Cretim0), Name = "XCTXNLOG_XCR3")]
    [Index(nameof(Ref10), nameof(Ref20), nameof(Txntyp0), Name = "XCTXNLOG_XCR4")]
    public partial class Xctxnlog
    {
        [Required]
        [Column("RESPIND_0")]
        [StringLength(1)]
        public string Respind0 { get; set; }
        [Required]
        [Column("RESPCODE_0")]
        [StringLength(6)]
        public string Respcode0 { get; set; }
        [Required]
        [Column("RESPMSG_0")]
        [StringLength(100)]
        public string Respmsg0 { get; set; }
        [Required]
        [Column("AUTHCODE_0")]
        [StringLength(6)]
        public string Authcode0 { get; set; }
        [Required]
        [Column("CVVRES_0")]
        [StringLength(1)]
        public string Cvvres0 { get; set; }
        [Required]
        [Column("VANREF_0")]
        [StringLength(10)]
        public string Vanref0 { get; set; }
        [Required]
        [Column("TXNID_0")]
        [StringLength(40)]
        public string Txnid0 { get; set; }
        [Required]
        [Column("CCL4D_0")]
        [StringLength(4)]
        public string Ccl4d0 { get; set; }
        [Required]
        [Column("PAYDES_0")]
        [StringLength(20)]
        public string Paydes0 { get; set; }
        [Column("AMT_0", TypeName = "numeric(16, 3)")]
        public decimal Amt0 { get; set; }
        [Required]
        [Column("PAYTYPID_0")]
        [StringLength(3)]
        public string Paytypid0 { get; set; }
        [Required]
        [Column("REF1_0")]
        [StringLength(50)]
        public string Ref10 { get; set; }
        [Required]
        [Column("REF2_0")]
        [StringLength(50)]
        public string Ref20 { get; set; }
        [Required]
        [Column("TXNDATTIM_0")]
        [StringLength(25)]
        public string Txndattim0 { get; set; }
        [Required]
        [Column("CUSFNAM_0")]
        [StringLength(50)]
        public string Cusfnam0 { get; set; }
        [Required]
        [Column("CUSMI_0")]
        [StringLength(1)]
        public string Cusmi0 { get; set; }
        [Required]
        [Column("CUSLNAM_0")]
        [StringLength(50)]
        public string Cuslnam0 { get; set; }
        [Required]
        [Column("CUSADDLIN1_0")]
        [StringLength(50)]
        public string Cusaddlin10 { get; set; }
        [Required]
        [Column("CUSADDLIN2_0")]
        [StringLength(50)]
        public string Cusaddlin20 { get; set; }
        [Required]
        [Column("CUSCTY_0")]
        [StringLength(50)]
        public string Cuscty0 { get; set; }
        [Required]
        [Column("CUSSAT_0")]
        [StringLength(50)]
        public string Cussat0 { get; set; }
        [Required]
        [Column("CUSPOSCOD_0")]
        [StringLength(50)]
        public string Cusposcod0 { get; set; }
        [Required]
        [Column("CUSCRY_0")]
        [StringLength(50)]
        public string Cuscry0 { get; set; }
        [Required]
        [Column("CUSEMAIL_0")]
        [StringLength(250)]
        public string Cusemail0 { get; set; }
        [Required]
        [Column("CUSTEL_0")]
        [StringLength(50)]
        public string Custel0 { get; set; }
        [Required]
        [Column("CUSFAX_0")]
        [StringLength(50)]
        public string Cusfax0 { get; set; }
        [Required]
        [Column("TXNTYP_0")]
        [StringLength(2)]
        public string Txntyp0 { get; set; }
        [Required]
        [Column("TXNTYPDES_0")]
        [StringLength(30)]
        public string Txntypdes0 { get; set; }
        [Required]
        [Column("REQREP_0")]
        [StringLength(10)]
        public string Reqrep0 { get; set; }
        [Required]
        [Column("VLTGUID_0")]
        [StringLength(50)]
        public string Vltguid0 { get; set; }
        [Required]
        [Column("VLTVALTO_0")]
        [StringLength(10)]
        public string Vltvalto0 { get; set; }
        [Required]
        [Column("VLTLAST4_0")]
        [StringLength(20)]
        public string Vltlast40 { get; set; }
        [Required]
        [Column("VLTPAYDES_0")]
        [StringLength(30)]
        public string Vltpaydes0 { get; set; }
        [Required]
        [Column("VLTX3ID_0")]
        [StringLength(50)]
        public string Vltx3id0 { get; set; }
        [Required]
        [Column("VLTBPCPYR_0")]
        [StringLength(10)]
        public string Vltbpcpyr0 { get; set; }
        [Column("VLTCNTID_0")]
        public int Vltcntid0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("VLTPAYTYP_0")]
        [StringLength(5)]
        public string Vltpaytyp0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}