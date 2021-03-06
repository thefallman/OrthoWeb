// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AELT", Schema = "TESTPROD")]
    [Index(nameof(Elttyp0), nameof(Elt0), nameof(Eltlan0), Name = "AELT_ELT0", IsUnique = true)]
    [Index(nameof(Elttyp0), nameof(Eltinv0), nameof(Elt0), nameof(Eltlan0), Name = "AELT_ELT1", IsUnique = true)]
    public partial class Aelt
    {
        [Required]
        [Column("ELTTYP_0")]
        [StringLength(4)]
        public string Elttyp0 { get; set; }
        [Required]
        [Column("ELT_0")]
        [StringLength(14)]
        public string Elt0 { get; set; }
        [Required]
        [Column("ELTLAN_0")]
        [StringLength(3)]
        public string Eltlan0 { get; set; }
        [Required]
        [Column("ELTSTP_0")]
        [StringLength(14)]
        public string Eltstp0 { get; set; }
        [Required]
        [Column("ELTINV_0")]
        [StringLength(1)]
        public string Eltinv0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}