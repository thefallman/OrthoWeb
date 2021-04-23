﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GTABACC", Schema = "TESTPROD")]
    [Index(nameof(Cnscod0), nameof(Cod0), Name = "GTABACC_GTC0", IsUnique = true)]
    public partial class Gtabacc
    {
        [Required]
        [Column("CNSCOD_0")]
        [StringLength(3)]
        public string Cnscod0 { get; set; }
        [Required]
        [Column("ACS_0")]
        [StringLength(10)]
        public string Acs0 { get; set; }
        [Required]
        [Column("COD_0")]
        [StringLength(5)]
        public string Cod0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Column("NBRFLD_0")]
        public short Nbrfld0 { get; set; }
        [Column("NBRCOL_0")]
        public short Nbrcol0 { get; set; }
        [Column("NBRLIG_0")]
        public short Nbrlig0 { get; set; }
        [Required]
        [Column("FLD_0")]
        [StringLength(12)]
        public string Fld0 { get; set; }
        [Required]
        [Column("FLD_1")]
        [StringLength(12)]
        public string Fld1 { get; set; }
        [Required]
        [Column("FLD_2")]
        [StringLength(12)]
        public string Fld2 { get; set; }
        [Required]
        [Column("FLD_3")]
        [StringLength(12)]
        public string Fld3 { get; set; }
        [Required]
        [Column("FLD_4")]
        [StringLength(12)]
        public string Fld4 { get; set; }
        [Required]
        [Column("FLD_5")]
        [StringLength(12)]
        public string Fld5 { get; set; }
        [Required]
        [Column("FLD_6")]
        [StringLength(12)]
        public string Fld6 { get; set; }
        [Required]
        [Column("FLD_7")]
        [StringLength(12)]
        public string Fld7 { get; set; }
        [Required]
        [Column("FLD_8")]
        [StringLength(12)]
        public string Fld8 { get; set; }
        [Required]
        [Column("FLD_9")]
        [StringLength(12)]
        public string Fld9 { get; set; }
        [Required]
        [Column("FLD_10")]
        [StringLength(12)]
        public string Fld10 { get; set; }
        [Required]
        [Column("FLD_11")]
        [StringLength(12)]
        public string Fld11 { get; set; }
        [Required]
        [Column("FLD_12")]
        [StringLength(12)]
        public string Fld12 { get; set; }
        [Required]
        [Column("FLD_13")]
        [StringLength(12)]
        public string Fld13 { get; set; }
        [Required]
        [Column("FLD_14")]
        [StringLength(12)]
        public string Fld14 { get; set; }
        [Required]
        [Column("FLD_15")]
        [StringLength(12)]
        public string Fld15 { get; set; }
        [Required]
        [Column("FLD_16")]
        [StringLength(12)]
        public string Fld16 { get; set; }
        [Required]
        [Column("FLD_17")]
        [StringLength(12)]
        public string Fld17 { get; set; }
        [Required]
        [Column("FLD_18")]
        [StringLength(12)]
        public string Fld18 { get; set; }
        [Required]
        [Column("FLD_19")]
        [StringLength(12)]
        public string Fld19 { get; set; }
        [Required]
        [Column("FLD_20")]
        [StringLength(12)]
        public string Fld20 { get; set; }
        [Required]
        [Column("FLD_21")]
        [StringLength(12)]
        public string Fld21 { get; set; }
        [Required]
        [Column("FLD_22")]
        [StringLength(12)]
        public string Fld22 { get; set; }
        [Required]
        [Column("FLD_23")]
        [StringLength(12)]
        public string Fld23 { get; set; }
        [Required]
        [Column("FLD_24")]
        [StringLength(12)]
        public string Fld24 { get; set; }
        [Required]
        [Column("FLD_25")]
        [StringLength(12)]
        public string Fld25 { get; set; }
        [Required]
        [Column("FLD_26")]
        [StringLength(12)]
        public string Fld26 { get; set; }
        [Required]
        [Column("FLD_27")]
        [StringLength(12)]
        public string Fld27 { get; set; }
        [Required]
        [Column("FLD_28")]
        [StringLength(12)]
        public string Fld28 { get; set; }
        [Required]
        [Column("FLD_29")]
        [StringLength(12)]
        public string Fld29 { get; set; }
        [Required]
        [Column("FLD_30")]
        [StringLength(12)]
        public string Fld30 { get; set; }
        [Required]
        [Column("FLD_31")]
        [StringLength(12)]
        public string Fld31 { get; set; }
        [Required]
        [Column("FLD_32")]
        [StringLength(12)]
        public string Fld32 { get; set; }
        [Required]
        [Column("FLD_33")]
        [StringLength(12)]
        public string Fld33 { get; set; }
        [Required]
        [Column("FLD_34")]
        [StringLength(12)]
        public string Fld34 { get; set; }
        [Required]
        [Column("FLD_35")]
        [StringLength(12)]
        public string Fld35 { get; set; }
        [Required]
        [Column("FLD_36")]
        [StringLength(12)]
        public string Fld36 { get; set; }
        [Required]
        [Column("FLD_37")]
        [StringLength(12)]
        public string Fld37 { get; set; }
        [Required]
        [Column("FLD_38")]
        [StringLength(12)]
        public string Fld38 { get; set; }
        [Required]
        [Column("FLD_39")]
        [StringLength(12)]
        public string Fld39 { get; set; }
        [Required]
        [Column("FLD_40")]
        [StringLength(12)]
        public string Fld40 { get; set; }
        [Required]
        [Column("FLD_41")]
        [StringLength(12)]
        public string Fld41 { get; set; }
        [Required]
        [Column("FLD_42")]
        [StringLength(12)]
        public string Fld42 { get; set; }
        [Required]
        [Column("FLD_43")]
        [StringLength(12)]
        public string Fld43 { get; set; }
        [Required]
        [Column("FLD_44")]
        [StringLength(12)]
        public string Fld44 { get; set; }
        [Required]
        [Column("FLD_45")]
        [StringLength(12)]
        public string Fld45 { get; set; }
        [Required]
        [Column("FLD_46")]
        [StringLength(12)]
        public string Fld46 { get; set; }
        [Required]
        [Column("FLD_47")]
        [StringLength(12)]
        public string Fld47 { get; set; }
        [Required]
        [Column("FLD_48")]
        [StringLength(12)]
        public string Fld48 { get; set; }
        [Required]
        [Column("FLD_49")]
        [StringLength(12)]
        public string Fld49 { get; set; }
        [Required]
        [Column("FLD_50")]
        [StringLength(12)]
        public string Fld50 { get; set; }
        [Required]
        [Column("FLD_51")]
        [StringLength(12)]
        public string Fld51 { get; set; }
        [Required]
        [Column("FLD_52")]
        [StringLength(12)]
        public string Fld52 { get; set; }
        [Required]
        [Column("FLD_53")]
        [StringLength(12)]
        public string Fld53 { get; set; }
        [Required]
        [Column("FLD_54")]
        [StringLength(12)]
        public string Fld54 { get; set; }
        [Required]
        [Column("FLD_55")]
        [StringLength(12)]
        public string Fld55 { get; set; }
        [Required]
        [Column("FLD_56")]
        [StringLength(12)]
        public string Fld56 { get; set; }
        [Required]
        [Column("FLD_57")]
        [StringLength(12)]
        public string Fld57 { get; set; }
        [Required]
        [Column("FLD_58")]
        [StringLength(12)]
        public string Fld58 { get; set; }
        [Required]
        [Column("FLD_59")]
        [StringLength(12)]
        public string Fld59 { get; set; }
        [Required]
        [Column("FLD_60")]
        [StringLength(12)]
        public string Fld60 { get; set; }
        [Required]
        [Column("FLD_61")]
        [StringLength(12)]
        public string Fld61 { get; set; }
        [Required]
        [Column("FLD_62")]
        [StringLength(12)]
        public string Fld62 { get; set; }
        [Required]
        [Column("FLD_63")]
        [StringLength(12)]
        public string Fld63 { get; set; }
        [Required]
        [Column("FLD_64")]
        [StringLength(12)]
        public string Fld64 { get; set; }
        [Required]
        [Column("FLD_65")]
        [StringLength(12)]
        public string Fld65 { get; set; }
        [Required]
        [Column("FLD_66")]
        [StringLength(12)]
        public string Fld66 { get; set; }
        [Required]
        [Column("FLD_67")]
        [StringLength(12)]
        public string Fld67 { get; set; }
        [Required]
        [Column("FLD_68")]
        [StringLength(12)]
        public string Fld68 { get; set; }
        [Required]
        [Column("FLD_69")]
        [StringLength(12)]
        public string Fld69 { get; set; }
        [Required]
        [Column("FLD_70")]
        [StringLength(12)]
        public string Fld70 { get; set; }
        [Required]
        [Column("FLD_71")]
        [StringLength(12)]
        public string Fld71 { get; set; }
        [Required]
        [Column("FLD_72")]
        [StringLength(12)]
        public string Fld72 { get; set; }
        [Required]
        [Column("FLD_73")]
        [StringLength(12)]
        public string Fld73 { get; set; }
        [Required]
        [Column("FLD_74")]
        [StringLength(12)]
        public string Fld74 { get; set; }
        [Required]
        [Column("FLD_75")]
        [StringLength(12)]
        public string Fld75 { get; set; }
        [Required]
        [Column("FLD_76")]
        [StringLength(12)]
        public string Fld76 { get; set; }
        [Required]
        [Column("FLD_77")]
        [StringLength(12)]
        public string Fld77 { get; set; }
        [Required]
        [Column("FLD_78")]
        [StringLength(12)]
        public string Fld78 { get; set; }
        [Required]
        [Column("FLD_79")]
        [StringLength(12)]
        public string Fld79 { get; set; }
        [Column("DAC_0")]
        public short Dac0 { get; set; }
        [Column("DAC_1")]
        public short Dac1 { get; set; }
        [Column("DAC_2")]
        public short Dac2 { get; set; }
        [Column("DAC_3")]
        public short Dac3 { get; set; }
        [Column("DAC_4")]
        public short Dac4 { get; set; }
        [Column("DAC_5")]
        public short Dac5 { get; set; }
        [Column("DAC_6")]
        public short Dac6 { get; set; }
        [Column("DAC_7")]
        public short Dac7 { get; set; }
        [Column("DAC_8")]
        public short Dac8 { get; set; }
        [Column("DAC_9")]
        public short Dac9 { get; set; }
        [Column("DAC_10")]
        public short Dac10 { get; set; }
        [Column("DAC_11")]
        public short Dac11 { get; set; }
        [Column("DAC_12")]
        public short Dac12 { get; set; }
        [Column("DAC_13")]
        public short Dac13 { get; set; }
        [Column("DAC_14")]
        public short Dac14 { get; set; }
        [Column("DAC_15")]
        public short Dac15 { get; set; }
        [Column("DAC_16")]
        public short Dac16 { get; set; }
        [Column("DAC_17")]
        public short Dac17 { get; set; }
        [Column("DAC_18")]
        public short Dac18 { get; set; }
        [Column("DAC_19")]
        public short Dac19 { get; set; }
        [Column("DAC_20")]
        public short Dac20 { get; set; }
        [Column("DAC_21")]
        public short Dac21 { get; set; }
        [Column("DAC_22")]
        public short Dac22 { get; set; }
        [Column("DAC_23")]
        public short Dac23 { get; set; }
        [Column("DAC_24")]
        public short Dac24 { get; set; }
        [Column("DAC_25")]
        public short Dac25 { get; set; }
        [Column("DAC_26")]
        public short Dac26 { get; set; }
        [Column("DAC_27")]
        public short Dac27 { get; set; }
        [Column("DAC_28")]
        public short Dac28 { get; set; }
        [Column("DAC_29")]
        public short Dac29 { get; set; }
        [Column("DAC_30")]
        public short Dac30 { get; set; }
        [Column("DAC_31")]
        public short Dac31 { get; set; }
        [Column("DAC_32")]
        public short Dac32 { get; set; }
        [Column("DAC_33")]
        public short Dac33 { get; set; }
        [Column("DAC_34")]
        public short Dac34 { get; set; }
        [Column("DAC_35")]
        public short Dac35 { get; set; }
        [Column("DAC_36")]
        public short Dac36 { get; set; }
        [Column("DAC_37")]
        public short Dac37 { get; set; }
        [Column("DAC_38")]
        public short Dac38 { get; set; }
        [Column("DAC_39")]
        public short Dac39 { get; set; }
        [Column("DAC_40")]
        public short Dac40 { get; set; }
        [Column("DAC_41")]
        public short Dac41 { get; set; }
        [Column("DAC_42")]
        public short Dac42 { get; set; }
        [Column("DAC_43")]
        public short Dac43 { get; set; }
        [Column("DAC_44")]
        public short Dac44 { get; set; }
        [Column("DAC_45")]
        public short Dac45 { get; set; }
        [Column("DAC_46")]
        public short Dac46 { get; set; }
        [Column("DAC_47")]
        public short Dac47 { get; set; }
        [Column("DAC_48")]
        public short Dac48 { get; set; }
        [Column("DAC_49")]
        public short Dac49 { get; set; }
        [Column("DAC_50")]
        public short Dac50 { get; set; }
        [Column("DAC_51")]
        public short Dac51 { get; set; }
        [Column("DAC_52")]
        public short Dac52 { get; set; }
        [Column("DAC_53")]
        public short Dac53 { get; set; }
        [Column("DAC_54")]
        public short Dac54 { get; set; }
        [Column("DAC_55")]
        public short Dac55 { get; set; }
        [Column("DAC_56")]
        public short Dac56 { get; set; }
        [Column("DAC_57")]
        public short Dac57 { get; set; }
        [Column("DAC_58")]
        public short Dac58 { get; set; }
        [Column("DAC_59")]
        public short Dac59 { get; set; }
        [Column("DAC_60")]
        public short Dac60 { get; set; }
        [Column("DAC_61")]
        public short Dac61 { get; set; }
        [Column("DAC_62")]
        public short Dac62 { get; set; }
        [Column("DAC_63")]
        public short Dac63 { get; set; }
        [Column("DAC_64")]
        public short Dac64 { get; set; }
        [Column("DAC_65")]
        public short Dac65 { get; set; }
        [Column("DAC_66")]
        public short Dac66 { get; set; }
        [Column("DAC_67")]
        public short Dac67 { get; set; }
        [Column("DAC_68")]
        public short Dac68 { get; set; }
        [Column("DAC_69")]
        public short Dac69 { get; set; }
        [Column("DAC_70")]
        public short Dac70 { get; set; }
        [Column("DAC_71")]
        public short Dac71 { get; set; }
        [Column("DAC_72")]
        public short Dac72 { get; set; }
        [Column("DAC_73")]
        public short Dac73 { get; set; }
        [Column("DAC_74")]
        public short Dac74 { get; set; }
        [Column("DAC_75")]
        public short Dac75 { get; set; }
        [Column("DAC_76")]
        public short Dac76 { get; set; }
        [Column("DAC_77")]
        public short Dac77 { get; set; }
        [Column("DAC_78")]
        public short Dac78 { get; set; }
        [Column("DAC_79")]
        public short Dac79 { get; set; }
        [Column("GRA_0")]
        public byte Gra0 { get; set; }
        [Column("GRA_1")]
        public byte Gra1 { get; set; }
        [Column("GRA_2")]
        public byte Gra2 { get; set; }
        [Column("GRA_3")]
        public byte Gra3 { get; set; }
        [Column("GRA_4")]
        public byte Gra4 { get; set; }
        [Column("GRA_5")]
        public byte Gra5 { get; set; }
        [Column("GRA_6")]
        public byte Gra6 { get; set; }
        [Column("GRA_7")]
        public byte Gra7 { get; set; }
        [Column("GRA_8")]
        public byte Gra8 { get; set; }
        [Column("GRA_9")]
        public byte Gra9 { get; set; }
        [Column("GRA_10")]
        public byte Gra10 { get; set; }
        [Column("GRA_11")]
        public byte Gra11 { get; set; }
        [Column("GRA_12")]
        public byte Gra12 { get; set; }
        [Column("GRA_13")]
        public byte Gra13 { get; set; }
        [Column("GRA_14")]
        public byte Gra14 { get; set; }
        [Column("GRA_15")]
        public byte Gra15 { get; set; }
        [Column("GRA_16")]
        public byte Gra16 { get; set; }
        [Column("GRA_17")]
        public byte Gra17 { get; set; }
        [Column("GRA_18")]
        public byte Gra18 { get; set; }
        [Column("GRA_19")]
        public byte Gra19 { get; set; }
        [Column("GRA_20")]
        public byte Gra20 { get; set; }
        [Column("GRA_21")]
        public byte Gra21 { get; set; }
        [Column("GRA_22")]
        public byte Gra22 { get; set; }
        [Column("GRA_23")]
        public byte Gra23 { get; set; }
        [Column("GRA_24")]
        public byte Gra24 { get; set; }
        [Column("GRA_25")]
        public byte Gra25 { get; set; }
        [Column("GRA_26")]
        public byte Gra26 { get; set; }
        [Column("GRA_27")]
        public byte Gra27 { get; set; }
        [Column("GRA_28")]
        public byte Gra28 { get; set; }
        [Column("GRA_29")]
        public byte Gra29 { get; set; }
        [Column("GRA_30")]
        public byte Gra30 { get; set; }
        [Column("GRA_31")]
        public byte Gra31 { get; set; }
        [Column("GRA_32")]
        public byte Gra32 { get; set; }
        [Column("GRA_33")]
        public byte Gra33 { get; set; }
        [Column("GRA_34")]
        public byte Gra34 { get; set; }
        [Column("GRA_35")]
        public byte Gra35 { get; set; }
        [Column("GRA_36")]
        public byte Gra36 { get; set; }
        [Column("GRA_37")]
        public byte Gra37 { get; set; }
        [Column("GRA_38")]
        public byte Gra38 { get; set; }
        [Column("GRA_39")]
        public byte Gra39 { get; set; }
        [Column("GRA_40")]
        public byte Gra40 { get; set; }
        [Column("GRA_41")]
        public byte Gra41 { get; set; }
        [Column("GRA_42")]
        public byte Gra42 { get; set; }
        [Column("GRA_43")]
        public byte Gra43 { get; set; }
        [Column("GRA_44")]
        public byte Gra44 { get; set; }
        [Column("GRA_45")]
        public byte Gra45 { get; set; }
        [Column("GRA_46")]
        public byte Gra46 { get; set; }
        [Column("GRA_47")]
        public byte Gra47 { get; set; }
        [Column("GRA_48")]
        public byte Gra48 { get; set; }
        [Column("GRA_49")]
        public byte Gra49 { get; set; }
        [Column("GRA_50")]
        public byte Gra50 { get; set; }
        [Column("GRA_51")]
        public byte Gra51 { get; set; }
        [Column("GRA_52")]
        public byte Gra52 { get; set; }
        [Column("GRA_53")]
        public byte Gra53 { get; set; }
        [Column("GRA_54")]
        public byte Gra54 { get; set; }
        [Column("GRA_55")]
        public byte Gra55 { get; set; }
        [Column("GRA_56")]
        public byte Gra56 { get; set; }
        [Column("GRA_57")]
        public byte Gra57 { get; set; }
        [Column("GRA_58")]
        public byte Gra58 { get; set; }
        [Column("GRA_59")]
        public byte Gra59 { get; set; }
        [Column("GRA_60")]
        public byte Gra60 { get; set; }
        [Column("GRA_61")]
        public byte Gra61 { get; set; }
        [Column("GRA_62")]
        public byte Gra62 { get; set; }
        [Column("GRA_63")]
        public byte Gra63 { get; set; }
        [Column("GRA_64")]
        public byte Gra64 { get; set; }
        [Column("GRA_65")]
        public byte Gra65 { get; set; }
        [Column("GRA_66")]
        public byte Gra66 { get; set; }
        [Column("GRA_67")]
        public byte Gra67 { get; set; }
        [Column("GRA_68")]
        public byte Gra68 { get; set; }
        [Column("GRA_69")]
        public byte Gra69 { get; set; }
        [Column("GRA_70")]
        public byte Gra70 { get; set; }
        [Column("GRA_71")]
        public byte Gra71 { get; set; }
        [Column("GRA_72")]
        public byte Gra72 { get; set; }
        [Column("GRA_73")]
        public byte Gra73 { get; set; }
        [Column("GRA_74")]
        public byte Gra74 { get; set; }
        [Column("GRA_75")]
        public byte Gra75 { get; set; }
        [Column("GRA_76")]
        public byte Gra76 { get; set; }
        [Column("GRA_77")]
        public byte Gra77 { get; set; }
        [Column("GRA_78")]
        public byte Gra78 { get; set; }
        [Column("GRA_79")]
        public byte Gra79 { get; set; }
        [Column("REP_0")]
        public byte Rep0 { get; set; }
        [Column("REP_1")]
        public byte Rep1 { get; set; }
        [Column("REP_2")]
        public byte Rep2 { get; set; }
        [Column("REP_3")]
        public byte Rep3 { get; set; }
        [Column("REP_4")]
        public byte Rep4 { get; set; }
        [Column("REP_5")]
        public byte Rep5 { get; set; }
        [Column("REP_6")]
        public byte Rep6 { get; set; }
        [Column("REP_7")]
        public byte Rep7 { get; set; }
        [Column("REP_8")]
        public byte Rep8 { get; set; }
        [Column("REP_9")]
        public byte Rep9 { get; set; }
        [Column("REP_10")]
        public byte Rep10 { get; set; }
        [Column("REP_11")]
        public byte Rep11 { get; set; }
        [Column("REP_12")]
        public byte Rep12 { get; set; }
        [Column("REP_13")]
        public byte Rep13 { get; set; }
        [Column("REP_14")]
        public byte Rep14 { get; set; }
        [Column("REP_15")]
        public byte Rep15 { get; set; }
        [Column("REP_16")]
        public byte Rep16 { get; set; }
        [Column("REP_17")]
        public byte Rep17 { get; set; }
        [Column("REP_18")]
        public byte Rep18 { get; set; }
        [Column("REP_19")]
        public byte Rep19 { get; set; }
        [Column("REP_20")]
        public byte Rep20 { get; set; }
        [Column("REP_21")]
        public byte Rep21 { get; set; }
        [Column("REP_22")]
        public byte Rep22 { get; set; }
        [Column("REP_23")]
        public byte Rep23 { get; set; }
        [Column("REP_24")]
        public byte Rep24 { get; set; }
        [Column("REP_25")]
        public byte Rep25 { get; set; }
        [Column("REP_26")]
        public byte Rep26 { get; set; }
        [Column("REP_27")]
        public byte Rep27 { get; set; }
        [Column("REP_28")]
        public byte Rep28 { get; set; }
        [Column("REP_29")]
        public byte Rep29 { get; set; }
        [Column("REP_30")]
        public byte Rep30 { get; set; }
        [Column("REP_31")]
        public byte Rep31 { get; set; }
        [Column("REP_32")]
        public byte Rep32 { get; set; }
        [Column("REP_33")]
        public byte Rep33 { get; set; }
        [Column("REP_34")]
        public byte Rep34 { get; set; }
        [Column("REP_35")]
        public byte Rep35 { get; set; }
        [Column("REP_36")]
        public byte Rep36 { get; set; }
        [Column("REP_37")]
        public byte Rep37 { get; set; }
        [Column("REP_38")]
        public byte Rep38 { get; set; }
        [Column("REP_39")]
        public byte Rep39 { get; set; }
        [Column("REP_40")]
        public byte Rep40 { get; set; }
        [Column("REP_41")]
        public byte Rep41 { get; set; }
        [Column("REP_42")]
        public byte Rep42 { get; set; }
        [Column("REP_43")]
        public byte Rep43 { get; set; }
        [Column("REP_44")]
        public byte Rep44 { get; set; }
        [Column("REP_45")]
        public byte Rep45 { get; set; }
        [Column("REP_46")]
        public byte Rep46 { get; set; }
        [Column("REP_47")]
        public byte Rep47 { get; set; }
        [Column("REP_48")]
        public byte Rep48 { get; set; }
        [Column("REP_49")]
        public byte Rep49 { get; set; }
        [Column("REP_50")]
        public byte Rep50 { get; set; }
        [Column("REP_51")]
        public byte Rep51 { get; set; }
        [Column("REP_52")]
        public byte Rep52 { get; set; }
        [Column("REP_53")]
        public byte Rep53 { get; set; }
        [Column("REP_54")]
        public byte Rep54 { get; set; }
        [Column("REP_55")]
        public byte Rep55 { get; set; }
        [Column("REP_56")]
        public byte Rep56 { get; set; }
        [Column("REP_57")]
        public byte Rep57 { get; set; }
        [Column("REP_58")]
        public byte Rep58 { get; set; }
        [Column("REP_59")]
        public byte Rep59 { get; set; }
        [Column("REP_60")]
        public byte Rep60 { get; set; }
        [Column("REP_61")]
        public byte Rep61 { get; set; }
        [Column("REP_62")]
        public byte Rep62 { get; set; }
        [Column("REP_63")]
        public byte Rep63 { get; set; }
        [Column("REP_64")]
        public byte Rep64 { get; set; }
        [Column("REP_65")]
        public byte Rep65 { get; set; }
        [Column("REP_66")]
        public byte Rep66 { get; set; }
        [Column("REP_67")]
        public byte Rep67 { get; set; }
        [Column("REP_68")]
        public byte Rep68 { get; set; }
        [Column("REP_69")]
        public byte Rep69 { get; set; }
        [Column("REP_70")]
        public byte Rep70 { get; set; }
        [Column("REP_71")]
        public byte Rep71 { get; set; }
        [Column("REP_72")]
        public byte Rep72 { get; set; }
        [Column("REP_73")]
        public byte Rep73 { get; set; }
        [Column("REP_74")]
        public byte Rep74 { get; set; }
        [Column("REP_75")]
        public byte Rep75 { get; set; }
        [Column("REP_76")]
        public byte Rep76 { get; set; }
        [Column("REP_77")]
        public byte Rep77 { get; set; }
        [Column("REP_78")]
        public byte Rep78 { get; set; }
        [Column("REP_79")]
        public byte Rep79 { get; set; }
        [Column("REPGRA_0")]
        public byte Repgra0 { get; set; }
        [Column("TYPGRA_0")]
        public byte Typgra0 { get; set; }
        [Column("POSGRA_0")]
        public byte Posgra0 { get; set; }
        [Column("AFFGRA_0")]
        public byte Affgra0 { get; set; }
        [Column("DEFGRA_0")]
        public byte Defgra0 { get; set; }
        [Column("FSHGRA_0")]
        public byte Fshgra0 { get; set; }
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