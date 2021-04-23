﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("CAPVAR", Schema = "TESTPROD")]
    [Index(nameof(Wst0), nameof(Wcrfcy0), Name = "CAPVAR_CPV0", IsUnique = true)]
    public partial class Capvar
    {
        [Required]
        [Column("WST_0")]
        [StringLength(8)]
        public string Wst0 { get; set; }
        [Required]
        [Column("WCRFCY_0")]
        [StringLength(5)]
        public string Wcrfcy0 { get; set; }
        [Column("STRDAT_0", TypeName = "datetime")]
        public DateTime Strdat0 { get; set; }
        [Column("STRDAT_1", TypeName = "datetime")]
        public DateTime Strdat1 { get; set; }
        [Column("STRDAT_2", TypeName = "datetime")]
        public DateTime Strdat2 { get; set; }
        [Column("STRDAT_3", TypeName = "datetime")]
        public DateTime Strdat3 { get; set; }
        [Column("STRDAT_4", TypeName = "datetime")]
        public DateTime Strdat4 { get; set; }
        [Column("STRDAT_5", TypeName = "datetime")]
        public DateTime Strdat5 { get; set; }
        [Column("STRDAT_6", TypeName = "datetime")]
        public DateTime Strdat6 { get; set; }
        [Column("STRDAT_7", TypeName = "datetime")]
        public DateTime Strdat7 { get; set; }
        [Column("STRDAT_8", TypeName = "datetime")]
        public DateTime Strdat8 { get; set; }
        [Column("STRDAT_9", TypeName = "datetime")]
        public DateTime Strdat9 { get; set; }
        [Column("STRDAT_10", TypeName = "datetime")]
        public DateTime Strdat10 { get; set; }
        [Column("STRDAT_11", TypeName = "datetime")]
        public DateTime Strdat11 { get; set; }
        [Column("STRDAT_12", TypeName = "datetime")]
        public DateTime Strdat12 { get; set; }
        [Column("STRDAT_13", TypeName = "datetime")]
        public DateTime Strdat13 { get; set; }
        [Column("STRDAT_14", TypeName = "datetime")]
        public DateTime Strdat14 { get; set; }
        [Column("STRDAT_15", TypeName = "datetime")]
        public DateTime Strdat15 { get; set; }
        [Column("STRDAT_16", TypeName = "datetime")]
        public DateTime Strdat16 { get; set; }
        [Column("STRDAT_17", TypeName = "datetime")]
        public DateTime Strdat17 { get; set; }
        [Column("STRDAT_18", TypeName = "datetime")]
        public DateTime Strdat18 { get; set; }
        [Column("STRDAT_19", TypeName = "datetime")]
        public DateTime Strdat19 { get; set; }
        [Column("STRDAT_20", TypeName = "datetime")]
        public DateTime Strdat20 { get; set; }
        [Column("STRDAT_21", TypeName = "datetime")]
        public DateTime Strdat21 { get; set; }
        [Column("STRDAT_22", TypeName = "datetime")]
        public DateTime Strdat22 { get; set; }
        [Column("STRDAT_23", TypeName = "datetime")]
        public DateTime Strdat23 { get; set; }
        [Column("STRDAT_24", TypeName = "datetime")]
        public DateTime Strdat24 { get; set; }
        [Column("ENDDAT_0", TypeName = "datetime")]
        public DateTime Enddat0 { get; set; }
        [Column("ENDDAT_1", TypeName = "datetime")]
        public DateTime Enddat1 { get; set; }
        [Column("ENDDAT_2", TypeName = "datetime")]
        public DateTime Enddat2 { get; set; }
        [Column("ENDDAT_3", TypeName = "datetime")]
        public DateTime Enddat3 { get; set; }
        [Column("ENDDAT_4", TypeName = "datetime")]
        public DateTime Enddat4 { get; set; }
        [Column("ENDDAT_5", TypeName = "datetime")]
        public DateTime Enddat5 { get; set; }
        [Column("ENDDAT_6", TypeName = "datetime")]
        public DateTime Enddat6 { get; set; }
        [Column("ENDDAT_7", TypeName = "datetime")]
        public DateTime Enddat7 { get; set; }
        [Column("ENDDAT_8", TypeName = "datetime")]
        public DateTime Enddat8 { get; set; }
        [Column("ENDDAT_9", TypeName = "datetime")]
        public DateTime Enddat9 { get; set; }
        [Column("ENDDAT_10", TypeName = "datetime")]
        public DateTime Enddat10 { get; set; }
        [Column("ENDDAT_11", TypeName = "datetime")]
        public DateTime Enddat11 { get; set; }
        [Column("ENDDAT_12", TypeName = "datetime")]
        public DateTime Enddat12 { get; set; }
        [Column("ENDDAT_13", TypeName = "datetime")]
        public DateTime Enddat13 { get; set; }
        [Column("ENDDAT_14", TypeName = "datetime")]
        public DateTime Enddat14 { get; set; }
        [Column("ENDDAT_15", TypeName = "datetime")]
        public DateTime Enddat15 { get; set; }
        [Column("ENDDAT_16", TypeName = "datetime")]
        public DateTime Enddat16 { get; set; }
        [Column("ENDDAT_17", TypeName = "datetime")]
        public DateTime Enddat17 { get; set; }
        [Column("ENDDAT_18", TypeName = "datetime")]
        public DateTime Enddat18 { get; set; }
        [Column("ENDDAT_19", TypeName = "datetime")]
        public DateTime Enddat19 { get; set; }
        [Column("ENDDAT_20", TypeName = "datetime")]
        public DateTime Enddat20 { get; set; }
        [Column("ENDDAT_21", TypeName = "datetime")]
        public DateTime Enddat21 { get; set; }
        [Column("ENDDAT_22", TypeName = "datetime")]
        public DateTime Enddat22 { get; set; }
        [Column("ENDDAT_23", TypeName = "datetime")]
        public DateTime Enddat23 { get; set; }
        [Column("ENDDAT_24", TypeName = "datetime")]
        public DateTime Enddat24 { get; set; }
        [Required]
        [Column("CODVAR_0")]
        [StringLength(20)]
        public string Codvar0 { get; set; }
        [Required]
        [Column("CODVAR_1")]
        [StringLength(20)]
        public string Codvar1 { get; set; }
        [Required]
        [Column("CODVAR_2")]
        [StringLength(20)]
        public string Codvar2 { get; set; }
        [Required]
        [Column("CODVAR_3")]
        [StringLength(20)]
        public string Codvar3 { get; set; }
        [Required]
        [Column("CODVAR_4")]
        [StringLength(20)]
        public string Codvar4 { get; set; }
        [Required]
        [Column("CODVAR_5")]
        [StringLength(20)]
        public string Codvar5 { get; set; }
        [Required]
        [Column("CODVAR_6")]
        [StringLength(20)]
        public string Codvar6 { get; set; }
        [Required]
        [Column("CODVAR_7")]
        [StringLength(20)]
        public string Codvar7 { get; set; }
        [Required]
        [Column("CODVAR_8")]
        [StringLength(20)]
        public string Codvar8 { get; set; }
        [Required]
        [Column("CODVAR_9")]
        [StringLength(20)]
        public string Codvar9 { get; set; }
        [Required]
        [Column("CODVAR_10")]
        [StringLength(20)]
        public string Codvar10 { get; set; }
        [Required]
        [Column("CODVAR_11")]
        [StringLength(20)]
        public string Codvar11 { get; set; }
        [Required]
        [Column("CODVAR_12")]
        [StringLength(20)]
        public string Codvar12 { get; set; }
        [Required]
        [Column("CODVAR_13")]
        [StringLength(20)]
        public string Codvar13 { get; set; }
        [Required]
        [Column("CODVAR_14")]
        [StringLength(20)]
        public string Codvar14 { get; set; }
        [Required]
        [Column("CODVAR_15")]
        [StringLength(20)]
        public string Codvar15 { get; set; }
        [Required]
        [Column("CODVAR_16")]
        [StringLength(20)]
        public string Codvar16 { get; set; }
        [Required]
        [Column("CODVAR_17")]
        [StringLength(20)]
        public string Codvar17 { get; set; }
        [Required]
        [Column("CODVAR_18")]
        [StringLength(20)]
        public string Codvar18 { get; set; }
        [Required]
        [Column("CODVAR_19")]
        [StringLength(20)]
        public string Codvar19 { get; set; }
        [Required]
        [Column("CODVAR_20")]
        [StringLength(20)]
        public string Codvar20 { get; set; }
        [Required]
        [Column("CODVAR_21")]
        [StringLength(20)]
        public string Codvar21 { get; set; }
        [Required]
        [Column("CODVAR_22")]
        [StringLength(20)]
        public string Codvar22 { get; set; }
        [Required]
        [Column("CODVAR_23")]
        [StringLength(20)]
        public string Codvar23 { get; set; }
        [Required]
        [Column("CODVAR_24")]
        [StringLength(20)]
        public string Codvar24 { get; set; }
        [Required]
        [Column("TWD_0")]
        [StringLength(3)]
        public string Twd0 { get; set; }
        [Required]
        [Column("TWD_1")]
        [StringLength(3)]
        public string Twd1 { get; set; }
        [Required]
        [Column("TWD_2")]
        [StringLength(3)]
        public string Twd2 { get; set; }
        [Required]
        [Column("TWD_3")]
        [StringLength(3)]
        public string Twd3 { get; set; }
        [Required]
        [Column("TWD_4")]
        [StringLength(3)]
        public string Twd4 { get; set; }
        [Required]
        [Column("TWD_5")]
        [StringLength(3)]
        public string Twd5 { get; set; }
        [Required]
        [Column("TWD_6")]
        [StringLength(3)]
        public string Twd6 { get; set; }
        [Required]
        [Column("TWD_7")]
        [StringLength(3)]
        public string Twd7 { get; set; }
        [Required]
        [Column("TWD_8")]
        [StringLength(3)]
        public string Twd8 { get; set; }
        [Required]
        [Column("TWD_9")]
        [StringLength(3)]
        public string Twd9 { get; set; }
        [Required]
        [Column("TWD_10")]
        [StringLength(3)]
        public string Twd10 { get; set; }
        [Required]
        [Column("TWD_11")]
        [StringLength(3)]
        public string Twd11 { get; set; }
        [Required]
        [Column("TWD_12")]
        [StringLength(3)]
        public string Twd12 { get; set; }
        [Required]
        [Column("TWD_13")]
        [StringLength(3)]
        public string Twd13 { get; set; }
        [Required]
        [Column("TWD_14")]
        [StringLength(3)]
        public string Twd14 { get; set; }
        [Required]
        [Column("TWD_15")]
        [StringLength(3)]
        public string Twd15 { get; set; }
        [Required]
        [Column("TWD_16")]
        [StringLength(3)]
        public string Twd16 { get; set; }
        [Required]
        [Column("TWD_17")]
        [StringLength(3)]
        public string Twd17 { get; set; }
        [Required]
        [Column("TWD_18")]
        [StringLength(3)]
        public string Twd18 { get; set; }
        [Required]
        [Column("TWD_19")]
        [StringLength(3)]
        public string Twd19 { get; set; }
        [Required]
        [Column("TWD_20")]
        [StringLength(3)]
        public string Twd20 { get; set; }
        [Required]
        [Column("TWD_21")]
        [StringLength(3)]
        public string Twd21 { get; set; }
        [Required]
        [Column("TWD_22")]
        [StringLength(3)]
        public string Twd22 { get; set; }
        [Required]
        [Column("TWD_23")]
        [StringLength(3)]
        public string Twd23 { get; set; }
        [Required]
        [Column("TWD_24")]
        [StringLength(3)]
        public string Twd24 { get; set; }
        [Column("WSTNBR_0")]
        public short Wstnbr0 { get; set; }
        [Column("WSTNBR_1")]
        public short Wstnbr1 { get; set; }
        [Column("WSTNBR_2")]
        public short Wstnbr2 { get; set; }
        [Column("WSTNBR_3")]
        public short Wstnbr3 { get; set; }
        [Column("WSTNBR_4")]
        public short Wstnbr4 { get; set; }
        [Column("WSTNBR_5")]
        public short Wstnbr5 { get; set; }
        [Column("WSTNBR_6")]
        public short Wstnbr6 { get; set; }
        [Column("WSTNBR_7")]
        public short Wstnbr7 { get; set; }
        [Column("WSTNBR_8")]
        public short Wstnbr8 { get; set; }
        [Column("WSTNBR_9")]
        public short Wstnbr9 { get; set; }
        [Column("WSTNBR_10")]
        public short Wstnbr10 { get; set; }
        [Column("WSTNBR_11")]
        public short Wstnbr11 { get; set; }
        [Column("WSTNBR_12")]
        public short Wstnbr12 { get; set; }
        [Column("WSTNBR_13")]
        public short Wstnbr13 { get; set; }
        [Column("WSTNBR_14")]
        public short Wstnbr14 { get; set; }
        [Column("WSTNBR_15")]
        public short Wstnbr15 { get; set; }
        [Column("WSTNBR_16")]
        public short Wstnbr16 { get; set; }
        [Column("WSTNBR_17")]
        public short Wstnbr17 { get; set; }
        [Column("WSTNBR_18")]
        public short Wstnbr18 { get; set; }
        [Column("WSTNBR_19")]
        public short Wstnbr19 { get; set; }
        [Column("WSTNBR_20")]
        public short Wstnbr20 { get; set; }
        [Column("WSTNBR_21")]
        public short Wstnbr21 { get; set; }
        [Column("WSTNBR_22")]
        public short Wstnbr22 { get; set; }
        [Column("WSTNBR_23")]
        public short Wstnbr23 { get; set; }
        [Column("WSTNBR_24")]
        public short Wstnbr24 { get; set; }
        [Required]
        [Column("VARTEX_0")]
        [StringLength(12)]
        public string Vartex0 { get; set; }
        [Required]
        [Column("VARTEX_1")]
        [StringLength(12)]
        public string Vartex1 { get; set; }
        [Required]
        [Column("VARTEX_2")]
        [StringLength(12)]
        public string Vartex2 { get; set; }
        [Required]
        [Column("VARTEX_3")]
        [StringLength(12)]
        public string Vartex3 { get; set; }
        [Required]
        [Column("VARTEX_4")]
        [StringLength(12)]
        public string Vartex4 { get; set; }
        [Required]
        [Column("VARTEX_5")]
        [StringLength(12)]
        public string Vartex5 { get; set; }
        [Required]
        [Column("VARTEX_6")]
        [StringLength(12)]
        public string Vartex6 { get; set; }
        [Required]
        [Column("VARTEX_7")]
        [StringLength(12)]
        public string Vartex7 { get; set; }
        [Required]
        [Column("VARTEX_8")]
        [StringLength(12)]
        public string Vartex8 { get; set; }
        [Required]
        [Column("VARTEX_9")]
        [StringLength(12)]
        public string Vartex9 { get; set; }
        [Required]
        [Column("VARTEX_10")]
        [StringLength(12)]
        public string Vartex10 { get; set; }
        [Required]
        [Column("VARTEX_11")]
        [StringLength(12)]
        public string Vartex11 { get; set; }
        [Required]
        [Column("VARTEX_12")]
        [StringLength(12)]
        public string Vartex12 { get; set; }
        [Required]
        [Column("VARTEX_13")]
        [StringLength(12)]
        public string Vartex13 { get; set; }
        [Required]
        [Column("VARTEX_14")]
        [StringLength(12)]
        public string Vartex14 { get; set; }
        [Required]
        [Column("VARTEX_15")]
        [StringLength(12)]
        public string Vartex15 { get; set; }
        [Required]
        [Column("VARTEX_16")]
        [StringLength(12)]
        public string Vartex16 { get; set; }
        [Required]
        [Column("VARTEX_17")]
        [StringLength(12)]
        public string Vartex17 { get; set; }
        [Required]
        [Column("VARTEX_18")]
        [StringLength(12)]
        public string Vartex18 { get; set; }
        [Required]
        [Column("VARTEX_19")]
        [StringLength(12)]
        public string Vartex19 { get; set; }
        [Required]
        [Column("VARTEX_20")]
        [StringLength(12)]
        public string Vartex20 { get; set; }
        [Required]
        [Column("VARTEX_21")]
        [StringLength(12)]
        public string Vartex21 { get; set; }
        [Required]
        [Column("VARTEX_22")]
        [StringLength(12)]
        public string Vartex22 { get; set; }
        [Required]
        [Column("VARTEX_23")]
        [StringLength(12)]
        public string Vartex23 { get; set; }
        [Required]
        [Column("VARTEX_24")]
        [StringLength(12)]
        public string Vartex24 { get; set; }
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