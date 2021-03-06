// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("CMARKETING", Schema = "TESTPROD")]
    [Index(nameof(Num0), Name = "CMARKETING_CMG0", IsUnique = true)]
    [Index(nameof(Datstr0), Name = "CMARKETING_CMG1")]
    public partial class Cmarketing
    {
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("TTR_0")]
        [StringLength(60)]
        public string Ttr0 { get; set; }
        [Column("DATSTR_0", TypeName = "datetime")]
        public DateTime Datstr0 { get; set; }
        [Column("DATEND_0", TypeName = "datetime")]
        public DateTime Datend0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(250)]
        public string Des0 { get; set; }
        [Required]
        [Column("TYPFULOBJ_0")]
        [StringLength(10)]
        public string Typfulobj0 { get; set; }
        [Required]
        [Column("NUMFULOBJ_0")]
        [StringLength(30)]
        public string Numfulobj0 { get; set; }
        [Column("OBJFLG_0")]
        public short Objflg0 { get; set; }
        [Column("BUD_0", TypeName = "numeric(27, 13)")]
        public decimal Bud0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("CLO_0")]
        public byte Clo0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREHOU_0")]
        [StringLength(5)]
        public string Crehou0 { get; set; }
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