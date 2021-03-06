// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XCSPSCNT", Schema = "TESTPROD")]
    [Index(nameof(Bpcpyr0), nameof(Spscntid0), Name = "XCSPSCNT_XC80", IsUnique = true)]
    public partial class Xcspscnt
    {
        [Required]
        [Column("BPCPYR_0")]
        [StringLength(10)]
        public string Bpcpyr0 { get; set; }
        [Column("SPSCNTID_0")]
        public int Spscntid0 { get; set; }
        [Required]
        [Column("FIRSTNAME_0")]
        [StringLength(30)]
        public string Firstname0 { get; set; }
        [Required]
        [Column("INITIAL_0")]
        [StringLength(1)]
        public string Initial0 { get; set; }
        [Required]
        [Column("LASTNAME_0")]
        [StringLength(35)]
        public string Lastname0 { get; set; }
        [Required]
        [Column("ADDLIN_0")]
        [StringLength(40)]
        public string Addlin0 { get; set; }
        [Required]
        [Column("ADDLIN_1")]
        [StringLength(40)]
        public string Addlin1 { get; set; }
        [Required]
        [Column("ADDLIN_2")]
        [StringLength(40)]
        public string Addlin2 { get; set; }
        [Required]
        [Column("CTY_0")]
        [StringLength(40)]
        public string Cty0 { get; set; }
        [Required]
        [Column("SAT_0")]
        [StringLength(35)]
        public string Sat0 { get; set; }
        [Required]
        [Column("POSCOD_0")]
        [StringLength(10)]
        public string Poscod0 { get; set; }
        [Required]
        [Column("CRY_0")]
        [StringLength(3)]
        public string Cry0 { get; set; }
        [Required]
        [Column("TEL_0")]
        [StringLength(20)]
        public string Tel0 { get; set; }
        [Required]
        [Column("FAX_0")]
        [StringLength(20)]
        public string Fax0 { get; set; }
        [Required]
        [Column("EMAIL_0")]
        [StringLength(80)]
        public string Email0 { get; set; }
        [Required]
        [Column("CRDTYP_0")]
        [StringLength(20)]
        public string Crdtyp0 { get; set; }
        [Required]
        [Column("CCL4D_0")]
        [StringLength(4)]
        public string Ccl4d0 { get; set; }
        [Required]
        [Column("VLTGUID_0")]
        [StringLength(50)]
        public string Vltguid0 { get; set; }
        [Required]
        [Column("VLTID_0")]
        [StringLength(50)]
        public string Vltid0 { get; set; }
        [Required]
        [Column("CCMSK_0")]
        [StringLength(20)]
        public string Ccmsk0 { get; set; }
        [Column("VALTO_0", TypeName = "datetime")]
        public DateTime Valto0 { get; set; }
        [Required]
        [Column("SPSCRDTYP_0")]
        [StringLength(10)]
        public string Spscrdtyp0 { get; set; }
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
        [Required]
        [Column("NOTES_0")]
        [StringLength(200)]
        public string Notes0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}