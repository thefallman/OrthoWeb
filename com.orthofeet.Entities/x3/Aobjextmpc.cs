// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AOBJEXTMPC", Schema = "TESTPROD")]
    [Index(nameof(Numlot0), nameof(Numlig0), Name = "AOBJEXTMPC_AOY0", IsUnique = true)]
    [Index(nameof(Numlot0), nameof(Numlig0), Name = "AOBJEXTMPC_AOY2", IsUnique = true)]
    public partial class Aobjextmpc
    {
        [Required]
        [Column("NUMLOT_0")]
        [StringLength(20)]
        public string Numlot0 { get; set; }
        [Column("NUMLIG_0", TypeName = "numeric(10, 1)")]
        public decimal Numlig0 { get; set; }
        [Required]
        [Column("FLDCLB_0")]
        public string Fldclb0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}