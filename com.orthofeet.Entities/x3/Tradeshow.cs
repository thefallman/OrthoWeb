﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TRADESHOW", Schema = "TESTPROD")]
    [Index(nameof(Omtnum0), Name = "TRADESHOW_OMT0", IsUnique = true)]
    [Index(nameof(Cmgnum0), Name = "TRADESHOW_OMT1")]
    public partial class Tradeshow
    {
        [Required]
        [Column("OMTNUM_0")]
        [StringLength(20)]
        public string Omtnum0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("CMGNUM_0")]
        [StringLength(20)]
        public string Cmgnum0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(60)]
        public string Des0 { get; set; }
        [Required]
        [Column("OBJ_0")]
        [StringLength(250)]
        public string Obj0 { get; set; }
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
        [Column("NEWPPTOBJ_0")]
        public int Newpptobj0 { get; set; }
        [Column("OMTSTR_0", TypeName = "datetime")]
        public DateTime Omtstr0 { get; set; }
        [Column("OMTEND_0", TypeName = "datetime")]
        public DateTime Omtend0 { get; set; }
        [Column("BOOSUR_0")]
        public int Boosur0 { get; set; }
        [Required]
        [Column("BOOSURBAS_0")]
        [StringLength(2)]
        public string Boosurbas0 { get; set; }
        [Column("BOOCST_0", TypeName = "numeric(27, 13)")]
        public decimal Boocst0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("OTHCST_0", TypeName = "numeric(27, 13)")]
        public decimal Othcst0 { get; set; }
        [Column("CLO_0")]
        public byte Clo0 { get; set; }
        [Column("CLODAT_0", TypeName = "datetime")]
        public DateTime Clodat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}