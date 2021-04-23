﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ADOPAR", Schema = "TESTPROD")]
    [Index(nameof(Chapitre0), nameof(Param0), Name = "ADOPAR_ADP0", IsUnique = true)]
    [Index(nameof(Param0), Name = "ADOPAR_ADP1", IsUnique = true)]
    [Index(nameof(Chapitre0), nameof(Rang0), nameof(Param0), Name = "ADOPAR_ADP3", IsUnique = true)]
    [Index(nameof(Objet0), nameof(Param0), Name = "ADOPAR_ADP4", IsUnique = true)]
    [Index(nameof(Chapitre0), nameof(Grppar0), nameof(Param0), Name = "ADOPAR_ADP5", IsUnique = true)]
    public partial class Adopar
    {
        [Required]
        [Column("CHAPITRE_0")]
        [StringLength(20)]
        public string Chapitre0 { get; set; }
        [Required]
        [Column("PARAM_0")]
        [StringLength(10)]
        public string Param0 { get; set; }
        [Required]
        [Column("GRPPAR_0")]
        [StringLength(20)]
        public string Grppar0 { get; set; }
        [Column("NAM_0")]
        public int Nam0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Column("TYPVAL_0")]
        public byte Typval0 { get; set; }
        [Column("MODIF_0")]
        public byte Modif0 { get; set; }
        [Column("NOLIB_0")]
        public short Nolib0 { get; set; }
        [Column("NIVDEF_0")]
        public byte Nivdef0 { get; set; }
        [Required]
        [Column("VALUES_0")]
        [StringLength(10)]
        public string Values0 { get; set; }
        [Required]
        [Column("VALUES_1")]
        [StringLength(10)]
        public string Values1 { get; set; }
        [Required]
        [Column("VALUES_2")]
        [StringLength(10)]
        public string Values2 { get; set; }
        [Required]
        [Column("VALUES_3")]
        [StringLength(10)]
        public string Values3 { get; set; }
        [Required]
        [Column("VALUES_4")]
        [StringLength(10)]
        public string Values4 { get; set; }
        [Required]
        [Column("VALUES_5")]
        [StringLength(10)]
        public string Values5 { get; set; }
        [Required]
        [Column("VALUES_6")]
        [StringLength(10)]
        public string Values6 { get; set; }
        [Required]
        [Column("VALUES_7")]
        [StringLength(10)]
        public string Values7 { get; set; }
        [Required]
        [Column("VALUES_8")]
        [StringLength(10)]
        public string Values8 { get; set; }
        [Required]
        [Column("VALUES_9")]
        [StringLength(10)]
        public string Values9 { get; set; }
        [Required]
        [Column("VALUES_10")]
        [StringLength(10)]
        public string Values10 { get; set; }
        [Required]
        [Column("VALUES_11")]
        [StringLength(10)]
        public string Values11 { get; set; }
        [Required]
        [Column("VALUES_12")]
        [StringLength(10)]
        public string Values12 { get; set; }
        [Required]
        [Column("VALUES_13")]
        [StringLength(10)]
        public string Values13 { get; set; }
        [Required]
        [Column("VALUES_14")]
        [StringLength(10)]
        public string Values14 { get; set; }
        [Column("NBVAL_0")]
        public short Nbval0 { get; set; }
        [Column("VALFLG_0")]
        public byte Valflg0 { get; set; }
        [Required]
        [Column("OBJET_0")]
        [StringLength(3)]
        public string Objet0 { get; set; }
        [Required]
        [Column("SUPP_0")]
        [StringLength(10)]
        public string Supp0 { get; set; }
        [Required]
        [Column("TRAIT_0")]
        [StringLength(30)]
        public string Trait0 { get; set; }
        [Required]
        [Column("SELOPT_0")]
        [StringLength(20)]
        public string Selopt0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Column("AUSMODIF_0")]
        public byte Ausmodif0 { get; set; }
        [Column("RANG_0")]
        public int Rang0 { get; set; }
        [Required]
        [Column("ACS_0")]
        [StringLength(10)]
        public string Acs0 { get; set; }
        [Column("VALDEF_0")]
        public byte Valdef0 { get; set; }
        [Required]
        [Column("CNDMOD_0")]
        [StringLength(250)]
        public string Cndmod0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}