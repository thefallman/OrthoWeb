﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SPPRTCONF", Schema = "TESTPROD")]
    [Index(nameof(Cod0), Name = "SPPRTCONF_SPP0", IsUnique = true)]
    public partial class Spprtconf
    {
        [Required]
        [Column("COD_0")]
        [StringLength(10)]
        public string Cod0 { get; set; }
        [Required]
        [Column("LANDESSHO_0")]
        [StringLength(60)]
        public string Landessho0 { get; set; }
        [Column("DAT_0", TypeName = "datetime")]
        public DateTime Dat0 { get; set; }
        [Required]
        [Column("BPCSTR_0")]
        [StringLength(15)]
        public string Bpcstr0 { get; set; }
        [Required]
        [Column("BPCEND_0")]
        [StringLength(15)]
        public string Bpcend0 { get; set; }
        [Required]
        [Column("BPCCRI_0")]
        [StringLength(150)]
        public string Bpccri0 { get; set; }
        [Required]
        [Column("BPRCRI_0")]
        [StringLength(150)]
        public string Bprcri0 { get; set; }
        [Required]
        [Column("ITMSTR_0")]
        [StringLength(20)]
        public string Itmstr0 { get; set; }
        [Required]
        [Column("ITMEND_0")]
        [StringLength(20)]
        public string Itmend0 { get; set; }
        [Required]
        [Column("ITMCRI_0")]
        [StringLength(150)]
        public string Itmcri0 { get; set; }
        [Required]
        [Column("ITSCRI_0")]
        [StringLength(150)]
        public string Itscri0 { get; set; }
        [Column("FLGCUR_0")]
        public byte Flgcur0 { get; set; }
        [Column("FLGPRITYP_0")]
        public byte Flgprityp0 { get; set; }
        [Column("FLGCHGTYP_0")]
        public byte Flgchgtyp0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("PRITYP_0")]
        public byte Prityp0 { get; set; }
        [Column("CHGTYP_0")]
        public byte Chgtyp0 { get; set; }
        [Required]
        [Column("SALFCY_0")]
        [StringLength(5)]
        public string Salfcy0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("PLISTC_0")]
        [StringLength(10)]
        public string Plistc0 { get; set; }
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