﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("INTERVEN", Schema = "TESTPROD")]
    [Index(nameof(Num0), Name = "INTERVEN_ITN0", IsUnique = true)]
    [Index(nameof(Datx0), Name = "INTERVEN_ITN1")]
    [Index(nameof(Bpc0), Name = "INTERVEN_ITN2")]
    [Index(nameof(Ccn0), Name = "INTERVEN_ITN3")]
    [Index(nameof(Rep0), nameof(Datx0), Name = "INTERVEN_ITN4")]
    [Index(nameof(Rep0), nameof(Dat0), Name = "INTERVEN_ITN5")]
    [Index(nameof(Dat0), Name = "INTERVEN_ITN6")]
    [Index(nameof(Itnori0), nameof(Itnorivcr0), nameof(Itnorivcrl0), Name = "INTERVEN_ITN7")]
    public partial class Interven
    {
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Required]
        [Column("SALFCY_0")]
        [StringLength(5)]
        public string Salfcy0 { get; set; }
        [Required]
        [Column("SRVDEMNUM_0")]
        [StringLength(20)]
        public string Srvdemnum0 { get; set; }
        [Required]
        [Column("BPC_0")]
        [StringLength(15)]
        public string Bpc0 { get; set; }
        [Required]
        [Column("CCN_0")]
        [StringLength(15)]
        public string Ccn0 { get; set; }
        [Required]
        [Column("MAC_0")]
        [StringLength(20)]
        public string Mac0 { get; set; }
        [Required]
        [Column("MACGRU_0")]
        [StringLength(20)]
        public string Macgru0 { get; set; }
        [Required]
        [Column("TYP_0")]
        [StringLength(20)]
        public string Typ0 { get; set; }
        [Column("DAT_0", TypeName = "datetime")]
        public DateTime Dat0 { get; set; }
        [Column("DATEND_0", TypeName = "datetime")]
        public DateTime Datend0 { get; set; }
        [Required]
        [Column("HOU_0")]
        [StringLength(5)]
        public string Hou0 { get; set; }
        [Required]
        [Column("HOUEND_0")]
        [StringLength(5)]
        public string Houend0 { get; set; }
        [Column("FULDAY_0")]
        public byte Fulday0 { get; set; }
        [Column("WEE_0")]
        public short Wee0 { get; set; }
        [Required]
        [Column("DUR_0")]
        [StringLength(5)]
        public string Dur0 { get; set; }
        [Column("DATX_0", TypeName = "datetime")]
        public DateTime Datx0 { get; set; }
        [Column("DTCKIL_0")]
        public int Dtckil0 { get; set; }
        [Column("TRITIM_0")]
        public short Tritim0 { get; set; }
        [Required]
        [Column("OBJ_0")]
        [StringLength(250)]
        public string Obj0 { get; set; }
        [Required]
        [Column("TYPFULOBJ_0")]
        [StringLength(10)]
        public string Typfulobj0 { get; set; }
        [Required]
        [Column("NUMFULOBJ_0")]
        [StringLength(30)]
        public string Numfulobj0 { get; set; }
        [Column("OBJFLG_0")]
        public short Objflg0 { get; set; }
        [Required]
        [Column("REP_0")]
        [StringLength(5)]
        public string Rep0 { get; set; }
        [Column("HTOTTIMSPG_0")]
        public int Htottimspg0 { get; set; }
        [Column("MTOTTIMSPG_0")]
        public short Mtottimspg0 { get; set; }
        [Column("MANTIMFLG_0")]
        public short Mantimflg0 { get; set; }
        [Column("PBLSOL_0")]
        public byte Pblsol0 { get; set; }
        [Column("SRVCONCOV_0")]
        public byte Srvconcov0 { get; set; }
        [Required]
        [Column("CONNUM_0")]
        [StringLength(20)]
        public string Connum0 { get; set; }
        [Required]
        [Column("ORDNUM_0")]
        [StringLength(20)]
        public string Ordnum0 { get; set; }
        [Column("SCO_0")]
        public byte Sco0 { get; set; }
        [Required]
        [Column("SCONUM_0")]
        [StringLength(15)]
        public string Sconum0 { get; set; }
        [Column("SCOAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Scoamt0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("ITNTYPADD_0")]
        public byte Itntypadd0 { get; set; }
        [Required]
        [Column("ITNCODADD_0")]
        [StringLength(7)]
        public string Itncodadd0 { get; set; }
        [Required]
        [Column("ITNRECADD_0")]
        [StringLength(15)]
        public string Itnrecadd0 { get; set; }
        [Required]
        [Column("ADD_0")]
        [StringLength(40)]
        public string Add0 { get; set; }
        [Required]
        [Column("ADD_1")]
        [StringLength(40)]
        public string Add1 { get; set; }
        [Required]
        [Column("ADD_2")]
        [StringLength(40)]
        public string Add2 { get; set; }
        [Required]
        [Column("ZIP_0")]
        [StringLength(10)]
        public string Zip0 { get; set; }
        [Required]
        [Column("CTY_0")]
        [StringLength(40)]
        public string Cty0 { get; set; }
        [Required]
        [Column("CRY_0")]
        [StringLength(3)]
        public string Cry0 { get; set; }
        [Required]
        [Column("SAT_0")]
        [StringLength(35)]
        public string Sat0 { get; set; }
        [Required]
        [Column("TEL_0")]
        [StringLength(20)]
        public string Tel0 { get; set; }
        [Required]
        [Column("IFFADD_0")]
        [StringLength(250)]
        public string Iffadd0 { get; set; }
        [Required]
        [Column("RER_0")]
        [StringLength(20)]
        public string Rer0 { get; set; }
        [Required]
        [Column("RER_1")]
        [StringLength(20)]
        public string Rer1 { get; set; }
        [Required]
        [Column("RER_2")]
        [StringLength(20)]
        public string Rer2 { get; set; }
        [Required]
        [Column("RER_3")]
        [StringLength(20)]
        public string Rer3 { get; set; }
        [Required]
        [Column("RER_4")]
        [StringLength(20)]
        public string Rer4 { get; set; }
        [Required]
        [Column("RER_5")]
        [StringLength(20)]
        public string Rer5 { get; set; }
        [Required]
        [Column("RER_6")]
        [StringLength(20)]
        public string Rer6 { get; set; }
        [Required]
        [Column("RER_7")]
        [StringLength(20)]
        public string Rer7 { get; set; }
        [Required]
        [Column("RER_8")]
        [StringLength(20)]
        public string Rer8 { get; set; }
        [Required]
        [Column("RER_9")]
        [StringLength(20)]
        public string Rer9 { get; set; }
        [Required]
        [Column("RER_10")]
        [StringLength(20)]
        public string Rer10 { get; set; }
        [Required]
        [Column("RER_11")]
        [StringLength(20)]
        public string Rer11 { get; set; }
        [Required]
        [Column("RER_12")]
        [StringLength(20)]
        public string Rer12 { get; set; }
        [Required]
        [Column("RER_13")]
        [StringLength(20)]
        public string Rer13 { get; set; }
        [Required]
        [Column("RER_14")]
        [StringLength(20)]
        public string Rer14 { get; set; }
        [Column("DON_0")]
        public byte Don0 { get; set; }
        [Required]
        [Column("TYPFULRPO_0")]
        [StringLength(10)]
        public string Typfulrpo0 { get; set; }
        [Required]
        [Column("NUMFULRPO_0")]
        [StringLength(30)]
        public string Numfulrpo0 { get; set; }
        [Required]
        [Column("RPO_0")]
        [StringLength(250)]
        public string Rpo0 { get; set; }
        [Column("RPOFLG_0")]
        public short Rpoflg0 { get; set; }
        [Column("ITNORI_0")]
        public byte Itnori0 { get; set; }
        [Required]
        [Column("ITNORIVCR_0")]
        [StringLength(20)]
        public string Itnorivcr0 { get; set; }
        [Column("ITNORIVCRL_0")]
        public int Itnorivcrl0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREHOU_0")]
        [StringLength(5)]
        public string Crehou0 { get; set; }
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