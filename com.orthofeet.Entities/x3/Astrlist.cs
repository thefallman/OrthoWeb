﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ASTRLIST", Schema = "TESTPROD")]
    [Index(nameof(Cod0), Name = "ASTRLIST_ASJ0", IsUnique = true)]
    [Index(nameof(Modele0), nameof(Cod0), Name = "ASTRLIST_ASJ1")]
    public partial class Astrlist
    {
        [Required]
        [Column("COD_0")]
        [StringLength(6)]
        public string Cod0 { get; set; }
        [Column("INTLIST_0")]
        public int Intlist0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Required]
        [Column("MODELE_0")]
        [StringLength(10)]
        public string Modele0 { get; set; }
        [Required]
        [Column("STRORI_0")]
        [StringLength(10)]
        public string Strori0 { get; set; }
        [Column("NBRLNK_0")]
        public short Nbrlnk0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Column("NBRFLD_0")]
        public short Nbrfld0 { get; set; }
        [Column("ROWCNT_0")]
        public byte Rowcnt0 { get; set; }
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
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}