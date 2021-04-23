﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ITMBOM", Schema = "TESTPROD")]
    [Index(nameof(Itmref0), nameof(Bomalt0), nameof(Llctyp0), Name = "ITMBOM_ITB0", IsUnique = true)]
    [Index(nameof(Bomalt0), nameof(Llctyp0), nameof(Llc0), nameof(Itmref0), Name = "ITMBOM_ITB1", IsUnique = true)]
    public partial class Itmbom
    {
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("BOMALT_0")]
        public short Bomalt0 { get; set; }
        [Column("LLCTYP_0")]
        public byte Llctyp0 { get; set; }
        [Column("LLC_0")]
        public short Llc0 { get; set; }
        [Column("BOMEXIFLG_0")]
        public byte Bomexiflg0 { get; set; }
        [Column("WUSEXIFLG_0")]
        public byte Wusexiflg0 { get; set; }
        [Required]
        [Column("BOHITM_0")]
        [StringLength(20)]
        public string Bohitm0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
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