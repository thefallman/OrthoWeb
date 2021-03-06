// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ITCMATCH", Schema = "TESTPROD")]
    [Index(nameof(Pronum0), nameof(Itmref0), Name = "ITCMATCH_ITC0", IsUnique = true)]
    public partial class Itcmatch
    {
        [Column("PRONUM_0")]
        public int Pronum0 { get; set; }
        [Column("AFFUNI_0")]
        public byte Affuni0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("STOFCY1_0")]
        [StringLength(5)]
        public string Stofcy10 { get; set; }
        [Required]
        [Column("STOFCY2_0")]
        [StringLength(5)]
        public string Stofcy20 { get; set; }
        [Column("CSTTYP1_0")]
        public byte Csttyp10 { get; set; }
        [Column("CSTTYP2_0")]
        public byte Csttyp20 { get; set; }
        [Column("ITCSTRDAT1_0", TypeName = "datetime")]
        public DateTime Itcstrdat10 { get; set; }
        [Column("ITCENDDAT1_0", TypeName = "datetime")]
        public DateTime Itcenddat10 { get; set; }
        [Column("ITCSTRDAT2_0", TypeName = "datetime")]
        public DateTime Itcstrdat20 { get; set; }
        [Column("ITCENDDAT2_0", TypeName = "datetime")]
        public DateTime Itcenddat20 { get; set; }
        [Column("ITCSEQ1_0")]
        public short Itcseq10 { get; set; }
        [Column("ITCSEQ2_0")]
        public short Itcseq20 { get; set; }
        [Column("ITCDAT1_0", TypeName = "datetime")]
        public DateTime Itcdat10 { get; set; }
        [Column("ITCDAT2_0", TypeName = "datetime")]
        public DateTime Itcdat20 { get; set; }
        [Required]
        [Column("VCRNUM1_0")]
        [StringLength(20)]
        public string Vcrnum10 { get; set; }
        [Column("VCRLIN1_0")]
        public int Vcrlin10 { get; set; }
        [Required]
        [Column("VCRNUM2_0")]
        [StringLength(20)]
        public string Vcrnum20 { get; set; }
        [Column("VCRLIN2_0")]
        public int Vcrlin20 { get; set; }
        [Column("MATTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Mattot0 { get; set; }
        [Column("MATTOT2_0", TypeName = "numeric(19, 5)")]
        public decimal Mattot20 { get; set; }
        [Column("MACTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Mactot0 { get; set; }
        [Column("MACTOT2_0", TypeName = "numeric(19, 5)")]
        public decimal Mactot20 { get; set; }
        [Column("LABTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Labtot0 { get; set; }
        [Column("LABTOT2_0", TypeName = "numeric(19, 5)")]
        public decimal Labtot20 { get; set; }
        [Column("SCOTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Scotot0 { get; set; }
        [Column("SCOTOT2_0", TypeName = "numeric(19, 5)")]
        public decimal Scotot20 { get; set; }
        [Column("INVDTA_0", TypeName = "numeric(19, 5)")]
        public decimal Invdta0 { get; set; }
        [Column("INVDTA2_0", TypeName = "numeric(19, 5)")]
        public decimal Invdta20 { get; set; }
        [Column("OVETOT_0", TypeName = "numeric(19, 5)")]
        public decimal Ovetot0 { get; set; }
        [Column("OVETOT2_0", TypeName = "numeric(19, 5)")]
        public decimal Ovetot20 { get; set; }
        [Column("CSTTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Csttot0 { get; set; }
        [Column("CSTTOT2_0", TypeName = "numeric(19, 5)")]
        public decimal Csttot20 { get; set; }
        [Column("VLTTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Vlttot0 { get; set; }
        [Column("VLTTOT2_0", TypeName = "numeric(19, 5)")]
        public decimal Vlttot20 { get; set; }
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
        [Column("MATCST2_0", TypeName = "numeric(19, 5)")]
        public decimal Matcst20 { get; set; }
        [Column("MATCST2_1", TypeName = "numeric(19, 5)")]
        public decimal Matcst21 { get; set; }
        [Column("MATCST2_2", TypeName = "numeric(19, 5)")]
        public decimal Matcst22 { get; set; }
        [Column("MATCST2_3", TypeName = "numeric(19, 5)")]
        public decimal Matcst23 { get; set; }
        [Column("MATCST2_4", TypeName = "numeric(19, 5)")]
        public decimal Matcst24 { get; set; }
        [Column("MATCST2_5", TypeName = "numeric(19, 5)")]
        public decimal Matcst25 { get; set; }
        [Column("MATCST2_6", TypeName = "numeric(19, 5)")]
        public decimal Matcst26 { get; set; }
        [Column("MATCST2_7", TypeName = "numeric(19, 5)")]
        public decimal Matcst27 { get; set; }
        [Column("MATCST2_8", TypeName = "numeric(19, 5)")]
        public decimal Matcst28 { get; set; }
        [Column("MATCST2_9", TypeName = "numeric(19, 5)")]
        public decimal Matcst29 { get; set; }
        [Column("MATCST2_10", TypeName = "numeric(19, 5)")]
        public decimal Matcst210 { get; set; }
        [Column("MATCST2_11", TypeName = "numeric(19, 5)")]
        public decimal Matcst211 { get; set; }
        [Column("MATCST2_12", TypeName = "numeric(19, 5)")]
        public decimal Matcst212 { get; set; }
        [Column("MATCST2_13", TypeName = "numeric(19, 5)")]
        public decimal Matcst213 { get; set; }
        [Column("MATCST2_14", TypeName = "numeric(19, 5)")]
        public decimal Matcst214 { get; set; }
        [Column("MATCST2_15", TypeName = "numeric(19, 5)")]
        public decimal Matcst215 { get; set; }
        [Column("MATCST2_16", TypeName = "numeric(19, 5)")]
        public decimal Matcst216 { get; set; }
        [Column("MATCST2_17", TypeName = "numeric(19, 5)")]
        public decimal Matcst217 { get; set; }
        [Column("MATCST2_18", TypeName = "numeric(19, 5)")]
        public decimal Matcst218 { get; set; }
        [Column("MATCST2_19", TypeName = "numeric(19, 5)")]
        public decimal Matcst219 { get; set; }
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
        [Column("MACCST2_0", TypeName = "numeric(19, 5)")]
        public decimal Maccst20 { get; set; }
        [Column("MACCST2_1", TypeName = "numeric(19, 5)")]
        public decimal Maccst21 { get; set; }
        [Column("MACCST2_2", TypeName = "numeric(19, 5)")]
        public decimal Maccst22 { get; set; }
        [Column("MACCST2_3", TypeName = "numeric(19, 5)")]
        public decimal Maccst23 { get; set; }
        [Column("MACCST2_4", TypeName = "numeric(19, 5)")]
        public decimal Maccst24 { get; set; }
        [Column("MACCST2_5", TypeName = "numeric(19, 5)")]
        public decimal Maccst25 { get; set; }
        [Column("MACCST2_6", TypeName = "numeric(19, 5)")]
        public decimal Maccst26 { get; set; }
        [Column("MACCST2_7", TypeName = "numeric(19, 5)")]
        public decimal Maccst27 { get; set; }
        [Column("MACCST2_8", TypeName = "numeric(19, 5)")]
        public decimal Maccst28 { get; set; }
        [Column("MACCST2_9", TypeName = "numeric(19, 5)")]
        public decimal Maccst29 { get; set; }
        [Column("MACCST2_10", TypeName = "numeric(19, 5)")]
        public decimal Maccst210 { get; set; }
        [Column("MACCST2_11", TypeName = "numeric(19, 5)")]
        public decimal Maccst211 { get; set; }
        [Column("MACCST2_12", TypeName = "numeric(19, 5)")]
        public decimal Maccst212 { get; set; }
        [Column("MACCST2_13", TypeName = "numeric(19, 5)")]
        public decimal Maccst213 { get; set; }
        [Column("MACCST2_14", TypeName = "numeric(19, 5)")]
        public decimal Maccst214 { get; set; }
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
        [Column("LABCST2_0", TypeName = "numeric(19, 5)")]
        public decimal Labcst20 { get; set; }
        [Column("LABCST2_1", TypeName = "numeric(19, 5)")]
        public decimal Labcst21 { get; set; }
        [Column("LABCST2_2", TypeName = "numeric(19, 5)")]
        public decimal Labcst22 { get; set; }
        [Column("LABCST2_3", TypeName = "numeric(19, 5)")]
        public decimal Labcst23 { get; set; }
        [Column("LABCST2_4", TypeName = "numeric(19, 5)")]
        public decimal Labcst24 { get; set; }
        [Column("LABCST2_5", TypeName = "numeric(19, 5)")]
        public decimal Labcst25 { get; set; }
        [Column("LABCST2_6", TypeName = "numeric(19, 5)")]
        public decimal Labcst26 { get; set; }
        [Column("LABCST2_7", TypeName = "numeric(19, 5)")]
        public decimal Labcst27 { get; set; }
        [Column("LABCST2_8", TypeName = "numeric(19, 5)")]
        public decimal Labcst28 { get; set; }
        [Column("LABCST2_9", TypeName = "numeric(19, 5)")]
        public decimal Labcst29 { get; set; }
        [Column("LABCST2_10", TypeName = "numeric(19, 5)")]
        public decimal Labcst210 { get; set; }
        [Column("LABCST2_11", TypeName = "numeric(19, 5)")]
        public decimal Labcst211 { get; set; }
        [Column("LABCST2_12", TypeName = "numeric(19, 5)")]
        public decimal Labcst212 { get; set; }
        [Column("LABCST2_13", TypeName = "numeric(19, 5)")]
        public decimal Labcst213 { get; set; }
        [Column("LABCST2_14", TypeName = "numeric(19, 5)")]
        public decimal Labcst214 { get; set; }
        [Column("SCOCST_0", TypeName = "numeric(19, 5)")]
        public decimal Scocst0 { get; set; }
        [Column("SCOCST2_0", TypeName = "numeric(19, 5)")]
        public decimal Scocst20 { get; set; }
        [Column("OVEMATCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovematcst0 { get; set; }
        [Column("OVEMATCST2_0", TypeName = "numeric(19, 5)")]
        public decimal Ovematcst20 { get; set; }
        [Column("OVEMACCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovemaccst0 { get; set; }
        [Column("OVEMACCST2_0", TypeName = "numeric(19, 5)")]
        public decimal Ovemaccst20 { get; set; }
        [Column("OVELABCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovelabcst0 { get; set; }
        [Column("OVELABCST2_0", TypeName = "numeric(19, 5)")]
        public decimal Ovelabcst20 { get; set; }
        [Column("OVESCOCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovescocst0 { get; set; }
        [Column("OVESCOCST2_0", TypeName = "numeric(19, 5)")]
        public decimal Ovescocst20 { get; set; }
        [Column("CLCQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Clcqty0 { get; set; }
        [Column("CLCQTY2_0", TypeName = "numeric(28, 13)")]
        public decimal Clcqty20 { get; set; }
        [Column("DESCEND_0")]
        public byte Descend0 { get; set; }
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