// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BILSTA", Schema = "TESTPROD")]
    [Index(nameof(Frmnum0), nameof(Lin0), Name = "BILSTA_BES0", IsUnique = true)]
    [Index(nameof(Paynum0), nameof(Frmnum0), nameof(Lin0), Name = "BILSTA_BES1", IsUnique = true)]
    public partial class Bilsta
    {
        [Required]
        [Column("FRMNUM_0")]
        [StringLength(20)]
        public string Frmnum0 { get; set; }
        [Column("LIN_0")]
        public int Lin0 { get; set; }
        [Required]
        [Column("PAYNUM_0")]
        [StringLength(20)]
        public string Paynum0 { get; set; }
        [Required]
        [Column("BAN_0")]
        [StringLength(5)]
        public string Ban0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("AMTCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Amtcur0 { get; set; }
        [Column("PAYDAT_0", TypeName = "datetime")]
        public DateTime Paydat0 { get; set; }
        [Required]
        [Column("NUM_0")]
        [StringLength(8)]
        public string Num0 { get; set; }
        [Column("VALDAT_0", TypeName = "datetime")]
        public DateTime Valdat0 { get; set; }
        [Column("INSDAT_0", TypeName = "datetime")]
        public DateTime Insdat0 { get; set; }
        [Required]
        [Column("ADELEA_0")]
        [StringLength(5)]
        public string Adelea0 { get; set; }
        [Required]
        [Column("PABFCY_0")]
        [StringLength(5)]
        public string Pabfcy0 { get; set; }
        [Required]
        [Column("PABCOT_0")]
        [StringLength(5)]
        public string Pabcot0 { get; set; }
        [Required]
        [Column("DEBACC_0")]
        [StringLength(11)]
        public string Debacc0 { get; set; }
        [Required]
        [Column("NAMDEB_0")]
        [StringLength(24)]
        public string Namdeb0 { get; set; }
        [Required]
        [Column("INDCUR_0")]
        [StringLength(1)]
        public string Indcur0 { get; set; }
        [Column("AMT_0", TypeName = "numeric(27, 13)")]
        public decimal Amt0 { get; set; }
        [Required]
        [Column("PROCEN_0")]
        [StringLength(6)]
        public string Procen0 { get; set; }
        [Required]
        [Column("SENLEA_0")]
        [StringLength(5)]
        public string Senlea0 { get; set; }
        [Required]
        [Column("SENFCY_0")]
        [StringLength(5)]
        public string Senfcy0 { get; set; }
        [Required]
        [Column("SENCOT_0")]
        [StringLength(5)]
        public string Sencot0 { get; set; }
        [Required]
        [Column("CDTACC_0")]
        [StringLength(11)]
        public string Cdtacc0 { get; set; }
        [Required]
        [Column("NAMCDT_0")]
        [StringLength(24)]
        public string Namcdt0 { get; set; }
        [Column("DUDDAT_0", TypeName = "datetime")]
        public DateTime Duddat0 { get; set; }
        [Column("ACP_0")]
        public short Acp0 { get; set; }
        [Required]
        [Column("REFDEB_0")]
        [StringLength(10)]
        public string Refdeb0 { get; set; }
        [Required]
        [Column("REFCDT_0")]
        [StringLength(10)]
        public string Refcdt0 { get; set; }
        [Required]
        [Column("REFPRE_0")]
        [StringLength(8)]
        public string Refpre0 { get; set; }
        [Required]
        [Column("PABNAM_0")]
        [StringLength(24)]
        public string Pabnam0 { get; set; }
        [Column("ENTDAT_0", TypeName = "datetime")]
        public DateTime Entdat0 { get; set; }
        [Required]
        [Column("PABORD_0")]
        [StringLength(8)]
        public string Pabord0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("PABFLG_0")]
        public byte Pabflg0 { get; set; }
        [Required]
        [Column("PABREN_0")]
        [StringLength(20)]
        public string Pabren0 { get; set; }
        [Column("PABAMTPRT_0", TypeName = "numeric(27, 13)")]
        public decimal Pabamtprt0 { get; set; }
        [Column("FLGANO_0")]
        public byte Flgano0 { get; set; }
        [Column("FLGEXP_0")]
        public byte Flgexp0 { get; set; }
        [Required]
        [Column("IMPFIL_0")]
        [StringLength(20)]
        public string Impfil0 { get; set; }
        [Column("IMPDAT_0", TypeName = "datetime")]
        public DateTime Impdat0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}