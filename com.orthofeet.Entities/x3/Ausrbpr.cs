// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AUSRBPR", Schema = "TESTPROD")]
    [Index(nameof(Usr0), nameof(Bpr0), nameof(Rol0), Name = "AUSRBPR_AUB0", IsUnique = true)]
    public partial class Ausrbpr
    {
        [Required]
        [Column("USR_0")]
        [StringLength(5)]
        public string Usr0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(30)]
        public string Bpr0 { get; set; }
        [Required]
        [Column("ROL_0")]
        [StringLength(20)]
        public string Rol0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}