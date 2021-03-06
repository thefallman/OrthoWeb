// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("CONTREWX", Schema = "TESTPROD")]
    [Index(nameof(Connum0), nameof(Rewrecnumx0), nameof(Pronum0), Name = "CONTREWX_CRX0", IsUnique = true)]
    public partial class Contrewx
    {
        [Required]
        [Column("CONNUM_0")]
        [StringLength(20)]
        public string Connum0 { get; set; }
        [Column("PRONUM_0")]
        public int Pronum0 { get; set; }
        [Column("REWRECNUMX_0")]
        public int Rewrecnumx0 { get; set; }
        [Column("REWSTR_0", TypeName = "datetime")]
        public DateTime Rewstr0 { get; set; }
        [Column("REWEND_0", TypeName = "datetime")]
        public DateTime Rewend0 { get; set; }
        [Column("REWMAN_0")]
        public short Rewman0 { get; set; }
        [Required]
        [Column("INVNUM_0")]
        [StringLength(20)]
        public string Invnum0 { get; set; }
        [Column("PRONUMINV_0")]
        public int Pronuminv0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}