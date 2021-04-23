﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("MAILING", Schema = "TESTPROD")]
    [Index(nameof(Ommnum0), Name = "MAILING_OMM0", IsUnique = true)]
    [Index(nameof(Cmgnum0), Name = "MAILING_OMM1")]
    [Index(nameof(Credat0), Name = "MAILING_OMM2")]
    public partial class Mailing
    {
        [Required]
        [Column("OMMNUM_0")]
        [StringLength(20)]
        public string Ommnum0 { get; set; }
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
        [Column("BUD_0", TypeName = "numeric(27, 13)")]
        public decimal Bud0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("SHIDAT_0", TypeName = "datetime")]
        public DateTime Shidat0 { get; set; }
        [Column("SHISTA_0")]
        public byte Shista0 { get; set; }
        [Column("SHIMOD_0")]
        public byte Shimod0 { get; set; }
        [Column("NBQSND_0")]
        public int Nbqsnd0 { get; set; }
        [Required]
        [Column("EMAOBC_0")]
        [StringLength(90)]
        public string Emaobc0 { get; set; }
        [Required]
        [Column("EMATEX_0")]
        [StringLength(250)]
        public string Ematex0 { get; set; }
        [Required]
        [Column("TPL_0")]
        [StringLength(50)]
        public string Tpl0 { get; set; }
        [Column("TYPMRG_0")]
        public byte Typmrg0 { get; set; }
        [Column("CREHIS_0")]
        public byte Crehis0 { get; set; }
        [Column("DEFADD_0")]
        public byte Defadd0 { get; set; }
        [Column("HIEBPR_0")]
        public byte Hiebpr0 { get; set; }
        [Required]
        [Column("TYPSEA_0")]
        [StringLength(3)]
        public string Typsea0 { get; set; }
        [Required]
        [Column("CNTTTR_0")]
        [StringLength(75)]
        public string Cntttr0 { get; set; }
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