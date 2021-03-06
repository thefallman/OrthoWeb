// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("OPPOR", Schema = "TESTPROD")]
    [Index(nameof(Oppnum0), Name = "OPPOR_OPP0", IsUnique = true)]
    [Index(nameof(Oppcda0), Name = "OPPOR_OPP1")]
    [Index(nameof(Oppcmgnum0), Name = "OPPOR_OPP2")]
    [Index(nameof(Oppopgnum0), Name = "OPPOR_OPP3")]
    [Index(nameof(Oppcmp0), Name = "OPPOR_OPP4")]
    [Index(nameof(Oppmcn0), Name = "OPPOR_OPP5")]
    [Index(nameof(Opprep0), nameof(Oppcda0), Name = "OPPOR_OPP6")]
    [Index(nameof(Oppori0), nameof(Opporivcr0), nameof(Opporivcrl0), Name = "OPPOR_OPP7")]
    public partial class Oppor
    {
        [Required]
        [Column("OPPNUM_0")]
        [StringLength(20)]
        public string Oppnum0 { get; set; }
        [Required]
        [Column("OPPDES_0")]
        [StringLength(60)]
        public string Oppdes0 { get; set; }
        [Required]
        [Column("OPPTYP_0")]
        [StringLength(20)]
        public string Opptyp0 { get; set; }
        [Required]
        [Column("OPPEXTNUM_0")]
        [StringLength(20)]
        public string Oppextnum0 { get; set; }
        [Required]
        [Column("OPPSRENUM_0")]
        [StringLength(20)]
        public string Oppsrenum0 { get; set; }
        [Column("OPPSTEADI_0")]
        public short Oppsteadi0 { get; set; }
        [Required]
        [Column("OPPSTE_0")]
        [StringLength(20)]
        public string Oppste0 { get; set; }
        [Required]
        [Column("OPPSTEA2_0")]
        [StringLength(10)]
        public string Oppstea20 { get; set; }
        [Column("OPPCLO_0")]
        public byte Oppclo0 { get; set; }
        [Column("STRSTE_0", TypeName = "datetime")]
        public DateTime Strste0 { get; set; }
        [Column("OPPAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Oppamt0 { get; set; }
        [Column("PBYPRJ_0")]
        public int Pbyprj0 { get; set; }
        [Column("PBYPRJAAM_0", TypeName = "numeric(27, 13)")]
        public decimal Pbyprjaam0 { get; set; }
        [Column("OPPSUC_0")]
        public int Oppsuc0 { get; set; }
        [Column("OPPAAM_0", TypeName = "numeric(27, 13)")]
        public decimal Oppaam0 { get; set; }
        [Column("DAM_0", TypeName = "numeric(27, 13)")]
        public decimal Dam0 { get; set; }
        [Column("DAMAVE_0")]
        public byte Damave0 { get; set; }
        [Column("DAMCUM_0")]
        public byte Damcum0 { get; set; }
        [Column("OPPCDA_0", TypeName = "datetime")]
        public DateTime Oppcda0 { get; set; }
        [Column("OPPREACDA_0", TypeName = "datetime")]
        public DateTime Oppreacda0 { get; set; }
        [Required]
        [Column("OPPREP_0")]
        [StringLength(15)]
        public string Opprep0 { get; set; }
        [Column("OPPNBQ_0")]
        public int Oppnbq0 { get; set; }
        [Required]
        [Column("OPPCMP_0")]
        [StringLength(15)]
        public string Oppcmp0 { get; set; }
        [Required]
        [Column("OPPMCN_0")]
        [StringLength(15)]
        public string Oppmcn0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Required]
        [Column("SALFCY_0")]
        [StringLength(5)]
        public string Salfcy0 { get; set; }
        [Required]
        [Column("CPP_0")]
        [StringLength(20)]
        public string Cpp0 { get; set; }
        [Required]
        [Column("CPP_1")]
        [StringLength(20)]
        public string Cpp1 { get; set; }
        [Required]
        [Column("CPP_2")]
        [StringLength(20)]
        public string Cpp2 { get; set; }
        [Required]
        [Column("CPP_3")]
        [StringLength(20)]
        public string Cpp3 { get; set; }
        [Required]
        [Column("CPP_4")]
        [StringLength(20)]
        public string Cpp4 { get; set; }
        [Required]
        [Column("CPP_5")]
        [StringLength(20)]
        public string Cpp5 { get; set; }
        [Required]
        [Column("CPP_6")]
        [StringLength(20)]
        public string Cpp6 { get; set; }
        [Required]
        [Column("CPP_7")]
        [StringLength(20)]
        public string Cpp7 { get; set; }
        [Required]
        [Column("CPP_8")]
        [StringLength(20)]
        public string Cpp8 { get; set; }
        [Required]
        [Column("CPP_9")]
        [StringLength(20)]
        public string Cpp9 { get; set; }
        [Required]
        [Column("CPP_10")]
        [StringLength(20)]
        public string Cpp10 { get; set; }
        [Required]
        [Column("CPP_11")]
        [StringLength(20)]
        public string Cpp11 { get; set; }
        [Required]
        [Column("CPP_12")]
        [StringLength(20)]
        public string Cpp12 { get; set; }
        [Required]
        [Column("CPP_13")]
        [StringLength(20)]
        public string Cpp13 { get; set; }
        [Required]
        [Column("CPP_14")]
        [StringLength(20)]
        public string Cpp14 { get; set; }
        [Column("CPPAMT_0", TypeName = "numeric(27, 13)")]
        public decimal Cppamt0 { get; set; }
        [Column("CPPAMT_1", TypeName = "numeric(27, 13)")]
        public decimal Cppamt1 { get; set; }
        [Column("CPPAMT_2", TypeName = "numeric(27, 13)")]
        public decimal Cppamt2 { get; set; }
        [Column("CPPAMT_3", TypeName = "numeric(27, 13)")]
        public decimal Cppamt3 { get; set; }
        [Column("CPPAMT_4", TypeName = "numeric(27, 13)")]
        public decimal Cppamt4 { get; set; }
        [Column("CPPAMT_5", TypeName = "numeric(27, 13)")]
        public decimal Cppamt5 { get; set; }
        [Column("CPPAMT_6", TypeName = "numeric(27, 13)")]
        public decimal Cppamt6 { get; set; }
        [Column("CPPAMT_7", TypeName = "numeric(27, 13)")]
        public decimal Cppamt7 { get; set; }
        [Column("CPPAMT_8", TypeName = "numeric(27, 13)")]
        public decimal Cppamt8 { get; set; }
        [Column("CPPAMT_9", TypeName = "numeric(27, 13)")]
        public decimal Cppamt9 { get; set; }
        [Column("CPPAMT_10", TypeName = "numeric(27, 13)")]
        public decimal Cppamt10 { get; set; }
        [Column("CPPAMT_11", TypeName = "numeric(27, 13)")]
        public decimal Cppamt11 { get; set; }
        [Column("CPPAMT_12", TypeName = "numeric(27, 13)")]
        public decimal Cppamt12 { get; set; }
        [Column("CPPAMT_13", TypeName = "numeric(27, 13)")]
        public decimal Cppamt13 { get; set; }
        [Column("CPPAMT_14", TypeName = "numeric(27, 13)")]
        public decimal Cppamt14 { get; set; }
        [Required]
        [Column("ASE_0")]
        [StringLength(60)]
        public string Ase0 { get; set; }
        [Required]
        [Column("ASE_1")]
        [StringLength(60)]
        public string Ase1 { get; set; }
        [Required]
        [Column("ASE_2")]
        [StringLength(60)]
        public string Ase2 { get; set; }
        [Required]
        [Column("ASE_3")]
        [StringLength(60)]
        public string Ase3 { get; set; }
        [Required]
        [Column("ASE_4")]
        [StringLength(60)]
        public string Ase4 { get; set; }
        [Required]
        [Column("ASE_5")]
        [StringLength(60)]
        public string Ase5 { get; set; }
        [Required]
        [Column("ASE_6")]
        [StringLength(60)]
        public string Ase6 { get; set; }
        [Required]
        [Column("ASE_7")]
        [StringLength(60)]
        public string Ase7 { get; set; }
        [Required]
        [Column("ASE_8")]
        [StringLength(60)]
        public string Ase8 { get; set; }
        [Required]
        [Column("ASE_9")]
        [StringLength(60)]
        public string Ase9 { get; set; }
        [Required]
        [Column("ASE_10")]
        [StringLength(60)]
        public string Ase10 { get; set; }
        [Required]
        [Column("ASE_11")]
        [StringLength(60)]
        public string Ase11 { get; set; }
        [Required]
        [Column("ASE_12")]
        [StringLength(60)]
        public string Ase12 { get; set; }
        [Required]
        [Column("ASE_13")]
        [StringLength(60)]
        public string Ase13 { get; set; }
        [Required]
        [Column("ASE_14")]
        [StringLength(60)]
        public string Ase14 { get; set; }
        [Required]
        [Column("SHC_0")]
        [StringLength(60)]
        public string Shc0 { get; set; }
        [Required]
        [Column("SHC_1")]
        [StringLength(60)]
        public string Shc1 { get; set; }
        [Required]
        [Column("SHC_2")]
        [StringLength(60)]
        public string Shc2 { get; set; }
        [Required]
        [Column("SHC_3")]
        [StringLength(60)]
        public string Shc3 { get; set; }
        [Required]
        [Column("SHC_4")]
        [StringLength(60)]
        public string Shc4 { get; set; }
        [Required]
        [Column("SHC_5")]
        [StringLength(60)]
        public string Shc5 { get; set; }
        [Required]
        [Column("SHC_6")]
        [StringLength(60)]
        public string Shc6 { get; set; }
        [Required]
        [Column("SHC_7")]
        [StringLength(60)]
        public string Shc7 { get; set; }
        [Required]
        [Column("SHC_8")]
        [StringLength(60)]
        public string Shc8 { get; set; }
        [Required]
        [Column("SHC_9")]
        [StringLength(60)]
        public string Shc9 { get; set; }
        [Required]
        [Column("SHC_10")]
        [StringLength(60)]
        public string Shc10 { get; set; }
        [Required]
        [Column("SHC_11")]
        [StringLength(60)]
        public string Shc11 { get; set; }
        [Required]
        [Column("SHC_12")]
        [StringLength(60)]
        public string Shc12 { get; set; }
        [Required]
        [Column("SHC_13")]
        [StringLength(60)]
        public string Shc13 { get; set; }
        [Required]
        [Column("SHC_14")]
        [StringLength(60)]
        public string Shc14 { get; set; }
        [Required]
        [Column("STE_0")]
        [StringLength(20)]
        public string Ste0 { get; set; }
        [Required]
        [Column("STE_1")]
        [StringLength(20)]
        public string Ste1 { get; set; }
        [Required]
        [Column("STE_2")]
        [StringLength(20)]
        public string Ste2 { get; set; }
        [Required]
        [Column("STE_3")]
        [StringLength(20)]
        public string Ste3 { get; set; }
        [Required]
        [Column("STE_4")]
        [StringLength(20)]
        public string Ste4 { get; set; }
        [Required]
        [Column("STE_5")]
        [StringLength(20)]
        public string Ste5 { get; set; }
        [Required]
        [Column("STE_6")]
        [StringLength(20)]
        public string Ste6 { get; set; }
        [Required]
        [Column("STE_7")]
        [StringLength(20)]
        public string Ste7 { get; set; }
        [Required]
        [Column("STE_8")]
        [StringLength(20)]
        public string Ste8 { get; set; }
        [Required]
        [Column("STE_9")]
        [StringLength(20)]
        public string Ste9 { get; set; }
        [Required]
        [Column("STE_10")]
        [StringLength(20)]
        public string Ste10 { get; set; }
        [Required]
        [Column("STE_11")]
        [StringLength(20)]
        public string Ste11 { get; set; }
        [Required]
        [Column("STE_12")]
        [StringLength(20)]
        public string Ste12 { get; set; }
        [Required]
        [Column("STE_13")]
        [StringLength(20)]
        public string Ste13 { get; set; }
        [Required]
        [Column("STE_14")]
        [StringLength(20)]
        public string Ste14 { get; set; }
        [Column("DON_0")]
        public byte Don0 { get; set; }
        [Column("DON_1")]
        public byte Don1 { get; set; }
        [Column("DON_2")]
        public byte Don2 { get; set; }
        [Column("DON_3")]
        public byte Don3 { get; set; }
        [Column("DON_4")]
        public byte Don4 { get; set; }
        [Column("DON_5")]
        public byte Don5 { get; set; }
        [Column("DON_6")]
        public byte Don6 { get; set; }
        [Column("DON_7")]
        public byte Don7 { get; set; }
        [Column("DON_8")]
        public byte Don8 { get; set; }
        [Column("DON_9")]
        public byte Don9 { get; set; }
        [Column("DON_10")]
        public byte Don10 { get; set; }
        [Column("DON_11")]
        public byte Don11 { get; set; }
        [Column("DON_12")]
        public byte Don12 { get; set; }
        [Column("DON_13")]
        public byte Don13 { get; set; }
        [Column("DON_14")]
        public byte Don14 { get; set; }
        [Column("ENDDAT_0", TypeName = "datetime")]
        public DateTime Enddat0 { get; set; }
        [Column("ENDDAT_1", TypeName = "datetime")]
        public DateTime Enddat1 { get; set; }
        [Column("ENDDAT_2", TypeName = "datetime")]
        public DateTime Enddat2 { get; set; }
        [Column("ENDDAT_3", TypeName = "datetime")]
        public DateTime Enddat3 { get; set; }
        [Column("ENDDAT_4", TypeName = "datetime")]
        public DateTime Enddat4 { get; set; }
        [Column("ENDDAT_5", TypeName = "datetime")]
        public DateTime Enddat5 { get; set; }
        [Column("ENDDAT_6", TypeName = "datetime")]
        public DateTime Enddat6 { get; set; }
        [Column("ENDDAT_7", TypeName = "datetime")]
        public DateTime Enddat7 { get; set; }
        [Column("ENDDAT_8", TypeName = "datetime")]
        public DateTime Enddat8 { get; set; }
        [Column("ENDDAT_9", TypeName = "datetime")]
        public DateTime Enddat9 { get; set; }
        [Column("ENDDAT_10", TypeName = "datetime")]
        public DateTime Enddat10 { get; set; }
        [Column("ENDDAT_11", TypeName = "datetime")]
        public DateTime Enddat11 { get; set; }
        [Column("ENDDAT_12", TypeName = "datetime")]
        public DateTime Enddat12 { get; set; }
        [Column("ENDDAT_13", TypeName = "datetime")]
        public DateTime Enddat13 { get; set; }
        [Column("ENDDAT_14", TypeName = "datetime")]
        public DateTime Enddat14 { get; set; }
        [Required]
        [Column("REN_0")]
        [StringLength(30)]
        public string Ren0 { get; set; }
        [Required]
        [Column("REN_1")]
        [StringLength(30)]
        public string Ren1 { get; set; }
        [Required]
        [Column("REN_2")]
        [StringLength(30)]
        public string Ren2 { get; set; }
        [Required]
        [Column("REN_3")]
        [StringLength(30)]
        public string Ren3 { get; set; }
        [Required]
        [Column("REN_4")]
        [StringLength(30)]
        public string Ren4 { get; set; }
        [Required]
        [Column("REN_5")]
        [StringLength(30)]
        public string Ren5 { get; set; }
        [Required]
        [Column("REN_6")]
        [StringLength(30)]
        public string Ren6 { get; set; }
        [Required]
        [Column("REN_7")]
        [StringLength(30)]
        public string Ren7 { get; set; }
        [Required]
        [Column("REN_8")]
        [StringLength(30)]
        public string Ren8 { get; set; }
        [Required]
        [Column("REN_9")]
        [StringLength(30)]
        public string Ren9 { get; set; }
        [Required]
        [Column("REN_10")]
        [StringLength(30)]
        public string Ren10 { get; set; }
        [Required]
        [Column("REN_11")]
        [StringLength(30)]
        public string Ren11 { get; set; }
        [Required]
        [Column("REN_12")]
        [StringLength(30)]
        public string Ren12 { get; set; }
        [Required]
        [Column("REN_13")]
        [StringLength(30)]
        public string Ren13 { get; set; }
        [Required]
        [Column("REN_14")]
        [StringLength(30)]
        public string Ren14 { get; set; }
        [Required]
        [Column("STEX_0")]
        [StringLength(20)]
        public string Stex0 { get; set; }
        [Required]
        [Column("STEX_1")]
        [StringLength(20)]
        public string Stex1 { get; set; }
        [Required]
        [Column("STEX_2")]
        [StringLength(20)]
        public string Stex2 { get; set; }
        [Required]
        [Column("STEX_3")]
        [StringLength(20)]
        public string Stex3 { get; set; }
        [Required]
        [Column("STEX_4")]
        [StringLength(20)]
        public string Stex4 { get; set; }
        [Required]
        [Column("STEX_5")]
        [StringLength(20)]
        public string Stex5 { get; set; }
        [Required]
        [Column("STEX_6")]
        [StringLength(20)]
        public string Stex6 { get; set; }
        [Required]
        [Column("STEX_7")]
        [StringLength(20)]
        public string Stex7 { get; set; }
        [Required]
        [Column("STEX_8")]
        [StringLength(20)]
        public string Stex8 { get; set; }
        [Required]
        [Column("STEX_9")]
        [StringLength(20)]
        public string Stex9 { get; set; }
        [Required]
        [Column("STEX_10")]
        [StringLength(20)]
        public string Stex10 { get; set; }
        [Required]
        [Column("STEX_11")]
        [StringLength(20)]
        public string Stex11 { get; set; }
        [Required]
        [Column("STEX_12")]
        [StringLength(20)]
        public string Stex12 { get; set; }
        [Required]
        [Column("STEX_13")]
        [StringLength(20)]
        public string Stex13 { get; set; }
        [Required]
        [Column("STEX_14")]
        [StringLength(20)]
        public string Stex14 { get; set; }
        [Column("DONX_0")]
        public byte Donx0 { get; set; }
        [Column("DONX_1")]
        public byte Donx1 { get; set; }
        [Column("DONX_2")]
        public byte Donx2 { get; set; }
        [Column("DONX_3")]
        public byte Donx3 { get; set; }
        [Column("DONX_4")]
        public byte Donx4 { get; set; }
        [Column("DONX_5")]
        public byte Donx5 { get; set; }
        [Column("DONX_6")]
        public byte Donx6 { get; set; }
        [Column("DONX_7")]
        public byte Donx7 { get; set; }
        [Column("DONX_8")]
        public byte Donx8 { get; set; }
        [Column("DONX_9")]
        public byte Donx9 { get; set; }
        [Column("DONX_10")]
        public byte Donx10 { get; set; }
        [Column("DONX_11")]
        public byte Donx11 { get; set; }
        [Column("DONX_12")]
        public byte Donx12 { get; set; }
        [Column("DONX_13")]
        public byte Donx13 { get; set; }
        [Column("DONX_14")]
        public byte Donx14 { get; set; }
        [Column("ENDDATX_0", TypeName = "datetime")]
        public DateTime Enddatx0 { get; set; }
        [Column("ENDDATX_1", TypeName = "datetime")]
        public DateTime Enddatx1 { get; set; }
        [Column("ENDDATX_2", TypeName = "datetime")]
        public DateTime Enddatx2 { get; set; }
        [Column("ENDDATX_3", TypeName = "datetime")]
        public DateTime Enddatx3 { get; set; }
        [Column("ENDDATX_4", TypeName = "datetime")]
        public DateTime Enddatx4 { get; set; }
        [Column("ENDDATX_5", TypeName = "datetime")]
        public DateTime Enddatx5 { get; set; }
        [Column("ENDDATX_6", TypeName = "datetime")]
        public DateTime Enddatx6 { get; set; }
        [Column("ENDDATX_7", TypeName = "datetime")]
        public DateTime Enddatx7 { get; set; }
        [Column("ENDDATX_8", TypeName = "datetime")]
        public DateTime Enddatx8 { get; set; }
        [Column("ENDDATX_9", TypeName = "datetime")]
        public DateTime Enddatx9 { get; set; }
        [Column("ENDDATX_10", TypeName = "datetime")]
        public DateTime Enddatx10 { get; set; }
        [Column("ENDDATX_11", TypeName = "datetime")]
        public DateTime Enddatx11 { get; set; }
        [Column("ENDDATX_12", TypeName = "datetime")]
        public DateTime Enddatx12 { get; set; }
        [Column("ENDDATX_13", TypeName = "datetime")]
        public DateTime Enddatx13 { get; set; }
        [Column("ENDDATX_14", TypeName = "datetime")]
        public DateTime Enddatx14 { get; set; }
        [Required]
        [Column("RENX_0")]
        [StringLength(30)]
        public string Renx0 { get; set; }
        [Required]
        [Column("RENX_1")]
        [StringLength(30)]
        public string Renx1 { get; set; }
        [Required]
        [Column("RENX_2")]
        [StringLength(30)]
        public string Renx2 { get; set; }
        [Required]
        [Column("RENX_3")]
        [StringLength(30)]
        public string Renx3 { get; set; }
        [Required]
        [Column("RENX_4")]
        [StringLength(30)]
        public string Renx4 { get; set; }
        [Required]
        [Column("RENX_5")]
        [StringLength(30)]
        public string Renx5 { get; set; }
        [Required]
        [Column("RENX_6")]
        [StringLength(30)]
        public string Renx6 { get; set; }
        [Required]
        [Column("RENX_7")]
        [StringLength(30)]
        public string Renx7 { get; set; }
        [Required]
        [Column("RENX_8")]
        [StringLength(30)]
        public string Renx8 { get; set; }
        [Required]
        [Column("RENX_9")]
        [StringLength(30)]
        public string Renx9 { get; set; }
        [Required]
        [Column("RENX_10")]
        [StringLength(30)]
        public string Renx10 { get; set; }
        [Required]
        [Column("RENX_11")]
        [StringLength(30)]
        public string Renx11 { get; set; }
        [Required]
        [Column("RENX_12")]
        [StringLength(30)]
        public string Renx12 { get; set; }
        [Required]
        [Column("RENX_13")]
        [StringLength(30)]
        public string Renx13 { get; set; }
        [Required]
        [Column("RENX_14")]
        [StringLength(30)]
        public string Renx14 { get; set; }
        [Required]
        [Column("SBBPJT_0")]
        [StringLength(20)]
        public string Sbbpjt0 { get; set; }
        [Required]
        [Column("SBBPJT_1")]
        [StringLength(20)]
        public string Sbbpjt1 { get; set; }
        [Required]
        [Column("SBBPJT_2")]
        [StringLength(20)]
        public string Sbbpjt2 { get; set; }
        [Required]
        [Column("SBBPJT_3")]
        [StringLength(20)]
        public string Sbbpjt3 { get; set; }
        [Required]
        [Column("SBBPJT_4")]
        [StringLength(20)]
        public string Sbbpjt4 { get; set; }
        [Required]
        [Column("SBBPJT_5")]
        [StringLength(20)]
        public string Sbbpjt5 { get; set; }
        [Required]
        [Column("SBBPJT_6")]
        [StringLength(20)]
        public string Sbbpjt6 { get; set; }
        [Required]
        [Column("SBBPJT_7")]
        [StringLength(20)]
        public string Sbbpjt7 { get; set; }
        [Required]
        [Column("SBBPJT_8")]
        [StringLength(20)]
        public string Sbbpjt8 { get; set; }
        [Required]
        [Column("SBBPJT_9")]
        [StringLength(20)]
        public string Sbbpjt9 { get; set; }
        [Required]
        [Column("SBBPJT_10")]
        [StringLength(20)]
        public string Sbbpjt10 { get; set; }
        [Required]
        [Column("SBBPJT_11")]
        [StringLength(20)]
        public string Sbbpjt11 { get; set; }
        [Required]
        [Column("SBBPJT_12")]
        [StringLength(20)]
        public string Sbbpjt12 { get; set; }
        [Required]
        [Column("SBBPJT_13")]
        [StringLength(20)]
        public string Sbbpjt13 { get; set; }
        [Required]
        [Column("SBBPJT_14")]
        [StringLength(20)]
        public string Sbbpjt14 { get; set; }
        [Required]
        [Column("OPPCMGNUM_0")]
        [StringLength(20)]
        public string Oppcmgnum0 { get; set; }
        [Required]
        [Column("OPPOPGNUM_0")]
        [StringLength(20)]
        public string Oppopgnum0 { get; set; }
        [Required]
        [Column("OPPOPGTYP_0")]
        [StringLength(3)]
        public string Oppopgtyp0 { get; set; }
        [Column("OPPORI_0")]
        public byte Oppori0 { get; set; }
        [Required]
        [Column("OPPORIVCR_0")]
        [StringLength(20)]
        public string Opporivcr0 { get; set; }
        [Column("OPPORIVCRL_0")]
        public int Opporivcrl0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREHOU_0")]
        [StringLength(5)]
        public string Crehou0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Column("OPPORITYP_0")]
        public byte Opporityp0 { get; set; }
        [Column("OPPDATOPN_0", TypeName = "datetime")]
        public DateTime Oppdatopn0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}