// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("BPSUPPMVT", Schema = "TESTPROD")]
    [Index(nameof(Bpsrsk0), nameof(Cpy0), nameof(Bpsnum0), nameof(Cur0), Name = "BPSUPPMVT_MVS0", IsUnique = true)]
    [Index(nameof(Bpsnum0), nameof(Cpy0), Name = "BPSUPPMVT_MVS1")]
    public partial class Bpsuppmvt
    {
        [Required]
        [Column("BPSNUM_0")]
        [StringLength(15)]
        public string Bpsnum0 { get; set; }
        [Required]
        [Column("ACCCUR_0")]
        [StringLength(3)]
        public string Acccur0 { get; set; }
        [Required]
        [Column("BPSRSK_0")]
        [StringLength(15)]
        public string Bpsrsk0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("ORDNOTC_0", TypeName = "numeric(27, 13)")]
        public decimal Ordnotc0 { get; set; }
        [Column("ORDATIC_0", TypeName = "numeric(27, 13)")]
        public decimal Ordatic0 { get; set; }
        [Column("RCPNOTC_0", TypeName = "numeric(27, 13)")]
        public decimal Rcpnotc0 { get; set; }
        [Column("RCPATIC_0", TypeName = "numeric(27, 13)")]
        public decimal Rcpatic0 { get; set; }
        [Column("BILAMTC_0", TypeName = "numeric(27, 13)")]
        public decimal Bilamtc0 { get; set; }
        [Column("BILAMTC_1", TypeName = "numeric(27, 13)")]
        public decimal Bilamtc1 { get; set; }
        [Column("BILAMTC_2", TypeName = "numeric(27, 13)")]
        public decimal Bilamtc2 { get; set; }
        [Column("BLCAMTC_0", TypeName = "numeric(27, 13)")]
        public decimal Blcamtc0 { get; set; }
        [Column("INVAMTC_0", TypeName = "numeric(27, 13)")]
        public decimal Invamtc0 { get; set; }
        [Column("ORDNOTL_0", TypeName = "numeric(27, 13)")]
        public decimal Ordnotl0 { get; set; }
        [Column("ORDATIL_0", TypeName = "numeric(27, 13)")]
        public decimal Ordatil0 { get; set; }
        [Column("RCPNOTL_0", TypeName = "numeric(27, 13)")]
        public decimal Rcpnotl0 { get; set; }
        [Column("RCPATIL_0", TypeName = "numeric(27, 13)")]
        public decimal Rcpatil0 { get; set; }
        [Column("BILAMTL_0", TypeName = "numeric(27, 13)")]
        public decimal Bilamtl0 { get; set; }
        [Column("BILAMTL_1", TypeName = "numeric(27, 13)")]
        public decimal Bilamtl1 { get; set; }
        [Column("BILAMTL_2", TypeName = "numeric(27, 13)")]
        public decimal Bilamtl2 { get; set; }
        [Column("BLCAMTL_0", TypeName = "numeric(27, 13)")]
        public decimal Blcamtl0 { get; set; }
        [Column("INVAMTL_0", TypeName = "numeric(27, 13)")]
        public decimal Invamtl0 { get; set; }
        [Column("ORDNOTR_0", TypeName = "numeric(27, 13)")]
        public decimal Ordnotr0 { get; set; }
        [Column("ORDATIR_0", TypeName = "numeric(27, 13)")]
        public decimal Ordatir0 { get; set; }
        [Column("RCPNOTR_0", TypeName = "numeric(27, 13)")]
        public decimal Rcpnotr0 { get; set; }
        [Column("RCPATIR_0", TypeName = "numeric(27, 13)")]
        public decimal Rcpatir0 { get; set; }
        [Column("BILAMTR_0", TypeName = "numeric(27, 13)")]
        public decimal Bilamtr0 { get; set; }
        [Column("BILAMTR_1", TypeName = "numeric(27, 13)")]
        public decimal Bilamtr1 { get; set; }
        [Column("BILAMTR_2", TypeName = "numeric(27, 13)")]
        public decimal Bilamtr2 { get; set; }
        [Column("BLCAMTR_0", TypeName = "numeric(27, 13)")]
        public decimal Blcamtr0 { get; set; }
        [Column("INVAMTR_0", TypeName = "numeric(27, 13)")]
        public decimal Invamtr0 { get; set; }
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