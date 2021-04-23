﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("SVCRVAT", Schema = "TESTPROD")]
    [Index(nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vat0), Name = "SVCRVAT_SVV0", IsUnique = true)]
    [Index(nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vattyp0), nameof(Vat0), Name = "SVCRVAT_SVV1", IsUnique = true)]
    [Index(nameof(Num0), nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vat0), Name = "SVCRVAT_SVV2", IsUnique = true)]
    public partial class Svcrvat
    {
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Required]
        [Column("VAT_0")]
        [StringLength(5)]
        public string Vat0 { get; set; }
        [Column("VATTYP_0")]
        public byte Vattyp0 { get; set; }
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Column("VATRAT_0", TypeName = "numeric(16, 7)")]
        public decimal Vatrat0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("BASTAX_0", TypeName = "numeric(27, 13)")]
        public decimal Bastax0 { get; set; }
        [Column("AMTTAX_0", TypeName = "numeric(27, 13)")]
        public decimal Amttax0 { get; set; }
        [Column("THEAMTTAX_0", TypeName = "numeric(28, 8)")]
        public decimal Theamttax0 { get; set; }
        [Column("EXEAMTTAX_0", TypeName = "numeric(27, 13)")]
        public decimal Exeamttax0 { get; set; }
        [Column("VATGRO_0", TypeName = "numeric(27, 13)")]
        public decimal Vatgro0 { get; set; }
        [Column("VATNET_0", TypeName = "numeric(27, 13)")]
        public decimal Vatnet0 { get; set; }
        [Column("VATAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Vatamt0 { get; set; }
        [Column("VATSUPAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Vatsupamt0 { get; set; }
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