// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("XCSPSMSG", Schema = "TESTPROD")]
    [Index(nameof(Resptype0), nameof(Respcode0), Name = "XCSPSMSG_XCE0", IsUnique = true)]
    public partial class Xcspsmsg
    {
        [Required]
        [Column("RESPTYPE_0")]
        [StringLength(10)]
        public string Resptype0 { get; set; }
        [Required]
        [Column("RESPCODE_0")]
        [StringLength(10)]
        public string Respcode0 { get; set; }
        [Required]
        [Column("XRESPMSG_0")]
        [StringLength(200)]
        public string Xrespmsg0 { get; set; }
        [Required]
        [Column("SUMMARY_0")]
        [StringLength(20)]
        public string Summary0 { get; set; }
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
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}