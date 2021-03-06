// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AVIEW", Schema = "TESTPROD")]
    [Index(nameof(Codvue0), Name = "AVIEW_AVW0", IsUnique = true)]
    [Index(nameof(Abrvue0), Name = "AVIEW_AVW1")]
    public partial class Aview
    {
        [Required]
        [Column("CODVUE_0")]
        [StringLength(12)]
        public string Codvue0 { get; set; }
        [Required]
        [Column("ABRVUE_0")]
        [StringLength(4)]
        public string Abrvue0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Column("UPDFLG_0")]
        public byte Updflg0 { get; set; }
        [Column("INTIT_0")]
        public int Intit0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Column("SECURE_0")]
        public byte Secure0 { get; set; }
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
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}