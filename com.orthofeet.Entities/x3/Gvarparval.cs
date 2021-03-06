// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GVARPARVAL", Schema = "TESTPROD")]
    [Index(nameof(Cod0), nameof(Linnum0), nameof(Fld0), nameof(Codvar0), nameof(Codpar0), Name = "GVARPARVAL_GVV0", IsUnique = true)]
    public partial class Gvarparval
    {
        [Required]
        [Column("COD_0")]
        [StringLength(5)]
        public string Cod0 { get; set; }
        [Column("LINNUM_0")]
        public short Linnum0 { get; set; }
        [Required]
        [Column("FLD_0")]
        [StringLength(10)]
        public string Fld0 { get; set; }
        [Required]
        [Column("CODVAR_0")]
        [StringLength(10)]
        public string Codvar0 { get; set; }
        [Required]
        [Column("CODPAR_0")]
        [StringLength(10)]
        public string Codpar0 { get; set; }
        [Required]
        [Column("VALPAR_0")]
        [StringLength(80)]
        public string Valpar0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}