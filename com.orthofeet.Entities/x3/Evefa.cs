﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("EVEFAS", Schema = "TESTPROD")]
    [Index(nameof(Cpy0), nameof(Evt0), nameof(Pln0), nameof(Fcy0), nameof(Acccod0), nameof(Ref0), nameof(Timstp0), nameof(Creusr0), nameof(Cptflg0), nameof(Evtdat0), Name = "EVEFAS_EFS0", IsUnique = true)]
    [Index(nameof(Cpy0), nameof(Evt0), nameof(Pln0), nameof(Ref0), nameof(Timstpo0), nameof(Creusro0), Name = "EVEFAS_EFS1")]
    [Index(nameof(Cptflg0), nameof(Evtdat0), nameof(Cpy0), nameof(Evt0), nameof(Pln0), nameof(Ref0), Name = "EVEFAS_EFS2")]
    [Index(nameof(Ref0), Name = "EVEFAS_EFS4")]
    public partial class Evefa
    {
        [Column("REFOBJ_0")]
        public byte Refobj0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("ACCCOD_0")]
        [StringLength(10)]
        public string Acccod0 { get; set; }
        [Required]
        [Column("REF_0")]
        [StringLength(20)]
        public string Ref0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(60)]
        public string Des0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Required]
        [Column("TIMSTP_0")]
        [StringLength(20)]
        public string Timstp0 { get; set; }
        [Column("CREORI_0")]
        public byte Creori0 { get; set; }
        [Required]
        [Column("EVT_0")]
        [StringLength(20)]
        public string Evt0 { get; set; }
        [Column("PLN_0")]
        public byte Pln0 { get; set; }
        [Required]
        [Column("EVTINT_0")]
        [StringLength(10)]
        public string Evtint0 { get; set; }
        [Column("EVTDAT_0", TypeName = "datetime")]
        public DateTime Evtdat0 { get; set; }
        [Column("CPTFLG_0")]
        public byte Cptflg0 { get; set; }
        [Column("CPTDATINT_0", TypeName = "datetime")]
        public DateTime Cptdatint0 { get; set; }
        [Column("SNSEVE_0")]
        public byte Snseve0 { get; set; }
        [Required]
        [Column("CREUSRO_0")]
        [StringLength(5)]
        public string Creusro0 { get; set; }
        [Required]
        [Column("TIMSTPO_0")]
        [StringLength(20)]
        public string Timstpo0 { get; set; }
        [Column("CPTDATINTO_0", TypeName = "datetime")]
        public DateTime Cptdatinto0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Required]
        [Column("FLDNAMA_0")]
        [StringLength(10)]
        public string Fldnama0 { get; set; }
        [Required]
        [Column("FLDNAMA_1")]
        [StringLength(10)]
        public string Fldnama1 { get; set; }
        [Required]
        [Column("FLDNAMA_2")]
        [StringLength(10)]
        public string Fldnama2 { get; set; }
        [Required]
        [Column("FLDNAMA_3")]
        [StringLength(10)]
        public string Fldnama3 { get; set; }
        [Required]
        [Column("FLDNAMA_4")]
        [StringLength(10)]
        public string Fldnama4 { get; set; }
        [Required]
        [Column("FLDNAMA_5")]
        [StringLength(10)]
        public string Fldnama5 { get; set; }
        [Required]
        [Column("FLDNAMA_6")]
        [StringLength(10)]
        public string Fldnama6 { get; set; }
        [Required]
        [Column("FLDNAMA_7")]
        [StringLength(10)]
        public string Fldnama7 { get; set; }
        [Required]
        [Column("FLDNAMA_8")]
        [StringLength(10)]
        public string Fldnama8 { get; set; }
        [Required]
        [Column("FLDNAMA_9")]
        [StringLength(10)]
        public string Fldnama9 { get; set; }
        [Required]
        [Column("FLDNAMA_10")]
        [StringLength(10)]
        public string Fldnama10 { get; set; }
        [Required]
        [Column("FLDNAMA_11")]
        [StringLength(10)]
        public string Fldnama11 { get; set; }
        [Required]
        [Column("FLDNAMA_12")]
        [StringLength(10)]
        public string Fldnama12 { get; set; }
        [Required]
        [Column("FLDNAMA_13")]
        [StringLength(10)]
        public string Fldnama13 { get; set; }
        [Required]
        [Column("FLDNAMA_14")]
        [StringLength(10)]
        public string Fldnama14 { get; set; }
        [Required]
        [Column("FLDNAMA_15")]
        [StringLength(10)]
        public string Fldnama15 { get; set; }
        [Required]
        [Column("FLDNAMA_16")]
        [StringLength(10)]
        public string Fldnama16 { get; set; }
        [Required]
        [Column("FLDNAMA_17")]
        [StringLength(10)]
        public string Fldnama17 { get; set; }
        [Required]
        [Column("FLDNAMA_18")]
        [StringLength(10)]
        public string Fldnama18 { get; set; }
        [Required]
        [Column("FLDNAMA_19")]
        [StringLength(10)]
        public string Fldnama19 { get; set; }
        [Required]
        [Column("FLDNAMA_20")]
        [StringLength(10)]
        public string Fldnama20 { get; set; }
        [Required]
        [Column("FLDNAMA_21")]
        [StringLength(10)]
        public string Fldnama21 { get; set; }
        [Required]
        [Column("FLDNAMA_22")]
        [StringLength(10)]
        public string Fldnama22 { get; set; }
        [Required]
        [Column("FLDNAMA_23")]
        [StringLength(10)]
        public string Fldnama23 { get; set; }
        [Required]
        [Column("FLDNAMA_24")]
        [StringLength(10)]
        public string Fldnama24 { get; set; }
        [Required]
        [Column("FLDNAMA_25")]
        [StringLength(10)]
        public string Fldnama25 { get; set; }
        [Required]
        [Column("FLDNAMA_26")]
        [StringLength(10)]
        public string Fldnama26 { get; set; }
        [Required]
        [Column("FLDNAMA_27")]
        [StringLength(10)]
        public string Fldnama27 { get; set; }
        [Required]
        [Column("FLDNAMA_28")]
        [StringLength(10)]
        public string Fldnama28 { get; set; }
        [Required]
        [Column("FLDNAMA_29")]
        [StringLength(10)]
        public string Fldnama29 { get; set; }
        [Required]
        [Column("FLDNAMA_30")]
        [StringLength(10)]
        public string Fldnama30 { get; set; }
        [Required]
        [Column("FLDNAMA_31")]
        [StringLength(10)]
        public string Fldnama31 { get; set; }
        [Required]
        [Column("FLDNAMA_32")]
        [StringLength(10)]
        public string Fldnama32 { get; set; }
        [Required]
        [Column("FLDNAMA_33")]
        [StringLength(10)]
        public string Fldnama33 { get; set; }
        [Required]
        [Column("FLDNAMA_34")]
        [StringLength(10)]
        public string Fldnama34 { get; set; }
        [Required]
        [Column("FLDNAMA_35")]
        [StringLength(10)]
        public string Fldnama35 { get; set; }
        [Required]
        [Column("FLDNAMA_36")]
        [StringLength(10)]
        public string Fldnama36 { get; set; }
        [Required]
        [Column("FLDNAMA_37")]
        [StringLength(10)]
        public string Fldnama37 { get; set; }
        [Required]
        [Column("FLDNAMA_38")]
        [StringLength(10)]
        public string Fldnama38 { get; set; }
        [Required]
        [Column("FLDNAMA_39")]
        [StringLength(10)]
        public string Fldnama39 { get; set; }
        [Required]
        [Column("FLDFILAO_0")]
        [StringLength(20)]
        public string Fldfilao0 { get; set; }
        [Required]
        [Column("FLDFILAO_1")]
        [StringLength(20)]
        public string Fldfilao1 { get; set; }
        [Required]
        [Column("FLDFILAO_2")]
        [StringLength(20)]
        public string Fldfilao2 { get; set; }
        [Required]
        [Column("FLDFILAO_3")]
        [StringLength(20)]
        public string Fldfilao3 { get; set; }
        [Required]
        [Column("FLDFILAO_4")]
        [StringLength(20)]
        public string Fldfilao4 { get; set; }
        [Required]
        [Column("FLDFILAO_5")]
        [StringLength(20)]
        public string Fldfilao5 { get; set; }
        [Required]
        [Column("FLDFILAO_6")]
        [StringLength(20)]
        public string Fldfilao6 { get; set; }
        [Required]
        [Column("FLDFILAO_7")]
        [StringLength(20)]
        public string Fldfilao7 { get; set; }
        [Required]
        [Column("FLDFILAO_8")]
        [StringLength(20)]
        public string Fldfilao8 { get; set; }
        [Required]
        [Column("FLDFILAO_9")]
        [StringLength(20)]
        public string Fldfilao9 { get; set; }
        [Required]
        [Column("FLDFILAO_10")]
        [StringLength(20)]
        public string Fldfilao10 { get; set; }
        [Required]
        [Column("FLDFILAO_11")]
        [StringLength(20)]
        public string Fldfilao11 { get; set; }
        [Required]
        [Column("FLDFILAO_12")]
        [StringLength(20)]
        public string Fldfilao12 { get; set; }
        [Required]
        [Column("FLDFILAO_13")]
        [StringLength(20)]
        public string Fldfilao13 { get; set; }
        [Required]
        [Column("FLDFILAO_14")]
        [StringLength(20)]
        public string Fldfilao14 { get; set; }
        [Required]
        [Column("FLDFILAO_15")]
        [StringLength(20)]
        public string Fldfilao15 { get; set; }
        [Required]
        [Column("FLDFILAO_16")]
        [StringLength(20)]
        public string Fldfilao16 { get; set; }
        [Required]
        [Column("FLDFILAO_17")]
        [StringLength(20)]
        public string Fldfilao17 { get; set; }
        [Required]
        [Column("FLDFILAO_18")]
        [StringLength(20)]
        public string Fldfilao18 { get; set; }
        [Required]
        [Column("FLDFILAO_19")]
        [StringLength(20)]
        public string Fldfilao19 { get; set; }
        [Required]
        [Column("FLDFILAO_20")]
        [StringLength(20)]
        public string Fldfilao20 { get; set; }
        [Required]
        [Column("FLDFILAO_21")]
        [StringLength(20)]
        public string Fldfilao21 { get; set; }
        [Required]
        [Column("FLDFILAO_22")]
        [StringLength(20)]
        public string Fldfilao22 { get; set; }
        [Required]
        [Column("FLDFILAO_23")]
        [StringLength(20)]
        public string Fldfilao23 { get; set; }
        [Required]
        [Column("FLDFILAO_24")]
        [StringLength(20)]
        public string Fldfilao24 { get; set; }
        [Required]
        [Column("FLDFILAO_25")]
        [StringLength(20)]
        public string Fldfilao25 { get; set; }
        [Required]
        [Column("FLDFILAO_26")]
        [StringLength(20)]
        public string Fldfilao26 { get; set; }
        [Required]
        [Column("FLDFILAO_27")]
        [StringLength(20)]
        public string Fldfilao27 { get; set; }
        [Required]
        [Column("FLDFILAO_28")]
        [StringLength(20)]
        public string Fldfilao28 { get; set; }
        [Required]
        [Column("FLDFILAO_29")]
        [StringLength(20)]
        public string Fldfilao29 { get; set; }
        [Required]
        [Column("FLDFILAO_30")]
        [StringLength(20)]
        public string Fldfilao30 { get; set; }
        [Required]
        [Column("FLDFILAO_31")]
        [StringLength(20)]
        public string Fldfilao31 { get; set; }
        [Required]
        [Column("FLDFILAO_32")]
        [StringLength(20)]
        public string Fldfilao32 { get; set; }
        [Required]
        [Column("FLDFILAO_33")]
        [StringLength(20)]
        public string Fldfilao33 { get; set; }
        [Required]
        [Column("FLDFILAO_34")]
        [StringLength(20)]
        public string Fldfilao34 { get; set; }
        [Required]
        [Column("FLDFILAO_35")]
        [StringLength(20)]
        public string Fldfilao35 { get; set; }
        [Required]
        [Column("FLDFILAO_36")]
        [StringLength(20)]
        public string Fldfilao36 { get; set; }
        [Required]
        [Column("FLDFILAO_37")]
        [StringLength(20)]
        public string Fldfilao37 { get; set; }
        [Required]
        [Column("FLDFILAO_38")]
        [StringLength(20)]
        public string Fldfilao38 { get; set; }
        [Required]
        [Column("FLDFILAO_39")]
        [StringLength(20)]
        public string Fldfilao39 { get; set; }
        [Required]
        [Column("FLDFILAD_0")]
        [StringLength(20)]
        public string Fldfilad0 { get; set; }
        [Required]
        [Column("FLDFILAD_1")]
        [StringLength(20)]
        public string Fldfilad1 { get; set; }
        [Required]
        [Column("FLDFILAD_2")]
        [StringLength(20)]
        public string Fldfilad2 { get; set; }
        [Required]
        [Column("FLDFILAD_3")]
        [StringLength(20)]
        public string Fldfilad3 { get; set; }
        [Required]
        [Column("FLDFILAD_4")]
        [StringLength(20)]
        public string Fldfilad4 { get; set; }
        [Required]
        [Column("FLDFILAD_5")]
        [StringLength(20)]
        public string Fldfilad5 { get; set; }
        [Required]
        [Column("FLDFILAD_6")]
        [StringLength(20)]
        public string Fldfilad6 { get; set; }
        [Required]
        [Column("FLDFILAD_7")]
        [StringLength(20)]
        public string Fldfilad7 { get; set; }
        [Required]
        [Column("FLDFILAD_8")]
        [StringLength(20)]
        public string Fldfilad8 { get; set; }
        [Required]
        [Column("FLDFILAD_9")]
        [StringLength(20)]
        public string Fldfilad9 { get; set; }
        [Required]
        [Column("FLDFILAD_10")]
        [StringLength(20)]
        public string Fldfilad10 { get; set; }
        [Required]
        [Column("FLDFILAD_11")]
        [StringLength(20)]
        public string Fldfilad11 { get; set; }
        [Required]
        [Column("FLDFILAD_12")]
        [StringLength(20)]
        public string Fldfilad12 { get; set; }
        [Required]
        [Column("FLDFILAD_13")]
        [StringLength(20)]
        public string Fldfilad13 { get; set; }
        [Required]
        [Column("FLDFILAD_14")]
        [StringLength(20)]
        public string Fldfilad14 { get; set; }
        [Required]
        [Column("FLDFILAD_15")]
        [StringLength(20)]
        public string Fldfilad15 { get; set; }
        [Required]
        [Column("FLDFILAD_16")]
        [StringLength(20)]
        public string Fldfilad16 { get; set; }
        [Required]
        [Column("FLDFILAD_17")]
        [StringLength(20)]
        public string Fldfilad17 { get; set; }
        [Required]
        [Column("FLDFILAD_18")]
        [StringLength(20)]
        public string Fldfilad18 { get; set; }
        [Required]
        [Column("FLDFILAD_19")]
        [StringLength(20)]
        public string Fldfilad19 { get; set; }
        [Required]
        [Column("FLDFILAD_20")]
        [StringLength(20)]
        public string Fldfilad20 { get; set; }
        [Required]
        [Column("FLDFILAD_21")]
        [StringLength(20)]
        public string Fldfilad21 { get; set; }
        [Required]
        [Column("FLDFILAD_22")]
        [StringLength(20)]
        public string Fldfilad22 { get; set; }
        [Required]
        [Column("FLDFILAD_23")]
        [StringLength(20)]
        public string Fldfilad23 { get; set; }
        [Required]
        [Column("FLDFILAD_24")]
        [StringLength(20)]
        public string Fldfilad24 { get; set; }
        [Required]
        [Column("FLDFILAD_25")]
        [StringLength(20)]
        public string Fldfilad25 { get; set; }
        [Required]
        [Column("FLDFILAD_26")]
        [StringLength(20)]
        public string Fldfilad26 { get; set; }
        [Required]
        [Column("FLDFILAD_27")]
        [StringLength(20)]
        public string Fldfilad27 { get; set; }
        [Required]
        [Column("FLDFILAD_28")]
        [StringLength(20)]
        public string Fldfilad28 { get; set; }
        [Required]
        [Column("FLDFILAD_29")]
        [StringLength(20)]
        public string Fldfilad29 { get; set; }
        [Required]
        [Column("FLDFILAD_30")]
        [StringLength(20)]
        public string Fldfilad30 { get; set; }
        [Required]
        [Column("FLDFILAD_31")]
        [StringLength(20)]
        public string Fldfilad31 { get; set; }
        [Required]
        [Column("FLDFILAD_32")]
        [StringLength(20)]
        public string Fldfilad32 { get; set; }
        [Required]
        [Column("FLDFILAD_33")]
        [StringLength(20)]
        public string Fldfilad33 { get; set; }
        [Required]
        [Column("FLDFILAD_34")]
        [StringLength(20)]
        public string Fldfilad34 { get; set; }
        [Required]
        [Column("FLDFILAD_35")]
        [StringLength(20)]
        public string Fldfilad35 { get; set; }
        [Required]
        [Column("FLDFILAD_36")]
        [StringLength(20)]
        public string Fldfilad36 { get; set; }
        [Required]
        [Column("FLDFILAD_37")]
        [StringLength(20)]
        public string Fldfilad37 { get; set; }
        [Required]
        [Column("FLDFILAD_38")]
        [StringLength(20)]
        public string Fldfilad38 { get; set; }
        [Required]
        [Column("FLDFILAD_39")]
        [StringLength(20)]
        public string Fldfilad39 { get; set; }
        [Required]
        [Column("FLDNAMN_0")]
        [StringLength(10)]
        public string Fldnamn0 { get; set; }
        [Required]
        [Column("FLDNAMN_1")]
        [StringLength(10)]
        public string Fldnamn1 { get; set; }
        [Required]
        [Column("FLDNAMN_2")]
        [StringLength(10)]
        public string Fldnamn2 { get; set; }
        [Required]
        [Column("FLDNAMN_3")]
        [StringLength(10)]
        public string Fldnamn3 { get; set; }
        [Required]
        [Column("FLDNAMN_4")]
        [StringLength(10)]
        public string Fldnamn4 { get; set; }
        [Required]
        [Column("FLDNAMN_5")]
        [StringLength(10)]
        public string Fldnamn5 { get; set; }
        [Required]
        [Column("FLDNAMN_6")]
        [StringLength(10)]
        public string Fldnamn6 { get; set; }
        [Required]
        [Column("FLDNAMN_7")]
        [StringLength(10)]
        public string Fldnamn7 { get; set; }
        [Required]
        [Column("FLDNAMN_8")]
        [StringLength(10)]
        public string Fldnamn8 { get; set; }
        [Required]
        [Column("FLDNAMN_9")]
        [StringLength(10)]
        public string Fldnamn9 { get; set; }
        [Required]
        [Column("FLDNAMN_10")]
        [StringLength(10)]
        public string Fldnamn10 { get; set; }
        [Required]
        [Column("FLDNAMN_11")]
        [StringLength(10)]
        public string Fldnamn11 { get; set; }
        [Required]
        [Column("FLDNAMN_12")]
        [StringLength(10)]
        public string Fldnamn12 { get; set; }
        [Required]
        [Column("FLDNAMN_13")]
        [StringLength(10)]
        public string Fldnamn13 { get; set; }
        [Required]
        [Column("FLDNAMN_14")]
        [StringLength(10)]
        public string Fldnamn14 { get; set; }
        [Required]
        [Column("FLDNAMN_15")]
        [StringLength(10)]
        public string Fldnamn15 { get; set; }
        [Required]
        [Column("FLDNAMN_16")]
        [StringLength(10)]
        public string Fldnamn16 { get; set; }
        [Required]
        [Column("FLDNAMN_17")]
        [StringLength(10)]
        public string Fldnamn17 { get; set; }
        [Required]
        [Column("FLDNAMN_18")]
        [StringLength(10)]
        public string Fldnamn18 { get; set; }
        [Required]
        [Column("FLDNAMN_19")]
        [StringLength(10)]
        public string Fldnamn19 { get; set; }
        [Required]
        [Column("FLDNAMN_20")]
        [StringLength(10)]
        public string Fldnamn20 { get; set; }
        [Required]
        [Column("FLDNAMN_21")]
        [StringLength(10)]
        public string Fldnamn21 { get; set; }
        [Required]
        [Column("FLDNAMN_22")]
        [StringLength(10)]
        public string Fldnamn22 { get; set; }
        [Required]
        [Column("FLDNAMN_23")]
        [StringLength(10)]
        public string Fldnamn23 { get; set; }
        [Required]
        [Column("FLDNAMN_24")]
        [StringLength(10)]
        public string Fldnamn24 { get; set; }
        [Required]
        [Column("FLDNAMN_25")]
        [StringLength(10)]
        public string Fldnamn25 { get; set; }
        [Required]
        [Column("FLDNAMN_26")]
        [StringLength(10)]
        public string Fldnamn26 { get; set; }
        [Required]
        [Column("FLDNAMN_27")]
        [StringLength(10)]
        public string Fldnamn27 { get; set; }
        [Required]
        [Column("FLDNAMN_28")]
        [StringLength(10)]
        public string Fldnamn28 { get; set; }
        [Required]
        [Column("FLDNAMN_29")]
        [StringLength(10)]
        public string Fldnamn29 { get; set; }
        [Required]
        [Column("FLDNAMN_30")]
        [StringLength(10)]
        public string Fldnamn30 { get; set; }
        [Required]
        [Column("FLDNAMN_31")]
        [StringLength(10)]
        public string Fldnamn31 { get; set; }
        [Required]
        [Column("FLDNAMN_32")]
        [StringLength(10)]
        public string Fldnamn32 { get; set; }
        [Required]
        [Column("FLDNAMN_33")]
        [StringLength(10)]
        public string Fldnamn33 { get; set; }
        [Required]
        [Column("FLDNAMN_34")]
        [StringLength(10)]
        public string Fldnamn34 { get; set; }
        [Required]
        [Column("FLDNAMN_35")]
        [StringLength(10)]
        public string Fldnamn35 { get; set; }
        [Required]
        [Column("FLDNAMN_36")]
        [StringLength(10)]
        public string Fldnamn36 { get; set; }
        [Required]
        [Column("FLDNAMN_37")]
        [StringLength(10)]
        public string Fldnamn37 { get; set; }
        [Required]
        [Column("FLDNAMN_38")]
        [StringLength(10)]
        public string Fldnamn38 { get; set; }
        [Required]
        [Column("FLDNAMN_39")]
        [StringLength(10)]
        public string Fldnamn39 { get; set; }
        [Column("FLDFILN_0", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln0 { get; set; }
        [Column("FLDFILN_1", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln1 { get; set; }
        [Column("FLDFILN_2", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln2 { get; set; }
        [Column("FLDFILN_3", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln3 { get; set; }
        [Column("FLDFILN_4", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln4 { get; set; }
        [Column("FLDFILN_5", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln5 { get; set; }
        [Column("FLDFILN_6", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln6 { get; set; }
        [Column("FLDFILN_7", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln7 { get; set; }
        [Column("FLDFILN_8", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln8 { get; set; }
        [Column("FLDFILN_9", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln9 { get; set; }
        [Column("FLDFILN_10", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln10 { get; set; }
        [Column("FLDFILN_11", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln11 { get; set; }
        [Column("FLDFILN_12", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln12 { get; set; }
        [Column("FLDFILN_13", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln13 { get; set; }
        [Column("FLDFILN_14", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln14 { get; set; }
        [Column("FLDFILN_15", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln15 { get; set; }
        [Column("FLDFILN_16", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln16 { get; set; }
        [Column("FLDFILN_17", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln17 { get; set; }
        [Column("FLDFILN_18", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln18 { get; set; }
        [Column("FLDFILN_19", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln19 { get; set; }
        [Column("FLDFILN_20", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln20 { get; set; }
        [Column("FLDFILN_21", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln21 { get; set; }
        [Column("FLDFILN_22", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln22 { get; set; }
        [Column("FLDFILN_23", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln23 { get; set; }
        [Column("FLDFILN_24", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln24 { get; set; }
        [Column("FLDFILN_25", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln25 { get; set; }
        [Column("FLDFILN_26", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln26 { get; set; }
        [Column("FLDFILN_27", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln27 { get; set; }
        [Column("FLDFILN_28", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln28 { get; set; }
        [Column("FLDFILN_29", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln29 { get; set; }
        [Column("FLDFILN_30", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln30 { get; set; }
        [Column("FLDFILN_31", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln31 { get; set; }
        [Column("FLDFILN_32", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln32 { get; set; }
        [Column("FLDFILN_33", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln33 { get; set; }
        [Column("FLDFILN_34", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln34 { get; set; }
        [Column("FLDFILN_35", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln35 { get; set; }
        [Column("FLDFILN_36", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln36 { get; set; }
        [Column("FLDFILN_37", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln37 { get; set; }
        [Column("FLDFILN_38", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln38 { get; set; }
        [Column("FLDFILN_39", TypeName = "numeric(28, 7)")]
        public decimal Fldfiln39 { get; set; }
        [Required]
        [Column("FLDNAMM_0")]
        [StringLength(10)]
        public string Fldnamm0 { get; set; }
        [Required]
        [Column("FLDNAMM_1")]
        [StringLength(10)]
        public string Fldnamm1 { get; set; }
        [Required]
        [Column("FLDNAMM_2")]
        [StringLength(10)]
        public string Fldnamm2 { get; set; }
        [Required]
        [Column("FLDNAMM_3")]
        [StringLength(10)]
        public string Fldnamm3 { get; set; }
        [Required]
        [Column("FLDNAMM_4")]
        [StringLength(10)]
        public string Fldnamm4 { get; set; }
        [Required]
        [Column("FLDNAMM_5")]
        [StringLength(10)]
        public string Fldnamm5 { get; set; }
        [Required]
        [Column("FLDNAMM_6")]
        [StringLength(10)]
        public string Fldnamm6 { get; set; }
        [Required]
        [Column("FLDNAMM_7")]
        [StringLength(10)]
        public string Fldnamm7 { get; set; }
        [Required]
        [Column("FLDNAMM_8")]
        [StringLength(10)]
        public string Fldnamm8 { get; set; }
        [Required]
        [Column("FLDNAMM_9")]
        [StringLength(10)]
        public string Fldnamm9 { get; set; }
        [Column("FLDFILMO_0")]
        public short Fldfilmo0 { get; set; }
        [Column("FLDFILMO_1")]
        public short Fldfilmo1 { get; set; }
        [Column("FLDFILMO_2")]
        public short Fldfilmo2 { get; set; }
        [Column("FLDFILMO_3")]
        public short Fldfilmo3 { get; set; }
        [Column("FLDFILMO_4")]
        public short Fldfilmo4 { get; set; }
        [Column("FLDFILMO_5")]
        public short Fldfilmo5 { get; set; }
        [Column("FLDFILMO_6")]
        public short Fldfilmo6 { get; set; }
        [Column("FLDFILMO_7")]
        public short Fldfilmo7 { get; set; }
        [Column("FLDFILMO_8")]
        public short Fldfilmo8 { get; set; }
        [Column("FLDFILMO_9")]
        public short Fldfilmo9 { get; set; }
        [Column("FLDFILMD_0")]
        public short Fldfilmd0 { get; set; }
        [Column("FLDFILMD_1")]
        public short Fldfilmd1 { get; set; }
        [Column("FLDFILMD_2")]
        public short Fldfilmd2 { get; set; }
        [Column("FLDFILMD_3")]
        public short Fldfilmd3 { get; set; }
        [Column("FLDFILMD_4")]
        public short Fldfilmd4 { get; set; }
        [Column("FLDFILMD_5")]
        public short Fldfilmd5 { get; set; }
        [Column("FLDFILMD_6")]
        public short Fldfilmd6 { get; set; }
        [Column("FLDFILMD_7")]
        public short Fldfilmd7 { get; set; }
        [Column("FLDFILMD_8")]
        public short Fldfilmd8 { get; set; }
        [Column("FLDFILMD_9")]
        public short Fldfilmd9 { get; set; }
        [Required]
        [Column("FLDNAMD_0")]
        [StringLength(10)]
        public string Fldnamd0 { get; set; }
        [Required]
        [Column("FLDNAMD_1")]
        [StringLength(10)]
        public string Fldnamd1 { get; set; }
        [Required]
        [Column("FLDNAMD_2")]
        [StringLength(10)]
        public string Fldnamd2 { get; set; }
        [Required]
        [Column("FLDNAMD_3")]
        [StringLength(10)]
        public string Fldnamd3 { get; set; }
        [Required]
        [Column("FLDNAMD_4")]
        [StringLength(10)]
        public string Fldnamd4 { get; set; }
        [Required]
        [Column("FLDNAMD_5")]
        [StringLength(10)]
        public string Fldnamd5 { get; set; }
        [Required]
        [Column("FLDNAMD_6")]
        [StringLength(10)]
        public string Fldnamd6 { get; set; }
        [Required]
        [Column("FLDNAMD_7")]
        [StringLength(10)]
        public string Fldnamd7 { get; set; }
        [Required]
        [Column("FLDNAMD_8")]
        [StringLength(10)]
        public string Fldnamd8 { get; set; }
        [Required]
        [Column("FLDNAMD_9")]
        [StringLength(10)]
        public string Fldnamd9 { get; set; }
        [Column("FLDFILD_0", TypeName = "datetime")]
        public DateTime Fldfild0 { get; set; }
        [Column("FLDFILD_1", TypeName = "datetime")]
        public DateTime Fldfild1 { get; set; }
        [Column("FLDFILD_2", TypeName = "datetime")]
        public DateTime Fldfild2 { get; set; }
        [Column("FLDFILD_3", TypeName = "datetime")]
        public DateTime Fldfild3 { get; set; }
        [Column("FLDFILD_4", TypeName = "datetime")]
        public DateTime Fldfild4 { get; set; }
        [Column("FLDFILD_5", TypeName = "datetime")]
        public DateTime Fldfild5 { get; set; }
        [Column("FLDFILD_6", TypeName = "datetime")]
        public DateTime Fldfild6 { get; set; }
        [Column("FLDFILD_7", TypeName = "datetime")]
        public DateTime Fldfild7 { get; set; }
        [Column("FLDFILD_8", TypeName = "datetime")]
        public DateTime Fldfild8 { get; set; }
        [Column("FLDFILD_9", TypeName = "datetime")]
        public DateTime Fldfild9 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}