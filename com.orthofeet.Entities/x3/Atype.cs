﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ATYPE", Schema = "TESTPROD")]
    [Index(nameof(Codtyp0), Name = "ATYPE_CODTYP", IsUnique = true)]
    [Index(nameof(Typtyp0), nameof(Codtyp0), Name = "ATYPE_GLOBVAR", IsUnique = true)]
    public partial class Atype
    {
        [Required]
        [Column("ACTION_0")]
        [StringLength(10)]
        public string Action0 { get; set; }
        [Required]
        [Column("ACTION_1")]
        [StringLength(10)]
        public string Action1 { get; set; }
        [Required]
        [Column("ACTION_2")]
        [StringLength(10)]
        public string Action2 { get; set; }
        [Required]
        [Column("ACTION_3")]
        [StringLength(10)]
        public string Action3 { get; set; }
        [Required]
        [Column("ACTION_4")]
        [StringLength(10)]
        public string Action4 { get; set; }
        [Required]
        [Column("ACTION_5")]
        [StringLength(10)]
        public string Action5 { get; set; }
        [Required]
        [Column("ACTION_6")]
        [StringLength(10)]
        public string Action6 { get; set; }
        [Required]
        [Column("ACTION_7")]
        [StringLength(10)]
        public string Action7 { get; set; }
        [Required]
        [Column("ACTION_8")]
        [StringLength(10)]
        public string Action8 { get; set; }
        [Required]
        [Column("ACTION_9")]
        [StringLength(10)]
        public string Action9 { get; set; }
        [Required]
        [Column("ACTION_10")]
        [StringLength(10)]
        public string Action10 { get; set; }
        [Required]
        [Column("ACTION_11")]
        [StringLength(10)]
        public string Action11 { get; set; }
        [Required]
        [Column("ACTION_12")]
        [StringLength(10)]
        public string Action12 { get; set; }
        [Required]
        [Column("ACTION_13")]
        [StringLength(10)]
        public string Action13 { get; set; }
        [Required]
        [Column("ACTION_14")]
        [StringLength(10)]
        public string Action14 { get; set; }
        [Required]
        [Column("ACTION_15")]
        [StringLength(10)]
        public string Action15 { get; set; }
        [Required]
        [Column("ACTION_16")]
        [StringLength(10)]
        public string Action16 { get; set; }
        [Required]
        [Column("ACTION_17")]
        [StringLength(10)]
        public string Action17 { get; set; }
        [Required]
        [Column("ACTION_18")]
        [StringLength(10)]
        public string Action18 { get; set; }
        [Required]
        [Column("ACTION_19")]
        [StringLength(10)]
        public string Action19 { get; set; }
        [Required]
        [Column("ACTION_20")]
        [StringLength(10)]
        public string Action20 { get; set; }
        [Required]
        [Column("ACTION_21")]
        [StringLength(10)]
        public string Action21 { get; set; }
        [Required]
        [Column("ACTION_22")]
        [StringLength(10)]
        public string Action22 { get; set; }
        [Required]
        [Column("ACTION_23")]
        [StringLength(10)]
        public string Action23 { get; set; }
        [Required]
        [Column("ACTION_24")]
        [StringLength(10)]
        public string Action24 { get; set; }
        [Required]
        [Column("ACTION_25")]
        [StringLength(10)]
        public string Action25 { get; set; }
        [Required]
        [Column("ACTION_26")]
        [StringLength(10)]
        public string Action26 { get; set; }
        [Required]
        [Column("ACTION_27")]
        [StringLength(10)]
        public string Action27 { get; set; }
        [Required]
        [Column("ACTION_28")]
        [StringLength(10)]
        public string Action28 { get; set; }
        [Required]
        [Column("ACTION_29")]
        [StringLength(10)]
        public string Action29 { get; set; }
        [Column("ACTTYP_0")]
        public byte Acttyp0 { get; set; }
        [Column("ACTTYP_1")]
        public byte Acttyp1 { get; set; }
        [Column("ACTTYP_2")]
        public byte Acttyp2 { get; set; }
        [Column("ACTTYP_3")]
        public byte Acttyp3 { get; set; }
        [Column("ACTTYP_4")]
        public byte Acttyp4 { get; set; }
        [Column("ACTTYP_5")]
        public byte Acttyp5 { get; set; }
        [Column("ACTTYP_6")]
        public byte Acttyp6 { get; set; }
        [Column("ACTTYP_7")]
        public byte Acttyp7 { get; set; }
        [Column("ACTTYP_8")]
        public byte Acttyp8 { get; set; }
        [Column("ACTTYP_9")]
        public byte Acttyp9 { get; set; }
        [Column("ACTTYP_10")]
        public byte Acttyp10 { get; set; }
        [Column("ACTTYP_11")]
        public byte Acttyp11 { get; set; }
        [Column("ACTTYP_12")]
        public byte Acttyp12 { get; set; }
        [Column("ACTTYP_13")]
        public byte Acttyp13 { get; set; }
        [Column("ACTTYP_14")]
        public byte Acttyp14 { get; set; }
        [Column("ACTTYP_15")]
        public byte Acttyp15 { get; set; }
        [Column("ACTTYP_16")]
        public byte Acttyp16 { get; set; }
        [Column("ACTTYP_17")]
        public byte Acttyp17 { get; set; }
        [Column("ACTTYP_18")]
        public byte Acttyp18 { get; set; }
        [Column("ACTTYP_19")]
        public byte Acttyp19 { get; set; }
        [Column("ACTTYP_20")]
        public byte Acttyp20 { get; set; }
        [Column("ACTTYP_21")]
        public byte Acttyp21 { get; set; }
        [Column("ACTTYP_22")]
        public byte Acttyp22 { get; set; }
        [Column("ACTTYP_23")]
        public byte Acttyp23 { get; set; }
        [Column("ACTTYP_24")]
        public byte Acttyp24 { get; set; }
        [Column("ACTTYP_25")]
        public byte Acttyp25 { get; set; }
        [Column("ACTTYP_26")]
        public byte Acttyp26 { get; set; }
        [Column("ACTTYP_27")]
        public byte Acttyp27 { get; set; }
        [Column("ACTTYP_28")]
        public byte Acttyp28 { get; set; }
        [Column("ACTTYP_29")]
        public byte Acttyp29 { get; set; }
        [Column("NBTYP_0")]
        public short Nbtyp0 { get; set; }
        [Column("EXEACT_0")]
        public byte Exeact0 { get; set; }
        [Column("EXEACT_1")]
        public byte Exeact1 { get; set; }
        [Column("EXEACT_2")]
        public byte Exeact2 { get; set; }
        [Column("EXEACT_3")]
        public byte Exeact3 { get; set; }
        [Column("EXEACT_4")]
        public byte Exeact4 { get; set; }
        [Column("EXEACT_5")]
        public byte Exeact5 { get; set; }
        [Column("EXEACT_6")]
        public byte Exeact6 { get; set; }
        [Column("EXEACT_7")]
        public byte Exeact7 { get; set; }
        [Column("EXEACT_8")]
        public byte Exeact8 { get; set; }
        [Column("EXEACT_9")]
        public byte Exeact9 { get; set; }
        [Column("EXEACT_10")]
        public byte Exeact10 { get; set; }
        [Column("EXEACT_11")]
        public byte Exeact11 { get; set; }
        [Column("EXEACT_12")]
        public byte Exeact12 { get; set; }
        [Column("EXEACT_13")]
        public byte Exeact13 { get; set; }
        [Column("EXEACT_14")]
        public byte Exeact14 { get; set; }
        [Column("EXEACT_15")]
        public byte Exeact15 { get; set; }
        [Column("EXEACT_16")]
        public byte Exeact16 { get; set; }
        [Column("EXEACT_17")]
        public byte Exeact17 { get; set; }
        [Column("EXEACT_18")]
        public byte Exeact18 { get; set; }
        [Column("EXEACT_19")]
        public byte Exeact19 { get; set; }
        [Column("EXEACT_20")]
        public byte Exeact20 { get; set; }
        [Column("EXEACT_21")]
        public byte Exeact21 { get; set; }
        [Column("EXEACT_22")]
        public byte Exeact22 { get; set; }
        [Column("EXEACT_23")]
        public byte Exeact23 { get; set; }
        [Column("EXEACT_24")]
        public byte Exeact24 { get; set; }
        [Column("EXEACT_25")]
        public byte Exeact25 { get; set; }
        [Column("EXEACT_26")]
        public byte Exeact26 { get; set; }
        [Column("EXEACT_27")]
        public byte Exeact27 { get; set; }
        [Column("EXEACT_28")]
        public byte Exeact28 { get; set; }
        [Column("EXEACT_29")]
        public byte Exeact29 { get; set; }
        [Required]
        [Column("CODACT_0")]
        [StringLength(5)]
        public string Codact0 { get; set; }
        [Required]
        [Column("CODTYP_0")]
        [StringLength(3)]
        public string Codtyp0 { get; set; }
        [Required]
        [Column("FICLIEN_0")]
        [StringLength(12)]
        public string Ficlien0 { get; set; }
        [Required]
        [Column("FORTYP_0")]
        [StringLength(50)]
        public string Fortyp0 { get; set; }
        [Column("INTITTYP_0")]
        public int Intittyp0 { get; set; }
        [Column("LNGTYP_0", TypeName = "numeric(9, 4)")]
        public decimal Lngtyp0 { get; set; }
        [Column("NOLIB_0")]
        public short Nolib0 { get; set; }
        [Required]
        [Column("OBJLIEN_0")]
        [StringLength(3)]
        public string Objlien0 { get; set; }
        [Required]
        [Column("OPTION_0")]
        [StringLength(10)]
        public string Option0 { get; set; }
        [Column("TYPTYP_0")]
        public byte Typtyp0 { get; set; }
        [Required]
        [Column("VALDEF_0")]
        [StringLength(80)]
        public string Valdef0 { get; set; }
        [Column("OPTTAB_0")]
        public byte Opttab0 { get; set; }
        [Required]
        [Column("PARTAB_0")]
        [StringLength(10)]
        public string Partab0 { get; set; }
        [Required]
        [Column("VARTAB_0")]
        [StringLength(15)]
        public string Vartab0 { get; set; }
        [Column("MODULE_0")]
        public byte Module0 { get; set; }
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