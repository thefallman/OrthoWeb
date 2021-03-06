// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("MTCAUTO", Schema = "TESTPROD")]
    [Index(nameof(Num0), Name = "MTCAUTO_MTU0", IsUnique = true)]
    public partial class Mtcauto
    {
        [Column("NUM_0")]
        public int Num0 { get; set; }
        [Column("LEDTYP_0")]
        public byte Ledtyp0 { get; set; }
        [Column("ACCDAT_0", TypeName = "datetime")]
        public DateTime Accdat0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("COA_0")]
        [StringLength(3)]
        public string Coa0 { get; set; }
        [Required]
        [Column("ACC_0")]
        [StringLength(15)]
        public string Acc0 { get; set; }
        [Required]
        [Column("BPR_0")]
        [StringLength(15)]
        public string Bpr0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("AMTCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Amtcur0 { get; set; }
        [Required]
        [Column("CURLED_0")]
        [StringLength(3)]
        public string Curled0 { get; set; }
        [Column("AMTLED_0", TypeName = "numeric(27, 13)")]
        public decimal Amtled0 { get; set; }
        [Column("AMTAUT_0", TypeName = "numeric(27, 13)")]
        public decimal Amtaut0 { get; set; }
        [Column("AMTAUT_1", TypeName = "numeric(27, 13)")]
        public decimal Amtaut1 { get; set; }
        [Column("AMTAUT_2", TypeName = "numeric(27, 13)")]
        public decimal Amtaut2 { get; set; }
        [Column("AMTAUT_3", TypeName = "numeric(27, 13)")]
        public decimal Amtaut3 { get; set; }
        [Column("AMTAUT_4", TypeName = "numeric(27, 13)")]
        public decimal Amtaut4 { get; set; }
        [Column("AMTAUT_5", TypeName = "numeric(27, 13)")]
        public decimal Amtaut5 { get; set; }
        [Column("AMTAUT_6", TypeName = "numeric(27, 13)")]
        public decimal Amtaut6 { get; set; }
        [Column("AMTAUT_7", TypeName = "numeric(27, 13)")]
        public decimal Amtaut7 { get; set; }
        [Column("AMTAUT_8", TypeName = "numeric(27, 13)")]
        public decimal Amtaut8 { get; set; }
        [Column("AMTAUT_9", TypeName = "numeric(27, 13)")]
        public decimal Amtaut9 { get; set; }
        [Column("SNS_0")]
        public short Sns0 { get; set; }
        [Required]
        [Column("ACCMTC_0")]
        [StringLength(15)]
        public string Accmtc0 { get; set; }
        [Required]
        [Column("REFINT_0")]
        [StringLength(20)]
        public string Refint0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}