﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("APLLCK", Schema = "TESTPROD")]
    [Index(nameof(Lcksym0), nameof(Lckind0), Name = "APLLCK_LCKCLE", IsUnique = true)]
    [Index(nameof(Lckpid0), nameof(Lckflg0), Name = "APLLCK_PIDFLG")]
    public partial class Apllck
    {
        [Required]
        [Column("LCKSYM_0")]
        [StringLength(50)]
        public string Lcksym0 { get; set; }
        [Column("LCKIND_0")]
        public short Lckind0 { get; set; }
        [Column("LCKPID_0")]
        public int Lckpid0 { get; set; }
        [Column("LCKFLG_0")]
        public byte Lckflg0 { get; set; }
        [Column("LCKDAT_0", TypeName = "datetime")]
        public DateTime Lckdat0 { get; set; }
        [Column("LCKTIM_0")]
        public int Lcktim0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}