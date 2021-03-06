// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("PWRKPOC", Schema = "TESTPROD")]
    [Index(nameof(Pronum0), nameof(Pohnum0), nameof(Poplin0), Name = "PWRKPOC_PWC0", IsUnique = true)]
    public partial class Pwrkpoc
    {
        [Column("PRONUM_0")]
        public int Pronum0 { get; set; }
        [Required]
        [Column("POHNUM_0")]
        [StringLength(20)]
        public string Pohnum0 { get; set; }
        [Column("POPLIN_0")]
        public int Poplin0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Required]
        [Column("ITMREFBPS_0")]
        [StringLength(20)]
        public string Itmrefbps0 { get; set; }
        [Required]
        [Column("ITMDES_0")]
        [StringLength(30)]
        public string Itmdes0 { get; set; }
        [Required]
        [Column("ITMDES1_0")]
        [StringLength(30)]
        public string Itmdes10 { get; set; }
        [Required]
        [Column("FMTREM_0")]
        [StringLength(15)]
        public string Fmtrem0 { get; set; }
        [Required]
        [Column("FMTREM_1")]
        [StringLength(15)]
        public string Fmtrem1 { get; set; }
        [Required]
        [Column("FMTREM_2")]
        [StringLength(15)]
        public string Fmtrem2 { get; set; }
        [Required]
        [Column("FMTREM_3")]
        [StringLength(15)]
        public string Fmtrem3 { get; set; }
        [Required]
        [Column("FMTREM_4")]
        [StringLength(15)]
        public string Fmtrem4 { get; set; }
        [Required]
        [Column("FMTREM_5")]
        [StringLength(15)]
        public string Fmtrem5 { get; set; }
        [Required]
        [Column("FMTREM_6")]
        [StringLength(15)]
        public string Fmtrem6 { get; set; }
        [Required]
        [Column("FMTREM_7")]
        [StringLength(15)]
        public string Fmtrem7 { get; set; }
        [Required]
        [Column("FMTREM_8")]
        [StringLength(15)]
        public string Fmtrem8 { get; set; }
        [Required]
        [Column("LINSTOFCY_0")]
        [StringLength(5)]
        public string Linstofcy0 { get; set; }
        [Required]
        [Column("PRHFCY_0")]
        [StringLength(5)]
        public string Prhfcy0 { get; set; }
        [Required]
        [Column("FCYADD_0")]
        [StringLength(7)]
        public string Fcyadd0 { get; set; }
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
        [Column("XPUUFLG_0")]
        public byte Xpuuflg0 { get; set; }
        [Column("EXTQTYPUU_0", TypeName = "numeric(28, 13)")]
        public decimal Extqtypuu0 { get; set; }
        [Column("FIMHOR_0")]
        public short Fimhor0 { get; set; }
        [Column("FIMHORUOM_0")]
        public byte Fimhoruom0 { get; set; }
        [Column("FRTHOR_0")]
        public short Frthor0 { get; set; }
        [Column("FRTHORUOM_0")]
        public byte Frthoruom0 { get; set; }
        [Column("XSTRDAT_0", TypeName = "datetime")]
        public DateTime Xstrdat0 { get; set; }
        [Column("XENDDAT_0", TypeName = "datetime")]
        public DateTime Xenddat0 { get; set; }
        [Required]
        [Column("PLI_0")]
        [StringLength(6)]
        public string Pli0 { get; set; }
        [Column("PRIVLT_0", TypeName = "numeric(19, 5)")]
        public decimal Privlt0 { get; set; }
        [Required]
        [Column("WCURVLT_0")]
        [StringLength(3)]
        public string Wcurvlt0 { get; set; }
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
        [Column("AMTVLT_0", TypeName = "numeric(27, 13)")]
        public decimal Amtvlt0 { get; set; }
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
        [Column("VAT_0")]
        [StringLength(5)]
        public string Vat0 { get; set; }
        [Required]
        [Column("VAT_1")]
        [StringLength(5)]
        public string Vat1 { get; set; }
        [Required]
        [Column("VAT_2")]
        [StringLength(5)]
        public string Vat2 { get; set; }
        [Required]
        [Column("TAXRCP_0")]
        [StringLength(1)]
        public string Taxrcp0 { get; set; }
        [Required]
        [Column("TAXISS_0")]
        [StringLength(1)]
        public string Taxiss0 { get; set; }
        [Required]
        [Column("TAXOTH1_0")]
        [StringLength(1)]
        public string Taxoth10 { get; set; }
        [Required]
        [Column("TAXOTH2_0")]
        [StringLength(1)]
        public string Taxoth20 { get; set; }
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
        [Required]
        [Column("LINTEX_0")]
        [StringLength(12)]
        public string Lintex0 { get; set; }
        [Column("LINCREFLG_0")]
        public short Lincreflg0 { get; set; }
        [Column("XONUM_0")]
        public short Xonum0 { get; set; }
        [Column("XONUM_1")]
        public short Xonum1 { get; set; }
        [Column("XONUM_2")]
        public short Xonum2 { get; set; }
        [Column("XONUM_3")]
        public short Xonum3 { get; set; }
        [Column("XONUM_4")]
        public short Xonum4 { get; set; }
        [Column("XONUM_5")]
        public short Xonum5 { get; set; }
        [Column("XONUM_6")]
        public short Xonum6 { get; set; }
        [Column("XONUM_7")]
        public short Xonum7 { get; set; }
        [Column("XONUM_8")]
        public short Xonum8 { get; set; }
        [Column("XONUM_9")]
        public short Xonum9 { get; set; }
        [Column("XONUM_10")]
        public short Xonum10 { get; set; }
        [Column("XONUM_11")]
        public short Xonum11 { get; set; }
        [Column("XONUM_12")]
        public short Xonum12 { get; set; }
        [Column("XONUM_13")]
        public short Xonum13 { get; set; }
        [Column("XONUM_14")]
        public short Xonum14 { get; set; }
        [Column("XONUM_15")]
        public short Xonum15 { get; set; }
        [Column("XONUM_16")]
        public short Xonum16 { get; set; }
        [Column("XONUM_17")]
        public short Xonum17 { get; set; }
        [Column("XONUM_18")]
        public short Xonum18 { get; set; }
        [Column("XONUM_19")]
        public short Xonum19 { get; set; }
        [Column("XONUM_20")]
        public short Xonum20 { get; set; }
        [Column("XONUM_21")]
        public short Xonum21 { get; set; }
        [Column("XONUM_22")]
        public short Xonum22 { get; set; }
        [Column("XONUM_23")]
        public short Xonum23 { get; set; }
        [Column("XONUM_24")]
        public short Xonum24 { get; set; }
        [Column("XONUM_25")]
        public short Xonum25 { get; set; }
        [Column("XONUM_26")]
        public short Xonum26 { get; set; }
        [Column("XONUM_27")]
        public short Xonum27 { get; set; }
        [Column("XONUM_28")]
        public short Xonum28 { get; set; }
        [Column("XONUM_29")]
        public short Xonum29 { get; set; }
        [Column("XONUM_30")]
        public short Xonum30 { get; set; }
        [Column("XONUM_31")]
        public short Xonum31 { get; set; }
        [Column("XONUM_32")]
        public short Xonum32 { get; set; }
        [Column("XONUM_33")]
        public short Xonum33 { get; set; }
        [Column("XONUM_34")]
        public short Xonum34 { get; set; }
        [Column("XONUM_35")]
        public short Xonum35 { get; set; }
        [Column("XONUM_36")]
        public short Xonum36 { get; set; }
        [Column("XONUM_37")]
        public short Xonum37 { get; set; }
        [Column("XONUM_38")]
        public short Xonum38 { get; set; }
        [Column("XONUM_39")]
        public short Xonum39 { get; set; }
        [Column("XONUM_40")]
        public short Xonum40 { get; set; }
        [Column("XONUM_41")]
        public short Xonum41 { get; set; }
        [Column("XONUM_42")]
        public short Xonum42 { get; set; }
        [Column("XONUM_43")]
        public short Xonum43 { get; set; }
        [Column("XONUM_44")]
        public short Xonum44 { get; set; }
        [Column("XONUM_45")]
        public short Xonum45 { get; set; }
        [Column("XONUM_46")]
        public short Xonum46 { get; set; }
        [Column("XONUM_47")]
        public short Xonum47 { get; set; }
        [Column("XONUM_48")]
        public short Xonum48 { get; set; }
        [Column("XONUM_49")]
        public short Xonum49 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}