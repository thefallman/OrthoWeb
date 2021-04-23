﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PORDERC", Schema = "TESTPROD")]
    [Index(nameof(Pohnum0), nameof(Poplin0), Name = "PORDERC_POC0", IsUnique = true)]
    [Index(nameof(Pohnum0), nameof(Itmref0), nameof(Prhfcy0), Name = "PORDERC_POC1", IsUnique = true)]
    [Index(nameof(Itmref0), nameof(Betfcy0), nameof(Strdat0), Name = "PORDERC_POC2")]
    public partial class Porderc
    {
        [Required]
        [Column("POHNUM_0")]
        [StringLength(20)]
        public string Pohnum0 { get; set; }
        [Column("POPLIN_0")]
        public int Poplin0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("POHFCY_0")]
        [StringLength(5)]
        public string Pohfcy0 { get; set; }
        [Required]
        [Column("BPSNUM_0")]
        [StringLength(15)]
        public string Bpsnum0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("ITMDES1_0")]
        [StringLength(30)]
        public string Itmdes10 { get; set; }
        [Required]
        [Column("ITMDES_0")]
        [StringLength(30)]
        public string Itmdes0 { get; set; }
        [Required]
        [Column("ITMREFBPS_0")]
        [StringLength(20)]
        public string Itmrefbps0 { get; set; }
        [Column("LINREVNUM_0")]
        public short Linrevnum0 { get; set; }
        [Column("STRDAT_0", TypeName = "datetime")]
        public DateTime Strdat0 { get; set; }
        [Column("ENDDAT_0", TypeName = "datetime")]
        public DateTime Enddat0 { get; set; }
        [Required]
        [Column("PLI_0")]
        [StringLength(6)]
        public string Pli0 { get; set; }
        [Column("FRTHOR_0")]
        public short Frthor0 { get; set; }
        [Column("FRTHORUOM_0")]
        public byte Frthoruom0 { get; set; }
        [Column("FIMHOR_0")]
        public short Fimhor0 { get; set; }
        [Column("DAYDSP_0")]
        public short Daydsp0 { get; set; }
        [Column("DAYDSP_1")]
        public short Daydsp1 { get; set; }
        [Column("DAYDSP_2")]
        public short Daydsp2 { get; set; }
        [Column("DAYDSP_3")]
        public short Daydsp3 { get; set; }
        [Column("DAYDSP_4")]
        public short Daydsp4 { get; set; }
        [Column("DAYDSP_5")]
        public short Daydsp5 { get; set; }
        [Column("DAYDSP_6")]
        public short Daydsp6 { get; set; }
        [Column("WEEDSP_0")]
        public short Weedsp0 { get; set; }
        [Column("WEEDSP_1")]
        public short Weedsp1 { get; set; }
        [Column("WEEDSP_2")]
        public short Weedsp2 { get; set; }
        [Column("WEEDSP_3")]
        public short Weedsp3 { get; set; }
        [Column("WEEDSP_4")]
        public short Weedsp4 { get; set; }
        [Required]
        [Column("PRHFCY_0")]
        [StringLength(5)]
        public string Prhfcy0 { get; set; }
        [Required]
        [Column("FCYADD_0")]
        [StringLength(7)]
        public string Fcyadd0 { get; set; }
        [Required]
        [Column("STOFCY_0")]
        [StringLength(5)]
        public string Stofcy0 { get; set; }
        [Required]
        [Column("USEPLC_0")]
        [StringLength(30)]
        public string Useplc0 { get; set; }
        [Required]
        [Column("EECICT2_0")]
        [StringLength(20)]
        public string Eecict20 { get; set; }
        [Required]
        [Column("ICTCTY2_0")]
        [StringLength(40)]
        public string Ictcty20 { get; set; }
        [Required]
        [Column("FFWNUM2_0")]
        [StringLength(15)]
        public string Ffwnum20 { get; set; }
        [Required]
        [Column("FFWADD2_0")]
        [StringLength(7)]
        public string Ffwadd20 { get; set; }
        [Column("EECLOC2_0")]
        public short Eecloc20 { get; set; }
        [Required]
        [Column("EECNUM2_0")]
        [StringLength(1)]
        public string Eecnum20 { get; set; }
        [Required]
        [Column("PUU_0")]
        [StringLength(3)]
        public string Puu0 { get; set; }
        [Required]
        [Column("STU_0")]
        [StringLength(3)]
        public string Stu0 { get; set; }
        [Column("EXTQTYPUU_0", TypeName = "numeric(28, 13)")]
        public decimal Extqtypuu0 { get; set; }
        [Column("EXTQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Extqtystu0 { get; set; }
        [Column("INVQTYPUU_0", TypeName = "numeric(28, 13)")]
        public decimal Invqtypuu0 { get; set; }
        [Column("INVQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Invqtystu0 { get; set; }
        [Column("ORDQTYPUU_0", TypeName = "numeric(28, 13)")]
        public decimal Ordqtypuu0 { get; set; }
        [Column("ORDQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Ordqtystu0 { get; set; }
        [Column("RCPQTYPUU_0", TypeName = "numeric(28, 13)")]
        public decimal Rcpqtypuu0 { get; set; }
        [Column("RCPQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Rcpqtystu0 { get; set; }
        [Column("RTNQTYPUU_0", TypeName = "numeric(28, 13)")]
        public decimal Rtnqtypuu0 { get; set; }
        [Column("RTNQTYSTU_0", TypeName = "numeric(28, 13)")]
        public decimal Rtnqtystu0 { get; set; }
        [Column("EARQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Earqty0 { get; set; }
        [Column("EARDAT_0", TypeName = "datetime")]
        public DateTime Eardat0 { get; set; }
        [Required]
        [Column("EARHOU_0")]
        [StringLength(5)]
        public string Earhou0 { get; set; }
        [Column("PRIVLT_0", TypeName = "numeric(19, 5)")]
        public decimal Privlt0 { get; set; }
        [Column("AMTVLT_0", TypeName = "numeric(27, 13)")]
        public decimal Amtvlt0 { get; set; }
        [Column("BETFCY_0")]
        public byte Betfcy0 { get; set; }
        [Column("DLVREQNUM_0")]
        public int Dlvreqnum0 { get; set; }
        [Required]
        [Column("TEX_0")]
        [StringLength(12)]
        public string Tex0 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Required]
        [Column("COA_1")]
        [StringLength(3)]
        public string Coa1 { get; set; }
        [Required]
        [Column("COA_2")]
        [StringLength(3)]
        public string Coa2 { get; set; }
        [Required]
        [Column("COA_3")]
        [StringLength(3)]
        public string Coa3 { get; set; }
        [Required]
        [Column("COA_4")]
        [StringLength(3)]
        public string Coa4 { get; set; }
        [Required]
        [Column("COA_5")]
        [StringLength(3)]
        public string Coa5 { get; set; }
        [Required]
        [Column("COA_6")]
        [StringLength(3)]
        public string Coa6 { get; set; }
        [Required]
        [Column("COA_7")]
        [StringLength(3)]
        public string Coa7 { get; set; }
        [Required]
        [Column("COA_8")]
        [StringLength(3)]
        public string Coa8 { get; set; }
        [Required]
        [Column("COA_9")]
        [StringLength(3)]
        public string Coa9 { get; set; }
        [Required]
        [Column("LINACC_0")]
        [StringLength(15)]
        public string Linacc0 { get; set; }
        [Required]
        [Column("LINACC_1")]
        [StringLength(15)]
        public string Linacc1 { get; set; }
        [Required]
        [Column("LINACC_2")]
        [StringLength(15)]
        public string Linacc2 { get; set; }
        [Required]
        [Column("LINACC_3")]
        [StringLength(15)]
        public string Linacc3 { get; set; }
        [Required]
        [Column("LINACC_4")]
        [StringLength(15)]
        public string Linacc4 { get; set; }
        [Required]
        [Column("LINACC_5")]
        [StringLength(15)]
        public string Linacc5 { get; set; }
        [Required]
        [Column("LINACC_6")]
        [StringLength(15)]
        public string Linacc6 { get; set; }
        [Required]
        [Column("LINACC_7")]
        [StringLength(15)]
        public string Linacc7 { get; set; }
        [Required]
        [Column("LINACC_8")]
        [StringLength(15)]
        public string Linacc8 { get; set; }
        [Required]
        [Column("LINACC_9")]
        [StringLength(15)]
        public string Linacc9 { get; set; }
        [Column("LINPURTYP_0")]
        public byte Linpurtyp0 { get; set; }
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