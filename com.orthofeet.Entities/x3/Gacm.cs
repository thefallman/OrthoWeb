// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GACM", Schema = "TESTPROD")]
    [Index(nameof(Gcm0), Name = "GACM_GCM0", IsUnique = true)]
    public partial class Gacm
    {
        [Required]
        [Column("GCM_0")]
        [StringLength(3)]
        public string Gcm0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Required]
        [Column("DESSHO_0")]
        [StringLength(10)]
        public string Dessho0 { get; set; }
        [Required]
        [Column("LEG_0")]
        [StringLength(20)]
        public string Leg0 { get; set; }
        [Required]
        [Column("LED_0")]
        [StringLength(3)]
        public string Led0 { get; set; }
        [Required]
        [Column("LED_1")]
        [StringLength(3)]
        public string Led1 { get; set; }
        [Required]
        [Column("LED_2")]
        [StringLength(3)]
        public string Led2 { get; set; }
        [Required]
        [Column("LED_3")]
        [StringLength(3)]
        public string Led3 { get; set; }
        [Required]
        [Column("LED_4")]
        [StringLength(3)]
        public string Led4 { get; set; }
        [Required]
        [Column("LED_5")]
        [StringLength(3)]
        public string Led5 { get; set; }
        [Required]
        [Column("LED_6")]
        [StringLength(3)]
        public string Led6 { get; set; }
        [Required]
        [Column("LED_7")]
        [StringLength(3)]
        public string Led7 { get; set; }
        [Required]
        [Column("LED_8")]
        [StringLength(3)]
        public string Led8 { get; set; }
        [Required]
        [Column("LED_9")]
        [StringLength(3)]
        public string Led9 { get; set; }
        [Column("CFMAUT_0")]
        public byte Cfmaut0 { get; set; }
        [Column("CFMAUT_1")]
        public byte Cfmaut1 { get; set; }
        [Column("CFMAUT_2")]
        public byte Cfmaut2 { get; set; }
        [Column("CFMAUT_3")]
        public byte Cfmaut3 { get; set; }
        [Column("CFMAUT_4")]
        public byte Cfmaut4 { get; set; }
        [Column("CFMAUT_5")]
        public byte Cfmaut5 { get; set; }
        [Column("CFMAUT_6")]
        public byte Cfmaut6 { get; set; }
        [Column("CFMAUT_7")]
        public byte Cfmaut7 { get; set; }
        [Column("CFMAUT_8")]
        public byte Cfmaut8 { get; set; }
        [Column("CFMAUT_9")]
        public byte Cfmaut9 { get; set; }
        [Column("ORILEDTYP_0")]
        public byte Oriledtyp0 { get; set; }
        [Column("ORILEDTYP_1")]
        public byte Oriledtyp1 { get; set; }
        [Column("ORILEDTYP_2")]
        public byte Oriledtyp2 { get; set; }
        [Column("ORILEDTYP_3")]
        public byte Oriledtyp3 { get; set; }
        [Column("ORILEDTYP_4")]
        public byte Oriledtyp4 { get; set; }
        [Column("ORILEDTYP_5")]
        public byte Oriledtyp5 { get; set; }
        [Column("ORILEDTYP_6")]
        public byte Oriledtyp6 { get; set; }
        [Column("ORILEDTYP_7")]
        public byte Oriledtyp7 { get; set; }
        [Column("ORILEDTYP_8")]
        public byte Oriledtyp8 { get; set; }
        [Column("ORILEDTYP_9")]
        public byte Oriledtyp9 { get; set; }
        [Column("DOELED_0")]
        public byte Doeled0 { get; set; }
        [Column("DOELED_1")]
        public byte Doeled1 { get; set; }
        [Column("DOELED_2")]
        public byte Doeled2 { get; set; }
        [Column("DOELED_3")]
        public byte Doeled3 { get; set; }
        [Column("DOELED_4")]
        public byte Doeled4 { get; set; }
        [Column("DOELED_5")]
        public byte Doeled5 { get; set; }
        [Column("DOELED_6")]
        public byte Doeled6 { get; set; }
        [Column("DOELED_7")]
        public byte Doeled7 { get; set; }
        [Column("DOELED_8")]
        public byte Doeled8 { get; set; }
        [Column("DOELED_9")]
        public byte Doeled9 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Required]
        [Column("CUR_1")]
        [StringLength(3)]
        public string Cur1 { get; set; }
        [Required]
        [Column("CUR_2")]
        [StringLength(3)]
        public string Cur2 { get; set; }
        [Required]
        [Column("CUR_3")]
        [StringLength(3)]
        public string Cur3 { get; set; }
        [Required]
        [Column("CUR_4")]
        [StringLength(3)]
        public string Cur4 { get; set; }
        [Required]
        [Column("CUR_5")]
        [StringLength(3)]
        public string Cur5 { get; set; }
        [Required]
        [Column("CUR_6")]
        [StringLength(3)]
        public string Cur6 { get; set; }
        [Required]
        [Column("CUR_7")]
        [StringLength(3)]
        public string Cur7 { get; set; }
        [Required]
        [Column("CUR_8")]
        [StringLength(3)]
        public string Cur8 { get; set; }
        [Required]
        [Column("CUR_9")]
        [StringLength(3)]
        public string Cur9 { get; set; }
        [Column("DACRAT_0")]
        public byte Dacrat0 { get; set; }
        [Column("DACRAT_1")]
        public byte Dacrat1 { get; set; }
        [Column("DACRAT_2")]
        public byte Dacrat2 { get; set; }
        [Column("DACRAT_3")]
        public byte Dacrat3 { get; set; }
        [Column("DACRAT_4")]
        public byte Dacrat4 { get; set; }
        [Column("DACRAT_5")]
        public byte Dacrat5 { get; set; }
        [Column("DACRAT_6")]
        public byte Dacrat6 { get; set; }
        [Column("DACRAT_7")]
        public byte Dacrat7 { get; set; }
        [Column("DACRAT_8")]
        public byte Dacrat8 { get; set; }
        [Column("DACRAT_9")]
        public byte Dacrat9 { get; set; }
        [Column("FLGVCRRAT_0")]
        public byte Flgvcrrat0 { get; set; }
        [Column("FLGVCRRAT_1")]
        public byte Flgvcrrat1 { get; set; }
        [Column("FLGVCRRAT_2")]
        public byte Flgvcrrat2 { get; set; }
        [Column("FLGVCRRAT_3")]
        public byte Flgvcrrat3 { get; set; }
        [Column("FLGVCRRAT_4")]
        public byte Flgvcrrat4 { get; set; }
        [Column("FLGVCRRAT_5")]
        public byte Flgvcrrat5 { get; set; }
        [Column("FLGVCRRAT_6")]
        public byte Flgvcrrat6 { get; set; }
        [Column("FLGVCRRAT_7")]
        public byte Flgvcrrat7 { get; set; }
        [Column("FLGVCRRAT_8")]
        public byte Flgvcrrat8 { get; set; }
        [Column("FLGVCRRAT_9")]
        public byte Flgvcrrat9 { get; set; }
        [Column("TYPRAT_0")]
        public byte Typrat0 { get; set; }
        [Column("TYPRAT_1")]
        public byte Typrat1 { get; set; }
        [Column("TYPRAT_2")]
        public byte Typrat2 { get; set; }
        [Column("TYPRAT_3")]
        public byte Typrat3 { get; set; }
        [Column("TYPRAT_4")]
        public byte Typrat4 { get; set; }
        [Column("TYPRAT_5")]
        public byte Typrat5 { get; set; }
        [Column("TYPRAT_6")]
        public byte Typrat6 { get; set; }
        [Column("TYPRAT_7")]
        public byte Typrat7 { get; set; }
        [Column("TYPRAT_8")]
        public byte Typrat8 { get; set; }
        [Column("TYPRAT_9")]
        public byte Typrat9 { get; set; }
        [Column("RNDOPTBAL_0")]
        public byte Rndoptbal0 { get; set; }
        [Column("RNDOPTBAL_1")]
        public byte Rndoptbal1 { get; set; }
        [Column("RNDOPTBAL_2")]
        public byte Rndoptbal2 { get; set; }
        [Column("RNDOPTBAL_3")]
        public byte Rndoptbal3 { get; set; }
        [Column("RNDOPTBAL_4")]
        public byte Rndoptbal4 { get; set; }
        [Column("RNDOPTBAL_5")]
        public byte Rndoptbal5 { get; set; }
        [Column("RNDOPTBAL_6")]
        public byte Rndoptbal6 { get; set; }
        [Column("RNDOPTBAL_7")]
        public byte Rndoptbal7 { get; set; }
        [Column("RNDOPTBAL_8")]
        public byte Rndoptbal8 { get; set; }
        [Column("RNDOPTBAL_9")]
        public byte Rndoptbal9 { get; set; }
        [Column("GENLEDTYP_0")]
        public byte Genledtyp0 { get; set; }
        [Column("ANALEDTYP_0")]
        public byte Analedtyp0 { get; set; }
        [Column("FLGIAS_0")]
        public short Flgias0 { get; set; }
        [Column("IASLEDTYP_0")]
        public short Iasledtyp0 { get; set; }
        [Column("NBRCTL_0")]
        public short Nbrctl0 { get; set; }
        [Required]
        [Column("LED1_0")]
        [StringLength(3)]
        public string Led10 { get; set; }
        [Required]
        [Column("LED1_1")]
        [StringLength(3)]
        public string Led11 { get; set; }
        [Required]
        [Column("LED1_2")]
        [StringLength(3)]
        public string Led12 { get; set; }
        [Required]
        [Column("LED1_3")]
        [StringLength(3)]
        public string Led13 { get; set; }
        [Required]
        [Column("LED1_4")]
        [StringLength(3)]
        public string Led14 { get; set; }
        [Required]
        [Column("LED1_5")]
        [StringLength(3)]
        public string Led15 { get; set; }
        [Required]
        [Column("LED1_6")]
        [StringLength(3)]
        public string Led16 { get; set; }
        [Required]
        [Column("LED1_7")]
        [StringLength(3)]
        public string Led17 { get; set; }
        [Required]
        [Column("LED1_8")]
        [StringLength(3)]
        public string Led18 { get; set; }
        [Required]
        [Column("LED1_9")]
        [StringLength(3)]
        public string Led19 { get; set; }
        [Required]
        [Column("LED2_0")]
        [StringLength(3)]
        public string Led20 { get; set; }
        [Required]
        [Column("LED2_1")]
        [StringLength(3)]
        public string Led21 { get; set; }
        [Required]
        [Column("LED2_2")]
        [StringLength(3)]
        public string Led22 { get; set; }
        [Required]
        [Column("LED2_3")]
        [StringLength(3)]
        public string Led23 { get; set; }
        [Required]
        [Column("LED2_4")]
        [StringLength(3)]
        public string Led24 { get; set; }
        [Required]
        [Column("LED2_5")]
        [StringLength(3)]
        public string Led25 { get; set; }
        [Required]
        [Column("LED2_6")]
        [StringLength(3)]
        public string Led26 { get; set; }
        [Required]
        [Column("LED2_7")]
        [StringLength(3)]
        public string Led27 { get; set; }
        [Required]
        [Column("LED2_8")]
        [StringLength(3)]
        public string Led28 { get; set; }
        [Required]
        [Column("LED2_9")]
        [StringLength(3)]
        public string Led29 { get; set; }
        [Required]
        [Column("CTLTYP_0")]
        [StringLength(5)]
        public string Ctltyp0 { get; set; }
        [Required]
        [Column("CTLTYP_1")]
        [StringLength(5)]
        public string Ctltyp1 { get; set; }
        [Required]
        [Column("CTLTYP_2")]
        [StringLength(5)]
        public string Ctltyp2 { get; set; }
        [Required]
        [Column("CTLTYP_3")]
        [StringLength(5)]
        public string Ctltyp3 { get; set; }
        [Required]
        [Column("CTLTYP_4")]
        [StringLength(5)]
        public string Ctltyp4 { get; set; }
        [Required]
        [Column("CTLTYP_5")]
        [StringLength(5)]
        public string Ctltyp5 { get; set; }
        [Required]
        [Column("CTLTYP_6")]
        [StringLength(5)]
        public string Ctltyp6 { get; set; }
        [Required]
        [Column("CTLTYP_7")]
        [StringLength(5)]
        public string Ctltyp7 { get; set; }
        [Required]
        [Column("CTLTYP_8")]
        [StringLength(5)]
        public string Ctltyp8 { get; set; }
        [Required]
        [Column("CTLTYP_9")]
        [StringLength(5)]
        public string Ctltyp9 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
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
        [Column("EXPNUM_0")]
        public int Expnum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}