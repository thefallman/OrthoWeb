﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("QUEUE", Schema = "TESTPROD")]
    [Index(nameof(Num0), Name = "QUEUE_QUE0", IsUnique = true)]
    public partial class Queue
    {
        [Required]
        [Column("NUM_0")]
        [StringLength(20)]
        public string Num0 { get; set; }
        [Required]
        [Column("TTR_0")]
        [StringLength(60)]
        public string Ttr0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(250)]
        public string Des0 { get; set; }
        [Required]
        [Column("TYPFULDES_0")]
        [StringLength(10)]
        public string Typfuldes0 { get; set; }
        [Required]
        [Column("NUMFULDES_0")]
        [StringLength(30)]
        public string Numfuldes0 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}