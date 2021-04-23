﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PARJAL", Schema = "TESTPROD")]
    [Index(nameof(Mfgfcy0), Name = "PARJAL_PJA0", IsUnique = true)]
    public partial class Parjal
    {
        [Required]
        [Column("MFGFCY_0")]
        [StringLength(5)]
        public string Mfgfcy0 { get; set; }
        [Column("MAXPERNBR_0")]
        public short Maxpernbr0 { get; set; }
        [Column("CUTSTRDAT_0", TypeName = "datetime")]
        public DateTime Cutstrdat0 { get; set; }
        [Column("WKLDAYNBR_0")]
        public short Wkldaynbr0 { get; set; }
        [Column("WKLWEENBR_0")]
        public short Wklweenbr0 { get; set; }
        [Column("WKLMONNBR_0")]
        public short Wklmonnbr0 { get; set; }
        [Column("WKLBUCCOR_0")]
        public byte Wklbuccor0 { get; set; }
        [Column("AUTFRWSCD_0")]
        public byte Autfrwscd0 { get; set; }
        [Column("AUTFRCSCD_0")]
        public byte Autfrcscd0 { get; set; }
        [Column("AUTWIPSCD_0")]
        public byte Autwipscd0 { get; set; }
        [Required]
        [Column("STRTEAM1_0")]
        [StringLength(5)]
        public string Strteam10 { get; set; }
        [Required]
        [Column("STRTEAM2_0")]
        [StringLength(5)]
        public string Strteam20 { get; set; }
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