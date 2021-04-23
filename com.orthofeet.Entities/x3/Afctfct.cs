﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AFCTFCT", Schema = "TESTPROD")]
    [Index(nameof(Prfcod0), Name = "AFCTFCT_AFT0", IsUnique = true)]
    public partial class Afctfct
    {
        [Required]
        [Column("PRFCOD_0")]
        [StringLength(5)]
        public string Prfcod0 { get; set; }
        [Column("ALLACS_0")]
        public byte Allacs0 { get; set; }
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
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Column("AUTETA_0")]
        public byte Auteta0 { get; set; }
        [Column("AUTETA_1")]
        public byte Auteta1 { get; set; }
        [Column("AUTETA_2")]
        public byte Auteta2 { get; set; }
        [Column("AUTETA_3")]
        public byte Auteta3 { get; set; }
        [Column("AUTETA_4")]
        public byte Auteta4 { get; set; }
        [Column("AUTETA_5")]
        public byte Auteta5 { get; set; }
        [Column("AUTETA_6")]
        public byte Auteta6 { get; set; }
        [Column("AUTETA_7")]
        public byte Auteta7 { get; set; }
        [Column("AUTETA_8")]
        public byte Auteta8 { get; set; }
        [Column("AUTETA_9")]
        public byte Auteta9 { get; set; }
        [Column("AUTETA_10")]
        public byte Auteta10 { get; set; }
        [Column("AUTETA_11")]
        public byte Auteta11 { get; set; }
        [Column("AUTETA_12")]
        public byte Auteta12 { get; set; }
        [Column("AUTETA_13")]
        public byte Auteta13 { get; set; }
        [Column("AUTETA_14")]
        public byte Auteta14 { get; set; }
        [Column("AUTETA_15")]
        public byte Auteta15 { get; set; }
        [Column("AUTETA_16")]
        public byte Auteta16 { get; set; }
        [Column("AUTETA_17")]
        public byte Auteta17 { get; set; }
        [Column("AUTETA_18")]
        public byte Auteta18 { get; set; }
        [Column("AUTETA_19")]
        public byte Auteta19 { get; set; }
        [Column("AUTETA_20")]
        public byte Auteta20 { get; set; }
        [Column("AUTETA_21")]
        public byte Auteta21 { get; set; }
        [Column("AUTETA_22")]
        public byte Auteta22 { get; set; }
        [Column("AUTETA_23")]
        public byte Auteta23 { get; set; }
        [Column("AUTETA_24")]
        public byte Auteta24 { get; set; }
        [Column("AUTETA_25")]
        public byte Auteta25 { get; set; }
        [Column("AUTETA_26")]
        public byte Auteta26 { get; set; }
        [Column("AUTETA_27")]
        public byte Auteta27 { get; set; }
        [Column("AUTETA_28")]
        public byte Auteta28 { get; set; }
        [Column("AUTETA_29")]
        public byte Auteta29 { get; set; }
        [Column("AUTETA_30")]
        public byte Auteta30 { get; set; }
        [Column("AUTETA_31")]
        public byte Auteta31 { get; set; }
        [Column("AUTETA_32")]
        public byte Auteta32 { get; set; }
        [Column("AUTETA_33")]
        public byte Auteta33 { get; set; }
        [Column("AUTETA_34")]
        public byte Auteta34 { get; set; }
        [Column("AUTETA_35")]
        public byte Auteta35 { get; set; }
        [Column("AUTETA_36")]
        public byte Auteta36 { get; set; }
        [Column("AUTETA_37")]
        public byte Auteta37 { get; set; }
        [Column("AUTETA_38")]
        public byte Auteta38 { get; set; }
        [Column("AUTETA_39")]
        public byte Auteta39 { get; set; }
        [Column("AUTETA_40")]
        public byte Auteta40 { get; set; }
        [Column("AUTETA_41")]
        public byte Auteta41 { get; set; }
        [Column("AUTETA_42")]
        public byte Auteta42 { get; set; }
        [Column("AUTETA_43")]
        public byte Auteta43 { get; set; }
        [Column("AUTETA_44")]
        public byte Auteta44 { get; set; }
        [Column("AUTETA_45")]
        public byte Auteta45 { get; set; }
        [Column("AUTETA_46")]
        public byte Auteta46 { get; set; }
        [Column("AUTETA_47")]
        public byte Auteta47 { get; set; }
        [Column("AUTETA_48")]
        public byte Auteta48 { get; set; }
        [Column("AUTETA_49")]
        public byte Auteta49 { get; set; }
        [Required]
        [Column("FCYDEF_0")]
        [StringLength(5)]
        public string Fcydef0 { get; set; }
        [Required]
        [Column("FCYDEF_1")]
        [StringLength(5)]
        public string Fcydef1 { get; set; }
        [Required]
        [Column("FCYDEF_2")]
        [StringLength(5)]
        public string Fcydef2 { get; set; }
        [Required]
        [Column("FCYDEF_3")]
        [StringLength(5)]
        public string Fcydef3 { get; set; }
        [Required]
        [Column("FCYDEF_4")]
        [StringLength(5)]
        public string Fcydef4 { get; set; }
        [Required]
        [Column("FCYDEF_5")]
        [StringLength(5)]
        public string Fcydef5 { get; set; }
        [Required]
        [Column("FCYDEF_6")]
        [StringLength(5)]
        public string Fcydef6 { get; set; }
        [Required]
        [Column("FCYDEF_7")]
        [StringLength(5)]
        public string Fcydef7 { get; set; }
        [Required]
        [Column("FCYDEF_8")]
        [StringLength(5)]
        public string Fcydef8 { get; set; }
        [Required]
        [Column("FCYDEF_9")]
        [StringLength(5)]
        public string Fcydef9 { get; set; }
        [Required]
        [Column("FCYDEF_10")]
        [StringLength(5)]
        public string Fcydef10 { get; set; }
        [Required]
        [Column("FCYDEF_11")]
        [StringLength(5)]
        public string Fcydef11 { get; set; }
        [Required]
        [Column("FCYDEF_12")]
        [StringLength(5)]
        public string Fcydef12 { get; set; }
        [Required]
        [Column("FCYDEF_13")]
        [StringLength(5)]
        public string Fcydef13 { get; set; }
        [Required]
        [Column("FCYDEF_14")]
        [StringLength(5)]
        public string Fcydef14 { get; set; }
        [Required]
        [Column("FCYDEF_15")]
        [StringLength(5)]
        public string Fcydef15 { get; set; }
        [Required]
        [Column("FCYDEF_16")]
        [StringLength(5)]
        public string Fcydef16 { get; set; }
        [Required]
        [Column("FCYDEF_17")]
        [StringLength(5)]
        public string Fcydef17 { get; set; }
        [Required]
        [Column("FCYDEF_18")]
        [StringLength(5)]
        public string Fcydef18 { get; set; }
        [Required]
        [Column("FCYDEF_19")]
        [StringLength(5)]
        public string Fcydef19 { get; set; }
        [Column("DIFIMP_0")]
        public byte Difimp0 { get; set; }
        [Required]
        [Column("FILTRE_0")]
        [StringLength(10)]
        public string Filtre0 { get; set; }
        [Column("ALLFCT_0")]
        public byte Allfct0 { get; set; }
        [Column("FLGPOR_0")]
        public byte Flgpor0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}