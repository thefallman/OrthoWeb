﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("MFCSCRAP", Schema = "TESTPROD")]
    [Index(nameof(Stofcy0), nameof(Itmref0), nameof(Vcrtyp0), nameof(Vcrnum0), nameof(Vcrlin0), nameof(Mfctyp0), nameof(Uid0), Name = "MFCSCRAP_MCS0", IsUnique = true)]
    public partial class Mfcscrap
    {
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("VCRTYP_0")]
        public byte Vcrtyp0 { get; set; }
        [Required]
        [Column("VCRNUM_0")]
        [StringLength(20)]
        public string Vcrnum0 { get; set; }
        [Column("VCRLIN_0")]
        public int Vcrlin0 { get; set; }
        [Column("MFCTYP_0")]
        public byte Mfctyp0 { get; set; }
        [Column("UID_0")]
        public int Uid0 { get; set; }
        [Column("MATTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Mattot0 { get; set; }
        [Column("MACTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Mactot0 { get; set; }
        [Column("LABTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Labtot0 { get; set; }
        [Column("SCOTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Scotot0 { get; set; }
        [Column("OVETOT_0", TypeName = "numeric(19, 5)")]
        public decimal Ovetot0 { get; set; }
        [Column("CSTTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Csttot0 { get; set; }
        [Column("MATCST_0", TypeName = "numeric(19, 5)")]
        public decimal Matcst0 { get; set; }
        [Column("MATCST_1", TypeName = "numeric(19, 5)")]
        public decimal Matcst1 { get; set; }
        [Column("MATCST_2", TypeName = "numeric(19, 5)")]
        public decimal Matcst2 { get; set; }
        [Column("MATCST_3", TypeName = "numeric(19, 5)")]
        public decimal Matcst3 { get; set; }
        [Column("MATCST_4", TypeName = "numeric(19, 5)")]
        public decimal Matcst4 { get; set; }
        [Column("MATCST_5", TypeName = "numeric(19, 5)")]
        public decimal Matcst5 { get; set; }
        [Column("MATCST_6", TypeName = "numeric(19, 5)")]
        public decimal Matcst6 { get; set; }
        [Column("MATCST_7", TypeName = "numeric(19, 5)")]
        public decimal Matcst7 { get; set; }
        [Column("MATCST_8", TypeName = "numeric(19, 5)")]
        public decimal Matcst8 { get; set; }
        [Column("MATCST_9", TypeName = "numeric(19, 5)")]
        public decimal Matcst9 { get; set; }
        [Column("MATCST_10", TypeName = "numeric(19, 5)")]
        public decimal Matcst10 { get; set; }
        [Column("MATCST_11", TypeName = "numeric(19, 5)")]
        public decimal Matcst11 { get; set; }
        [Column("MATCST_12", TypeName = "numeric(19, 5)")]
        public decimal Matcst12 { get; set; }
        [Column("MATCST_13", TypeName = "numeric(19, 5)")]
        public decimal Matcst13 { get; set; }
        [Column("MATCST_14", TypeName = "numeric(19, 5)")]
        public decimal Matcst14 { get; set; }
        [Column("MATCST_15", TypeName = "numeric(19, 5)")]
        public decimal Matcst15 { get; set; }
        [Column("MATCST_16", TypeName = "numeric(19, 5)")]
        public decimal Matcst16 { get; set; }
        [Column("MATCST_17", TypeName = "numeric(19, 5)")]
        public decimal Matcst17 { get; set; }
        [Column("MATCST_18", TypeName = "numeric(19, 5)")]
        public decimal Matcst18 { get; set; }
        [Column("MATCST_19", TypeName = "numeric(19, 5)")]
        public decimal Matcst19 { get; set; }
        [Column("MACCST_0", TypeName = "numeric(19, 5)")]
        public decimal Maccst0 { get; set; }
        [Column("MACCST_1", TypeName = "numeric(19, 5)")]
        public decimal Maccst1 { get; set; }
        [Column("MACCST_2", TypeName = "numeric(19, 5)")]
        public decimal Maccst2 { get; set; }
        [Column("MACCST_3", TypeName = "numeric(19, 5)")]
        public decimal Maccst3 { get; set; }
        [Column("MACCST_4", TypeName = "numeric(19, 5)")]
        public decimal Maccst4 { get; set; }
        [Column("MACCST_5", TypeName = "numeric(19, 5)")]
        public decimal Maccst5 { get; set; }
        [Column("MACCST_6", TypeName = "numeric(19, 5)")]
        public decimal Maccst6 { get; set; }
        [Column("MACCST_7", TypeName = "numeric(19, 5)")]
        public decimal Maccst7 { get; set; }
        [Column("MACCST_8", TypeName = "numeric(19, 5)")]
        public decimal Maccst8 { get; set; }
        [Column("MACCST_9", TypeName = "numeric(19, 5)")]
        public decimal Maccst9 { get; set; }
        [Column("MACCST_10", TypeName = "numeric(19, 5)")]
        public decimal Maccst10 { get; set; }
        [Column("MACCST_11", TypeName = "numeric(19, 5)")]
        public decimal Maccst11 { get; set; }
        [Column("MACCST_12", TypeName = "numeric(19, 5)")]
        public decimal Maccst12 { get; set; }
        [Column("MACCST_13", TypeName = "numeric(19, 5)")]
        public decimal Maccst13 { get; set; }
        [Column("MACCST_14", TypeName = "numeric(19, 5)")]
        public decimal Maccst14 { get; set; }
        [Column("LABCST_0", TypeName = "numeric(19, 5)")]
        public decimal Labcst0 { get; set; }
        [Column("LABCST_1", TypeName = "numeric(19, 5)")]
        public decimal Labcst1 { get; set; }
        [Column("LABCST_2", TypeName = "numeric(19, 5)")]
        public decimal Labcst2 { get; set; }
        [Column("LABCST_3", TypeName = "numeric(19, 5)")]
        public decimal Labcst3 { get; set; }
        [Column("LABCST_4", TypeName = "numeric(19, 5)")]
        public decimal Labcst4 { get; set; }
        [Column("LABCST_5", TypeName = "numeric(19, 5)")]
        public decimal Labcst5 { get; set; }
        [Column("LABCST_6", TypeName = "numeric(19, 5)")]
        public decimal Labcst6 { get; set; }
        [Column("LABCST_7", TypeName = "numeric(19, 5)")]
        public decimal Labcst7 { get; set; }
        [Column("LABCST_8", TypeName = "numeric(19, 5)")]
        public decimal Labcst8 { get; set; }
        [Column("LABCST_9", TypeName = "numeric(19, 5)")]
        public decimal Labcst9 { get; set; }
        [Column("LABCST_10", TypeName = "numeric(19, 5)")]
        public decimal Labcst10 { get; set; }
        [Column("LABCST_11", TypeName = "numeric(19, 5)")]
        public decimal Labcst11 { get; set; }
        [Column("LABCST_12", TypeName = "numeric(19, 5)")]
        public decimal Labcst12 { get; set; }
        [Column("LABCST_13", TypeName = "numeric(19, 5)")]
        public decimal Labcst13 { get; set; }
        [Column("LABCST_14", TypeName = "numeric(19, 5)")]
        public decimal Labcst14 { get; set; }
        [Column("SCOCST_0", TypeName = "numeric(19, 5)")]
        public decimal Scocst0 { get; set; }
        [Column("OVEMATCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovematcst0 { get; set; }
        [Column("OVEMACCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovemaccst0 { get; set; }
        [Column("OVELABCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovelabcst0 { get; set; }
        [Column("OVESCOCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovescocst0 { get; set; }
        [Column("QTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Qtystu0 { get; set; }
        [Column("MATCPNCST_0", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst0 { get; set; }
        [Column("MATCPNCST_1", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst1 { get; set; }
        [Column("MATCPNCST_2", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst2 { get; set; }
        [Column("MATCPNCST_3", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst3 { get; set; }
        [Column("MATCPNCST_4", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst4 { get; set; }
        [Column("MATCPNCST_5", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst5 { get; set; }
        [Column("MATCPNCST_6", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst6 { get; set; }
        [Column("MATCPNCST_7", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst7 { get; set; }
        [Column("MATCPNCST_8", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst8 { get; set; }
        [Column("MATCPNCST_9", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst9 { get; set; }
        [Column("MATCPNCST_10", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst10 { get; set; }
        [Column("MATCPNCST_11", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst11 { get; set; }
        [Column("MATCPNCST_12", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst12 { get; set; }
        [Column("MATCPNCST_13", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst13 { get; set; }
        [Column("MATCPNCST_14", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst14 { get; set; }
        [Column("MATCPNCST_15", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst15 { get; set; }
        [Column("MATCPNCST_16", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst16 { get; set; }
        [Column("MATCPNCST_17", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst17 { get; set; }
        [Column("MATCPNCST_18", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst18 { get; set; }
        [Column("MATCPNCST_19", TypeName = "numeric(19, 5)")]
        public decimal Matcpncst19 { get; set; }
        [Column("MACCPNCST_0", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst0 { get; set; }
        [Column("MACCPNCST_1", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst1 { get; set; }
        [Column("MACCPNCST_2", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst2 { get; set; }
        [Column("MACCPNCST_3", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst3 { get; set; }
        [Column("MACCPNCST_4", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst4 { get; set; }
        [Column("MACCPNCST_5", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst5 { get; set; }
        [Column("MACCPNCST_6", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst6 { get; set; }
        [Column("MACCPNCST_7", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst7 { get; set; }
        [Column("MACCPNCST_8", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst8 { get; set; }
        [Column("MACCPNCST_9", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst9 { get; set; }
        [Column("MACCPNCST_10", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst10 { get; set; }
        [Column("MACCPNCST_11", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst11 { get; set; }
        [Column("MACCPNCST_12", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst12 { get; set; }
        [Column("MACCPNCST_13", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst13 { get; set; }
        [Column("MACCPNCST_14", TypeName = "numeric(19, 5)")]
        public decimal Maccpncst14 { get; set; }
        [Column("LABCPNCST_0", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst0 { get; set; }
        [Column("LABCPNCST_1", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst1 { get; set; }
        [Column("LABCPNCST_2", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst2 { get; set; }
        [Column("LABCPNCST_3", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst3 { get; set; }
        [Column("LABCPNCST_4", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst4 { get; set; }
        [Column("LABCPNCST_5", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst5 { get; set; }
        [Column("LABCPNCST_6", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst6 { get; set; }
        [Column("LABCPNCST_7", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst7 { get; set; }
        [Column("LABCPNCST_8", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst8 { get; set; }
        [Column("LABCPNCST_9", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst9 { get; set; }
        [Column("LABCPNCST_10", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst10 { get; set; }
        [Column("LABCPNCST_11", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst11 { get; set; }
        [Column("LABCPNCST_12", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst12 { get; set; }
        [Column("LABCPNCST_13", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst13 { get; set; }
        [Column("LABCPNCST_14", TypeName = "numeric(19, 5)")]
        public decimal Labcpncst14 { get; set; }
        [Column("OVECPNCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovecpncst0 { get; set; }
        [Column("SCOCPNCST_0", TypeName = "numeric(19, 5)")]
        public decimal Scocpncst0 { get; set; }
        [Column("OVEMATCPN_0", TypeName = "numeric(19, 5)")]
        public decimal Ovematcpn0 { get; set; }
        [Column("OVEMACCPN_0", TypeName = "numeric(19, 5)")]
        public decimal Ovemaccpn0 { get; set; }
        [Column("OVELABCPN_0", TypeName = "numeric(19, 5)")]
        public decimal Ovelabcpn0 { get; set; }
        [Column("OVESCOCPN_0", TypeName = "numeric(19, 5)")]
        public decimal Ovescocpn0 { get; set; }
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