﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("ITMCOST", Schema = "TESTPROD")]
    [Index(nameof(Stofcy0), nameof(Itmref0), nameof(Csttyp0), nameof(Itcseq0), nameof(Uid0), Name = "ITMCOST_ITC0", IsUnique = true)]
    [Index(nameof(Stofcy0), nameof(Itmref0), nameof(Csttyp0), nameof(Itcstrdat0), nameof(Itcseq0), Name = "ITMCOST_ITC1")]
    [Index(nameof(Stofcy0), nameof(Itmref0), nameof(Csttyp0), nameof(Itcenddat0), nameof(Itcseq0), Name = "ITMCOST_ITC2")]
    public partial class Itmcost
    {
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("ITCSEQ_0")]
        public int Itcseq0 { get; set; }
        [Column("CSTTYP_0")]
        public byte Csttyp0 { get; set; }
        [Column("YEA_0")]
        public short Yea0 { get; set; }
        [Column("ITCSTRDAT_0", TypeName = "datetime")]
        public DateTime Itcstrdat0 { get; set; }
        [Column("ITCENDDAT_0", TypeName = "datetime")]
        public DateTime Itcenddat0 { get; set; }
        [Column("CSTSEQ_0")]
        public short Cstseq0 { get; set; }
        [Column("UID_0")]
        public int Uid0 { get; set; }
        [Column("FIYNUM_0")]
        public short Fiynum0 { get; set; }
        [Column("ITCDAT_0", TypeName = "datetime")]
        public DateTime Itcdat0 { get; set; }
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
        [Column("VLTTOT_0", TypeName = "numeric(19, 5)")]
        public decimal Vlttot0 { get; set; }
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
        [Column("FXDMATCST_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst0 { get; set; }
        [Column("FXDMATCST_1", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst1 { get; set; }
        [Column("FXDMATCST_2", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst2 { get; set; }
        [Column("FXDMATCST_3", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst3 { get; set; }
        [Column("FXDMATCST_4", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst4 { get; set; }
        [Column("FXDMATCST_5", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst5 { get; set; }
        [Column("FXDMATCST_6", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst6 { get; set; }
        [Column("FXDMATCST_7", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst7 { get; set; }
        [Column("FXDMATCST_8", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst8 { get; set; }
        [Column("FXDMATCST_9", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst9 { get; set; }
        [Column("FXDMATCST_10", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst10 { get; set; }
        [Column("FXDMATCST_11", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst11 { get; set; }
        [Column("FXDMATCST_12", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst12 { get; set; }
        [Column("FXDMATCST_13", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst13 { get; set; }
        [Column("FXDMATCST_14", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst14 { get; set; }
        [Column("FXDMATCST_15", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst15 { get; set; }
        [Column("FXDMATCST_16", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst16 { get; set; }
        [Column("FXDMATCST_17", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst17 { get; set; }
        [Column("FXDMATCST_18", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst18 { get; set; }
        [Column("FXDMATCST_19", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatcst19 { get; set; }
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
        [Column("FXDMACCST_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst0 { get; set; }
        [Column("FXDMACCST_1", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst1 { get; set; }
        [Column("FXDMACCST_2", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst2 { get; set; }
        [Column("FXDMACCST_3", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst3 { get; set; }
        [Column("FXDMACCST_4", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst4 { get; set; }
        [Column("FXDMACCST_5", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst5 { get; set; }
        [Column("FXDMACCST_6", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst6 { get; set; }
        [Column("FXDMACCST_7", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst7 { get; set; }
        [Column("FXDMACCST_8", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst8 { get; set; }
        [Column("FXDMACCST_9", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst9 { get; set; }
        [Column("FXDMACCST_10", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst10 { get; set; }
        [Column("FXDMACCST_11", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst11 { get; set; }
        [Column("FXDMACCST_12", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst12 { get; set; }
        [Column("FXDMACCST_13", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst13 { get; set; }
        [Column("FXDMACCST_14", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaccst14 { get; set; }
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
        [Column("FXDLABCST_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst0 { get; set; }
        [Column("FXDLABCST_1", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst1 { get; set; }
        [Column("FXDLABCST_2", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst2 { get; set; }
        [Column("FXDLABCST_3", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst3 { get; set; }
        [Column("FXDLABCST_4", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst4 { get; set; }
        [Column("FXDLABCST_5", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst5 { get; set; }
        [Column("FXDLABCST_6", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst6 { get; set; }
        [Column("FXDLABCST_7", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst7 { get; set; }
        [Column("FXDLABCST_8", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst8 { get; set; }
        [Column("FXDLABCST_9", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst9 { get; set; }
        [Column("FXDLABCST_10", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst10 { get; set; }
        [Column("FXDLABCST_11", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst11 { get; set; }
        [Column("FXDLABCST_12", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst12 { get; set; }
        [Column("FXDLABCST_13", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst13 { get; set; }
        [Column("FXDLABCST_14", TypeName = "numeric(19, 5)")]
        public decimal Fxdlabcst14 { get; set; }
        [Column("SCOCST_0", TypeName = "numeric(19, 5)")]
        public decimal Scocst0 { get; set; }
        [Column("FXDSCOCST_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdscocst0 { get; set; }
        [Column("OVEPRD_0", TypeName = "numeric(19, 5)")]
        public decimal Oveprd0 { get; set; }
        [Column("OVEMATCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovematcst0 { get; set; }
        [Column("FXDOVEMAT_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdovemat0 { get; set; }
        [Column("OVEMACCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovemaccst0 { get; set; }
        [Column("FXDOVEMAC_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdovemac0 { get; set; }
        [Column("OVELABCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovelabcst0 { get; set; }
        [Column("FXDOVELAB_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdovelab0 { get; set; }
        [Column("OVESCOCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovescocst0 { get; set; }
        [Column("FXDOVESCO_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdovesco0 { get; set; }
        [Column("CLCQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Clcqty0 { get; set; }
        [Column("MATLEVCST_0", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst0 { get; set; }
        [Column("MATLEVCST_1", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst1 { get; set; }
        [Column("MATLEVCST_2", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst2 { get; set; }
        [Column("MATLEVCST_3", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst3 { get; set; }
        [Column("MATLEVCST_4", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst4 { get; set; }
        [Column("MATLEVCST_5", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst5 { get; set; }
        [Column("MATLEVCST_6", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst6 { get; set; }
        [Column("MATLEVCST_7", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst7 { get; set; }
        [Column("MATLEVCST_8", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst8 { get; set; }
        [Column("MATLEVCST_9", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst9 { get; set; }
        [Column("MATLEVCST_10", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst10 { get; set; }
        [Column("MATLEVCST_11", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst11 { get; set; }
        [Column("MATLEVCST_12", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst12 { get; set; }
        [Column("MATLEVCST_13", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst13 { get; set; }
        [Column("MATLEVCST_14", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst14 { get; set; }
        [Column("MATLEVCST_15", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst15 { get; set; }
        [Column("MATLEVCST_16", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst16 { get; set; }
        [Column("MATLEVCST_17", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst17 { get; set; }
        [Column("MATLEVCST_18", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst18 { get; set; }
        [Column("MATLEVCST_19", TypeName = "numeric(19, 5)")]
        public decimal Matlevcst19 { get; set; }
        [Column("FXDMATLEV_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev0 { get; set; }
        [Column("FXDMATLEV_1", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev1 { get; set; }
        [Column("FXDMATLEV_2", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev2 { get; set; }
        [Column("FXDMATLEV_3", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev3 { get; set; }
        [Column("FXDMATLEV_4", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev4 { get; set; }
        [Column("FXDMATLEV_5", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev5 { get; set; }
        [Column("FXDMATLEV_6", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev6 { get; set; }
        [Column("FXDMATLEV_7", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev7 { get; set; }
        [Column("FXDMATLEV_8", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev8 { get; set; }
        [Column("FXDMATLEV_9", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev9 { get; set; }
        [Column("FXDMATLEV_10", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev10 { get; set; }
        [Column("FXDMATLEV_11", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev11 { get; set; }
        [Column("FXDMATLEV_12", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev12 { get; set; }
        [Column("FXDMATLEV_13", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev13 { get; set; }
        [Column("FXDMATLEV_14", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev14 { get; set; }
        [Column("FXDMATLEV_15", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev15 { get; set; }
        [Column("FXDMATLEV_16", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev16 { get; set; }
        [Column("FXDMATLEV_17", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev17 { get; set; }
        [Column("FXDMATLEV_18", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev18 { get; set; }
        [Column("FXDMATLEV_19", TypeName = "numeric(19, 5)")]
        public decimal Fxdmatlev19 { get; set; }
        [Column("MACLEVCST_0", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst0 { get; set; }
        [Column("MACLEVCST_1", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst1 { get; set; }
        [Column("MACLEVCST_2", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst2 { get; set; }
        [Column("MACLEVCST_3", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst3 { get; set; }
        [Column("MACLEVCST_4", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst4 { get; set; }
        [Column("MACLEVCST_5", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst5 { get; set; }
        [Column("MACLEVCST_6", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst6 { get; set; }
        [Column("MACLEVCST_7", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst7 { get; set; }
        [Column("MACLEVCST_8", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst8 { get; set; }
        [Column("MACLEVCST_9", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst9 { get; set; }
        [Column("MACLEVCST_10", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst10 { get; set; }
        [Column("MACLEVCST_11", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst11 { get; set; }
        [Column("MACLEVCST_12", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst12 { get; set; }
        [Column("MACLEVCST_13", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst13 { get; set; }
        [Column("MACLEVCST_14", TypeName = "numeric(19, 5)")]
        public decimal Maclevcst14 { get; set; }
        [Column("FXDMACLEV_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev0 { get; set; }
        [Column("FXDMACLEV_1", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev1 { get; set; }
        [Column("FXDMACLEV_2", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev2 { get; set; }
        [Column("FXDMACLEV_3", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev3 { get; set; }
        [Column("FXDMACLEV_4", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev4 { get; set; }
        [Column("FXDMACLEV_5", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev5 { get; set; }
        [Column("FXDMACLEV_6", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev6 { get; set; }
        [Column("FXDMACLEV_7", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev7 { get; set; }
        [Column("FXDMACLEV_8", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev8 { get; set; }
        [Column("FXDMACLEV_9", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev9 { get; set; }
        [Column("FXDMACLEV_10", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev10 { get; set; }
        [Column("FXDMACLEV_11", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev11 { get; set; }
        [Column("FXDMACLEV_12", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev12 { get; set; }
        [Column("FXDMACLEV_13", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev13 { get; set; }
        [Column("FXDMACLEV_14", TypeName = "numeric(19, 5)")]
        public decimal Fxdmaclev14 { get; set; }
        [Column("LABLEVCST_0", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst0 { get; set; }
        [Column("LABLEVCST_1", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst1 { get; set; }
        [Column("LABLEVCST_2", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst2 { get; set; }
        [Column("LABLEVCST_3", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst3 { get; set; }
        [Column("LABLEVCST_4", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst4 { get; set; }
        [Column("LABLEVCST_5", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst5 { get; set; }
        [Column("LABLEVCST_6", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst6 { get; set; }
        [Column("LABLEVCST_7", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst7 { get; set; }
        [Column("LABLEVCST_8", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst8 { get; set; }
        [Column("LABLEVCST_9", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst9 { get; set; }
        [Column("LABLEVCST_10", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst10 { get; set; }
        [Column("LABLEVCST_11", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst11 { get; set; }
        [Column("LABLEVCST_12", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst12 { get; set; }
        [Column("LABLEVCST_13", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst13 { get; set; }
        [Column("LABLEVCST_14", TypeName = "numeric(19, 5)")]
        public decimal Lablevcst14 { get; set; }
        [Column("FXDLABLEV_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev0 { get; set; }
        [Column("FXDLABLEV_1", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev1 { get; set; }
        [Column("FXDLABLEV_2", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev2 { get; set; }
        [Column("FXDLABLEV_3", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev3 { get; set; }
        [Column("FXDLABLEV_4", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev4 { get; set; }
        [Column("FXDLABLEV_5", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev5 { get; set; }
        [Column("FXDLABLEV_6", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev6 { get; set; }
        [Column("FXDLABLEV_7", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev7 { get; set; }
        [Column("FXDLABLEV_8", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev8 { get; set; }
        [Column("FXDLABLEV_9", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev9 { get; set; }
        [Column("FXDLABLEV_10", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev10 { get; set; }
        [Column("FXDLABLEV_11", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev11 { get; set; }
        [Column("FXDLABLEV_12", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev12 { get; set; }
        [Column("FXDLABLEV_13", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev13 { get; set; }
        [Column("FXDLABLEV_14", TypeName = "numeric(19, 5)")]
        public decimal Fxdlablev14 { get; set; }
        [Column("OVELEVCST_0", TypeName = "numeric(19, 5)")]
        public decimal Ovelevcst0 { get; set; }
        [Column("FXDOVELEV_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdovelev0 { get; set; }
        [Column("SCOLEVCST_0", TypeName = "numeric(19, 5)")]
        public decimal Scolevcst0 { get; set; }
        [Column("FXDSCOLEV_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdscolev0 { get; set; }
        [Column("OVEMATLEV_0", TypeName = "numeric(19, 5)")]
        public decimal Ovematlev0 { get; set; }
        [Column("FXDOVEMATL_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdovematl0 { get; set; }
        [Column("OVELABLEV_0", TypeName = "numeric(19, 5)")]
        public decimal Ovelablev0 { get; set; }
        [Column("FXDOVELABL_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdovelabl0 { get; set; }
        [Column("OVEMACLEV_0", TypeName = "numeric(19, 5)")]
        public decimal Ovemaclev0 { get; set; }
        [Column("FXDOVEMACL_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdovemacl0 { get; set; }
        [Column("OVESCOLEV_0", TypeName = "numeric(19, 5)")]
        public decimal Ovescolev0 { get; set; }
        [Column("FXDOVESCOL_0", TypeName = "numeric(19, 5)")]
        public decimal Fxdovescol0 { get; set; }
        [Column("ROUALT_0")]
        public short Roualt0 { get; set; }
        [Column("BOMALT_0")]
        public short Bomalt0 { get; set; }
        [Column("BOMALTTYP_0")]
        public byte Bomalttyp0 { get; set; }
        [Column("SLTMATCST_0")]
        public byte Sltmatcst0 { get; set; }
        [Column("VLTCCERAT_0")]
        public byte Vltccerat0 { get; set; }
        [Column("FXDCSTDSP_0")]
        public byte Fxdcstdsp0 { get; set; }
        [Column("SLTOVECOL_0")]
        public byte Sltovecol0 { get; set; }
        [Column("DESCEND_0")]
        public byte Descend0 { get; set; }
        [Column("OLDCST_0", TypeName = "numeric(19, 5)")]
        public decimal Oldcst0 { get; set; }
        [Column("OLDDAT_0", TypeName = "datetime")]
        public DateTime Olddat0 { get; set; }
        [Column("PHYSTO_0", TypeName = "numeric(28, 13)")]
        public decimal Physto0 { get; set; }
        [Column("UPDFLG_0")]
        public byte Updflg0 { get; set; }
        [Required]
        [Column("CFGVCRNUM_0")]
        [StringLength(1)]
        public string Cfgvcrnum0 { get; set; }
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
        [Column("PRNUID_0")]
        public int Prnuid0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}