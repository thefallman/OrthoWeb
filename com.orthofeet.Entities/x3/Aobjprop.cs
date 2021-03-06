// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AOBJPROP", Schema = "TESTPROD")]
    [Index(nameof(Obj0), nameof(Num0), Name = "AOBJPROP_AOP0", IsUnique = true)]
    public partial class Aobjprop
    {
        [Required]
        [Column("OBJ_0")]
        [StringLength(3)]
        public string Obj0 { get; set; }
        [Column("NUM_0")]
        public short Num0 { get; set; }
        [Required]
        [Column("FRM_0")]
        [StringLength(250)]
        public string Frm0 { get; set; }
        [Column("NBRTBL_0")]
        public short Nbrtbl0 { get; set; }
        [Required]
        [Column("TBL_0")]
        [StringLength(12)]
        public string Tbl0 { get; set; }
        [Required]
        [Column("TBL_1")]
        [StringLength(12)]
        public string Tbl1 { get; set; }
        [Required]
        [Column("TBL_2")]
        [StringLength(12)]
        public string Tbl2 { get; set; }
        [Required]
        [Column("TBL_3")]
        [StringLength(12)]
        public string Tbl3 { get; set; }
        [Required]
        [Column("TBL_4")]
        [StringLength(12)]
        public string Tbl4 { get; set; }
        [Required]
        [Column("CLELNK_0")]
        [StringLength(12)]
        public string Clelnk0 { get; set; }
        [Required]
        [Column("CLELNK_1")]
        [StringLength(12)]
        public string Clelnk1 { get; set; }
        [Required]
        [Column("CLELNK_2")]
        [StringLength(12)]
        public string Clelnk2 { get; set; }
        [Required]
        [Column("CLELNK_3")]
        [StringLength(12)]
        public string Clelnk3 { get; set; }
        [Required]
        [Column("CLELNK_4")]
        [StringLength(12)]
        public string Clelnk4 { get; set; }
        [Required]
        [Column("LNK_0")]
        [StringLength(80)]
        public string Lnk0 { get; set; }
        [Required]
        [Column("LNK_1")]
        [StringLength(80)]
        public string Lnk1 { get; set; }
        [Required]
        [Column("LNK_2")]
        [StringLength(80)]
        public string Lnk2 { get; set; }
        [Required]
        [Column("LNK_3")]
        [StringLength(80)]
        public string Lnk3 { get; set; }
        [Required]
        [Column("LNK_4")]
        [StringLength(80)]
        public string Lnk4 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Column("UPDDAT_0", TypeName = "datetime")]
        public DateTime Upddat0 { get; set; }
        [Required]
        [Column("CREUSR_0")]
        [StringLength(5)]
        public string Creusr0 { get; set; }
        [Required]
        [Column("UPDUSR_0")]
        [StringLength(5)]
        public string Updusr0 { get; set; }
        [Column("CRETIM_0")]
        public int Cretim0 { get; set; }
        [Column("UPDTIM_0")]
        public int Updtim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}