// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GAJOUSTA", Schema = "TESTPROD")]
    [Index(nameof(Cpy0), nameof(Jou0), Name = "GAJOUSTA_JST0", IsUnique = true)]
    public partial class Gajousta
    {
        [Required]
        [Column("JOU_0")]
        [StringLength(5)]
        public string Jou0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Column("OPGSTRDAT_0", TypeName = "datetime")]
        public DateTime Opgstrdat0 { get; set; }
        [Column("OPGENDDAT_0", TypeName = "datetime")]
        public DateTime Opgenddat0 { get; set; }
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
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}