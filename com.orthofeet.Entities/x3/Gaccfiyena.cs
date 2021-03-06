// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GACCFIYENA", Schema = "TESTPROD")]
    [Index(nameof(Cur0), nameof(Cpy0), nameof(Ledtyp0), nameof(Fcy0), nameof(Grp0), nameof(Acc0), nameof(Bpr0), nameof(Lig0), nameof(Analig0), Name = "GACCFIYENA_FYA0", IsUnique = true)]
    [Index(nameof(Fcy0), nameof(Cpy0), nameof(Ledtyp0), nameof(Cur0), nameof(Grp0), nameof(Acc0), nameof(Bpr0), nameof(Lig0), nameof(Analig0), Name = "GACCFIYENA_FYA1", IsUnique = true)]
    public partial class Gaccfiyena
    {
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Column("LEDTYP_0")]
        public byte Ledtyp0 { get; set; }
        [Required]
        [Column("CPY_0")]
        [StringLength(5)]
        public string Cpy0 { get; set; }
        [Required]
        [Column("FCY_0")]
        [StringLength(5)]
        public string Fcy0 { get; set; }
        [Column("GRP_0")]
        public short Grp0 { get; set; }
        [Column("LIG_0")]
        public short Lig0 { get; set; }
        [Column("ANALIG_0")]
        public short Analig0 { get; set; }
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
        [Column("AMTCUR_0", TypeName = "numeric(27, 13)")]
        public decimal Amtcur0 { get; set; }
        [Column("AMTLOC_0", TypeName = "numeric(27, 13)")]
        public decimal Amtloc0 { get; set; }
        [Required]
        [Column("CURLED_0")]
        [StringLength(3)]
        public string Curled0 { get; set; }
        [Column("QTY_0", TypeName = "numeric(28, 13)")]
        public decimal Qty0 { get; set; }
        [Required]
        [Column("UOM_0")]
        [StringLength(3)]
        public string Uom0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}