﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TMPMASLEA", Schema = "TESTPROD")]
    [Index(nameof(Trtnum0), nameof(Objref0), Name = "TMPMASLEA_MFS0", IsUnique = true)]
    [Index(nameof(Trtnum0), nameof(Cpy0), nameof(Objref0), Name = "TMPMASLEA_MFS1", IsUnique = true)]
    public partial class Tmpmaslea
    {
        [Column("TRTNUM_0")]
        public int Trtnum0 { get; set; }
        [Required]
        [Column("OBJREF_0")]
        [StringLength(20)]
        public string Objref0 { get; set; }
        [Column("FLGERR_0")]
        public byte Flgerr0 { get; set; }
        [Required]
        [Column("MSGERR_0")]
        [StringLength(100)]
        public string Msgerr0 { get; set; }
        [Column("FLGMOD_0")]
        public byte Flgmod0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCYO_0")]
        [StringLength(5)]
        public string Fcyo0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Column("MVTDAT_0", TypeName = "datetime")]
        public DateTime Mvtdat0 { get; set; }
        [Required]
        [Column("LEAREF_0")]
        [StringLength(20)]
        public string Learef0 { get; set; }
        [Required]
        [Column("LEADES_0")]
        [StringLength(60)]
        public string Leades0 { get; set; }
        [Column("LEASTA_0")]
        public byte Leasta0 { get; set; }
        [Column("LEATYP_0")]
        public byte Leatyp0 { get; set; }
        [Required]
        [Column("LES_0")]
        [StringLength(15)]
        public string Les0 { get; set; }
        [Column("LEAORI_0")]
        public byte Leaori0 { get; set; }
        [Column("STRLEADAT_0", TypeName = "datetime")]
        public DateTime Strleadat0 { get; set; }
        [Column("ENDLEADAT_0", TypeName = "datetime")]
        public DateTime Endleadat0 { get; set; }
        [Column("TRMLEADAT_0", TypeName = "datetime")]
        public DateTime Trmleadat0 { get; set; }
        [Column("LEANAT_0")]
        public byte Leanat0 { get; set; }
        [Column("BSENAT_0")]
        public byte Bsenat0 { get; set; }
        [Required]
        [Column("ACCCOD_0")]
        [StringLength(10)]
        public string Acccod0 { get; set; }
        [Required]
        [Column("DSP_0")]
        [StringLength(10)]
        public string Dsp0 { get; set; }
        [Required]
        [Column("DIE_0")]
        [StringLength(3)]
        public string Die0 { get; set; }
        [Required]
        [Column("DIE_1")]
        [StringLength(3)]
        public string Die1 { get; set; }
        [Required]
        [Column("DIE_2")]
        [StringLength(3)]
        public string Die2 { get; set; }
        [Required]
        [Column("DIE_3")]
        [StringLength(3)]
        public string Die3 { get; set; }
        [Required]
        [Column("DIE_4")]
        [StringLength(3)]
        public string Die4 { get; set; }
        [Required]
        [Column("DIE_5")]
        [StringLength(3)]
        public string Die5 { get; set; }
        [Required]
        [Column("DIE_6")]
        [StringLength(3)]
        public string Die6 { get; set; }
        [Required]
        [Column("DIE_7")]
        [StringLength(3)]
        public string Die7 { get; set; }
        [Required]
        [Column("DIE_8")]
        [StringLength(3)]
        public string Die8 { get; set; }
        [Required]
        [Column("DIE_9")]
        [StringLength(3)]
        public string Die9 { get; set; }
        [Required]
        [Column("DIE_10")]
        [StringLength(3)]
        public string Die10 { get; set; }
        [Required]
        [Column("DIE_11")]
        [StringLength(3)]
        public string Die11 { get; set; }
        [Required]
        [Column("DIE_12")]
        [StringLength(3)]
        public string Die12 { get; set; }
        [Required]
        [Column("DIE_13")]
        [StringLength(3)]
        public string Die13 { get; set; }
        [Required]
        [Column("DIE_14")]
        [StringLength(3)]
        public string Die14 { get; set; }
        [Required]
        [Column("DIE_15")]
        [StringLength(3)]
        public string Die15 { get; set; }
        [Required]
        [Column("DIE_16")]
        [StringLength(3)]
        public string Die16 { get; set; }
        [Required]
        [Column("DIE_17")]
        [StringLength(3)]
        public string Die17 { get; set; }
        [Required]
        [Column("DIE_18")]
        [StringLength(3)]
        public string Die18 { get; set; }
        [Required]
        [Column("DIE_19")]
        [StringLength(3)]
        public string Die19 { get; set; }
        [Required]
        [Column("CCE_0")]
        [StringLength(15)]
        public string Cce0 { get; set; }
        [Required]
        [Column("CCE_1")]
        [StringLength(15)]
        public string Cce1 { get; set; }
        [Required]
        [Column("CCE_2")]
        [StringLength(15)]
        public string Cce2 { get; set; }
        [Required]
        [Column("CCE_3")]
        [StringLength(15)]
        public string Cce3 { get; set; }
        [Required]
        [Column("CCE_4")]
        [StringLength(15)]
        public string Cce4 { get; set; }
        [Required]
        [Column("CCE_5")]
        [StringLength(15)]
        public string Cce5 { get; set; }
        [Required]
        [Column("CCE_6")]
        [StringLength(15)]
        public string Cce6 { get; set; }
        [Required]
        [Column("CCE_7")]
        [StringLength(15)]
        public string Cce7 { get; set; }
        [Required]
        [Column("CCE_8")]
        [StringLength(15)]
        public string Cce8 { get; set; }
        [Required]
        [Column("CCE_9")]
        [StringLength(15)]
        public string Cce9 { get; set; }
        [Required]
        [Column("CCE_10")]
        [StringLength(15)]
        public string Cce10 { get; set; }
        [Required]
        [Column("CCE_11")]
        [StringLength(15)]
        public string Cce11 { get; set; }
        [Required]
        [Column("CCE_12")]
        [StringLength(15)]
        public string Cce12 { get; set; }
        [Required]
        [Column("CCE_13")]
        [StringLength(15)]
        public string Cce13 { get; set; }
        [Required]
        [Column("CCE_14")]
        [StringLength(15)]
        public string Cce14 { get; set; }
        [Required]
        [Column("CCE_15")]
        [StringLength(15)]
        public string Cce15 { get; set; }
        [Required]
        [Column("CCE_16")]
        [StringLength(15)]
        public string Cce16 { get; set; }
        [Required]
        [Column("CCE_17")]
        [StringLength(15)]
        public string Cce17 { get; set; }
        [Required]
        [Column("CCE_18")]
        [StringLength(15)]
        public string Cce18 { get; set; }
        [Required]
        [Column("CCE_19")]
        [StringLength(15)]
        public string Cce19 { get; set; }
        [Required]
        [Column("LEACUR_0")]
        [StringLength(3)]
        public string Leacur0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("CURTYP_0")]
        public byte Curtyp0 { get; set; }
        [Column("LEAAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Leaamt0 { get; set; }
        [Column("STRPERDAT_0", TypeName = "datetime")]
        public DateTime Strperdat0 { get; set; }
        [Column("ENDPERDAT_0", TypeName = "datetime")]
        public DateTime Endperdat0 { get; set; }
        [Column("RNTAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Rntamt0 { get; set; }
        [Column("FINDPR_0", TypeName = "numeric(27, 13)")]
        public decimal Findpr0 { get; set; }
        [Column("FINEXS_0", TypeName = "numeric(27, 13)")]
        public decimal Finexs0 { get; set; }
        [Column("PAYDAT_0", TypeName = "datetime")]
        public DateTime Paydat0 { get; set; }
        [Required]
        [Column("PAYREF_0")]
        [StringLength(20)]
        public string Payref0 { get; set; }
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