﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("TXSA", Schema = "TESTPROD")]
    [Index(nameof(Lstgrp0), nameof(Txsnam0), Name = "TXSA_TXS0", IsUnique = true)]
    [Index(nameof(Txsnam0), Name = "TXSA_TXS1", IsUnique = true)]
    public partial class Txsa
    {
        [Required]
        [Column("LSTGRP_0")]
        [StringLength(8)]
        public string Lstgrp0 { get; set; }
        [Required]
        [Column("TXSNAM_0")]
        [StringLength(10)]
        public string Txsnam0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Column("AUTVER_0")]
        public byte Autver0 { get; set; }
        [Column("GENLEDTYP_0")]
        public byte Genledtyp0 { get; set; }
        [Column("ANALEDTYP_0")]
        public byte Analedtyp0 { get; set; }
        [Column("NBRCOL_0")]
        public short Nbrcol0 { get; set; }
        [Required]
        [Column("COLNUM_0")]
        [StringLength(20)]
        public string Colnum0 { get; set; }
        [Required]
        [Column("COLNUM_1")]
        [StringLength(20)]
        public string Colnum1 { get; set; }
        [Required]
        [Column("COLNUM_2")]
        [StringLength(20)]
        public string Colnum2 { get; set; }
        [Required]
        [Column("COLNUM_3")]
        [StringLength(20)]
        public string Colnum3 { get; set; }
        [Required]
        [Column("COLNUM_4")]
        [StringLength(20)]
        public string Colnum4 { get; set; }
        [Required]
        [Column("COLNUM_5")]
        [StringLength(20)]
        public string Colnum5 { get; set; }
        [Required]
        [Column("COLNUM_6")]
        [StringLength(20)]
        public string Colnum6 { get; set; }
        [Required]
        [Column("COLNUM_7")]
        [StringLength(20)]
        public string Colnum7 { get; set; }
        [Required]
        [Column("COLNUM_8")]
        [StringLength(20)]
        public string Colnum8 { get; set; }
        [Required]
        [Column("COLNUM_9")]
        [StringLength(20)]
        public string Colnum9 { get; set; }
        [Required]
        [Column("COLNUM_10")]
        [StringLength(20)]
        public string Colnum10 { get; set; }
        [Required]
        [Column("COLNUM_11")]
        [StringLength(20)]
        public string Colnum11 { get; set; }
        [Required]
        [Column("COLNUM_12")]
        [StringLength(20)]
        public string Colnum12 { get; set; }
        [Required]
        [Column("COLNUM_13")]
        [StringLength(20)]
        public string Colnum13 { get; set; }
        [Required]
        [Column("COLNUM_14")]
        [StringLength(20)]
        public string Colnum14 { get; set; }
        [Required]
        [Column("COLNUM_15")]
        [StringLength(20)]
        public string Colnum15 { get; set; }
        [Required]
        [Column("COLNUM_16")]
        [StringLength(20)]
        public string Colnum16 { get; set; }
        [Required]
        [Column("COLNUM_17")]
        [StringLength(20)]
        public string Colnum17 { get; set; }
        [Required]
        [Column("COLNUM_18")]
        [StringLength(20)]
        public string Colnum18 { get; set; }
        [Required]
        [Column("COLNUM_19")]
        [StringLength(20)]
        public string Colnum19 { get; set; }
        [Column("SAICOL_0")]
        public byte Saicol0 { get; set; }
        [Column("SAICOL_1")]
        public byte Saicol1 { get; set; }
        [Column("SAICOL_2")]
        public byte Saicol2 { get; set; }
        [Column("SAICOL_3")]
        public byte Saicol3 { get; set; }
        [Column("SAICOL_4")]
        public byte Saicol4 { get; set; }
        [Column("SAICOL_5")]
        public byte Saicol5 { get; set; }
        [Column("SAICOL_6")]
        public byte Saicol6 { get; set; }
        [Column("SAICOL_7")]
        public byte Saicol7 { get; set; }
        [Column("SAICOL_8")]
        public byte Saicol8 { get; set; }
        [Column("SAICOL_9")]
        public byte Saicol9 { get; set; }
        [Column("SAICOL_10")]
        public byte Saicol10 { get; set; }
        [Column("SAICOL_11")]
        public byte Saicol11 { get; set; }
        [Column("SAICOL_12")]
        public byte Saicol12 { get; set; }
        [Column("SAICOL_13")]
        public byte Saicol13 { get; set; }
        [Column("SAICOL_14")]
        public byte Saicol14 { get; set; }
        [Column("SAICOL_15")]
        public byte Saicol15 { get; set; }
        [Column("SAICOL_16")]
        public byte Saicol16 { get; set; }
        [Column("SAICOL_17")]
        public byte Saicol17 { get; set; }
        [Column("SAICOL_18")]
        public byte Saicol18 { get; set; }
        [Column("SAICOL_19")]
        public byte Saicol19 { get; set; }
        [Column("FMTCOL_0")]
        public byte Fmtcol0 { get; set; }
        [Column("FMTCOL_1")]
        public byte Fmtcol1 { get; set; }
        [Column("FMTCOL_2")]
        public byte Fmtcol2 { get; set; }
        [Column("FMTCOL_3")]
        public byte Fmtcol3 { get; set; }
        [Column("FMTCOL_4")]
        public byte Fmtcol4 { get; set; }
        [Column("FMTCOL_5")]
        public byte Fmtcol5 { get; set; }
        [Column("FMTCOL_6")]
        public byte Fmtcol6 { get; set; }
        [Column("FMTCOL_7")]
        public byte Fmtcol7 { get; set; }
        [Column("FMTCOL_8")]
        public byte Fmtcol8 { get; set; }
        [Column("FMTCOL_9")]
        public byte Fmtcol9 { get; set; }
        [Column("FMTCOL_10")]
        public byte Fmtcol10 { get; set; }
        [Column("FMTCOL_11")]
        public byte Fmtcol11 { get; set; }
        [Column("FMTCOL_12")]
        public byte Fmtcol12 { get; set; }
        [Column("FMTCOL_13")]
        public byte Fmtcol13 { get; set; }
        [Column("FMTCOL_14")]
        public byte Fmtcol14 { get; set; }
        [Column("FMTCOL_15")]
        public byte Fmtcol15 { get; set; }
        [Column("FMTCOL_16")]
        public byte Fmtcol16 { get; set; }
        [Column("FMTCOL_17")]
        public byte Fmtcol17 { get; set; }
        [Column("FMTCOL_18")]
        public byte Fmtcol18 { get; set; }
        [Column("FMTCOL_19")]
        public byte Fmtcol19 { get; set; }
        [Column("EFFCOL_0")]
        public byte Effcol0 { get; set; }
        [Column("EFFCOL_1")]
        public byte Effcol1 { get; set; }
        [Column("EFFCOL_2")]
        public byte Effcol2 { get; set; }
        [Column("EFFCOL_3")]
        public byte Effcol3 { get; set; }
        [Column("EFFCOL_4")]
        public byte Effcol4 { get; set; }
        [Column("EFFCOL_5")]
        public byte Effcol5 { get; set; }
        [Column("EFFCOL_6")]
        public byte Effcol6 { get; set; }
        [Column("EFFCOL_7")]
        public byte Effcol7 { get; set; }
        [Column("EFFCOL_8")]
        public byte Effcol8 { get; set; }
        [Column("EFFCOL_9")]
        public byte Effcol9 { get; set; }
        [Column("EFFCOL_10")]
        public byte Effcol10 { get; set; }
        [Column("EFFCOL_11")]
        public byte Effcol11 { get; set; }
        [Column("EFFCOL_12")]
        public byte Effcol12 { get; set; }
        [Column("EFFCOL_13")]
        public byte Effcol13 { get; set; }
        [Column("EFFCOL_14")]
        public byte Effcol14 { get; set; }
        [Column("EFFCOL_15")]
        public byte Effcol15 { get; set; }
        [Column("EFFCOL_16")]
        public byte Effcol16 { get; set; }
        [Column("EFFCOL_17")]
        public byte Effcol17 { get; set; }
        [Column("EFFCOL_18")]
        public byte Effcol18 { get; set; }
        [Column("EFFCOL_19")]
        public byte Effcol19 { get; set; }
        [Column("DIVCOL_0", TypeName = "numeric(19, 9)")]
        public decimal Divcol0 { get; set; }
        [Column("DIVCOL_1", TypeName = "numeric(19, 9)")]
        public decimal Divcol1 { get; set; }
        [Column("DIVCOL_2", TypeName = "numeric(19, 9)")]
        public decimal Divcol2 { get; set; }
        [Column("DIVCOL_3", TypeName = "numeric(19, 9)")]
        public decimal Divcol3 { get; set; }
        [Column("DIVCOL_4", TypeName = "numeric(19, 9)")]
        public decimal Divcol4 { get; set; }
        [Column("DIVCOL_5", TypeName = "numeric(19, 9)")]
        public decimal Divcol5 { get; set; }
        [Column("DIVCOL_6", TypeName = "numeric(19, 9)")]
        public decimal Divcol6 { get; set; }
        [Column("DIVCOL_7", TypeName = "numeric(19, 9)")]
        public decimal Divcol7 { get; set; }
        [Column("DIVCOL_8", TypeName = "numeric(19, 9)")]
        public decimal Divcol8 { get; set; }
        [Column("DIVCOL_9", TypeName = "numeric(19, 9)")]
        public decimal Divcol9 { get; set; }
        [Column("DIVCOL_10", TypeName = "numeric(19, 9)")]
        public decimal Divcol10 { get; set; }
        [Column("DIVCOL_11", TypeName = "numeric(19, 9)")]
        public decimal Divcol11 { get; set; }
        [Column("DIVCOL_12", TypeName = "numeric(19, 9)")]
        public decimal Divcol12 { get; set; }
        [Column("DIVCOL_13", TypeName = "numeric(19, 9)")]
        public decimal Divcol13 { get; set; }
        [Column("DIVCOL_14", TypeName = "numeric(19, 9)")]
        public decimal Divcol14 { get; set; }
        [Column("DIVCOL_15", TypeName = "numeric(19, 9)")]
        public decimal Divcol15 { get; set; }
        [Column("DIVCOL_16", TypeName = "numeric(19, 9)")]
        public decimal Divcol16 { get; set; }
        [Column("DIVCOL_17", TypeName = "numeric(19, 9)")]
        public decimal Divcol17 { get; set; }
        [Column("DIVCOL_18", TypeName = "numeric(19, 9)")]
        public decimal Divcol18 { get; set; }
        [Column("DIVCOL_19", TypeName = "numeric(19, 9)")]
        public decimal Divcol19 { get; set; }
        [Column("DECCOL_0")]
        public short Deccol0 { get; set; }
        [Column("DECCOL_1")]
        public short Deccol1 { get; set; }
        [Column("DECCOL_2")]
        public short Deccol2 { get; set; }
        [Column("DECCOL_3")]
        public short Deccol3 { get; set; }
        [Column("DECCOL_4")]
        public short Deccol4 { get; set; }
        [Column("DECCOL_5")]
        public short Deccol5 { get; set; }
        [Column("DECCOL_6")]
        public short Deccol6 { get; set; }
        [Column("DECCOL_7")]
        public short Deccol7 { get; set; }
        [Column("DECCOL_8")]
        public short Deccol8 { get; set; }
        [Column("DECCOL_9")]
        public short Deccol9 { get; set; }
        [Column("DECCOL_10")]
        public short Deccol10 { get; set; }
        [Column("DECCOL_11")]
        public short Deccol11 { get; set; }
        [Column("DECCOL_12")]
        public short Deccol12 { get; set; }
        [Column("DECCOL_13")]
        public short Deccol13 { get; set; }
        [Column("DECCOL_14")]
        public short Deccol14 { get; set; }
        [Column("DECCOL_15")]
        public short Deccol15 { get; set; }
        [Column("DECCOL_16")]
        public short Deccol16 { get; set; }
        [Column("DECCOL_17")]
        public short Deccol17 { get; set; }
        [Column("DECCOL_18")]
        public short Deccol18 { get; set; }
        [Column("DECCOL_19")]
        public short Deccol19 { get; set; }
        [Column("DETACC_0")]
        public byte Detacc0 { get; set; }
        [Column("DETBPR_0")]
        public byte Detbpr0 { get; set; }
        [Column("DETCCE_0")]
        public byte Detcce0 { get; set; }
        [Required]
        [Column("FCYINF_0")]
        [StringLength(10)]
        public string Fcyinf0 { get; set; }
        [Required]
        [Column("ACCINF_0")]
        [StringLength(10)]
        public string Accinf0 { get; set; }
        [Required]
        [Column("BPRINF_0")]
        [StringLength(10)]
        public string Bprinf0 { get; set; }
        [Required]
        [Column("CCEINF_0")]
        [StringLength(10)]
        public string Cceinf0 { get; set; }
        [Column("NEGSTO_0")]
        public byte Negsto0 { get; set; }
        [Column("NBLIG_0")]
        public short Nblig0 { get; set; }
        [Required]
        [Column("ACS_0")]
        [StringLength(10)]
        public string Acs0 { get; set; }
        [Column("NBLIG1_0")]
        public short Nblig10 { get; set; }
        [Required]
        [Column("TL_0")]
        [StringLength(60)]
        public string Tl0 { get; set; }
        [Required]
        [Column("TL_1")]
        [StringLength(60)]
        public string Tl1 { get; set; }
        [Required]
        [Column("TL_2")]
        [StringLength(60)]
        public string Tl2 { get; set; }
        [Required]
        [Column("TC_0")]
        [StringLength(60)]
        public string Tc0 { get; set; }
        [Required]
        [Column("TC_1")]
        [StringLength(60)]
        public string Tc1 { get; set; }
        [Required]
        [Column("TC_2")]
        [StringLength(60)]
        public string Tc2 { get; set; }
        [Required]
        [Column("TR_0")]
        [StringLength(60)]
        public string Tr0 { get; set; }
        [Required]
        [Column("TR_1")]
        [StringLength(60)]
        public string Tr1 { get; set; }
        [Required]
        [Column("TR_2")]
        [StringLength(60)]
        public string Tr2 { get; set; }
        [Column("NBLIG2_0")]
        public short Nblig20 { get; set; }
        [Required]
        [Column("FL_0")]
        [StringLength(60)]
        public string Fl0 { get; set; }
        [Required]
        [Column("FL_1")]
        [StringLength(60)]
        public string Fl1 { get; set; }
        [Required]
        [Column("FL_2")]
        [StringLength(60)]
        public string Fl2 { get; set; }
        [Required]
        [Column("FC_0")]
        [StringLength(60)]
        public string Fc0 { get; set; }
        [Required]
        [Column("FC_1")]
        [StringLength(60)]
        public string Fc1 { get; set; }
        [Required]
        [Column("FC_2")]
        [StringLength(60)]
        public string Fc2 { get; set; }
        [Required]
        [Column("FR_0")]
        [StringLength(60)]
        public string Fr0 { get; set; }
        [Required]
        [Column("FR_1")]
        [StringLength(60)]
        public string Fr1 { get; set; }
        [Required]
        [Column("FR_2")]
        [StringLength(60)]
        public string Fr2 { get; set; }
        [Column("NBVAR_0")]
        public short Nbvar0 { get; set; }
        [Required]
        [Column("RPTCOD_0")]
        [StringLength(15)]
        public string Rptcod0 { get; set; }
        [Required]
        [Column("GRPCOD_0")]
        [StringLength(15)]
        public string Grpcod0 { get; set; }
        [Column("TYPDOC_0")]
        public byte Typdoc0 { get; set; }
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