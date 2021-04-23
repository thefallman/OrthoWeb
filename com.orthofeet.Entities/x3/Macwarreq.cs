﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("MACWARREQ", Schema = "TESTPROD")]
    [Index(nameof(Macnum0), Name = "MACWARREQ_MWR0")]
    public partial class Macwarreq
    {
        [Required]
        [Column("MACNUM_0")]
        [StringLength(20)]
        public string Macnum0 { get; set; }
        [Required]
        [Column("WRENUM_0")]
        [StringLength(20)]
        public string Wrenum0 { get; set; }
        [Column("CREDAT_0", TypeName = "datetime")]
        public DateTime Credat0 { get; set; }
        [Required]
        [Column("CONNUM_0")]
        [StringLength(20)]
        public string Connum0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}