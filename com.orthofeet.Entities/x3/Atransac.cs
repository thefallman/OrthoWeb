﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ATRANSAC", Schema = "TESTPROD")]
    [Index(nameof(Cod0), Name = "ATRANSAC_ATN0", IsUnique = true)]
    [Index(nameof(Objges0), Name = "ATRANSAC_ATN1")]
    public partial class Atransac
    {
        [Required]
        [Column("COD_0")]
        [StringLength(10)]
        public string Cod0 { get; set; }
        [Column("DES_0")]
        public int Des0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Required]
        [Column("CODTRT_0")]
        [StringLength(30)]
        public string Codtrt0 { get; set; }
        [Required]
        [Column("OBJGES_0")]
        [StringLength(3)]
        public string Objges0 { get; set; }
        [Required]
        [Column("TBL_0")]
        [StringLength(12)]
        public string Tbl0 { get; set; }
        [Required]
        [Column("FLDCOD_0")]
        [StringLength(10)]
        public string Fldcod0 { get; set; }
        [Required]
        [Column("CND_0")]
        [StringLength(250)]
        public string Cnd0 { get; set; }
        [Column("COP_0")]
        public byte Cop0 { get; set; }
        [Required]
        [Column("OBJ_0")]
        [StringLength(3)]
        public string Obj0 { get; set; }
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