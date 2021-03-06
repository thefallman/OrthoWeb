// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AROLE", Schema = "TESTPROD")]
    [Index(nameof(Obj0), nameof(Rol0), Name = "AROLE_ARL0", IsUnique = true)]
    [Index(nameof(Rol0), nameof(Obj0), Name = "AROLE_ARL1", IsUnique = true)]
    public partial class Arole
    {
        [Required]
        [Column("ROL_0")]
        [StringLength(20)]
        public string Rol0 { get; set; }
        [Required]
        [Column("OBJ_0")]
        [StringLength(3)]
        public string Obj0 { get; set; }
        [Required]
        [Column("FLD_0")]
        [StringLength(15)]
        public string Fld0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}