// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("MATCHTOL", Schema = "TESTPROD")]
    [Index(nameof(Mattol0), Name = "MATCHTOL_MAT0", IsUnique = true)]
    public partial class Matchtol
    {
        [Required]
        [Column("MATTOL_0")]
        [StringLength(5)]
        public string Mattol0 { get; set; }
        [Required]
        [Column("TOLDES_0")]
        [StringLength(30)]
        public string Toldes0 { get; set; }
        [Required]
        [Column("TOLUOM_0")]
        [StringLength(3)]
        public string Toluom0 { get; set; }
        [Required]
        [Column("TOLCUR_0")]
        [StringLength(3)]
        public string Tolcur0 { get; set; }
        [Column("QSCTL_0")]
        public byte Qsctl0 { get; set; }
        [Column("QSPER_0", TypeName = "numeric(8, 3)")]
        public decimal Qsper0 { get; set; }
        [Column("QSQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Qsqty0 { get; set; }
        [Column("QSACT_0")]
        public byte Qsact0 { get; set; }
        [Column("QECTL_0")]
        public byte Qectl0 { get; set; }
        [Column("QEPER_0", TypeName = "numeric(8, 3)")]
        public decimal Qeper0 { get; set; }
        [Column("QEQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Qeqty0 { get; set; }
        [Column("QEACT_0")]
        public byte Qeact0 { get; set; }
        [Column("IQSCTL_0")]
        public byte Iqsctl0 { get; set; }
        [Column("IQSCTLP_0")]
        public byte Iqsctlp0 { get; set; }
        [Column("IQSCTLQ_0")]
        public byte Iqsctlq0 { get; set; }
        [Column("IQSPER_0", TypeName = "numeric(8, 3)")]
        public decimal Iqsper0 { get; set; }
        [Column("IQSQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Iqsqty0 { get; set; }
        [Column("IQSACT_0")]
        public byte Iqsact0 { get; set; }
        [Column("IQECTL_0")]
        public byte Iqectl0 { get; set; }
        [Column("IQECTLP_0")]
        public byte Iqectlp0 { get; set; }
        [Column("IQECTLQ_0")]
        public byte Iqectlq0 { get; set; }
        [Column("IQEPER_0", TypeName = "numeric(8, 3)")]
        public decimal Iqeper0 { get; set; }
        [Column("IQEQTY_0", TypeName = "numeric(28, 13)")]
        public decimal Iqeqty0 { get; set; }
        [Column("IQEACT_0")]
        public byte Iqeact0 { get; set; }
        [Column("ERCTL_0")]
        public byte Erctl0 { get; set; }
        [Column("ERDAYS_0")]
        public short Erdays0 { get; set; }
        [Column("ERACT_0")]
        public byte Eract0 { get; set; }
        [Column("LRCTL_0")]
        public byte Lrctl0 { get; set; }
        [Column("LRDAYS_0")]
        public short Lrdays0 { get; set; }
        [Column("LRACT_0")]
        public byte Lract0 { get; set; }
        [Column("UIUCTL_0")]
        public byte Uiuctl0 { get; set; }
        [Column("UIUPER_0", TypeName = "numeric(8, 3)")]
        public decimal Uiuper0 { get; set; }
        [Column("UIUAMT_0", TypeName = "numeric(19, 5)")]
        public decimal Uiuamt0 { get; set; }
        [Column("UIUACT_0")]
        public byte Uiuact0 { get; set; }
        [Column("OIUCTL_0")]
        public byte Oiuctl0 { get; set; }
        [Column("OIUPER_0", TypeName = "numeric(8, 3)")]
        public decimal Oiuper0 { get; set; }
        [Column("OIUAMT_0", TypeName = "numeric(19, 5)")]
        public decimal Oiuamt0 { get; set; }
        [Column("OIUACT_0")]
        public byte Oiuact0 { get; set; }
        [Column("UILCTL_0")]
        public byte Uilctl0 { get; set; }
        [Column("UILPER_0", TypeName = "numeric(8, 3)")]
        public decimal Uilper0 { get; set; }
        [Column("UILAMT_0", TypeName = "numeric(19, 5)")]
        public decimal Uilamt0 { get; set; }
        [Column("UILACT_0")]
        public byte Uilact0 { get; set; }
        [Column("OILCTL_0")]
        public byte Oilctl0 { get; set; }
        [Column("OILPER_0", TypeName = "numeric(8, 3)")]
        public decimal Oilper0 { get; set; }
        [Column("OILAMT_0", TypeName = "numeric(19, 5)")]
        public decimal Oilamt0 { get; set; }
        [Column("OILACT_0")]
        public byte Oilact0 { get; set; }
        [Column("QSCTLP_0")]
        public byte Qsctlp0 { get; set; }
        [Column("QSCTLQ_0")]
        public byte Qsctlq0 { get; set; }
        [Column("QECTLP_0")]
        public byte Qectlp0 { get; set; }
        [Column("QECTLQ_0")]
        public byte Qectlq0 { get; set; }
        [Column("UIUCTLP_0")]
        public byte Uiuctlp0 { get; set; }
        [Column("UIUCTLA_0")]
        public byte Uiuctla0 { get; set; }
        [Column("OIUCTLP_0")]
        public byte Oiuctlp0 { get; set; }
        [Column("OIUCTLA_0")]
        public byte Oiuctla0 { get; set; }
        [Column("UILCTLP_0")]
        public byte Uilctlp0 { get; set; }
        [Column("UILCTLA_0")]
        public byte Uilctla0 { get; set; }
        [Column("OILCTLP_0")]
        public byte Oilctlp0 { get; set; }
        [Column("OILCTLA_0")]
        public byte Oilctla0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}