// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace com.orthofeet.Entities
{
    [Table("GRPCUR", Schema = "TESTPROD")]
    [Index(nameof(Grp0), Name = "GRPCUR_GCU0", IsUnique = true)]
    public partial class Grpcur
    {
        [Required]
        [Column("GRP_0")]
        [StringLength(4)]
        public string Grp0 { get; set; }
        [Required]
        [Column("DES_0")]
        [StringLength(30)]
        public string Des0 { get; set; }
        [Required]
        [Column("DESSHO_0")]
        [StringLength(10)]
        public string Dessho0 { get; set; }
        [Column("NBRCUR_0")]
        public short Nbrcur0 { get; set; }
        [Required]
        [Column("CUR_0")]
        [StringLength(3)]
        public string Cur0 { get; set; }
        [Required]
        [Column("CUR_1")]
        [StringLength(3)]
        public string Cur1 { get; set; }
        [Required]
        [Column("CUR_2")]
        [StringLength(3)]
        public string Cur2 { get; set; }
        [Required]
        [Column("CUR_3")]
        [StringLength(3)]
        public string Cur3 { get; set; }
        [Required]
        [Column("CUR_4")]
        [StringLength(3)]
        public string Cur4 { get; set; }
        [Required]
        [Column("CUR_5")]
        [StringLength(3)]
        public string Cur5 { get; set; }
        [Required]
        [Column("CUR_6")]
        [StringLength(3)]
        public string Cur6 { get; set; }
        [Required]
        [Column("CUR_7")]
        [StringLength(3)]
        public string Cur7 { get; set; }
        [Required]
        [Column("CUR_8")]
        [StringLength(3)]
        public string Cur8 { get; set; }
        [Required]
        [Column("CUR_9")]
        [StringLength(3)]
        public string Cur9 { get; set; }
        [Required]
        [Column("CUR_10")]
        [StringLength(3)]
        public string Cur10 { get; set; }
        [Required]
        [Column("CUR_11")]
        [StringLength(3)]
        public string Cur11 { get; set; }
        [Required]
        [Column("CUR_12")]
        [StringLength(3)]
        public string Cur12 { get; set; }
        [Required]
        [Column("CUR_13")]
        [StringLength(3)]
        public string Cur13 { get; set; }
        [Required]
        [Column("CUR_14")]
        [StringLength(3)]
        public string Cur14 { get; set; }
        [Required]
        [Column("CUR_15")]
        [StringLength(3)]
        public string Cur15 { get; set; }
        [Required]
        [Column("CUR_16")]
        [StringLength(3)]
        public string Cur16 { get; set; }
        [Required]
        [Column("CUR_17")]
        [StringLength(3)]
        public string Cur17 { get; set; }
        [Required]
        [Column("CUR_18")]
        [StringLength(3)]
        public string Cur18 { get; set; }
        [Required]
        [Column("CUR_19")]
        [StringLength(3)]
        public string Cur19 { get; set; }
        [Required]
        [Column("CUR_20")]
        [StringLength(3)]
        public string Cur20 { get; set; }
        [Required]
        [Column("CUR_21")]
        [StringLength(3)]
        public string Cur21 { get; set; }
        [Required]
        [Column("CUR_22")]
        [StringLength(3)]
        public string Cur22 { get; set; }
        [Required]
        [Column("CUR_23")]
        [StringLength(3)]
        public string Cur23 { get; set; }
        [Required]
        [Column("CUR_24")]
        [StringLength(3)]
        public string Cur24 { get; set; }
        [Required]
        [Column("CUR_25")]
        [StringLength(3)]
        public string Cur25 { get; set; }
        [Required]
        [Column("CUR_26")]
        [StringLength(3)]
        public string Cur26 { get; set; }
        [Required]
        [Column("CUR_27")]
        [StringLength(3)]
        public string Cur27 { get; set; }
        [Required]
        [Column("CUR_28")]
        [StringLength(3)]
        public string Cur28 { get; set; }
        [Required]
        [Column("CUR_29")]
        [StringLength(3)]
        public string Cur29 { get; set; }
        [Key]
        [Column("ROWID")]
        public int Rowid { get; set; }
    }
}