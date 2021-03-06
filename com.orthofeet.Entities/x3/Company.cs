// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("COMPANY", Schema = "TESTPROD")]
    [Index(nameof(Cpy0), Name = "COMPANY_CPY0", IsUnique = true)]
    [Index(nameof(Leg0), nameof(Cpy0), Name = "COMPANY_CPY1")]
    public partial class Company
    {
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("CPYNAM_0")]
        [StringLength(35)]
        public string Cpynam0 { get; set; }
        [Required]
        [Column("CPYSHO_0")]
        [StringLength(10)]
        public string Cpysho0 { get; set; }
        [Column("CPYLEGFLG_0")]
        public byte Cpylegflg0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Required]
        [Column("ACM_0")]
        [StringLength(3)]
        public string Acm0 { get; set; }
        [Required]
        [Column("MAIFCY_0")]
        [StringLength(5)]
        public string Maifcy0 { get; set; }
        [Required]
        [Column("CRY_0")]
        [StringLength(3)]
        public string Cry0 { get; set; }
        [Required]
        [Column("CRN_0")]
        [StringLength(20)]
        public string Crn0 { get; set; }
        [Required]
        [Column("NAF_0")]
        [StringLength(10)]
        public string Naf0 { get; set; }
        [Required]
        [Column("NID_0")]
        [StringLength(80)]
        public string Nid0 { get; set; }
        [Required]
        [Column("CPYLOG_0")]
        [StringLength(10)]
        public string Cpylog0 { get; set; }
        [Column("RGCAMT_0", TypeName = "numeric(28, 8)")]
        public decimal Rgcamt0 { get; set; }
        [Required]
        [Column("RGCCUR_0")]
        [StringLength(1)]
        public string Rgccur0 { get; set; }
        [Required]
        [Column("BPAADD_0")]
        [StringLength(7)]
        public string Bpaadd0 { get; set; }
        [Required]
        [Column("CNTNAM_0")]
        [StringLength(15)]
        public string Cntnam0 { get; set; }
        [Required]
        [Column("BIDNUM_0")]
        [StringLength(30)]
        public string Bidnum0 { get; set; }
        [Required]
        [Column("ACCCOD_0")]
        [StringLength(10)]
        public string Acccod0 { get; set; }
        [Required]
        [Column("DIVCOD_0")]
        [StringLength(20)]
        public string Divcod0 { get; set; }
        [Required]
        [Column("EECNUM_0")]
        [StringLength(20)]
        public string Eecnum0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
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
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("OBYDIE_0")]
        public byte Obydie0 { get; set; }
        [Column("OBYDIE_1")]
        public byte Obydie1 { get; set; }
        [Column("OBYDIE_2")]
        public byte Obydie2 { get; set; }
        [Column("OBYDIE_3")]
        public byte Obydie3 { get; set; }
        [Column("OBYDIE_4")]
        public byte Obydie4 { get; set; }
        [Column("OBYDIE_5")]
        public byte Obydie5 { get; set; }
        [Column("OBYDIE_6")]
        public byte Obydie6 { get; set; }
        [Column("OBYDIE_7")]
        public byte Obydie7 { get; set; }
        [Column("OBYDIE_8")]
        public byte Obydie8 { get; set; }
        [Column("OBYDIE_9")]
        public byte Obydie9 { get; set; }
        [Column("OBYDIE_10")]
        public byte Obydie10 { get; set; }
        [Column("OBYDIE_11")]
        public byte Obydie11 { get; set; }
        [Column("OBYDIE_12")]
        public byte Obydie12 { get; set; }
        [Column("OBYDIE_13")]
        public byte Obydie13 { get; set; }
        [Column("OBYDIE_14")]
        public byte Obydie14 { get; set; }
        [Column("OBYDIE_15")]
        public byte Obydie15 { get; set; }
        [Column("OBYDIE_16")]
        public byte Obydie16 { get; set; }
        [Column("OBYDIE_17")]
        public byte Obydie17 { get; set; }
        [Column("OBYDIE_18")]
        public byte Obydie18 { get; set; }
        [Column("OBYDIE_19")]
        public byte Obydie19 { get; set; }
        [Column("STRPER_0", TypeName = "datetime")]
        public DateTime Strper0 { get; set; }
        [Required]
        [Column("ACCCUR_0")]
        [StringLength(3)]
        public string Acccur0 { get; set; }
        [Column("DACDIE_0")]
        public byte Dacdie0 { get; set; }
        [Column("DACDIE_1")]
        public byte Dacdie1 { get; set; }
        [Column("DACDIE_2")]
        public byte Dacdie2 { get; set; }
        [Column("DACDIE_3")]
        public byte Dacdie3 { get; set; }
        [Column("DACDIE_4")]
        public byte Dacdie4 { get; set; }
        [Column("DACDIE_5")]
        public byte Dacdie5 { get; set; }
        [Column("DACDIE_6")]
        public byte Dacdie6 { get; set; }
        [Column("DACDIE_7")]
        public byte Dacdie7 { get; set; }
        [Column("DACDIE_8")]
        public byte Dacdie8 { get; set; }
        [Column("DACDIE_9")]
        public byte Dacdie9 { get; set; }
        [Column("DACDIE_10")]
        public byte Dacdie10 { get; set; }
        [Column("DACDIE_11")]
        public byte Dacdie11 { get; set; }
        [Column("DACDIE_12")]
        public byte Dacdie12 { get; set; }
        [Column("DACDIE_13")]
        public byte Dacdie13 { get; set; }
        [Column("DACDIE_14")]
        public byte Dacdie14 { get; set; }
        [Column("DACDIE_15")]
        public byte Dacdie15 { get; set; }
        [Column("DACDIE_16")]
        public byte Dacdie16 { get; set; }
        [Column("DACDIE_17")]
        public byte Dacdie17 { get; set; }
        [Column("DACDIE_18")]
        public byte Dacdie18 { get; set; }
        [Column("DACDIE_19")]
        public byte Dacdie19 { get; set; }
        [Column("NUMADD_0")]
        public short Numadd0 { get; set; }
        [Required]
        [Column("STAFED_0")]
        [StringLength(1)]
        public string Stafed0 { get; set; }
        [Required]
        [Column("GRUCOD_0")]
        [StringLength(1)]
        public string Grucod0 { get; set; }
        [Required]
        [Column("KACT_0")]
        [StringLength(1)]
        public string Kact0 { get; set; }
        [Required]
        [Column("CCE_0")]
        [StringLength(15)]
        public string Cce0 { get; set; }
        [Required]
        [Column("CCE_1")]
        [StringLength(15)]
        public string Cce1 { get; set; }
        [Required]
        [Column("CCE_2")]
        [StringLength(15)]
        public string Cce2 { get; set; }
        [Required]
        [Column("CCE_3")]
        [StringLength(15)]
        public string Cce3 { get; set; }
        [Required]
        [Column("CCE_4")]
        [StringLength(15)]
        public string Cce4 { get; set; }
        [Required]
        [Column("CCE_5")]
        [StringLength(15)]
        public string Cce5 { get; set; }
        [Required]
        [Column("CCE_6")]
        [StringLength(15)]
        public string Cce6 { get; set; }
        [Required]
        [Column("CCE_7")]
        [StringLength(15)]
        public string Cce7 { get; set; }
        [Required]
        [Column("CCE_8")]
        [StringLength(15)]
        public string Cce8 { get; set; }
        [Required]
        [Column("CCE_9")]
        [StringLength(15)]
        public string Cce9 { get; set; }
        [Required]
        [Column("CCE_10")]
        [StringLength(15)]
        public string Cce10 { get; set; }
        [Required]
        [Column("CCE_11")]
        [StringLength(15)]
        public string Cce11 { get; set; }
        [Required]
        [Column("CCE_12")]
        [StringLength(15)]
        public string Cce12 { get; set; }
        [Required]
        [Column("CCE_13")]
        [StringLength(15)]
        public string Cce13 { get; set; }
        [Required]
        [Column("CCE_14")]
        [StringLength(15)]
        public string Cce14 { get; set; }
        [Required]
        [Column("CCE_15")]
        [StringLength(15)]
        public string Cce15 { get; set; }
        [Required]
        [Column("CCE_16")]
        [StringLength(15)]
        public string Cce16 { get; set; }
        [Required]
        [Column("CCE_17")]
        [StringLength(15)]
        public string Cce17 { get; set; }
        [Required]
        [Column("CCE_18")]
        [StringLength(15)]
        public string Cce18 { get; set; }
        [Required]
        [Column("CCE_19")]
        [StringLength(15)]
        public string Cce19 { get; set; }
        [Required]
        [Column("PLISTC_0")]
        [StringLength(10)]
        public string Plistc0 { get; set; }
        [Column("RTZFLG_0")]
        public short Rtzflg0 { get; set; }
        [Column("AGTPCP_0")]
        public short Agtpcp0 { get; set; }
        [Required]
        [Column("VACCPY_0")]
        [StringLength(1)]
        public string Vaccpy0 { get; set; }
        [Column("DCLDIRBALPAY_0")]
        public byte Dcldirbalpay0 { get; set; }
        [Required]
        [Column("BDFECOCOD_0")]
        [StringLength(20)]
        public string Bdfecocod0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}