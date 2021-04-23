﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("OMMRESULT", Schema = "TESTPROD")]
    [Index(nameof(Opgnum0), nameof(Mrenum0), Name = "OMMRESULT_MRE0", IsUnique = true)]
    public partial class Ommresult
    {
        [Required]
        [Column("OPGNUM_0")]
        [StringLength(20)]
        public string Opgnum0 { get; set; }
        [Required]
        [Column("BPRNUM_0")]
        [StringLength(50)]
        public string Bprnum0 { get; set; }
        [Required]
        [Column("CCNNUM_0")]
        [StringLength(50)]
        public string Ccnnum0 { get; set; }
        [Required]
        [Column("MRENUM_0")]
        [StringLength(20)]
        public string Mrenum0 { get; set; }
        [Column("CLSNUM_0")]
        public int Clsnum0 { get; set; }
        [Required]
        [Column("CNTTTL_0")]
        [StringLength(50)]
        public string Cntttl0 { get; set; }
        [Required]
        [Column("CNTNAM_0")]
        [StringLength(85)]
        public string Cntnam0 { get; set; }
        [Required]
        [Column("BPRNAM_0")]
        [StringLength(50)]
        public string Bprnam0 { get; set; }
        [Required]
        [Column("ADD1_0")]
        [StringLength(50)]
        public string Add10 { get; set; }
        [Required]
        [Column("ADD2_0")]
        [StringLength(50)]
        public string Add20 { get; set; }
        [Required]
        [Column("ADD3_0")]
        [StringLength(50)]
        public string Add30 { get; set; }
        [Required]
        [Column("ZIP_0")]
        [StringLength(50)]
        public string Zip0 { get; set; }
        [Required]
        [Column("CTY_0")]
        [StringLength(50)]
        public string Cty0 { get; set; }
        [Required]
        [Column("CRY_0")]
        [StringLength(50)]
        public string Cry0 { get; set; }
        [Required]
        [Column("SAT_0")]
        [StringLength(50)]
        public string Sat0 { get; set; }
        [Required]
        [Column("TEL_0")]
        [StringLength(50)]
        public string Tel0 { get; set; }
        [Required]
        [Column("FAX_0")]
        [StringLength(50)]
        public string Fax0 { get; set; }
        [Required]
        [Column("WEB_0")]
        [StringLength(50)]
        public string Web0 { get; set; }
        [Required]
        [Column("REPNAM_0")]
        [StringLength(50)]
        public string Repnam0 { get; set; }
        [Required]
        [Column("REPFNC_0")]
        [StringLength(50)]
        public string Repfnc0 { get; set; }
        [Required]
        [Column("F599_0")]
        [StringLength(10)]
        public string F5990 { get; set; }
        [Required]
        [Column("F501_0")]
        [StringLength(10)]
        public string F5010 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}