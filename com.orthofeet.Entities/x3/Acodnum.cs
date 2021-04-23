﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ACODNUM", Schema = "TESTPROD")]
    [Index(nameof(Codnum0), Name = "ACODNUM_ANM0", IsUnique = true)]
    public partial class Acodnum
    {
        [Required]
        [Column("CODNUM_0")]
        [StringLength(5)]
        public string Codnum0 { get; set; }
        [Column("LNG_0")]
        public short Lng0 { get; set; }
        [Column("NIVDEF_0")]
        public byte Nivdef0 { get; set; }
        [Column("NIVRAZ_0")]
        public byte Nivraz0 { get; set; }
        [Column("TYP_0")]
        public byte Typ0 { get; set; }
        [Column("NBPOS_0")]
        public short Nbpos0 { get; set; }
        [Column("POSTYP_0")]
        public byte Postyp0 { get; set; }
        [Column("POSTYP_1")]
        public byte Postyp1 { get; set; }
        [Column("POSTYP_2")]
        public byte Postyp2 { get; set; }
        [Column("POSTYP_3")]
        public byte Postyp3 { get; set; }
        [Column("POSTYP_4")]
        public byte Postyp4 { get; set; }
        [Column("POSTYP_5")]
        public byte Postyp5 { get; set; }
        [Column("POSTYP_6")]
        public byte Postyp6 { get; set; }
        [Column("POSTYP_7")]
        public byte Postyp7 { get; set; }
        [Column("POSTYP_8")]
        public byte Postyp8 { get; set; }
        [Column("POSTYP_9")]
        public byte Postyp9 { get; set; }
        [Column("POSLNG_0")]
        public short Poslng0 { get; set; }
        [Column("POSLNG_1")]
        public short Poslng1 { get; set; }
        [Column("POSLNG_2")]
        public short Poslng2 { get; set; }
        [Column("POSLNG_3")]
        public short Poslng3 { get; set; }
        [Column("POSLNG_4")]
        public short Poslng4 { get; set; }
        [Column("POSLNG_5")]
        public short Poslng5 { get; set; }
        [Column("POSLNG_6")]
        public short Poslng6 { get; set; }
        [Column("POSLNG_7")]
        public short Poslng7 { get; set; }
        [Column("POSLNG_8")]
        public short Poslng8 { get; set; }
        [Column("POSLNG_9")]
        public short Poslng9 { get; set; }
        [Required]
        [Column("POSCTE_0")]
        [StringLength(80)]
        public string Poscte0 { get; set; }
        [Required]
        [Column("POSCTE_1")]
        [StringLength(80)]
        public string Poscte1 { get; set; }
        [Required]
        [Column("POSCTE_2")]
        [StringLength(80)]
        public string Poscte2 { get; set; }
        [Required]
        [Column("POSCTE_3")]
        [StringLength(80)]
        public string Poscte3 { get; set; }
        [Required]
        [Column("POSCTE_4")]
        [StringLength(80)]
        public string Poscte4 { get; set; }
        [Required]
        [Column("POSCTE_5")]
        [StringLength(80)]
        public string Poscte5 { get; set; }
        [Required]
        [Column("POSCTE_6")]
        [StringLength(80)]
        public string Poscte6 { get; set; }
        [Required]
        [Column("POSCTE_7")]
        [StringLength(80)]
        public string Poscte7 { get; set; }
        [Required]
        [Column("POSCTE_8")]
        [StringLength(80)]
        public string Poscte8 { get; set; }
        [Required]
        [Column("POSCTE_9")]
        [StringLength(80)]
        public string Poscte9 { get; set; }
        [Column("CTLCHR_0")]
        public byte Ctlchr0 { get; set; }
        [Column("ZERO_0")]
        public byte Zero0 { get; set; }
        [Column("SEQ_0")]
        public byte Seq0 { get; set; }
        [Required]
        [Column("SEQTBL_0")]
        [StringLength(12)]
        public string Seqtbl0 { get; set; }
        [Required]
        [Column("SEQABR_0")]
        [StringLength(5)]
        public string Seqabr0 { get; set; }
        [Column("SEQNBR_0")]
        public short Seqnbr0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}