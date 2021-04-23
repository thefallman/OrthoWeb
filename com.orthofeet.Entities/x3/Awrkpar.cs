﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AWRKPAR", Schema = "TESTPROD")]
    [Index(nameof(Code0), Name = "AWRKPAR_AWA0", IsUnique = true)]
    [Index(nameof(Typevt0), nameof(Codevt0), nameof(Code0), Name = "AWRKPAR_AWA1", IsUnique = true)]
    [Index(nameof(Categ0), nameof(Code0), Name = "AWRKPAR_AWA2", IsUnique = true)]
    public partial class Awrkpar
    {
        [Required]
        [Column("CODE_0")]
        [StringLength(10)]
        public string Code0 { get; set; }
        [Required]
        [Column("CATEG_0")]
        [StringLength(20)]
        public string Categ0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Column("TYPEVT_0")]
        public byte Typevt0 { get; set; }
        [Required]
        [Column("CODEVT_0")]
        [StringLength(15)]
        public string Codevt0 { get; set; }
        [Required]
        [Column("OPERATION_0")]
        [StringLength(20)]
        public string Operation0 { get; set; }
        [Column("TYPDEC_0")]
        public byte Typdec0 { get; set; }
        [Required]
        [Column("REGLE_0")]
        [StringLength(10)]
        public string Regle0 { get; set; }
        [Required]
        [Column("MODELE_0")]
        [StringLength(10)]
        public string Modele0 { get; set; }
        [Required]
        [Column("GROUPE_0")]
        [StringLength(80)]
        public string Groupe0 { get; set; }
        [Column("TYPWRK_0")]
        public byte Typwrk0 { get; set; }
        [Required]
        [Column("TABLIG_0")]
        [StringLength(12)]
        public string Tablig0 { get; set; }
        [Required]
        [Column("ABRLIG_0")]
        [StringLength(4)]
        public string Abrlig0 { get; set; }
        [Column("NBCOND_0")]
        public short Nbcond0 { get; set; }
        [Required]
        [Column("CONDITION_0")]
        [StringLength(250)]
        public string Condition0 { get; set; }
        [Required]
        [Column("CONDITION_1")]
        [StringLength(250)]
        public string Condition1 { get; set; }
        [Required]
        [Column("CONDITION_2")]
        [StringLength(250)]
        public string Condition2 { get; set; }
        [Required]
        [Column("CONDITION_3")]
        [StringLength(250)]
        public string Condition3 { get; set; }
        [Required]
        [Column("CONDITION_4")]
        [StringLength(250)]
        public string Condition4 { get; set; }
        [Column("TYPCND_0")]
        public byte Typcnd0 { get; set; }
        [Column("TYPCND_1")]
        public byte Typcnd1 { get; set; }
        [Column("TYPCND_2")]
        public byte Typcnd2 { get; set; }
        [Column("TYPCND_3")]
        public byte Typcnd3 { get; set; }
        [Column("TYPCND_4")]
        public byte Typcnd4 { get; set; }
        [Column("DEBUG_0")]
        public byte Debug0 { get; set; }
        [Column("ENAMES_0")]
        public byte Enames0 { get; set; }
        [Column("ENAACT_0")]
        public byte Enaact0 { get; set; }
        [Column("ENASUI_0")]
        public byte Enasui0 { get; set; }
        [Required]
        [Column("OBJET_0")]
        [StringLength(250)]
        public string Objet0 { get; set; }
        [Required]
        [Column("TEXLIG_0")]
        [StringLength(250)]
        public string Texlig0 { get; set; }
        [Column("TYPMES_0")]
        public byte Typmes0 { get; set; }
        [Column("INTERV_0")]
        public byte Interv0 { get; set; }
        [Column("RETOUR_0")]
        public byte Retour0 { get; set; }
        [Required]
        [Column("BAKFCT_0")]
        [StringLength(10)]
        public string Bakfct0 { get; set; }
        [Required]
        [Column("BAKLNK_0")]
        [StringLength(60)]
        public string Baklnk0 { get; set; }
        [Column("BAKMEN_0")]
        public byte Bakmen0 { get; set; }
        [Column("REQREC_0")]
        public byte Reqrec0 { get; set; }
        [Column("GRPENV_0")]
        public byte Grpenv0 { get; set; }
        [Required]
        [Column("JOINT_0")]
        [StringLength(250)]
        public string Joint0 { get; set; }
        [Column("TRACE_0")]
        public byte Trace0 { get; set; }
        [Column("JOIOBJ_0")]
        public byte Joiobj0 { get; set; }
        [Column("ALLTYPJOI_0")]
        public byte Alltypjoi0 { get; set; }
        [Required]
        [Column("TYPJOI_0")]
        [StringLength(20)]
        public string Typjoi0 { get; set; }
        [Column("ALLCATJOI_0")]
        public byte Allcatjoi0 { get; set; }
        [Column("CATJOI_0")]
        public byte Catjoi0 { get; set; }
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
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Required]
        [Column("TEXTE_0")]
        public string Texte0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}