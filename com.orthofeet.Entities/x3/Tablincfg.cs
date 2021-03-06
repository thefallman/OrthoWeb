// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TABLINCFG", Schema = "TESTPROD")]
    [Index(nameof(Cfglin0), Name = "TABLINCFG_TLP0", IsUnique = true)]
    public partial class Tablincfg
    {
        [Required]
        [Column("CFGLIN_0")]
        [StringLength(5)]
        public string Cfglin0 { get; set; }
        [Required]
        [Column("CFGLINDES_0")]
        [StringLength(30)]
        public string Cfglindes0 { get; set; }
        [Required]
        [Column("SCENUM_0")]
        [StringLength(1)]
        public string Scenum0 { get; set; }
        [Column("CFGNUM1_0")]
        public byte Cfgnum10 { get; set; }
        [Column("CFGNUMCOD1_0")]
        public byte Cfgnumcod10 { get; set; }
        [Required]
        [Column("CFGNUMTCT1_0")]
        [StringLength(3)]
        public string Cfgnumtct10 { get; set; }
        [Column("CFGNUM2_0")]
        public byte Cfgnum20 { get; set; }
        [Column("CFGNUMCOD2_0")]
        public byte Cfgnumcod20 { get; set; }
        [Required]
        [Column("CFGNUMTCT2_0")]
        [StringLength(3)]
        public string Cfgnumtct20 { get; set; }
        [Column("CFGNUM3_0")]
        public byte Cfgnum30 { get; set; }
        [Column("CFGNUMCOD3_0")]
        public byte Cfgnumcod30 { get; set; }
        [Required]
        [Column("CFGNUMTCT3_0")]
        [StringLength(3)]
        public string Cfgnumtct30 { get; set; }
        [Column("CFGNUM4_0")]
        public byte Cfgnum40 { get; set; }
        [Column("CFGNUMCOD4_0")]
        public byte Cfgnumcod40 { get; set; }
        [Required]
        [Column("CFGNUMTCT4_0")]
        [StringLength(3)]
        public string Cfgnumtct40 { get; set; }
        [Column("CFGNUM5_0")]
        public byte Cfgnum50 { get; set; }
        [Column("CFGNUMCOD5_0")]
        public byte Cfgnumcod50 { get; set; }
        [Required]
        [Column("CFGNUMTCT5_0")]
        [StringLength(3)]
        public string Cfgnumtct50 { get; set; }
        [Column("CFGNUM6_0")]
        public byte Cfgnum60 { get; set; }
        [Column("CFGNUMCOD6_0")]
        public byte Cfgnumcod60 { get; set; }
        [Required]
        [Column("CFGNUMTCT6_0")]
        [StringLength(3)]
        public string Cfgnumtct60 { get; set; }
        [Column("CFGALP1_0")]
        public byte Cfgalp10 { get; set; }
        [Column("CFGALPCOD1_0")]
        public byte Cfgalpcod10 { get; set; }
        [Required]
        [Column("CFGALPTCT1_0")]
        [StringLength(3)]
        public string Cfgalptct10 { get; set; }
        [Column("CFGALP2_0")]
        public byte Cfgalp20 { get; set; }
        [Column("CFGALPCOD2_0")]
        public byte Cfgalpcod20 { get; set; }
        [Required]
        [Column("CFGALPTCT2_0")]
        [StringLength(3)]
        public string Cfgalptct20 { get; set; }
        [Column("CFGALP3_0")]
        public byte Cfgalp30 { get; set; }
        [Column("CFGALPCOD3_0")]
        public byte Cfgalpcod30 { get; set; }
        [Required]
        [Column("CFGALPTCT3_0")]
        [StringLength(3)]
        public string Cfgalptct30 { get; set; }
        [Column("CFGALP4_0")]
        public byte Cfgalp40 { get; set; }
        [Column("CFGALPCOD4_0")]
        public byte Cfgalpcod40 { get; set; }
        [Required]
        [Column("CFGALPTCT4_0")]
        [StringLength(3)]
        public string Cfgalptct40 { get; set; }
        [Column("CFGALP5_0")]
        public byte Cfgalp50 { get; set; }
        [Column("CFGALPCOD5_0")]
        public byte Cfgalpcod50 { get; set; }
        [Required]
        [Column("CFGALPTCT5_0")]
        [StringLength(3)]
        public string Cfgalptct50 { get; set; }
        [Column("CFGALP6_0")]
        public byte Cfgalp60 { get; set; }
        [Column("CFGALPCOD6_0")]
        public byte Cfgalpcod60 { get; set; }
        [Required]
        [Column("CFGALPTCT6_0")]
        [StringLength(3)]
        public string Cfgalptct60 { get; set; }
        [Column("SEAKEY_0")]
        public byte Seakey0 { get; set; }
        [Column("ITMFLDNBR_0")]
        public short Itmfldnbr0 { get; set; }
        [Required]
        [Column("ITMFLD_0")]
        [StringLength(10)]
        public string Itmfld0 { get; set; }
        [Required]
        [Column("ITMFLD_1")]
        [StringLength(10)]
        public string Itmfld1 { get; set; }
        [Required]
        [Column("ITMFLD_2")]
        [StringLength(10)]
        public string Itmfld2 { get; set; }
        [Required]
        [Column("ITMFLD_3")]
        [StringLength(10)]
        public string Itmfld3 { get; set; }
        [Required]
        [Column("ITMFLD_4")]
        [StringLength(10)]
        public string Itmfld4 { get; set; }
        [Required]
        [Column("ITMFLD_5")]
        [StringLength(10)]
        public string Itmfld5 { get; set; }
        [Required]
        [Column("ITMFLD_6")]
        [StringLength(10)]
        public string Itmfld6 { get; set; }
        [Required]
        [Column("ITMFLD_7")]
        [StringLength(10)]
        public string Itmfld7 { get; set; }
        [Required]
        [Column("ITMFLD_8")]
        [StringLength(10)]
        public string Itmfld8 { get; set; }
        [Required]
        [Column("ITMFLD_9")]
        [StringLength(10)]
        public string Itmfld9 { get; set; }
        [Required]
        [Column("ITMFLD_10")]
        [StringLength(10)]
        public string Itmfld10 { get; set; }
        [Required]
        [Column("ITMFLD_11")]
        [StringLength(10)]
        public string Itmfld11 { get; set; }
        [Required]
        [Column("ITMFLD_12")]
        [StringLength(10)]
        public string Itmfld12 { get; set; }
        [Required]
        [Column("ITMFLD_13")]
        [StringLength(10)]
        public string Itmfld13 { get; set; }
        [Required]
        [Column("ITMFLD_14")]
        [StringLength(10)]
        public string Itmfld14 { get; set; }
        [Column("INDFLD_0")]
        public short Indfld0 { get; set; }
        [Column("INDFLD_1")]
        public short Indfld1 { get; set; }
        [Column("INDFLD_2")]
        public short Indfld2 { get; set; }
        [Column("INDFLD_3")]
        public short Indfld3 { get; set; }
        [Column("INDFLD_4")]
        public short Indfld4 { get; set; }
        [Column("INDFLD_5")]
        public short Indfld5 { get; set; }
        [Column("INDFLD_6")]
        public short Indfld6 { get; set; }
        [Column("INDFLD_7")]
        public short Indfld7 { get; set; }
        [Column("INDFLD_8")]
        public short Indfld8 { get; set; }
        [Column("INDFLD_9")]
        public short Indfld9 { get; set; }
        [Column("INDFLD_10")]
        public short Indfld10 { get; set; }
        [Column("INDFLD_11")]
        public short Indfld11 { get; set; }
        [Column("INDFLD_12")]
        public short Indfld12 { get; set; }
        [Column("INDFLD_13")]
        public short Indfld13 { get; set; }
        [Column("INDFLD_14")]
        public short Indfld14 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
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