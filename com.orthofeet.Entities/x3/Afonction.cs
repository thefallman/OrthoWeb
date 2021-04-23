﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AFONCTION", Schema = "TESTPROD")]
    [Index(nameof(Codext0), Name = "AFONCTION_CODEXT", IsUnique = true)]
    [Index(nameof(Codint0), Name = "AFONCTION_CODINT", IsUnique = true)]
    [Index(nameof(Menu0), nameof(Rang0), nameof(Codint0), Name = "AFONCTION_MENU", IsUnique = true)]
    [Index(nameof(Module0), nameof(Menu0), nameof(Codint0), Name = "AFONCTION_MODULE", IsUnique = true)]
    [Index(nameof(Numfnc0), Name = "AFONCTION_NUMFNC", IsUnique = true)]
    public partial class Afonction
    {
        [Column("AIDE_0")]
        public int Aide0 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
        [Required]
        [Column("CODEXT_0")]
        [StringLength(10)]
        public string Codext0 { get; set; }
        [Required]
        [Column("CODINT_0")]
        [StringLength(10)]
        public string Codint0 { get; set; }
        [Column("NUMFNC_0")]
        public int Numfnc0 { get; set; }
        [Column("LIBMENU_0")]
        public int Libmenu0 { get; set; }
        [Required]
        [Column("MENU_0")]
        [StringLength(10)]
        public string Menu0 { get; set; }
        [Column("NOM_0")]
        public int Nom0 { get; set; }
        [Column("NBOPT_0")]
        public short Nbopt0 { get; set; }
        [Required]
        [Column("FLAG_0")]
        [StringLength(1)]
        public string Flag0 { get; set; }
        [Required]
        [Column("FLAG_1")]
        [StringLength(1)]
        public string Flag1 { get; set; }
        [Required]
        [Column("FLAG_2")]
        [StringLength(1)]
        public string Flag2 { get; set; }
        [Required]
        [Column("FLAG_3")]
        [StringLength(1)]
        public string Flag3 { get; set; }
        [Required]
        [Column("FLAG_4")]
        [StringLength(1)]
        public string Flag4 { get; set; }
        [Required]
        [Column("FLAG_5")]
        [StringLength(1)]
        public string Flag5 { get; set; }
        [Required]
        [Column("FLAG_6")]
        [StringLength(1)]
        public string Flag6 { get; set; }
        [Required]
        [Column("FLAG_7")]
        [StringLength(1)]
        public string Flag7 { get; set; }
        [Required]
        [Column("FLAG_8")]
        [StringLength(1)]
        public string Flag8 { get; set; }
        [Required]
        [Column("FLAG_9")]
        [StringLength(1)]
        public string Flag9 { get; set; }
        [Required]
        [Column("FLAG_10")]
        [StringLength(1)]
        public string Flag10 { get; set; }
        [Required]
        [Column("FLAG_11")]
        [StringLength(1)]
        public string Flag11 { get; set; }
        [Required]
        [Column("FLAG_12")]
        [StringLength(1)]
        public string Flag12 { get; set; }
        [Required]
        [Column("FLAG_13")]
        [StringLength(1)]
        public string Flag13 { get; set; }
        [Required]
        [Column("FLAG_14")]
        [StringLength(1)]
        public string Flag14 { get; set; }
        [Required]
        [Column("FLAG_15")]
        [StringLength(1)]
        public string Flag15 { get; set; }
        [Required]
        [Column("FLAG_16")]
        [StringLength(1)]
        public string Flag16 { get; set; }
        [Required]
        [Column("FLAG_17")]
        [StringLength(1)]
        public string Flag17 { get; set; }
        [Required]
        [Column("FLAG_18")]
        [StringLength(1)]
        public string Flag18 { get; set; }
        [Required]
        [Column("ACTOPT_0")]
        [StringLength(5)]
        public string Actopt0 { get; set; }
        [Required]
        [Column("ACTOPT_1")]
        [StringLength(5)]
        public string Actopt1 { get; set; }
        [Required]
        [Column("ACTOPT_2")]
        [StringLength(5)]
        public string Actopt2 { get; set; }
        [Required]
        [Column("ACTOPT_3")]
        [StringLength(5)]
        public string Actopt3 { get; set; }
        [Required]
        [Column("ACTOPT_4")]
        [StringLength(5)]
        public string Actopt4 { get; set; }
        [Required]
        [Column("ACTOPT_5")]
        [StringLength(5)]
        public string Actopt5 { get; set; }
        [Required]
        [Column("ACTOPT_6")]
        [StringLength(5)]
        public string Actopt6 { get; set; }
        [Required]
        [Column("ACTOPT_7")]
        [StringLength(5)]
        public string Actopt7 { get; set; }
        [Required]
        [Column("ACTOPT_8")]
        [StringLength(5)]
        public string Actopt8 { get; set; }
        [Required]
        [Column("ACTOPT_9")]
        [StringLength(5)]
        public string Actopt9 { get; set; }
        [Required]
        [Column("ACTOPT_10")]
        [StringLength(5)]
        public string Actopt10 { get; set; }
        [Required]
        [Column("ACTOPT_11")]
        [StringLength(5)]
        public string Actopt11 { get; set; }
        [Required]
        [Column("ACTOPT_12")]
        [StringLength(5)]
        public string Actopt12 { get; set; }
        [Required]
        [Column("ACTOPT_13")]
        [StringLength(5)]
        public string Actopt13 { get; set; }
        [Required]
        [Column("ACTOPT_14")]
        [StringLength(5)]
        public string Actopt14 { get; set; }
        [Required]
        [Column("ACTOPT_15")]
        [StringLength(5)]
        public string Actopt15 { get; set; }
        [Required]
        [Column("ACTOPT_16")]
        [StringLength(5)]
        public string Actopt16 { get; set; }
        [Required]
        [Column("ACTOPT_17")]
        [StringLength(5)]
        public string Actopt17 { get; set; }
        [Required]
        [Column("ACTOPT_18")]
        [StringLength(5)]
        public string Actopt18 { get; set; }
        [Column("OPTION_0")]
        public int Option0 { get; set; }
        [Column("OPTION_1")]
        public int Option1 { get; set; }
        [Column("OPTION_2")]
        public int Option2 { get; set; }
        [Column("OPTION_3")]
        public int Option3 { get; set; }
        [Column("OPTION_4")]
        public int Option4 { get; set; }
        [Column("OPTION_5")]
        public int Option5 { get; set; }
        [Column("OPTION_6")]
        public int Option6 { get; set; }
        [Column("OPTION_7")]
        public int Option7 { get; set; }
        [Column("OPTION_8")]
        public int Option8 { get; set; }
        [Column("OPTION_9")]
        public int Option9 { get; set; }
        [Column("OPTION_10")]
        public int Option10 { get; set; }
        [Column("OPTION_11")]
        public int Option11 { get; set; }
        [Column("OPTION_12")]
        public int Option12 { get; set; }
        [Column("OPTION_13")]
        public int Option13 { get; set; }
        [Column("OPTION_14")]
        public int Option14 { get; set; }
        [Column("OPTION_15")]
        public int Option15 { get; set; }
        [Column("OPTION_16")]
        public int Option16 { get; set; }
        [Column("OPTION_17")]
        public int Option17 { get; set; }
        [Column("OPTION_18")]
        public int Option18 { get; set; }
        [Required]
        [Column("FNCOPT_0")]
        [StringLength(10)]
        public string Fncopt0 { get; set; }
        [Required]
        [Column("FNCOPT_1")]
        [StringLength(10)]
        public string Fncopt1 { get; set; }
        [Required]
        [Column("FNCOPT_2")]
        [StringLength(10)]
        public string Fncopt2 { get; set; }
        [Required]
        [Column("FNCOPT_3")]
        [StringLength(10)]
        public string Fncopt3 { get; set; }
        [Required]
        [Column("FNCOPT_4")]
        [StringLength(10)]
        public string Fncopt4 { get; set; }
        [Required]
        [Column("FNCOPT_5")]
        [StringLength(10)]
        public string Fncopt5 { get; set; }
        [Required]
        [Column("FNCOPT_6")]
        [StringLength(10)]
        public string Fncopt6 { get; set; }
        [Required]
        [Column("FNCOPT_7")]
        [StringLength(10)]
        public string Fncopt7 { get; set; }
        [Required]
        [Column("FNCOPT_8")]
        [StringLength(10)]
        public string Fncopt8 { get; set; }
        [Required]
        [Column("FNCOPT_9")]
        [StringLength(10)]
        public string Fncopt9 { get; set; }
        [Required]
        [Column("FNCOPT_10")]
        [StringLength(10)]
        public string Fncopt10 { get; set; }
        [Required]
        [Column("FNCOPT_11")]
        [StringLength(10)]
        public string Fncopt11 { get; set; }
        [Required]
        [Column("FNCOPT_12")]
        [StringLength(10)]
        public string Fncopt12 { get; set; }
        [Required]
        [Column("FNCOPT_13")]
        [StringLength(10)]
        public string Fncopt13 { get; set; }
        [Required]
        [Column("FNCOPT_14")]
        [StringLength(10)]
        public string Fncopt14 { get; set; }
        [Required]
        [Column("FNCOPT_15")]
        [StringLength(10)]
        public string Fncopt15 { get; set; }
        [Required]
        [Column("FNCOPT_16")]
        [StringLength(10)]
        public string Fncopt16 { get; set; }
        [Required]
        [Column("FNCOPT_17")]
        [StringLength(10)]
        public string Fncopt17 { get; set; }
        [Required]
        [Column("FNCOPT_18")]
        [StringLength(10)]
        public string Fncopt18 { get; set; }
        [Column("RANG_0")]
        public short Rang0 { get; set; }
        [Required]
        [Column("TRAIT_0")]
        [StringLength(30)]
        public string Trait0 { get; set; }
        [Column("TYP_0")]
        public byte Typ0 { get; set; }
        [Column("TYPTRAIT_0")]
        public byte Typtrait0 { get; set; }
        [Column("NBVAR_0")]
        public short Nbvar0 { get; set; }
        [Required]
        [Column("ACTVAR_0")]
        [StringLength(5)]
        public string Actvar0 { get; set; }
        [Required]
        [Column("ACTVAR_1")]
        [StringLength(5)]
        public string Actvar1 { get; set; }
        [Required]
        [Column("ACTVAR_2")]
        [StringLength(5)]
        public string Actvar2 { get; set; }
        [Required]
        [Column("ACTVAR_3")]
        [StringLength(5)]
        public string Actvar3 { get; set; }
        [Required]
        [Column("ACTVAR_4")]
        [StringLength(5)]
        public string Actvar4 { get; set; }
        [Required]
        [Column("ACTVAR_5")]
        [StringLength(5)]
        public string Actvar5 { get; set; }
        [Required]
        [Column("ACTVAR_6")]
        [StringLength(5)]
        public string Actvar6 { get; set; }
        [Required]
        [Column("ACTVAR_7")]
        [StringLength(5)]
        public string Actvar7 { get; set; }
        [Required]
        [Column("ACTVAR_8")]
        [StringLength(5)]
        public string Actvar8 { get; set; }
        [Required]
        [Column("ACTVAR_9")]
        [StringLength(5)]
        public string Actvar9 { get; set; }
        [Required]
        [Column("VALEUR_0")]
        [StringLength(20)]
        public string Valeur0 { get; set; }
        [Required]
        [Column("VALEUR_1")]
        [StringLength(20)]
        public string Valeur1 { get; set; }
        [Required]
        [Column("VALEUR_2")]
        [StringLength(20)]
        public string Valeur2 { get; set; }
        [Required]
        [Column("VALEUR_3")]
        [StringLength(20)]
        public string Valeur3 { get; set; }
        [Required]
        [Column("VALEUR_4")]
        [StringLength(20)]
        public string Valeur4 { get; set; }
        [Required]
        [Column("VALEUR_5")]
        [StringLength(20)]
        public string Valeur5 { get; set; }
        [Required]
        [Column("VALEUR_6")]
        [StringLength(20)]
        public string Valeur6 { get; set; }
        [Required]
        [Column("VALEUR_7")]
        [StringLength(20)]
        public string Valeur7 { get; set; }
        [Required]
        [Column("VALEUR_8")]
        [StringLength(20)]
        public string Valeur8 { get; set; }
        [Required]
        [Column("VALEUR_9")]
        [StringLength(20)]
        public string Valeur9 { get; set; }
        [Required]
        [Column("VARIA_0")]
        [StringLength(12)]
        public string Varia0 { get; set; }
        [Required]
        [Column("VARIA_1")]
        [StringLength(12)]
        public string Varia1 { get; set; }
        [Required]
        [Column("VARIA_2")]
        [StringLength(12)]
        public string Varia2 { get; set; }
        [Required]
        [Column("VARIA_3")]
        [StringLength(12)]
        public string Varia3 { get; set; }
        [Required]
        [Column("VARIA_4")]
        [StringLength(12)]
        public string Varia4 { get; set; }
        [Required]
        [Column("VARIA_5")]
        [StringLength(12)]
        public string Varia5 { get; set; }
        [Required]
        [Column("VARIA_6")]
        [StringLength(12)]
        public string Varia6 { get; set; }
        [Required]
        [Column("VARIA_7")]
        [StringLength(12)]
        public string Varia7 { get; set; }
        [Required]
        [Column("VARIA_8")]
        [StringLength(12)]
        public string Varia8 { get; set; }
        [Required]
        [Column("VARIA_9")]
        [StringLength(12)]
        public string Varia9 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("RPT1_0")]
        [StringLength(15)]
        public string Rpt10 { get; set; }
        [Required]
        [Column("RPT2_0")]
        [StringLength(15)]
        public string Rpt20 { get; set; }
        [Required]
        [Column("ACTION_0")]
        [StringLength(10)]
        public string Action0 { get; set; }
        [Required]
        [Column("VALPAR_0")]
        [StringLength(30)]
        public string Valpar0 { get; set; }
        [Required]
        [Column("VALPAR_1")]
        [StringLength(30)]
        public string Valpar1 { get; set; }
        [Required]
        [Column("VALPAR_2")]
        [StringLength(30)]
        public string Valpar2 { get; set; }
        [Required]
        [Column("VALPAR_3")]
        [StringLength(30)]
        public string Valpar3 { get; set; }
        [Required]
        [Column("VALPAR_4")]
        [StringLength(30)]
        public string Valpar4 { get; set; }
        [Required]
        [Column("VALPAR_5")]
        [StringLength(30)]
        public string Valpar5 { get; set; }
        [Required]
        [Column("VALPAR_6")]
        [StringLength(30)]
        public string Valpar6 { get; set; }
        [Required]
        [Column("VALPAR_7")]
        [StringLength(30)]
        public string Valpar7 { get; set; }
        [Required]
        [Column("VALPAR_8")]
        [StringLength(30)]
        public string Valpar8 { get; set; }
        [Required]
        [Column("VALPAR_9")]
        [StringLength(30)]
        public string Valpar9 { get; set; }
        [Required]
        [Column("VALPAR_10")]
        [StringLength(30)]
        public string Valpar10 { get; set; }
        [Required]
        [Column("VALPAR_11")]
        [StringLength(30)]
        public string Valpar11 { get; set; }
        [Required]
        [Column("VALPAR_12")]
        [StringLength(30)]
        public string Valpar12 { get; set; }
        [Required]
        [Column("VALPAR_13")]
        [StringLength(30)]
        public string Valpar13 { get; set; }
        [Required]
        [Column("VALPAR_14")]
        [StringLength(30)]
        public string Valpar14 { get; set; }
        [Required]
        [Column("VALPAR_15")]
        [StringLength(30)]
        public string Valpar15 { get; set; }
        [Required]
        [Column("VALPAR_16")]
        [StringLength(30)]
        public string Valpar16 { get; set; }
        [Required]
        [Column("VALPAR_17")]
        [StringLength(30)]
        public string Valpar17 { get; set; }
        [Required]
        [Column("VALPAR_18")]
        [StringLength(30)]
        public string Valpar18 { get; set; }
        [Required]
        [Column("VALPAR_19")]
        [StringLength(30)]
        public string Valpar19 { get; set; }
        [Required]
        [Column("CODPAR_0")]
        [StringLength(10)]
        public string Codpar0 { get; set; }
        [Required]
        [Column("CODPAR_1")]
        [StringLength(10)]
        public string Codpar1 { get; set; }
        [Required]
        [Column("CODPAR_2")]
        [StringLength(10)]
        public string Codpar2 { get; set; }
        [Required]
        [Column("CODPAR_3")]
        [StringLength(10)]
        public string Codpar3 { get; set; }
        [Required]
        [Column("CODPAR_4")]
        [StringLength(10)]
        public string Codpar4 { get; set; }
        [Required]
        [Column("CODPAR_5")]
        [StringLength(10)]
        public string Codpar5 { get; set; }
        [Required]
        [Column("CODPAR_6")]
        [StringLength(10)]
        public string Codpar6 { get; set; }
        [Required]
        [Column("CODPAR_7")]
        [StringLength(10)]
        public string Codpar7 { get; set; }
        [Required]
        [Column("CODPAR_8")]
        [StringLength(10)]
        public string Codpar8 { get; set; }
        [Required]
        [Column("CODPAR_9")]
        [StringLength(10)]
        public string Codpar9 { get; set; }
        [Required]
        [Column("CODPAR_10")]
        [StringLength(10)]
        public string Codpar10 { get; set; }
        [Required]
        [Column("CODPAR_11")]
        [StringLength(10)]
        public string Codpar11 { get; set; }
        [Required]
        [Column("CODPAR_12")]
        [StringLength(10)]
        public string Codpar12 { get; set; }
        [Required]
        [Column("CODPAR_13")]
        [StringLength(10)]
        public string Codpar13 { get; set; }
        [Required]
        [Column("CODPAR_14")]
        [StringLength(10)]
        public string Codpar14 { get; set; }
        [Required]
        [Column("CODPAR_15")]
        [StringLength(10)]
        public string Codpar15 { get; set; }
        [Required]
        [Column("CODPAR_16")]
        [StringLength(10)]
        public string Codpar16 { get; set; }
        [Required]
        [Column("CODPAR_17")]
        [StringLength(10)]
        public string Codpar17 { get; set; }
        [Required]
        [Column("CODPAR_18")]
        [StringLength(10)]
        public string Codpar18 { get; set; }
        [Required]
        [Column("CODPAR_19")]
        [StringLength(10)]
        public string Codpar19 { get; set; }
        [Required]
        [Column("TRTENT_0")]
        [StringLength(10)]
        public string Trtent0 { get; set; }
        [Column("FCYAUZ_0")]
        public byte Fcyauz0 { get; set; }
        [Column("MONO_0")]
        public byte Mono0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Column("NAVIG_0")]
        public byte Navig0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}