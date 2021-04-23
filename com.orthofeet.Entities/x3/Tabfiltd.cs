﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABFILTDS", Schema = "TESTPROD")]
    [Index(nameof(Cod0), nameof(Rectyp0), nameof(Num0), Name = "TABFILTDS_TFT0", IsUnique = true)]
    public partial class Tabfiltd
    {
        [Required]
        [Column("COD_0")]
        [StringLength(10)]
        public string Cod0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Required]
        [Column("DESSHO_0")]
        [StringLength(10)]
        public string Dessho0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Required]
        [Column("FILREF_0")]
        [StringLength(2)]
        public string Filref0 { get; set; }
        [Column("RECTYP_0")]
        public byte Rectyp0 { get; set; }
        [Column("NUM_0")]
        public short Num0 { get; set; }
        [Column("LNG_0")]
        public short Lng0 { get; set; }
        [Column("FLDTYP_0")]
        public byte Fldtyp0 { get; set; }
        [Required]
        [Column("FRM_0")]
        [StringLength(80)]
        public string Frm0 { get; set; }
        [Required]
        [Column("DESLIN_0")]
        [StringLength(30)]
        public string Deslin0 { get; set; }
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