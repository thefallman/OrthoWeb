// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("AWINBRO", Schema = "TESTPROD")]
    [Index(nameof(Win0), Name = "AWINBRO_AWB0", IsUnique = true)]
    public partial class Awinbro
    {
        [Required]
        [Column("WIN_0")]
        [StringLength(12)]
        public string Win0 { get; set; }
        [Required]
        [Column("OBJLIS_0")]
        [StringLength(3)]
        public string Objlis0 { get; set; }
        [Required]
        [Column("OBJLIS_1")]
        [StringLength(3)]
        public string Objlis1 { get; set; }
        [Required]
        [Column("OBJLIS_2")]
        [StringLength(3)]
        public string Objlis2 { get; set; }
        [Required]
        [Column("OBJLIS_3")]
        [StringLength(3)]
        public string Objlis3 { get; set; }
        [Required]
        [Column("OBJLIS_4")]
        [StringLength(3)]
        public string Objlis4 { get; set; }
        [Required]
        [Column("OBJLIS_5")]
        [StringLength(3)]
        public string Objlis5 { get; set; }
        [Required]
        [Column("OBJLIS_6")]
        [StringLength(3)]
        public string Objlis6 { get; set; }
        [Required]
        [Column("OBJLIS_7")]
        [StringLength(3)]
        public string Objlis7 { get; set; }
        [Required]
        [Column("OBJLIS_8")]
        [StringLength(3)]
        public string Objlis8 { get; set; }
        [Column("INTLIS_0")]
        public int Intlis0 { get; set; }
        [Column("INTLIS_1")]
        public int Intlis1 { get; set; }
        [Column("INTLIS_2")]
        public int Intlis2 { get; set; }
        [Column("INTLIS_3")]
        public int Intlis3 { get; set; }
        [Column("INTLIS_4")]
        public int Intlis4 { get; set; }
        [Column("INTLIS_5")]
        public int Intlis5 { get; set; }
        [Column("INTLIS_6")]
        public int Intlis6 { get; set; }
        [Column("INTLIS_7")]
        public int Intlis7 { get; set; }
        [Column("INTLIS_8")]
        public int Intlis8 { get; set; }
        [Required]
        [Column("CLELIS_0")]
        [StringLength(10)]
        public string Clelis0 { get; set; }
        [Required]
        [Column("CLELIS_1")]
        [StringLength(10)]
        public string Clelis1 { get; set; }
        [Required]
        [Column("CLELIS_2")]
        [StringLength(10)]
        public string Clelis2 { get; set; }
        [Required]
        [Column("CLELIS_3")]
        [StringLength(10)]
        public string Clelis3 { get; set; }
        [Required]
        [Column("CLELIS_4")]
        [StringLength(10)]
        public string Clelis4 { get; set; }
        [Required]
        [Column("CLELIS_5")]
        [StringLength(10)]
        public string Clelis5 { get; set; }
        [Required]
        [Column("CLELIS_6")]
        [StringLength(10)]
        public string Clelis6 { get; set; }
        [Required]
        [Column("CLELIS_7")]
        [StringLength(10)]
        public string Clelis7 { get; set; }
        [Required]
        [Column("CLELIS_8")]
        [StringLength(10)]
        public string Clelis8 { get; set; }
        [Column("ORDLIS_0")]
        public byte Ordlis0 { get; set; }
        [Column("ORDLIS_1")]
        public byte Ordlis1 { get; set; }
        [Column("ORDLIS_2")]
        public byte Ordlis2 { get; set; }
        [Column("ORDLIS_3")]
        public byte Ordlis3 { get; set; }
        [Column("ORDLIS_4")]
        public byte Ordlis4 { get; set; }
        [Column("ORDLIS_5")]
        public byte Ordlis5 { get; set; }
        [Column("ORDLIS_6")]
        public byte Ordlis6 { get; set; }
        [Column("ORDLIS_7")]
        public byte Ordlis7 { get; set; }
        [Column("ORDLIS_8")]
        public byte Ordlis8 { get; set; }
        [Column("TRELIS_0")]
        public byte Trelis0 { get; set; }
        [Column("TRELIS_1")]
        public byte Trelis1 { get; set; }
        [Column("TRELIS_2")]
        public byte Trelis2 { get; set; }
        [Column("TRELIS_3")]
        public byte Trelis3 { get; set; }
        [Column("TRELIS_4")]
        public byte Trelis4 { get; set; }
        [Column("TRELIS_5")]
        public byte Trelis5 { get; set; }
        [Column("TRELIS_6")]
        public byte Trelis6 { get; set; }
        [Column("TRELIS_7")]
        public byte Trelis7 { get; set; }
        [Column("TRELIS_8")]
        public byte Trelis8 { get; set; }
        [Column("BROLIS_0")]
        public byte Brolis0 { get; set; }
        [Column("BROLIS_1")]
        public byte Brolis1 { get; set; }
        [Column("BROLIS_2")]
        public byte Brolis2 { get; set; }
        [Column("BROLIS_3")]
        public byte Brolis3 { get; set; }
        [Column("BROLIS_4")]
        public byte Brolis4 { get; set; }
        [Column("BROLIS_5")]
        public byte Brolis5 { get; set; }
        [Column("BROLIS_6")]
        public byte Brolis6 { get; set; }
        [Column("BROLIS_7")]
        public byte Brolis7 { get; set; }
        [Column("BROLIS_8")]
        public byte Brolis8 { get; set; }
        [Column("CHGLIS_0")]
        public byte Chglis0 { get; set; }
        [Column("CHGLIS_1")]
        public byte Chglis1 { get; set; }
        [Column("CHGLIS_2")]
        public byte Chglis2 { get; set; }
        [Column("CHGLIS_3")]
        public byte Chglis3 { get; set; }
        [Column("CHGLIS_4")]
        public byte Chglis4 { get; set; }
        [Column("CHGLIS_5")]
        public byte Chglis5 { get; set; }
        [Column("CHGLIS_6")]
        public byte Chglis6 { get; set; }
        [Column("CHGLIS_7")]
        public byte Chglis7 { get; set; }
        [Column("CHGLIS_8")]
        public byte Chglis8 { get; set; }
        [Required]
        [Column("ABRLIS_0")]
        [StringLength(4)]
        public string Abrlis0 { get; set; }
        [Required]
        [Column("ABRLIS_1")]
        [StringLength(4)]
        public string Abrlis1 { get; set; }
        [Required]
        [Column("ABRLIS_2")]
        [StringLength(4)]
        public string Abrlis2 { get; set; }
        [Required]
        [Column("ABRLIS_3")]
        [StringLength(4)]
        public string Abrlis3 { get; set; }
        [Required]
        [Column("ABRLIS_4")]
        [StringLength(4)]
        public string Abrlis4 { get; set; }
        [Required]
        [Column("ABRLIS_5")]
        [StringLength(4)]
        public string Abrlis5 { get; set; }
        [Required]
        [Column("ABRLIS_6")]
        [StringLength(4)]
        public string Abrlis6 { get; set; }
        [Required]
        [Column("ABRLIS_7")]
        [StringLength(4)]
        public string Abrlis7 { get; set; }
        [Required]
        [Column("ABRLIS_8")]
        [StringLength(4)]
        public string Abrlis8 { get; set; }
        [Column("FLELIS_0")]
        public byte Flelis0 { get; set; }
        [Column("FLELIS_1")]
        public byte Flelis1 { get; set; }
        [Column("FLELIS_2")]
        public byte Flelis2 { get; set; }
        [Column("FLELIS_3")]
        public byte Flelis3 { get; set; }
        [Column("FLELIS_4")]
        public byte Flelis4 { get; set; }
        [Column("FLELIS_5")]
        public byte Flelis5 { get; set; }
        [Column("FLELIS_6")]
        public byte Flelis6 { get; set; }
        [Column("FLELIS_7")]
        public byte Flelis7 { get; set; }
        [Column("FLELIS_8")]
        public byte Flelis8 { get; set; }
        [Required]
        [Column("ACTLIS_0")]
        [StringLength(5)]
        public string Actlis0 { get; set; }
        [Required]
        [Column("ACTLIS_1")]
        [StringLength(5)]
        public string Actlis1 { get; set; }
        [Required]
        [Column("ACTLIS_2")]
        [StringLength(5)]
        public string Actlis2 { get; set; }
        [Required]
        [Column("ACTLIS_3")]
        [StringLength(5)]
        public string Actlis3 { get; set; }
        [Required]
        [Column("ACTLIS_4")]
        [StringLength(5)]
        public string Actlis4 { get; set; }
        [Required]
        [Column("ACTLIS_5")]
        [StringLength(5)]
        public string Actlis5 { get; set; }
        [Required]
        [Column("ACTLIS_6")]
        [StringLength(5)]
        public string Actlis6 { get; set; }
        [Required]
        [Column("ACTLIS_7")]
        [StringLength(5)]
        public string Actlis7 { get; set; }
        [Required]
        [Column("ACTLIS_8")]
        [StringLength(5)]
        public string Actlis8 { get; set; }
        [Required]
        [Column("EXPLIS_0")]
        [StringLength(60)]
        public string Explis0 { get; set; }
        [Required]
        [Column("EXPLIS_1")]
        [StringLength(60)]
        public string Explis1 { get; set; }
        [Required]
        [Column("EXPLIS_2")]
        [StringLength(60)]
        public string Explis2 { get; set; }
        [Required]
        [Column("EXPLIS_3")]
        [StringLength(60)]
        public string Explis3 { get; set; }
        [Required]
        [Column("EXPLIS_4")]
        [StringLength(60)]
        public string Explis4 { get; set; }
        [Required]
        [Column("EXPLIS_5")]
        [StringLength(60)]
        public string Explis5 { get; set; }
        [Required]
        [Column("EXPLIS_6")]
        [StringLength(60)]
        public string Explis6 { get; set; }
        [Required]
        [Column("EXPLIS_7")]
        [StringLength(60)]
        public string Explis7 { get; set; }
        [Required]
        [Column("EXPLIS_8")]
        [StringLength(60)]
        public string Explis8 { get; set; }
        [Column("ROWLIS_0")]
        public short Rowlis0 { get; set; }
        [Column("ROWLIS_1")]
        public short Rowlis1 { get; set; }
        [Column("ROWLIS_2")]
        public short Rowlis2 { get; set; }
        [Column("ROWLIS_3")]
        public short Rowlis3 { get; set; }
        [Column("ROWLIS_4")]
        public short Rowlis4 { get; set; }
        [Column("ROWLIS_5")]
        public short Rowlis5 { get; set; }
        [Column("ROWLIS_6")]
        public short Rowlis6 { get; set; }
        [Column("ROWLIS_7")]
        public short Rowlis7 { get; set; }
        [Column("ROWLIS_8")]
        public short Rowlis8 { get; set; }
        [Column("NBLIS_0")]
        public short Nblis0 { get; set; }
        [Column("DERLU_0")]
        public byte Derlu0 { get; set; }
        [Column("FIRLIS_0")]
        public byte Firlis0 { get; set; }
        [Column("AFLBRO_0")]
        public byte Aflbro0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}