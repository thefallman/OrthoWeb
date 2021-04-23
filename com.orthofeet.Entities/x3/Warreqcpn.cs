﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("WARREQCPN", Schema = "TESTPROD")]
    [Index(nameof(Rqwnum0), nameof(Rqwnumlin0), Name = "WARREQCPN_RCW0", IsUnique = true)]
    public partial class Warreqcpn
    {
        [Required]
        [Column("RQWNUM_0")]
        [StringLength(20)]
        public string Rqwnum0 { get; set; }
        [Column("RQWNUMLIN_0")]
        public int Rqwnumlin0 { get; set; }
        [Required]
        [Column("ITMREF_0")]
        [StringLength(20)]
        public string Itmref0 { get; set; }
        [Column("QTY_0")]
        public int Qty0 { get; set; }
        [Required]
        [Column("MACSERNUM_0")]
        [StringLength(25)]
        public string Macsernum0 { get; set; }
        [Column("MACBPCDAT_0", TypeName = "datetime")]
        public DateTime Macbpcdat0 { get; set; }
        [Column("MACBPCPRI_0", TypeName = "numeric(27, 13)")]
        public decimal Macbpcpri0 { get; set; }
        [Required]
        [Column("MACBPCCUR_0")]
        [StringLength(3)]
        public string Macbpccur0 { get; set; }
        [Required]
        [Column("RSL_0")]
        [StringLength(15)]
        public string Rsl0 { get; set; }
        [Required]
        [Column("PLE_0")]
        [StringLength(250)]
        public string Ple0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}