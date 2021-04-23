﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ANNUAIRE", Schema = "TESTPROD")]
    [Index(nameof(Cod0), Name = "ANNUAIRE_ANU0", IsUnique = true)]
    public partial class Annuaire
    {
        [Required]
        [Column("COD_0")]
        [StringLength(10)]
        public string Cod0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Required]
        [Column("DOMAIN_0")]
        [StringLength(50)]
        public string Domain0 { get; set; }
        [Required]
        [Column("SERV1_0")]
        [StringLength(80)]
        public string Serv10 { get; set; }
        [Required]
        [Column("SERV2_0")]
        [StringLength(80)]
        public string Serv20 { get; set; }
        [Column("PORT_0")]
        public int Port0 { get; set; }
        [Required]
        [Column("CONNEC_0")]
        [StringLength(250)]
        public string Connec0 { get; set; }
        [Required]
        [Column("PASSE_0")]
        [StringLength(50)]
        public string Passe0 { get; set; }
        [Required]
        [Column("PARAM1_0")]
        [StringLength(250)]
        public string Param10 { get; set; }
        [Required]
        [Column("PARAM2_0")]
        [StringLength(250)]
        public string Param20 { get; set; }
        [Column("NBRFLD_0")]
        public short Nbrfld0 { get; set; }
        [Column("TYPFLD_0")]
        public byte Typfld0 { get; set; }
        [Column("TYPFLD_1")]
        public byte Typfld1 { get; set; }
        [Column("TYPFLD_2")]
        public byte Typfld2 { get; set; }
        [Column("TYPFLD_3")]
        public byte Typfld3 { get; set; }
        [Column("TYPFLD_4")]
        public byte Typfld4 { get; set; }
        [Column("TYPFLD_5")]
        public byte Typfld5 { get; set; }
        [Column("TYPFLD_6")]
        public byte Typfld6 { get; set; }
        [Column("TYPFLD_7")]
        public byte Typfld7 { get; set; }
        [Column("TYPFLD_8")]
        public byte Typfld8 { get; set; }
        [Column("TYPFLD_9")]
        public byte Typfld9 { get; set; }
        [Column("TYPFLD_10")]
        public byte Typfld10 { get; set; }
        [Column("TYPFLD_11")]
        public byte Typfld11 { get; set; }
        [Column("TYPFLD_12")]
        public byte Typfld12 { get; set; }
        [Column("TYPFLD_13")]
        public byte Typfld13 { get; set; }
        [Column("TYPFLD_14")]
        public byte Typfld14 { get; set; }
        [Column("TYPFLD_15")]
        public byte Typfld15 { get; set; }
        [Column("TYPFLD_16")]
        public byte Typfld16 { get; set; }
        [Column("TYPFLD_17")]
        public byte Typfld17 { get; set; }
        [Column("TYPFLD_18")]
        public byte Typfld18 { get; set; }
        [Column("TYPFLD_19")]
        public byte Typfld19 { get; set; }
        [Required]
        [Column("CODFLD_0")]
        [StringLength(12)]
        public string Codfld0 { get; set; }
        [Required]
        [Column("CODFLD_1")]
        [StringLength(12)]
        public string Codfld1 { get; set; }
        [Required]
        [Column("CODFLD_2")]
        [StringLength(12)]
        public string Codfld2 { get; set; }
        [Required]
        [Column("CODFLD_3")]
        [StringLength(12)]
        public string Codfld3 { get; set; }
        [Required]
        [Column("CODFLD_4")]
        [StringLength(12)]
        public string Codfld4 { get; set; }
        [Required]
        [Column("CODFLD_5")]
        [StringLength(12)]
        public string Codfld5 { get; set; }
        [Required]
        [Column("CODFLD_6")]
        [StringLength(12)]
        public string Codfld6 { get; set; }
        [Required]
        [Column("CODFLD_7")]
        [StringLength(12)]
        public string Codfld7 { get; set; }
        [Required]
        [Column("CODFLD_8")]
        [StringLength(12)]
        public string Codfld8 { get; set; }
        [Required]
        [Column("CODFLD_9")]
        [StringLength(12)]
        public string Codfld9 { get; set; }
        [Required]
        [Column("CODFLD_10")]
        [StringLength(12)]
        public string Codfld10 { get; set; }
        [Required]
        [Column("CODFLD_11")]
        [StringLength(12)]
        public string Codfld11 { get; set; }
        [Required]
        [Column("CODFLD_12")]
        [StringLength(12)]
        public string Codfld12 { get; set; }
        [Required]
        [Column("CODFLD_13")]
        [StringLength(12)]
        public string Codfld13 { get; set; }
        [Required]
        [Column("CODFLD_14")]
        [StringLength(12)]
        public string Codfld14 { get; set; }
        [Required]
        [Column("CODFLD_15")]
        [StringLength(12)]
        public string Codfld15 { get; set; }
        [Required]
        [Column("CODFLD_16")]
        [StringLength(12)]
        public string Codfld16 { get; set; }
        [Required]
        [Column("CODFLD_17")]
        [StringLength(12)]
        public string Codfld17 { get; set; }
        [Required]
        [Column("CODFLD_18")]
        [StringLength(12)]
        public string Codfld18 { get; set; }
        [Required]
        [Column("CODFLD_19")]
        [StringLength(12)]
        public string Codfld19 { get; set; }
        [Required]
        [Column("ADDFLD_0")]
        [StringLength(30)]
        public string Addfld0 { get; set; }
        [Required]
        [Column("ADDFLD_1")]
        [StringLength(30)]
        public string Addfld1 { get; set; }
        [Required]
        [Column("ADDFLD_2")]
        [StringLength(30)]
        public string Addfld2 { get; set; }
        [Required]
        [Column("ADDFLD_3")]
        [StringLength(30)]
        public string Addfld3 { get; set; }
        [Required]
        [Column("ADDFLD_4")]
        [StringLength(30)]
        public string Addfld4 { get; set; }
        [Required]
        [Column("ADDFLD_5")]
        [StringLength(30)]
        public string Addfld5 { get; set; }
        [Required]
        [Column("ADDFLD_6")]
        [StringLength(30)]
        public string Addfld6 { get; set; }
        [Required]
        [Column("ADDFLD_7")]
        [StringLength(30)]
        public string Addfld7 { get; set; }
        [Required]
        [Column("ADDFLD_8")]
        [StringLength(30)]
        public string Addfld8 { get; set; }
        [Required]
        [Column("ADDFLD_9")]
        [StringLength(30)]
        public string Addfld9 { get; set; }
        [Required]
        [Column("ADDFLD_10")]
        [StringLength(30)]
        public string Addfld10 { get; set; }
        [Required]
        [Column("ADDFLD_11")]
        [StringLength(30)]
        public string Addfld11 { get; set; }
        [Required]
        [Column("ADDFLD_12")]
        [StringLength(30)]
        public string Addfld12 { get; set; }
        [Required]
        [Column("ADDFLD_13")]
        [StringLength(30)]
        public string Addfld13 { get; set; }
        [Required]
        [Column("ADDFLD_14")]
        [StringLength(30)]
        public string Addfld14 { get; set; }
        [Required]
        [Column("ADDFLD_15")]
        [StringLength(30)]
        public string Addfld15 { get; set; }
        [Required]
        [Column("ADDFLD_16")]
        [StringLength(30)]
        public string Addfld16 { get; set; }
        [Required]
        [Column("ADDFLD_17")]
        [StringLength(30)]
        public string Addfld17 { get; set; }
        [Required]
        [Column("ADDFLD_18")]
        [StringLength(30)]
        public string Addfld18 { get; set; }
        [Required]
        [Column("ADDFLD_19")]
        [StringLength(30)]
        public string Addfld19 { get; set; }
        [Required]
        [Column("FORFLD_0")]
        [StringLength(250)]
        public string Forfld0 { get; set; }
        [Required]
        [Column("FORFLD_1")]
        [StringLength(250)]
        public string Forfld1 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}