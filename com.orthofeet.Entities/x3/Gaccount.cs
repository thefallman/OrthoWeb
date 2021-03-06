// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GACCOUNT", Schema = "TESTPROD")]
    [Index(nameof(Coa0), nameof(Acc0), Name = "GACCOUNT_GAC0", IsUnique = true)]
    [Index(nameof(Coa0), nameof(Accsho0), Name = "GACCOUNT_GAC1")]
    public partial class Gaccount
    {
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Required]
        [Column("DESSHO_0")]
        [StringLength(10)]
        public string Dessho0 { get; set; }
        [Column("SAC_0")]
        public byte Sac0 { get; set; }
        [Required]
        [Column("ACCSHO_0")]
        [StringLength(4)]
        public string Accsho0 { get; set; }
        [Required]
        [Column("CSLDEB_0")]
        [StringLength(1)]
        public string Csldeb0 { get; set; }
        [Required]
        [Column("CSLCDT_0")]
        [StringLength(1)]
        public string Cslcdt0 { get; set; }
        [Column("CSLFLG_0")]
        public short Cslflg0 { get; set; }
        [Column("CSLFLGFLW_0")]
        public short Cslflgflw0 { get; set; }
        [Required]
        [Column("FLODEB_0")]
        [StringLength(1)]
        public string Flodeb0 { get; set; }
        [Required]
        [Column("FLOCDT_0")]
        [StringLength(1)]
        public string Flocdt0 { get; set; }
        [Required]
        [Column("CLSCOD_0")]
        [StringLength(10)]
        public string Clscod0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Required]
        [Column("SUBACC_0")]
        [StringLength(15)]
        public string Subacc0 { get; set; }
        [Required]
        [Column("SUBBPR_0")]
        [StringLength(15)]
        public string Subbpr0 { get; set; }
        [Required]
        [Column("RPTCODDEB_0")]
        [StringLength(10)]
        public string Rptcoddeb0 { get; set; }
        [Required]
        [Column("RPTCODDEB_1")]
        [StringLength(10)]
        public string Rptcoddeb1 { get; set; }
        [Required]
        [Column("RPTCODDEB_2")]
        [StringLength(10)]
        public string Rptcoddeb2 { get; set; }
        [Required]
        [Column("RPTCODDEB_3")]
        [StringLength(10)]
        public string Rptcoddeb3 { get; set; }
        [Required]
        [Column("RPTCODDEB_4")]
        [StringLength(10)]
        public string Rptcoddeb4 { get; set; }
        [Required]
        [Column("RPTCODDEB_5")]
        [StringLength(10)]
        public string Rptcoddeb5 { get; set; }
        [Required]
        [Column("RPTCODDEB_6")]
        [StringLength(10)]
        public string Rptcoddeb6 { get; set; }
        [Required]
        [Column("RPTCODDEB_7")]
        [StringLength(10)]
        public string Rptcoddeb7 { get; set; }
        [Required]
        [Column("RPTCODDEB_8")]
        [StringLength(10)]
        public string Rptcoddeb8 { get; set; }
        [Required]
        [Column("RPTCODDEB_9")]
        [StringLength(10)]
        public string Rptcoddeb9 { get; set; }
        [Required]
        [Column("RPTCODCDT_0")]
        [StringLength(10)]
        public string Rptcodcdt0 { get; set; }
        [Required]
        [Column("RPTCODCDT_1")]
        [StringLength(10)]
        public string Rptcodcdt1 { get; set; }
        [Required]
        [Column("RPTCODCDT_2")]
        [StringLength(10)]
        public string Rptcodcdt2 { get; set; }
        [Required]
        [Column("RPTCODCDT_3")]
        [StringLength(10)]
        public string Rptcodcdt3 { get; set; }
        [Required]
        [Column("RPTCODCDT_4")]
        [StringLength(10)]
        public string Rptcodcdt4 { get; set; }
        [Required]
        [Column("RPTCODCDT_5")]
        [StringLength(10)]
        public string Rptcodcdt5 { get; set; }
        [Required]
        [Column("RPTCODCDT_6")]
        [StringLength(10)]
        public string Rptcodcdt6 { get; set; }
        [Required]
        [Column("RPTCODCDT_7")]
        [StringLength(10)]
        public string Rptcodcdt7 { get; set; }
        [Required]
        [Column("RPTCODCDT_8")]
        [StringLength(10)]
        public string Rptcodcdt8 { get; set; }
        [Required]
        [Column("RPTCODCDT_9")]
        [StringLength(10)]
        public string Rptcodcdt9 { get; set; }
        [Column("FLGUOM_0")]
        public byte Flguom0 { get; set; }
        [Required]
        [Column("UOM_0")]
        [StringLength(3)]
        public string Uom0 { get; set; }
        [Column("VALUOM_0", TypeName = "numeric(21, 10)")]
        public decimal Valuom0 { get; set; }
        [Column("ENAFLG_0")]
        public byte Enaflg0 { get; set; }
        [Required]
        [Column("ACS_0")]
        [StringLength(10)]
        public string Acs0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Column("VLYSTR_0", TypeName = "datetime")]
        public DateTime Vlystr0 { get; set; }
        [Column("VLYEND_0", TypeName = "datetime")]
        public DateTime Vlyend0 { get; set; }
        [Required]
        [Column("AUZ_0")]
        [StringLength(20)]
        public string Auz0 { get; set; }
        [Column("COANBR_0")]
        public short Coanbr0 { get; set; }
        [Required]
        [Column("OTHCOA_0")]
        [StringLength(3)]
        public string Othcoa0 { get; set; }
        [Required]
        [Column("OTHCOA_1")]
        [StringLength(3)]
        public string Othcoa1 { get; set; }
        [Required]
        [Column("OTHCOA_2")]
        [StringLength(3)]
        public string Othcoa2 { get; set; }
        [Required]
        [Column("OTHCOA_3")]
        [StringLength(3)]
        public string Othcoa3 { get; set; }
        [Required]
        [Column("OTHCOA_4")]
        [StringLength(3)]
        public string Othcoa4 { get; set; }
        [Required]
        [Column("OTHCOA_5")]
        [StringLength(3)]
        public string Othcoa5 { get; set; }
        [Required]
        [Column("OTHCOA_6")]
        [StringLength(3)]
        public string Othcoa6 { get; set; }
        [Required]
        [Column("OTHCOA_7")]
        [StringLength(3)]
        public string Othcoa7 { get; set; }
        [Required]
        [Column("OTHCOA_8")]
        [StringLength(3)]
        public string Othcoa8 { get; set; }
        [Required]
        [Column("OTHCOA_9")]
        [StringLength(3)]
        public string Othcoa9 { get; set; }
        [Required]
        [Column("OTHCOA_10")]
        [StringLength(3)]
        public string Othcoa10 { get; set; }
        [Required]
        [Column("OTHCOA_11")]
        [StringLength(3)]
        public string Othcoa11 { get; set; }
        [Required]
        [Column("OTHCOA_12")]
        [StringLength(3)]
        public string Othcoa12 { get; set; }
        [Required]
        [Column("OTHCOA_13")]
        [StringLength(3)]
        public string Othcoa13 { get; set; }
        [Required]
        [Column("OTHCOA_14")]
        [StringLength(3)]
        public string Othcoa14 { get; set; }
        [Required]
        [Column("OTHCOA_15")]
        [StringLength(3)]
        public string Othcoa15 { get; set; }
        [Required]
        [Column("OTHCOA_16")]
        [StringLength(3)]
        public string Othcoa16 { get; set; }
        [Required]
        [Column("OTHCOA_17")]
        [StringLength(3)]
        public string Othcoa17 { get; set; }
        [Required]
        [Column("OTHCOA_18")]
        [StringLength(3)]
        public string Othcoa18 { get; set; }
        [Required]
        [Column("OTHCOA_19")]
        [StringLength(3)]
        public string Othcoa19 { get; set; }
        [Required]
        [Column("OTHCOA_20")]
        [StringLength(3)]
        public string Othcoa20 { get; set; }
        [Required]
        [Column("OTHCOA_21")]
        [StringLength(3)]
        public string Othcoa21 { get; set; }
        [Required]
        [Column("OTHCOA_22")]
        [StringLength(3)]
        public string Othcoa22 { get; set; }
        [Required]
        [Column("OTHCOA_23")]
        [StringLength(3)]
        public string Othcoa23 { get; set; }
        [Required]
        [Column("OTHCOA_24")]
        [StringLength(3)]
        public string Othcoa24 { get; set; }
        [Required]
        [Column("OTHCOA_25")]
        [StringLength(3)]
        public string Othcoa25 { get; set; }
        [Required]
        [Column("OTHCOA_26")]
        [StringLength(3)]
        public string Othcoa26 { get; set; }
        [Required]
        [Column("OTHCOA_27")]
        [StringLength(3)]
        public string Othcoa27 { get; set; }
        [Required]
        [Column("OTHCOA_28")]
        [StringLength(3)]
        public string Othcoa28 { get; set; }
        [Required]
        [Column("OTHCOA_29")]
        [StringLength(3)]
        public string Othcoa29 { get; set; }
        [Required]
        [Column("OTHCOA_30")]
        [StringLength(3)]
        public string Othcoa30 { get; set; }
        [Required]
        [Column("OTHCOA_31")]
        [StringLength(3)]
        public string Othcoa31 { get; set; }
        [Required]
        [Column("OTHCOA_32")]
        [StringLength(3)]
        public string Othcoa32 { get; set; }
        [Required]
        [Column("OTHCOA_33")]
        [StringLength(3)]
        public string Othcoa33 { get; set; }
        [Required]
        [Column("OTHCOA_34")]
        [StringLength(3)]
        public string Othcoa34 { get; set; }
        [Required]
        [Column("OTHCOA_35")]
        [StringLength(3)]
        public string Othcoa35 { get; set; }
        [Required]
        [Column("OTHCOA_36")]
        [StringLength(3)]
        public string Othcoa36 { get; set; }
        [Required]
        [Column("OTHCOA_37")]
        [StringLength(3)]
        public string Othcoa37 { get; set; }
        [Required]
        [Column("OTHCOA_38")]
        [StringLength(3)]
        public string Othcoa38 { get; set; }
        [Required]
        [Column("OTHCOA_39")]
        [StringLength(3)]
        public string Othcoa39 { get; set; }
        [Required]
        [Column("OTHCOA_40")]
        [StringLength(3)]
        public string Othcoa40 { get; set; }
        [Required]
        [Column("OTHCOA_41")]
        [StringLength(3)]
        public string Othcoa41 { get; set; }
        [Required]
        [Column("OTHCOA_42")]
        [StringLength(3)]
        public string Othcoa42 { get; set; }
        [Required]
        [Column("OTHCOA_43")]
        [StringLength(3)]
        public string Othcoa43 { get; set; }
        [Required]
        [Column("OTHCOA_44")]
        [StringLength(3)]
        public string Othcoa44 { get; set; }
        [Required]
        [Column("OTHCOA_45")]
        [StringLength(3)]
        public string Othcoa45 { get; set; }
        [Required]
        [Column("OTHCOA_46")]
        [StringLength(3)]
        public string Othcoa46 { get; set; }
        [Required]
        [Column("OTHCOA_47")]
        [StringLength(3)]
        public string Othcoa47 { get; set; }
        [Required]
        [Column("OTHCOA_48")]
        [StringLength(3)]
        public string Othcoa48 { get; set; }
        [Required]
        [Column("OTHCOA_49")]
        [StringLength(3)]
        public string Othcoa49 { get; set; }
        [Required]
        [Column("DEFACC_0")]
        [StringLength(15)]
        public string Defacc0 { get; set; }
        [Required]
        [Column("DEFACC_1")]
        [StringLength(15)]
        public string Defacc1 { get; set; }
        [Required]
        [Column("DEFACC_2")]
        [StringLength(15)]
        public string Defacc2 { get; set; }
        [Required]
        [Column("DEFACC_3")]
        [StringLength(15)]
        public string Defacc3 { get; set; }
        [Required]
        [Column("DEFACC_4")]
        [StringLength(15)]
        public string Defacc4 { get; set; }
        [Required]
        [Column("DEFACC_5")]
        [StringLength(15)]
        public string Defacc5 { get; set; }
        [Required]
        [Column("DEFACC_6")]
        [StringLength(15)]
        public string Defacc6 { get; set; }
        [Required]
        [Column("DEFACC_7")]
        [StringLength(15)]
        public string Defacc7 { get; set; }
        [Required]
        [Column("DEFACC_8")]
        [StringLength(15)]
        public string Defacc8 { get; set; }
        [Required]
        [Column("DEFACC_9")]
        [StringLength(15)]
        public string Defacc9 { get; set; }
        [Required]
        [Column("DEFACC_10")]
        [StringLength(15)]
        public string Defacc10 { get; set; }
        [Required]
        [Column("DEFACC_11")]
        [StringLength(15)]
        public string Defacc11 { get; set; }
        [Required]
        [Column("DEFACC_12")]
        [StringLength(15)]
        public string Defacc12 { get; set; }
        [Required]
        [Column("DEFACC_13")]
        [StringLength(15)]
        public string Defacc13 { get; set; }
        [Required]
        [Column("DEFACC_14")]
        [StringLength(15)]
        public string Defacc14 { get; set; }
        [Required]
        [Column("DEFACC_15")]
        [StringLength(15)]
        public string Defacc15 { get; set; }
        [Required]
        [Column("DEFACC_16")]
        [StringLength(15)]
        public string Defacc16 { get; set; }
        [Required]
        [Column("DEFACC_17")]
        [StringLength(15)]
        public string Defacc17 { get; set; }
        [Required]
        [Column("DEFACC_18")]
        [StringLength(15)]
        public string Defacc18 { get; set; }
        [Required]
        [Column("DEFACC_19")]
        [StringLength(15)]
        public string Defacc19 { get; set; }
        [Required]
        [Column("DEFACC_20")]
        [StringLength(15)]
        public string Defacc20 { get; set; }
        [Required]
        [Column("DEFACC_21")]
        [StringLength(15)]
        public string Defacc21 { get; set; }
        [Required]
        [Column("DEFACC_22")]
        [StringLength(15)]
        public string Defacc22 { get; set; }
        [Required]
        [Column("DEFACC_23")]
        [StringLength(15)]
        public string Defacc23 { get; set; }
        [Required]
        [Column("DEFACC_24")]
        [StringLength(15)]
        public string Defacc24 { get; set; }
        [Required]
        [Column("DEFACC_25")]
        [StringLength(15)]
        public string Defacc25 { get; set; }
        [Required]
        [Column("DEFACC_26")]
        [StringLength(15)]
        public string Defacc26 { get; set; }
        [Required]
        [Column("DEFACC_27")]
        [StringLength(15)]
        public string Defacc27 { get; set; }
        [Required]
        [Column("DEFACC_28")]
        [StringLength(15)]
        public string Defacc28 { get; set; }
        [Required]
        [Column("DEFACC_29")]
        [StringLength(15)]
        public string Defacc29 { get; set; }
        [Required]
        [Column("DEFACC_30")]
        [StringLength(15)]
        public string Defacc30 { get; set; }
        [Required]
        [Column("DEFACC_31")]
        [StringLength(15)]
        public string Defacc31 { get; set; }
        [Required]
        [Column("DEFACC_32")]
        [StringLength(15)]
        public string Defacc32 { get; set; }
        [Required]
        [Column("DEFACC_33")]
        [StringLength(15)]
        public string Defacc33 { get; set; }
        [Required]
        [Column("DEFACC_34")]
        [StringLength(15)]
        public string Defacc34 { get; set; }
        [Required]
        [Column("DEFACC_35")]
        [StringLength(15)]
        public string Defacc35 { get; set; }
        [Required]
        [Column("DEFACC_36")]
        [StringLength(15)]
        public string Defacc36 { get; set; }
        [Required]
        [Column("DEFACC_37")]
        [StringLength(15)]
        public string Defacc37 { get; set; }
        [Required]
        [Column("DEFACC_38")]
        [StringLength(15)]
        public string Defacc38 { get; set; }
        [Required]
        [Column("DEFACC_39")]
        [StringLength(15)]
        public string Defacc39 { get; set; }
        [Required]
        [Column("DEFACC_40")]
        [StringLength(15)]
        public string Defacc40 { get; set; }
        [Required]
        [Column("DEFACC_41")]
        [StringLength(15)]
        public string Defacc41 { get; set; }
        [Required]
        [Column("DEFACC_42")]
        [StringLength(15)]
        public string Defacc42 { get; set; }
        [Required]
        [Column("DEFACC_43")]
        [StringLength(15)]
        public string Defacc43 { get; set; }
        [Required]
        [Column("DEFACC_44")]
        [StringLength(15)]
        public string Defacc44 { get; set; }
        [Required]
        [Column("DEFACC_45")]
        [StringLength(15)]
        public string Defacc45 { get; set; }
        [Required]
        [Column("DEFACC_46")]
        [StringLength(15)]
        public string Defacc46 { get; set; }
        [Required]
        [Column("DEFACC_47")]
        [StringLength(15)]
        public string Defacc47 { get; set; }
        [Required]
        [Column("DEFACC_48")]
        [StringLength(15)]
        public string Defacc48 { get; set; }
        [Required]
        [Column("DEFACC_49")]
        [StringLength(15)]
        public string Defacc49 { get; set; }
        [Required]
        [Column("SCRACC_0")]
        [StringLength(15)]
        public string Scracc0 { get; set; }
        [Required]
        [Column("SCRACC_1")]
        [StringLength(15)]
        public string Scracc1 { get; set; }
        [Required]
        [Column("SCRACC_2")]
        [StringLength(15)]
        public string Scracc2 { get; set; }
        [Required]
        [Column("SCRACC_3")]
        [StringLength(15)]
        public string Scracc3 { get; set; }
        [Required]
        [Column("SCRACC_4")]
        [StringLength(15)]
        public string Scracc4 { get; set; }
        [Required]
        [Column("SCRACC_5")]
        [StringLength(15)]
        public string Scracc5 { get; set; }
        [Required]
        [Column("SCRACC_6")]
        [StringLength(15)]
        public string Scracc6 { get; set; }
        [Required]
        [Column("SCRACC_7")]
        [StringLength(15)]
        public string Scracc7 { get; set; }
        [Required]
        [Column("SCRACC_8")]
        [StringLength(15)]
        public string Scracc8 { get; set; }
        [Required]
        [Column("SCRACC_9")]
        [StringLength(15)]
        public string Scracc9 { get; set; }
        [Required]
        [Column("SCRACC_10")]
        [StringLength(15)]
        public string Scracc10 { get; set; }
        [Required]
        [Column("SCRACC_11")]
        [StringLength(15)]
        public string Scracc11 { get; set; }
        [Required]
        [Column("SCRACC_12")]
        [StringLength(15)]
        public string Scracc12 { get; set; }
        [Required]
        [Column("SCRACC_13")]
        [StringLength(15)]
        public string Scracc13 { get; set; }
        [Required]
        [Column("SCRACC_14")]
        [StringLength(15)]
        public string Scracc14 { get; set; }
        [Required]
        [Column("SCRACC_15")]
        [StringLength(15)]
        public string Scracc15 { get; set; }
        [Required]
        [Column("SCRACC_16")]
        [StringLength(15)]
        public string Scracc16 { get; set; }
        [Required]
        [Column("SCRACC_17")]
        [StringLength(15)]
        public string Scracc17 { get; set; }
        [Required]
        [Column("SCRACC_18")]
        [StringLength(15)]
        public string Scracc18 { get; set; }
        [Required]
        [Column("SCRACC_19")]
        [StringLength(15)]
        public string Scracc19 { get; set; }
        [Required]
        [Column("SCRACC_20")]
        [StringLength(15)]
        public string Scracc20 { get; set; }
        [Required]
        [Column("SCRACC_21")]
        [StringLength(15)]
        public string Scracc21 { get; set; }
        [Required]
        [Column("SCRACC_22")]
        [StringLength(15)]
        public string Scracc22 { get; set; }
        [Required]
        [Column("SCRACC_23")]
        [StringLength(15)]
        public string Scracc23 { get; set; }
        [Required]
        [Column("SCRACC_24")]
        [StringLength(15)]
        public string Scracc24 { get; set; }
        [Required]
        [Column("SCRACC_25")]
        [StringLength(15)]
        public string Scracc25 { get; set; }
        [Required]
        [Column("SCRACC_26")]
        [StringLength(15)]
        public string Scracc26 { get; set; }
        [Required]
        [Column("SCRACC_27")]
        [StringLength(15)]
        public string Scracc27 { get; set; }
        [Required]
        [Column("SCRACC_28")]
        [StringLength(15)]
        public string Scracc28 { get; set; }
        [Required]
        [Column("SCRACC_29")]
        [StringLength(15)]
        public string Scracc29 { get; set; }
        [Required]
        [Column("SCRACC_30")]
        [StringLength(15)]
        public string Scracc30 { get; set; }
        [Required]
        [Column("SCRACC_31")]
        [StringLength(15)]
        public string Scracc31 { get; set; }
        [Required]
        [Column("SCRACC_32")]
        [StringLength(15)]
        public string Scracc32 { get; set; }
        [Required]
        [Column("SCRACC_33")]
        [StringLength(15)]
        public string Scracc33 { get; set; }
        [Required]
        [Column("SCRACC_34")]
        [StringLength(15)]
        public string Scracc34 { get; set; }
        [Required]
        [Column("SCRACC_35")]
        [StringLength(15)]
        public string Scracc35 { get; set; }
        [Required]
        [Column("SCRACC_36")]
        [StringLength(15)]
        public string Scracc36 { get; set; }
        [Required]
        [Column("SCRACC_37")]
        [StringLength(15)]
        public string Scracc37 { get; set; }
        [Required]
        [Column("SCRACC_38")]
        [StringLength(15)]
        public string Scracc38 { get; set; }
        [Required]
        [Column("SCRACC_39")]
        [StringLength(15)]
        public string Scracc39 { get; set; }
        [Required]
        [Column("SCRACC_40")]
        [StringLength(15)]
        public string Scracc40 { get; set; }
        [Required]
        [Column("SCRACC_41")]
        [StringLength(15)]
        public string Scracc41 { get; set; }
        [Required]
        [Column("SCRACC_42")]
        [StringLength(15)]
        public string Scracc42 { get; set; }
        [Required]
        [Column("SCRACC_43")]
        [StringLength(15)]
        public string Scracc43 { get; set; }
        [Required]
        [Column("SCRACC_44")]
        [StringLength(15)]
        public string Scracc44 { get; set; }
        [Required]
        [Column("SCRACC_45")]
        [StringLength(15)]
        public string Scracc45 { get; set; }
        [Required]
        [Column("SCRACC_46")]
        [StringLength(15)]
        public string Scracc46 { get; set; }
        [Required]
        [Column("SCRACC_47")]
        [StringLength(15)]
        public string Scracc47 { get; set; }
        [Required]
        [Column("SCRACC_48")]
        [StringLength(15)]
        public string Scracc48 { get; set; }
        [Required]
        [Column("SCRACC_49")]
        [StringLength(15)]
        public string Scracc49 { get; set; }
        [Column("OBYIPT_0")]
        public byte Obyipt0 { get; set; }
        [Column("OBYIPT_1")]
        public byte Obyipt1 { get; set; }
        [Column("OBYIPT_2")]
        public byte Obyipt2 { get; set; }
        [Column("OBYIPT_3")]
        public byte Obyipt3 { get; set; }
        [Column("OBYIPT_4")]
        public byte Obyipt4 { get; set; }
        [Column("OBYIPT_5")]
        public byte Obyipt5 { get; set; }
        [Column("OBYIPT_6")]
        public byte Obyipt6 { get; set; }
        [Column("OBYIPT_7")]
        public byte Obyipt7 { get; set; }
        [Column("OBYIPT_8")]
        public byte Obyipt8 { get; set; }
        [Column("OBYIPT_9")]
        public byte Obyipt9 { get; set; }
        [Column("OBYIPT_10")]
        public byte Obyipt10 { get; set; }
        [Column("OBYIPT_11")]
        public byte Obyipt11 { get; set; }
        [Column("OBYIPT_12")]
        public byte Obyipt12 { get; set; }
        [Column("OBYIPT_13")]
        public byte Obyipt13 { get; set; }
        [Column("OBYIPT_14")]
        public byte Obyipt14 { get; set; }
        [Column("OBYIPT_15")]
        public byte Obyipt15 { get; set; }
        [Column("OBYIPT_16")]
        public byte Obyipt16 { get; set; }
        [Column("OBYIPT_17")]
        public byte Obyipt17 { get; set; }
        [Column("OBYIPT_18")]
        public byte Obyipt18 { get; set; }
        [Column("OBYIPT_19")]
        public byte Obyipt19 { get; set; }
        [Column("OBYIPT_20")]
        public byte Obyipt20 { get; set; }
        [Column("OBYIPT_21")]
        public byte Obyipt21 { get; set; }
        [Column("OBYIPT_22")]
        public byte Obyipt22 { get; set; }
        [Column("OBYIPT_23")]
        public byte Obyipt23 { get; set; }
        [Column("OBYIPT_24")]
        public byte Obyipt24 { get; set; }
        [Column("OBYIPT_25")]
        public byte Obyipt25 { get; set; }
        [Column("OBYIPT_26")]
        public byte Obyipt26 { get; set; }
        [Column("OBYIPT_27")]
        public byte Obyipt27 { get; set; }
        [Column("OBYIPT_28")]
        public byte Obyipt28 { get; set; }
        [Column("OBYIPT_29")]
        public byte Obyipt29 { get; set; }
        [Column("OBYIPT_30")]
        public byte Obyipt30 { get; set; }
        [Column("OBYIPT_31")]
        public byte Obyipt31 { get; set; }
        [Column("OBYIPT_32")]
        public byte Obyipt32 { get; set; }
        [Column("OBYIPT_33")]
        public byte Obyipt33 { get; set; }
        [Column("OBYIPT_34")]
        public byte Obyipt34 { get; set; }
        [Column("OBYIPT_35")]
        public byte Obyipt35 { get; set; }
        [Column("OBYIPT_36")]
        public byte Obyipt36 { get; set; }
        [Column("OBYIPT_37")]
        public byte Obyipt37 { get; set; }
        [Column("OBYIPT_38")]
        public byte Obyipt38 { get; set; }
        [Column("OBYIPT_39")]
        public byte Obyipt39 { get; set; }
        [Column("OBYIPT_40")]
        public byte Obyipt40 { get; set; }
        [Column("OBYIPT_41")]
        public byte Obyipt41 { get; set; }
        [Column("OBYIPT_42")]
        public byte Obyipt42 { get; set; }
        [Column("OBYIPT_43")]
        public byte Obyipt43 { get; set; }
        [Column("OBYIPT_44")]
        public byte Obyipt44 { get; set; }
        [Column("OBYIPT_45")]
        public byte Obyipt45 { get; set; }
        [Column("OBYIPT_46")]
        public byte Obyipt46 { get; set; }
        [Column("OBYIPT_47")]
        public byte Obyipt47 { get; set; }
        [Column("OBYIPT_48")]
        public byte Obyipt48 { get; set; }
        [Column("OBYIPT_49")]
        public byte Obyipt49 { get; set; }
        [Column("FLGVAT_0")]
        public byte Flgvat0 { get; set; }
        [Column("VATIPT_0")]
        public byte Vatipt0 { get; set; }
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
        [Column("ESDTRK_0")]
        public short Esdtrk0 { get; set; }
        [Column("SNSDEF_0")]
        public byte Snsdef0 { get; set; }
        [Column("SNSBLC_0")]
        public byte Snsblc0 { get; set; }
        [Column("MTC_0")]
        public byte Mtc0 { get; set; }
        [Column("CEN_0")]
        public byte Cen0 { get; set; }
        [Column("DIFFLG_0")]
        public byte Difflg0 { get; set; }
        [Column("DIF_0")]
        public byte Dif0 { get; set; }
        [Column("LOSGAIGNR_0")]
        public byte Losgaignr0 { get; set; }
        [Column("DAS_0")]
        public byte Das0 { get; set; }
        [Column("DASTYP_0")]
        public byte Dastyp0 { get; set; }
        [Column("FLGABL_0")]
        public byte Flgabl0 { get; set; }
        [Column("FLGEXPCRE_0")]
        public byte Flgexpcre0 { get; set; }
        [Column("FLGDEP_0")]
        public short Flgdep0 { get; set; }
        [Required]
        [Column("GACPVS_0")]
        [StringLength(1)]
        public string Gacpvs0 { get; set; }
        [Column("GACACN_0")]
        public byte Gacacn0 { get; set; }
        [Column("RITTYP_0")]
        public short Rittyp0 { get; set; }
        [Column("UPDBLC_0")]
        public byte Updblc0 { get; set; }
        [Column("AUZBPR_0")]
        public byte Auzbpr0 { get; set; }
        [Column("AUZBPR_1")]
        public byte Auzbpr1 { get; set; }
        [Column("AUZBPR_2")]
        public byte Auzbpr2 { get; set; }
        [Column("AUZBPR_3")]
        public byte Auzbpr3 { get; set; }
        [Column("AUZBPR_4")]
        public byte Auzbpr4 { get; set; }
        [Column("AUZBPR_5")]
        public byte Auzbpr5 { get; set; }
        [Column("AUZBPR_6")]
        public byte Auzbpr6 { get; set; }
        [Column("AUZBPR_7")]
        public byte Auzbpr7 { get; set; }
        [Column("AUZBPR_8")]
        public byte Auzbpr8 { get; set; }
        [Column("AUZBPR_9")]
        public byte Auzbpr9 { get; set; }
        [Required]
        [Column("DSP_0")]
        [StringLength(10)]
        public string Dsp0 { get; set; }
        [Column("DACDIENBR_0")]
        public short Dacdienbr0 { get; set; }
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
        [Column("CCEDEF_0")]
        [StringLength(15)]
        public string Ccedef0 { get; set; }
        [Required]
        [Column("CCEDEF_1")]
        [StringLength(15)]
        public string Ccedef1 { get; set; }
        [Required]
        [Column("CCEDEF_2")]
        [StringLength(15)]
        public string Ccedef2 { get; set; }
        [Required]
        [Column("CCEDEF_3")]
        [StringLength(15)]
        public string Ccedef3 { get; set; }
        [Required]
        [Column("CCEDEF_4")]
        [StringLength(15)]
        public string Ccedef4 { get; set; }
        [Required]
        [Column("CCEDEF_5")]
        [StringLength(15)]
        public string Ccedef5 { get; set; }
        [Required]
        [Column("CCEDEF_6")]
        [StringLength(15)]
        public string Ccedef6 { get; set; }
        [Required]
        [Column("CCEDEF_7")]
        [StringLength(15)]
        public string Ccedef7 { get; set; }
        [Required]
        [Column("CCEDEF_8")]
        [StringLength(15)]
        public string Ccedef8 { get; set; }
        [Required]
        [Column("CCEDEF_9")]
        [StringLength(15)]
        public string Ccedef9 { get; set; }
        [Required]
        [Column("CCEDEF_10")]
        [StringLength(15)]
        public string Ccedef10 { get; set; }
        [Required]
        [Column("CCEDEF_11")]
        [StringLength(15)]
        public string Ccedef11 { get; set; }
        [Required]
        [Column("CCEDEF_12")]
        [StringLength(15)]
        public string Ccedef12 { get; set; }
        [Required]
        [Column("CCEDEF_13")]
        [StringLength(15)]
        public string Ccedef13 { get; set; }
        [Required]
        [Column("CCEDEF_14")]
        [StringLength(15)]
        public string Ccedef14 { get; set; }
        [Required]
        [Column("CCEDEF_15")]
        [StringLength(15)]
        public string Ccedef15 { get; set; }
        [Required]
        [Column("CCEDEF_16")]
        [StringLength(15)]
        public string Ccedef16 { get; set; }
        [Required]
        [Column("CCEDEF_17")]
        [StringLength(15)]
        public string Ccedef17 { get; set; }
        [Required]
        [Column("CCEDEF_18")]
        [StringLength(15)]
        public string Ccedef18 { get; set; }
        [Required]
        [Column("CCEDEF_19")]
        [StringLength(15)]
        public string Ccedef19 { get; set; }
        [Column("BUDTRK_0")]
        public byte Budtrk0 { get; set; }
        [Required]
        [Column("TIMDSP_0")]
        [StringLength(10)]
        public string Timdsp0 { get; set; }
        [Column("FRWCUR_0")]
        public byte Frwcur0 { get; set; }
        [Required]
        [Column("BIDNUM_0")]
        [StringLength(30)]
        public string Bidnum0 { get; set; }
        [Required]
        [Column("BPAADD_0")]
        [StringLength(7)]
        public string Bpaadd0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}